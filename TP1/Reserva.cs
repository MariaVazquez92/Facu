using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Reserva
    {
        public int CodReserva { get; set; }
        public DateTime FechaSolicitud { get; set;}
        public DateTime FechaInicioReserva { get; set;}
        public DateTime FechaFinReserva { get; set;}
        public DateTime HorarioRetiro { get; set;}
        public DateTime HorarioDevolucion { get; set;}
        public DateTime HorarioDevolucionReal { get; set;}
        public string LugarUso { get; set;}
        public decimal CostoTotal { get; set;}
        public decimal CostoMulta { get; set;}
        public decimal PagoParcial { get; set;}
        public Estado Estado { get; set;}

        public List<DetalleEquipo> ListaDetalleEquipo { get; set; } = new List<DetalleEquipo>();
        public List<DetalleResponsable> DetalleResponsable { get; set; } = new List<DetalleResponsable>();
        private static List<Reserva> ListaReservas { get; set; } = new List<Reserva>();

        public Reserva()
        {
            
        }

        public void AgregarReserva()
        {
            //1-Agregamos el ingreso
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parámetro lo definido //en el archivo de configuración, que hace referencia a los parámetros
            //de conexión que le habríamos creado en App.Config
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "insert into Reserva ( FechaSolicitud, FechaInicioReserva, HorarioRetiro, " + 
                    " HorarioDevolucion, LugarUso, CostoTotal, PagoParcial, FechaFinReserva, CodEstado ) " +
                    " OUTPUT Inserted.Id values (@FechaSolicitud, @FechaInicioReserva, @HorarioRetiro, " +
                    " @HorarioDevolucion, @LugarUso, @CostoTotal, @PagoParcial, @FechaFinReserva, @CodEstado ) ";

                //creamos nuestra sentencia de inserción en un string.

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que //creamos y la conexión de donde nos traerá los datos
                //Dentro de nuestra sentencia definimos unos parámetros, que debemos crear y //asignar al comando. Esto lo hacemos:
                // 1-declarando el parámetro, 2- Definiendo el tipo de dato del parámetro que //se enviará y 3-añadiendo el parámetro al comando creado
                //aquí hacemos los pasos 1 y 2
                SqlParameter p1 = new SqlParameter("@FechaSolicitud", this.FechaSolicitud);
                p1.SqlDbType = SqlDbType.Date;
                SqlParameter p2 = new SqlParameter("@FechaInicioReserva", this.FechaInicioReserva);
                p2.SqlDbType = SqlDbType.Date;
                SqlParameter p3 = new SqlParameter("@HorarioRetiro", this.HorarioRetiro);
                p3.SqlDbType = SqlDbType.Time;
                SqlParameter p4 = new SqlParameter("@HorarioDevolucion", this.HorarioDevolucion);
                p4.SqlDbType = SqlDbType.Time;
                SqlParameter p5 = new SqlParameter("@LugarUso", this.LugarUso);
                p5.SqlDbType = SqlDbType.VarChar;
                SqlParameter p6 = new SqlParameter("@CostoTotal", this.CostoTotal);
                p6.SqlDbType = SqlDbType.Decimal;
                SqlParameter p7 = new SqlParameter("@PagoParcial", this.PagoParcial);
                p7.SqlDbType = SqlDbType.Decimal;
                SqlParameter p8 = new SqlParameter("@FechaFinReserva", this.FechaFinReserva);
                p8.SqlDbType = SqlDbType.Date;
                SqlParameter p9 = new SqlParameter("@CodEstado", this.Estado.CodEstado);
                p9.SqlDbType = SqlDbType.SmallInt;

                //Aquí hacemos el paso 3
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);

                int idNuevaReserva;
                //Una vez que nuestra sentencia esta completa, ejecutamos el comando //que ya tiene la conexión, la sentencia y los parámetros.
                idNuevaReserva = (int)cmd.ExecuteScalar();
                this.CodReserva = idNuevaReserva;
            }

            //Actualizamos nuestra lista. 
            ActualizarIngresoLista();

        }


        private int ObtenerId()
        {
            var rnd = new Random();
            return rnd.Next(1, 9999999);
        }

        public void AgregarDetalleEquipo(DetalleEquipo detalleEquipo)
        {
            detalleEquipo.Agregar();          
            ActualizarIngresoLista();
        }

        public void EliminarDetalleEquipo(DetalleEquipo detalleEquipo)
        {
            detalleEquipo.Eliminar();
            ActualizarDetalleIngresoLista(ObtenerDetalleIngresos());
        }

        public void EditarDetalleEquipo(DetalleEquipo detalleEquipo)
        {
            detalleEquipo.Editar();
            ActualizarDetalleIngresoLista(ObtenerDetalleIngresos());

        }

        public void AgregarDetalleResponsable(DetalleResponsable detalleResponsable)
        {
            detalleResponsable.Agregar();
            ActualizarIngresoLista();
        }

        public void EliminarDetalleResponsable(DetalleResponsable detalleResponsable)
        {
            detalleResponsable.Eliminar();
            ActualizarDetalleIngresoLista(ObtenerDetalleIngresos());
        }

        public void EditarDetalleResponsable(DetalleResponsable detalleResponsable)
        {
            detalleResponsable.Editar();
            ActualizarDetalleIngresoLista(ObtenerDetalleIngresos());

        }



        public static int ObtenerIndice(int Id)
        {
            if (ListaReservas.Count == 0) ActualizarIngresoLista();
            return ListaReservas.FindIndex(x => x.CodReserva == Id);
        }

        public static bool ValidarExistenciaIngreso(int Id)
        {
            if (ObtenerIndice(Id) >= 0)
            {
                return true;
            }
            return false;

        }

        public static Reserva ObtenerIngreso(int id)
        {
            //return ListaIngresos[ObtenerIndice(Id)];
            if (ListaReservas.Count == 0) ActualizarIngresoLista();
            var ingreso = new Reserva();
            ingreso = ListaReservas.Find(e => e.CodReserva == id);
            return ingreso;

        }

        public DataTable ObtenerDetalleIngresos()
        {

            // El using Delimita usar el objeto conexión "con" en el área de apertura y cierre de //la llave.
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido en el //archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "select p.Descripcion,di.Cantidad, DI.CodDetalleEquipo ,Di.CodReserva,Di.CodEquipo from DetalleEquipo DI join Reserva I on DI.CodReserva = I.CodReserva join Equipo P on P.CodEquipo = DI.CodEquipo where CodReserva = @Id";
                //creamos nuestra sentencia de selección en un string.

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y la //conexión de donde nos traerá los datos

                SqlParameter p1 = new SqlParameter("@Id", this.CodReserva);
                //Creo el parametro donde indico el id del ingreso

                cmd.Parameters.Add(p1);

                //Creamos un objeto adaptador de datos para obtener los datos de la BD
                SqlDataAdapter adaptadorDetalle = new SqlDataAdapter(cmd);

                //Creamos una tabla virtual de datos
                DataTable tablaDatos = new DataTable();

                //Rellenamos la tabla con los datos del adaptador
                adaptadorDetalle.Fill(tablaDatos);

                ActualizarDetalleIngresoLista(tablaDatos);

                return tablaDatos;

            }



        }

        private void ActualizarDetalleIngresoLista(DataTable tabladetalleingreso)
        {

            //Cargamos la lista mediante el datatable 

            ListaReservas.Clear();
            DetalleEquipo detalleEquipo;

            //recorro el datatable y adhiero los elementos a la lista
            foreach (DataRow fila in tabladetalleingreso.Rows)
            {
                detalleEquipo = new DetalleEquipo
                {
                    CodDetalleEquipo = Convert.ToInt32(fila[2].ToString()),
                    Reserva = Reserva.ObtenerIngreso(Convert.ToInt32(fila[3].ToString())),
                    Equipo = Equipo.ObtenerEquipoLista(Convert.ToInt32(fila[4].ToString())),
                    Cantidad = Convert.ToInt32(fila[1].ToString())
                };

                ListaDetalleIngreso.Add(detalleIngreso);

            }

        }



        public static void ActualizarIngresoLista()
        {
            ListaReservas.Clear();
            Reserva reserva;
            // El using Delimita usar el objeto conexión "con" en el área de apertura y cierre de //la llave.
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido en el //archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "select * from Reserva";
                //creamos nuestra sentencia de selección en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y la //conexión de donde nos traerá los datos
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                //Creamos nuestro lector, y en el comando que creamos ejecutamos el lector.
                //recorremos los items recuperados y los asignamos a nuestra lista. El método //Read(), nos retorna el valor a leer, por esto es que
                //mientras haya objetos que leer recorreremos el lector.
                while (lectorDatos.Read())
                {
                    //instaciamos un nuevo objeto persona, para que nos guarde en un espacio //de memoria x y le cargamos los datos.
                    reserva = new Reserva();
                    //Asignamos a cada campo del objeto la columna que correspone, usando el //metodo get, según el tipo de dato.
                    reserva.CodReserva = Convert.ToInt16(lectorDatos.GetInt32(0));

                    reserva.FechaSolicitud = lectorDatos.GetDateTime(1);

                    reserva.FechaInicioReserva = lectorDatos.GetDateTime(2);

                    reserva.HorarioRetiro = lectorDatos.GetDateTime(3);

                    reserva.HorarioDevolucion = lectorDatos.GetDateTime(4);

                    reserva.HorarioDevolucionReal = lectorDatos.GetDateTime(5);

                    reserva.LugarUso = lectorDatos.GetString(6);

                    reserva.CostoTotal = lectorDatos.GetDecimal(7);

                    reserva.CostoMulta = lectorDatos.GetDecimal(8);

                    reserva.PagoParcial = lectorDatos.GetDecimal(9);

                    reserva.Estado = Estado.ObtenerEstado(lectorDatos.GetInt32(10));

                    reserva.FechaFinReserva = lectorDatos.GetDateTime(11);


                    //añadimos el objeto cargado a la Lista.
                    ListaReservas.Add(reserva);
                }
            }

        }

        //public static bool VerificarEstadoAbierto(int Id)
        //{
        //    if (ValidarExistenciaIngreso(Id))
        //    {
        //        if (ListaReservas[ObtenerIndice(Id)].Estado == Estado.Abierto)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void ConfirmarIngreso()
        {
            foreach (var detalleIngreso in ListaDetalleEquipo)
            {
                detalleIngreso.Equipo.ModificarEstado(detalleIngreso);
            }
            ActualizarEstadoIngreso(int codEstado);
        }

        public bool ActualizarEstadoReserva(Estado estado)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido //en el archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "Update Reserva " +
                "set estado= @estado " +
                "where Id = @parametroId";
                //creamos nuestra sentencia de actualización en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y //la conexión de donde nos traerá los datos
                //Dentro de nuestra sentencia definimos unos parámetros, que debemos crear y //asignar al comando. Esto lo hacemos:
                // 1-declarando el parámetro, 2- Definiendo el tipo de dato del parámetro que //se enviará y 3-añadiendo el parámetro al comando creado
                //aquí hacemos los pasos 1 y 2
                SqlParameter p1 = new SqlParameter("@estado", ((int)estado));
                p1.SqlDbType = SqlDbType.NVarChar;
                SqlParameter p2 = new SqlParameter("@parametroId", this.CodReserva);
                p2.SqlDbType = SqlDbType.NVarChar;

                //Aquí hacemos el paso 3
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                //Una vez que nuestra sentencia esta completa, ejecutamos el comando que ya //tiene la conexión, la sentencia y los parámetros.
                cmd.ExecuteNonQuery();

            }
            return true;
        }


    }
}
