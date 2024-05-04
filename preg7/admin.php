<?php
$con = mysqli_connect("localhost", "user324", "Andy2403");
mysqli_select_db($con, "bdgustavo");
$sql = "select case
		when cod_dep = 1 then 'Chuquisaca'
        when cod_dep = 2 then 'La Paz'
        when cod_dep = 3 then 'Cochabamba'
        when cod_dep = 4 then 'Oruro'
        when cod_dep = 5 then 'Potosi'
        when cod_dep = 6 then 'Tarija'
        when cod_dep = 7 then 'Santa Cruz'
        when cod_dep = 8 then 'Beni'
        when cod_dep = 9 then 'Pando'
        else ''
        end as dep, monto
from (select cod_dep, sum(c.saldo) monto
from persona p, cuenta_bancaria c
where p.id_persona = c.id_persona
group by cod_dep
order by cod_dep) t";
$resultado = mysqli_query($con, $sql);
?>
<link rel="stylesheet" type="text/css" href="styles.css">
<table border="1px">
<tr>
	<?php
	while($fila=mysqli_fetch_array($resultado)){
		echo "<th>".$fila['dep']."</th>";
	}
	?>
</tr>
<?php
$resultado = mysqli_query($con, $sql);
?>
<tr>
	<?php
	while($fila=mysqli_fetch_array($resultado)){
		echo "<td>".$fila['monto']."</td>";
	}
	?>
</tr>
</table>