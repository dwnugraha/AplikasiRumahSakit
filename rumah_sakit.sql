-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2016 at 11:30 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `rumah_sakit`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_biaya`
--

CREATE TABLE IF NOT EXISTS `detail_biaya` (
  `no_reg` varchar(11) NOT NULL,
  `biaya_ruang` int(11) NOT NULL,
  `biaya_dokter` int(11) NOT NULL,
  `biaya_obat` int(11) NOT NULL,
  `total_biaya` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `lama_inap` int(11) NOT NULL,
  `kd_pasien` varchar(10) NOT NULL,
  `kd_dokter` varchar(10) NOT NULL,
  `kd_ruang` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_biaya`
--

INSERT INTO `detail_biaya` (`no_reg`, `biaya_ruang`, `biaya_dokter`, `biaya_obat`, `total_biaya`, `keluhan`, `lama_inap`, `kd_pasien`, `kd_dokter`, `kd_ruang`) VALUES
('REG1', 1000000, 100000, 10000, 11100000, 'Mata merah', 10, 'P01', 'D01', 'R01'),
('REG2', 50000, 200000, 10000, 260000, 'Gigi cabut', 1, 'P02', 'D02', 'R02');

-- --------------------------------------------------------

--
-- Table structure for table `dokter`
--

CREATE TABLE IF NOT EXISTS `dokter` (
  `kd_dokter` varchar(10) NOT NULL,
  `nm_dokter` varchar(100) NOT NULL,
  `spesialis` varchar(100) NOT NULL,
  `no_telp` varchar(100) NOT NULL,
  `tarif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dokter`
--

INSERT INTO `dokter` (`kd_dokter`, `nm_dokter`, `spesialis`, `no_telp`, `tarif`) VALUES
('D01', 'daffa', 'mata', '12221', 100000),
('D02', 'Arya', 'Gigi', '2321535', 200000),
('D03', 'Naura', 'Umum', '231232', 50000);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `user` varchar(10) NOT NULL,
  `pass` varchar(10) NOT NULL,
  `kd_pegawai` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`user`, `pass`, `kd_pegawai`) VALUES
('daffa', '123', ''),
('nugraha', 'nugraha', ''),
('wisesa', 'wisesa', '');

-- --------------------------------------------------------

--
-- Table structure for table `pasien`
--

CREATE TABLE IF NOT EXISTS `pasien` (
  `kd_pasien` varchar(10) NOT NULL,
  `nm_pasien` varchar(100) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `umur` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pasien`
--

INSERT INTO `pasien` (`kd_pasien`, `nm_pasien`, `jk`, `alamat`, `umur`) VALUES
('P01', 'Arya', 'Laki laki', 'Malang', '13 Tahun'),
('P02', 'rara', 'Perempuan', 'Kesatrian', '13 Tahun');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE IF NOT EXISTS `pegawai` (
  `kd_pegawai` varchar(10) NOT NULL,
  `nm_pegawai` varchar(100) NOT NULL,
  `jabatan` varchar(10) NOT NULL,
  `no_telp` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `kd_dokter` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`kd_pegawai`, `nm_pegawai`, `jabatan`, `no_telp`, `alamat`, `kd_dokter`) VALUES
('01', 'Daffa', 'Karyawan', '12141', 'Malang', ''),
('02', 'Wisesa', 'Perawat', '214151', 'malang', ''),
('03', 'Nugraha', 'Karyawan', '02412', 'Klojen', '');

-- --------------------------------------------------------

--
-- Table structure for table `ruang`
--

CREATE TABLE IF NOT EXISTS `ruang` (
  `kd_ruang` varchar(10) NOT NULL,
  `nm_ruang` varchar(100) NOT NULL,
  `jenis_ruang` varchar(100) NOT NULL,
  `harga` int(11) NOT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ruang`
--

INSERT INTO `ruang` (`kd_ruang`, `nm_ruang`, `jenis_ruang`, `harga`, `stock`) VALUES
('R01', 'Flamboyan', 'VIP', 1000000, 10),
('R02', 'Melati', 'Kelas 2', 50000, 100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_biaya`
--
ALTER TABLE `detail_biaya`
 ADD PRIMARY KEY (`no_reg`);

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
 ADD PRIMARY KEY (`kd_dokter`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
 ADD PRIMARY KEY (`user`);

--
-- Indexes for table `pasien`
--
ALTER TABLE `pasien`
 ADD PRIMARY KEY (`kd_pasien`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
 ADD PRIMARY KEY (`kd_pegawai`);

--
-- Indexes for table `ruang`
--
ALTER TABLE `ruang`
 ADD PRIMARY KEY (`kd_ruang`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
