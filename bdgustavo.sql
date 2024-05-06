-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-05-2024 a las 20:00:46
-- Versión del servidor: 8.3.0
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdgustavo`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_bancaria`
--

CREATE TABLE `cuenta_bancaria` (
  `id_cuenta` int NOT NULL,
  `id_persona` int DEFAULT NULL,
  `tipo_cuenta` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `saldo` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `cuenta_bancaria`
--

INSERT INTO `cuenta_bancaria` (`id_cuenta`, `id_persona`, `tipo_cuenta`, `saldo`) VALUES
(1, 1, 'Cuenta corriente', 5000),
(2, 1, 'Cuenta de ahorros', 10000),
(3, 2, 'Cuenta de ahorros', 7500),
(4, 3, 'Cuenta corriente', 3000),
(5, 4, 'Cuenta de inversion', 8000),
(6, 5, 'Cuenta corriente', 6000),
(7, 6, 'Cuenta de ahorros', 5000),
(8, 7, 'Cuenta de inversion', 9000),
(9, 8, 'Cuenta corriente', 7000),
(10, 9, 'Cuenta corriente', 5500),
(11, 10, 'Cuenta de ahorros', 3500),
(12, 11, 'Cuenta de inversion', 2000),
(13, 12, 'Cuenta corriente', 4800),
(14, 13, 'Cuenta de ahorros', 6200),
(15, 14, 'Cuenta de inversion', 5300),
(16, 15, 'Cuenta corriente', 4000),
(18, 12, 'Cuenta de ahorros', 3000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `id_persona` int NOT NULL,
  `nombre` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `apellido` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `edad` int DEFAULT NULL,
  `cod_dep` int DEFAULT NULL,
  `email` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `telefono` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id_persona`, `nombre`, `apellido`, `edad`, `cod_dep`, `email`, `telefono`) VALUES
(1, 'Juan', 'Pérez', 35, 5, 'juan@example.com', '123-456-7890'),
(2, 'María', 'Gómez', 28, 3, 'maria@example.com', '987-654-3210'),
(3, 'Carlos', 'Martínez', 40, 7, 'carlos@example.com', '555-555-5555'),
(4, 'Laura', 'Rodríguez', 25, 1, 'laura@example.com', '111-222-3333'),
(5, 'Pedro', 'Sánchez', 50, 6, 'pedro@example.com', '444-555-6666'),
(6, 'Ana', 'López', 45, 9, 'ana@example.com', '777-888-9999'),
(7, 'Sofía', 'Hernández', 32, 2, 'sofia@example.com', '333-222-1111'),
(8, 'Diego', 'García', 38, 4, 'diego@example.com', '999-888-7777'),
(9, 'Elena', 'Fernández', 29, 8, 'elena@example.com', '666-777-8888'),
(10, 'Daniel', 'Díaz', 31, 5, 'daniel@example.com', '222-333-4444'),
(11, 'Luisa', 'Martínez', 42, 3, 'luisa@example.com', '888-999-0000'),
(12, 'Javier', 'Gutiérrez', 37, 7, 'javier@example.com', '111-000-9999'),
(13, 'Fernanda', 'Ramírez', 26, 1, 'fernanda@example.com', '555-666-7777'),
(14, 'Pablo', 'Morales', 48, 9, 'pablo@example.com', '777-666-5555'),
(15, 'Marcela', 'Ortiz', 33, 4, 'marcela@example.com', '333-444-5555'),
(19, 'Juan', 'Quispe', 31, 1, 'juanquispe@gmail.com', '7349864'),
(25, 'Sandro', 'Contreras', 35, 1, 'sandrito@gmail.com', '673465'),
(26, 'fernando', 'castro', 38, 5, 'fcastro@gmail.com', '6753498');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transaccion_bancaria`
--

CREATE TABLE `transaccion_bancaria` (
  `id_transaccion` int NOT NULL,
  `id_cuenta` int DEFAULT NULL,
  `tipo_transaccion` enum('Depósito','Retiro') COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `monto` double DEFAULT NULL,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `transaccion_bancaria`
--

INSERT INTO `transaccion_bancaria` (`id_transaccion`, `id_cuenta`, `tipo_transaccion`, `monto`, `fecha`) VALUES
(1, 1, 'Depósito', 2000, '2024-04-22 17:03:31'),
(2, 1, 'Retiro', 500, '2024-04-22 17:03:31'),
(3, 1, 'Depósito', 1500, '2024-04-22 17:03:31'),
(4, 2, 'Depósito', 3000, '2024-04-22 17:03:31'),
(5, 2, 'Retiro', 1000, '2024-04-22 17:03:31'),
(6, 2, 'Depósito', 500, '2024-04-22 17:03:31'),
(7, 2, 'Retiro', 200, '2024-04-22 17:03:31'),
(8, 2, 'Depósito', 700, '2024-04-22 17:03:31'),
(9, 2, 'Retiro', 1000, '2024-04-22 17:03:31'),
(10, 2, 'Depósito', 1000, '2024-04-22 17:03:31'),
(11, 2, 'Retiro', 1500, '2024-04-22 17:03:31'),
(12, 2, 'Depósito', 2000, '2024-04-22 17:03:31'),
(13, 2, 'Retiro', 300, '2024-04-22 17:03:31'),
(14, 2, 'Depósito', 800, '2024-04-22 17:03:31'),
(15, 2, 'Retiro', 700, '2024-04-22 17:03:31'),
(16, 2, 'Depósito', 1500, '2024-04-22 17:03:31'),
(17, 3, 'Depósito', 1500, '2024-04-22 17:03:31'),
(18, 4, 'Depósito', 1000, '2024-04-22 17:03:31'),
(19, 4, 'Retiro', 500, '2024-04-22 17:03:31'),
(20, 5, 'Depósito', 2000, '2024-04-22 17:03:31'),
(21, 5, 'Depósito', 1000, '2024-04-22 17:03:31'),
(22, 5, 'Retiro', 500, '2024-04-22 17:03:31'),
(23, 5, 'Retiro', 700, '2024-04-22 17:03:31'),
(24, 6, 'Depósito', 1500, '2024-04-22 17:03:31'),
(25, 6, 'Retiro', 1000, '2024-04-22 17:03:31'),
(26, 6, 'Depósito', 2000, '2024-04-22 17:03:31'),
(27, 7, 'Retiro', 1500, '2024-04-22 17:03:31'),
(28, 7, 'Depósito', 1000, '2024-04-22 17:03:31'),
(29, 8, 'Depósito', 500, '2024-04-22 17:03:31'),
(30, 8, 'Depósito', 200, '2024-04-22 17:03:31'),
(31, 8, 'Depósito', 700, '2024-04-22 17:03:31'),
(32, 8, 'Retiro', 1000, '2024-04-22 17:03:31'),
(33, 8, 'Depósito', 1000, '2024-04-22 17:03:31'),
(34, 9, 'Retiro', 500, '2024-04-22 17:03:31'),
(35, 9, 'Depósito', 1000, '2024-04-22 17:03:31'),
(36, 9, 'Retiro', 200, '2024-04-22 17:03:31'),
(37, 9, 'Depósito', 1500, '2024-04-22 17:03:31'),
(38, 10, 'Depósito', 300, '2024-04-22 17:03:31'),
(39, 10, 'Depósito', 800, '2024-04-22 17:03:31'),
(40, 10, 'Depósito', 1500, '2024-04-22 17:03:31'),
(41, 10, 'Retiro', 200, '2024-04-22 17:03:31'),
(42, 11, 'Depósito', 200, '2024-04-22 17:03:31'),
(43, 11, 'Depósito', 1000, '2024-04-22 17:03:31'),
(44, 11, 'Retiro', 700, '2024-04-22 17:03:31'),
(45, 12, 'Retiro', 500, '2024-04-22 17:03:31'),
(46, 12, 'Depósito', 800, '2024-04-22 17:03:31'),
(47, 12, 'Depósito', 1000, '2024-04-22 17:03:31'),
(48, 12, 'Retiro', 700, '2024-04-22 17:03:31'),
(49, 13, 'Depósito', 500, '2024-04-22 17:03:31'),
(50, 13, 'Retiro', 200, '2024-04-22 17:03:31'),
(51, 13, 'Depósito', 1500, '2024-04-22 17:03:31'),
(52, 13, 'Depósito', 1000, '2024-04-22 17:03:31'),
(53, 13, 'Retiro', 700, '2024-04-22 17:03:31'),
(54, 14, 'Depósito', 1000, '2024-04-22 17:03:31'),
(55, 14, 'Retiro', 500, '2024-04-22 17:03:31'),
(56, 14, 'Depósito', 800, '2024-04-22 17:03:31'),
(57, 14, 'Retiro', 1000, '2024-04-22 17:03:31'),
(58, 14, 'Retiro', 700, '2024-04-22 17:03:31');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int NOT NULL,
  `id_persona` int DEFAULT NULL,
  `usuario` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `contrasena` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `rol` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `id_persona`, `usuario`, `contrasena`, `rol`) VALUES
(1, 1, 'adm', 'adm', 'admin'),
(2, 2, 'user', 'user', 'user');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD PRIMARY KEY (`id_cuenta`),
  ADD KEY `id_persona` (`id_persona`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id_persona`);

--
-- Indices de la tabla `transaccion_bancaria`
--
ALTER TABLE `transaccion_bancaria`
  ADD PRIMARY KEY (`id_transaccion`),
  ADD KEY `id_cuenta` (`id_cuenta`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD KEY `id_persona` (`id_persona`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  MODIFY `id_cuenta` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `id_persona` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de la tabla `transaccion_bancaria`
--
ALTER TABLE `transaccion_bancaria`
  MODIFY `id_transaccion` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD CONSTRAINT `cuenta_bancaria_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`);

--
-- Filtros para la tabla `transaccion_bancaria`
--
ALTER TABLE `transaccion_bancaria`
  ADD CONSTRAINT `transaccion_bancaria_ibfk_1` FOREIGN KEY (`id_cuenta`) REFERENCES `cuenta_bancaria` (`id_cuenta`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
