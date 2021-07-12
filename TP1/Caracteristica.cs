using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Caracteristica
    {
        public int CodCaracteristica { set; get; }
        public string Descripcion { get; set; }
        public int Camara { get; set; }

        public int Cable { get; set; }

        public int VideoHub { get; set; }

        public static List<Caracteristica> ListaCaracteristica = new List<Caracteristica>();

        public Caracteristica()
        {
            //Cuando trabajamos con la base de datos no hace falta asignar el id en el constructor
            //ya que dicho valor nos será devuelto al insertar en la base de datos, por lo que comentamos la linea de código. 
            //this.Id = ObtenerId();
        }

        public static bool AgregarLista(Caracteristica caracteristica)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                //abrimos la conexion
                con.Open();

                //indicamos en la sentencia que insertaremos en la tabla  producto los campos (columnas) nombre, costo, precio, fecha de vencimiento, refrigerado,
                //stock , categoria y el id de empleado cuyos valores (values) van a ser lo que definiremos como parámetros mediante el @
                string sentenciaSql = "insert into caracteristica (descripcion,camara,cable,videohub) values (@Descripcion, @camara, @cable, @videohub)";

                //creamos el comando con la sentencia
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                cmd = AsignarParametrosSinId(cmd, caracteristica);


                //ejecutamos la sentencia para que se inserte en la base de datos
                cmd.ExecuteNonQuery();


            }



            //actualizamos nuestra lista. 
            ActualizarCaracteristicaLista();
            return true;

        }

        private static SqlCommand AsignarParametrosSinId(SqlCommand cmd, Caracteristica caracteristica)
        {
            //Establecemos que será cada parametro y su tipo
            SqlParameter p1 = new SqlParameter("@Descripcion", caracteristica.Descripcion);
            p1.SqlDbType = SqlDbType.NVarChar;

            SqlParameter p2 = new SqlParameter("@camara", caracteristica.Camara);
            p2.SqlDbType = SqlDbType.TinyInt;

            SqlParameter p3 = new SqlParameter("@cable", caracteristica.Cable);
            p3.SqlDbType = SqlDbType.TinyInt;

            SqlParameter p4 = new SqlParameter("@videohub", caracteristica.VideoHub);
            p4.SqlDbType = SqlDbType.TinyInt;

            //agregamos los parametros al comando
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);


            return cmd;
        }

        private static void ActualizarCaracteristicaLista()
        {
            //Vaciando la lista que queremos cargar
            ListaCaracteristica.Clear();

            //creamos un objeto del tipo de la clase, que contendrá cada producto a ser agregado. 
            Caracteristica caracteristica;

            // El using Delimita usar el objeto conexión "con" en el área de apertura y cierre de
            //la llave.
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido en el
            //archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión

                //creamos nuestra sentencia de conexion
                string sentenciaSql = "select * from caracteristica";

                //creamos nuestra sentencia de selección en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y la
                //conexión de donde nos traerá los datos

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                //Creamos nuestro lector, y en el comando que creamos ejecutamos el lector. 
                //recorremos los items recuperados y los asiganmos a nuestra lista. El metodo
                //Read(), nos retorna el valor a leer, por esto es que
                //mientras haya objetos que leer recorreremos el lector.
                while (lectorDatos.Read())
                {
                    //instaciamos un nuevo objeto persona, para que nos guarde en un espacio
                    //de memoria x y le cargamos los datos.

                    caracteristica = new Caracteristica();
                    //Asignamos a cada campo del objeto la columna que correspone, usando el
                    //metodo get, según el tipo de dato.
                    caracteristica.CodCaracteristica = lectorDatos.GetInt32(0);
                    caracteristica.Descripcion = lectorDatos.GetString(1);
                    caracteristica.Cable = lectorDatos.GetInt16(2);
                    caracteristica.Camara = lectorDatos.GetInt16(3);
                    caracteristica.VideoHub = lectorDatos.GetInt16(4);                   

                    //añadimos el objeto cargado a la Lista
                    ListaCaracteristica.Add(caracteristica);
                }
            }
        }
        public static bool EditarLista(Caracteristica caracteristica)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Caracteristica " +
                                     "set Descripcion = @Descripcion, " +
                                     "Cable = @Cable, " +
                                     "Camara = @Camara, " +
                                     "VideoHub = @VideoHub " +
                                     "where CodCaracteristica = @Id";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                cmd = AsignarParametrosSinId(cmd, caracteristica);

                SqlParameter p9 = new SqlParameter("@Id", caracteristica.CodCaracteristica);
                p9.SqlDbType = SqlDbType.SmallInt;
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery();

            }
            ActualizarCaracteristicaLista();
            return true;
        }

        public static bool EliminarLista(int id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sql = "DELETE FROM Caracteristica where CodCaracteristica = @Id";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter p9 = new SqlParameter("@Id", id);
                p9.SqlDbType = SqlDbType.SmallInt;
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery();
            }
            ActualizarCaracteristicaLista();
            return true;
        }

        public static List<Caracteristica> ObtenerLista()
        {
            if (ListaCaracteristica.Count == 0) ActualizarCaracteristicaLista();
            return ListaCaracteristica;
        }

        public static Caracteristica ObtenerCaracteristica(int id)
        {
            if (ListaCaracteristica.Count == 0) ActualizarCaracteristicaLista();
            var caracteristica = new Caracteristica();
            caracteristica = ListaCaracteristica.Find(e => e.CodCaracteristica == id);
            return caracteristica;
        }

        public static Caracteristica ObtenerCarac(int CodCaracteristica)
        {
            if (ListaCaracteristica.Count == 00) ObtenerLista();

            Caracteristica caracteristica = ListaCaracteristica.Find(emp => emp.CodCaracteristica == CodCaracteristica);

            return caracteristica;
        }



    }
}
