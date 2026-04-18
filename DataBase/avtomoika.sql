-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Апр 18 2026 г., 23:18
-- Версия сервера: 5.7.24
-- Версия PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `avtomoika`
--

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `Nums` varchar(32) NOT NULL,
  `Client` varchar(100) NOT NULL,
  `id` int(11) UNSIGNED NOT NULL,
  `NumsMob` bigint(15) UNSIGNED DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `kuzova`
--

CREATE TABLE `kuzova` (
  `KuZOV` varchar(32) NOT NULL,
  `Xtime` float UNSIGNED NOT NULL,
  `XCost` float UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `list_operations`
--

CREATE TABLE `list_operations` (
  `id` int(10) UNSIGNED NOT NULL,
  `Data` datetime DEFAULT NULL,
  `NumsMob` bigint(100) DEFAULT NULL,
  `TipKuzov` varchar(100) DEFAULT NULL,
  `Uslugi` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `uslugi`
--

CREATE TABLE `uslugi` (
  `Usluga` varchar(50) NOT NULL,
  `Cost` float UNSIGNED NOT NULL,
  `time` float UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD UNIQUE KEY `id` (`id`),
  ADD UNIQUE KEY `NumsMob` (`NumsMob`),
  ADD KEY `Client` (`Client`) USING BTREE;

--
-- Индексы таблицы `kuzova`
--
ALTER TABLE `kuzova`
  ADD PRIMARY KEY (`KuZOV`);

--
-- Индексы таблицы `list_operations`
--
ALTER TABLE `list_operations`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `uslugi`
--
ALTER TABLE `uslugi`
  ADD PRIMARY KEY (`Usluga`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `list_operations`
--
ALTER TABLE `list_operations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
