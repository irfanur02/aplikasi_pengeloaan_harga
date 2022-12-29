-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2022 at 07:14 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_cvktm`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(150) DEFAULT NULL,
  `merek_barang` varchar(20) DEFAULT NULL,
  `model_barang` varchar(100) DEFAULT NULL,
  `seri_barang` varchar(15) DEFAULT NULL,
  `satuan_barang` char(8) NOT NULL,
  `detail_barang` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customer_pembelian`
--

CREATE TABLE `customer_pembelian` (
  `id_penjualan` int(11) DEFAULT NULL,
  `nama_customer_pembelian` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `detail_nomor_kantor`
--

CREATE TABLE `detail_nomor_kantor` (
  `id_detail_nomor_kantor` int(11) NOT NULL,
  `id_profil_kantor` int(11) DEFAULT NULL,
  `nomor_hp_kantor` char(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `detail_penjualan`
--

CREATE TABLE `detail_penjualan` (
  `id_penjualan` int(11) DEFAULT NULL,
  `id_barang` int(11) DEFAULT NULL,
  `id_jasa` int(11) DEFAULT NULL,
  `harga_penjualan` int(11) DEFAULT NULL,
  `jumlah_barang` int(11) DEFAULT NULL,
  `diskon` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `jasa`
--

CREATE TABLE `jasa` (
  `id_jasa` int(11) NOT NULL,
  `nama_jasa` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `mesin`
--

CREATE TABLE `mesin` (
  `id_mesin` int(11) NOT NULL,
  `nama_mesin` varchar(50) DEFAULT NULL,
  `merek_mesin` varchar(30) DEFAULT NULL,
  `model_mesin` varchar(50) DEFAULT NULL,
  `seri_mesin` varchar(50) DEFAULT NULL,
  `detail_mesin` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `mitra`
--

CREATE TABLE `mitra` (
  `id_mitra` int(11) NOT NULL,
  `nama_mitra` varchar(150) DEFAULT NULL,
  `alamat_mitra` varchar(255) DEFAULT NULL,
  `nomor_telp_mitra` char(12) DEFAULT NULL,
  `nomor_fax_mitra` char(12) DEFAULT NULL,
  `email_mitra` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `penawaran`
--

CREATE TABLE `penawaran` (
  `nomor_penawaran` char(4) NOT NULL,
  `id_penjualan` int(11) DEFAULT NULL,
  `tanggal_penawaran` date DEFAULT NULL,
  `status_penawaran` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `id_penjualan` int(11) NOT NULL,
  `id_mesin` int(11) DEFAULT NULL,
  `id_mitra` int(11) DEFAULT NULL,
  `keterangan_customer` varchar(40) DEFAULT NULL,
  `ppn` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `profil_kantor`
--

CREATE TABLE `profil_kantor` (
  `id_profil_kantor` int(11) NOT NULL,
  `nama_kantor` varchar(100) DEFAULT NULL,
  `pemilik_kantor` varchar(80) DEFAULT NULL,
  `alamat_kantor` varchar(255) DEFAULT NULL,
  `nomor_telp_kantor` char(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `purchase_order`
--

CREATE TABLE `purchase_order` (
  `nomor_purchase_order` char(4) NOT NULL,
  `nomor_surat_jalan` char(4) DEFAULT NULL,
  `tanggal_purchase_order` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `surat_jalan`
--

CREATE TABLE `surat_jalan` (
  `nomor_surat_jalan` char(4) NOT NULL,
  `nomor_penawaran` char(4) DEFAULT NULL,
  `tanggal_surat_jalan` date DEFAULT NULL,
  `status_surat_jalan` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indexes for table `customer_pembelian`
--
ALTER TABLE `customer_pembelian`
  ADD KEY `fk_customer_relations_penjuala` (`id_penjualan`);

--
-- Indexes for table `detail_nomor_kantor`
--
ALTER TABLE `detail_nomor_kantor`
  ADD PRIMARY KEY (`id_detail_nomor_kantor`),
  ADD KEY `fk_detail_n_relations_profil_k` (`id_profil_kantor`);

--
-- Indexes for table `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD KEY `fk_detail_p_relations_jasa` (`id_jasa`),
  ADD KEY `fk_detail_p_relations_barang` (`id_barang`),
  ADD KEY `fk_detail_p_relations_penjuala` (`id_penjualan`);

--
-- Indexes for table `jasa`
--
ALTER TABLE `jasa`
  ADD PRIMARY KEY (`id_jasa`);

--
-- Indexes for table `mesin`
--
ALTER TABLE `mesin`
  ADD PRIMARY KEY (`id_mesin`);

--
-- Indexes for table `mitra`
--
ALTER TABLE `mitra`
  ADD PRIMARY KEY (`id_mitra`);

--
-- Indexes for table `penawaran`
--
ALTER TABLE `penawaran`
  ADD PRIMARY KEY (`nomor_penawaran`),
  ADD KEY `fk_penawara_relations_penjuala` (`id_penjualan`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `fk_penjuala_relations_mesin` (`id_mesin`),
  ADD KEY `fk_penjuala_relations_mitra` (`id_mitra`);

--
-- Indexes for table `profil_kantor`
--
ALTER TABLE `profil_kantor`
  ADD PRIMARY KEY (`id_profil_kantor`);

--
-- Indexes for table `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD PRIMARY KEY (`nomor_purchase_order`),
  ADD KEY `fk_purchase_relations_surat_ja` (`nomor_surat_jalan`);

--
-- Indexes for table `surat_jalan`
--
ALTER TABLE `surat_jalan`
  ADD PRIMARY KEY (`nomor_surat_jalan`),
  ADD KEY `fk_surat_ja_relations_penawara` (`nomor_penawaran`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer_pembelian`
--
ALTER TABLE `customer_pembelian`
  ADD CONSTRAINT `fk_customer_relations_penjuala` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`);

--
-- Constraints for table `detail_nomor_kantor`
--
ALTER TABLE `detail_nomor_kantor`
  ADD CONSTRAINT `fk_detail_n_relations_profil_k` FOREIGN KEY (`id_profil_kantor`) REFERENCES `profil_kantor` (`id_profil_kantor`);

--
-- Constraints for table `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD CONSTRAINT `fk_detail_p_relations_barang` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`),
  ADD CONSTRAINT `fk_detail_p_relations_jasa` FOREIGN KEY (`id_jasa`) REFERENCES `jasa` (`id_jasa`),
  ADD CONSTRAINT `fk_detail_p_relations_penjuala` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`);

--
-- Constraints for table `penawaran`
--
ALTER TABLE `penawaran`
  ADD CONSTRAINT `fk_penawara_relations_penjuala` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`);

--
-- Constraints for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `fk_penjuala_relations_mesin` FOREIGN KEY (`id_mesin`) REFERENCES `mesin` (`id_mesin`),
  ADD CONSTRAINT `fk_penjuala_relations_mitra` FOREIGN KEY (`id_mitra`) REFERENCES `mitra` (`id_mitra`);

--
-- Constraints for table `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD CONSTRAINT `fk_purchase_relations_surat_ja` FOREIGN KEY (`nomor_surat_jalan`) REFERENCES `surat_jalan` (`nomor_surat_jalan`);

--
-- Constraints for table `surat_jalan`
--
ALTER TABLE `surat_jalan`
  ADD CONSTRAINT `fk_surat_ja_relations_penawara` FOREIGN KEY (`nomor_penawaran`) REFERENCES `penawaran` (`nomor_penawaran`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
