<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$sql = "select p.id_persona, nombre, apellido, tipo_cuenta from persona p, cuenta_bancaria c where p.id_persona = c.id_persona order by p.id_persona";
$resultado = mysqli_query($con, $sql);
?>
<link rel="stylesheet" type="text/css" href="styles.css">
<table border="1px">
<tr>
	<th>CI</th>
	<th>Nombre Completo</th>
	<th>Tipo de cuenta</th>
</tr>
<?php
while ($fila=mysqli_fetch_array($resultado)){
	echo "<tr>";
	echo "<td>".$fila['id_persona']."</td>";
	echo "<td>".$fila['nombre']." ".$fila['apellido']."</td>";
	echo "<td>".$fila['tipo_cuenta']."</td>";
	echo "</tr>";
}
?>
</table><br>

