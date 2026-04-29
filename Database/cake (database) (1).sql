CREATE DATABASE  IF NOT EXISTS `cakeshopdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cakeshopdb`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cakeshopdb
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `adminid` int NOT NULL AUTO_INCREMENT,
  `username` varchar(20) DEFAULT NULL,
  `password` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`adminid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,'Nithy','Nithya@');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cake`
--

DROP TABLE IF EXISTS `cake`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cake` (
  `cakeid` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `category` varchar(20) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `quantity` varchar(10) DEFAULT NULL,
  `availability` tinyint(1) NOT NULL DEFAULT '0',
  `ImagePath` varchar(255) DEFAULT NULL,
  `flavour` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cakeid`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cake`
--

LOCK TABLES `cake` WRITE;
/*!40000 ALTER TABLE `cake` DISABLE KEYS */;
INSERT INTO `cake` VALUES (13,'double dutch','cake',250,'500g',1,'C:\\Users\\Ashok S\\Downloads\\choco cake.png','Chocolate'),(17,'venillacupcake','cupcake',20,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\venillacupcake.jpg','Venilla'),(18,'White Forest','Cake',400,'1.5kg',1,'C:\\Users\\Ashok S\\Downloads\\whiteforestcake.jpg','Venilla'),(19,'strawberry','cupcake',35,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\strawberrycupcake.jpg','strawberry'),(20,'Blue Berry','cupcake',50,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\backcurrentcupcake.jpg','Black Current'),(21,'Curros','cupcake',65,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\ChurroCupcakes.jpg','cinnamon'),(22,'Chocolate','cupcake',30,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\choccupcake.jpg',NULL),(23,'Butterscotch','cupcake',40,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\Butterscochcupcake.jpg',NULL),(24,'Rain Bow','cake',500,'1kg',1,'C:\\Users\\Ashok S\\Downloads\\Rainbowcake.jpg',NULL),(25,'Rain Bow','pastry',60,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\RainBowpastry.jpg',NULL),(26,'BlackcurrentChoco','Cake',1500,'1.5kg',1,'C:\\Users\\Ashok S\\Downloads\\BlackCurrentChoco.jpg',NULL),(27,'Blackcurrent','Pastry',80,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\BlackCurrentPastry.jpg',NULL),(28,'Blackcurrent','Cake',800,'1kg',1,'C:\\Users\\Ashok S\\Downloads\\BlackCurrentcake.jpg',NULL),(29,'Redvelvet','Cake',950,'1.5kg',1,'C:\\Users\\Ashok S\\Downloads\\Redvelvet.jpg',NULL),(30,'Redvelvet','Pastry',75,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\redpastery.jpg',NULL),(31,'BlackForest','Cake',350,'500g',1,'C:\\Users\\Ashok S\\Downloads\\BlackForest.jpg','Chocolate'),(32,'Whiteforest','pastry',30,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\whiteforestPastery.jpg','Venilla'),(33,'BlackForest','pastry',50,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\BlackForestPastery.jpg',NULL),(34,'funfetti','cupcake',50,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\fumfetti cupcake.jpg',NULL),(35,'ferraro rocher','cupcake',70,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\ferrero rocher cupcake.jpg',NULL),(36,'Rasberry','cupcake',50,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\rasberry cupcake.jpg',NULL),(37,'mango','cupcake',45,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\mango cupcake.jpg',NULL),(38,'Pistachio','cupcake',70,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\pistachio cupcake.png',NULL),(39,'crullers','Dounut',30,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\Crullers donut.jpg',NULL),(40,'Bavarian cream','Dounut',110,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\bavarian cream donut.jpg',NULL),(41,'cinnamon sugar','Dounut',80,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\cinnamon sugar donut.jpg',NULL),(42,'Maplebacon','Dounut',100,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\MapleBaconDonut.jpg',NULL),(43,'Old fashion','Dounut',100,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\Old_fashioned_doughnuts.jpg','caramel'),(44,'Mochi','Dounut',95,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\Mochidonut.jpg',NULL),(45,'Bluberry','Dounut',89,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\bluberry donut.png',NULL),(46,'Beignets','Dounut',39,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\beignets.jpg',NULL),(47,'Jelly filled','Dounut',65,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\jelly donut.jpg',NULL),(48,'Triple chocolate','Brownie',335,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\tripple chocolate brownie.jpg',NULL),(49,'Chocolate Chip','Brownie',220,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\Chocolate-Chip-Brownies.png',NULL),(50,'Peanut Crunch','Brownie',480,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\Peanut-Butter-Crunch-Brownies.jpg',NULL),(51,'Pepper Mint','Brownie',200,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\pepper-mint-brownies.jpg',NULL),(52,'Lemon Blondie','Brownie',225,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\lemon blondy brownie.jpg',NULL),(53,'Ginger Bread','Brownie',345,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\ginger bread brownie.jpg',NULL),(54,'Cherry Choco','Brownie',480,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\cherry choco brownie.jpg',NULL),(55,'Coconut Almond','Brownie',400,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\coconut almond brownie.png',NULL),(56,'Sizzling Crunch','Brownie',125,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\sizzling bvrownie.jpg',NULL),(57,'Blondie','Brownie',300,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\blondies.png',NULL),(58,'Caramel Pretzel','Brownie',650,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\salted caramel pretzel brownies.jpg','Caramel'),(59,'Nutty','Dounut',30,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\nutty donut.jpg','Chocolate Almond'),(60,'Strawberry frost','Dounut',50,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\straw berry frosted donut.png','Strawberry'),(61,'Boston Cream','Dounut',85,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\boston cream donut.png','Chocolate'),(62,'Crystal Crash','Dounut',85,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\caramel glazed donuts.jpg','Caramel'),(63,'Powdered','Dounut',35,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\sugar coated donuts.png','Venilla'),(64,'Choco sprinkle','Dounut',25,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\chocolate glazed donuts.png','Chocolate'),(65,'Dream Velvet','Cake',800,'500gm',1,'C:\\Users\\Ashok S\\Downloads\\velvet cake.jpg','Chocolate'),(66,'Fruit Overload','Cake',950,'1kg',1,'C:\\Users\\Ashok S\\Downloads\\fruit overload cake.png','Fruit'),(67,'yellow crush','Pastry',25,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\pineapple-pastry.png','Pineapple'),(68,'lemon Zest','Cupcake',30,'1pc',1,'C:\\Users\\Ashok S\\Downloads\\lemon zest cupcakes.jpg','Lemon'),(74,'Chocolate','Cake',250,'2kg',1,'C:\\Users\\Ashok S\\Downloads\\choco cake.png','Choco');
/*!40000 ALTER TABLE `cake` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderitems`
--

