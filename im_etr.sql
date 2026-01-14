-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2026 at 02:41 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `im_etr`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `booking_id` int(11) NOT NULL,
  `tenant_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `check_in_date` date NOT NULL,
  `check_out_date` date NOT NULL,
  `status` enum('Pending','Approved','Rejected','Completed') NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`booking_id`, `tenant_id`, `room_id`, `check_in_date`, `check_out_date`, `status`) VALUES
(8, 1, 13, '2025-12-30', '2025-12-30', 'Completed'),
(9, 1, 13, '2025-12-30', '2025-12-30', 'Completed'),
(10, 1, 7, '2025-12-30', '2025-12-30', 'Completed'),
(11, 1, 1, '2025-12-30', '2026-01-06', 'Completed'),
(12, 2, 2, '2025-12-30', '2026-01-06', 'Completed'),
(13, 3, 6, '2025-12-30', '2025-12-30', 'Completed'),
(14, 4, 3, '2025-12-30', '2025-12-30', 'Completed'),
(15, 4, 9, '2025-12-30', '2026-01-06', 'Completed'),
(16, 1, 13, '2025-12-30', '2025-12-31', 'Pending'),
(17, 1, 7, '2026-01-06', '2026-01-06', 'Completed'),
(18, 1, 10, '2026-01-06', '2026-01-06', 'Completed'),
(19, 1, 11, '2026-01-06', '2026-01-06', 'Completed'),
(20, 1, 7, '2026-01-06', '2026-01-06', 'Completed'),
(21, 1, 2, '2026-01-06', '2026-01-06', 'Completed'),
(22, 1, 1, '2026-01-06', '2026-01-07', 'Approved'),
(23, 1, 12, '2026-01-06', '2026-01-06', 'Completed'),
(24, 1, 1, '2026-01-06', '2026-01-07', 'Pending'),
(25, 1, 1, '2026-01-06', '2026-01-07', 'Pending'),
(26, 1, 1, '2026-01-06', '2026-01-07', 'Pending'),
(27, 5, 1, '2026-01-06', '2026-01-07', 'Pending'),
(28, 5, 3, '2026-01-06', '2026-01-06', 'Completed'),
(29, 5, 5, '2026-01-06', '2026-01-06', 'Completed');

-- --------------------------------------------------------

--
-- Table structure for table `housekeeping`
--

CREATE TABLE `housekeeping` (
  `task_id` int(11) NOT NULL,
  `room_id` int(11) DEFAULT NULL,
  `staff_name` varchar(100) DEFAULT NULL,
  `cleaning_status` enum('Pending','In Progress','Cleaned') DEFAULT 'Pending',
  `scheduled_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `housekeeping`
--

INSERT INTO `housekeeping` (`task_id`, `room_id`, `staff_name`, `cleaning_status`, `scheduled_date`) VALUES
(1, 2, 'Marc Lebanon', 'Cleaned', '2026-01-06 02:50:25'),
(2, 7, 'Joshua Garcia', 'Cleaned', '2026-01-06 02:51:11'),
(3, 1, 'Jutay', 'Cleaned', '2026-01-06 02:59:49'),
(4, 7, 'Eljohn Molina', 'Cleaned', '2026-01-06 05:20:54'),
(5, 2, 'Eljohn Molina', 'Cleaned', '2026-01-06 18:55:44'),
(6, 12, 'Ej', 'Cleaned', '2026-01-06 19:04:27'),
(7, 9, 'elel', 'Cleaned', '2026-01-06 19:07:11'),
(8, 3, 'tagalinis`', 'Cleaned', '2026-01-06 19:11:55');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `room_id` int(11) NOT NULL,
  `room_number` varchar(20) NOT NULL,
  `capacity` int(11) NOT NULL,
  `rate` decimal(10,2) NOT NULL,
  `status` enum('Available','Occupied','Maintenance','Dirty') NOT NULL DEFAULT 'Available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`room_id`, `room_number`, `capacity`, `rate`, `status`) VALUES
