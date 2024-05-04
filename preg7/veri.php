<?php
$con = mysqli_connect("localhost", "user324", "Andy2403");
mysqli_select_db($con, "bdgustavo");
$usuario=$_GET["usuario"];
$contrasena=$_GET["contrasena"];
$sql = "select id_persona, rol from usuario where usuario='".$usuario."' and contrasena='".$contrasena."'";
$resultado = mysqli_query($con, $sql);
$fila = mysqli_fetch_array($resultado);
if ($fila["rol"]=='admin'){
	header("Location: admin.php");
	exit();
}
else {
	header("Location: cuenta.php?id=".(int)$fila["id_persona"]);
	exit();
}
?>