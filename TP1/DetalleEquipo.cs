using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class DetalleEquipo
    {
        public int CodDetalleEquipo { get; set; }
        public Reserva Reserva { get; set; }
        public Equipo Equipo { get; set; }
        public int Cantidad { get; set; }

        public DetalleEquipo() { }

        public DetalleEquipo(Reserva reserva, Equipo equipo, int cantidad) 
        {
            this.Reserva = reserva;
            this.Equipo = equipo;
            this.Cantidad = cantidad;
        }

        public bool Agregar()
        {
            //1-Agregamos el detalle.
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parámetro lo definido //en el archivo de configuración, que hace referencia a los parámetros
            //de conexión que le habríamos creado en App.Config
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "insert into DetalleEquipo (CodReserva, CodEquipo, Cantidad) values (@CodReserva, @CodEquipo, @Cantidad)";
                //creamos nuestra sentencia de inserción en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que //creamos y la conexión de donde nos traerá los datos
                //Dentro de nuestra sentencia definimos unos parámetros, que debemos crear y //asignar al comando. Esto lo hacemos:
                // 1-declarando el parámetro, 2- Definiendo el tipo de dato del parámetro que //se enviará y 3-añadiendo el parámetro al comando creado
                //aquí hacemos los pasos 1 y 2
                SqlParameter p1 = new SqlParameter("@IdIngreso", this.Reserva.CodReserva);
                p1.SqlDbType = SqlDbType.SmallInt;
                SqlParameter p2 = new SqlParameter("@Producto", this.Equipo.CodEquipo);
                p2.SqlDbType = SqlDbType.SmallInt;
                SqlParameter p3 = new SqlParameter("@Cantidad", this.Cantidad);
                p3.SqlDbType = SqlDbType.SmallInt;

                //Aquí hacemos el paso 3
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                //Una vez que nuestra sentencia esta completa, ejecutamos el comando //que ya tiene la conexión, la sentencia y los parámetros.
                cmd.ExecuteNonQuery();

                return true;
            }
        }

        public bool Editar()
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido //en el archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = "Update DetalleEquipo " +
                "set cantidad= @cantidad " +
                "where CodDetalleEquipo = @parametroId and CodReserva= @CodReserva and CodEquipo = @CodEquipo ";
                //creamos nuestra sentencia de actualización en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y //la conexión de donde nos traerá los datos
                //Dentro de nuestra sentencia definimos unos parámetros, que debemos crear y //asignar al comando. Esto lo hacemos:
                // 1-declarando el parámetro, 2- Definiendo el tipo de dato del parámetro que //se enviará y 3-añadiendo el parámetro al comando creado
                //aquí hacemos los pasos 1 y 2
                SqlParameter p1 = new SqlParameter("@cantidad", this.Cantidad);
                p1.SqlDbType = SqlDbType.Int;
                SqlParameter p2 = new SqlParameter("@parametroId", this.CodDetalleEquipo);
                p2.SqlDbType = SqlDbType.Int;
                SqlParameter p3 = new SqlParameter("@IdIngreso", this.Reserva.CodReserva);
                p2.SqlDbType = SqlDbType.Int;
                SqlParameter p4 = new SqlParameter("@IdProducto", this.Equipo.CodEquipo);
                p4.SqlDbType = SqlDbType.Int;

                //Aquí hacemos el paso 3
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                //Una vez que nuestra sentencia esta completa, ejecutamos el comando que ya //tiene la conexión, la sentencia y los parámetros.
                cmd.ExecuteNonQuery();

            }
            return true;

        }

        public bool Eliminar()
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            //Creamos nuestro objeto conexión y le pasamos como parametro lo definido //en el archivo de configuración, que hace referencia a los parametros
            //de conexión que le habríamos creado
            {
                con.Open();
                //abrimos nuestra conexión
                string sentenciaSql = " delete from detalleEquipo " +
                "where CodDetalleEquipo = @parametroId and CodReserva= @CodReserva and CodEquipo = @CodEquipo ";
                //creamos nuestra sentencia de actualización en un string.
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                //creamos un objeto comando sql, y le asignamos la sentencia sql que creamos y //la conexión de donde nos traerá los datos
                //Dentro de nuestra sentencia definimos unos parámetros, que debemos crear y //asignar al comando. Esto lo hacemos:
                // 1-declarando el parámetro, 2- Definiendo el tipo de dato del parámetro que //se enviará y 3-añadiendo el parámetro al comando creado
                //aquí hacemos los pasos 1 y 2

                SqlParameter p2 = new SqlParameter("@parametroId", this.CodDetalleEquipo);
                p2.SqlDbType = SqlDbType.Int;
                SqlParameter p3 = new SqlParameter("@IdIngreso", this.Reserva.CodReserva);
                p2.SqlDbType = SqlDbType.Int;
                SqlParameter p4 = new SqlParameter("@IdProducto", this.Equipo.CodEquipo);
                p4.SqlDbType = SqlDbType.Int;

                //Aquí hacemos el paso 3

                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                //Una vez que nuestra sentencia esta completa, ejecutamos el comando que ya //tiene la conexión, la sentencia y los parámetros.
                cmd.ExecuteNonQuery();

            }
            return true;

        }

        private int ObtenerId()
        {
            var rnd = new Random();
            return rnd.Next(1, 9999999);
        }

        public int ObtenerIndiceDetalleIngreso(List<DetalleEquipo> ListaDetalle)
        {
            return ListaDetalle.FindIndex(x => x.CodDetalleEquipo == this.CodDetalleEquipo && x.Reserva.CodReserva == this.Reserva.CodReserva);
        }

        public override string ToString()
        {
            return ($"Equipo: {this.Equipo.Descripcion} - Cantidad: {this.Cantidad}");
        }

    }
}
