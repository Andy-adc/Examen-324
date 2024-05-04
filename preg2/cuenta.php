<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$id=$_GET['id'];
$sql = "select id_cuenta, tipo_cuenta, saldo from cuenta_bancaria c where c.id_persona = ".(int)$id;
$resultado = mysqli_query($con, $sql);
?>
<table border="1px">
<tr>
	<td>ID cuenta</td>
	<td>Tipo cuenta</td>
	<td>Saldo</td>
	<td>Operación</td>
</tr>
<?php
while ($fila=mysqli_fetch_array($resultado)){
	echo "<tr>";
	echo "<td>".$fila['id_cuenta']."</td>";
	echo "<td>".$fila['tipo_cuenta']."</td>";
	echo "<td>".$fila['saldo']."</td>";
	echo "<td>";
	echo "<a href='editarcuenta.php?id=".$fila['id_cuenta']."&idpersona=".$id."'>Editar</a><br>";
	echo "<a href='eliminarcuenta.php?id=".$fila['id_cuenta']."&idpersona=".$id."'>Eliminar</a>";
	echo "</td>";
	echo "</tr>";
}
?>
</table><br>


<form method="GET" action="anadircuenta.php">
	<input type="hidden" name="id" value="<?php echo $id;?>">
	
	<input type="submit" name="Añadir" value="Añadir cuenta" />
</form><br>
<a href="index.php">Regresar a personas</a>