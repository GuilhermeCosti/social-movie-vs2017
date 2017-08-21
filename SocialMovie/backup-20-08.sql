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
INSERT INTO `__efmigrationshistory` VALUES ('20170821014828_Initial','1.1.2');
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
) ENGINE=InnoDB AUTO_INCREMENT=166 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `archives`
--

LOCK TABLES `archives` WRITE;
/*!40000 ALTER TABLE `archives` DISABLE KEYS */;
INSERT INTO `archives` VALUES (1,'.jpg','split','split/',2),(2,'mpd','TheHollywoodBowl_vod','tom-and-jerry/TheHollywoodBowl_output',0),(3,'mpd','ThatsMyPup!_vod','tom-and-jerry/ThatsMyPup!_output',0),(4,'mpd','SolidSerenade_vod','tom-and-jerry/SolidSerenade_output',0),(5,'mpd','TheMissingMouse_vod','tom-and-jerry/TheMissingMouse_output',0),(6,'mpd','TheFlyingSorceress_vod','tom-and-jerry/TheFlyingSorceress_output',0),(7,'mpd','DogTrouble_vod','tom-and-jerry/DogTrouble_output',0),(8,'mpd','ShutterBuggedCat_vod','tom-and-jerry/ShutterBuggedCat_output',0),(9,'mpd','IsThereaDoctorintheMouse_vod','tom-and-jerry/IsThereaDoctorintheMouse_output',0),(10,'mpd','SurfBoredCat_vod','tom-and-jerry/SurfBoredCat_output',0),(11,'mpd','SaltWaterTabby_vod','tom-and-jerry/SaltWaterTabby_output',0),(12,'mpd','SnowbodyLovesMe_vod','tom-and-jerry/SnowbodyLovesMe_output',0),(13,'mpd','TexasTom_vod','tom-and-jerry/TexasTom_output',0),(14,'mpd','CatFishin_vod','tom-and-jerry/CatFishin_output',0),(15,'mpd','SmartyCat_vod','tom-and-jerry/SmartyCat_output',0),(16,'mpd','TheCatsMeOuch_vod','tom-and-jerry/TheCatsMeOuch_output',0),(17,'mpd','TheMidnightSnack_vod','tom-and-jerry/TheMidnightSnack_output',0),(18,'mpd','HiccupPup_vod','tom-and-jerry/HiccupPup_output',0),(19,'mpd','LandingStripling_vod','tom-and-jerry/LandingStripling_output',0),(20,'mpd','PussnToots_vod','tom-and-jerry/PussnToots_output',0),(21,'mpd','PosseCat_vod','tom-and-jerry/PosseCat_output',0),(22,'mpd','Dr.JekyllandMr.Mouse_vod','tom-and-jerry/Dr.JekyllandMr.Mouse_output',0),(23,'mpd','TrapHappy_vod','tom-and-jerry/TrapHappy_output',0),(24,'mpd','TheVanishingDuck_vod','tom-and-jerry/TheVanishingDuck_output',0),(25,'mpd','RocknRodent_vod','tom-and-jerry/RocknRodent_output',0),(26,'mpd','BuddiesThickerThanWater_vod','tom-and-jerry/BuddiesThickerThanWater_output',0),(27,'mpd','PartTimePal_vod','tom-and-jerry/PartTimePal_output',0),(28,'mpd','RobinHoodwinked_vod','tom-and-jerry/RobinHoodwinked_output',0),(29,'mpd','DuelPersonality_vod','tom-and-jerry/DuelPersonality_output',0),(30,'mpd','FittobeTied_vod','tom-and-jerry/FittobeTied_output',0),(31,'mpd','BarbecueBrawl_vod','tom-and-jerry/BarbecueBrawl_output',0),(32,'mpd','JerrysDiary_vod','tom-and-jerry/JerrysDiary_output',0),(33,'mpd','ThatsMyMommy_vod','tom-and-jerry/ThatsMyMommy_output',0),(34,'mpd','TheYankeeDoodleMouse_vod','tom-and-jerry/TheYankeeDoodleMouse_output',0),(35,'mpd','PushButtonKitty_vod','tom-and-jerry/PushButtonKitty_output',0),(36,'mpd','JerrysCousin_vod','tom-and-jerry/JerrysCousin_output',0),(37,'mpd','TheDogHouse_vod','tom-and-jerry/TheDogHouse_output',0),(38,'mpd','CueBallCat_vod','tom-and-jerry/CueBallCat_output',0),(39,'mpd','PuponaPicnic_vod','tom-and-jerry/PuponaPicnic_output',0),(40,'mpd','TheCatConcerto_vod','tom-and-jerry/TheCatConcerto_output',0),(41,'mpd','BlueCatBlues_vod','tom-and-jerry/BlueCatBlues_output',0),(42,'mpd','TheTomandJerryCartoonKit_vod','tom-and-jerry/TheTomandJerryCartoonKit_output',0),(43,'mpd','LittleSchoolMouse_vod','tom-and-jerry/LittleSchoolMouse_output',0),(44,'mpd','FeedintheKiddie_vod','tom-and-jerry/FeedintheKiddie_output',0),(45,'mpd','MuchAdoAboutMousing_vod','tom-and-jerry/MuchAdoAboutMousing_output',0),(46,'mpd','MouseIntoSpace_vod','tom-and-jerry/MouseIntoSpace_output',0),(47,'mpd','TennisChumps_vod','tom-and-jerry/TennisChumps_output',0),(48,'mpd','TomicEnergy_vod','tom-and-jerry/TomicEnergy_output',0),(49,'mpd','SufferinCats!_vod','tom-and-jerry/SufferinCats!_output',0),(50,'mpd','GuidedMouseille_vod','tom-and-jerry/GuidedMouseille_output',0),(51,'mpd','BabyButch_vod','tom-and-jerry/BabyButch_output',0),(52,'mpd','MouseCleaning_vod','tom-and-jerry/MouseCleaning_output',0),(53,'mpd','HeavenlyPuss_vod','tom-and-jerry/HeavenlyPuss_output',0),(54,'mpd','SleepyTimeTom_vod','tom-and-jerry/SleepyTimeTom_output',0),(55,'mpd','HappyGoDucky_vod','tom-and-jerry/HappyGoDucky_output',0),(56,'mpd','MouseTrouble_vod','tom-and-jerry/MouseTrouble_output',0),(57,'mpd','DownandOuting_vod','tom-and-jerry/DownandOuting_output',0),(58,'mpd','BusyBuddies_vod','tom-and-jerry/BusyBuddies_output',0),(59,'mpd','TimidTabby_vod','tom-and-jerry/TimidTabby_output',0),(60,'mpd','TheYearoftheMouse_vod','tom-and-jerry/TheYearoftheMouse_output',0),(61,'mpd','TheZootCat_vod','tom-and-jerry/TheZootCat_output',0),(62,'mpd','CalypsoCat_vod','tom-and-jerry/CalypsoCat_output',0),(63,'mpd','DownBeatBear_vod','tom-and-jerry/DownBeatBear_output',0),(64,'mpd','BadDayatCatRock_vod','tom-and-jerry/BadDayatCatRock_output',0),(65,'mpd','HisMouseFriday_vod','tom-and-jerry/HisMouseFriday_output',0),(66,'mpd','TomandCh#Uerie_vod','tom-and-jerry/TomandCh#Uerie_output',0),(67,'mpd','PecosPest_vod','tom-and-jerry/PecosPest_output',0),(68,'mpd','PolkaDotPuss_vod','tom-and-jerry/PolkaDotPuss_output',0),(69,'mpd','PentHouseMouse_vod','tom-and-jerry/PentHouseMouse_output',0),(70,'mpd','FineFeatheredFriend_vod','tom-and-jerry/FineFeatheredFriend_output',0),(71,'mpd','PuttinontheDog_vod','tom-and-jerry/PuttinontheDog_output',0),(72,'mpd','TheUnshrinkableJerryMouse_vod','tom-and-jerry/TheUnshrinkableJerryMouse_output',0),(73,'mpd','CattyCornered_vod','tom-and-jerry/CattyCornered_output',0),(74,'mpd','TheCatandtheMermouse_vod','tom-and-jerry/TheCatandtheMermouse_output',0),(75,'mpd','TeeforTwo_vod','tom-and-jerry/TeeforTwo_output',0),(76,'mpd','JerryJerryQuiteContrary_vod','tom-and-jerry/JerryJerryQuiteContrary_output',0),(77,'mpd','TheBrothersCarryMouseOff_vod','tom-and-jerry/TheBrothersCarryMouseOff_output',0),(78,'mpd','TheTwoMouseketeers_vod','tom-and-jerry/TheTwoMouseketeers_output',0),(79,'mpd','TotWatchers_vod','tom-and-jerry/TotWatchers_output',0),(80,'mpd','BabyPuss_vod','tom-and-jerry/BabyPuss_output',0),(81,'mpd','TheLonesomeMouse_vod','tom-and-jerry/TheLonesomeMouse_output',0),(82,'mpd','SouthboundDuckling_vod','tom-and-jerry/SouthboundDuckling_output',0),(83,'mpd','LittleQuacker_vod','tom-and-jerry/LittleQuacker_output',0),(84,'mpd','QuietPlease!_vod','tom-and-jerry/QuietPlease!_output',0),(85,'mpd','KittyFoiled_vod','tom-and-jerry/KittyFoiled_output',0),(86,'mpd','TheLittleOrphan_vod','tom-and-jerry/TheLittleOrphan_output',0),(87,'mpd','PurrChancetoDream_vod','tom-and-jerry/PurrChancetoDream_output',0),(88,'mpd','TheMousefromH.U.N.G.E.R._vod','tom-and-jerry/TheMousefromH.U.N.G.E.R._output',0),(89,'mpd','FlirtyBirdy_vod','tom-and-jerry/FlirtyBirdy_output',0),(90,'mpd','CatNapping_vod','tom-and-jerry/CatNapping_output',0),(91,'mpd','SwitchinKitten_vod','tom-and-jerry/SwitchinKitten_output',0),(92,'mpd','LoveThatPup_vod','tom-and-jerry/LoveThatPup_output',0),(93,'mpd','AhSweetMouseStoryofLife_vod','tom-and-jerry/AhSweetMouseStoryofLife_output',0),(94,'mpd','CasanovaCat_vod','tom-and-jerry/CasanovaCat_output',0),(95,'mpd','TheFramedCat_vod','tom-and-jerry/TheFramedCat_output',0),(96,'mpd','HighSteaks_vod','tom-and-jerry/HighSteaks_output',0),(97,'mpd','PetPeeve_vod','tom-and-jerry/PetPeeve_output',0),(98,'mpd','SaturdayEveningPuss_vod','tom-and-jerry/SaturdayEveningPuss_output',0),(99,'mpd','MiceFollies_vod','tom-and-jerry/MiceFollies_output',0),(100,'mpd','TallintheTrap_vod','tom-and-jerry/TallintheTrap_output',0),(101,'mpd','TheDuckDoctor_vod','tom-and-jerry/TheDuckDoctor_output',0),(102,'mpd','SorrySafari_vod','tom-and-jerry/SorrySafari_output',0),(103,'mpd','TripletTrouble_vod','tom-and-jerry/TripletTrouble_output',0),(104,'mpd','TopswithPops_vod','tom-and-jerry/TopswithPops_output',0),(105,'mpd','stream','split/video',1),(106,'.jpg','tom','jerry/',2),(107,'mpd','JerryGoRound_vod','JerryGoRound_output',0),(108,'mpd','NeapolitanMouse_vod','tom-and-jerry/NeapolitanMouse_output',0),(109,'mpd','MouseinManhattan_vod','tom-and-jerry/MouseinManhattan_output',0),(110,'mpd','SafetySecond_vod','tom-and-jerry/SafetySecond_output',0),(111,'mpd','TheBowlingAlleyCat_vod','tom-and-jerry/TheBowlingAlleyCat_output',0),(112,'mpd','DesignsonJerry_vod','tom-and-jerry/DesignsonJerry_output',0),(113,'mpd','TheTruceHurts_vod','tom-and-jerry/TheTruceHurts_output',0),(114,'mpd','MuchoMouse_vod','tom-and-jerry/MuchoMouse_output',0),(115,'mpd','JohannMouse_vod','tom-and-jerry/JohannMouse_output',0),(116,'mpd','TheFlyingCat_vod','tom-and-jerry/TheFlyingCat_output',0),(117,'mpd','CarmenGetIt!_vod','tom-and-jerry/CarmenGetIt!_output',0),(118,'mpd','LoveMeLoveMyMouse_vod','tom-and-jerry/LoveMeLoveMyMouse_output',0),(119,'mpd','CatandDuplicat_vod','tom-and-jerry/CatandDuplicat_output',0),(120,'mpd','TheATomInableSnowman_vod','tom-and-jerry/TheATomInableSnowman_output',0),(121,'mpd','SlickedupPup_vod','tom-and-jerry/SlickedupPup_output',0),(122,'mpd','LittleRunaway_vod','tom-and-jerry/LittleRunaway_output',0),(123,'mpd','TheInvisibleMouse_vod','tom-and-jerry/TheInvisibleMouse_output',0),(124,'mpd','TheBodyguard_vod','tom-and-jerry/TheBodyguard_output',0),(125,'mpd','AdvanceandBeMechanized_vod','tom-and-jerry/AdvanceandBeMechanized_output',0),(126,'mpd','HauntedMouse_vod','tom-and-jerry/HauntedMouse_output',0),(127,'mpd','JerryandtheGoldfish_vod','tom-and-jerry/JerryandtheGoldfish_output',0),(128,'mpd','TomsPhotoFinish_vod','tom-and-jerry/TomsPhotoFinish_output',0),(129,'mpd','TheEggandJerry_vod','tom-and-jerry/TheEggandJerry_output',0),(130,'mpd','OfFelineBondage_vod','tom-and-jerry/OfFelineBondage_output',0),(131,'mpd','LifewithTom_vod','tom-and-jerry/LifewithTom_output',0),(132,'mpd','DickyMoe_vod','tom-and-jerry/DickyMoe_output',0),(133,'mpd','ItsGreektoMeow_vod','tom-and-jerry/ItsGreektoMeow_output',0),(134,'mpd','PuppyTale_vod','tom-and-jerry/PuppyTale_output',0),(135,'mpd','MouseforSale_vod','tom-and-jerry/MouseforSale_output',0),(136,'mpd','MatineeMouse_vod','tom-and-jerry/MatineeMouse_output',0),(137,'mpd','ProfessorTom_vod','tom-and-jerry/ProfessorTom_output',0),(138,'mpd','RoyalCatNap_vod','tom-and-jerry/RoyalCatNap_output',0),(139,'mpd','TheMillionDollarCat_vod','tom-and-jerry/TheMillionDollarCat_output',0),(140,'mpd','ImJustWildAboutJerry_vod','tom-and-jerry/ImJustWildAboutJerry_output',0),(141,'mpd','JustDucky_vod','tom-and-jerry/JustDucky_output',0),(142,'mpd','TheCatAboveandtheMouseBelow_vod','tom-and-jerry/TheCatAboveandtheMouseBelow_output',0),(143,'mpd','FiletMeow_vod','tom-and-jerry/FiletMeow_output',0),(144,'mpd','NitWittyKitty_vod','tom-and-jerry/NitWittyKitty_output',0),(145,'mpd','SmittenKitten_vod','tom-and-jerry/SmittenKitten_output',0),(146,'mpd','CanneryRodent_vod','tom-and-jerry/CanneryRodent_output',0),(147,'mpd','TheMilkyWaif_vod','tom-and-jerry/TheMilkyWaif_output',0),(148,'mpd','AMouseintheHouse_vod','tom-and-jerry/AMouseintheHouse_output',0),(149,'mpd','TheMouseComestoDinner_vod','tom-and-jerry/TheMouseComestoDinner_output',0),(150,'mpd','PussGetstheBoot_vod','tom-and-jerry/PussGetstheBoot_output',0),(151,'mpd','FraidyCat_vod','tom-and-jerry/FraidyCat_output',0),(152,'mpd','CruiseCat_vod','tom-and-jerry/CruiseCat_output',0),(153,'mpd','PussnBoats_vod','tom-and-jerry/PussnBoats_output',0),(154,'mpd','SpringtimeforThomas_vod','tom-and-jerry/SpringtimeforThomas_output',0),(155,'mpd','MuscleBeachTom_vod','tom-and-jerry/MuscleBeachTom_output',0),(156,'mpd','JerryGoRound_vod','tom-and-jerry/JerryGoRound_output',0),(157,'mpd','Touch#UePussyCat!_vod','tom-and-jerry/Touch#UePussyCat!_output',0),(158,'mpd','DownheartedDuckling_vod','tom-and-jerry/DownheartedDuckling_output',0),(159,'mpd','OSolarMeow_vod','tom-and-jerry/OSolarMeow_output',0),(160,'mpd','TwoLittleIndians_vod','tom-and-jerry/TwoLittleIndians_output',0),(161,'mpd','JerryandtheLion_vod','tom-and-jerry/JerryandtheLion_output',0),(162,'mpd','HatchUpYourTroubles_vod','tom-and-jerry/HatchUpYourTroubles_output',0),(163,'mpd','JerryandJumbo_vod','tom-and-jerry/JerryandJumbo_output',0),(164,'mpd','OldRockinChairTom_vod','tom-and-jerry/OldRockinChairTom_output',0),(165,'mpd','TheNightBeforeChristmas_vod','tom-and-jerry/TheNightBeforeChristmas_output',0);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contents`
--

LOCK TABLES `contents` WRITE;
/*!40000 ALTER TABLE `contents` DISABLE KEYS */;
INSERT INTO `contents` VALUES (1,'Rapaz que rouba mocas','Movie','Split',10,20,30,40,50,1,1,105),(2,'Gato e rato','Serie','Tom and Jerry',10,20,30,40,50,106,2,NULL);
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
  `Name` text,
  `SNumber` int(11) NOT NULL,
  `SerieId` int(11) DEFAULT NULL,
  `VideoFileId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Episodes_SerieId` (`SerieId`),
  KEY `IX_Episodes_VideoFileId` (`VideoFileId`),
  CONSTRAINT `FK_Episodes_Archives_VideoFileId` FOREIGN KEY (`VideoFileId`) REFERENCES `archives` (`Id`),
  CONSTRAINT `FK_Episodes_Contents_SerieId` FOREIGN KEY (`SerieId`) REFERENCES `contents` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=163 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `episodes`
--

LOCK TABLES `episodes` WRITE;
/*!40000 ALTER TABLE `episodes` DISABLE KEYS */;
INSERT INTO `episodes` VALUES (1,1,NULL,1,2,107),(2,0,'ThatsMyPup!',103,2,3),(3,0,'SolidSerenade',104,2,4),(4,0,'TheMissingMouse',105,2,5),(5,0,'TheFlyingSorceress',106,2,6),(6,0,'DogTrouble',107,2,7),(7,0,'ShutterBuggedCat',108,2,8),(8,0,'SurfBoredCat',109,2,10),(9,0,'TheHollywoodBowl',102,2,2),(10,0,'HiccupPup',110,2,18),(11,0,'SnowbodyLovesMe',112,2,12),(12,0,'TexasTom',113,2,13),(13,0,'CatFishin',114,2,14),(14,0,'SmartyCat',115,2,15),(15,0,'TheCatsMeOuch',116,2,16),(16,0,'TheMidnightSnack',117,2,17),(17,0,'PuponaPicnic',118,2,39),(18,0,'SaltWaterTabby',111,2,11),(19,0,'TheCatConcerto',119,2,40),(20,0,'IsThereaDoctorintheMouse',101,2,9),(21,0,'PussnToots',99,2,20),(22,0,'TheVanishingDuck',83,2,24),(23,0,'RocknRodent',84,2,25),(24,0,'BuddiesThickerThanWater',85,2,26),(25,0,'PartTimePal',86,2,27),(26,0,'RobinHoodwinked',87,2,28),(27,0,'DuelPersonality',88,2,29),(28,0,'FittobeTied',89,2,30),(29,0,'LandingStripling',100,2,19),(30,0,'BarbecueBrawl',90,2,31),(31,0,'ThatsMyMommy',92,2,33),(32,0,'TheYankeeDoodleMouse',93,2,34),(33,0,'PushButtonKitty',94,2,35),(34,0,'JerrysCousin',95,2,36),(35,0,'TheDogHouse',96,2,37),(36,0,'CueBallCat',97,2,38),(37,0,'PosseCat',98,2,21),(38,0,'JerrysDiary',91,2,32),(39,0,'BlueCatBlues',120,2,41),(40,0,'TheTomandJerryCartoonKit',121,2,42),(41,0,'BadDayatCatRock',122,2,64),(42,0,'FeedintheKiddie',144,2,44),(43,0,'MuchAdoAboutMousing',145,2,45),(44,0,'MouseIntoSpace',146,2,46),(45,0,'TennisChumps',147,2,47),(46,0,'TomicEnergy',148,2,48),(47,0,'SufferinCats!',149,2,49),(48,0,'GuidedMouseille',150,2,50),(49,0,'LittleSchoolMouse',143,2,43),(50,0,'BabyButch',151,2,51),(51,0,'HeavenlyPuss',153,2,53),(52,0,'SleepyTimeTom',154,2,54),(53,0,'HappyGoDucky',155,2,55),(54,0,'MouseTrouble',156,2,56),(55,0,'DownandOuting',157,2,57),(56,0,'BusyBuddies',158,2,58),(57,0,'TimidTabby',159,2,59),(58,0,'MouseCleaning',152,2,52),(59,0,'TheYearoftheMouse',142,2,60),(60,0,'CalypsoCat',141,2,62),(61,0,'TheLonesomeMouse',140,2,81),(62,0,'HisMouseFriday',123,2,65),(63,0,'TomandCh#Uerie',124,2,66),(64,0,'PecosPest',125,2,67),(65,0,'PolkaDotPuss',126,2,68),(66,0,'PentHouseMouse',127,2,69),(67,0,'FineFeatheredFriend',128,2,70),(68,0,'PuttinontheDog',129,2,71),(69,0,'TheUnshrinkableJerryMouse',130,2,72),(70,0,'CattyCornered',131,2,73),(71,0,'TheCatandtheMermouse',132,2,74),(72,0,'TeeforTwo',133,2,75),(73,0,'JerryJerryQuiteContrary',134,2,76),(74,0,'TheBrothersCarryMouseOff',135,2,77),(75,0,'TheTwoMouseketeers',136,2,78),(76,0,'TotWatchers',137,2,79),(77,0,'BabyPuss',138,2,80),(78,0,'DownBeatBear',139,2,63),(79,0,'TrapHappy',82,2,23),(80,0,'Dr.JekyllandMr.Mouse',81,2,22),(81,0,'TheZootCat',80,2,61),(82,0,'LittleQuacker',79,2,83),(83,0,'TheMousefromH.U.N.G.E.R.',22,2,88),(84,0,'FlirtyBirdy',23,2,89),(85,0,'CatNapping',24,2,90),(86,0,'SwitchinKitten',25,2,91),(87,0,'AhSweetMouseStoryofLife',26,2,93),(88,0,'TheDuckDoctor',27,2,101),(89,0,'CasanovaCat',28,2,94),(90,0,'PurrChancetoDream',21,2,87),(91,0,'TheFramedCat',29,2,95),(92,0,'PetPeeve',31,2,97),(93,0,'SaturdayEveningPuss',32,2,98),(94,0,'MiceFollies',33,2,99),(95,0,'TallintheTrap',34,2,100),(96,0,'LittleRunaway',35,2,122),(97,0,'TheInvisibleMouse',36,2,123),(98,0,'TheBodyguard',37,2,124),(99,0,'HighSteaks',30,2,96),(100,0,'TheLittleOrphan',20,2,86),(101,0,'KittyFoiled',19,2,85),(102,0,'LoveThatPup',18,2,92),(103,0,'NeapolitanMouse',1,2,108),(104,0,'MouseinManhattan',2,2,109),(105,0,'SafetySecond',3,2,110),(106,0,'TheBowlingAlleyCat',4,2,111),(107,0,'DesignsonJerry',5,2,112),(108,0,'TheTruceHurts',6,2,113),(109,0,'MuchoMouse',7,2,114),(110,0,'JohannMouse',8,2,115),(111,0,'TheFlyingCat',9,2,116),(112,0,'CarmenGetIt!',10,2,117),(113,0,'LoveMeLoveMyMouse',11,2,118),(114,0,'CatandDuplicat',12,2,119),(115,0,'TheATomInableSnowman',13,2,120),(116,0,'SlickedupPup',14,2,121),(117,0,'TopswithPops',15,2,104),(118,0,'TripletTrouble',16,2,103),(119,0,'SorrySafari',17,2,102),(120,0,'AdvanceandBeMechanized',38,2,125),(121,0,'SouthboundDuckling',160,2,82),(122,0,'TheMilkyWaif',39,2,147),(123,0,'TheMouseComestoDinner',41,2,149),(124,0,'TheEggandJerry',63,2,129),(125,0,'OfFelineBondage',64,2,130),(126,0,'LifewithTom',65,2,131),(127,0,'DickyMoe',66,2,132),(128,0,'ItsGreektoMeow',67,2,133),(129,0,'PuppyTale',68,2,134),(130,0,'MouseforSale',69,2,135),(131,0,'TomsPhotoFinish',62,2,128),(132,0,'MatineeMouse',70,2,136),(133,0,'RoyalCatNap',72,2,138),(134,0,'TheMillionDollarCat',73,2,139),(135,0,'ImJustWildAboutJerry',74,2,140),(136,0,'JustDucky',75,2,141),(137,0,'TheCatAboveandtheMouseBelow',76,2,142),(138,0,'QuietPlease!',77,2,84),(139,0,'NitWittyKitty',78,2,144),(140,0,'ProfessorTom',71,2,137),(141,0,'JerryandtheGoldfish',61,2,127),(142,0,'HauntedMouse',60,2,126),(143,0,'FiletMeow',59,2,143),(144,0,'PussGetstheBoot',42,2,150),(145,0,'FraidyCat',43,2,151),(146,0,'CruiseCat',44,2,152),(147,0,'PussnBoats',45,2,153),(148,0,'SpringtimeforThomas',46,2,154),(149,0,'MuscleBeachTom',47,2,155),(150,0,'JerryGoRound',48,2,156),(151,0,'Touch#UePussyCat!',49,2,157),(152,0,'DownheartedDuckling',50,2,158),(153,0,'OSolarMeow',51,2,159),(154,0,'TwoLittleIndians',52,2,160),(155,0,'JerryandtheLion',53,2,161),(156,0,'HatchUpYourTroubles',54,2,162),(157,0,'JerryandJumbo',55,2,163),(158,0,'CanneryRodent',56,2,146),(159,0,'OldRockinChairTom',57,2,164),(160,0,'SmittenKitten',58,2,145),(161,0,'AMouseintheHouse',40,2,148),(162,0,'TheNightBeforeChristmas',161,2,165);
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
  `ArchiveId` int(11) NOT NULL,
  `Body` text,
  `Deslikes` int(11) NOT NULL DEFAULT '0',
  `Likes` int(11) NOT NULL DEFAULT '0',
  `Rating` tinyint(4) NOT NULL,
  `ReviewerId` int(11) NOT NULL,
  `Title` text,
  PRIMARY KEY (`Id`)
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
INSERT INTO `users` VALUES (1,NULL,'2017-08-20 22:52:41',NULL,NULL,'f¯Co#\∆\Ó7\÷v\…\”	Ñ\Ô≤:∆æÉ\Ô:øy\ƒ;\’B\„<#{Qx˚á+™˛Éhf%£»çêÃ≠ï\‡¯S˜àÜÀí',',Ù‹Æ@ôKf>˛T{¯r¬ª\ÁgGH∏?∏\¬TNRE\r\ÂÆ?äÇ¥*#y¥ï3\≈_g699ô£æp(\‹\‘\Ê\‘\Î\ZqÅ‘õVó','joao');
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

-- Dump completed on 2017-08-20 23:16:34
