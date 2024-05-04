<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$id=$_GET['id'];
$sql = "select id_cuenta, tipo_cuenta, saldo from cuenta_bancaria c where c.id_persona = ".(int)$id;
$resultado = mysqli_query($con, $sql);
?>
<link rel="stylesheet" type="text/css" href="styles.css">
<table border="1px">
<tr>
	<th>ID cuenta</th>
	<th>Tipo cuenta</th>
	<th>Saldo</th>
</tr>
<?php
while ($fila=mysqli_fetch_array($resultado)){
	echo "<tr>";
	echo "<td>".$fila['id_cuenta']."</td>";
	echo "<td>".$fila['tipo_cuenta']."</td>";
	echo "<td>".$fila['saldo']."</td>";
	echo "</tr>";
}
?>
</table><br>