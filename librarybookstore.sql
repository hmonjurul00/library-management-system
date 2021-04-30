-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2021 at 08:20 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarybookstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(10) NOT NULL,
  `full_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `role`, `full_name`) VALUES
('admin', '1234', 'admin', 'Monjurul Hasan'),
('faisal', '1234', 'manager', 'Faisal Ahmed'),
('kamrul', '1234', 'manager', 'Kamrul Hasan'),
('manager1', '1234', 'manager', 'Abdul Karim'),
('manager2', '1234', 'manager', 'Abdul Jabbar'),
('manager3', '1234', 'manager', 'Abdur Rahman');

-- --------------------------------------------------------

--
-- Table structure for table `manager_book_entry`
--

CREATE TABLE `manager_book_entry` (
  `book_id` int(11) NOT NULL,
  `book_name` varchar(200) NOT NULL,
  `book_publish_year` int(11) NOT NULL,
  `writer_name` varchar(100) NOT NULL,
  `quantity_of_book` int(11) NOT NULL,
  `is_available` tinyint(1) NOT NULL,
  `catagory_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manager_book_entry`
--

INSERT INTO `manager_book_entry` (`book_id`, `book_name`, `book_publish_year`, `writer_name`, `quantity_of_book`, `is_available`, `catagory_name`) VALUES
(101, 'Electrical Circuit', 1996, 'Robart Boilstate', 100, 1, 'Electrical & Electronics'),
(102, 'Computer Fundamental', 1998, 'Bala Guru Shami', 50, 1, 'Computer Science'),
(103, 'Electronic Device', 1996, 'Robert BoyelState', 70, 1, 'Electrical & Electronics'),
(104, 'Economics', 1974, 'William Hunt', 5, 1, 'Economics'),
(105, 'Discrete Mathematics', 1992, 'Kenneth H. Rosen', 120, 1, 'Mathematics'),
(106, 'Introduction to Algorithms', 1989, 'Thomas H. Cormen', 90, 1, 'Algorithm'),
(107, 'Competitive Programming 3', 2008, 'Felix Halim', 30, 1, 'Competitve Programming'),
(108, 'Art of Programming', 2010, 'Samuel Morson', 50, 1, 'Algorithm'),
(109, 'Object Oriented Programming', 2003, 'Robert Lafore', 50, 1, 'Programming'),
(110, 'Computer Programming', 2014, 'Tamim Shahriar', 105, 1, 'Programming'),
(111, 'Algorithms to Live By: The Computer Science of Human Decisions', 2016, 'Brian Christian, Griffiths', 15, 1, 'Algorithms'),
(112, 'Code: The Hidden Language of Computer Hardware and Software', 1999, 'Charles Petzold', 5, 0, 'Computer Science');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `manager_book_entry`
--
ALTER TABLE `manager_book_entry`
  ADD PRIMARY KEY (`book_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `manager_book_entry`
--
ALTER TABLE `manager_book_entry`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=113;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
