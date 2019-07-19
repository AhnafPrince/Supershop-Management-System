-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 12, 2018 at 03:25 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `super_shop`
--

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE `branch` (
  `Branch_ID` int(11) NOT NULL,
  `Location` varchar(50) NOT NULL,
  `Phone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`Branch_ID`, `Location`, `Phone`) VALUES
(1, 'Dhanmondi', 168552341),
(2, 'Mohammadpur', 169456783),
(3, 'Kochukhet', 1734521376);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `C_ID` int(11) NOT NULL,
  `C_Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `M_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`C_ID`, `C_Name`, `Email`, `M_ID`) VALUES
(1001, 'Arefeen Sultan', 'arsultan@gmail.com', 4),
(1002, 'Fahim Ahsan Khan', 'fahim@gmail.com', 3),
(1003, 'Ahnaf Tahseen Prince', 'gamer@gmail.com', 3),
(1004, 'Sayed Hossain Khan', 'dark@gmail.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `membership`
--

CREATE TABLE `membership` (
  `M_ID` int(11) NOT NULL,
  `P_Range_From` double NOT NULL,
  `P_Range_To` double NOT NULL,
  `Discount_Rate` double NOT NULL,
  `Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `membership`
--

INSERT INTO `membership` (`M_ID`, `P_Range_From`, `P_Range_To`, `Discount_Rate`, `Type`) VALUES
(1, 2000, 10000, 5, 'Bronze'),
(2, 10000, 20000, 10, 'Silver'),
(3, 20000, 40000, 20, 'Gold'),
(4, 40000, 100000, 25, 'Platinum');

-- --------------------------------------------------------

--
-- Table structure for table `occurs_in`
--

CREATE TABLE `occurs_in` (
  `Branch_ID` int(11) NOT NULL,
  `T_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `occurs_in`
--

INSERT INTO `occurs_in` (`Branch_ID`, `T_ID`) VALUES
(1, 1),
(2, 3),
(3, 2);

-- --------------------------------------------------------

--
-- Table structure for table `proceed`
--

CREATE TABLE `proceed` (
  `T_ID` int(11) NOT NULL,
  `C_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `proceed`
--

INSERT INTO `proceed` (`T_ID`, `C_ID`) VALUES
(1, 1003),
(2, 1004),
(3, 1001);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `P_ID` int(11) NOT NULL,
  `Selling_Price` double NOT NULL,
  `P_Name` varchar(50) NOT NULL,
  `Category` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`P_ID`, `Selling_Price`, `P_Name`, `Category`) VALUES
(10001, 500, 'Sunsilk Shampoo 500ml', 'Cosmetics'),
(10002, 18000, 'Samsung J Prime', 'Cellphone'),
(10003, 28500, 'Samsung 32 inch TV', 'Electronics'),
(10004, 36000, 'Conion 50-50 Refrigerator BG 21FDCG', 'Electronics');

-- --------------------------------------------------------

--
-- Table structure for table `stores_in`
--

CREATE TABLE `stores_in` (
  `P_ID` int(11) NOT NULL,
  `P_Quantity` int(11) NOT NULL,
  `Branch_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stores_in`
--

INSERT INTO `stores_in` (`P_ID`, `P_Quantity`, `Branch_ID`) VALUES
(10001, 3, 1),
(10002, 1, 2),
(10003, 2, 2),
(10004, 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `T_ID` int(11) NOT NULL,
  `P_ID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Total_Price` double NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`T_ID`, `P_ID`, `Quantity`, `Total_Price`, `Date`) VALUES
(1, 10001, 1, 500, '2018-01-09'),
(2, 10002, 2, 36000, '2018-01-02'),
(3, 10003, 1, 28500, '2018-01-03'),
(4, 10004, 2, 72000, '2018-01-06');

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE `warehouse` (
  `S_ID` int(11) NOT NULL,
  `S_Date` date NOT NULL,
  `P_ID` int(11) NOT NULL,
  `P_Quantity` int(11) NOT NULL,
  `Price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`S_ID`, `S_Date`, `P_ID`, `P_Quantity`, `Price`) VALUES
(1, '2018-01-02', 10001, 20, 9000),
(2, '2018-01-03', 10002, 10, 170000),
(3, '2018-01-06', 10003, 12, 336000),
(4, '2018-01-03', 10004, 8, 280000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`Branch_ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`C_ID`,`M_ID`),
  ADD KEY `M_ID` (`M_ID`);

--
-- Indexes for table `membership`
--
ALTER TABLE `membership`
  ADD PRIMARY KEY (`M_ID`);

--
-- Indexes for table `occurs_in`
--
ALTER TABLE `occurs_in`
  ADD PRIMARY KEY (`Branch_ID`,`T_ID`),
  ADD KEY `T_ID` (`T_ID`);

--
-- Indexes for table `proceed`
--
ALTER TABLE `proceed`
  ADD PRIMARY KEY (`T_ID`,`C_ID`),
  ADD KEY `C_ID` (`C_ID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`P_ID`);

--
-- Indexes for table `stores_in`
--
ALTER TABLE `stores_in`
  ADD PRIMARY KEY (`P_ID`,`Branch_ID`),
  ADD KEY `fk_bid` (`Branch_ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`T_ID`,`P_ID`),
  ADD KEY `P_ID` (`P_ID`);

--
-- Indexes for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`S_ID`,`P_ID`),
  ADD KEY `P_ID` (`P_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `C_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1005;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `fk_mid` FOREIGN KEY (`M_ID`) REFERENCES `membership` (`M_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `occurs_in`
--
ALTER TABLE `occurs_in`
  ADD CONSTRAINT `occurs_in_ibfk_1` FOREIGN KEY (`Branch_ID`) REFERENCES `branch` (`Branch_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `occurs_in_ibfk_2` FOREIGN KEY (`T_ID`) REFERENCES `transaction` (`T_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `proceed`
--
ALTER TABLE `proceed`
  ADD CONSTRAINT `proceed_ibfk_1` FOREIGN KEY (`C_ID`) REFERENCES `customer` (`C_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `proceed_ibfk_2` FOREIGN KEY (`T_ID`) REFERENCES `transaction` (`T_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `stores_in`
--
ALTER TABLE `stores_in`
  ADD CONSTRAINT `fk_bid` FOREIGN KEY (`Branch_ID`) REFERENCES `branch` (`Branch_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_pid` FOREIGN KEY (`P_ID`) REFERENCES `product` (`P_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`P_ID`) REFERENCES `product` (`P_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD CONSTRAINT `warehouse_ibfk_1` FOREIGN KEY (`P_ID`) REFERENCES `product` (`P_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
