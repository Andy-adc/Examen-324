<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$idpersona=$_GET['idpersona'];
$idcuenta=$_GET["idcuenta"];
$saldo=$_GET["saldo"];
$sql = "update cuenta_bancaria set saldo = ".(int)$saldo." where id_cuenta = ".(int)$idcuenta;
$resultado = mysqli_query($con, $sql);


header("Location: cuenta.php?id=".$idpersona);
?>