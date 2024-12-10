using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBox;
using PracticaEmpresarial.Commons;
using Transitions;
using Logica.Models;
using System.Runtime.InteropServices;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmMainSystem : Form
    {
        private Vehiculo MiRTVProximo { get; set; }
        private DataTable ListaProxRTV { get; set; }
        private DataTable ListaMarchamos { get; set; }
        private DataTable ListaOilChange { get; set; }
        private Vehiculo MiMarchamoProx { get; set; }
        private Vehiculo MisCambiosOil { get; set; }
        private Vehiculo MisValidacionesVehiculo { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMainSystem()
        {
            
            InitializeComponent();
            customizeDesing();
            MiRTVProximo = new Vehiculo();
            ListaProxRTV = new DataTable();
            MiMarchamoProx = new Vehiculo();
            MisCambiosOil = new Vehiculo();
            ListaOilChange = new DataTable();
            ListaMarchamos = new DataTable();
            MisValidacionesVehiculo = new Vehiculo();
        }

        private void customizeDesing() 
        {
            panelSubMenuGestion.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
            panelSubMenu4.Visible = false;
            panelSubMenu5.Visible = false;
            panelSubMenu6.Visible = false;

        }

        private void hideSubMenu() 
        {
            if (panelSubMenuGestion.Visible == true)
            {
                panelSubMenuGestion.Visible = false;
            }
            if (panelSubMenu2.Visible ==true)
            {
                panelSubMenu2.Visible = false;
            }
            if (panelSubMenu3.Visible == true)
            {
                panelSubMenu3.Visible = false;
            }
            if (panelSubMenu4.Visible == true)
            {
                panelSubMenu4.Visible = false;
            }
            if (panelSubMenu5.Visible == true)
            {
                panelSubMenu5.Visible = false;
            }
            if (panelSubMenu6.Visible == true)
            {
                panelSubMenu6.Visible = false;
            }

        }

        private void ShowSubMenu(Panel subMenu) {


            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;    
            }
        
        
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public void Alert2(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 1);
        }

        public void Alert3(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 2);
        }


        private void FrmMainSystem_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbHora.Text = DateTime.Now.ToString("g");
            lblUserLog.Text = ObjetosGlobales.MiUsuarioDeSistema.FullName;
            checkAnio.Enabled = false;
            check6meses.Enabled = false;
            check1mes.Enabled = false;
            checkCoarsa.Enabled = false;
            checkCoarsa2.Enabled = false;
            checkArvaco.Enabled = false;
            checkArvaco2.Enabled = false;
            checkBoth.Enabled = false;
            checkCoarsa.Enabled = false;
            checkArvaco.Enabled = false;
            checkBoth2.Enabled = false;
            checkCoarsa2.Enabled = false;
            checkArvaco2.Enabled = false;


            LlenarProximoRTV(checkTodos);
            LlenarProximoOil(checkAll);
            LlenarProximoMarchamo();

            this.Alert("Ingreso Exitoso", Form_Alert.enmType.Success);
            AlertarSiHayCambiosOilPronto();

          

        }

        private void AlertarSiHayCambiosOilPronto() 
        {
            
                if (!MisValidacionesVehiculo.ConsultarHayCambiosOil() && !MisValidacionesVehiculo.ConsultarRTVEsteMes()
                    && !MisValidacionesVehiculo.ConsultarRTVVencido() && !MisValidacionesVehiculo.ConsultarHayCambiosOilVencidos())
                {
                    this.Alert("Excelente todo en orden", Form_Alert.enmType.Success);
                    AlertImg.Image.Dispose();
                    AlertImg.Image = Properties.Resources.AlertGood;
                }
              else
                {
                if (MisValidacionesVehiculo.ConsultarHayCambiosOil())
                {
                    this.Alert2("Cambios de Aceite este mes", Form_Alert.enmType.Warning);
                    AlertImg.Image.Dispose();
                    AlertImg.Image = Properties.Resources.AlertCuidado;
                }
                if (MisValidacionesVehiculo.ConsultarRTVEsteMes())
                {
                    this.Alert2("Vehiculos con RTV este mes", Form_Alert.enmType.Warning);
                    AlertImg.Image.Dispose();
                    AlertImg.Image = Properties.Resources.AlertCuidado;
                }
                if (MisValidacionesVehiculo.ConsultarRTVVencido())
                {
                    this.Alert3("Revision Técnica Atrasada", Form_Alert.enmType.Error);
                    AlertImg.Image.Dispose();
                    AlertImg.Image = Properties.Resources.AlertBad;
                }
                if (MisValidacionesVehiculo.ConsultarHayCambiosOilVencidos())
                {
                    this.Alert3("Cambio de Aceite Atrasado", Form_Alert.enmType.Error);
                    AlertImg.Image.Dispose();
                    AlertImg.Image = Properties.Resources.AlertBad;
                }
            }
                   
                
          
        }

        private void LlenarProximoMarchamo() 
        {

            ListaMarchamos = MiMarchamoProx.ListarMarchamos();

            DgvListaMarchamos.DataSource = ListaMarchamos;

            DgvListaMarchamos.ClearSelection();
        
        
        }
       

        private void LlenarProximoRTV(CheckBox check)
        {
            if (check.Name == "checkTodos")
            {
                if (checkBoth.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVs();

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else if (checkCoarsa.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Coarsa");

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Arvaco");

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
              
            }
            if (check.Name == "checkAnio")
            {

                if (checkBoth.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVs(365);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else if (checkCoarsa.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Coarsa",365);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Arvaco",365);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }

            }
            if (check.Name == "check6meses")
            {
                if (checkBoth.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVs(180);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else if (checkCoarsa.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Coarsa",180);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Arvaco",180);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }

            }
            if (check.Name == "check1mes")
            {
                if (checkBoth.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVs(30);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else if (checkCoarsa.Checked)
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Coarsa",30);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }
                else
                {
                    ListaProxRTV = MiRTVProximo.ListarRTVConFiltro("Arvaco",30);

                    DgvListaRTV.DataSource = ListaProxRTV;

                    DgvListaRTV.ClearSelection();
                }

            }
        }

        private void LlenarProximoOil(CheckBox check)
        {
            if (check.Name == "checkAll")
            {
                if (checkBoth2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOil();

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else if (checkCoarsa2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Coarsa");

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Arvaco");

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }

            }
            if (check.Name == "checkMes")
            {

                if (checkBoth2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOil(30);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else if (checkCoarsa2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Coarsa", 30);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Arvaco", 30);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }

            }
            if (check.Name == "check3Meses")
            {
                if (checkBoth2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOil(90);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else if (checkCoarsa2.Checked)
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Coarsa", 90);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }
                else
                {
                    ListaOilChange = MisCambiosOil.ListarOilConFiltro("Arvaco", 90);

                    DgvListaCambiosOil.DataSource = ListaOilChange;

                    DgvListaCambiosOil.ClearSelection();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("g");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            string message = "¿Estás seguro que deseas cerrar sesión?\n¿" + ObjetosGlobales.MiUsuarioDeSistema.FullName + "?";

            DialogResult Continuar = MessageBoxCustom.Show(message, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
            if (Continuar == DialogResult.Yes) {
                this.Close();
                ObjetosGlobales.GestionVehiculos.Close();
                ObjetosGlobales.GestionRolesUsuario.Close();
                ObjetosGlobales.GestionUsuarios.Close();
                ObjetosGlobales.FrmChoferes.Close();
                ObjetosGlobales.FormularioBitacora.Close();
                ObjetosGlobales.FrmLugares.Close();
                ObjetosGlobales.FrmTiposVehiculos.Close();
                ObjetosGlobales.FrmGastosVariados.Close();
                ObjetosGlobales.MiGestionMantenimientos.Close();
                ObjetosGlobales.MisCompanies.Close();


                ObjetosGlobales.MiLogin.Show();
                this.Alert("Cierre de Sesión Exitoso!", Form_Alert.enmType.Success);
            }

        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                ShowSubMenu(panelSubMenuGestion);
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


       
        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnUserRoles_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsersRols);

            if (frm == null)
            {
                ObjetosGlobales.GestionRolesUsuario = new FrmUsersRols();
                ObjetosGlobales.GestionRolesUsuario.Show();
            }
            else
            {
                frm.BringToFront();
                hideSubMenu();
                return;
            }
            hideSubMenu();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuarioGestion);

            if (frm == null)
            {
                ObjetosGlobales.GestionUsuarios = new FrmUsuarioGestion();
                ObjetosGlobales.GestionUsuarios.Show();
            }
            else
            {
                frm.BringToFront();
                hideSubMenu();
                return;
            }


            hideSubMenu();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                ShowSubMenu(panelSubMenu2);
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmBitacora);

            if (frm == null)
            {
                ObjetosGlobales.FormularioBitacora = new FrmBitacora();
                ObjetosGlobales.FormularioBitacora.Show();
            }
            else
            {
                frm.BringToFront();
                hideSubMenu();
                return;
            }
            hideSubMenu();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu3);
        }

        private void btnLugaresGestion_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmPlaces);

            if (frm == null)
            {
                ObjetosGlobales.FrmLugares = new FrmPlaces();
                ObjetosGlobales.FrmLugares.Show();
            }
            else
            {
                frm.BringToFront();
                hideSubMenu();
                return;
            }
            hideSubMenu();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin()||ObjetosGlobales.VerChofer())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionChoferes);

                if (frm == null)
                {
                    ObjetosGlobales.FrmChoferes = new FrmGestionChoferes();
                    ObjetosGlobales.FrmChoferes.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmTipoVehiculo);

                if (frm == null)
                {
                    ObjetosGlobales.FrmTiposVehiculos = new FrmTipoVehiculo();
                    ObjetosGlobales.FrmTiposVehiculos.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionVehiculos_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.VerVehiculo() || ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionVehiculos);

                if (frm == null)
                {
                    ObjetosGlobales.GestionVehiculos = new FrmGestionVehiculos();
                    ObjetosGlobales.GestionVehiculos.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                LlenarProximoRTV(checkTodos);
                checkAnio.Checked = false;
                checkAnio.Enabled = false;
                check6meses.Checked = false;
                check6meses.Enabled = false;
                check1mes.Checked = false;
                check1mes.Enabled = false;

                checkBoth.Enabled = false;
                checkCoarsa.Enabled = false;
                checkArvaco.Enabled = false;
            }
            else
            {
                checkAnio.Enabled = true;
                check6meses.Enabled = true;
                check1mes.Enabled = true;

                checkBoth.Enabled = true;
                checkCoarsa.Enabled = true;
                checkArvaco.Enabled = true;
            }


        }

        private void checkAnio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAnio.Checked)
            {
                LlenarProximoRTV(checkAnio);
                checkTodos.Checked = false;
                checkTodos.Enabled = false;
                check6meses.Checked = false;
                check6meses.Enabled = false;
                check1mes.Checked = false;
                check1mes.Enabled = false;

                checkBoth.Enabled = false;
                checkCoarsa.Enabled = false;
                checkArvaco.Enabled = false;
            }
            else
            {
                checkTodos.Enabled = true;
                check6meses.Enabled = true;
                check1mes.Enabled = true;

                checkBoth.Enabled = true;
                checkCoarsa.Enabled = true;
                checkArvaco.Enabled = true;
            }
        }

        private void check6meses_CheckedChanged(object sender, EventArgs e)
        {
            if (check6meses.Checked)
            {
                LlenarProximoRTV(check6meses);
                checkTodos.Checked = false;
                checkTodos.Enabled = false;
                checkAnio.Checked = false;
                checkAnio.Enabled = false;
                check1mes.Checked = false;
                check1mes.Enabled = false;


                checkBoth.Enabled = false;
                checkCoarsa.Enabled = false;
                checkArvaco.Enabled = false;
            }
            else
            {
                checkTodos.Enabled = true;
                checkAnio.Enabled = true;
                check1mes.Enabled = true;

                checkBoth.Enabled = true;
                checkCoarsa.Enabled = true;
                checkArvaco.Enabled = true;
            }
        }

        private void check1mes_CheckedChanged(object sender, EventArgs e)
        {
            if (check1mes.Checked)
            {
                LlenarProximoRTV(check1mes);
                checkTodos.Checked = false;
                checkTodos.Enabled = false;
                checkAnio.Checked = false;
                checkAnio.Enabled = false;
                check6meses.Checked = false;
                check6meses.Enabled = false;

                checkBoth.Enabled = false;
                checkCoarsa.Enabled = false;
                checkArvaco.Enabled = false;
            }
            else
            {
                checkTodos.Enabled = true;
                checkAnio.Enabled = true;
                check6meses.Enabled = true;

                checkBoth.Enabled = true;
                checkCoarsa.Enabled = true;
                checkArvaco.Enabled = true;
            }
        }

        private void btnRefrescar_MouseEnter(object sender, EventArgs e)
        {
            Transition.run(btnRefrescar, "BackColor", Color.FromArgb(42, 96, 148), new TransitionType_Linear(500));
        }

        private void btnRefrescar_MouseLeave(object sender, EventArgs e)
        {
            Transition.run(btnRefrescar, "BackColor", Color.FromArgb(59, 141, 220), new TransitionType_Linear(500));
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LlenarProximoMarchamo();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu4);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.VerGastos() || ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionGastosVarios);

                if (frm == null)
                {
                    ObjetosGlobales.FrmGastosVariados = new FrmGestionGastosVarios();
                    ObjetosGlobales.FrmGastosVariados.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       

        private void btnMante_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.VerMantenimiento())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionMantenimientos);

                if (frm == null)
                {
                    ObjetosGlobales.MiGestionMantenimientos = new FrmGestionMantenimientos();
                    ObjetosGlobales.MiGestionMantenimientos.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCompanies);

                if (frm == null)
                {
                    ObjetosGlobales.MisCompanies = new FrmCompanies();
                    ObjetosGlobales.MisCompanies.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void checkBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoth.Checked)
            {
                checkCoarsa.Checked = false;
                checkArvaco.Checked = false;
                checkArvaco.Enabled = false;
                checkCoarsa.Enabled = false;

                checkTodos.Enabled = true;
                checkAnio.Enabled = true;
                check6meses.Enabled = true;
                check1mes.Enabled = true;

            }
            else
            {
                checkCoarsa.Enabled = true;
                checkArvaco.Enabled = true;

                checkTodos.Checked = false;
                checkAnio.Checked = false;
                check6meses.Checked = false;
                check1mes.Checked = false;
                checkTodos.Enabled = false;
                checkAnio.Enabled = false;
                check6meses.Enabled = false;
                check1mes.Enabled = false;

            }

        }

        private void checkCoarsa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCoarsa.Checked)
            {
                checkBoth.Checked = false;
                checkArvaco.Checked = false;
                checkArvaco.Enabled = false;
                checkBoth.Enabled = false;

                checkTodos.Enabled = true;
                checkAnio.Enabled = true;
                check6meses.Enabled = true;
                check1mes.Enabled = true;

            }
            else
            {
                checkBoth.Enabled = true;
                checkArvaco.Enabled = true;

                checkTodos.Checked = false;
                checkAnio.Checked = false;
                check6meses.Checked = false;
                check1mes.Checked = false;
                checkTodos.Enabled = false;
                checkAnio.Enabled = false;
                check6meses.Enabled = false;
                check1mes.Enabled = false;

            }
        }

        private void checkArvaco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArvaco.Checked)
            {
                checkBoth.Checked = false;
                checkCoarsa.Checked = false;
                checkCoarsa.Enabled = false;
                checkBoth.Enabled = false;

                checkTodos.Enabled = true;
                checkAnio.Enabled = true;
                check6meses.Enabled = true;
                check1mes.Enabled = true;

            }
            else
            {
                checkBoth.Enabled = true;
                checkCoarsa.Enabled = true;

                checkTodos.Checked = false;
                checkAnio.Checked = false;
                check6meses.Checked = false;
                check1mes.Checked = false;
                checkTodos.Enabled = false;
                checkAnio.Enabled = false;
                check6meses.Enabled = false;
                check1mes.Enabled = false;

            }
        }

        private void btnRefrescar2_Click(object sender, EventArgs e)
        {
           // LlenarProximoMarchamo();
        }

        private void checkBoth2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoth2.Checked)
            {
                checkCoarsa2.Checked = false;
                checkArvaco2.Checked = false;
                checkArvaco2.Enabled = false;
                checkCoarsa2.Enabled = false;

                checkAll.Enabled = true;
                check3Meses.Enabled = true;
                checkMes.Enabled = true;

            }
            else
            {
                checkCoarsa2.Enabled = true;
                checkArvaco2.Enabled = true;

                check3Meses.Checked = false;
                checkMes.Checked = false;
                checkAll.Checked = false;
                checkAll.Enabled = false;
                checkMes.Enabled = false;
                check3Meses.Enabled = false;
                

            }
        }

        private void checkCoarsa2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCoarsa2.Checked)
            {
                checkBoth2.Checked = false;
                checkArvaco2.Checked = false;
                checkArvaco2.Enabled = false;
                checkBoth2.Enabled = false;

                checkAll.Enabled = true;
                check3Meses.Enabled = true;
                checkMes.Enabled = true;
            }
            else
            {
                checkBoth2.Enabled = true;
                checkArvaco2.Enabled = true;

                check3Meses.Checked = false;
                checkMes.Checked = false;
                checkAll.Checked = false;
                checkAll.Enabled = false;
                checkMes.Enabled = false;
                check3Meses.Enabled = false;
            }
        }

        private void checkArvaco2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArvaco2.Checked)
            {
                checkBoth2.Checked = false;
                checkCoarsa2.Checked = false;
                checkCoarsa2.Enabled = false;
                checkBoth2.Enabled = false;

                checkAll.Enabled = true;
                check3Meses.Enabled = true;
                checkMes.Enabled = true;
            }
            else
            {
                checkBoth2.Enabled = true;
                checkCoarsa2.Enabled = true;

                check3Meses.Checked = false;
                checkMes.Checked = false;
                checkAll.Checked = false;
                checkAll.Enabled = false;
                checkMes.Enabled = false;
                check3Meses.Enabled = false;
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                LlenarProximoOil(checkAll);
                checkMes.Checked = false;
                checkMes.Enabled = false;
                check3Meses.Checked = false;
                check3Meses.Enabled = false;

                checkBoth2.Enabled = false;
                checkCoarsa2.Enabled = false;
                checkArvaco2.Enabled = false;
            }
            else
            {
                checkMes.Enabled = true;
                check3Meses.Enabled = true;

                checkBoth2.Enabled = true;
                checkCoarsa2.Enabled = true;
                checkArvaco2.Enabled = true;
            }
        }

        private void check3Meses_CheckedChanged(object sender, EventArgs e)
        {
            if (check3Meses.Checked)
            {
                LlenarProximoOil(check3Meses);
                checkMes.Checked = false;
                checkMes.Enabled = false;
                checkAll.Checked = false;
                checkAll.Enabled = false;

                checkBoth2.Enabled = false;
                checkCoarsa2.Enabled = false;
                checkArvaco2.Enabled = false;
            }
            else
            {
                checkMes.Enabled = true;
                checkAll.Enabled = true;

                checkBoth2.Enabled = true;
                checkCoarsa2.Enabled = true;
                checkArvaco2.Enabled = true;
            }
        }

        private void checkMes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMes.Checked)
            {
                LlenarProximoOil(checkMes);
                checkAll.Checked = false;
                checkAll.Enabled = false;
                check3Meses.Checked = false;
                check3Meses.Enabled = false;

                checkBoth2.Enabled = false;
                checkCoarsa2.Enabled = false;
                checkArvaco2.Enabled = false;

            }
            else
            {
                checkAll.Enabled = true;
                check3Meses.Enabled = true;

                checkBoth2.Enabled = true;
                checkCoarsa2.Enabled = true;
                checkArvaco2.Enabled = true;
            }
        }

        private void btnTiposMantenimiento_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionTiposMantenimientos);

                if (frm == null)
                {
                    ObjetosGlobales.FrmTiposMantenimientos = new FrmGestionTiposMantenimientos();
                    ObjetosGlobales.FrmTiposMantenimientos.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DialogResult.Yes == MessageBoxCustom.Show("¿Tienes un administrador ayudandote?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    Form FormPermiso = new FrmDarPermiso();
                    DialogResult result = FormPermiso.ShowDialog();
                    if (result == DialogResult.OK && ObjetosGlobales.PermisoConcedidoRapido == true)
                    {
                        Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionTiposMantenimientos);
                        if (frm == null)
                        {
                            ObjetosGlobales.PermisoConcedidoRapido = false;
                            ObjetosGlobales.TrabajandoConPermiso = true;
                            ObjetosGlobales.FrmTiposMantenimientos = new FrmGestionTiposMantenimientos();
                            ObjetosGlobales.FrmTiposMantenimientos.ShowDialog();
                            this.Alert("Permiso Rapido Utilizado", Form_Alert.enmType.Success);
                        }
                        else
                        {
                            frm.BringToFront();
                            hideSubMenu();
                            return;
                        }
                        hideSubMenu();
                    }
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(pictureBox1, "Left", -400);
            t.add(pictureBox2, "Left", 18);
            t.run();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(pictureBox2, "Left", -400);
            t.add(pictureBox1, "Left", 6);
            t.run();
        }

        private void btnComprobarAlerta_Click(object sender, EventArgs e)
        {
           AlertarSiHayCambiosOilPronto();
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesReportes() || ObjetosGlobales.EresAdmin())
            {
                ShowSubMenu(panelSubMenu5);
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCrearReportes);

            if (frm == null)
            {
                ObjetosGlobales.CrearReportes = new FrmCrearReportes();
                ObjetosGlobales.CrearReportes.ShowDialog();
            }
            else
            {
                frm.BringToFront();
                hideSubMenu();
                return;
            }
            hideSubMenu();
        }

        private void panelTitleNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTipoArchivo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmTipoArchivos);

                if (frm == null)
                {
                    ObjetosGlobales.FrmTiposdeArchivos = new FrmTipoArchivos();
                    ObjetosGlobales.FrmTiposdeArchivos.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionArchivos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu6);
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmGestionArchivos);

                if (frm == null)
                {
                    FrmGestionArchivos.DesactivarSeleccion = true;
                    ObjetosGlobales.FrmGestionDeArchivos = new FrmGestionArchivos();
                    ObjetosGlobales.FrmGestionDeArchivos.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesOrdenesCompra())
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmOrdendeCompra);

                if (frm == null)
                {
                    ObjetosGlobales.FrmGestionOrdenesDeCompra = new FrmOrdendeCompra();
                    ObjetosGlobales.FrmGestionOrdenesDeCompra.Show();
                }
                else
                {
                    frm.BringToFront();
                    hideSubMenu();
                    return;
                }
                hideSubMenu();
            }
            else
            {
                MessageBoxCustom.Show("Acceso Denegado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
