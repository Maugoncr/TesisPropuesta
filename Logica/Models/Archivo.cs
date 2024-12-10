using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Archivo
    {

        public int IDImg { get; set; }
        public string Nombre { get; set; }
        public byte[] Documento { get; set; }
        public string Extension { get; set; }

        public int IDTipoArchivo { get; set; }

        public TipoArchivo MiTipo { get; set; }

        public Archivo()
        {
            MiTipo = new TipoArchivo();
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnnAdd = new Conexion();
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Documento", this.Documento));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Extension", this.Extension));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDTipoArchivo", this.MiTipo.IDTipoArchivo));


            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPArchivoAgregar");
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }


        public DataTable Listar(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPArchivoListar");

            return R;
        }

        public DataTable ArchivoPorID()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDImg));

            R = MiCnn.DMLSelect("SPArchivoPorID");

            return R;

        }


        public List<Archivo> FiltroArchivos()
        {

            var R =  ArchivoPorID();
            var infoDocumento = new List<Archivo>();

            foreach (DataRow item in R.Rows) 
            {
                infoDocumento.Add(new Archivo
                {
                    IDImg = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString()

                });
            
            }

            return infoDocumento;

        
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDTipoArchivo", this.MiTipo.IDTipoArchivo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDImg));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPArchivoEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }


        public Archivo ConsultarPorID(int ID)
        {
            Archivo R = new Archivo();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPArchivoPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDImg = ID;
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Documento = (byte[])Fila["Documento"];
                R.Extension = Convert.ToString(Fila["Extension"]);
                R.MiTipo.IDTipoArchivo = Convert.ToInt32(Fila["IDTipoArchivo"]);
                
            }
            return R;
        }


    }
}
