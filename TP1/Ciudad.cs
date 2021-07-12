using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    class Ciudad
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
        public int CodCiudad { get; set; }
        public string Descripcion { get; set; }
        private static List<Ciudad> ListaCiudad = new List<Ciudad>();

        public Ciudad()
        {

        }

        public Ciudad(int codPais, string descripcion)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.CodCiudad = codPais;
            this.Descripcion = descripcion;
        }
        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaCiudad.FindIndex(x => x.Id == id);
            return indice;

        }
        public static bool AgregarCiudad(Ciudad ciudad)
        {

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Ciudad(CodCiudad,Descripcion" +
                    "values (@CodCiudad,Descripcion))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codCiudad", ciudad.CodCiudad);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", ciudad.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool EditarCiudad(Ciudad ciudad)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Ciudad " +
                                      "set CodCiudad= @CodCiudad, " +
                                      "Descripcion= @Descripcion, " +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codCiudad", ciudad.CodCiudad);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", ciudad.Descripcion);
                p2.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();
                ActualizarCiudadLista();



            }
            return true;
        }
        public static bool EliminarCiudad(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Ciudad where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarCiudadLista();
            }
            return true;
        }
        public static List<Pais> ObtenerCiudadLista()
        {
            if (ListaCiudad.Count == 0) ActualizarCiudadLista();

            return ListaCiudad;
        }
        public static List<Alumno> ActualizarCiudadLista()
        {
            ListaCiudad.Clear();
            Ciudad ciudad;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Ciudad";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    ciudad = new Ciudad();

                    ciudad.CodCiudad = lectorDatos.GetInt32(0);
                    ciudad.Descripcion = lectorDatos.GetString(1);

                    ListaCiudad.Add(ciudad);

                }

                return ListaCiudad;
            }
        }
    }
}
