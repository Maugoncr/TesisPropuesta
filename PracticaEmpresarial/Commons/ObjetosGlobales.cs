using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Commons
{
    public static class ObjetosGlobales
    {
        public static Logica.Models.Usuario MiUsuarioDeSistema = new Logica.Models.Usuario();
        public static Logica.Models.Usuario MiAdministradorPermiso = new Logica.Models.Usuario();
        public static Logica.Models.UserRol MiRolDeSistema = new Logica.Models.UserRol();
        public static Form MiLogin = new Forms.FrmLogin();
        public static Form MiFormPrincipal = new Forms.FrmMainSystem();
        public static Form GestionRolesUsuario = new Forms.FrmUsersRols();
        public static Form GestionUsuarios = new Forms.FrmUsuarioGestion();
        //Forms alertas
        public static Form VehiculosWarnings = new Forms.FrmRevisarWarnings();
        public static Form VehiculosRetrasos = new Forms.FrmRevisarRetrasos();

        //Forms Reportes
        public static Form CrearReportes = new Forms.FrmCrearReportes();
        
        public static Form GestionVehiculos = new Forms.FrmGestionVehiculos();
        public static Form FormularioBitacora = new Forms.FrmBitacora();
        public static Form FormularioRecuperacionContrasennia = new Forms.FrmRecuperarPassword();
        public static Form FrmLugares = new Forms.FrmPlaces();
        public static Form FrmChoferes = new Forms.FrmGestionChoferes();
        public static Form FrmTiposVehiculos = new Forms.FrmTipoVehiculo();
        public static Form FrmGastosVariados = new Forms.FrmGestionGastosVarios();
        public static Form MiGestionMantenimientos = new Forms.FrmGestionMantenimientos();
        public static Form MisCompanies = new Forms.FrmCompanies();
        public static Form FrmTiposMantenimientos = new Forms.FrmGestionTiposMantenimientos();
        public static Form FrmTiposdeArchivos = new Forms.FrmTipoArchivos();
        public static Form FrmGestionDeArchivos = new Forms.FrmGestionArchivos();
        public static Form FrmGestionOrdenesDeCompra = new Forms.FrmOrdendeCompra();

        //PERMISOS
        public static bool PermisoConcedidoRapido = false;
        public static bool TrabajandoConPermiso = false;


        public static bool EresAdmin()
        {
            bool R = false;
            if (MiRolDeSistema.IsAdmin)
            {
                R = true;
            }
            return R;
        }
        public static bool IsAutorizador()
        {
            bool R = false;
            if (MiRolDeSistema.IsAutorizador)
            {
                R = true;
            }
            return R;
        }

        public static bool PuedesOrdenesCompra()
        {
            bool R = false;
            if (MiRolDeSistema.POrdenCompra)
            {
                R = true;
            }
            return R;
        }

        public static bool PuedesAgregar()
        {
            bool R = false;
            if (MiRolDeSistema.PAgregar)
            {
                R = true;
            }
            return R;
        }
        public static bool PuedesEditar()
        {
            bool R = false;
            if (MiRolDeSistema.PEditar)
            {
                R = true;
            }
            return R;
        }
        public static bool PuedesEliminar()
        {
            bool R = false;
            if (MiRolDeSistema.PEliminar)
            {
                R = true;
            }
            return R;
        }
        public static bool PuedesConsultar()
        {
            bool R = false;
            if (MiRolDeSistema.PConsultar)
            {
                R = true;
            }
            return R;
        }
        public static bool PuedesReportes()
        {
            bool R = false;
            if (MiRolDeSistema.PReport)
            {
                R = true;
            }
            return R;
        }
        public static bool VerChofer()
        {
            bool R = false;
            if (MiRolDeSistema.PChofer)
            {
                R = true;
            }
            return R;
        }
        public static bool VerMantenimiento()
        {
            bool R = false;
            if (MiRolDeSistema.PMantenimiento)
            {
                R = true;
            }
            return R;
        }
        public static bool VerVehiculo()
        {
            bool R = false;
            if (MiRolDeSistema.PVehiculo)
            {
                R = true;
            }
            return R;
        }
        public static bool VerGastos()
        {
            bool R = false;
            if (MiRolDeSistema.PGasto)
            {
                R = true;
            }
            return R;
        }


        public static bool ValidarContrasennia(string pass)
        {
            bool mayuscula = false, minuscula = false, numeroImpar = false, caracterEspecial = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsUpper(pass, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(pass, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(pass, i))
                {
                    if (pass[i] % 2 == 1)
                    {
                        numeroImpar = true;
                    }
                }
                else
                {
                    caracterEspecial = true;
                }
            }
            if (mayuscula && minuscula && numeroImpar && caracterEspecial && pass.Length >= 8)
            {
                return true;
            }
            return false;
        }

        const string EmailRegex =
     @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
		[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
		[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public static bool ValidarEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, EmailRegex);
            }
            else
            { return false; }

        }


    }
}
