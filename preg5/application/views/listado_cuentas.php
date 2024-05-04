<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Listado de Cuentas</title>
</head>
<body>
    <h1>Listado de Cuentas Bancarias</h1>
    <table>
        <tr>
            <th>ID</th>
            <th>Tipo de cuenta</th>
            <th>Saldo</th>
            <th>Acciones</th>
        </tr>
        <?php foreach ($cuentas as $cuenta): ?>
        <tr>
            <td><?php echo $cuenta->id_cuenta; ?></td>
            <td><?php echo $cuenta->tipo_cuenta; ?></td>
            <td><?php echo $cuenta->saldo; ?></td>
            <td>
                <a href="<?php echo site_url('cuentas/delete/' . $cuenta->id_cuenta); ?>">Eliminar</a>
            </td>
        </tr>
        <?php endforeach; ?>
    </table>
</body>
</html>
