-- phpMyAdmin SQL Dump
-- version 5.2.0-rc1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost:3306
-- Thời gian đã tạo: Th3 15, 2023 lúc 11:16 PM
-- Phiên bản máy phục vụ: 5.7.33
-- Phiên bản PHP: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `ef_core_api_ktr_dinhtrung`
--
CREATE DATABASE IF NOT EXISTS `ef_core_api_ktr_dinhtrung` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `ef_core_api_ktr_dinhtrung`;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `categories`
--

CREATE TABLE `categories` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `DateCreated` datetime(6) NOT NULL,
  `DateUpdated` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `categories`
--

INSERT INTO `categories` (`Id`, `Name`, `DateCreated`, `DateUpdated`) VALUES
(1, 'SSD', '2023-03-16 04:49:53.000000', '2023-03-16 04:49:53.000000'),
(2, 'RAM', '2023-03-16 04:50:39.000000', '2023-03-16 04:50:39.000000'),
(3, 'SD', '2023-03-16 04:51:28.000000', '2023-03-16 04:51:28.000000');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `images`
--

CREATE TABLE `images` (
  `Id` int(11) NOT NULL,
  `FileName` varchar(1000) NOT NULL,
  `DateCreated` datetime(6) NOT NULL,
  `DateUpdated` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `products`
--

CREATE TABLE `products` (
  `Id` int(11) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `Code` varchar(150) NOT NULL,
  `Price` double NOT NULL,
  `Continue` tinyint(1) NOT NULL,
  `IdCategory` int(11) NOT NULL,
  `DateCreated` datetime(6) NOT NULL,
  `DateUpdated` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `products`
--

INSERT INTO `products` (`Id`, `Name`, `Code`, `Price`, `Continue`, `IdCategory`, `DateCreated`, `DateUpdated`) VALUES
(1, 'Samsung SSD 870 EVO 500GB', 'MZ-77E500BW', 1290000, 1, 1, '2023-03-16 05:39:52.539549', '2023-03-16 05:41:55.000000'),
(2, 'SSD Samsung 870 Qvo 1TB 2.5-Inch SATA III', 'MZ-77Q1T0', 1850000, 1, 1, '2023-03-16 05:42:43.227589', '2023-03-16 05:42:43.227589'),
(3, 'SSD Samsung NVMe PM981a M.2 PCIe Gen3 x4 512GB', 'MZ-VLB512B', 1150000, 1, 1, '2023-03-16 05:44:11.670377', '2023-03-16 05:44:11.670377'),
(4, 'SSD Western Digital Blue SA510 3D-NAND 2.5-Inch SATA III 500GB', 'WDS500G3B0A', 1150000, 1, 1, '2023-03-16 05:45:49.348028', '2023-03-16 05:45:49.348028'),
(5, 'SSD Western Digital Blue SN570 PCIe Gen3 x4 NVMe M.2 500GB', 'WDS500G3B0C', 1150000, 1, 1, '2023-03-16 05:46:34.852218', '2023-03-16 05:46:34.852218'),
(6, 'SSD Crucial P3 Plus 500GB NVMe 3D-NAND M.2 PCIe Gen4 x4', 'CT500P3PSSD8', 1250000, 1, 1, '2023-03-16 05:47:40.539180', '2023-03-16 05:47:40.539180'),
(7, 'SSD Western Digital Blue SN570 PCIe Gen3 x4 NVMe M.2 1TB', 'WDS100T3B0C', 2190000, 1, 1, '2023-03-16 05:48:32.272180', '2023-03-16 05:48:32.272180'),
(8, 'Ram Laptop Corsair Vengeance DDR4 8GB 3200MHz 1.2v', 'CMSX8GX4M1A3200C22', 660000, 1, 2, '2023-03-16 05:51:33.458267', '2023-03-16 05:51:33.458267'),
(9, 'Ram Laptop Corsair Vengeance DDR4 16GB 2400MHz 1.2v', 'CMSX16GX4M1A2400C16', 1150000, 1, 2, '2023-03-16 05:52:30.045295', '2023-03-16 05:52:30.045295'),
(10, 'Ram Laptop Crucial DDR4 32GB 2666MHz 1.2v', 'CT32G4SFD8266', 2490000, 1, 2, '2023-03-16 05:53:10.631178', '2023-03-16 05:53:10.631177'),
(11, 'Ram PC Kingston Fury Beast RGB 16GB 3200MHz DDR4 (2x8GB)', 'KF432C16BBAK2', 1390000, 1, 2, '2023-03-16 05:55:23.072583', '2023-03-16 05:55:23.072582'),
(12, 'Ram PC Corsair Vengeance RGB RS 16GB 3200MHz DDR4 (2x8GB)', 'CMG16GX4M2E3200C16', 1390000, 1, 2, '2023-03-16 05:56:01.313456', '2023-03-16 05:56:01.313456'),
(13, 'Ram PC Corsair Vengeance RGB Pro 16GB 3200Mhz DDR4 (2x8GB)', 'CMW16GX4M2E3200C16W', 1750000, 1, 2, '2023-03-16 05:56:31.088898', '2023-03-16 05:56:31.088898'),
(14, 'ten san pham vua sua doi', 'maspabbbjhb', 22639444, 1, 3, '0001-01-01 00:00:00.000000', '2023-03-16 06:12:57.140754');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product_images`
--

CREATE TABLE `product_images` (
  `IdProduct` int(11) NOT NULL,
  `IdImage` int(11) NOT NULL,
  `DateCreated` datetime(6) NOT NULL,
  `DateUpdate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230315214428_init_dtp000', '7.0.4');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `images`
--
ALTER TABLE `images`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Products_IdCategory` (`IdCategory`);

--
-- Chỉ mục cho bảng `product_images`
--
ALTER TABLE `product_images`
  ADD PRIMARY KEY (`IdProduct`,`IdImage`),
  ADD KEY `IX_Product_Images_IdImage` (`IdImage`);

--
-- Chỉ mục cho bảng `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `categories`
--
ALTER TABLE `categories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `images`
--
ALTER TABLE `images`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `products`
--
ALTER TABLE `products`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `FK_Products_Categories_IdCategory` FOREIGN KEY (`IdCategory`) REFERENCES `categories` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `product_images`
--
ALTER TABLE `product_images`
  ADD CONSTRAINT `FK_Product_Images_Images_IdImage` FOREIGN KEY (`IdImage`) REFERENCES `images` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Product_Images_Products_IdProduct` FOREIGN KEY (`IdProduct`) REFERENCES `products` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
