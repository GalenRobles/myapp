using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace myapp
{
    internal class Datos
    {
        SqlConnection conexion;
        String cadenaConexion = "Server=localhost,1434;Database=Agenda;User Id=sa;Password=L12345678.;TrustServerCertificate=True;";
        private void conexionOpen()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

            }catch(Exception ex)
            {
            Console.WriteLine("Error: "+ex.ToString());
            }
        }
        private void conexionClose()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public bool Insertar(string nombre, string paterno,string materno,string telefono,string correo)
        {
            try
            {
                conexionOpen();
                string comando = "INSERT INTO Datos(Nombre, Paterno, Materno, Telefono, Correo) VALUES ('" + nombre + "', '" + paterno + "', '" + materno + "', '" + telefono + "', '" + correo + "')";
                SqlCommand sqlCommand = new SqlCommand(comando, conexion);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }
        public DataSet Informacion(string comando)
        {
            DataSet ds= new DataSet();
            try
            {
                conexionOpen();
                SqlDataAdapter da = new SqlDataAdapter(comando, conexion);
                da.Fill(ds);
                conexion.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error"+ex.ToString());
                return null;
            }
        }
    }
}
