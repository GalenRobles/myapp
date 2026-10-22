using System;
using System.Data.SqlClient;
using System.Data;

namespace myapp
{
    internal class ConexionDB
    {
        SqlConnection conexion;
        String cadenaConexion = "Server=localhost,1434;Database=Agenda;User Id=sa;Password=L12345678.;TrustServerCertificate=True;";

        private void conexionOpen()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
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

        public bool InsertarMasivo(DataTable dtData, string nombreTablaDestino)
        {
            try
            {
                conexionOpen();

                SqlBulkCopy bulk = new SqlBulkCopy(conexion);
                bulk.DestinationTableName = nombreTablaDestino;

                foreach (DataColumn column in dtData.Columns)
                {
                    bulk.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                }

                bulk.WriteToServer(dtData);
                bulk.Close();

                conexionClose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                conexionClose();
                return false;
            }
        }
    }
}