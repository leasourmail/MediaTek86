-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 28 mai 2025 à 14:32
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'mediatek86'@'%' IDENTIFIED BY 'mediatheque86Vienne';
GRANT USAGE ON *.* TO 'mediatek86'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(8, '2025-03-27 06:13:45', '2025-05-13 15:16:44', 3),
(7, '2024-09-27 07:52:06', '2024-09-29 21:24:54', 2),
(11, '2024-12-05 23:52:29', '2024-12-25 22:18:47', 3),
(5, '2025-02-14 07:55:29', '2025-03-01 23:10:52', 1),
(13, '2025-03-05 15:05:43', '2025-04-05 21:07:38', 3),
(2, '2024-05-22 10:15:27', '2024-07-14 06:54:11', 4),
(12, '2025-02-07 23:14:06', '2025-02-23 04:47:54', 1),
(7, '2024-11-07 05:59:21', '2024-11-10 07:21:19', 2),
(15, '2024-10-06 23:27:30', '2024-11-13 15:49:23', 2),
(9, '2024-08-23 18:36:11', '2024-10-12 14:01:22', 2),
(10, '2024-08-29 09:49:47', '2024-10-05 06:25:25', 1),
(3, '2024-10-17 08:30:46', '2024-11-05 13:43:18', 4),
(7, '2025-03-26 06:39:39', '2025-06-03 04:02:32', 1),
(4, '2025-04-25 01:02:22', '2025-10-23 07:52:05', 2),
(1, '2024-11-19 20:46:11', '2024-11-26 17:23:42', 3),
(8, '2024-05-05 21:43:48', '2024-06-02 01:51:30', 2),
(2, '2024-06-08 11:20:35', '2024-07-22 15:28:30', 2),
(5, '2024-12-17 07:29:59', '2024-12-18 00:15:20', 4),
(10, '2024-12-04 13:36:54', '2024-12-12 06:40:14', 2),
(3, '2025-01-17 12:03:16', '2025-02-01 18:18:37', 2),
(8, '2024-08-29 01:29:45', '2024-08-31 22:02:28', 2),
(12, '2024-07-19 21:11:55', '2024-07-25 03:20:51', 3),
(6, '2024-07-23 21:14:18', '2024-09-20 01:51:06', 3),
(10, '2025-05-27 15:08:18', '2025-05-28 15:08:18', 3),
(9, '2024-06-12 15:26:03', '2024-08-04 10:54:36', 2),
(1, '2025-03-27 19:56:11', '2025-04-16 09:48:49', 1),
(3, '2024-08-12 03:20:54', '2024-09-27 18:44:00', 2),
(5, '2024-05-30 10:21:30', '2024-09-06 01:27:37', 4),
(15, '2025-01-19 21:59:42', '2025-03-20 17:20:04', 1),
(2, '2024-07-28 06:39:48', '2024-10-22 03:42:06', 3),
(8, '2024-09-15 12:21:03', '2024-09-30 20:53:34', 4),
(5, '2024-03-23 15:45:36', '2024-06-11 04:24:28', 3),
(2, '2024-10-13 06:25:07', '2024-10-21 11:26:18', 4),
(11, '2024-10-02 13:00:00', '2024-11-28 11:56:02', 3),
(4, '2024-04-02 06:54:54', '2024-11-24 04:00:49', 4),
(5, '2024-03-31 04:10:29', '2024-04-01 16:21:55', 1),
(14, '2024-09-26 01:32:22', '2024-10-14 12:04:13', 2),
(6, '2024-03-24 04:44:15', '2024-10-08 02:24:49', 2),
(1, '2025-03-23 23:31:16', '2025-05-05 15:16:41', 2),
(4, '2025-03-22 11:04:58', '2025-05-21 21:01:12', 2),
(2, '2025-03-24 07:04:28', '2025-04-18 04:02:41', 2),
(14, '2024-03-06 12:28:18', '2024-07-08 10:14:13', 1),
(7, '2025-04-19 11:12:59', '2025-07-28 22:59:44', 1),
(5, '2024-05-14 17:27:45', '2024-11-25 23:24:47', 4),
(6, '2025-05-05 10:03:15', '2025-05-23 01:05:55', 2),
(7, '2024-07-28 16:45:19', '2024-08-24 19:45:11', 4),
(13, '2024-07-27 07:02:26', '2024-08-03 06:11:09', 2),
(4, '2025-03-29 20:33:49', '2025-03-30 20:30:41', 1),
(14, '2024-07-05 19:15:10', '2024-12-16 04:51:33', 2),
(6, '2024-07-07 20:08:36', '2024-12-30 09:34:04', 3),
(1, '2024-03-29 15:31:34', '2024-05-14 07:11:59', 2),
(3, '2025-01-13 11:05:51', '2025-10-08 10:59:41', 4),
(10, '2024-09-26 08:39:03', '2024-10-12 17:25:04', 2),
(5, '2025-04-07 17:45:08', '2025-04-07 17:48:08', 3),
(4, '2024-04-18 11:45:29', '2024-12-27 14:26:00', 1),
(6, '2024-10-12 08:10:08', '2024-11-17 23:04:40', 1),
(3, '2024-11-10 06:28:18', '2024-12-15 23:52:37', 3),
(15, '2024-10-26 11:22:44', '2024-10-31 14:02:30', 4),
(4, '2024-12-24 23:46:43', '2025-02-14 00:38:48', 4),
(3, '2024-05-26 21:35:11', '2024-05-26 21:38:11', 4),
(16, '2025-05-25 16:40:09', '2025-05-26 16:40:08', 4),
(16, '2025-05-19 14:09:07', '2025-05-25 14:09:07', 3);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Velez', 'Jade', '08 08 36 47 07', 'velez_jade747@yahoo.com', 2),
(2, 'Mcbride', 'Maxime', '03 79 04 97 84', 'maxime-mcbride9293@hotmail.fr', 2),
(4, 'Matthews', 'Aurélie', '09 33 38 71 70', 'm_aurlie@yahoo.fr', 3),
(24, 'Pierui', 'Pierre', '02 05 56 25 52', 'pieruipierre@gmail.com', 1),
(6, 'Walls', 'Valerie', '02 77 76 57 39', 'v-walls@hotmail.com', 2),
(7, 'Haynes', 'Justine', '06 08 11 58 88', 'haynes_justine2495@gmail.com', 3),
(8, 'Riddle', 'Jeanne', '04 37 24 94 89', 'jeanne-riddle9254@gmail.com', 3),
(9, 'Gilbert', 'Clara', '03 62 71 15 13', 'gilbert-clara@yahoo.com', 2),
(10, 'Wade', 'Marion', '07 12 55 20 59', 'marion_wade@yahoo.com', 2),
(11, 'Mayo', 'Camille', '03 94 72 67 18', 'm_camille@outlook.com', 2),
(12, 'Gilbert', 'Manon', '01 90 13 66 68', 'manon_gilbert989@orange.com', 3),
(13, 'Brian', 'Morgane', '03 65 14 22 11', 'morganebrian7370@outlook.com', 1),
(14, 'Madden', 'Emma', '02 12 91 36 86', 'm.emma136@yahoo.fr', 2),
(15, 'Fowler', 'Sarah', '03 97 88 46 78', 's_fowler@yahoo.com', 2),
(16, 'PAILLET', 'Dylan ', '0545522636', 'pailletdylan550@yahoo.fr', 1);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('admin', 'ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY idmotif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY idservice (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
