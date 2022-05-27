-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 26 May 2022, 18:46:27
-- Sunucu sürümü: 8.0.21
-- PHP Sürümü: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `bayrakdartek`
--

DELIMITER $$
--
-- Yordamlar
--
DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriBakiye`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriBakiye` (`id` VARCHAR(64))  BEGIN
    declare borc  float;
    declare odeme float;
    
    SELECT  SUM(satis_fiyat) into borc  
    FROM    bayrakdartek_satislar 
    WHERE   musteri_id = id;
    
    SELECT  SUM(odeme_tutar) into odeme  
    FROM    bayrakdartek_odemeler 
    WHERE   musteri_id = id;
    
    SELECT odeme - borc;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriBul`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriBul` (`filtre` VARCHAR(32))  BEGIN
    SELECT * FROM bayrakdartek_musteriler
    WHERE 
        musteri_id      LIKE  CONCAT('%',filtre,'%') OR
        musteri_ad      LIKE  CONCAT('%',filtre,'%') OR
        musteri_soyad   LIKE  CONCAT('%',filtre,'%') OR
        musteri_tel     LIKE  CONCAT('%',filtre,'%') OR
        musteri_mail    LIKE  CONCAT('%',filtre,'%') OR
        musteri_adres   LIKE  CONCAT('%',filtre,'%');
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriEkle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriEkle` (`id` VARCHAR(64), `ad` VARCHAR(64), `soy` VARCHAR(64), `tel` VARCHAR(25), `mail` VARCHAR(250), `adr` VARCHAR(250))  BEGIN
    INSERT INTO bayrakdartek_musteriler
    VALUES  (id, ad, soy, tel, mail, adr);
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriGuncelle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriGuncelle` (`id` VARCHAR(64), `ad` VARCHAR(64), `soy` VARCHAR(64), `tel` VARCHAR(25), `mail` VARCHAR(250), `adr` VARCHAR(250))  BEGIN
    UPDATE bayrakdartek_musteriler
    SET 
        musteri_ad      = ad,
        musteri_soyad   = soy,
        musteri_tel     = tel,
        musteri_mail    = mail,
        musteri_adres   = adr
    WHERE 
        musteri_id      = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusterilerHepsi`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusterilerHepsi` ()  BEGIN
    SELECT 
        musteri_id      as ID,
        musteri_ad      as Adı,
        musteri_soyad   as Soyadı,
        musteri_tel     as Telefon, 
        musteri_mail    as Mail,
        musteri_adres   as Adres
    FROM bayrakdartek_musteriler;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriSatislar`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriSatislar` (`id` VARCHAR(64))  BEGIN
    SELECT * FROM bayrakdartek_satislar
    WHERE musteri_id = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_MusteriSil`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_MusteriSil` (`id` VARCHAR(64))  BEGIN
    DELETE FROM bayrakdartek_musteriler
    WHERE   musteri_id  = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_OdemeDetay`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_OdemeDetay` ()  BEGIN
SELECT   
        o.odeme_id,
        m.musteri_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        o.odeme_tarih as `Ödeme Tarihi`,
        o.odeme_tutar as `Ödeme Tutarı`,
        o.odeme_tur as `Ödeme Türü`,
        o.odeme_aciklama as `Açıklama`
        
FROM    bayrakdartek_musteriler m inner join  bayrakdartek_odemeler o 
    on m.musteri_id = o.musteri_id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_OdemeEkle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_OdemeEkle` (`oid` VARCHAR(64), `mid` VARCHAR(64), `tarih` DATETIME, `tutar` FLOAT, `tur` VARCHAR(25), `aciklama` VARCHAR(250))  BEGIN
    INSERT INTO bayrakdartek_odemeler
    VALUES  (oid, mid, tarih, tutar, tur, aciklama);
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_OdemeGuncelle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_OdemeGuncelle` (`oid` VARCHAR(64), `mid` VARCHAR(64), `tarih` DATETIME, `tutar` FLOAT, `tur` VARCHAR(25), `aciklama` VARCHAR(250))  BEGIN
    UPDATE bayrakdartek_odemeler
    SET
        musteri_id      = mid,
        odeme_tarih     = tarih,
        odeme_tutar     = tutar,
        odeme_tur       = tur,
        odeme_aciklama  = aciklama
    WHERE 
        odeme_id = oid; 
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_OdemelerToplam`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_OdemelerToplam` ()  BEGIN
    SELECT  SUM(odeme_tutar)  
    FROM    bayrakdartek_odemeler ;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_OdemeSil`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_OdemeSil` (`oid` VARCHAR(64))  BEGIN
    DELETE FROM bayrakdartek_odemeler
    WHERE odeme_id = oid;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_SatisDetay`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_SatisDetay` ()  BEGIN
