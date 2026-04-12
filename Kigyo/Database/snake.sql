-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Ápr 12. 21:20
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `snake`
--
CREATE DATABASE IF NOT EXISTS `snake` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `snake`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `snake`
--

CREATE TABLE `snake` (
  `Id` int(255) NOT NULL,
  `Nev` varchar(255) NOT NULL,
  `Pont` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `snake`
--

INSERT INTO `snake` (`Id`, `Nev`, `Pont`) VALUES
(1, 'Béla', 0),
(2, 'Ádám', 0),
(3, 'András', 3);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `snake`
--
ALTER TABLE `snake`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Nev` (`Nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `snake`
--
ALTER TABLE `snake`
  MODIFY `Id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
