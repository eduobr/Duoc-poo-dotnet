-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-10-2016 a las 15:38:00
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `cruz negra`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `farmacia`
--

CREATE TABLE IF NOT EXISTS `farmacia` (
  `id_farmacia` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre_farmacia` varchar(20) NOT NULL,
  `Comuna` varchar(20) NOT NULL,
  `Encargado` varchar(20) NOT NULL,
  PRIMARY KEY (`id_farmacia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `Codigo` int(2) NOT NULL AUTO_INCREMENT,
  `precioBase` int(2) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

CREATE TABLE IF NOT EXISTS `stock` (
  `id_Stock` int(2) NOT NULL AUTO_INCREMENT,
  `Codigo_producto` int(2) NOT NULL,
  `id_Farmacia` int(2) NOT NULL,
  PRIMARY KEY (`id_Stock`),
  KEY `Codigo_producto` (`Codigo_producto`),
  KEY `id_Farmacia` (`id_Farmacia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `FK_Farmacia` FOREIGN KEY (`id_Farmacia`) REFERENCES `farmacia` (`id_farmacia`),
  ADD CONSTRAINT `FK_Producto` FOREIGN KEY (`Codigo_producto`) REFERENCES `producto` (`Codigo`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
