using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class CaracteristicaEquipos
    {
        public int CodCaracteristicaEquipo { set; get; }
        public Equipo Equipo { get; set; }
        public Caracteristica Caracteristica { get; set; }
        public string Detalle { get; set; }

        public static List<CaracteristicaEquipos> ListaCaracteristicaEquipos = new List<CaracteristicaEquipos>();

        public CaracteristicaEquipos()
        {

        }

        public static bool AgregarLista(CaracteristicaEquipos caracteristica)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                //abrimos la conexion
                con.Open();

                //indicamos en la sentencia que insertaremos en la tabla  producto los campos (columnas) nombre, costo, precio, fecha de vencimiento, refrigerado,
                //stock , categoria y el id de empleado cuyos valores (values) van a ser lo que definiremos como parámetros mediante el @
                string sentenciaSql = "insert into caracteristicaEquipo (codEquipo, codCaracteristica, detalle ) values (@CodEquipo, @CodCaracteristica, @detalle)";

                //creamos el comando con la sentencia
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                cmd = AsignarParametrosSinId(cmd, caracteristica);


                //ejecutamos la sentencia para que se inserte en la base de datos
                cmd.ExecuteNonQuery();
            }
            //actualizamos nuestra lista. 
            ActualizarListaCaracteristicaEquipo();
            return true;
        }
        private static SqlCommand AsignarParametrosSinId(SqlCommand cmd, CaracteristicaEquipos caracteristicaEquipos)
        {
            //Establecemos que será cada parametro y su tipo
            SqlParameter p1 = new SqlParameter("@CodEquipo", caracteristicaEquipos.Equipo.CodEquipo);
            p1.SqlDbType = SqlDbType.SmallInt;

            SqlParameter p2 = new SqlParameter("@CodCaracteristica", caracteristicaEquipos.Caracteristica.CodCaracteristica);
            p2.SqlDbType = SqlDbType.SmallInt;

            SqlParameter p3 = new SqlParameter("@detalle", caracteristicaEquipos.Detalle);
            p3.SqlDbType = SqlDbType.VarChar;

            //agregamos los parametros al comando
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            return cmd;
        }

        private static void ActualizarListaCaracteristicaEquipo()
        {
            //Vaciando la lista que queremos cargar
            ListaCaracteristicaEquipos.Clear();

            //creamos un objeto del tipo de la clase, que contendrá cada producto a ser agregado. 
            CaracteristicaEquipos caracteristicaEquipos;

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
                string sentenciaSql = "select * from caracteristicaEquipo";

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

                    caracteristicaEquipos = new CaracteristicaEquipos();
                    //Asignamos a cada campo del objeto la columna que correspone, usando el
                    //metodo get, según el tipo de dato.
                    caracteristicaEquipos.Caracteristica = Caracteristica.ObtenerCarac(lectorDatos.GetInt32(0));

                    caracteristicaEquipos.Equipo = Equipo.ObtenerEquipo(lectorDatos.GetInt32(1));

                    caracteristicaEquipos.Detalle = lectorDatos.GetString(2);

                    caracteristicaEquipos.CodCaracteristicaEquipo = lectorDatos.GetInt16(3);


                    ListaCaracteristicaEquipos.Add(caracteristicaEquipos);
                }

            }

        }

        public static bool EditarLista(CaracteristicaEquipos caracteristicaEquipos)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update CaracteristicaEquipo " +
                                     "set CodCaracteristica = @CodCaracteristica, " +
                                     "CodEquipo = @CodEquipo, " +
                                     "Detalle = @Detalle " +
                                     "where CodCaracteristicaEquipo = @Id";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                cmd = AsignarParametrosSinId(cmd, caracteristicaEquipos);

                SqlParameter p9 = new SqlParameter("@Id", caracteristicaEquipos.CodCaracteristicaEquipo);
                p9.SqlDbType = SqlDbType.SmallInt;
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery();

            }
            ActualizarListaCaracteristicaEquipo();
            return true;
        }

        public static bool EliminarLista(int id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sql = "DELETE FROM CaracteristicaEquipo where CodCaracteristicaEquipo = @Id";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter p9 = new SqlParameter("@Id", id);
                p9.SqlDbType = SqlDbType.SmallInt;
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery();
            }
            ActualizarListaCaracteristicaEquipo();
            return true;
        }

        public static List<CaracteristicaEquipos> ObtenerLista()
        {
            if (ListaCaracteristicaEquipos.Count == 0) ActualizarListaCaracteristicaEquipo();
            return ListaCaracteristicaEquipos;
        }

        public static CaracteristicaEquipos ObtenerCaracteristicaEquipos(int codCaracteristicaEquipos)
        {
            if (ListaCaracteristicaEquipos.Count == 0) ActualizarListaCaracteristicaEquipo();
            var caracteristiaEquipo = new CaracteristicaEquipos();
            caracteristiaEquipo = ListaCaracteristicaEquipos.Find(e => e.CodCaracteristicaEquipo == codCaracteristicaEquipos);
            return caracteristiaEquipo;
        }


    }
}
