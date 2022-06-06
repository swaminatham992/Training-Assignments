create database Normalization
use Normalization


create table tblclientnormal
(
ClientNO varchar(20) primary key,
CName varchar(20) NOT NULL,
PropertyNO1 varchar(20),
PropertyNO2 varchar(20),
PropertyNO3 varchar(20),
Paddress1 varchar(30),
Paddress2 varchar(30),
Paddress3 varchar(30),
Rentstart1 DATE,
Rentstart2 DATE,
Rentstart3 DATE,
Rentstart4 DATE,
Rentstart5 DATE,
Rentfinish1 DATE,
Rentfinish2 DATE,
Rentfinish3 DATE,
Rentfinish4 DATE,
Rentfinish5 DATE,
Rent1 INT,
Rent2 INT,
Rent3 INT,
OwnerNO1 VARCHAR(10),
OwnerNO2 VARCHAR(10),
OName1 VARCHAR(20),
OName2 VARCHAR(20)

select * from tblclientnormal;
insert into tblclientnormal values('CR76','JOHNKAY','PG4','PG16',NULL,'6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW',NULL,'1-JUL-00','1-SEP-02',NULL,NULL,NULL,'31-AUG-01','1-SEP-02',NULL,NULL,NULL,350,450,NULL,'C040','CO93','TINAMURPHY','TONYSHAW')
insert into tblclientnormal values('CR56','ALINESTEWART','PG4','PG16','PG36','6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW','2 MONOR RD GLASGOW',NULL,NULL,'1-SEP-99','10-OCT-00','1-NOV-02',NULL,NULL,'10-JAN-00','1-DEC-01','1-AUG-03',350,450,370,'C040','CO93','TINAMURPHY','TONYSHAW')