<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$sql = "select * from persona";
$resultado = mysqli_query($con, $sql);
?>
<link rel="stylesheet" type="text/css" href="styles.css">
<table border="1px">
<tr>
	<th>CI</th>
	<th>Nombre Completo</th>
	<th>Departamento</th>
	<th>Edad</th>
	<th>Email</th>
	<th>Telefono</th>
	<th>Cuentas</th>
</tr>
<?php
while ($fila=mysqli_fetch_array($resultado)){
	echo "<tr>";
	echo "<td>".$fila['id_persona']."</td>";
	echo "<td>".$fila['nombre']." ".$fila['apellido']."</td>";
	echo "<td>".$fila['cod_dep']."</td>";
	echo "<td>".$fila['edad']."</td>";
	echo "<td>".$fila['email']."</td>";
	echo "<td>".$fila['telefono']."</td>";
	echo "<td>";
	echo "<a href='cuenta.php?id=".$fila['id_persona']."'>Ver cuentas</a><br>";
	echo "</td>";
	echo "</tr>";
}
?>
</table>