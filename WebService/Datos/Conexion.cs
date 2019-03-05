using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebService.Datos
{
    public class Conexion
    {
        string cadenaBD = "Data Source=CÉSAR-PC\\SQLEXPRESS;Initial Catalog=UsersBD;Integrated Security=True";

        public SqlConnection conexion = new SqlConnection();

        public Conexion() {

            conexion.ConnectionString = cadenaBD;
        }

        private void abrirConexion() {

            Console.WriteLine("haciendo conexion");

            try {

                conexion.Open();
                Console.WriteLine("conexion abierta");
            }
            catch (Exception ex) {

                Console.WriteLine("error al abrir la base de datos\n" + ex.Message);
            }

        }

        public void cerrar() {

            conexion.Close();
        }

        private void Insertar(Persona per) {

            //creamos un comando de sql
            SqlCommand command = new SqlCommand();

            //abrimos la conexion a la bd
            abrirConexion();
            //ejecutamos la consulta

            StringBuilder str = new StringBuilder();
            str.Append("insert into dbo.Persona (id,nombre,edoCivil) values");
            str.AppendFormat("({0},'{1}',{2})", per.Id, per.Nombre, 0);

            command.CommandText = str.ToString();

            command.CommandType = System.Data.CommandType.Text;

            command.Connection = conexion;

            command.ExecuteNonQuery();
            //hacemos la consulta
            //SqlDataAdapter info = new SqlDataAdapter(command);

            conexion.Close();
        }

        public void insertar(Persona per){

            Insertar(per);

        }

        private List<Persona> recibir() {

            //creamos un comando de sql
            SqlCommand command = new SqlCommand();

            //abrimos la conexion a la bd
            abrirConexion();
            //ejecutamos la consulta
            command.CommandText = "select * from dbo.Persona";

            command.CommandType = System.Data.CommandType.Text;

            command.Connection = conexion;
            //hacemos la consulta
            SqlDataAdapter info = new SqlDataAdapter(command);
            //creamos una tabla para guaradar el resultado
            DataTable table = new DataTable();
            //llenamos la tabla
            info.Fill(table);
            //cerramos la conexion
            cerrar();

            List<Persona> nombres = new List<Persona>();

            foreach (DataRow row in table.Rows) {

                int id = int.Parse(row["id"].ToString());
                string nm = row["nombre"].ToString();
                bool edo = false;//int.Parse(row["edoCivil"].ToString()) == 1;

                Persona nuevo = new Persona() {
                   Id = id,
                    Nombre = nm,
                    EdoCivil = edo
                };

                nombres.Add(nuevo); 
            }

            return nombres;
        }


        public string soloUnaPersona()
        {

            SqlCommand command = new SqlCommand();

            abrirConexion();

            command.CommandText = "select nombre from dbo.Persona where id = 1";

            command.CommandType = System.Data.CommandType.Text;

            command.Connection = conexion; 

            SqlDataAdapter info = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            info.Fill(table);

            DataRow row = table.Rows[0];


            // conexion.

            return row["nombre"].ToString();
        }

        public List<Persona> resultado_select() {

            return recibir();
        }


    }
}