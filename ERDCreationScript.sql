-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema VideoGameDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema VideoGameDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `VideoGameDB` DEFAULT CHARACTER SET utf8 ;
USE `VideoGameDB` ;

-- -----------------------------------------------------
-- Table `VideoGameDB`.`Team`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Team` (
  `Team_ID` INT NOT NULL,
  `Player_ID_Leader` INT NOT NULL,
  `Team_Name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Team_ID`),
  INDEX `fk_Team_Player1_idx` (`Player_ID_Leader` ASC) VISIBLE,
  UNIQUE INDEX `Team_Name_UNIQUE` (`Team_Name` ASC) VISIBLE,
  UNIQUE INDEX `Player_ID_Leader_UNIQUE` (`Player_ID_Leader` ASC) VISIBLE,
  UNIQUE INDEX `Team_ID_UNIQUE` (`Team_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Team_Player1`
    FOREIGN KEY (`Player_ID_Leader`)
    REFERENCES `VideoGameDB`.`Player` (`Player_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Account`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Account` (
  `Account_ID` INT NOT NULL,
  `Account_Username` VARCHAR(30) NOT NULL,
  `Account_Password` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Account_ID`),
  UNIQUE INDEX `Account_ID_UNIQUE` (`Account_ID` ASC) VISIBLE,
  UNIQUE INDEX `Account_Username_UNIQUE` (`Account_Username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Player`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Player` (
  `Player_ID` INT NOT NULL,
  `Player_Username` VARCHAR(30) NOT NULL,
  `Team_ID` INT NULL,
  `Account_ID` INT NOT NULL,
  PRIMARY KEY (`Player_ID`),
  UNIQUE INDEX `Player_ID_UNIQUE` (`Player_ID` ASC) VISIBLE,
  UNIQUE INDEX `Player_Username_UNIQUE` (`Player_Username` ASC) VISIBLE,
  INDEX `fk_Player_Team1_idx` (`Team_ID` ASC) VISIBLE,
  INDEX `fk_Player_Account1_idx` (`Account_ID` ASC) VISIBLE,
  UNIQUE INDEX `Account_Account_ID_UNIQUE` (`Account_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Player_Team1`
    FOREIGN KEY (`Team_ID`)
    REFERENCES `VideoGameDB`.`Team` (`Team_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Player_Account1`
    FOREIGN KEY (`Account_ID`)
    REFERENCES `VideoGameDB`.`Account` (`Account_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Game`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Game` (
  `Game_ID` INT NOT NULL,
  `Game_Title` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Game_ID`),
  UNIQUE INDEX `Game_ID_UNIQUE` (`Game_ID` ASC) VISIBLE,
  UNIQUE INDEX `Game_Title_UNIQUE` (`Game_Title` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Gamemode`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Gamemode` (
  `Gamemode_ID` INT NOT NULL,
  `Gamemode_Name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Gamemode_ID`),
  UNIQUE INDEX `Gamemode_ID_UNIQUE` (`Gamemode_ID` ASC) VISIBLE,
  UNIQUE INDEX `Gamemode_Name_UNIQUE` (`Gamemode_Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Gametype`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Gametype` (
  `Gamemode_ID` INT NOT NULL,
  `Game_ID` INT NOT NULL,
  `Gametype_ExpectedTime` INT NULL,
  PRIMARY KEY (`Gamemode_ID`, `Game_ID`),
  INDEX `fk_Gametype_Game1_idx` (`Game_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Gametype_Gamemode`
    FOREIGN KEY (`Gamemode_ID`)
    REFERENCES `VideoGameDB`.`Gamemode` (`Gamemode_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Gametype_Game1`
    FOREIGN KEY (`Game_ID`)
    REFERENCES `VideoGameDB`.`Game` (`Game_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`StatType`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`StatType` (
  `StatType_ID` INT NOT NULL,
  `StatType_Name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`StatType_ID`),
  UNIQUE INDEX `StatType_ID_UNIQUE` (`StatType_ID` ASC) VISIBLE,
  UNIQUE INDEX `StatType_Name_UNIQUE` (`StatType_Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Stat`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Stat` (
  `Player_ID` INT NOT NULL,
  `Gametype_Gamemode_ID` INT NOT NULL,
  `Gametype_Game_ID` INT NOT NULL,
  `StatType_ID` INT NOT NULL,
  `Stat_Value` INT NULL,
  PRIMARY KEY (`Player_ID`, `Gametype_Gamemode_ID`, `Gametype_Game_ID`, `StatType_ID`),
  INDEX `fk_Stats_Gametype1_idx` (`Gametype_Gamemode_ID` ASC, `Gametype_Game_ID` ASC) VISIBLE,
  INDEX `fk_Stat_StatType1_idx` (`StatType_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Stats_Player1`
    FOREIGN KEY (`Player_ID`)
    REFERENCES `VideoGameDB`.`Player` (`Player_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Stats_Gametype1`
    FOREIGN KEY (`Gametype_Gamemode_ID` , `Gametype_Game_ID`)
    REFERENCES `VideoGameDB`.`Gametype` (`Gamemode_ID` , `Game_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Stat_StatType1`
    FOREIGN KEY (`StatType_ID`)
    REFERENCES `VideoGameDB`.`StatType` (`StatType_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`Friend`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`Friend` (
  `Player_ID_Requester` INT NOT NULL,
  `Player_ID_Receiver` INT NOT NULL,
  `Friend_Pending` TINYINT NOT NULL,
  PRIMARY KEY (`Player_ID_Requester`, `Player_ID_Receiver`),
  INDEX `fk_Friend_Player2_idx` (`Player_ID_Receiver` ASC) VISIBLE,
  CONSTRAINT `fk_Friend_Player1`
    FOREIGN KEY (`Player_ID_Requester`)
    REFERENCES `VideoGameDB`.`Player` (`Player_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Friend_Player2`
    FOREIGN KEY (`Player_ID_Receiver`)
    REFERENCES `VideoGameDB`.`Player` (`Player_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`GameStatType`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`GameStatType` (
  `GameStatType_ID` INT NOT NULL,
  `GameStatType_Name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`GameStatType_ID`),
  UNIQUE INDEX `GameStatType_ID_UNIQUE` (`GameStatType_ID` ASC) VISIBLE,
  UNIQUE INDEX `GameStatType_Name_UNIQUE` (`GameStatType_Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `VideoGameDB`.`GameStat`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `VideoGameDB`.`GameStat` (
  `Player_ID` INT NOT NULL,
  `Game_ID` INT NOT NULL,
  `GameStatType_ID` INT NOT NULL,
  `GameStat_Value` INT NULL,
  PRIMARY KEY (`Player_ID`, `Game_ID`, `GameStatType_ID`),
  INDEX `fk_GameStats_Game1_idx` (`Game_ID` ASC) VISIBLE,
  INDEX `fk_GameStat_GameStatType1_idx` (`GameStatType_ID` ASC) VISIBLE,
  CONSTRAINT `fk_GameStats_Player1`
    FOREIGN KEY (`Player_ID`)
    REFERENCES `VideoGameDB`.`Player` (`Player_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_GameStats_Game1`
    FOREIGN KEY (`Game_ID`)
    REFERENCES `VideoGameDB`.`Game` (`Game_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_GameStat_GameStatType1`
    FOREIGN KEY (`GameStatType_ID`)
    REFERENCES `VideoGameDB`.`GameStatType` (`GameStatType_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE VIEW Gametype_Info AS
SELECT Gametype.Gamemode_ID AS Gamemode_ID, Gametype.Game_ID AS Game_ID,
	   Gametype_ExpectedTime, Game_Title, Gamemode_Name
FROM Gametype JOIN Game ON Gametype.Game_ID = Game.Game_ID
			  JOIN Gamemode ON Gametype.Gamemode_ID = Gamemode.Gamemode_ID;

CREATE VIEW Stats_Info AS
SELECT Player.Player_ID AS Player_ID, Player_Username, Team_ID,
	   Account_ID, Stat_Value, StatType_Name, Game_Title, Gamemode_Name
FROM Player JOIN Stat ON Player.Player_ID = Stat.Player_ID
			JOIN StatType ON Stat.StatType_ID = StatType.StatType_ID
            JOIN Gametype_Info ON Stat.Gametype_Game_ID = Gametype_Info.Game_ID
							 and Stat.Gametype_Gamemode_ID = Gametype_Info.Gamemode_ID;

CREATE VIEW GameStats_Info AS
SELECT Player.Player_ID AS Player_ID, Player_Username, Team_ID,
	   Account_ID, GameStat_Value, GameStatType_Name, Game_Title
FROM Player JOIN GameStat ON Player.Player_ID = GameStat.Player_ID
			JOIN GameStatType ON GameStat.GameStatType_ID = GameStatType.GameStatType_ID
            JOIN Game ON GameStat.Game_ID = Game.Game_ID;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
