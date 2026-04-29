CREATE DATABASE IF NOT EXISTS `cakeshopdb`;
USE `cakeshopdb`;

-- ----------------------------
-- Table: admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin` (
  `adminid` int NOT NULL AUTO_INCREMENT,
  `username` varchar(20),
  `password` varchar(20),
  PRIMARY KEY (`adminid`)
);

INSERT INTO `admin` VALUES (1,'admin','admin');

-- ----------------------------
-- Table: cake
-- ----------------------------
DROP TABLE IF EXISTS `cake`;
CREATE TABLE `cake` (
  `cakeid` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50),
  `category` varchar(20),
  `price` decimal(10,2),
  `quantity` varchar(10),
  `availability` tinyint(1) DEFAULT 1,
  `ImagePath` varchar(255),
  `flavour` varchar(50),
  PRIMARY KEY (`cakeid`)
);

INSERT INTO `cake` (`cakeid`,`name`,`category`,`price`,`quantity`,`availability`,`ImagePath`,`flavour`) VALUES
(1,'Chocolate Cake','Cake',500,'1kg',1,'Images/choco_cake.png','Chocolate'),
(2,'Black Forest','Cake',350,'500g',1,'Images/black_forest.png','Chocolate'),
(3,'White Forest','Cake',400,'1kg',1,'Images/white_forest.png','Vanilla'),
(4,'Strawberry Cupcake','Cupcake',35,'1pc',1,'Images/strawberry_cupcake.png','Strawberry'),
(5,'Vanilla Cupcake','Cupcake',20,'1pc',1,'Images/vanilla_cupcake.png','Vanilla'),
(6,'Butterscotch Cupcake','Cupcake',40,'1pc',1,'Images/butterscotch_cupcake.png','Butterscotch'),
(7,'Rainbow Cake','Cake',800,'1kg',1,'Images/rainbow_cake.png','Mixed'),
(8,'Red Velvet Cake','Cake',950,'1kg',1,'Images/red_velvet.png','Chocolate'),
(9,'Chocolate Donut','Donut',30,'1pc',1,'Images/choco_donut.png','Chocolate'),
(10,'Caramel Donut','Donut',50,'1pc',1,'Images/caramel_donut.png','Caramel');

-- ----------------------------
-- Table: orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `orderid` int NOT NULL AUTO_INCREMENT,
  `order_date` date,
  `totalamount` decimal(10,2),
  PRIMARY KEY (`orderid`)
);

-- ----------------------------
-- Table: orderitems
-- ----------------------------
DROP TABLE IF EXISTS `orderitems`;
CREATE TABLE `orderitems` (
  `orderitem_id` int NOT NULL AUTO_INCREMENT,
  `cakeid` int,
  `quantity` int,
  `price` decimal(10,2),
  `order_date` date,
  PRIMARY KEY (`orderitem_id`),
  FOREIGN KEY (`cakeid`) REFERENCES `cake`(`cakeid`)
);

-- ----------------------------
-- Table: payment
-- ----------------------------
DROP TABLE IF EXISTS `payment`;
CREATE TABLE `payment` (
  `paymentid` int NOT NULL AUTO_INCREMENT,
  `totalamount` decimal(10,2),
  `paymentmethod` enum('Cash','Online'),
  `paymentdate` date,
  `orderitem_id` int,
  PRIMARY KEY (`paymentid`),
  FOREIGN KEY (`orderitem_id`) REFERENCES `orderitems`(`orderitem_id`)
);

-- ----------------------------
-- Table: salesreport
-- ----------------------------
DROP TABLE IF EXISTS `salesreport`;
CREATE TABLE `salesreport` (
  `reportid` int NOT NULL AUTO_INCREMENT,
  `totalsales` decimal(10,2),
  `reportdate` datetime,
  `paymentid` int,
  PRIMARY KEY (`reportid`),
  FOREIGN KEY (`paymentid`) REFERENCES `payment`(`paymentid`)
);
