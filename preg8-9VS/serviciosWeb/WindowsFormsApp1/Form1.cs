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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string id = "";
        private string nombre = "";
        private string apellido = "";
        private string edad = "";
        private string dep = "";
        private string email = "";
        private string tel = "";

        public Form1()
        {
            InitializeComponent();
            mostrarDatos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDep.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = txtEdad.Text;
            dep = txtDep.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = txtEdad.Text;
            dep = txtDep.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;
            WS_crud.WS_crudSoapClient client = new WS_crud.WS_crudSoapClient();
            client.insertarDatos(nombre, apellido, edad, dep, email, tel);
            mostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = txtEdad.Text;
            dep = txtDep.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;
            WS_crud.WS_crudSoapClient cliente = new WS_crud.WS_crudSoapClient();
            cliente.actualizarDatos(id, nombre, apellido, edad, dep, email, tel);
            mostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            WS_crud.WS_crudSoapClient client = new WS_crud.WS_crudSoapClient();
            client.eliminarDatos(id);
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            try
            {
                MySqlConnection objConexion = new MySqlConnection();
                objConexion.ConnectionString = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";
                objConexion.Open();
                string query = "select * from persona";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                objConexion.Close();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDep.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar la tabla");
            }
        }
    }
}
