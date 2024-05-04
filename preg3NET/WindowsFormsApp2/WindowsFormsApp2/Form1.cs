using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private CConexion objConexion = new CConexion();
        private string connectionString = "server=localhost;database=bdgustavo;user=user324;password=user324;";
        public Form1()
        {
            InitializeComponent();
            mostrarTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CConexion objetoConexion = new CConexion();
            objetoConexion.establecerConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string idcuenta = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string query = "update persona set nombre='" + txtNombre.Text + "', " +
                    "apellido='" + txtApellido.Text + "', email='" + txtEmail.Text + "', " +
                    "telefono='" + txtTel.Text + "' where id_persona=" + id + ";" +
                    "update cuenta_bancaria set tipo_cuenta='" + txtCuenta.Text + "', " +
                    "saldo =" + txtSaldo.Text + " where id_cuenta=" + idcuenta;
                MySqlCommand myComand = new MySqlCommand(query, objConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();

                while (reader.Read())
                {

                }
                objConexion.cerrarConexion();
                mostrarTabla();

                MessageBox.Show("Se modifico los registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar la tabla");
            }
        }
        public void mostrarTabla()
        {
            try
            {
                string query = "select p.id_persona, nombre, apellido, email, telefono, id_cuenta, tipo_cuenta, saldo from persona p, cuenta_bancaria c where p.id_persona = c.id_persona order by p.id_persona";
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                objConexion.cerrarConexion();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
                txtCuenta.Text = "";
                txtSaldo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar la tabla");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string idcuenta = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCuenta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtSaldo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar la tabla");
            }
        }
        /*
private void CargarDatosPersona()
{
// Crear la conexión MySQL
using (MySqlConnection connection = new MySqlConnection(connectionString))
{
// Crear el comando SQL para seleccionar todos los datos de la tabla personas
string sql = "SELECT * FROM persona";

// Crear el adaptador de datos MySQL y el DataSet
MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
DataSet dataSet = new DataSet();

try
{
// Abrir la conexión
connection.Open();

// Llenar el DataSet con los datos de la tabla prsonas
adapter.Fill(dataSet, "usuarios");

// Asignar el DataSet como origen de datos del datosTabla
datosTabla.DataSource = dataSet.Tables["usuarios"];
}
catch (MySqlException ex)
{
// Capturar y mostrar cualquier error que ocurra durante la conexión o al cargar los datos
MessageBox.Show("Error al cargar los datos de la tabla usuarios: " + ex.Message);
}
}
}*/
    }
}
