<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$id=$_GET["id"];
$tipocuenta=$_GET["tipocuenta"];
$saldo=$_GET["saldo"];
$sql = "insert into cuenta_bancaria(id_persona, tipo_cuenta, saldo) values
(".(int)$id.", '".$tipocuenta."', ".(int)$saldo.")";
$resultado = mysqli_query($con, $sql);

header("Location: cuenta.php?id=".$id);
?>