SELECT   
        s.satis_id,
        m.musteri_id,
        u.urun_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        urun_ad as `Ürün`,
        urun_kategori as `Kategori`,
        urun_fiyat as `Birim Fiyat`,
        satis_fiyat as `Satış Fiyatı`,
        satis_tarih as `Satış Tarihi`
FROM    bayrakdartek_musteriler m inner join  bayrakdartek_satislar s 
    on m.musteri_id = s.musteri_id 
        inner join bayrakdartek_urunler u on s.urun_id = u.urun_id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_SatisEkle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_SatisEkle` (`sid` VARCHAR(64), `mid` VARCHAR(64), `uid` VARCHAR(64), `tarih` DATETIME, `fiyat` FLOAT)  BEGIN
    INSERT INTO bayrakdartek_satislar
    VALUES  (sid, mid, uid, tarih, fiyat);
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_SatisGuncelle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_SatisGuncelle` (`sid` VARCHAR(64), `mid` VARCHAR(64), `uid` VARCHAR(64), `tarih` DATETIME, `fiyat` FLOAT)  BEGIN
    UPDATE bayrakdartek_satislar
    SET 
        musteri_id    = mid,
        urun_id       = uid,
        satis_tarih   = tarih,
        satis_fiyat   = fiyat
    WHERE 
        satis_id      = sid;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_SatislarToplam`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_SatislarToplam` ()  BEGIN
    SELECT  SUM(satis_fiyat)  
    FROM    bayrakdartek_satislar ;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_SatisSil`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_SatisSil` (`id` VARCHAR(64))  BEGIN
    DELETE FROM bayrakdartek_satislar
    WHERE satis_id  = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunBul`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunBul` (`filtre` VARCHAR(32))  BEGIN
    SELECT * FROM bayrakdartek_urunler
    WHERE 
        urun_id       LIKE  CONCAT('%',filtre,'%') OR
        urun_ad       LIKE  CONCAT('%',filtre,'%') OR
        urun_kategori LIKE  CONCAT('%',filtre,'%') OR
        urun_fiyat    LIKE  CONCAT('%',filtre,'%') OR
        urun_stok     LIKE  CONCAT('%',filtre,'%') OR
        urun_birim    LIKE  CONCAT('%',filtre,'%') OR
        urun_detay    LIKE  CONCAT('%',filtre,'%') ;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunEkle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunEkle` (`id` VARCHAR(64), `ad` VARCHAR(250), `kategori` VARCHAR(250), `fiyat` FLOAT, `stok` FLOAT, `birim` VARCHAR(16), `detay` VARCHAR(250))  BEGIN
    INSERT INTO bayrakdartek_urunler
    VALUES  (id, ad, kategori, fiyat, stok, birim, detay);
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunGuncelle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunGuncelle` (`id` VARCHAR(64), `ad` VARCHAR(250), `kategori` VARCHAR(250), `fiyat` FLOAT, `stok` FLOAT, `birim` VARCHAR(16), `detay` VARCHAR(250))  BEGIN
    UPDATE bayrakdartek_urunler
    SET 
        urun_ad       = ad,
        urun_kategori = kategori,
        urun_fiyat    = fiyat,
        urun_stok     = stok,
        urun_birim    = birim,
        urun_detay    = detay
    WHERE 
        urun_id       = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunlerHepsi`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunlerHepsi` ()  BEGIN
    SELECT * FROM bayrakdartek_urunler;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunSatislar`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunSatislar` (`id` VARCHAR(64))  BEGIN
    SELECT * FROM bayrakdartek_satislar
    WHERE urun_id = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunSil`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunSil` (`id` VARCHAR(64))  BEGIN
    DELETE FROM bayrakdartek_urunler
    WHERE urun_id  = id;
END$$