DROP TABLE IF EXISTS `orderitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderitems` (
  `orderitem_id` int NOT NULL AUTO_INCREMENT,
  `cakeid` int NOT NULL,
  `quantity` int NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `order_date` date DEFAULT NULL,
  PRIMARY KEY (`orderitem_id`),
  KEY `cakeid` (`cakeid`),
  CONSTRAINT `orderitems_ibfk_2` FOREIGN KEY (`cakeid`) REFERENCES `cake` (`cakeid`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderitems`
--

LOCK TABLES `orderitems` WRITE;
/*!40000 ALTER TABLE `orderitems` DISABLE KEYS */;
INSERT INTO `orderitems` VALUES (4,13,1,250.00,NULL),(7,13,1,250.00,NULL),(8,13,1,250.00,NULL),(9,31,1,50.00,NULL),(10,20,1,50.00,NULL),(11,21,1,65.00,NULL),(12,20,1,800.00,NULL),(13,18,1,400.00,NULL),(14,17,1,20.00,NULL),(15,13,1,250.00,NULL),(16,20,1,50.00,NULL),(17,13,1,250.00,NULL),(18,22,1,30.00,NULL),(19,19,1,35.00,NULL),(20,22,1,30.00,NULL),(21,17,1,20.00,NULL),(22,13,1,250.00,NULL),(23,19,1,35.00,NULL),(24,22,1,30.00,NULL),(25,21,1,65.00,NULL),(26,40,1,110.00,NULL),(27,41,1,80.00,NULL),(28,44,1,95.00,NULL),(29,44,1,95.00,NULL),(30,22,1,30.00,NULL),(31,17,1,20.00,NULL),(32,17,1,20.00,NULL),(33,17,1,20.00,NULL),(34,17,1,20.00,NULL),(35,18,1,400.00,'2025-04-21'),(36,17,1,20.00,'2025-04-21'),(37,19,1,35.00,'2025-04-21'),(38,19,1,35.00,'2025-04-21'),(39,18,1,400.00,'2025-04-21'),(40,18,1,400.00,'2025-04-21'),(41,18,1,400.00,'2025-04-21'),(42,17,1,20.00,'2025-04-21'),(43,13,1,250.00,'2025-04-21'),(44,19,1,35.00,'2025-04-21'),(45,17,1,20.00,'2025-04-21'),(46,17,1,20.00,'2025-04-21'),(47,18,1,400.00,'2025-04-21'),(48,18,1,400.00,'2025-04-21'),(49,18,1,400.00,'2025-04-21'),(50,19,1,35.00,'2025-04-21'),(51,18,1,400.00,'2025-04-21'),(52,23,1,40.00,'2025-04-21'),(53,22,1,30.00,'2025-04-21'),(54,66,1,950.00,'2025-04-21'),(55,19,1,35.00,'2025-04-21'),(56,18,1,400.00,'2025-04-21'),(57,17,1,20.00,'2025-04-21'),(58,13,1,250.00,'2025-04-21'),(59,47,1,65.00,'2025-04-24'),(60,47,1,65.00,'2025-04-24'),(61,43,1,100.00,'2025-04-24'),(62,47,1,65.00,'2025-04-24'),(63,47,1,65.00,'2025-04-24'),(64,47,1,65.00,'2025-04-24'),(65,18,1,400.00,'2025-04-24'),(66,61,1,85.00,'2025-05-16'),(67,59,1,30.00,'2025-05-16'),(68,19,1,35.00,'2025-05-16'),(69,23,1,40.00,'2025-05-16');
/*!40000 ALTER TABLE `orderitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `orderid` int NOT NULL AUTO_INCREMENT,
  `order_date` date NOT NULL,
  `totalamount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`orderid`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2025-03-01',1500.00),(2,'2025-03-02',1000.00),(3,'2025-03-03',800.00),(4,'2025-04-08',2100.00),(5,'2025-04-08',850.00),(6,'2025-04-08',750.00),(7,'2025-04-08',750.00),(8,'2025-04-08',1000.00),(9,'2025-04-08',1250.00),(10,'2025-04-09',500.00),(11,'2025-04-09',900.00),(12,'2025-04-09',900.00),(13,'2025-04-09',800.00),(14,'2025-04-09',400.00),(15,'2025-04-09',1150.00),(16,'2025-04-09',1500.00),(17,'2025-04-09',965.00),(18,'2025-04-09',400.00),(19,'2025-04-09',320.00),(20,'2025-04-09',280.00),(21,'2025-04-09',85.00),(22,'2025-04-09',380.00),(23,'2025-04-10',380.00),(24,'2025-04-10',50.00),(25,'2025-04-20',60.00),(26,'2025-04-21',60.00);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `paymentid` int NOT NULL AUTO_INCREMENT,
  `totalamount` decimal(10,2) DEFAULT NULL,
  `paymentmethod` enum('Cash','Online') DEFAULT NULL,
  `paymentdate` date DEFAULT NULL,
  `orderitem_id` int DEFAULT NULL,
  PRIMARY KEY (`paymentid`),
  KEY `itemid_idx` (`orderitem_id`),
  CONSTRAINT `itemid` FOREIGN KEY (`orderitem_id`) REFERENCES `orderitems` (`orderitem_id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,35.00,'Cash',NULL,37),(2,35.00,'Cash',NULL,38),(3,400.00,'Cash',NULL,39),(4,20.00,'Cash',NULL,42),(5,250.00,'Cash',NULL,43),(6,35.00,'Cash',NULL,44),(7,20.00,'Cash',NULL,45),(8,20.00,'Cash',NULL,46),(9,400.00,'Cash',NULL,47),(10,400.00,'Cash',NULL,48),(11,400.00,'Cash',NULL,49),(12,35.00,'Cash',NULL,50),(13,400.00,'Cash',NULL,51),(14,40.00,'Cash',NULL,52),(15,30.00,'Cash',NULL,53),(16,950.00,'Cash',NULL,54),(17,35.00,'Cash',NULL,55),(18,400.00,'Cash',NULL,56),(19,20.00,'Cash',NULL,57),(20,250.00,'Cash',NULL,58),(21,100.00,'Cash',NULL,61),(22,65.00,'Cash',NULL,62),(23,400.00,'Online',NULL,65),(24,85.00,'Online',NULL,66),(25,30.00,'Online',NULL,67),(26,35.00,'Cash',NULL,68),(27,40.00,'Cash',NULL,69);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salesreport`
--

DROP TABLE IF EXISTS `salesreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salesreport` (
  `reportid` int NOT NULL,
  `totalsales` decimal(10,0) DEFAULT NULL,
  `Reportdate` datetime DEFAULT NULL,
  `paymentid` int DEFAULT NULL,
  PRIMARY KEY (`reportid`),
  KEY `fk_idx` (`paymentid`),
  CONSTRAINT `fk` FOREIGN KEY (`paymentid`) REFERENCES `payment` (`paymentid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesreport`
--

LOCK TABLES `salesreport` WRITE;
/*!40000 ALTER TABLE `salesreport` DISABLE KEYS */;
/*!40000 ALTER TABLE `salesreport` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-15 23:25:46
