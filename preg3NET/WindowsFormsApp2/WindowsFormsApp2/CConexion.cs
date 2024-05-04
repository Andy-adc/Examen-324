using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string cadenaConexion = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se conectó a la base de datos, error: " + e.ToString());
            }
            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