(1, 'S-101', 2, 500.00, 'Occupied'),
(2, 'S-102', 2, 500.00, 'Maintenance'),
(3, 'S-103', 2, 500.00, 'Available'),
(4, 'S-104', 2, 500.00, 'Maintenance'),
(5, 'S-105', 2, 500.00, 'Dirty'),
(6, 'S-106', 2, 500.00, 'Available'),
(7, 'M-101', 4, 800.00, 'Available'),
(8, 'M-102', 4, 800.00, 'Maintenance'),
(9, 'M-103', 4, 800.00, 'Available'),
(10, 'M-104', 4, 800.00, 'Dirty'),
(11, 'M-105', 4, 800.00, 'Dirty'),
(12, 'M-106', 4, 800.00, 'Available'),
(13, 'L-101', 6, 1200.00, 'Available'),
(14, 'L-102', 6, 1200.00, 'Available'),
(15, 'L-103', 6, 1200.00, 'Available'),
(16, 'L-104', 6, 1200.00, 'Available'),
(17, 'L-105', 6, 1200.00, 'Available'),
(18, 'L-106', 6, 1200.00, 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `room_reviews`
--

CREATE TABLE `room_reviews` (
  `review_id` int(11) NOT NULL,
  `room_id` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `rating` int(11) DEFAULT NULL CHECK (`rating` >= 1 and `rating` <= 5),
  `comment` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room_reviews`
--

INSERT INTO `room_reviews` (`review_id`, `room_id`, `user_id`, `rating`, `comment`, `created_at`) VALUES
(1, 12, 13, 4, 'So Cozy', '2026-01-05 20:33:39'),
(7, 2, 13, 5, 'Maganda', '2026-01-06 10:45:29'),
(8, 3, 17, 3, 'ayos lang geng geng', '2026-01-06 11:11:11');

-- --------------------------------------------------------

--
-- Table structure for table `tenants`
--

CREATE TABLE `tenants` (
  `tenant_id` int(11) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `contact_number` varchar(20) NOT NULL,
  `emergency_contact` varchar(20) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tenants`
--

INSERT INTO `tenants` (`tenant_id`, `full_name`, `contact_number`, `emergency_contact`, `user_id`) VALUES
(1, 'Eljohn Molina', '0991111', '0998', 13),
(2, 'jibay bautista', '09998', '8989', 14),
(3, 'new', '1234', '123', 15),
(4, 'Jayby Bautista', '09989', '099112', 16),
(5, 'Jimar Bautista', '0999', '09122', 17);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('Admin','Tenant') NOT NULL DEFAULT 'Tenant'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `role`) VALUES
(9, 'admin1', '123', 'Admin'),
(13, 'test', '123', 'Tenant'),
(14, 'jibay', '123', 'Tenant'),
(15, 'new', '123', 'Tenant'),
(16, 'bagongCreate', '123', 'Tenant'),
(17, 'jimarbago', '123', 'Tenant');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`booking_id`),
  ADD KEY `fk_booking_tenant` (`tenant_id`),
  ADD KEY `fk_booking_room` (`room_id`);

--
-- Indexes for table `housekeeping`
--
ALTER TABLE `housekeeping`
  ADD PRIMARY KEY (`task_id`),
  ADD KEY `room_id` (`room_id`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`room_id`),
  ADD UNIQUE KEY `room_number` (`room_number`);

--
-- Indexes for table `room_reviews`
--
ALTER TABLE `room_reviews`
  ADD PRIMARY KEY (`review_id`),
  ADD KEY `room_id` (`room_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tenants`
--
ALTER TABLE `tenants`
  ADD PRIMARY KEY (`tenant_id`),
  ADD UNIQUE KEY `uq_tenant_user` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `housekeeping`
--
ALTER TABLE `housekeeping`
  MODIFY `task_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `rooms`
--
ALTER TABLE `rooms`
  MODIFY `room_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `room_reviews`
--
ALTER TABLE `room_reviews`
  MODIFY `review_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tenants`
--
ALTER TABLE `tenants`
  MODIFY `tenant_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `fk_booking_room` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`),
  ADD CONSTRAINT `fk_booking_tenant` FOREIGN KEY (`tenant_id`) REFERENCES `tenants` (`tenant_id`);

--
-- Constraints for table `housekeeping`
--
ALTER TABLE `housekeeping`
  ADD CONSTRAINT `housekeeping_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`);

--
-- Constraints for table `room_reviews`
--
ALTER TABLE `room_reviews`
  ADD CONSTRAINT `room_reviews_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`),
  ADD CONSTRAINT `room_reviews_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);

--
-- Constraints for table `tenants`
--
ALTER TABLE `tenants`
  ADD CONSTRAINT `fk_tenant_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
