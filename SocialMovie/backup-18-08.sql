-- MySQL dump 10.13  Distrib 5.7.19, for Win64 (x86_64)
--
-- Host: localhost    Database: socialmovie
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(767) NOT NULL,
  `ProductVersion` text NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20170816020521_Initial','1.1.2');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `archives`
--

DROP TABLE IF EXISTS `archives`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `archives` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Extension` text,
  `Name` text,
  `Path` text,
  `Type` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `archives`
--

LOCK TABLES `archives` WRITE;
/*!40000 ALTER TABLE `archives` DISABLE KEYS */;
INSERT INTO `archives` VALUES (3,'.jpg','split','split/',2),(4,'mpd','stream','split/video',1),(5,'.jpg','tom','jerry/',2),(6,'mpd','JerryGoRound_vod','JerryGoRound_output',0),(7,'mpd','JustDucky_vod','JustDucky_output',0);
/*!40000 ALTER TABLE `archives` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contents`
--

DROP TABLE IF EXISTS `contents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contents` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` text,
  `Discriminator` text NOT NULL,
  `Name` text,
  `Star1` int(11) NOT NULL DEFAULT '0',
  `Star2` int(11) NOT NULL DEFAULT '0',
  `Star3` int(11) NOT NULL DEFAULT '0',
  `Star4` int(11) NOT NULL DEFAULT '0',
  `Star5` int(11) NOT NULL DEFAULT '0',
  `ThumbnailId` int(11) DEFAULT NULL,
  `Type` tinyint(4) NOT NULL,
  `VideoFileId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Contents_ThumbnailId` (`ThumbnailId`),
  KEY `IX_Contents_VideoFileId` (`VideoFileId`),
  CONSTRAINT `FK_Contents_Archives_ThumbnailId` FOREIGN KEY (`ThumbnailId`) REFERENCES `archives` (`Id`),
  CONSTRAINT `FK_Contents_Archives_VideoFileId` FOREIGN KEY (`VideoFileId`) REFERENCES `archives` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contents`
--

LOCK TABLES `contents` WRITE;
/*!40000 ALTER TABLE `contents` DISABLE KEYS */;
INSERT INTO `contents` VALUES (2,'Rapaz que rouba mocas','Movie','Split',0,0,0,0,30,3,1,4),(3,'Gato e rato','Serie','Tom and Jerry',10,20,30,40,50,5,2,NULL);
/*!40000 ALTER TABLE `contents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `episodes`
--

DROP TABLE IF EXISTS `episodes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `episodes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ENumber` int(11) NOT NULL,
  `SNumber` int(11) NOT NULL,
  `SerieId` int(11) DEFAULT NULL,
  `VideoFileId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Episodes_SerieId` (`SerieId`),
  KEY `IX_Episodes_VideoFileId` (`VideoFileId`),
  CONSTRAINT `FK_Episodes_Archives_VideoFileId` FOREIGN KEY (`VideoFileId`) REFERENCES `archives` (`Id`),
  CONSTRAINT `FK_Episodes_Contents_SerieId` FOREIGN KEY (`SerieId`) REFERENCES `contents` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `episodes`
--

LOCK TABLES `episodes` WRITE;
/*!40000 ALTER TABLE `episodes` DISABLE KEYS */;
INSERT INTO `episodes` VALUES (1,1,1,3,6),(2,2,2,3,7);
/*!40000 ALTER TABLE `episodes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reviews` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Body` text,
  `ContentId` int(11) DEFAULT NULL,
  `Deslikes` int(11) NOT NULL DEFAULT '0',
  `Likes` int(11) NOT NULL DEFAULT '0',
  `Rating` tinyint(4) NOT NULL,
  `ReviewerId` int(11) DEFAULT NULL,
  `Title` text,
  PRIMARY KEY (`Id`),
  KEY `IX_Reviews_ContentId` (`ContentId`),
  KEY `IX_Reviews_ReviewerId` (`ReviewerId`),
  CONSTRAINT `FK_Reviews_Contents_ContentId` FOREIGN KEY (`ContentId`) REFERENCES `contents` (`Id`),
  CONSTRAINT `FK_Reviews_Users_ReviewerId` FOREIGN KEY (`ReviewerId`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AvatarId` int(11) DEFAULT NULL,
  `Birthday` datetime NOT NULL,
  `Email` text,
  `Name` text,
  `Password` varbinary(64) DEFAULT NULL,
  `Salt` varbinary(64) DEFAULT NULL,
  `UserName` text,
  PRIMARY KEY (`Id`),
  KEY `IX_Users_AvatarId` (`AvatarId`),
  CONSTRAINT `FK_Users_Archives_AvatarId` FOREIGN KEY (`AvatarId`) REFERENCES `archives` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,NULL,'2017-08-16 16:01:20',NULL,NULL,'\Â˘Zíƒºl¶©F˘UìÆ(\ﬁT¡d∑*°ÑX4\„;be[\–= ™®+4≤æ≈¨¶ñ»ü\'›ÅM∆ª8i˚ﬂú÷°¢','\È$Hn\ÓH!e6∑Tn´\ﬁ<ˆ5O\◊Q,|⁄π\‹¯\–7n\ÿ)ñ∏ÄN{ö˙-(®¶eSVó§\r\Íõ=É”Ø>','joao');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-18 16:04:32
