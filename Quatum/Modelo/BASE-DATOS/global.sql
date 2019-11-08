/*
SQLyog Ultimate v11.11 (32 bit)
MySQL - 5.5.39 : Database - global
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`global` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `global`;

/*Table structure for table `asientos` */

DROP TABLE IF EXISTS `asientos`;

CREATE TABLE `asientos` (
  `asiento_id` int(11) NOT NULL AUTO_INCREMENT,
  `asiento_fecha` varchar(255) DEFAULT NULL,
  `asiento_tipo` varchar(255) DEFAULT NULL,
  `asiento_valor` float DEFAULT NULL,
  `cuentas` int(11) DEFAULT NULL,
  PRIMARY KEY (`asiento_id`),
  KEY `FKb3r0ufew453cbx2m6y744ikqn` (`cuentas`),
  CONSTRAINT `FKb3r0ufew453cbx2m6y744ikqn` FOREIGN KEY (`cuentas`) REFERENCES `plan_cuentas` (`cuentas_id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;

/*Data for the table `asientos` */

insert  into `asientos`(`asiento_id`,`asiento_fecha`,`asiento_tipo`,`asiento_valor`,`cuentas`) values (43,'25 noviembre','Debe',250,1),(44,'viernes, 08 de noviembre de 2019','Haber',25,2),(45,'viernes, 08 de noviembre de 2019','Debe',25,1),(46,'viernes, 08 de noviembre de 2019','Debe',24,1),(47,'viernes, 08 de noviembre de 2019','Haber',24,40);

/*Table structure for table `plan_cuentas` */

DROP TABLE IF EXISTS `plan_cuentas`;

CREATE TABLE `plan_cuentas` (
  `cuentas_id` int(11) NOT NULL AUTO_INCREMENT,
  `cuentas_descripcion` varchar(255) DEFAULT NULL,
  `cuenta_tipo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cuentas_id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;

/*Data for the table `plan_cuentas` */

insert  into `plan_cuentas`(`cuentas_id`,`cuentas_descripcion`,`cuenta_tipo`) values (1,'Caja','Activo'),(2,'Rodados','Activo'),(5,'Capital Social','PN'),(6,'Documentos a pagar','Pasivo'),(7,'Proveedores','Pasivo'),(8,'Acreedores Varios','Pasivo'),(10,'Costo mercaderias vendidas','Egreso'),(11,'Alquileres perdidos','Egreso'),(15,'Intereses perdidos','Egreso'),(37,'Alquileres ganados','Ingreso'),(38,'Comisiones ganadas','Ingreso'),(39,'Venta de mercaderias','Ingreso'),(40,'Inmuebles','Activo');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
