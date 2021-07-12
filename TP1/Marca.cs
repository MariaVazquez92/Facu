using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    class Marca
    {
        private short _id;
        public short Id
        {
            get { return _id; }
            set
            {

                if (ObtenerIndice(value) >= 0)
                {
                    _id = value;
                }
                else
                {
                    _id = Utilidades.ObtenerCodigo();
                }
            }
        }
        public int CodMarca{ get; set; }
        public string Descripcion { get; set; }
        private static List<Marca> ListaMarca = new List<Marca>();
        public Marca()
        {

        }

        public Marca(int codMarca, string descripcion)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.CodMarca = codMarca;
            this.Descripcion = descripcion;
        }
        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaMarca.FindIndex(x => x.Id == id);
            return indice;

        }
        public static bool AgregarMarca(Estado estado)
        {

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Marca(CodMarca,Descripcion" +
                    "values (@CodMarca,Descripcion))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codMarca", estado.CodEstado);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", estado.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool EditarMarca(Estado estado)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Marca " +
                                      "set codMarca= @CodMarca, " +
                                      "Descripcion= @Descripcion, " +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codMarca", estado.CodEstado);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", estado.Descripcion);
                p2.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();
                ActualizarMarcaLista();



            }
            return true;
        }
        public static bool EliminarMarca(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Marca where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarMarcaLista();
            }
            return true;
        }
        public static List<Marca> ObtenerMarcaLista()
        {
            if (ListaMarca.Count == 0) ActualizarMarcaLista();

            return ListaMarca;
        }
        public static List<Alumno> ActualizarMarcaLista()
        {
            ListaMarca.Clear();
            Marca marca;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Marca";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    marca = new Marca ();

                    marca.CodMarca= lectorDatos.GetInt32(0);
                    marca.Descripcion= lectorDatos.GetString(1);

                    ListaMarca.Add(marca);

                }

                return ListaMarca;
            }
        }
    }
}
