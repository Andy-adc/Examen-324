<?php 
$id=$_GET['id'];
?>
<form method="GET" action="anadircuentag.php">
	<input type="hidden" name="id" value="<?php echo $id;?>">
	
	<label for="opciones">Selecciona el tipo de cuenta:</label>
	<select id="opciones" name="tipocuenta">
    	<option value="Cuenta corriente">Cuenta corriente</option>
    	<option value="Cuenta de ahorros">Cuenta de ahorros</option>
    	<option value="Cuenta de inversion">Cuenta de inversion</option>
	</select><br>
	Saldo
	<input type="text" name="saldo"/><br>
	<input type="submit" name="Guardar" value="Guardar"/>
</form>