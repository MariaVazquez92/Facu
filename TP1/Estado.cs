using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    class Estado
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
        public int CodEstado { get; set; }
        public string Descripcion { get; set; }
        private static List<Estado> ListaEstado = new List<Estado>();

        public Estado()
        {

        }

        public Estado(int codEstado, string descripcion)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.CodEstado = codEstado;
            this.Descripcion = descripcion;
        }
        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaEstado.FindIndex(x => x.Id == id);
            return indice;

        }
        public static bool AgregarEstado(Estado estado)
        {

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Ciudad(CodEstado,Descripcion" +
                    "values (@CodEstado,Descripcion))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codEstado", estado.CodEstado);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", estado.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool EditarEstado (Estado estado)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Estado " +
                                      "set CodEstado= @CodEstado, " +
                                      "Descripcion= @Descripcion, " +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codEstado", estado.CodEstado);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", estado.Descripcion);
                p2.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();
                ActualizarCiudadLista();



            }
            return true;
        }
        public static bool EliminarEstado(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Estado where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarEstadoLista();
            }
            return true;
        }
        public static List<Estado> ObtenerEstadoLista()
        {
            if (ListaEstado.Count == 0) ActualizarEstadoLista();

            return ListaEstado;
        }
        public static List<Alumno> ActualizarEstadoLista()
        {
            ListaEstado.Clear();
            Estado estado;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Estado";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    estado = new Estado();

                    estado.CodEstado = lectorDatos.GetInt32(0);
                    estado.Descripcion = lectorDatos.GetString(1);

                    ListaEstado.Add(estado);

                }

                return ListaEstado;
            }
        }
    }
}
