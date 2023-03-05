-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 17, 2020 at 04:24 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employeeloginsys`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_list`
--

CREATE TABLE `admin_list` (
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin_list`
--

INSERT INTO `admin_list` (`username`, `password`, `fname`, `lname`) VALUES
('admin', 'PbQIP26UN6c=', 'Master', 'Admin'),
('jdelacruz', 'PbQIP26UN6c=', 'Juan', 'Dela Cruz');

-- --------------------------------------------------------

--
-- Table structure for table `attendance_record`
--

CREATE TABLE `attendance_record` (
  `no` int(11) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mi` varchar(20) NOT NULL,
  `date` varchar(20) NOT NULL,
  `time_in` varchar(20) NOT NULL,
  `time_out` varchar(20) NOT NULL,
  `rfid` varchar(20) NOT NULL,
  `salary_earned` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `attendance_record`
--

INSERT INTO `attendance_record` (`no`, `lname`, `fname`, `mi`, `date`, `time_in`, `time_out`, `rfid`, `salary_earned`) VALUES
(57, 'Andrade', 'Leonardo', 'A', 'February 01, 2020', '07:35', '17:04', '9105655', '683'),
(58, 'Luchavez', 'Charles Vincent', 'P', 'February 01, 2020', '07:37', '17:24', '9105656', '604'),
(59, 'Collado', 'Joan', 'C', 'February 01, 2020', '07:48', '17:29', '6870301', '608'),
(60, 'Mistula', 'Arid', 'M', 'February 01, 2020', '08:01', '19:30', '6883843', '621'),
(61, 'Zabala', 'Victor', 'M', 'February 01, 2020', '08:07', '17:00', '9091986', '526'),
(62, 'Andrade', 'Leonardo', 'A', 'February 02, 2020', '8:00', '17:26', '9105655', '607'),
(63, 'Luchavez', 'Charles Vincent', 'P', 'February 02, 2020', '08:05', '16:32', '9105656', '470'),
(64, 'Collado', 'Joan', 'C', 'February 02, 2020', '08:08', '19:07', '6870301', '624'),
(65, 'Mistula', 'Arid', 'M', 'February 02, 2020', '08:12', '18:00', '6883843', '537'),
(66, 'Zabala', 'Victor', 'M', 'February 02, 2020', '08:32', '17:31', '9091986', '526'),
(67, 'Andrade', 'Leonardo', 'A', 'February 03, 2020', '08:13', '17:05', '9105655', '607'),
(68, 'Luchavez', 'Charles Vincent', 'P', 'February 03, 2020', '08:22', '17:42', '9105656', '537'),
(69, 'Collado', 'Joan', 'C', 'February 03, 2020', '08:40', '17:55', '6870301', '540'),
(70, 'Mistula', 'Arid', 'M', 'February 03, 2020', '09:02', '19:04', '6883843', '554'),
(71, 'Zabala', 'Victor', 'M', 'February 03, 2020', '09:30', '19:15', '9091986', '542'),
(72, 'Andrade', 'Leonardo', 'A', 'February 04, 2020', '08:05', '15:33', '9105655', '455'),
(73, 'Luchavez', 'Charles Vincent', 'P', 'February 04, 2020', '08:11', '17:02', '9105656', '537'),
(75, 'Collado', 'Joan', 'C', 'February 04, 2020', '08:21', '16:30', '6870301', '473'),
(76, 'Mistula', 'Arid', 'M', 'February 04, 2020', '08:23', '17:22', '6883843', '537'),
(77, 'Zabala', 'Victor', 'M', 'February 04, 2020', '09:01', '20:02', '9091986', '625'),
(78, 'Andrade', 'Leonardo', 'A', 'February 05, 2020', '08:01', '17:55', '9105655', '607'),
(79, 'Luchavez', 'Charles Vincent', 'P', 'February 05, 2020', '08:21', '20:21', '9105656', '705'),
(80, 'Collado', 'Joan', 'C', 'February 05, 2020', '08:45', '17:15', '6870301', '540'),
(81, 'Andrade', 'Leonardo', 'A', 'February 06, 2020', '07:10', '15:41', '9105655', '531'),
(82, 'Luchavez', 'Charles Vincent', 'P', 'February 06, 2020', '07:14', '16:05', '9105656', '537'),
(83, 'Collado', 'Joan', 'C', 'February 06, 2020', '08:04', '17:35', '6870301', '540'),
(84, 'Mistula', 'Arid', 'M', 'February 06, 2020', '08:15', '17:26', '6883843', '537'),
(85, 'Zabala', 'Victor', 'M', 'February 06, 2020', '08:30', '17:48', '9091986', '526'),
(86, 'Andrade', 'Leonardo', 'A', 'February 07, 2020', '07:48', '20:14', '9105655', '873'),
(87, 'Luchavez', 'Charles Vincent', 'P', 'February 07, 2020', '08:07', '17:19', '9105656', '537'),
(88, 'Collado', 'Joan', 'C', 'February 07, 2020', '08:14', '17:20', '6870301', '540'),
(89, 'Mistula', 'Arid', 'M', 'February 07, 2020', '08:20', '15:08', '6883843', '403'),
(90, 'Zabala', 'Victor', 'M', 'February 07, 2020', '08:21', '19:344', '9091986', '608'),
(91, 'Andrade', 'Leonardo', 'A', 'February 08, 2020', '08:34', '17:12', '9105655', '607'),
(92, 'Luchavez', 'Charles Vincent', 'P', 'February 08, 2020', '08:03', '17:33', '9105656', '537'),
(93, 'Collado', 'Joan', 'C', 'February 08, 2020', '08:12', '18:44', '6870301', '540'),
(94, 'Mistula', 'Arid', 'M', 'February 08, 2020', '07:12', '18:45', '6883843', '604'),
(95, 'Zabala', 'Victor', 'M', 'February 08, 2020', '08:00', '20:00', '9091986', '690'),
(96, 'Andrade', 'Leonardo', 'A', 'February 09, 2020', '07:44', '17:52', '9105655', '683'),
(97, 'Luchavez', 'Charles Vincent', 'P', 'February 09, 2020', '08:06', '17:05', '9105656', '537'),
(98, 'Collado', 'Joan', 'C', 'February 09, 2020', '08:12', '17:21', '6870301', '540'),
(99, 'Mistula', 'Arid', 'M', 'February 09, 2020', '08:15', '19:05', '6883843', '621'),
(100, 'Zabala', 'Victor', 'M', 'February 09, 2020', '08:20', '19:06', '9091986', '608'),
(101, 'Andrade', 'Leonardo', 'A', 'February 10, 2020', '08:06', '19:42', '9105655', '702'),
(102, 'Luchavez', 'Charles Vincent', 'P', 'February 10, 2020', '08:07', '17:18', '9105656', '537'),
(103, 'Collado', 'Joan', 'C', 'February 10, 2020', '08:07', '17:36', '6870301', '540'),
(104, 'Mistula', 'Arid', 'M', 'February 10, 2020', '08:22', '20:47', '6883843', '705'),
(105, 'Zabala', 'Victor', 'M', 'February 10, 2020', '09:12', '20:48', '9091986', '625'),
(106, 'Mistula', 'Arid', 'M', 'February 05, 2020', '07:48', '18:21', '6883843', '604'),
(107, 'Zabala', 'Victor', 'M', 'February 05, 2020', '08:48', '18:55', '9091986', '526'),
(108, 'Andrade', 'Leonardo', 'A', 'February 11, 2020', '08:55', '17:47', '9105655', '607'),
(109, 'Luchavez', 'Charles Vincent', 'P', 'February 11, 2020', '08:15', '17:01', '9105656', '537'),
(110, 'Collado', 'Joan', 'C', 'February 11, 2020', '08:02', '17:08', '6870301', '540'),
(111, 'Mistula', 'Arid', 'M', 'February 11, 2020', '08:14', '20:21', '6883843', '705'),
(112, 'Zabala', 'Victor', 'M', 'February 11, 2020', '07:44', '20:22', '9091986', '756'),
(113, 'Andrade', 'Leonardo', 'A', 'February 12, 2020', '07:22', '15:17', '9105655', '531'),
(114, 'Luchavez', 'Charles Vincent', 'P', 'February 12, 2020', '07:30', '16:30', '9105656', '537'),
(115, 'Collado', 'Joan', 'C', 'February 12, 2020', '08:32', '19:00', '6870301', '624'),
(116, 'Mistula', 'Arid', 'M', 'February 12, 2020', '08:05', '18:24', '6883843', '537'),
(117, 'Zabala', 'Victor', 'M', 'February 12, 2020', '08:06', '17:00', '9091986', '526'),
(118, 'Andrade', 'Leonardo', 'A', 'February 13, 2020', '10:03', '22:04', '9105655', '835'),
(119, 'Luchavez', 'Charles Vincent', 'P', 'February 13, 2020', '08:04', '17:09', '9105656', '537'),
(120, 'Collado', 'Joan', 'C', 'February 13, 2020', '08:17', '17:32', '6870301', '540'),
(121, 'Mistula', 'Arid', 'M', 'February 13, 2020', '07:12', '16:45', '6883843', '537'),
(122, 'Zabala', 'Victor', 'M', 'February 13, 2020', '07:44', '16:44', '9091986', '526'),
(123, 'Andrade', 'Leonardo', 'A', 'February 14, 2020', '08:01', '17:06', '9105655', '1214'),
(124, 'Luchavez', 'Charles Vincent', 'P', 'February 14, 2020', '08:01', '17:24', '9105656', '1074'),
(125, 'Collado', 'Joan', 'C', 'February 14, 2020', '08:02', '14:50', '6870301', '675'),
(126, 'Mistula', 'Arid', 'M', 'February 14, 2020', '08:02', '15:05', '6883843', '806'),
(127, 'Zabala', 'Victor', 'M', 'February 14, 2020', '08:03', '20:05', '9091986', '1394'),
(128, 'Andrade', 'Leonardo', 'A', 'February 15, 2020', '07:30', '20:30', '9105655', '873'),
(129, 'Luchavez', 'Charles Vincent', 'P', 'February 15, 2020', '07:45', '17:12', '9105656', '604'),
(130, 'Collado', 'Joan', 'C', 'February 15, 2020', '07:52', '21:00', '6870301', '861'),
(131, 'Mistula', 'Arid', 'M', 'February 15, 2020', '08:44', '17:55', '6883843', '537'),
(132, 'Zabala', 'Victor', 'M', 'February 15, 2020', '08:15', '17:30', '9091986', '526'),
(133, 'Mistula', 'Arid', 'M', 'July 17, 2020', '07:55', '17:03', '6883843', '1200'),
(134, 'Luchavez', 'Charles Vincent', 'P', 'July 17, 2020', '21:15', '06:20', '9105656', '682'),
(135, 'Collado', 'Joan', 'C', 'July 17, 2020', '08:20', '20:13', '6870301', '1142.19'),
(136, 'Andrade', 'Leonardo', 'A', 'July 17, 2020', '07:43', '19:21', '9105655', '924.98'),
(137, 'Zabala', 'Victor', 'M', 'July 17, 2020', '08:01', '17:33', '9091985', '2500'),
(138, 'Mistula', 'Arid', 'M', 'July 18, 2020', '07:45', '17:14', '6883843', '1200'),
(139, 'Luchavez', 'Charles Vincent', 'P', 'July 18, 2020', '22:00', '06:30', '9105656', '682'),
(140, 'Collado', 'Joan', 'C', 'July 18, 2020', '08:01', '18:44', '6870301', '876.56'),
(141, 'Andrade', 'Leonardo', 'A', 'July 18, 2020', '07:44', '15:44', '9105655', '469.88'),
(142, 'Zabala', 'Victor', 'M', 'July 18, 2020', '07:55', '17:05', '9091985', '2500'),
(143, 'Mistula', 'Arid', 'M', 'July 19, 2020', '08:57', '20:13', '6883843', '1612.5'),
(144, 'Luchavez', 'Charles Vincent', 'P', 'July 19, 2020', '22:04', '07:09', '9105656', '759.5'),
(145, 'Collado', 'Joan', 'C', 'July 19, 2020', '08:09', '18:09', '6870301', '876.56'),
(146, 'Andrade', 'Leonardo', 'A', 'July 19, 2020', '08:29', '17:44', '9105655', '537'),
(147, 'Zabala', 'Victor', 'M', 'July 19, 2020', '07:32', '15:00', '9091985', '1875'),
(148, 'Mistula', 'Arid', 'M', 'July 20, 2020', '08:00', '18:00', '6883843', '1387.5'),
(149, 'Luchavez', 'Charles Vincent', 'P', 'July 20, 2020', '22:00', '06:00', '9105656', '682'),
(150, 'Collado', 'Joan', 'C', 'July 20, 2020', '07:55', '18:00', '6870301', '982.81'),
(151, 'Andrade', 'Leonardo', 'A', 'July 20, 2020', '08:03', '18:02', '9105655', '553.78'),
(152, 'Zabala', 'Victor', 'M', 'July 20, 2020', '08:07', '17:44', '9091985', '2500'),
(153, 'Mistula', 'Arid', 'M', 'July 21, 2020', '07:44', '17:00', '6883843', '1200'),
(154, 'Luchavez', 'Charles Vincent', 'P', 'July 21, 2020', '21:50', '05:40', '9105656', '596.75'),
(155, 'Collado', 'Joan', 'C', 'July 21, 2020', '07:40', '17:02', '6870301', '850'),
(156, 'Andrade', 'Leonardo', 'A', 'July 21, 2020', '08:02', '20:44', '9105655', '721.59'),
(157, 'Zabala', 'Victor', 'M', 'July 21, 2020', '07:15', '17:30', '9091985', '3656.25'),
(158, 'Mistula', 'Arid', 'M', 'July 22, 2020', '08:17', '17:00', '6883843', '1365'),
(159, 'Luchavez', 'Charles Vincent', 'P', 'July 22, 2020', '22:00', '06:05', '9105656', '886.6'),
(160, 'Collado', 'Joan', 'C', 'July 22, 2020', '07:30', '21:03', '6870301', '2103.75'),
(161, 'Andrade', 'Leonardo', 'A', 'July 22, 2020', '08:03', '17:02', '9105655', '610.84'),
(162, 'Zabala', 'Victor', 'M', 'July 22, 2020', '07:54', '17:03', '9091985', '3250'),
(163, 'Mistula', 'Arid', 'M', 'July 23, 2020', '07:55', '17:00', '6883843', '1560'),
(164, 'Luchavez', 'Charles Vincent', 'P', 'July 23, 2020', '21:05', '05:12', '9105656', '682'),
(165, 'Collado', 'Joan', 'C', 'July 23, 2020', '08:12', '20:40', '6870301', '1142.19'),
(166, 'Andrade', 'Leonardo', 'A', 'July 23, 2020', '09:33', '17:50', '9105655', '469.88'),
(167, 'Zabala', 'Victor', 'M', 'July 23, 2020', '07:50', '17:23', '9091985', '2500'),
(168, 'Mistula', 'Arid', 'M', 'July 24, 2020', '07:32', '17:11', '6883843', '1200'),
(169, 'Luchavez', 'Charles Vincent', 'P', 'July 24, 2020', '22:15', '05:45', '9105656', '596.75'),
(170, 'Collado', 'Joan', 'C', 'July 24, 2020', '08:12', '18:04', '6870301', '876.56'),
(171, 'Andrade', 'Leonardo', 'A', 'July 24, 2020', '07:52', '17:45', '9105655', '698.1'),
(172, 'Zabala', 'Victor', 'M', 'July 24, 2020', '07:44', '20:22', '9091985', '3671.88'),
(173, 'Mistula', 'Arid', 'M', 'July 25, 2020', '07:22', '17:22', '6883843', '1350'),
(174, 'Luchavez', 'Charles Vincent', 'P', 'July 25, 2020', '22:17', '05:09', '9105656', '664.95'),
(175, 'Collado', 'Joan', 'C', 'July 25, 2020', '08:09', '17:23', '6870301', '850'),
(176, 'Andrade', 'Leonardo', 'A', 'July 25, 2020', '08:23', '18:05', '9105655', '553.78'),
(177, 'Zabala', 'Victor', 'M', 'July 25, 2020', '08:05', '17:05', '9091985', '2500'),
(178, 'Mistula', 'Arid', 'M', 'July 26, 2020', '07:55', '17:30', '6883843', '3600'),
(179, 'Luchavez', 'Charles Vincent', 'P', 'July 26, 2020', '22:00', '05:14', '9105656', '1806.52'),
(180, 'Collado', 'Joan', 'C', 'July 26, 2020', '07:55', '17:22', '6870301', '2550'),
(181, 'Andrade', 'Leonardo', 'A', 'July 26, 2020', '08:00', '21:00', '9105655', '2658.35'),
(182, 'Zabala', 'Victor', 'M', 'July 26, 2020', '07:57', '17:41', '9091985', '7500'),
(184, 'Mistula', 'Arid', 'M', 'July 27, 2020', '07:59', '17:04', '6883843', '1200'),
(185, 'Luchavez', 'Charles Vincent', 'P', 'July 27, 2020', '21:56', '06:15', '9105656', '682'),
(186, 'Collado', 'Joan', 'C', 'July 27, 2020', '08:10', '19:12', '6870301', '1009.38'),
(187, 'Andrade', 'Leonardo', 'A', 'July 27, 2020', '08:55', '17:00', '9105655', '469.88'),
(188, 'Zabala', 'Victor', 'M', 'July 27, 2020', '08:00', '17:05', '9091985', '2500'),
(189, 'Mistula', 'Arid', 'M', 'July 28, 2020', '07:55', '17:01', '6883843', '1200'),
(190, 'Luchavez', 'Charles Vincent', 'P', 'July 28, 2020', '22:03', '06:01', '9105656', '596.75'),
(191, 'Andrade', 'Leonardo', 'A', 'July 28, 2020', '07:56', '17:12', '9105655', '537'),
(193, 'Collado', 'Joan', 'C', 'July 28, 2020', '07:52', '17:44', '6870301', '850'),
(194, 'Zabala', 'Victor', 'M', 'July 28, 2020', '07:58', '17:20', '9091985', '3250'),
(195, 'Mistula', 'Arid', 'M', 'July 29, 2020', '08:00', '17:23', '6883843', '1200'),
(196, 'Luchavez', 'Charles Vincent', 'P', 'July 29, 2020', '22:04', '06:04', '9105656', '682'),
(197, 'Collado', 'Joan', 'C', 'July 29, 2020', '08:04', '17:04', '6870301', '1105'),
(198, 'Andrade', 'Leonardo', 'A', 'July 29, 2020', '08:52', '21:00', '9105655', '805.5'),
(199, 'Zabala', 'Victor', 'M', 'July 29, 2020', '08:12', '18:45', '9091985', '2578.12'),
(200, 'Mistula', 'Arid', 'M', 'July 30, 2020', '07:45', '17:07', '6883843', '1560'),
(201, 'Luchavez', 'Charles Vincent', 'P', 'July 30, 2020', '21:51', '06:31', '9105656', '682'),
(202, 'Collado', 'Joan', 'C', 'July 30, 2020', '08:00', '17:05', '6870301', '850'),
(203, 'Andrade', 'Leonardo', 'A', 'July 30, 2020', '08:01', '17:06', '9105655', '537'),
(204, 'Zabala', 'Victor', 'M', 'July 30, 2020', '07:56', '17:32', '9091985', '2500'),
(205, 'Mistula', 'Arid', 'M', 'July 31, 2020', '08:00', '18:00', '6883843', '2790'),
(206, 'Luchavez', 'Charles Vincent', 'P', 'July 31, 2020', '22:00', '06:00', '9105656', '1364'),
(207, 'Collado', 'Joan', 'C', 'July 31, 2020', '07:51', '17:03', '6870301', '1700'),
(208, 'Andrade', 'Leonardo', 'A', 'July 31, 2020', '08:25', '21:04', '9105655', '2129.2'),
(209, 'Zabala', 'Victor', 'M', 'July 31, 2020', '07:44', '19:21', '9091985', '6625'),
(210, 'Andrade', 'Leonardo', 'A', 'August 01, 2020', 'VL', 'VL', '9105655', '537'),
(211, 'Collado', 'Joan', 'C', 'August 01, 2020', 'VL', 'VL', '6870301', '850'),
(212, 'Collado', 'Joan', 'C', 'August 02, 2020', 'VL', 'VL', '6870301', '850'),
(213, 'Collado', 'Joan', 'C', 'August 03, 2020', 'VL', 'VL', '6870301', '850'),
(214, 'Collado', 'Joan', 'C', 'August 04, 2020', 'VL', 'VL', '6870301', '850'),
(215, 'Collado', 'Joan', 'C', 'August 05, 2020', 'VL', 'VL', '6870301', '850');

-- --------------------------------------------------------

--
-- Table structure for table `employee_list`
--

CREATE TABLE `employee_list` (
  `lname` varchar(20) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mi` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `contactno` varchar(20) NOT NULL,
  `birthday` varchar(20) NOT NULL,
  `rfid` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `salary` varchar(20) DEFAULT NULL,
  `refdate` varchar(20) NOT NULL,
  `pagibig` varchar(20) NOT NULL DEFAULT 'no',
  `philhealth` varchar(20) NOT NULL DEFAULT 'no',
  `sss` varchar(20) NOT NULL DEFAULT 'no',
  `loan` varchar(20) NOT NULL DEFAULT 'no',
  `base_pay` varchar(20) NOT NULL,
  `cash_adv` varchar(20) NOT NULL DEFAULT 'no',
  `rest_day` varchar(20) NOT NULL DEFAULT 'Sunday'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_list`
--

INSERT INTO `employee_list` (`lname`, `fname`, `mi`, `address`, `contactno`, `birthday`, `rfid`, `username`, `password`, `salary`, `refdate`, `pagibig`, `philhealth`, `sss`, `loan`, `base_pay`, `cash_adv`, `rest_day`) VALUES
('Mistula', 'Arid', 'M', 'Sample123', '123456789', 'January 01, 1990', '6883843', 'ammistula', 'PbQIP26UN6c=', '23625', 'February 15, 2020', 'yes', 'yes', 'yes', 'yes', '1200', 'yes', 'Thursday'),
('Luchavez', 'Charles Vincent', 'P', 'Sample123', '123456789', 'January 01, 1990', '9105656', 'cvpluchavez', 'PbQIP26UN6c=', '12045.82', 'February 15, 2020', 'yes', 'yes', 'yes', 'yes', '620', 'yes', 'Sunday'),
('Collado', 'Joan', 'C', 'Sample123', '123456789', 'January 01, 1990', '6870301', 'jccollado', 'PbQIP26UN6c=', '22015', 'February 15, 2020', 'yes', 'yes', 'yes', 'yes', '850', 'yes', 'Wednesday'),
('Andrade', 'Leonardo', 'A', 'Sample123', '123456789', 'January 01, 1990', '9105655', 'laandrade', 'PbQIP26UN6c=', '13213.56', 'February 15, 2020', 'yes', 'yes', 'yes', 'yes', '537', 'yes', 'Friday'),
('Zabala', 'Victor', 'M', 'Sample123', '123456789', 'January 01, 1990', '9091985', 'vmzabala', 'PbQIP26UN6c=', '49906.25', 'February 15, 2020', 'yes', 'yes', 'yes', 'yes', '2500', 'yes', 'Tuesday');

-- --------------------------------------------------------

--
-- Table structure for table `holiday_list`
--

CREATE TABLE `holiday_list` (
  `no` int(11) NOT NULL,
  `date` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `holiday_list`
--

INSERT INTO `holiday_list` (`no`, `date`, `type`) VALUES
(8, 'July 22, 2020', 'Special'),
(9, 'July 26, 2020', 'Double'),
(10, 'July 31, 2020', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `payout_record`
--

CREATE TABLE `payout_record` (
  `no` int(11) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mi` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `rfid` varchar(20) NOT NULL,
  `from` varchar(20) NOT NULL,
  `to` varchar(20) NOT NULL,
  `salary_earned` varchar(20) NOT NULL,
  `deduction` varchar(20) NOT NULL,
  `payout` varchar(20) NOT NULL,
  `pagibig` varchar(20) NOT NULL,
  `philhealth` varchar(20) NOT NULL,
  `sss` varchar(20) NOT NULL,
  `pagibig_loan` varchar(20) NOT NULL,
  `sss_loan` varchar(20) NOT NULL,
  `other_loan` varchar(20) NOT NULL,
  `tax` varchar(20) NOT NULL,
  `cash_adv` varchar(20) NOT NULL,
  `incentive` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payout_record`
--

INSERT INTO `payout_record` (`no`, `lname`, `fname`, `mi`, `username`, `rfid`, `from`, `to`, `salary_earned`, `deduction`, `payout`, `pagibig`, `philhealth`, `sss`, `pagibig_loan`, `sss_loan`, `other_loan`, `tax`, `cash_adv`, `incentive`) VALUES
(6, 'Mistula', 'Arid', 'M', 'ammistula', '6883843', 'January 18, 2020', 'February 15, 2020', '8291', '324.84', '7966.16', '50', '124.36', '150.48', '0', '0', '0', '0', '0', '0'),
(7, 'Luchavez', 'Charles Vincent', 'P', 'cvpluchavez', '9105656', 'January 18, 2020', 'February 15, 2020', '8827', '342.61', '8484.39', '50', '132.4', '160.21', '0', '0', '0', '0', '0', '0'),
(8, 'Collado', 'Joan', 'C', 'jccollado', '6870301', 'January 18, 2020', 'February 15, 2020', '8185', '321.34', '7863.66', '50', '122.78', '148.56', '0', '0', '0', '0', '0', '0'),
(9, 'Andrade', 'Leonardo', 'A', 'laandrade', '9105655', 'January 18, 2020', 'February 15, 2020', '11098', '417.9', '10680.1', '50', '166.47', '201.43', '0', '0', '0', '0', '0', '0'),
(10, 'Zabala', 'Victor', 'M', 'vmzabala', '9091985', 'January 18, 2020', '', '9530', '365.92', '9164.08', '50', '142.95', '172.97', '0', '0', '0', '0', '0', '0');

-- --------------------------------------------------------

--
-- Table structure for table `variables`
--

CREATE TABLE `variables` (
  `no` int(11) NOT NULL,
  `other_loan` varchar(20) NOT NULL,
  `pagibig` varchar(20) NOT NULL,
  `philhealth` varchar(20) NOT NULL,
  `sss` varchar(20) NOT NULL,
  `t1` varchar(20) NOT NULL,
  `t2` varchar(20) NOT NULL,
  `t3` varchar(20) NOT NULL,
  `t4` varchar(20) NOT NULL,
  `t5` varchar(20) NOT NULL,
  `r1` varchar(20) NOT NULL,
  `r2` varchar(20) NOT NULL,
  `r3` varchar(20) NOT NULL,
  `r4` varchar(20) NOT NULL,
  `r5` varchar(20) NOT NULL,
  `c1` varchar(20) NOT NULL,
  `c2` varchar(20) NOT NULL,
  `c3` varchar(20) NOT NULL,
  `c4` varchar(20) NOT NULL,
  `c5` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `variables`
--

INSERT INTO `variables` (`no`, `other_loan`, `pagibig`, `philhealth`, `sss`, `t1`, `t2`, `t3`, `t4`, `t5`, `r1`, `r2`, `r3`, `r4`, `r5`, `c1`, `c2`, `c3`, `c4`, `c5`) VALUES
(1, 'Insurance', '0.02', '0.03', '0.0363', '10417', '16666', '33332', '83332', '333332', '0.2', '0.25', '0.3', '0.32', '0.35', '0', '1250', '5416.67', '20416.67', '100416.67');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_list`
--
ALTER TABLE `admin_list`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `attendance_record`
--
ALTER TABLE `attendance_record`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `employee_list`
--
ALTER TABLE `employee_list`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `holiday_list`
--
ALTER TABLE `holiday_list`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `payout_record`
--
ALTER TABLE `payout_record`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `variables`
--
ALTER TABLE `variables`
  ADD PRIMARY KEY (`no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance_record`
--
ALTER TABLE `attendance_record`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=216;

--
-- AUTO_INCREMENT for table `holiday_list`
--
ALTER TABLE `holiday_list`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `payout_record`
--
ALTER TABLE `payout_record`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `variables`
--
ALTER TABLE `variables`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