DROP PROCEDURE IF EXISTS `bayrakdartek_UrunStokGuncelle`$$
CREATE DEFINER=`Fatih`@`%` PROCEDURE `bayrakdartek_UrunStokGuncelle` (`id` VARCHAR(64), `stok` FLOAT)  BEGIN
    UPDATE bayrakdartek_urunler
    SET 
        urun_stok     = stok
    WHERE 
        urun_id       = id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bayrakdartek_musteriler`
--

DROP TABLE IF EXISTS `bayrakdartek_musteriler`;
CREATE TABLE IF NOT EXISTS `bayrakdartek_musteriler` (
  `musteri_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_ad` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_soyad` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_tel` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_mail` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_adres` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`musteri_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bayrakdartek_musteriler`
--

INSERT INTO `bayrakdartek_musteriler` (`musteri_id`, `musteri_ad`, `musteri_soyad`, `musteri_tel`, `musteri_mail`, `musteri_adres`) VALUES
('00849d72-e406-47a6-a1d9-08c8cf3ece87', 'Fatih', 'Bayrakdar', '5444519511', 'fatihbayrakdar95@gmail.com', 'ANKARA');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bayrakdartek_odemeler`
--

DROP TABLE IF EXISTS `bayrakdartek_odemeler`;
CREATE TABLE IF NOT EXISTS `bayrakdartek_odemeler` (
  `odeme_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `odeme_tarih` datetime NOT NULL,
  `odeme_tutar` float NOT NULL,
  `odeme_tur` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `odeme_aciklama` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`odeme_id`),
  KEY `musteri_id` (`musteri_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bayrakdartek_odemeler`
--

INSERT INTO `bayrakdartek_odemeler` (`odeme_id`, `musteri_id`, `odeme_tarih`, `odeme_tutar`, `odeme_tur`, `odeme_aciklama`) VALUES
('12679ac0-9296-4392-9af8-a9791f634ed5', '00849d72-e406-47a6-a1d9-08c8cf3ece87', '2022-05-26 21:26:03', 10000, 'Nakit', 'İlk Taksit');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bayrakdartek_satislar`
--

DROP TABLE IF EXISTS `bayrakdartek_satislar`;
CREATE TABLE IF NOT EXISTS `bayrakdartek_satislar` (
  `satis_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `musteri_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `urun_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `satis_tarih` datetime NOT NULL,
  `satis_fiyat` float NOT NULL,
  PRIMARY KEY (`satis_id`),
  KEY `musteri_id` (`musteri_id`),
  KEY `urun_id` (`urun_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bayrakdartek_satislar`
--

INSERT INTO `bayrakdartek_satislar` (`satis_id`, `musteri_id`, `urun_id`, `satis_tarih`, `satis_fiyat`) VALUES
('52d20992-9353-417e-81f4-dca7ad2c0683', '5e936196-3213-4b82-82f8-da8cf8e11e28', '00849d72-e406-47a6-a1d9-08c8cf3ece87', '2022-05-26 21:13:05', 20000),
('8654ae7a-2070-4e1c-8d63-effab2bd835b', '5e936196-3213-4b82-82f8-da8cf8e11e28', '00849d72-e406-47a6-a1d9-08c8cf3ece87', '2022-05-26 21:26:22', 20000),
('675407a2-7aa9-4007-8182-09612fc47cd8', '78026d20-3923-401c-9790-5960309c9592', '00849d72-e406-47a6-a1d9-08c8cf3ece87', '2022-05-26 21:44:03', 20000);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bayrakdartek_urunler`
--

DROP TABLE IF EXISTS `bayrakdartek_urunler`;
CREATE TABLE IF NOT EXISTS `bayrakdartek_urunler` (
  `urun_id` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `urun_ad` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  `urun_kategori` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  `urun_fiyat` float NOT NULL,
  `urun_stok` float NOT NULL,
  `urun_birim` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `urun_detay` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`urun_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bayrakdartek_urunler`
--

INSERT INTO `bayrakdartek_urunler` (`urun_id`, `urun_ad`, `urun_kategori`, `urun_fiyat`, `urun_stok`, `urun_birim`, `urun_detay`) VALUES
('5e936196-3213-4b82-82f8-da8cf8e11e28', 'Iphone 258GB', 'Telefon', 20000, 10, 'Adet ', 'Iphone Telefon'),
('78026d20-3923-401c-9790-5960309c9592', 'Lg 128inç HD', 'Televizyon', 20000, 10, 'Adet ', 'LG Televizyon');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
