<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$id=$_GET["id"];
$idpersona=$_GET["idpersona"];
$sql = "select saldo from cuenta_bancaria where id_cuenta=".(int)$id;
$resultado = mysqli_query($con, $sql);
$fila=mysqli_fetch_array($resultado);
?>
<form method="GET" action="editarcuentag.php">
	<input type="hidden" name="idpersona" value="<?php echo $idpersona;?>">
	<input type="hidden" name="idcuenta" value="<?php echo $id;?>"/>


	Saldo
	<input type="text" name="saldo" value="<?php echo $fila['saldo'];?>"/><br>
	<input type="submit" name="Guardar" value="Guardar"/>
</form>