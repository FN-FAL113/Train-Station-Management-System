CREATE DATABASE  IF NOT EXISTS `orbeta_fatdb_activity2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `orbeta_fatdb_activity2`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: orbeta_fatdb_activity2
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `destination`
--

DROP TABLE IF EXISTS `destination`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `destination` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `fee` double NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `destination`
--

LOCK TABLES `destination` WRITE;
/*!40000 ALTER TABLE `destination` DISABLE KEYS */;
INSERT INTO `destination` VALUES (1,'Legazpi',25),(2,'Camalig',15),(3,'Cabangan',17.5),(4,'Daraga',20),(5,'Sorsogon',40),(6,'Ligao',15),(7,'Oas',16.5),(8,'Polangui',25),(9,'Nabua',35),(10,'Bato',40),(11,'Camarines Sur',70),(12,'Camarines Norte',90);
/*!40000 ALTER TABLE `destination` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `destination_fee_plus_tax`
--

DROP TABLE IF EXISTS `destination_fee_plus_tax`;
/*!50001 DROP VIEW IF EXISTS `destination_fee_plus_tax`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `destination_fee_plus_tax` AS SELECT 
 1 AS `name`,
 1 AS `fee`,
 1 AS `fee_with_tax`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `ongoing_train`
--

DROP TABLE IF EXISTS `ongoing_train`;
/*!50001 DROP VIEW IF EXISTS `ongoing_train`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `ongoing_train` AS SELECT 
 1 AS `train id`,
 1 AS `train_name`,
 1 AS `destination name`,
 1 AS `train operator`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `passenger`
--

DROP TABLE IF EXISTS `passenger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passenger` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `age` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passenger`
--

