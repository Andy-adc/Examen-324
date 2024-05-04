using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de WS_crud
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WS_crud : System.Web.Services.WebService
{


    public WS_crud()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void eliminarDatos(string id)
    {
        try
        {
            MySqlConnection objConexion = new MySqlConnection();
            objConexion.ConnectionString = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";
            objConexion.Open();
            string query = "delete from persona where id_persona ="+id+";";
            MySqlCommand myComand = new MySqlCommand(query, objConexion);
            MySqlDataReader reader = myComand.ExecuteReader();

            while (reader.Read())
            {

            }
            objConexion.Close();
        }
        catch (Exception ex)
        {
            
        }
    }

    [WebMethod]
    public void insertarDatos(string nombre, string apellido, string edad, string coddep, string email, string telefono)
    {
        try
        {
            MySqlConnection objConexion = new MySqlConnection();
            objConexion.ConnectionString = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";
            objConexion.Open();
            string query = "insert into persona(nombre, apellido, edad, cod_dep, email, telefono) values" +
                "('"+nombre+"', '"+apellido+"', "+edad+", "+coddep+", '"+email+"', '"+telefono+"');";
            MySqlCommand myComand = new MySqlCommand(query, objConexion);
            MySqlDataReader reader = myComand.ExecuteReader();

            while (reader.Read())
            {

            }
            objConexion.Close();
        }
        catch (Exception ex)
        {

        }
    }

    [WebMethod]
    public void actualizarDatos(string id, string nombre, string apellido, string edad, string coddep, string email, string telefono)
    {
        try
        {
            MySqlConnection objConexion = new MySqlConnection();
            objConexion.ConnectionString = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";
            objConexion.Open();
            string query = "update persona set nombre='" + nombre + "', " +
                    "apellido='" + apellido + "', edad="+edad+", cod_dep="+coddep+", email='" + email + "', " +
                    "telefono='" + telefono + "' where id_persona=" + id + ";";
            MySqlCommand myComand = new MySqlCommand(query, objConexion);
            MySqlDataReader reader = myComand.ExecuteReader();

            while (reader.Read())
            {

            }
            objConexion.Close();
        }
        catch (Exception ex)
        {

        }
    }

    [WebMethod]
    public DataTable tablaDatos()
    {
        try
        {
            MySqlConnection objConexion = new MySqlConnection();
            objConexion.ConnectionString = "server=localhost; port=3306; user=root; password=Andy-2403; database=bdgustavo;";
            objConexion.Open();
            string query = "select p.id_persona, nombre, apellido, email, telefono, id_cuenta, tipo_cuenta, saldo from persona p, cuenta_bancaria c where p.id_persona = c.id_persona order by p.id_persona";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            objConexion.Close();
            return dt;
        }
        catch (Exception ex)
        {
            DataTable dt = null;
            return dt;
        }
    }
}
