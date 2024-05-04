<%@ Page Language="C#" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        string nombre = Request.QueryString["nombre"];
        string edad = Request.QueryString["edad"];
        Response.Write("Nombre: " + nombre + "<br/>Edad: " + edad);
    }
</script>
<html>
<head>
    <title>Recibir Datos GET</title>
</head>
<body>
    <h1>Datos Recibidos</h1>
</body>
</html>