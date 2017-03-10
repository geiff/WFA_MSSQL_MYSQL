-- --------------------------------------------------------
-- Хост:                         127.0.0.1
-- Версия на сървъра:            5.6.35-log - MySQL Community Server (GPL)
-- ОС на сървъра:                Win64
-- HeidiSQL Версия:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for register_of_immunized_cows
CREATE DATABASE IF NOT EXISTS `register_of_immunized_cows` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `register_of_immunized_cows`;

-- Дъмп структура за таблица register_of_immunized_cows.cows
CREATE TABLE IF NOT EXISTS `cows` (
  `Id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `NumberOnCow` int(10) unsigned NOT NULL,
  `PopulatedPlace` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `NumberOnCow_PopulatedPlace` (`NumberOnCow`,`PopulatedPlace`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- Дъмп данни за таблица register_of_immunized_cows.cows: ~38 rows (approximately)
DELETE FROM `cows`;
/*!40000 ALTER TABLE `cows` DISABLE KEYS */;
/*!40000 ALTER TABLE `cows` ENABLE KEYS */;

-- Дъмп структура за таблица register_of_immunized_cows.immunizations
CREATE TABLE IF NOT EXISTS `immunizations` (
  `Id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

-- Дъмп данни за таблица register_of_immunized_cows.immunizations: ~24 rows (approximately)
DELETE FROM `immunizations`;
/*!40000 ALTER TABLE `immunizations` DISABLE KEYS */;
/*!40000 ALTER TABLE `immunizations` ENABLE KEYS */;

-- Дъмп структура за таблица register_of_immunized_cows.registers
CREATE TABLE IF NOT EXISTS `registers` (
  `Id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `CowID` int(5) unsigned NOT NULL,
  `ImmunisationID` int(5) unsigned NOT NULL,
  `DateOnImmunization` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `CowID_ImmunisationID_DateOnImmunization` (`CowID`,`ImmunisationID`,`DateOnImmunization`),
  KEY `FK_registers_immunizations` (`ImmunisationID`),
  CONSTRAINT `FK_registers_cows` FOREIGN KEY (`CowID`) REFERENCES `cows` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_registers_immunizations` FOREIGN KEY (`ImmunisationID`) REFERENCES `immunizations` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

-- Дъмп данни за таблица register_of_immunized_cows.registers: ~31 rows (approximately)
DELETE FROM `registers`;
/*!40000 ALTER TABLE `registers` DISABLE KEYS */;
/*!40000 ALTER TABLE `registers` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
