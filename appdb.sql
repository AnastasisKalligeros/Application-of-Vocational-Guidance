CREATE DATABASE  IF NOT EXISTS `appdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `appdb`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: appdb
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `newuser`
--

DROP TABLE IF EXISTS `newuser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `newuser` (
  `id` int NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `username` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `age` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `newuser`
--

LOCK TABLES `newuser` WRITE;
/*!40000 ALTER TABLE `newuser` DISABLE KEYS */;
INSERT INTO `newuser` VALUES (5,'Aliki','Papapetrou','alikpap','papaliki@gmail.com','fasko7asadi89','Female','06-03-2000'),(4,'Giwrgos','Nagkis','gnagk','nagkisg@gmail.com','asija23ad','Male','17-03-1999'),(10,'Maki','Melanis','makis','makismelanis@gmail.com','123','Male','26-11-2003'),(3,'Maria','Tzaxrista','mtzax','maraki@outlook.com','melenekimi7','Female','08-05-2002'),(1,'Petros','Alpos','palpos','palpos@gmail.com','1234','Male','29-12-2001'),(2,'Kwstas','Peristeris','peristerisk','kwstasper@yahoo.gr','alperi1kos','Male','17-09-2005'),(7,'Anastasis','Kouloxeris','taskoul','tasoskoulo@gmail.com','thrilosole1234','Male','05-07-2001'),(6,'Thanasis','Mantzaris','thmantz','mantzaristh@outlook.com','faihsaio12dsajo','Male','27-05-2002');
/*!40000 ALTER TABLE `newuser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `progress`
--

DROP TABLE IF EXISTS `progress`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `progress` (
  `username` varchar(45) NOT NULL,
  `progressc1q1` int DEFAULT NULL,
  `progressc1q2` int DEFAULT NULL,
  `progressc1q3` int DEFAULT NULL,
  `progressc2q1` int DEFAULT NULL,
  `progressc2q2` int DEFAULT NULL,
  `progressc2q3` int DEFAULT NULL,
  `progressc3q1` int DEFAULT NULL,
  `progressc3q2` int DEFAULT NULL,
  `progressc3q3` int DEFAULT NULL,
  `progressc4q1` int DEFAULT NULL,
  `progressc4q2` int DEFAULT NULL,
  `progressc4q3` int DEFAULT NULL,
  `progressc5q1` int DEFAULT NULL,
  `progressc5q2` int DEFAULT NULL,
  `progressc5q3` int DEFAULT NULL,
  `progressc6q1` int DEFAULT NULL,
  `progressc6q2` int DEFAULT NULL,
  `progressc6q3` int DEFAULT NULL,
  PRIMARY KEY (`username`),
  CONSTRAINT `username` FOREIGN KEY (`username`) REFERENCES `newuser` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `progress`
--

LOCK TABLES `progress` WRITE;
/*!40000 ALTER TABLE `progress` DISABLE KEYS */;
INSERT INTO `progress` VALUES ('alikpap',6,0,0,4,0,6,6,0,0,0,5,0,6,0,0,0,4,0),('makis',4,8,10,2,2,6,8,8,10,2,0,2,0,0,0,6,6,4),('palpos',2,2,4,6,8,6,10,6,2,8,8,6,4,2,2,0,0,0);
/*!40000 ALTER TABLE `progress` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-16 19:23:07
