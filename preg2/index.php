<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$sql = "select * from persona";
$resultado = mysqli_query($con, $sql);
?>
<table border="1px">
<tr>
	<td>CI</td>
	<td>Nombre Completo</td>
	<td>Departamento</td>
	<td>Edad</td>
	<td>Email</td>
	<td>Telefono</td>
	<td>Cuentas</td>
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

<form action="anadirPersona.php">
	<input type="submit" name="anadir" value="Agregar persona">
</form>