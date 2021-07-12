using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Equipo
    {
        
        public int CodEquipo { get; set; }

        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaAdq { get; set; }
        public decimal CostoGs { get; set; }
        public Sala Sala { get; set; }
        public decimal Precio { get; set; }
        
        public int Extraible { get; set; }

        private static List<CaracteristicaEquipos> ListaCaracteristicaEquipos = new List<CaracteristicaEquipos>();

        private static List<Equipo> ListaEquipo = new List<Equipo>();


        public Equipo()
        {

        }

        public Equipo(string descripcion,int codMarca,DateTime fechaAdq, decimal costoGs, Sala codSala,decimal Precio, Estado estado)
        {
            this._id = Utilidades.ObtenerCodigo();
           
            this.Descripcion = descripcion;
            this.Marca = codMarca;
            this.FechaAdq = fechaAdq;
            this.CostoGs = costoGs;
            this.Sala = codSala;
            this.Precio = Precio;
            this.Estado = estado;
        }
        public static Equipo ObtenerEquipo(int id)
        {
            if (ListaEquipo.Count == 0) ActualizarEquipoLista();
            var equipo = new Equipo();
            equipo = ListaEquipo.Find(e => e.CodEquipo == id);
            return equipo;
        }

        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaEquipo.FindIndex(x => x.CodEquipo == id);
            return indice;

        }

        public void AgregarEquipo()
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Equipo(CodEquipo,Descripcion,CodMarca,FechaAdquisicion, " +
                    " CostoGs, CodSala, Precio, Extraible, CodEstado) " +
                    " values (@CodEquipo,@Descripcion,@CodMarca,@FechaAdquisicion " +
                    " @CostoGs,@CodSala,@Precio, @Extraible, @CodEstado) ";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@CodEquipo", this.CodEquipo);
                p1.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p2 = new SqlParameter("@Descripcion", this.Descripcion);
                p2.SqlDbType = SqlDbType.VarChar;

                SqlParameter p3 = new SqlParameter("@CodMarca", this.Marca.CodMarca);
                p3.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p4 = new SqlParameter("@FechaAdquisicion", this.FechaAdq);
                p4.SqlDbType = SqlDbType.Date;

                SqlParameter p5 = new SqlParameter("@CostoGs", this.CostoGs);
                p5.SqlDbType = SqlDbType.Decimal;

                SqlParameter p6 = new SqlParameter("@CodSala", this.Sala.CodSala);
                p6.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p7 = new SqlParameter("@CodEstado", this.Estado.CodEstado);
                p7.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p8 = new SqlParameter("@Extraible", this.Extraible);
                p8.SqlDbType = SqlDbType.TinyInt;

                SqlParameter p9 = new SqlParameter("@Precio", this.Precio);
                p9.SqlDbType = SqlDbType.Decimal;


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);

                int idNuevoEquipo;
                //Una vez que nuestra sentencia esta completa, ejecutamos el comando //que ya tiene la conexión, la sentencia y los parámetros.
                idNuevoEquipo = (int)cmd.ExecuteScalar();
                this.CodEquipo = idNuevoEquipo;
            }

            //Actualizamos nuestra lista. 
            ActualizarEquipoLista();
        }

        public static bool EditarEquipo(Equipo equipo)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Equipo " +
                                      "set  CodEquipo = @CodEquipo ," +
                                      "Descripcion = @Descripcion," +
                                      "CodMarca = @CodMarca," +
                                      "FechaAdquisicion = @FechaAdq" +
                                      "CostoGs = @CostoGs," +
                                      "CodSala = @CodSala," +
                                      "Precio = @CodPrecio," +
                                      "CodEstado = @CodEstado" +
                                      "Extraible = @Extraible" +
                                      "where CodEquipo = @Id";
                
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
               
                SqlParameter p1 = new SqlParameter("@CodEquipo", equipo.CodEquipo);
                p1.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p2 = new SqlParameter("@Descripcion", equipo.Descripcion);
                p2.SqlDbType = SqlDbType.VarChar;

                SqlParameter p3 = new SqlParameter("@CodMarca", equipo.CodMarca);
                p3.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p4 = new SqlParameter("@FechaAdq", equipo.FechaAdq);
                p4.SqlDbType = SqlDbType.Date;

                SqlParameter p5 = new SqlParameter("@CostoGs", equipo.CostoGs);
                p5.SqlDbType = SqlDbType.Decimal;

                SqlParameter p6 = new SqlParameter("@CodSala", equipo.CodSala);
                p6.SqlDbType = SqlDbType.SmallInt;

                SqlParameter p7 = new SqlParameter("@CodEstado", equipo.Estado.CodEstado);
                p7.SqlDbType = SqlDbType.SmallInt;



                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();
                


                ActualizarEquipoLista();



            }
            return true;
        }
        public static bool EliminarEquipo(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "DELETE FROM Equipo where CodEquipo  = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.SmallInt;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarEquipoLista();

            }
            return true;
        }
        public static List<Equipo> ObtenerEquipoLista()
        {
            if (ListaEquipo.Count == 0) ActualizarEquipoLista();

            return ListaEquipo;
        }
        public static List<Equipo> ActualizarEquipoLista()
        {
            ListaEquipo.Clear();
            Equipo equipo;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Equipo";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    equipo = new Equipo();

                    equipo.CodEquipo = Convert.ToInt16(lectorDatos.GetInt32(0));
                    equipo.Descripcion = lectorDatos.GetString(1);
                    equipo.Marca = Marca.ObtenerMarca(lectorDatos.GetInt32(6));
                    equipo.FechaAdq = lectorDatos.GetDateTime(3);
                    equipo.CostoGs = lectorDatos.GetDecimal(4);
                    equipo.Sala = Sala.ObtenerSala(lectorDatos.GetInt32(5));
                    equipo.Precio = lectorDatos.GetDecimal(6);
                    equipo.Extraible = lectorDatos.GetInt16(7);
                    equipo.Estado = Estado.ObtenerEstado(lectorDatos.GetInt32(8));

                    ListaEquipo.Add(equipo);

                }

             
            }

            
        }
        
    }
}
