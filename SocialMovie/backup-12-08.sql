-- MySQL dump 10.13  Distrib 5.7.18, for Win64 (x86_64)
--
-- Host: localhost    Database: socialmovie
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
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movies` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` text COLLATE utf8mb4_unicode_ci,
  `Extension` text COLLATE utf8mb4_unicode_ci,
  `File` text COLLATE utf8mb4_unicode_ci,
  `MediaURL` text COLLATE utf8mb4_unicode_ci,
  `Name` text COLLATE utf8mb4_unicode_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies`
--

LOCK TABLES `movies` WRITE;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` VALUES (1, '1999-12-12 14:12:14','Rapaz muito doido com varias personalidades sequestras 3 garotas e fara loucuras','mpd','stream','split/video','Split'),(2,'A guerreira','mpd','stream','sintelshaka','Sintel'),(3,'A noite dos mortos vivos','mpd','stream','nightofthelivingdead','Night of the living dead'),(4,'Picapau ├â┬® um p├â┬íssaro da pesada','mpd','stream','picapau','Picapau'),(5,NULL,'mpd','Betty_Boop_A_Song_a_Day_1936_512kb_vod','Betty_Boop_A_Song_a_Day_1936_512kb_output','betty');
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AvatarImagePath` text,
  `Birthday` datetime NOT NULL,
  `Email` text,
  `Name` text,
  `Password` varbinary(128) DEFAULT NULL,
  `UserName` text,
  `Salt` varbinary(128) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (4,NULL,'2017-08-12 22:21:12',NULL,NULL,'╦ïU+\┘X\█·e\0ú	¿±#Aaè©\▀J-¥K\þ\─9\═\═Wô\╦┴ö\Í<íÖ,\╔¾ÁÅäkú┌Ç¬}\"@','maria','§:ÖP\'p┤æ\╚G\Ú­nÄú¼ÐÁ\┼|\ZÁ\╩Gi¶╗▓«p\Þ‗Âî\¯×╚╝©¼÷\┬\Ãªñ63âËâhªq\µ\Ê\ßí('),(5,NULL,'2017-08-12 22:23:50',NULL,NULL,'§\\H=\Ú╦úxI\╩4┴\µØ\ı`%\ÞÑ±ÉZÇîQ07\ÏTâ6\Ë\Ý\¤?\┘┘ê¿\▀^Áf|B\Z)\Z \ÊPá\▄W8Ä\╬/P\Z','joao-pio','\╩\┘\┼·ô|\─Wx#ÍÀ\Û\┼!NEs▀ç :\Ë¨Sco\0ø§»nÏú¹}\'ñ\ÍvV1▀ñ»×~-³l@3\0v'),(6,NULL,'2017-08-12 22:27:41',NULL,NULL,'▓\n¶\┘!¸[¸\╩G┤i¸	·°ö²\╬§¹ùÿ\▀¾\'╝,ìU¶¼<·T┴F┘ú\ý\´Ør·eP«ƒ\Þ╩Ø>\╚\═\È|GØ','joao','}M\═°\ÒwQ××Éîqêjm\Ó▄ª\¦ó\ÝB`),┤a\Õÿkà\\¬\¯\ã=\╩y║ª\├XkKkî╝è\┘d\Òî'),(7,NULL,'2017-08-13 13:50:24',NULL,NULL,'`¼N$8M²m\▀¤Ç¼\┘ü{5ª,q-\▀5º®iI±ñÉbhºS┴U[G¬\Î\├c6øv+\╔\Ã\µK3.öU;:\╠','carlos','$M¹G%CêØa¦Àv5\╦\ß¬5\Ú`B¢§ó²lR\├7N[ò\ß¬]1·F└9+Ñª\È!y\─\Ã\¤┴­▓\Ó\Í§Z¹i\╔\╔\▀¶.');
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

-- Dump completed on 2017-08-13 18:45:53