LOCK TABLES `passenger` WRITE;
/*!40000 ALTER TABLE `passenger` DISABLE KEYS */;
INSERT INTO `passenger` VALUES (1,'jeff hub','male',18),(2,'pam gibs','female',23),(3,'lexie williams','female',28),(4,'sam milby','male',35),(5,'john cruz','male',36),(6,'tracy mcgrady','male',43),(7,'jamal crawford','male',37),(8,'luka magic','male',23),(9,'magnus carlsen','male',26),(10,'hikaru nakamura','male',35);
/*!40000 ALTER TABLE `passenger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `system_user`
--

DROP TABLE IF EXISTS `system_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `system_user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(90) NOT NULL,
  `password` varchar(140) NOT NULL,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `system_user`
--

LOCK TABLES `system_user` WRITE;
/*!40000 ALTER TABLE `system_user` DISABLE KEYS */;
INSERT INTO `system_user` VALUES (3,'test1','5a105e8b9d40e1329780d62ea2265d8a','2023-03-02 19:18:22',NULL),(4,'test2','ad0234829205b9033196ba818f7a872b','2023-03-03 20:36:05',NULL),(6,'test3','8ad8757baa8564dc136c1e07507f4a98','2023-03-07 21:53:45',NULL),(7,'test','5a105e8b9d40e1329780d62ea2265d8a','2023-03-30 21:08:52',NULL);
/*!40000 ALTER TABLE `system_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket` (
  `id` int NOT NULL AUTO_INCREMENT,
  `passenger_id` int NOT NULL,
  `train_id` int NOT NULL,
  `fee_with_tax` double DEFAULT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `ticket_ibfk_1` (`passenger_id`),
  KEY `ticket_ibfk_3` (`train_id`),
  CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`passenger_id`) REFERENCES `passenger` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `ticket_ibfk_3` FOREIGN KEY (`train_id`) REFERENCES `train` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (3,5,3,NULL,'2023-02-15 20:15:11'),(5,4,6,NULL,'2023-02-15 20:15:11'),(6,7,6,NULL,'2023-02-15 20:15:11'),(7,9,7,NULL,'2023-02-15 20:15:11'),(8,1,2,NULL,'2023-02-17 20:15:11'),(9,2,1,NULL,'2023-02-17 20:15:11'),(10,3,10,NULL,'2023-02-17 20:15:11'),(11,6,4,NULL,'2023-02-17 20:15:11'),(12,6,8,NULL,'2023-02-17 20:15:11'),(13,1,2,17.25,'2023-02-17 20:15:11'),(14,2,3,20.7,'2023-02-17 20:15:11'),(15,1,1,28.749999999999996,'2023-04-28 15:42:28');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `add_tax_to_fee` BEFORE INSERT ON `ticket` FOR EACH ROW BEGIN
	DECLARE fee_without_tax DOUBLE;
	
    /*
		set column value for fee_with_tax before inserting new row entry to ticket table,
        using the provided train_id value in the ticket table we can use this value
        to properly get the fee through an inner join between destination and train.
		we can set the retrieved fee value into the fee_without_tax variable which is then passed to 
        the fee_tax() function as a parameter that applies the appropriate tax additions to the fee
    */
    if new.fee_with_tax IS NULL THEN
        SELECT fee INTO fee_without_tax from destination inner join train 
						on destination.id = train.destination_id
						where train.id = new.train_id;
                        
		set new.fee_with_tax = fee_tax(fee_without_tax, 0.15);
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `prevent_fee_with_tax_update` BEFORE UPDATE ON `ticket` FOR EACH ROW BEGIN
	
    /*
		
    */
    if new.fee_with_tax != old.fee_with_tax THEN
			SIGNAL SQLSTATE '61000' SET MESSAGE_TEXT = 'Updating fee with tax is disallowed to preserve data integrity!';
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_tax_to_fee` BEFORE UPDATE ON `ticket` FOR EACH ROW BEGIN
	DECLARE fee_without_tax DOUBLE;
	
	if new.fee_with_tax IS NULL OR new.fee_with_tax = 0 THEN
			SELECT fee INTO fee_without_tax from destination inner join train 
							on destination.id = train.destination_id
							where train.id = new.train_id;
							
			set new.fee_with_tax = fee_tax(fee_without_tax, 0.15);
		END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `check_ticket_delete` BEFORE DELETE ON `ticket` FOR EACH ROW BEGIN
	DECLARE ongoing INT;
    
    SELECT is_ongoing INTO ongoing from train inner join ticket 
			on train.id = ticket.train_id
            where train.id = old.train_id AND ticket.id = old.id AND train.is_ongoing = 0; 

    if ongoing = 0 THEN
		SIGNAL SQLSTATE '52000' SET MESSAGE_TEXT = 'Ticket deletion is not allowed for non-ongoing trains!';
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `train`
--

DROP TABLE IF EXISTS `train`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `train` (
  `id` int NOT NULL AUTO_INCREMENT,
  `destination_id` int NOT NULL,
  `train_name` varchar(255) NOT NULL,
  `is_ongoing` tinyint(1) DEFAULT '0',
  `train_operator_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `train_operator_id` (`train_operator_id`),
  UNIQUE KEY `destination_id_UNIQUE` (`destination_id`),
  CONSTRAINT `train_ibfk_1` FOREIGN KEY (`destination_id`) REFERENCES `destination` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `train_ibfk_2` FOREIGN KEY (`train_operator_id`) REFERENCES `train_operator` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `train`
--

