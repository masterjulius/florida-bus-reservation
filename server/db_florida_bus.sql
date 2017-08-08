-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: db_florida_bus
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_bus`
--

DROP TABLE IF EXISTS `tbl_bus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bus` (
  `bus_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bus_class_id` bigint(20) NOT NULL,
  `bus_number` varchar(20) NOT NULL DEFAULT '000000',
  `bus_plate_number` varchar(10) NOT NULL DEFAULT 'ABC123',
  `bus_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `bus_created_by` int(11) NOT NULL,
  `bus_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `bus_edited_by` int(11) NOT NULL DEFAULT '0',
  `bus_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`bus_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bus`
--

LOCK TABLES `tbl_bus` WRITE;
/*!40000 ALTER TABLE `tbl_bus` DISABLE KEYS */;
INSERT INTO `tbl_bus` VALUES (2,2,'123','QWER1234','2017-07-08 21:21:52',0,'2017-07-08 21:47:55',0,1),(3,2,'800','QWE431','2017-07-09 18:44:25',1,'2017-07-09 18:44:25',0,1),(4,5,'99999','876543SF','2017-07-17 11:22:16',1,'2017-07-17 11:22:16',0,1);
/*!40000 ALTER TABLE `tbl_bus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bus_class`
--

DROP TABLE IF EXISTS `tbl_bus_class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bus_class` (
  `class_id` int(11) NOT NULL AUTO_INCREMENT,
  `class_name` varchar(55) NOT NULL,
  `class_seat_count` tinyint(4) NOT NULL DEFAULT '50',
  `class_has_aircon` tinyint(4) NOT NULL DEFAULT '1',
  `class_seat_price` double NOT NULL DEFAULT '0',
  `class_remarks` text,
  `class_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `class_created_by` int(11) NOT NULL DEFAULT '0',
  `class_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `class_edited_by` int(11) NOT NULL DEFAULT '0',
  `class_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`class_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bus_class`
--

LOCK TABLES `tbl_bus_class` WRITE;
/*!40000 ALTER TABLE `tbl_bus_class` DISABLE KEYS */;
INSERT INTO `tbl_bus_class` VALUES (1,'AAA',60,0,0,'afafafaf','2017-07-03 00:56:37',1,'2017-07-03 22:56:27',0,0),(2,'BBB',60,1,0,'fafa afafaf','2017-07-03 18:33:13',1,'2017-07-11 21:08:38',1,1),(3,'CCC',55,1,0,'fafafafa','2017-07-03 18:35:55',1,'2017-07-03 22:54:37',1,0),(4,'Super Deluxe',60,1,0,'Nothing','2017-07-09 18:43:19',1,'2017-07-09 18:43:36',1,0),(5,'Deluxe',55,1,150,'','2017-07-17 09:08:19',1,'2017-07-17 09:08:19',0,1),(6,'Special',65,1,500,'','2017-07-17 09:25:09',1,'2017-07-17 09:25:09',0,1);
/*!40000 ALTER TABLE `tbl_bus_class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_busclassmeta`
--

DROP TABLE IF EXISTS `tbl_busclassmeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_busclassmeta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_busclass_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_busclassmeta`
--

LOCK TABLES `tbl_busclassmeta` WRITE;
/*!40000 ALTER TABLE `tbl_busclassmeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_busclassmeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_busmeta`
--

DROP TABLE IF EXISTS `tbl_busmeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_busmeta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_bus_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_busmeta`
--

LOCK TABLES `tbl_busmeta` WRITE;
/*!40000 ALTER TABLE `tbl_busmeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_busmeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_client_meta`
--

DROP TABLE IF EXISTS `tbl_client_meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_client_meta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_client_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_client_meta`
--

LOCK TABLES `tbl_client_meta` WRITE;
/*!40000 ALTER TABLE `tbl_client_meta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_client_meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clients`
--

DROP TABLE IF EXISTS `tbl_clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_clients` (
  `client_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `client_username` varchar(90) DEFAULT NULL,
  `client_password` varchar(85) DEFAULT NULL,
  `client_first_name` varchar(200) NOT NULL,
  `client_middle_name` varchar(200) DEFAULT NULL,
  `client_last_name` varchar(200) NOT NULL,
  `client_contact` varchar(45) NOT NULL,
  `client_address` text,
  `client_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `client_created_by` int(11) NOT NULL DEFAULT '0',
  `client_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `client_edited_by` int(11) NOT NULL DEFAULT '0',
  `client_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clients`
--

LOCK TABLES `tbl_clients` WRITE;
/*!40000 ALTER TABLE `tbl_clients` DISABLE KEYS */;
INSERT INTO `tbl_clients` VALUES (1,NULL,NULL,'John','Foo','Doe','0987654321','Sample Street.','2017-07-15 09:59:35',0,'2017-07-15 10:55:49',0,0),(2,NULL,NULL,'Joyce','Bradshaw','Pring','1234567890','DJ','2017-07-15 10:02:21',0,'2017-07-15 10:36:31',0,1),(3,NULL,NULL,'Obey','Your','Master','0987654321','Metallica Street, Trash Town, Metal State','2017-07-15 10:52:42',0,'2017-07-15 10:53:38',0,1),(4,NULL,NULL,'bxbx','sgsgs','gsgs','098765432','adad','2017-07-15 10:54:11',0,'2017-07-15 10:54:11',0,1),(5,NULL,NULL,'nccn','qrqrq','zvzv','65432','wtwt tw w','2017-07-28 15:32:00',0,'2017-07-28 15:32:00',0,1),(6,NULL,NULL,'nccn','qrqrq','zvzv','65432','wtwt tw w','2017-07-28 15:32:03',0,'2017-07-28 15:32:03',0,1),(7,NULL,NULL,'Julius','Bucaling','Palcong','09975445375','Newagac, Gattaran,Cagayan, Philippines','2017-07-28 15:51:05',0,'2017-07-28 15:51:05',0,1),(8,'sam','123','fahafhj','hjafhjhjf','afhjafhj','123','fafhahj','2017-07-28 16:45:41',0,'2017-07-28 16:45:41',0,1),(9,'asd','123','zxc','qwe','fgh','1234567890','itu gd','2017-07-29 17:37:54',0,'2017-07-29 17:37:54',0,1),(10,'rogielyn','123','Rogielyn','Asuncion','Cuevas','123456','Apayao, Philippines','2017-07-30 12:49:05',0,'2017-07-30 12:49:05',0,1),(11,'rogielyn','123','Rogielyn','Asuncion','Cuevas','123456','Apayao, Philippines','2017-07-30 12:49:05',0,'2017-07-30 12:49:05',0,1),(12,'rogielyn','123','Rogielyn','Asuncion','Cuevas','123456','Apayao, Philippines','2017-07-30 12:49:21',0,'2017-07-30 12:49:21',0,1);
/*!40000 ALTER TABLE `tbl_clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_meta_keys`
--

DROP TABLE IF EXISTS `tbl_meta_keys`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_meta_keys` (
  `key_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `key_name` varchar(255) DEFAULT '_',
  `key_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`key_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_meta_keys`
--

LOCK TABLES `tbl_meta_keys` WRITE;
/*!40000 ALTER TABLE `tbl_meta_keys` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_meta_keys` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reservation_meta`
--

DROP TABLE IF EXISTS `tbl_reservation_meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_reservation_meta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_reservation_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reservation_meta`
--

LOCK TABLES `tbl_reservation_meta` WRITE;
/*!40000 ALTER TABLE `tbl_reservation_meta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reservation_meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reservations`
--

DROP TABLE IF EXISTS `tbl_reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_reservations` (
  `res_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `res_sched_id` bigint(20) NOT NULL,
  `res_type` tinyint(4) NOT NULL DEFAULT '1',
  `res_code` varchar(25) NOT NULL,
  `res_bus_class_id` int(11) DEFAULT NULL,
  `res_bus_id` bigint(20) NOT NULL,
  `res_seat_numbers` varchar(255) NOT NULL,
  `res_is_cancelled` tinyint(1) NOT NULL DEFAULT '0',
  `res_client_id` bigint(20) NOT NULL,
  `res_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `res_created_by` int(11) NOT NULL DEFAULT '0',
  `res_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `res_edited_by` int(11) DEFAULT '0',
  `res_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`res_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reservations`
--

LOCK TABLES `tbl_reservations` WRITE;
/*!40000 ALTER TABLE `tbl_reservations` DISABLE KEYS */;
INSERT INTO `tbl_reservations` VALUES (5,0,1,'GV-170717110751-511',5,13,'1:2:3:4:5',0,4,'2017-07-17 11:58:51',0,'2017-07-17 11:58:51',0,1),(6,0,1,'GV-170717120700-374',5,13,'1:2:3:4:5',0,3,'2017-07-17 12:02:00',0,'2017-07-17 12:02:00',0,1),(7,0,1,'GV-170718100731-700',5,13,'1:2:3:4:5',0,3,'2017-07-18 10:05:31',0,'2017-07-18 10:05:31',0,1),(8,0,1,'GV-170718100730-231',5,13,'1:2:3:4:5',0,4,'2017-07-18 10:10:30',0,'2017-07-18 10:10:30',0,1),(9,0,1,'GV-170718100737-098',2,15,'1:2:3:4:5',0,4,'2017-07-18 10:12:37',0,'2017-07-18 10:12:37',0,1),(10,0,1,'GV-170718100715-507',5,13,'1:2:3:4:5',0,4,'2017-07-18 10:14:15',0,'2017-07-18 10:14:15',0,1);
/*!40000 ALTER TABLE `tbl_reservations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_schedulemeta`
--

DROP TABLE IF EXISTS `tbl_schedulemeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_schedulemeta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_schedule_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_schedulemeta`
--

LOCK TABLES `tbl_schedulemeta` WRITE;
/*!40000 ALTER TABLE `tbl_schedulemeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_schedulemeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_schedules`
--

DROP TABLE IF EXISTS `tbl_schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_schedules` (
  `sched_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `sched_bus_id` bigint(20) NOT NULL,
  `sched_date` date DEFAULT NULL,
  `sched_departure_time` time(6) DEFAULT NULL,
  `sched_name` tinytext,
  `sched_description` text,
  `sched_auto_departure` tinyint(1) NOT NULL DEFAULT '1',
  `sched_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sched_created_by` int(11) NOT NULL,
  `sched_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `sched_edited_by` int(11) NOT NULL DEFAULT '0',
  `sched_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`sched_id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_schedules`
--

LOCK TABLES `tbl_schedules` WRITE;
/*!40000 ALTER TABLE `tbl_schedules` DISABLE KEYS */;
INSERT INTO `tbl_schedules` VALUES (1,2,'2017-07-10','02:32:26.000000','','',1,'2017-07-09 02:32:34',0,'2017-07-09 02:32:34',0,1),(2,2,'2017-07-12','08:00:00.000000','','',1,'2017-07-09 02:35:46',0,'2017-07-09 02:35:46',0,1),(3,2,'2017-07-09','23:00:00.000000','','',1,'2017-07-09 08:45:22',0,'2017-07-09 17:26:47',0,0),(4,2,'2017-07-09','12:00:00.000000','','',1,'2017-07-09 08:45:45',0,'2017-07-09 08:45:45',0,1),(5,2,'2017-07-09','17:00:00.000000','','',1,'2017-07-09 11:53:06',0,'2017-07-09 14:09:13',0,1),(6,2,'2017-07-09','14:00:00.000000','','',1,'2017-07-09 11:54:26',0,'2017-07-09 11:54:26',0,1),(7,2,'2017-07-09','20:00:00.000000','','',1,'2017-07-09 14:04:06',0,'2017-07-09 14:10:53',0,1),(8,2,'2017-07-09','18:49:00.000000','','',1,'2017-07-09 14:06:34',0,'2017-07-09 18:47:38',1,1),(9,2,'2017-07-09','04:00:00.000000','','',1,'2017-07-09 14:07:21',0,'2017-07-09 14:07:21',0,1),(10,2,'2017-07-09','21:00:00.000000','','',1,'2017-07-09 17:23:36',1,'2017-07-09 17:25:35',0,0),(11,3,'2017-07-10','01:00:00.000000','','',1,'2017-07-09 18:45:11',1,'2017-07-09 18:45:54',1,1),(12,3,'2017-07-16','17:49:43.000000','','',1,'2017-07-15 17:49:58',1,'2017-07-15 17:49:58',0,1),(13,4,'2017-07-18','11:27:43.000000','','',1,'2017-07-17 11:27:55',1,'2017-07-17 11:27:55',0,1),(14,3,'2017-07-18','14:27:56.000000','','',0,'2017-07-17 11:28:18',1,'2017-07-18 09:52:21',1,1),(15,2,'2017-07-18','09:54:00.000000','','',0,'2017-07-18 09:52:56',1,'2017-07-18 09:52:56',0,1),(16,2,'2017-07-29','00:00:00.000000','','',1,'2017-07-29 19:02:18',1,'2017-07-29 19:02:18',0,1),(17,3,'2017-07-30','10:00:00.000000','','',1,'2017-07-29 19:02:43',1,'2017-07-29 19:02:43',0,1),(18,2,'2017-07-31','22:19:09.000000','','',1,'2017-07-31 10:19:20',1,'2017-07-31 10:19:20',0,1),(19,3,'2017-07-31','00:19:21.000000','','',1,'2017-07-31 10:19:36',1,'2017-07-31 10:19:36',0,1),(20,4,'2017-08-01','10:19:36.000000','','',1,'2017-07-31 10:19:46',1,'2017-07-31 10:19:46',0,1),(21,2,'2017-08-02','20:04:25.000000','','',1,'2017-08-01 20:04:43',1,'2017-08-01 20:04:43',0,1),(22,4,'2017-08-02','21:16:52.505205','','',1,'2017-08-01 21:17:02',1,'2017-08-01 21:17:02',0,1),(23,3,'2017-08-02','21:28:41.517126','','',1,'2017-08-01 21:28:56',1,'2017-08-01 21:28:56',0,1),(24,2,'2017-08-03','22:00:00.000000','','',1,'2017-08-02 21:30:50',1,'2017-08-02 21:30:50',0,1),(25,3,'2017-08-03','22:30:00.000000','','',1,'2017-08-02 21:31:38',1,'2017-08-02 21:31:38',0,1),(26,4,'2017-08-03','23:00:00.000000','','',1,'2017-08-02 21:32:02',1,'2017-08-02 21:32:02',0,1);
/*!40000 ALTER TABLE `tbl_schedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transaction_meta`
--

DROP TABLE IF EXISTS `tbl_transaction_meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_transaction_meta` (
  `meta_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_transaction_id` bigint(20) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaction_meta`
--

LOCK TABLES `tbl_transaction_meta` WRITE;
/*!40000 ALTER TABLE `tbl_transaction_meta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_transaction_meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transactions`
--

DROP TABLE IF EXISTS `tbl_transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_transactions` (
  `trans_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `trans_reservation_id` bigint(20) NOT NULL,
  `trans_total_payment` double NOT NULL DEFAULT '0',
  `trans_is_paid` tinyint(1) NOT NULL DEFAULT '0',
  `trans_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `trans_created_by` int(11) NOT NULL DEFAULT '0',
  `trans_edited_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `trans_edited_by` int(11) NOT NULL DEFAULT '0',
  `trans_is_active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`trans_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transactions`
--

LOCK TABLES `tbl_transactions` WRITE;
/*!40000 ALTER TABLE `tbl_transactions` DISABLE KEYS */;
INSERT INTO `tbl_transactions` VALUES (6,10,750,1,'2017-07-18 10:14:15',0,'2017-07-19 15:55:57',0,1);
/*!40000 ALTER TABLE `tbl_transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usermeta`
--

DROP TABLE IF EXISTS `tbl_usermeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_usermeta` (
  `meta_id` bigint(20) NOT NULL,
  `meta_key_id` bigint(20) NOT NULL,
  `meta_user_id` varchar(45) NOT NULL,
  `meta_value` longtext,
  `meta_created_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`meta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usermeta`
--

LOCK TABLES `tbl_usermeta` WRITE;
/*!40000 ALTER TABLE `tbl_usermeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_usermeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(55) NOT NULL,
  `user_password` varchar(65) NOT NULL,
  `user_role` int(11) NOT NULL DEFAULT '1',
  `user_created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `user_created_by` int(11) DEFAULT '0',
  `user_edited_date` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `user_edited_by` int(11) DEFAULT '0',
  `user_is_active` tinyint(4) DEFAULT '1',
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES (1,'admin','admin',1,'2017-07-02 10:32:17',0,'2017-07-02 10:32:17',0,1);
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-05 15:22:29
