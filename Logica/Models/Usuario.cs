using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public int IDUser { get; set; }
        public string Cedula { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public int IDRolUser { get; set; }

        public string CodigoRecuperacion { get; set; }

        public string Code { get; set; }

        //Composicion 
        public UserRol MiRol { get; set; }

        public Usuario() 
        {
            MiRol = new UserRol();
        
        }

        public bool BuscarCodePermiso(int ID, string CodeS) 
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));
                
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Code", CodeS));

                DataTable Resultado = MyCnn.DMLSelect("SPUsuarioComprobarCodigoPermiso");

                if (Resultado != null && Resultado.Rows.Count > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }

        public bool CambiarPassword()
        {
            bool R = false;
            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));

                Crypto MiEncriptador = new Crypto();

                string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Password);

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

                int Resultado = MyCnn.DMLUpdateDeleteInsert("SPUsuarioActualizarContrasennia");

                if (Resultado > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return R;

        }



        public bool ComprobarCodigoRecuperacion()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));

                Crypto MiEncriptador = new Crypto();

                string CodeEncriptado = MiEncriptador.EncriptarEnUnSentido(this.CodigoRecuperacion);

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@CodigoVerif", CodeEncriptado));

                DataTable Resultado = MyCnn.DMLSelect("SPUsuarioComprobarCodigoVerificacion");

                if (Resultado != null && Resultado.Rows.Count > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return R;
        }

        public bool EnviarCodigoRecuperacion(string CodigoVerif)
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));

                Crypto MiEncriptador = new Crypto();

                string CodeEncriptado = MiEncriptador.EncriptarEnUnSentido(CodigoVerif);

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@CodigoVerif", CodeEncriptado));

                int Resultado = MyCnn.DMLUpdateDeleteInsert("SPUsuarioGuardarCodigoVerificacion");

                if (Resultado > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return R;

        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDUser));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioActivar");

            if (retorno == 1)
            {
                R = true;
            }

            return R;

        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDUser));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEliminar");

            if (retorno == 1)
            {
                R = true;
            }


            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.FullName));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));

            Crypto MiEncriptador = new Crypto();
            string PassEncriptado = string.Empty;

            if (!string.IsNullOrEmpty(this.Password))
            {
                PassEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Password);
            }
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", PassEncriptado));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdRol", this.MiRol.IDUserRol));
            if (!string.IsNullOrEmpty(this.Code))
            {
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Code", this.Code));
            }

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDUser));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public bool Agregar()
        {
            bool R = false;
            
            Conexion MiCnnAdd = new Conexion();
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FullName", this.FullName));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            //Encriptar Contraseña
            Crypto MiEncriptador = new Crypto();
            string PassEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Password);
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Password", PassEncriptado));
            // Debemos enviar el valor del ID del rol, usando la composicion de la clase UsuarioRol
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDRolUser", this.MiRol.IDUserRol));
            if (!string.IsNullOrEmpty(this.Code))
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Code", this.Code));
            }
            // 1.6.3 y 1.6.4
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPUsuarioAgregar");
            // 1.6.5
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public Usuario ValidarIngreso(string user, string password)
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();
            Crypto MiEncriptador = new Crypto();

            string PassEncriptado = MiEncriptador.EncriptarEnUnSentido(password);

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@user", user));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@pass", PassEncriptado));

            DataTable DatosUsuario = MiCnn.DMLSelect("SPUsuarioValidarIngreso");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];

                R.IDUser = Convert.ToInt32(Fila["ID"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.FullName = Convert.ToString(Fila["FullName"]);
                R.Email = Convert.ToString(Fila["Email"]);
                R.Password = string.Empty;
                R.MiRol.IDUserRol = Convert.ToInt32(Fila["IDRolUser"]);
                if (Fila["Code"] != DBNull.Value)
                {
                    R.Code = Convert.ToString(Fila["IDRolUser"]);
                }
               
            }
            return R;
        }


        public DataTable Listar(bool VerActivos, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPUsuariosListar");

            return R;
        }

        public DataTable ListarUsuariosAutorizados()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPUsuariosAutorizadosListar");

            return R;
        }



        public Usuario ConsultarPorID(int ID)
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPUsuarioConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDUser = ID;
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.FullName = Convert.ToString(Fila["FullName"]);
                R.Email = Convert.ToString(Fila["Email"]);
                //R.Contrasennia = string.Empty;
                //SE HIZO ESTE CAMBIO PARA QUE NO ENCRIPTE UNA CONTRASEÑA QUE NO SE DESEABA CAMBIAR
                R.Password = Convert.ToString(Fila["Password"]);
                R.MiRol.IDUserRol = Convert.ToInt32(Fila["IDRolUser"]);
                if (Fila["Code"] != DBNull.Value)
                {
                    R.Code = Convert.ToString(Fila["Code"]);
                }

            }
            return R;
        }

        public bool ConsultarPorCedula(string cedula)
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            // En este caso y de forma didactica se decidio implementar un parametro para la cedula
            // este valor debe agregarse como parametro que debe llegar hasta el SP
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Cedula", cedula));
         
            DataTable retorno = MiConexion.DMLSelect("SPUsuarioConsultarPorCedula");
          
            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            
            Conexion MiCnn = new Conexion();
            // Agregar el parametro que debe llevar con el valor del email a consultar
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            
            DataTable resultado = MiCnn.DMLSelect("SPUsuarioConsultarPorEmail");
           
            if (resultado != null && resultado.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }

        public UserRol TraerRolDelSistema(int IDUserRol)
        {
            UserRol R = new UserRol();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", IDUserRol));

            DataTable DatosUsuario = MiCnn.DMLSelect("SPUsuarioTraerRol");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];

                R.IDUserRol = Convert.ToInt32(Fila["IDUserRol"]);
                R.Descripcion = Convert.ToString(Fila["Descripcion"]);
                R.PAgregar = Convert.ToBoolean(Fila["PAgregar"]);
                R.PEditar = Convert.ToBoolean(Fila["PEditar"]);
                R.PEliminar = Convert.ToBoolean(Fila["PEliminar"]);
                R.PConsultar = Convert.ToBoolean(Fila["PConsultar"]);
                R.PReport = Convert.ToBoolean(Fila["PReport"]);
                R.IsAdmin = Convert.ToBoolean(Fila["IsAdmin"]);
                R.PChofer = Convert.ToBoolean(Fila["PChofer"]);
                R.PVehiculo = Convert.ToBoolean(Fila["PVehiculo"]);
                R.PMantenimiento = Convert.ToBoolean(Fila["PMantenimiento"]);
                R.PGasto = Convert.ToBoolean(Fila["PGasto"]);
                R.IsAutorizador = Convert.ToBoolean(Fila["IsAutorizador"]);
                R.POrdenCompra = Convert.ToBoolean(Fila["POrdenCompra"]);

            }
            return R;
        }

    }
}
