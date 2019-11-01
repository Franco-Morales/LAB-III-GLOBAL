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
  `asiento_referencia` int(11) NOT NULL,
  PRIMARY KEY (`asiento_id`),
  KEY `FKb3r0ufew453cbx2m6y744ikqn` (`cuentas`),
  KEY `FKqug0ui0m4axx8191da9s3o01h` (`asiento_referencia`),
  CONSTRAINT `FKqug0ui0m4axx8191da9s3o01h` FOREIGN KEY (`asiento_referencia`) REFERENCES `referencia` (`id`),
  CONSTRAINT `FKb3r0ufew453cbx2m6y744ikqn` FOREIGN KEY (`cuentas`) REFERENCES `plan_cuentas` (`cuentas_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `asientos` */

/*Table structure for table `plan_cuentas` */

DROP TABLE IF EXISTS `plan_cuentas`;

CREATE TABLE `plan_cuentas` (
  `cuentas_id` int(11) NOT NULL AUTO_INCREMENT,
  `cuentas_descripcion` varchar(255) DEFAULT NULL,
  `cuenta_tipo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cuentas_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Data for the table `plan_cuentas` */

insert  into `plan_cuentas`(`cuentas_id`,`cuentas_descripcion`,`cuenta_tipo`) values (1,'Caja','Activo'),(2,'Rodados','Activo'),(3,'Maquinarias','Activo'),(4,'Documentos a cobrar','Activo'),(5,'Capital Social','PN'),(6,'Documentos a pagar','Pasivo'),(7,'Proveedores','Pasivo'),(8,'Acreedores Varios','Pasivo'),(9,'Alquileres a pagar','Pasivo'),(10,'CMV','Egreso'),(11,'Alquileres perdidos','Egreso'),(12,'Comisiones ganadas','Ingreso'),(13,'Comisiones perdidas','Ingreso'),(14,'Intereses ganados','Ingreso'),(15,'Intereses perdidos','Egreso');

/*Table structure for table `referencia` */

DROP TABLE IF EXISTS `referencia`;

CREATE TABLE `referencia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `referencia` */

insert  into `referencia`(`id`) values (1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
