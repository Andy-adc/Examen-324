<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$id=$_GET["id"];
$idpersona=$_GET["idpersona"];
$sql = "delete from cuenta_bancaria where id_cuenta=".(int)$id;
$resultado = mysqli_query($con, $sql);

header("Location: cuenta.php?id=".$idpersona);
?>