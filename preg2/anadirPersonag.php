<?php
$con = mysqli_connect("localhost", "user324", "user324");
mysqli_select_db($con, "bdgustavo");
$nombre = $_GET['nombre'];
$apellido = $_GET['apellido'];
$edad = $_GET['edad'];
$coddep = $_GET['coddep'];
$email = $_GET['email'];
$tel = $_GET['tel'];
$sql = "insert into persona(nombre, apellido, edad, cod_dep, email, telefono) values
('".$nombre."', '".$apellido."', ".$edad.", ".$coddep.", '".$email."', '".$tel."')";
$resultado = mysqli_query($con, $sql);

header("Location: index.php");
?>