LOCK TABLES `train` WRITE;
/*!40000 ALTER TABLE `train` DISABLE KEYS */;
INSERT INTO `train` VALUES (1,1,'krakken',0,1),(2,2,'santiago',1,2),(3,3,'grant',0,3),(4,4,'cassanova',1,4),(5,5,'feather',1,5),(6,6,'courage',0,6),(7,7,'philips',0,7),(8,8,'greesy',0,8),(9,9,'clump',1,9),(10,10,'villa',1,10),(11,11,'test',1,11),(12,12,'testing2',1,12);
/*!40000 ALTER TABLE `train` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `train_operator`
--

DROP TABLE IF EXISTS `train_operator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `train_operator` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `age` int NOT NULL,
  `phone_number` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `phone_number` (`phone_number`),
  UNIQUE KEY `id_2` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=99 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `train_operator`
--

LOCK TABLES `train_operator` WRITE;
/*!40000 ALTER TABLE `train_operator` DISABLE KEYS */;
INSERT INTO `train_operator` VALUES (1,'john wick','male',39,254728),(2,'drow traxex','female',31,267234),(3,'furion wrath','male',25,287942),(4,'nevermore shadows','male',45,246783),(5,'puck chub','male',51,246712),(6,'kunkka admiral','male',53,236721),(7,'krobelus dark','female',45,298578),(8,'kael invoker','male',37,246802),(9,'lina inverse','female',27,278542),(10,'zeus grump','male',55,267813),(11,'david john','male',42,273892),(12,'Kirk ham','male',61,271823);
/*!40000 ALTER TABLE `train_operator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `train_passenger`
--

DROP TABLE IF EXISTS `train_passenger`;
/*!50001 DROP VIEW IF EXISTS `train_passenger`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `train_passenger` AS SELECT 
 1 AS `train_name`,
 1 AS `passengers`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'orbeta_fatdb_activity2'
--

--
-- Dumping routines for database 'orbeta_fatdb_activity2'
--
/*!50003 DROP FUNCTION IF EXISTS `fee_tax` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `fee_tax`(fee int, tax_percent double) RETURNS double
    DETERMINISTIC
BEGIN
	declare newFee double;
    set newFee = fee * (1 + tax_percent);
    return newFee;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `claim_ticket_ongoing_train` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `claim_ticket_ongoing_train`(OUT message varchar(255))
BEGIN
	DECLARE ongoing_train_ticket INT DEFAULT 0;
    DECLARE done INT DEFAULT 0;
    DECLARE trainId INT;
    DECLARE dnumcur cursor for SELECT train_id FROM ticket;
    DECLARE continue handler for not found set done = 1;

	SELECT count(*) INTO ongoing_train_ticket from train inner join ticket on train.id = ticket.train_id where train.is_ongoing = 1;
	
    /* check if there are no tickets to claim by checking if referenced train from ticket is ongoing */
    IF (ongoing_train_ticket = 0) THEN
		SET message = 'No tickets to claim!';
	ELSE
		open dnumcur;
        
		repeat
			fetch dnumcur into trainId;
			DELETE FROM ticket where train_id IN (SELECT id FROM train where is_ongoing = 1 AND train_id = trainId);
		until done
        end repeat;
		
        close dnumcur;
        
        SET message = 'Successfully claimed tickets from ongoing trains!';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `destination_fee_plus_tax`
--

/*!50001 DROP VIEW IF EXISTS `destination_fee_plus_tax`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `destination_fee_plus_tax` AS select `destination`.`name` AS `name`,`destination`.`fee` AS `fee`,`fee_tax`(`destination`.`fee`,0.15) AS `fee_with_tax` from `destination` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `ongoing_train`
--

/*!50001 DROP VIEW IF EXISTS `ongoing_train`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `ongoing_train` AS select `train`.`id` AS `train id`,`train`.`train_name` AS `train_name`,`destination`.`name` AS `destination name`,`train_operator`.`name` AS `train operator` from ((`train` join `destination` on((`train`.`destination_id` = `destination`.`id`))) join `train_operator` on((`train`.`train_operator_id` = `train_operator`.`id`))) where (`train`.`is_ongoing` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `train_passenger`
--

/*!50001 DROP VIEW IF EXISTS `train_passenger`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `train_passenger` AS select `train`.`train_name` AS `train_name`,count(0) AS `passengers` from (`train` join `ticket` on((`train`.`id` = `ticket`.`train_id`))) group by `train`.`train_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-28 15:45:05
