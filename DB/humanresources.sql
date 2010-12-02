# MySQL-Front 5.1  (Build 4.2)

/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: localhost    Database: humanresources
# ------------------------------------------------------
# Server version 5.1.50-community

DROP DATABASE IF EXISTS `humanresources`;
CREATE DATABASE `humanresources` /*!40100 DEFAULT CHARACTER SET gb2312 */;
USE `humanresources`;

#
# Source for table candidate
#

DROP TABLE IF EXISTS `candidate`;
CREATE TABLE `candidate` (
  `Candidate_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '���',
  `Candidate_name` varchar(200) DEFAULT NULL COMMENT '����',
  `Candidate_sex` int(2) DEFAULT NULL COMMENT '�Ա�',
  `Candidate_birthday` date DEFAULT NULL COMMENT '��������',
  `Mingz_id` int(11) DEFAULT NULL COMMENT '������',
  `Nationality_id` int(11) DEFAULT NULL COMMENT '�������',
  `Candidate_marriage` varchar(200) DEFAULT NULL COMMENT '����״��',
  `Candidate_papersT` varchar(200) DEFAULT NULL COMMENT '֤������',
  `Candidate_papersN` varchar(200) DEFAULT NULL COMMENT '֤������',
  `registered` varchar(200) DEFAULT NULL COMMENT '�������ڵ�',
  `Candidate_method1` varchar(255) DEFAULT NULL COMMENT '��ϵ��ʽ1',
  `Candidate_method2` varchar(255) DEFAULT NULL COMMENT '��ϵ��ʽ2',
  `Candidate_telephone` varchar(200) DEFAULT NULL COMMENT '�̶��绰',
  `Candidate_Email` varchar(200) DEFAULT NULL COMMENT '��������',
  `recommend_mode` varchar(200) DEFAULT NULL COMMENT '�Ƽ�״̬',
  `incumbency_mode` varchar(200) DEFAULT NULL COMMENT '��ְ״̬',
  `User_id` int(11) DEFAULT NULL COMMENT '���ʱ��',
  `Comment` varchar(200) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Candidate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=gb2312 COMMENT='��ѡ��';

#
# Dumping data for table candidate
#

/*!40000 ALTER TABLE `candidate` DISABLE KEYS */;
INSERT INTO `candidate` VALUES (1,'���˻�',0,'2010-11-05',0,0,'δ֪','���֤','123','3123','12312','123','12312','1231','δ�Ƽ�','��ְ',1,'123123');
INSERT INTO `candidate` VALUES (2,'12312',0,'2010-11-05',0,0,'δ֪','���֤','123','3123','12312','123','12312','1231','δ�Ƽ�','��ְ',1,'123123');
INSERT INTO `candidate` VALUES (3,'werwer',0,'2010-11-05',0,0,'δ֪','���֤','','werwe','1231','123123','12312','12312','δ�Ƽ�','��ְ',2,'123');
INSERT INTO `candidate` VALUES (4,'werwer',0,'2010-11-05',0,0,'δ֪','���֤','','werwe','1231','123123','12312','12312','δ�Ƽ�','��ְ',2,'123');
INSERT INTO `candidate` VALUES (5,'κ���',0,'2010-11-07',1,1,'δ֪','���֤','1231','123123123','123','123123','2312','12','δ�Ƽ�','��ְ',1,'123123');
INSERT INTO `candidate` VALUES (6,'κ���',1,'2010-11-07',1,1,'δ֪','���֤','1231','123123123','123','123123','2312','12','δ�Ƽ�','��ְ',1,'123123');
INSERT INTO `candidate` VALUES (7,'κ���',0,'2010-11-07',1,1,'δ֪','���֤','123','12312','123','12','123','123','δ�Ƽ�','��ְ',2,'123');
INSERT INTO `candidate` VALUES (8,'123123',0,'2010-11-07',1,1,'δ֪','���֤','123','123','123','123','123','123','δ�Ƽ�','��ְ',2,'123');
INSERT INTO `candidate` VALUES (9,'qweqwe',0,'2010-11-07',1,1,'δ֪','���֤','123123','qqwe','123123','123','123123','123123','δ�Ƽ�','��ְ',1,'123');
INSERT INTO `candidate` VALUES (10,'123123',1,'2010-11-18',1,1,NULL,'���֤','','','123','2312','123','123','δ�Ƽ�','��ְ',1,'23123');
INSERT INTO `candidate` VALUES (11,'1231',1,'2010-11-18',1,1,'δ֪','���֤','','123123','','123','','123','δ�Ƽ�','��ְ',1,'123');
INSERT INTO `candidate` VALUES (12,'123',1,'2010-11-18',1,1,'δ��','���֤','123','123','123','123','123','123','δ�Ƽ�','��ְ',1,'123');
INSERT INTO `candidate` VALUES (13,'���',1,'2010-12-01',1,1,'δ��','���֤','','','','','','','δ�Ƽ�',NULL,1,'?\t���Ž�Ϊ�ḻ�����ۺͲ������ƹ���ʵ���������飻\r\n?\t������ʵ�Ļ�ƴ����������˰��ﻯ����Ƽ�Ͷ�ʷ������ڲ�����ʵ�����ˮƽ��\r\n?\t��Ϥ���ҵĸ���˰�ա������Ʒ��ɡ��������ؾ��÷�����Ϥ��������ҵ��\r\n?\t���н�ǿ����֯Э�������������빵ͨ������\r\n?\t���š����¹��ϡ�˼ά�Ͻ��������Ŷӡ�����ʵ�ɾ���\r\n');
INSERT INTO `candidate` VALUES (14,'123123',1,'2010-12-01',1,1,NULL,'���֤','','123123','','','','','δ�Ƽ�','��ְ',1,'');
INSERT INTO `candidate` VALUES (15,'123',1,'2010-12-01',1,1,'δ֪','���֤','123123','123','123','123','123','123','δ�Ƽ�','��ְ',1,'');
/*!40000 ALTER TABLE `candidate` ENABLE KEYS */;

#
# Source for table city
#

DROP TABLE IF EXISTS `city`;
CREATE TABLE `city` (
  `City_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '���б��',
  `City_name` varchar(200) DEFAULT NULL COMMENT '��������',
  `postcode` varchar(11) DEFAULT NULL COMMENT '�����ʱ�',
  `Province_id` int(6) DEFAULT NULL COMMENT 'ʡ�ݱ��',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`City_id`),
  KEY `FK_City_Province_id` (`Province_id`)
) ENGINE=InnoDB AUTO_INCREMENT=346 DEFAULT CHARSET=gb2312 COMMENT='����';

#
# Dumping data for table city
#

/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'������','100000',1,NULL);
INSERT INTO `city` VALUES (2,'�����','100000',2,NULL);
INSERT INTO `city` VALUES (3,'ʯ��ׯ��','50000',3,NULL);
INSERT INTO `city` VALUES (4,'��ɽ��','63000',3,NULL);
INSERT INTO `city` VALUES (5,'�ػʵ���','66000',3,NULL);
INSERT INTO `city` VALUES (6,'������','56000',3,NULL);
INSERT INTO `city` VALUES (7,'��̨��','54000',3,NULL);
INSERT INTO `city` VALUES (8,'������','71000',3,NULL);
INSERT INTO `city` VALUES (9,'�żҿ���','75000',3,NULL);
INSERT INTO `city` VALUES (10,'�е���','67000',3,NULL);
INSERT INTO `city` VALUES (11,'������','61000',3,NULL);
INSERT INTO `city` VALUES (12,'�ȷ���','65000',3,NULL);
INSERT INTO `city` VALUES (13,'��ˮ��','53000',3,NULL);
INSERT INTO `city` VALUES (14,'̫ԭ��','30000',4,NULL);
INSERT INTO `city` VALUES (15,'��ͬ��','37000',4,NULL);
INSERT INTO `city` VALUES (16,'��Ȫ��','45000',4,NULL);
INSERT INTO `city` VALUES (17,'������','46000',4,NULL);
INSERT INTO `city` VALUES (18,'������','48000',4,NULL);
INSERT INTO `city` VALUES (19,'˷����','36000',4,NULL);
INSERT INTO `city` VALUES (20,'������','30600',4,NULL);
INSERT INTO `city` VALUES (21,'�˳���','44000',4,NULL);
INSERT INTO `city` VALUES (22,'������','34000',4,NULL);
INSERT INTO `city` VALUES (23,'�ٷ���','41000',4,NULL);
INSERT INTO `city` VALUES (24,'������','30500',4,NULL);
INSERT INTO `city` VALUES (25,'���ͺ�����','10000',5,NULL);
INSERT INTO `city` VALUES (26,'��ͷ��','14000',5,NULL);
INSERT INTO `city` VALUES (27,'�ں���','16000',5,NULL);
INSERT INTO `city` VALUES (28,'�����','24000',5,NULL);
INSERT INTO `city` VALUES (29,'ͨ����','28000',5,NULL);
INSERT INTO `city` VALUES (30,'������˹��','10300',5,NULL);
INSERT INTO `city` VALUES (31,'���ױ�����','21000',5,NULL);
INSERT INTO `city` VALUES (32,'�����׶���','14400',5,NULL);
INSERT INTO `city` VALUES (33,'�����첼��','11800',5,NULL);
INSERT INTO `city` VALUES (34,'�˰���','137500',5,NULL);
INSERT INTO `city` VALUES (35,'���ֹ�����','11100',5,NULL);
INSERT INTO `city` VALUES (36,'��������','16000',5,NULL);
INSERT INTO `city` VALUES (37,'������','110000',6,NULL);
INSERT INTO `city` VALUES (38,'������','116000',6,NULL);
INSERT INTO `city` VALUES (39,'��ɽ��','114000',6,NULL);
INSERT INTO `city` VALUES (40,'��˳��','113000',6,NULL);
INSERT INTO `city` VALUES (41,'��Ϫ��','117000',6,NULL);
INSERT INTO `city` VALUES (42,'������','118000',6,NULL);
INSERT INTO `city` VALUES (43,'������','121000',6,NULL);
INSERT INTO `city` VALUES (44,'Ӫ����','115000',6,NULL);
INSERT INTO `city` VALUES (45,'������','123000',6,NULL);
INSERT INTO `city` VALUES (46,'������','111000',6,NULL);
INSERT INTO `city` VALUES (47,'�̽���','124000',6,NULL);
INSERT INTO `city` VALUES (48,'������','112000',6,NULL);
INSERT INTO `city` VALUES (49,'������','122000',6,NULL);
INSERT INTO `city` VALUES (50,'��«����','125000',6,NULL);
INSERT INTO `city` VALUES (51,'������','130000',7,NULL);
INSERT INTO `city` VALUES (52,'������','132000',7,NULL);
INSERT INTO `city` VALUES (53,'��ƽ��','136000',7,NULL);
INSERT INTO `city` VALUES (54,'��Դ��','136200',7,NULL);
INSERT INTO `city` VALUES (55,'ͨ����','134000',7,NULL);
INSERT INTO `city` VALUES (56,'��ɽ��','134300',7,NULL);
INSERT INTO `city` VALUES (57,'��ԭ��','131100',7,NULL);
INSERT INTO `city` VALUES (58,'�׳���','137000',7,NULL);
INSERT INTO `city` VALUES (59,'�ӱ߳�����������','133000',7,NULL);
INSERT INTO `city` VALUES (60,'��������','150000',8,NULL);
INSERT INTO `city` VALUES (61,'���������','161000',8,NULL);
INSERT INTO `city` VALUES (62,'������','158100',8,NULL);
INSERT INTO `city` VALUES (63,'�׸���','154100',8,NULL);
INSERT INTO `city` VALUES (64,'˫Ѽɽ��','155100',8,NULL);
INSERT INTO `city` VALUES (65,'������','163000',8,NULL);
INSERT INTO `city` VALUES (66,'������','152300',8,NULL);
INSERT INTO `city` VALUES (67,'��ľ˹��','154000',8,NULL);
INSERT INTO `city` VALUES (68,'��̨����','154600',8,NULL);
INSERT INTO `city` VALUES (69,'ĵ������','157000',8,NULL);
INSERT INTO `city` VALUES (70,'�ں���','164300',8,NULL);
INSERT INTO `city` VALUES (71,'�绯��','152000',8,NULL);
INSERT INTO `city` VALUES (72,'���˰������','165000',8,NULL);
INSERT INTO `city` VALUES (73,'�Ϻ���','200000',9,NULL);
INSERT INTO `city` VALUES (74,'�Ͼ���','210000',10,NULL);
INSERT INTO `city` VALUES (75,'������','214000',10,NULL);
INSERT INTO `city` VALUES (76,'������','221000',10,NULL);
INSERT INTO `city` VALUES (77,'������','213000',10,NULL);
INSERT INTO `city` VALUES (78,'������','215000',10,NULL);
INSERT INTO `city` VALUES (79,'��ͨ��','226000',10,NULL);
INSERT INTO `city` VALUES (80,'���Ƹ���','222000',10,NULL);
INSERT INTO `city` VALUES (81,'������','223200',10,NULL);
INSERT INTO `city` VALUES (82,'�γ���','224000',10,NULL);
INSERT INTO `city` VALUES (83,'������','225000',10,NULL);
INSERT INTO `city` VALUES (84,'����','212000',10,NULL);
INSERT INTO `city` VALUES (85,'̩����','225300',10,NULL);
INSERT INTO `city` VALUES (86,'��Ǩ��','223800',10,NULL);
INSERT INTO `city` VALUES (87,'������','310000',11,NULL);
INSERT INTO `city` VALUES (88,'������','315000',11,NULL);
INSERT INTO `city` VALUES (89,'������','325000',11,NULL);
INSERT INTO `city` VALUES (90,'������','314000',11,NULL);
INSERT INTO `city` VALUES (91,'������','313000',11,NULL);
INSERT INTO `city` VALUES (92,'������','312000',11,NULL);
INSERT INTO `city` VALUES (93,'����','321000',11,NULL);
INSERT INTO `city` VALUES (94,'������','324000',11,NULL);
INSERT INTO `city` VALUES (95,'��ɽ��','316000',11,NULL);
INSERT INTO `city` VALUES (96,'̨����','318000',11,NULL);
INSERT INTO `city` VALUES (97,'��ˮ��','323000',11,NULL);
INSERT INTO `city` VALUES (98,'�Ϸ���','230000',12,NULL);
INSERT INTO `city` VALUES (99,'�ߺ���','241000',12,NULL);
INSERT INTO `city` VALUES (100,'������','233000',12,NULL);
INSERT INTO `city` VALUES (101,'������','232000',12,NULL);
INSERT INTO `city` VALUES (102,'��ɽ��','243000',12,NULL);
INSERT INTO `city` VALUES (103,'������','235000',12,NULL);
INSERT INTO `city` VALUES (104,'ͭ����','244000',12,NULL);
INSERT INTO `city` VALUES (105,'������','246000',12,NULL);
INSERT INTO `city` VALUES (106,'��ɽ��','242700',12,NULL);
INSERT INTO `city` VALUES (107,'������','239000',12,NULL);
INSERT INTO `city` VALUES (108,'������','236100',12,NULL);
INSERT INTO `city` VALUES (109,'������','234100',12,NULL);
INSERT INTO `city` VALUES (110,'������','238000',12,NULL);
INSERT INTO `city` VALUES (111,'������','237000',12,NULL);
INSERT INTO `city` VALUES (112,'������','236800',12,NULL);
INSERT INTO `city` VALUES (113,'������','247100',12,NULL);
INSERT INTO `city` VALUES (114,'������','366000',12,NULL);
INSERT INTO `city` VALUES (115,'������','350000',13,NULL);
INSERT INTO `city` VALUES (116,'������','361000',13,NULL);
INSERT INTO `city` VALUES (117,'������','351100',13,NULL);
INSERT INTO `city` VALUES (118,'������','365000',13,NULL);
INSERT INTO `city` VALUES (119,'Ȫ����','362000',13,NULL);
INSERT INTO `city` VALUES (120,'������','363000',13,NULL);
INSERT INTO `city` VALUES (121,'��ƽ��','353000',13,NULL);
INSERT INTO `city` VALUES (122,'������','364000',13,NULL);
INSERT INTO `city` VALUES (123,'������','352100',13,NULL);
INSERT INTO `city` VALUES (124,'�ϲ���','330000',14,NULL);
INSERT INTO `city` VALUES (125,'��������','333000',14,NULL);
INSERT INTO `city` VALUES (126,'Ƽ����','337000',14,NULL);
INSERT INTO `city` VALUES (127,'�Ž���','332000',14,NULL);
INSERT INTO `city` VALUES (128,'������','338000',14,NULL);
INSERT INTO `city` VALUES (129,'ӥ̶��','335000',14,NULL);
INSERT INTO `city` VALUES (130,'������','341000',14,NULL);
INSERT INTO `city` VALUES (131,'������','343000',14,NULL);
INSERT INTO `city` VALUES (132,'�˴���','336000',14,NULL);
INSERT INTO `city` VALUES (133,'������','332900',14,NULL);
INSERT INTO `city` VALUES (134,'������','334000',14,NULL);
INSERT INTO `city` VALUES (135,'������','250000',15,NULL);
INSERT INTO `city` VALUES (136,'�ൺ��','266000',15,NULL);
INSERT INTO `city` VALUES (137,'�Ͳ���','255000',15,NULL);
INSERT INTO `city` VALUES (138,'��ׯ��','277100',15,NULL);
INSERT INTO `city` VALUES (139,'��Ӫ��','257000',15,NULL);
INSERT INTO `city` VALUES (140,'��̨��','264000',15,NULL);
INSERT INTO `city` VALUES (141,'Ϋ����','261000',15,NULL);
INSERT INTO `city` VALUES (142,'������','272100',15,NULL);
INSERT INTO `city` VALUES (143,'̩����','271000',15,NULL);
INSERT INTO `city` VALUES (144,'������','265700',15,NULL);
INSERT INTO `city` VALUES (145,'������','276800',15,NULL);
INSERT INTO `city` VALUES (146,'������','271100',15,NULL);
INSERT INTO `city` VALUES (147,'������','276000',15,NULL);
INSERT INTO `city` VALUES (148,'������','253000',15,NULL);
INSERT INTO `city` VALUES (149,'�ĳ���','252000',15,NULL);
INSERT INTO `city` VALUES (150,'������','256600',15,NULL);
INSERT INTO `city` VALUES (151,'������','255000',15,NULL);
INSERT INTO `city` VALUES (152,'֣����','450000',16,NULL);
INSERT INTO `city` VALUES (153,'������','475000',16,NULL);
INSERT INTO `city` VALUES (154,'������','471000',16,NULL);
INSERT INTO `city` VALUES (155,'ƽ��ɽ��','467000',16,NULL);
INSERT INTO `city` VALUES (156,'������','454900',16,NULL);
INSERT INTO `city` VALUES (157,'�ױ���','456600',16,NULL);
INSERT INTO `city` VALUES (158,'������','453000',16,NULL);
INSERT INTO `city` VALUES (159,'������','454100',16,NULL);
INSERT INTO `city` VALUES (160,'�����','457000',16,NULL);
INSERT INTO `city` VALUES (161,'�����','461000',16,NULL);
INSERT INTO `city` VALUES (162,'�����','462000',16,NULL);
INSERT INTO `city` VALUES (163,'����Ͽ��','472000',16,NULL);
INSERT INTO `city` VALUES (164,'������','473000',16,NULL);
INSERT INTO `city` VALUES (165,'������','476000',16,NULL);
INSERT INTO `city` VALUES (166,'������','464000',16,NULL);
INSERT INTO `city` VALUES (167,'�ܿ���','466000',16,NULL);
INSERT INTO `city` VALUES (168,'פ�����','463000',16,NULL);
INSERT INTO `city` VALUES (169,'�人��','430000',17,NULL);
INSERT INTO `city` VALUES (170,'��ʯ��','435000',17,NULL);
INSERT INTO `city` VALUES (171,'ʮ����','442000',17,NULL);
INSERT INTO `city` VALUES (172,'�˲���','443000',17,NULL);
INSERT INTO `city` VALUES (173,'�差��','441000',17,NULL);
INSERT INTO `city` VALUES (174,'������','436000',17,NULL);
INSERT INTO `city` VALUES (175,'������','448000',17,NULL);
INSERT INTO `city` VALUES (176,'Т����','432100',17,NULL);
INSERT INTO `city` VALUES (177,'������','434000',17,NULL);
INSERT INTO `city` VALUES (178,'�Ƹ���','438000',17,NULL);
INSERT INTO `city` VALUES (179,'������','437000',17,NULL);
INSERT INTO `city` VALUES (180,'������','441300',17,NULL);
INSERT INTO `city` VALUES (181,'��ʩ����������������','445000',17,NULL);
INSERT INTO `city` VALUES (182,'��ũ��','442400',17,NULL);
INSERT INTO `city` VALUES (183,'��ɳ��','410000',18,NULL);
INSERT INTO `city` VALUES (184,'������','412000',18,NULL);
INSERT INTO `city` VALUES (185,'��̶��','411100',18,NULL);
INSERT INTO `city` VALUES (186,'������','421000',18,NULL);
INSERT INTO `city` VALUES (187,'������','422000',18,NULL);
INSERT INTO `city` VALUES (188,'������','414000',18,NULL);
INSERT INTO `city` VALUES (189,'������','415000',18,NULL);
INSERT INTO `city` VALUES (190,'�żҽ���','427000',18,NULL);
INSERT INTO `city` VALUES (191,'������','413000',18,NULL);
INSERT INTO `city` VALUES (192,'������','423000',18,NULL);
INSERT INTO `city` VALUES (193,'������','425000',18,NULL);
INSERT INTO `city` VALUES (194,'������','418000',18,NULL);
INSERT INTO `city` VALUES (195,'¦����','417000',18,NULL);
INSERT INTO `city` VALUES (196,'��������������������','416000',18,NULL);
INSERT INTO `city` VALUES (197,'������','510000',19,NULL);
INSERT INTO `city` VALUES (198,'�ع���','521000',19,NULL);
INSERT INTO `city` VALUES (199,'������','518000',19,NULL);
INSERT INTO `city` VALUES (200,'�麣��','519000',19,NULL);
INSERT INTO `city` VALUES (201,'��ͷ��','515000',19,NULL);
INSERT INTO `city` VALUES (202,'��ɽ��','528000',19,NULL);
INSERT INTO `city` VALUES (203,'������','529000',19,NULL);
INSERT INTO `city` VALUES (204,'տ����','524000',19,NULL);
INSERT INTO `city` VALUES (205,'ï����','525000',19,NULL);
INSERT INTO `city` VALUES (206,'������','526000',19,NULL);
INSERT INTO `city` VALUES (207,'������','516000',19,NULL);
INSERT INTO `city` VALUES (208,'÷����','514000',19,NULL);
INSERT INTO `city` VALUES (209,'��β��','516600',19,NULL);
INSERT INTO `city` VALUES (210,'��Դ��','517000',19,NULL);
INSERT INTO `city` VALUES (211,'������','529500',19,NULL);
INSERT INTO `city` VALUES (212,'��Զ��','511500',19,NULL);
INSERT INTO `city` VALUES (213,'��ݸ��','511700',19,NULL);
INSERT INTO `city` VALUES (214,'��ɽ��','528400',19,NULL);
INSERT INTO `city` VALUES (215,'������','515600',19,NULL);
INSERT INTO `city` VALUES (216,'������','522000',19,NULL);
INSERT INTO `city` VALUES (217,'�Ƹ���','527300',19,NULL);
INSERT INTO `city` VALUES (218,'������','530000',20,NULL);
INSERT INTO `city` VALUES (219,'������','545000',20,NULL);
INSERT INTO `city` VALUES (220,'������','541000',20,NULL);
INSERT INTO `city` VALUES (221,'������','543000',20,NULL);
INSERT INTO `city` VALUES (222,'������','536000',20,NULL);
INSERT INTO `city` VALUES (223,'���Ǹ���','538000',20,NULL);
INSERT INTO `city` VALUES (224,'������','535000',20,NULL);
INSERT INTO `city` VALUES (225,'�����','537100',20,NULL);
INSERT INTO `city` VALUES (226,'������','537000',20,NULL);
INSERT INTO `city` VALUES (227,'��ɫ��','533000',20,NULL);
INSERT INTO `city` VALUES (228,'������','542800',20,NULL);
INSERT INTO `city` VALUES (229,'�ӳ���','547000',20,NULL);
INSERT INTO `city` VALUES (230,'������','546100',20,NULL);
INSERT INTO `city` VALUES (231,'������','532200',20,NULL);
INSERT INTO `city` VALUES (232,'������','570000',21,NULL);
INSERT INTO `city` VALUES (233,'������','572000',21,NULL);
INSERT INTO `city` VALUES (234,'������','400000',22,NULL);
INSERT INTO `city` VALUES (235,'�ɶ���','610000',23,NULL);
INSERT INTO `city` VALUES (236,'�Թ���','643000',23,NULL);
INSERT INTO `city` VALUES (237,'��֦����','617000',23,NULL);
INSERT INTO `city` VALUES (238,'������','646100',23,NULL);
INSERT INTO `city` VALUES (239,'������','618000',23,NULL);
INSERT INTO `city` VALUES (240,'������','621000',23,NULL);
INSERT INTO `city` VALUES (241,'��Ԫ��','628000',23,NULL);
INSERT INTO `city` VALUES (242,'������','629000',23,NULL);
INSERT INTO `city` VALUES (243,'�ڽ���','641000',23,NULL);
INSERT INTO `city` VALUES (244,'��ɽ��','614000',23,NULL);
INSERT INTO `city` VALUES (245,'�ϳ���','637000',23,NULL);
INSERT INTO `city` VALUES (246,'üɽ��','612100',23,NULL);
INSERT INTO `city` VALUES (247,'�˱���','644000',23,NULL);
INSERT INTO `city` VALUES (248,'�㰲��','638000',23,NULL);
INSERT INTO `city` VALUES (249,'������','635000',23,NULL);
INSERT INTO `city` VALUES (250,'�Ű���','625000',23,NULL);
INSERT INTO `city` VALUES (251,'������','635500',23,NULL);
INSERT INTO `city` VALUES (252,'������','641300',23,NULL);
INSERT INTO `city` VALUES (253,'���Ӳ���Ǽ��������','624600',23,NULL);
INSERT INTO `city` VALUES (254,'���β���������','626000',23,NULL);
INSERT INTO `city` VALUES (255,'��ɽ����������','615000',23,NULL);
INSERT INTO `city` VALUES (256,'������','55000',24,NULL);
INSERT INTO `city` VALUES (257,'����ˮ��','553000',24,NULL);
INSERT INTO `city` VALUES (258,'������','563000',24,NULL);
INSERT INTO `city` VALUES (259,'��˳��','561000',24,NULL);
INSERT INTO `city` VALUES (260,'ͭ�ʵ���','554300',24,NULL);
INSERT INTO `city` VALUES (261,'ǭ���ϲ���������������','551500',24,NULL);
INSERT INTO `city` VALUES (262,'�Ͻڵ���','551700',24,NULL);
INSERT INTO `city` VALUES (263,'ǭ�������嶱��������','551500',24,NULL);
INSERT INTO `city` VALUES (264,'ǭ�ϲ���������������','550100',24,NULL);
INSERT INTO `city` VALUES (265,'������','650000',25,NULL);
INSERT INTO `city` VALUES (266,'������','655000',25,NULL);
INSERT INTO `city` VALUES (267,'��Ϫ��','653100',25,NULL);
INSERT INTO `city` VALUES (268,'��ɽ��','678000',25,NULL);
INSERT INTO `city` VALUES (269,'��ͨ��','657000',25,NULL);
INSERT INTO `city` VALUES (270,'������','674100',25,NULL);
INSERT INTO `city` VALUES (271,'˼é��','665000',25,NULL);
INSERT INTO `city` VALUES (272,'�ٲ���','677000',25,NULL);
INSERT INTO `city` VALUES (273,'��������������','675000',25,NULL);
INSERT INTO `city` VALUES (274,'��ӹ���������������','654400',25,NULL);
INSERT INTO `city` VALUES (275,'��ɽ׳������������','663000',25,NULL);
INSERT INTO `city` VALUES (276,'��˫���ɴ���������','666200',25,NULL);
INSERT INTO `city` VALUES (277,'�������������','671000',25,NULL);
INSERT INTO `city` VALUES (278,'�º���徰����������','678400',25,NULL);
INSERT INTO `city` VALUES (279,'ŭ��������������','671400',25,NULL);
INSERT INTO `city` VALUES (280,'�������������','674400',25,NULL);
INSERT INTO `city` VALUES (281,'������','850000',26,NULL);
INSERT INTO `city` VALUES (282,'��������','854000',26,NULL);
INSERT INTO `city` VALUES (283,'ɽ�ϵ���','856000',26,NULL);
INSERT INTO `city` VALUES (284,'�տ������','857000',26,NULL);
INSERT INTO `city` VALUES (285,'��������','852000',26,NULL);
INSERT INTO `city` VALUES (286,'�������','859100',26,NULL);
INSERT INTO `city` VALUES (287,'��֥����','860100',26,NULL);
INSERT INTO `city` VALUES (288,'������','710000',27,NULL);
INSERT INTO `city` VALUES (289,'ͭ����','727000',27,NULL);
INSERT INTO `city` VALUES (290,'������','721000',27,NULL);
INSERT INTO `city` VALUES (291,'������','712000',27,NULL);
INSERT INTO `city` VALUES (292,'μ����','714000',27,NULL);
INSERT INTO `city` VALUES (293,'�Ӱ���','716000',27,NULL);
INSERT INTO `city` VALUES (294,'������','723000',27,NULL);
INSERT INTO `city` VALUES (295,'������','719000',27,NULL);
INSERT INTO `city` VALUES (296,'������','725000',27,NULL);
INSERT INTO `city` VALUES (297,'������','711500',27,NULL);
INSERT INTO `city` VALUES (298,'������','730000',28,NULL);
INSERT INTO `city` VALUES (299,'��������','735100',28,NULL);
INSERT INTO `city` VALUES (300,'�����','737100',28,NULL);
INSERT INTO `city` VALUES (301,'������','730900',28,NULL);
INSERT INTO `city` VALUES (302,'��ˮ��','741000',28,NULL);
INSERT INTO `city` VALUES (303,'������','733000',28,NULL);
INSERT INTO `city` VALUES (304,'��Ҵ��','734000',28,NULL);
INSERT INTO `city` VALUES (305,'ƽ����','744000',28,NULL);
INSERT INTO `city` VALUES (306,'��Ȫ��','735000',28,NULL);
INSERT INTO `city` VALUES (307,'������','744500',28,NULL);
INSERT INTO `city` VALUES (308,'������','743000',28,NULL);
INSERT INTO `city` VALUES (309,'¤����','742100',28,NULL);
INSERT INTO `city` VALUES (310,'���Ļ���������','731100',28,NULL);
INSERT INTO `city` VALUES (311,'���ϲ���������','747000',28,NULL);
INSERT INTO `city` VALUES (312,'������','810000',29,NULL);
INSERT INTO `city` VALUES (313,'��������','810600',29,NULL);
INSERT INTO `city` VALUES (314,'��������������','810300',29,NULL);
INSERT INTO `city` VALUES (315,'���ϲ���������','811300',29,NULL);
INSERT INTO `city` VALUES (316,'���ϲ���������','813000',29,NULL);
INSERT INTO `city` VALUES (317,'�������������','814000',29,NULL);
INSERT INTO `city` VALUES (318,'��������������','815000',29,NULL);
INSERT INTO `city` VALUES (319,'�����ɹ������������','817000',29,NULL);
INSERT INTO `city` VALUES (320,'������','750000',30,NULL);
INSERT INTO `city` VALUES (321,'ʯ��ɽ��','753000',30,NULL);
INSERT INTO `city` VALUES (322,'������','751100',30,NULL);
INSERT INTO `city` VALUES (323,'��ԭ��','756000',30,NULL);
INSERT INTO `city` VALUES (324,'������','751700',30,NULL);
INSERT INTO `city` VALUES (325,'��³ľ����','830000',31,NULL);
INSERT INTO `city` VALUES (326,'����������','834000',31,NULL);
INSERT INTO `city` VALUES (327,'��³������','838000',31,NULL);
INSERT INTO `city` VALUES (328,'���ܵ���','839000',31,NULL);
INSERT INTO `city` VALUES (329,'��������������','831100',31,NULL);
INSERT INTO `city` VALUES (330,'���������ɹ�������','833400',31,NULL);
INSERT INTO `city` VALUES (331,'���������ɹ�������','841000',31,NULL);
INSERT INTO `city` VALUES (332,'�����յ���','843000',31,NULL);
INSERT INTO `city` VALUES (333,'�������տ¶�����������','835600',31,NULL);
INSERT INTO `city` VALUES (334,'��ʲ����','844000',31,NULL);
INSERT INTO `city` VALUES (335,'�������','848000',31,NULL);
INSERT INTO `city` VALUES (336,'���������������','833200',31,NULL);
INSERT INTO `city` VALUES (337,'���ǵ���','834700',31,NULL);
INSERT INTO `city` VALUES (338,'����̩����','836500',31,NULL);
INSERT INTO `city` VALUES (339,'ʯ������','832000',31,NULL);
INSERT INTO `city` VALUES (340,'��������','843300',31,NULL);
INSERT INTO `city` VALUES (341,'ͼľ�����','843900',31,NULL);
INSERT INTO `city` VALUES (342,'�������','831300',31,NULL);
INSERT INTO `city` VALUES (343,'����ر�������','0',32,NULL);
INSERT INTO `city` VALUES (344,'�����ر�������','0',33,NULL);
INSERT INTO `city` VALUES (345,'̨��ʡ','0',34,NULL);
/*!40000 ALTER TABLE `city` ENABLE KEYS */;

#
# Source for table client
#

DROP TABLE IF EXISTS `client`;
CREATE TABLE `client` (
  `Client_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '�ͻ���� �ͻ����',
  `Client_establishT` datetime DEFAULT NULL COMMENT '��������ʱ��',
  `User_id` int(11) DEFAULT NULL COMMENT '�û����',
  `Client_name` varchar(100) DEFAULT NULL COMMENT '�ͻ����� �ͻ�����',
  `Client_nameE` varchar(100) DEFAULT NULL COMMENT '�ͻ����ƣ�Ӣ�ģ� �ͻ����ƣ�Ӣ�ģ�',
  `Client_Property` int(11) DEFAULT NULL COMMENT '�ͻ����� �ͻ�����',
  `Client_URL` varchar(100) DEFAULT NULL COMMENT '�ͻ���ַ �ͻ���ַ',
  `Client_add` varchar(100) DEFAULT NULL COMMENT '�ͻ���ַ �ͻ���ַ',
  `Client_postcode` varchar(100) DEFAULT NULL COMMENT '�ͻ��ʱ� �ͻ��ʱ�',
  `Client_product` varchar(100) DEFAULT NULL COMMENT '��Ҫ��Ʒ ��Ҫ��Ʒ',
  `Client_targetMarket` varchar(100) DEFAULT NULL COMMENT 'Ŀ���г� Ŀ���г�',
  `Trade_id` int(11) DEFAULT NULL COMMENT '��ҵ��� ��ҵ���',
  `Province_id` int(11) DEFAULT NULL COMMENT 'ʡ�ݱ�� ʡ�ݱ��',
  `City_id` int(11) DEFAULT '0' COMMENT '���б�� ���б��',
  `Client_typical` varchar(100) DEFAULT NULL COMMENT '���Ϳͻ� ���Ϳͻ�',
  `Ownership_id` int(11) DEFAULT NULL COMMENT '���������ʱ�� ���������ʱ��',
  `OperationModel_id` int(11) DEFAULT NULL COMMENT '�ͻ���Ӫģʽ��� �ͻ���Ӫģʽ���',
  `Client_summary` varchar(100) DEFAULT NULL COMMENT '�򵥽��� �򵥽���',
  `Dimensions_id` int(11) DEFAULT NULL COMMENT '��˾��ģ��� ��˾��ģ���',
  `EmployeesNumber_id` int(11) DEFAULT NULL COMMENT 'Ա��������� Ա���������',
  `Client_sales` double DEFAULT NULL COMMENT '�����۶� �����۶�',
  `Client_structure` varchar(100) DEFAULT NULL COMMENT '��˾��֯�ṹ ��˾��֯�ṹ',
  `Client_development` varchar(100) DEFAULT NULL COMMENT '��˾ҵ��չ�����Լ���3-5��Ĺ滮 ��˾ҵ��չ�����Լ���3-5��Ĺ滮',
  `Client_challenge` varchar(100) DEFAULT NULL COMMENT '���ڹ�˾���ٵ���ս��ʲô ���ڹ�˾���ٵ���ս��ʲô',
  `Client_turnover` varchar(100) DEFAULT NULL COMMENT 'Ա�������� Ա��������',
  `Client_Intermediate` varchar(100) DEFAULT NULL COMMENT '�и߼�Ա�� �и߼�Ա��',
  `Client_primary` varchar(100) DEFAULT NULL COMMENT '����Ա�� ����Ա��',
  `Client_Join` varchar(100) DEFAULT NULL COMMENT '��е���Ա���ͼ���Ƹ��ְλ ��е���Ա���ͼ���Ƹ��ְλ',
  `Client_difficulty` varchar(100) DEFAULT NULL COMMENT '��Ƹʱͨ�������������� ��Ƹʱͨ��������������',
  `Client_cooperation` tinyint(1) DEFAULT NULL COMMENT '�Ƿ�����ͷ������ �Ƿ�����ͷ������',
  `Client_cooperationN` varchar(100) DEFAULT NULL COMMENT '�����ɹ�����/�� ��������',
  `Client_recruitment` varchar(100) DEFAULT NULL COMMENT '��˾���/δ������������Ƹ�ƻ� ��˾���/δ������������Ƹ�ƻ�',
  `Client_cooperationA` varchar(100) DEFAULT NULL COMMENT '���ܺ��������� ���ܺ���������',
  `Client_staff` varchar(100) DEFAULT NULL COMMENT '��˾ϣ����Ƹ��ʲô����Ա�� ��˾ϣ����Ƹ��ʲô����Ա��',
  `Client_income1` varchar(100) DEFAULT NULL COMMENT '�����˾,Ա�����������1 �����˾,Ա�����������1',
  `Client_income2` varchar(100) DEFAULT NULL COMMENT '�����˾,Ա�����������2 �����˾,Ա�����������2',
  `Client_challenge1` varchar(100) DEFAULT NULL COMMENT '�����ս1 �����ս1',
  `Client_challenge2` varchar(100) DEFAULT NULL COMMENT '�����ս2 �����ս2',
  `Client_interviewing` varchar(100) DEFAULT NULL COMMENT '��˾����������ͨ����ʲô ��˾����������ͨ����ʲô',
  `Client_way` varchar(100) DEFAULT NULL COMMENT '���Է�ʽ ���Է�ʽ',
  `Client_period` varchar(100) DEFAULT NULL COMMENT '���Ե����� ���Ե�����',
  `Client_welfare` varchar(100) DEFAULT NULL COMMENT '��˾��н�ʸ�����ͬ�����,�����Ǹ���� ��˾��н�ʸ�����ͬ�����,�����Ǹ����',
  `Client_increase` varchar(100) DEFAULT NULL COMMENT '��н���� ��н����',
  `Client_range` varchar(100) DEFAULT NULL COMMENT 'ÿ��ĵ�н���� ÿ��ĵ�н����',
  `Client_reputation` varchar(100) DEFAULT NULL COMMENT '��˾���� ��˾����',
  `Client_hierarchy` varchar(100) DEFAULT NULL COMMENT '��Ҫ�㼶 ��Ҫ�㼶',
  `Client_status` varchar(100) DEFAULT NULL COMMENT '����״̬ ����״̬',
  `Client_contract` varchar(100) DEFAULT NULL COMMENT '��ͬ�Ƿ�ǩ��',
  `Comment` varchar(100) DEFAULT NULL COMMENT '��ע ��ע',
  PRIMARY KEY (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=gb2312;

#
# Dumping data for table client
#

/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (14,'2010-10-29 18:26:01',1,'qq','qq',1,'','','','','',0,0,0,'',5,0,'',0,0,0,'','','','',NULL,'','','',1,'','','','','','','','','','','','','','','','','',NULL,NULL);
INSERT INTO `client` VALUES (15,'2010-12-01 03:53:41',1,'123','123',1,'','','','','',1,1,1,'',1,0,'',0,0,0,'','','','','','','','',1,'','','','','','','','','','','','','','','','','',NULL,NULL);
INSERT INTO `client` VALUES (16,'2010-11-18 15:45:45',1,'123','123',1,'','','','','',1,1,7,'',1,0,'',0,0,0,'','','','','','','','',1,'','','','','','','','','','','','','','','','','',NULL,NULL);
INSERT INTO `client` VALUES (17,'2010-11-18 15:48:27',1,'123','123',1,'','','','','',1,1,8,'',1,0,'',0,0,0,'','','','','','','','',1,'','','','','','','','','','','','','','','','','',NULL,NULL);
INSERT INTO `client` VALUES (18,'2010-12-01 00:57:13',1,'��������������','Areva',1,'http://www.areva.com/','�Ϻ��������ֽ����ֽ��߿Ƽ�԰��','222222','�̵籣��','�߶�/�ж��г�',31,9,0,'������˾�����ز���',1,1,'',3,3,5,'GM���£����񲿡����²��������������̲������񲿡�EHS���š��з��������۲�','�ڵ�����Ϊ��ͷ��ҵ','��˾��ʩ�͵ºͰ���˹ͨ�������幫˾�չ����ڲ����ڵ���','9','50������','100������','�̱��з�����ʦ��Ӳ������ʦ���������ʦ','Ŀ�깫˾���٣���Ա������Խϵ�',1,'5��/��','�����кܴ����żƻ�����������Ա�ļܹ�����','�з�����ʦ','��ؾ���ḻ��̤ʵ�ȶ�','���õ�ְҵ��չ�ռ�','�ܺõ�н�긣��','��˾��Ʒ�ľ���������','','HRM�����ž���','','һ��2��','����','ÿ��3��','8%','','','',NULL,NULL);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

#
# Source for table client_follow
#

DROP TABLE IF EXISTS `client_follow`;
CREATE TABLE `client_follow` (
  `CF_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '�������',
  `User_id` int(11) DEFAULT NULL COMMENT '�û����',
  `Client_id` int(11) DEFAULT NULL COMMENT '�ͻ����',
  `CF_time` date DEFAULT NULL COMMENT '����ʱ��',
  `CF_target` varchar(4000) DEFAULT NULL COMMENT '����Ŀ��',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`CF_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312;

#
# Dumping data for table client_follow
#

/*!40000 ALTER TABLE `client_follow` DISABLE KEYS */;
INSERT INTO `client_follow` VALUES (1,1,23,'2010-11-02','123','123123');
INSERT INTO `client_follow` VALUES (2,1,23,'2010-11-18','123123','123123123');
/*!40000 ALTER TABLE `client_follow` ENABLE KEYS */;

#
# Source for table clientproperty
#

DROP TABLE IF EXISTS `clientproperty`;
CREATE TABLE `clientproperty` (
  `ClientProperty_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '�ͻ����Ա��',
  `ClientProperty_name` varchar(4000) DEFAULT NULL COMMENT '�ͻ���������',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`ClientProperty_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312 COMMENT='�ͻ�����';

#
# Dumping data for table clientproperty
#

/*!40000 ALTER TABLE `clientproperty` DISABLE KEYS */;
INSERT INTO `clientproperty` VALUES (1,'�ܲ�',NULL);
INSERT INTO `clientproperty` VALUES (2,'��֧����',NULL);
/*!40000 ALTER TABLE `clientproperty` ENABLE KEYS */;

#
# Source for table contract
#

DROP TABLE IF EXISTS `contract`;
CREATE TABLE `contract` (
  `Contract_id` int(11) NOT NULL COMMENT '��ͬ���',
  `Client_id` int(11) DEFAULT NULL COMMENT '�ͻ����',
  `Contract_number` varchar(4000) DEFAULT NULL COMMENT '��ͬ��',
  `Contract_validS` datetime DEFAULT NULL COMMENT '��ͬ��ʼʱ��',
  `Contract_validE` datetime DEFAULT NULL COMMENT '��ͬ����ʱ��',
  `Contract_reputation` varchar(4000) DEFAULT NULL COMMENT '���ã�����ȼ�',
  `Contract_payment` varchar(4000) DEFAULT NULL COMMENT 'ƽ���������ڣ��죩',
  `Contract_rate` varchar(4000) DEFAULT NULL COMMENT '�����Ƕ���',
  `Contract_calculate` varchar(4000) DEFAULT NULL COMMENT '���㹫ʽ',
  `Contract_guaranteeT` varchar(4000) DEFAULT NULL COMMENT '�����ڶ೤',
  `Contract_guaranteeD` varchar(4000) DEFAULT NULL COMMENT '��������',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Contract_id`),
  KEY `FK_Contract_Client_id` (`Client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='��ͬ';

#
# Dumping data for table contract
#

/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
INSERT INTO `contract` VALUES (1,18,'123123','1999-01-01','2010-01-01',NULL,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO `contract` VALUES (2,18,'123123','2010-01-01','2020-01-01',NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;

#
# Source for table degree
#

DROP TABLE IF EXISTS `degree`;
CREATE TABLE `degree` (
  `Degree_ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ѧ�����',
  `Degree_Name` varchar(200) DEFAULT NULL,
  `Degree_Order` int(11) DEFAULT NULL,
  PRIMARY KEY (`Degree_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gb2312 COMMENT='ѧ��';

#
# Dumping data for table degree
#

/*!40000 ALTER TABLE `degree` DISABLE KEYS */;
INSERT INTO `degree` VALUES (1,'��ʿ',0);
INSERT INTO `degree` VALUES (2,'�о���',1);
INSERT INTO `degree` VALUES (3,'����',2);
INSERT INTO `degree` VALUES (4,'ר��',3);
INSERT INTO `degree` VALUES (5,'��ר',4);
INSERT INTO `degree` VALUES (6,'����',5);
INSERT INTO `degree` VALUES (7,'����',6);
INSERT INTO `degree` VALUES (8,'Сѧ',7);
/*!40000 ALTER TABLE `degree` ENABLE KEYS */;

#
# Source for table dimensions
#

DROP TABLE IF EXISTS `dimensions`;
CREATE TABLE `dimensions` (
  `Dimensions_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��� ��˾��ģ���',
  `Dimensions_name` varchar(200) DEFAULT NULL COMMENT '��˾��ģ����',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Dimensions_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312 COMMENT='��˾��ģ';

#
# Dumping data for table dimensions
#

/*!40000 ALTER TABLE `dimensions` DISABLE KEYS */;
INSERT INTO `dimensions` VALUES (1,'С��',NULL);
INSERT INTO `dimensions` VALUES (2,'����',NULL);
INSERT INTO `dimensions` VALUES (3,'����',NULL);
/*!40000 ALTER TABLE `dimensions` ENABLE KEYS */;

#
# Source for table education
#

DROP TABLE IF EXISTS `education`;
CREATE TABLE `education` (
  `Education_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '������� �������',
  `Resume_id` int(11) DEFAULT NULL COMMENT '������� �������',
  `degree_id` int(11) DEFAULT NULL COMMENT '�����ƾ',
  `Education_DateS` datetime DEFAULT NULL COMMENT '����ʱ���� ����ʱ��',
  `Education_DateE` datetime DEFAULT NULL COMMENT '����ʱ��ֹ',
  `Education_school` varchar(200) DEFAULT NULL COMMENT 'ѧУ���� ѧУ����\r\n',
  `Education_major` varchar(200) DEFAULT NULL COMMENT 'רҵ���� רҵ����',
  `comment` varchar(200) DEFAULT NULL COMMENT '��ע ��ע',
  `Education_References` varchar(50) DEFAULT NULL COMMENT '֤����',
  `Education_References_Contect` varchar(255) DEFAULT NULL COMMENT '֤������ϵ��ʽ',
  PRIMARY KEY (`Education_id`),
  KEY `FK_Education_Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=gb2312 COMMENT='��������';

#
# Dumping data for table education
#

/*!40000 ALTER TABLE `education` DISABLE KEYS */;
INSERT INTO `education` VALUES (16,6,2,'2010-11-07','2010-11-07','123','12','','123','123123');
/*!40000 ALTER TABLE `education` ENABLE KEYS */;

#
# Source for table employeesnumber
#

DROP TABLE IF EXISTS `employeesnumber`;
CREATE TABLE `employeesnumber` (
  `EmployeesNumber_id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Ա���������',
  `EmployeesNumber_name` varchar(200) DEFAULT NULL COMMENT 'Ա����������',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`EmployeesNumber_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312 COMMENT='Ա������';

#
# Dumping data for table employeesnumber
#

/*!40000 ALTER TABLE `employeesnumber` DISABLE KEYS */;
INSERT INTO `employeesnumber` VALUES (1,'50������',NULL);
INSERT INTO `employeesnumber` VALUES (2,'50-500��',NULL);
INSERT INTO `employeesnumber` VALUES (3,'500������',NULL);
/*!40000 ALTER TABLE `employeesnumber` ENABLE KEYS */;

#
# Source for table evaluate
#

DROP TABLE IF EXISTS `evaluate`;
CREATE TABLE `evaluate` (
  `Evaluate_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '���۱�� ���۱��',
  `Evaluate_value` varchar(200) DEFAULT NULL COMMENT '�������� ��������',
  `Resume_id` int(11) NOT NULL DEFAULT '0' COMMENT '������� �������',
  `comment` varchar(200) DEFAULT NULL COMMENT '��ע ��ע',
  `User_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Evaluate_id`),
  KEY `Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312 COMMENT='����';

#
# Dumping data for table evaluate
#

/*!40000 ALTER TABLE `evaluate` DISABLE KEYS */;
INSERT INTO `evaluate` VALUES (1,'123',6,'12312',1);
/*!40000 ALTER TABLE `evaluate` ENABLE KEYS */;

#
# Source for table invoice
#

DROP TABLE IF EXISTS `invoice`;
CREATE TABLE `invoice` (
  `Invoice_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��Ʊ���',
  `Invoice_number` varchar(20) DEFAULT NULL COMMENT '��Ʊ��',
  `Invoice_State` int(11) NOT NULL DEFAULT '0' COMMENT '��Ʊ״̬',
  `Recommended_id` int(11) NOT NULL DEFAULT '0' COMMENT '�Ƽ���¼',
  `Invoice_cost` decimal(10,2) DEFAULT NULL COMMENT '�ܷ���ѽ�Ԫ��',
  `Invoice_guarantee` int(11) DEFAULT NULL COMMENT '������',
  `Invoice_paymentType` varchar(255) DEFAULT NULL COMMENT '�������',
  `Invoice_startT` datetime DEFAULT NULL COMMENT '���ο�Ʊ����',
  `Invoice_money` decimal(10,2) DEFAULT NULL COMMENT '��Ʊ��Ԫ��',
  `Invoice_paymentT` int(11) DEFAULT NULL COMMENT 'Լ��������',
  `Invoice_endT` datetime DEFAULT NULL COMMENT '�����ֹ����',
  `Invoice_BmoneyType` tinyint(3) NOT NULL DEFAULT '0' COMMENT '�Ƿ��Ѿ��ؿ�',
  `Invoice_BmoneyT` datetime DEFAULT '0000-00-00 00:00:00' COMMENT '�ؿ�����',
  `Invoice_Bmoney` decimal(10,2) DEFAULT '0.00' COMMENT '�ؿ���',
  `Invoice_delayD` int(11) DEFAULT NULL COMMENT '�ӳ���������ǰ+�Ƴ�-��',
  `User_id` int(11) DEFAULT NULL COMMENT '�ؿ�ȷ�ϲ�������',
  `Comment` varchar(255) DEFAULT NULL COMMENT '��ע',
  `Invoice_WorkDate` date DEFAULT '0000-00-00',
  PRIMARY KEY (`Invoice_id`),
  KEY `Invoice_State` (`Invoice_State`),
  KEY `Recommended_id` (`Recommended_id`),
  KEY `User_id` (`User_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='��Ʊ';

#
# Dumping data for table invoice
#

/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;

#
# Source for table invoicestate
#

DROP TABLE IF EXISTS `invoicestate`;
CREATE TABLE `invoicestate` (
  `InvoiceState_Id` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceState_Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`InvoiceState_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312;

#
# Dumping data for table invoicestate
#

/*!40000 ALTER TABLE `invoicestate` DISABLE KEYS */;
INSERT INTO `invoicestate` VALUES (1,'δ��Ʊ');
/*!40000 ALTER TABLE `invoicestate` ENABLE KEYS */;

#
# Source for table jobs
#

DROP TABLE IF EXISTS `jobs`;
CREATE TABLE `jobs` (
  `Jobs_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Jobs_Name` varchar(50) NOT NULL DEFAULT '',
  `Jobs_Comment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Jobs_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=gb2312;

#
# Dumping data for table jobs
#

/*!40000 ALTER TABLE `jobs` DISABLE KEYS */;
INSERT INTO `jobs` VALUES (1,'����������硤������',NULL);
INSERT INTO `jobs` VALUES (2,'���ӡ�������ͨ�ż�����',NULL);
INSERT INTO `jobs` VALUES (3,'������',NULL);
INSERT INTO `jobs` VALUES (4,'�г������ء�ý����',NULL);
INSERT INTO `jobs` VALUES (5,'������ơ�ͳ����',NULL);
INSERT INTO `jobs` VALUES (6,'������Դ��',NULL);
INSERT INTO `jobs` VALUES (7,'��Ӫ������',NULL);
INSERT INTO `jobs` VALUES (8,'��������ơ�������',NULL);
INSERT INTO `jobs` VALUES (9,'������(���С�����֤ȯ���ڻ���Ͷ�ʡ��䵱)',NULL);
INSERT INTO `jobs` VALUES (10,'ó�ס��������ɹ���������',NULL);
INSERT INTO `jobs` VALUES (11,'���������ز���װ��װ�ޡ���ҵ������',NULL);
INSERT INTO `jobs` VALUES (12,'�Ƶꡤ���������Ρ�������',NULL);
INSERT INTO `jobs` VALUES (13,'���塤Ӱ�ӡ�д����ý����',NULL);
INSERT INTO `jobs` VALUES (14,'��е�������Ǳ���',NULL);
INSERT INTO `jobs` VALUES (15,'����������',NULL);
INSERT INTO `jobs` VALUES (16,'ҽ�����������ݱ�����',NULL);
INSERT INTO `jobs` VALUES (17,'��������Դ��������',NULL);
INSERT INTO `jobs` VALUES (18,'������������',NULL);
INSERT INTO `jobs` VALUES (19,'������',NULL);
INSERT INTO `jobs` VALUES (20,'�ͻ�������',NULL);
INSERT INTO `jobs` VALUES (21,'��ѯ��������',NULL);
INSERT INTO `jobs` VALUES (22,'��Ŀ������',NULL);
INSERT INTO `jobs` VALUES (23,'��������ѵ��',NULL);
INSERT INTO `jobs` VALUES (24,'����������',NULL);
INSERT INTO `jobs` VALUES (25,'������',NULL);
INSERT INTO `jobs` VALUES (26,'������',NULL);
INSERT INTO `jobs` VALUES (27,'��ҵ������',NULL);
INSERT INTO `jobs` VALUES (28,'������',NULL);
INSERT INTO `jobs` VALUES (29,'�����ҩ��������������',NULL);
INSERT INTO `jobs` VALUES (30,'��Уѧ����',NULL);
INSERT INTO `jobs` VALUES (31,'������',NULL);
INSERT INTO `jobs` VALUES (32,'����Ա��',NULL);
INSERT INTO `jobs` VALUES (33,'��ѵ����',NULL);
INSERT INTO `jobs` VALUES (34,'������',NULL);
/*!40000 ALTER TABLE `jobs` ENABLE KEYS */;

#
# Source for table jobsdetail
#

DROP TABLE IF EXISTS `jobsdetail`;
CREATE TABLE `jobsdetail` (
  `JobsDetail_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��ҵ��ϸid',
  `JobsDetail_name` varchar(200) DEFAULT NULL COMMENT '��ҵ��ϸ����',
  `Jobs_id` int(11) DEFAULT NULL COMMENT '��ҵid',
  `Comment` varchar(200) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`JobsDetail_id`),
  KEY `FK_JobsDetail_Jobs_id` (`Jobs_id`)
) ENGINE=InnoDB AUTO_INCREMENT=467 DEFAULT CHARSET=gb2312 COMMENT='��ҵ��ϸ��';

#
# Dumping data for table jobsdetail
#

/*!40000 ALTER TABLE `jobsdetail` DISABLE KEYS */;
INSERT INTO `jobsdetail` VALUES (1,'��ϯ������CTO����ϯ��Ϣ��CIO',1,NULL);
INSERT INTO `jobsdetail` VALUES (2,'�����ܼࡤ��������',1,NULL);
INSERT INTO `jobsdetail` VALUES (3,'��Ϣ����������Ϣ��������',1,NULL);
INSERT INTO `jobsdetail` VALUES (4,'��Ϣ����רԱ',1,NULL);
INSERT INTO `jobsdetail` VALUES (5,'��Ʒ����',1,NULL);
INSERT INTO `jobsdetail` VALUES (6,'��Ŀ������������',1,NULL);
INSERT INTO `jobsdetail` VALUES (7,'��Ŀִ�С�Э����Ա',1,NULL);
INSERT INTO `jobsdetail` VALUES (8,'�ܹ�ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (9,'ϵͳ����Ա',1,NULL);
INSERT INTO `jobsdetail` VALUES (10,'�з�����ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (11,'�߼��������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (12,'�������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (13,'�����������������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (14,'�߼�Ӳ������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (15,'ϵͳ���ɹ���ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (16,'Ӳ������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (17,'ͨ�ż�������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (18,'��������Ŀʵʩ',1,NULL);
INSERT INTO `jobsdetail` VALUES (19,'ERP����Ӧ�ù��ʡ�ERPʵʩ����ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (20,'���ݿ����Ա�����ݿ⿪������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (21,'����֧�֡�ά������',1,NULL);
INSERT INTO `jobsdetail` VALUES (22,'����֧�֡�ά������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (23,'Ʒ�ʾ�����������ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (24,'��������Ϣ��ȫ����ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (25,'�������',1,NULL);
INSERT INTO `jobsdetail` VALUES (26,'Ӳ������',1,NULL);
INSERT INTO `jobsdetail` VALUES (27,'�ĵ�����ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (28,'ϵͳ����Ա������',1,NULL);
INSERT INTO `jobsdetail` VALUES (29,'��������Ƶ����ý�忪��',1,NULL);
INSERT INTO `jobsdetail` VALUES (30,'��Ϸ����뿪��',1,NULL);
INSERT INTO `jobsdetail` VALUES (31,'��վӪ�˹���',1,NULL);
INSERT INTO `jobsdetail` VALUES (32,'��վ�༭',1,NULL);
INSERT INTO `jobsdetail` VALUES (33,'��վ�߻�',1,NULL);
INSERT INTO `jobsdetail` VALUES (34,'���繤��ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (35,'UI��ơ���ҳ���������',1,NULL);
INSERT INTO `jobsdetail` VALUES (36,'�����������ƹ���ʦ',1,NULL);
INSERT INTO `jobsdetail` VALUES (37,'����ְλ(����������硤������)',1,NULL);
INSERT INTO `jobsdetail` VALUES (38,'���ӹ���ʦ����·����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (39,'��������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (40,'���Ź���ʦ��ͨѶ����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (41,'�ƶ�ͨ�Ź���ʦ������ͨ�Ź���ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (42,'���ߴ��乤��ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (43,'��ֵ��Ʒ�з�',2,NULL);
INSERT INTO `jobsdetail` VALUES (44,'ͨ�ŵ�Դ����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (45,'����ͨ�Ź���ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (46,'���չ���ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (47,'��������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (48,'�����Ʒ��������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (49,'Ƕ��ʽϵͳ�������',2,NULL);
INSERT INTO `jobsdetail` VALUES (50,'���ߵ繤��ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (51,'�뵼�幤��ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (52,'����Ԫ��������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (53,'���ӡ�����ά��',2,NULL);
INSERT INTO `jobsdetail` VALUES (54,'��Դ����������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (55,'���⡤����Ӽ���',2,NULL);
INSERT INTO `jobsdetail` VALUES (56,'���ɵ�·(IC)оƬ����',2,NULL);
INSERT INTO `jobsdetail` VALUES (57,'��ͼ��ƹ���ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (58,'�����ĵ�����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (59,'���Թ���ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (60,'��е����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (61,'��������ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (62,'��ء���Դ����',2,NULL);
INSERT INTO `jobsdetail` VALUES (63,'�з�����ʦ',2,NULL);
INSERT INTO `jobsdetail` VALUES (64,'��������Ŀʵʩ',2,NULL);
INSERT INTO `jobsdetail` VALUES (65,'�ֳ�Ӧ�ù���ʦ+FAE',2,NULL);
INSERT INTO `jobsdetail` VALUES (66,'����ְλ(���ӡ�������ͨ�ż�����)',2,NULL);
INSERT INTO `jobsdetail` VALUES (67,'�����ܼ�',3,NULL);
INSERT INTO `jobsdetail` VALUES (68,'���۾�����������',3,NULL);
INSERT INTO `jobsdetail` VALUES (69,'���۴����ͻ�����',3,NULL);
INSERT INTO `jobsdetail` VALUES (70,'�����ܼࡤ�����ܼ�',3,NULL);
INSERT INTO `jobsdetail` VALUES (71,'������������������������',3,NULL);
INSERT INTO `jobsdetail` VALUES (72,'��������',3,NULL);
INSERT INTO `jobsdetail` VALUES (73,'�������۾���',3,NULL);
INSERT INTO `jobsdetail` VALUES (74,'��ǰ֧�־�����ǰ֧������',3,NULL);
INSERT INTO `jobsdetail` VALUES (75,'��ǰ֧�ֹ���ʦ',3,NULL);
INSERT INTO `jobsdetail` VALUES (76,'��������',3,NULL);
INSERT INTO `jobsdetail` VALUES (77,'��������������',3,NULL);
INSERT INTO `jobsdetail` VALUES (78,'����רԱ����������',3,NULL);
INSERT INTO `jobsdetail` VALUES (79,'ҵ����չ(BD)����',3,NULL);
INSERT INTO `jobsdetail` VALUES (80,'�绰����',3,NULL);
INSERT INTO `jobsdetail` VALUES (81,'ҽҩ����',3,NULL);
INSERT INTO `jobsdetail` VALUES (82,'ҽ����е����',3,NULL);
INSERT INTO `jobsdetail` VALUES (83,'���մ����ˡ������ˡ��ͻ�����',3,NULL);
INSERT INTO `jobsdetail` VALUES (84,'����ְλ(������)',3,NULL);
INSERT INTO `jobsdetail` VALUES (85,'�г��ܼ�',4,NULL);
INSERT INTO `jobsdetail` VALUES (86,'�г������г�����',4,NULL);
INSERT INTO `jobsdetail` VALUES (87,'�г�רԱ���г�����',4,NULL);
INSERT INTO `jobsdetail` VALUES (88,'����ý�龭������ý������',4,NULL);
INSERT INTO `jobsdetail` VALUES (89,'����ý��רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (90,'�г����������',4,NULL);
INSERT INTO `jobsdetail` VALUES (91,'��������������',4,NULL);
INSERT INTO `jobsdetail` VALUES (92,'����רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (93,'��Ʒ����Ʒ�ƾ�������',4,NULL);
INSERT INTO `jobsdetail` VALUES (94,'��ƷרԱ��Ʒ��רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (95,'����������������',4,NULL);
INSERT INTO `jobsdetail` VALUES (96,'����Ա',4,NULL);
INSERT INTO `jobsdetail` VALUES (97,'�г��滮�����г��滮����',4,NULL);
INSERT INTO `jobsdetail` VALUES (98,'�г��滮רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (99,'��洴�⡤�߻�����Ƽ��İ�',4,NULL);
INSERT INTO `jobsdetail` VALUES (100,'���ͻ�����',4,NULL);
INSERT INTO `jobsdetail` VALUES (101,'���ͻ����ܡ����ͻ�רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (102,'�г�Ӫ�������г�Ӫ������',4,NULL);
INSERT INTO `jobsdetail` VALUES (103,'�г�Ӫ��רԱ',4,NULL);
INSERT INTO `jobsdetail` VALUES (104,'����(�г������ء�ý����)',4,NULL);
INSERT INTO `jobsdetail` VALUES (105,'��ϯ�����CFO',5,NULL);
INSERT INTO `jobsdetail` VALUES (106,'�����ܼ�',5,NULL);
INSERT INTO `jobsdetail` VALUES (107,'������',5,NULL);
INSERT INTO `jobsdetail` VALUES (108,'�������ܡ���������',5,NULL);
INSERT INTO `jobsdetail` VALUES (109,'��ƾ����������',5,NULL);
INSERT INTO `jobsdetail` VALUES (110,'���',5,NULL);
INSERT INTO `jobsdetail` VALUES (111,'����',5,NULL);
INSERT INTO `jobsdetail` VALUES (112,'����������������������',5,NULL);
INSERT INTO `jobsdetail` VALUES (113,'�������Ա',5,NULL);
INSERT INTO `jobsdetail` VALUES (114,'�ɱ������ɱ�����',5,NULL);
INSERT INTO `jobsdetail` VALUES (115,'�ɱ�����Ա',5,NULL);
INSERT INTO `jobsdetail` VALUES (116,'��ƾ����������',5,NULL);
INSERT INTO `jobsdetail` VALUES (117,'���רԱ���������',5,NULL);
INSERT INTO `jobsdetail` VALUES (118,'���������������',5,NULL);
INSERT INTO `jobsdetail` VALUES (119,'ͳ��',5,NULL);
INSERT INTO `jobsdetail` VALUES (120,'˰����˰������',5,NULL);
INSERT INTO `jobsdetail` VALUES (121,'˰��רԱ��˰������',5,NULL);
INSERT INTO `jobsdetail` VALUES (122,'Ͷ���ʾ���Ͷ��������',5,NULL);
INSERT INTO `jobsdetail` VALUES (123,'����ְλ(������ơ�ͳ����)',5,NULL);
INSERT INTO `jobsdetail` VALUES (124,'������Դ�ܼ�',6,NULL);
INSERT INTO `jobsdetail` VALUES (125,'������Դ����������Դ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (126,'������ԴרԱ��������Դ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (127,'�������ܡ�����רԱ',6,NULL);
INSERT INTO `jobsdetail` VALUES (128,'��Ƹ������Ƹ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (129,'��ƸרԱ����Ƹ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (130,'��ѵ������ѵ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (131,'��ѵרԱ����ѵ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (132,'��ѵʦ',6,NULL);
INSERT INTO `jobsdetail` VALUES (133,'н�ʸ�����������',6,NULL);
INSERT INTO `jobsdetail` VALUES (134,'н�ʸ���רԱ��н�ʸ�������',6,NULL);
INSERT INTO `jobsdetail` VALUES (135,'��Ч���˾�����Ч��������',6,NULL);
INSERT INTO `jobsdetail` VALUES (136,'��Ч����רԱ����Ч��������',6,NULL);
INSERT INTO `jobsdetail` VALUES (137,'Ա����ϵ����Ա����ϵ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (138,'Ա����ϵרԱ��Ա����ϵ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (139,'��ͷ����',6,NULL);
INSERT INTO `jobsdetail` VALUES (140,'����ְλ(������Դ��)',6,NULL);
INSERT INTO `jobsdetail` VALUES (141,'��ϯִ�й�CEO���ܲá��ܾ���',7,NULL);
INSERT INTO `jobsdetail` VALUES (142,'��ϯ��Ӫ��COO',7,NULL);
INSERT INTO `jobsdetail` VALUES (143,'��ϯ������CTO����ϯ��Ϣ��CIO',7,NULL);
INSERT INTO `jobsdetail` VALUES (144,'��ϯ�����CFO',7,NULL);
INSERT INTO `jobsdetail` VALUES (145,'���ܲá����ܾ���',7,NULL);
INSERT INTO `jobsdetail` VALUES (146,'�ϻ���',7,NULL);
INSERT INTO `jobsdetail` VALUES (147,'�ܼࡤ��ҵ���ܾ���',7,NULL);
INSERT INTO `jobsdetail` VALUES (148,'�ܲ������ܾ�������',7,NULL);
INSERT INTO `jobsdetail` VALUES (149,'�ֹ�˾������֧�����������´�����',7,NULL);
INSERT INTO `jobsdetail` VALUES (150,'���ž���',7,NULL);
INSERT INTO `jobsdetail` VALUES (151,'������������',7,NULL);
INSERT INTO `jobsdetail` VALUES (152,'�곤',7,NULL);
INSERT INTO `jobsdetail` VALUES (153,'����ְλ(��Ӫ������)',7,NULL);
INSERT INTO `jobsdetail` VALUES (154,'��ƹ�����Ա',8,NULL);
INSERT INTO `jobsdetail` VALUES (155,'������ͼ�����',8,NULL);
INSERT INTO `jobsdetail` VALUES (156,'��ҵ����Ʒ���',8,NULL);
INSERT INTO `jobsdetail` VALUES (157,'��װ����֯Ʒ���ʦ',8,NULL);
INSERT INTO `jobsdetail` VALUES (158,'��װ��������װ�ư�',8,NULL);
INSERT INTO `jobsdetail` VALUES (159,'����Ʒ���鱦���',8,NULL);
INSERT INTO `jobsdetail` VALUES (160,'�Ҿ����',8,NULL);
INSERT INTO `jobsdetail` VALUES (161,'ƽ�����',8,NULL);
INSERT INTO `jobsdetail` VALUES (162,'ý�������',8,NULL);
INSERT INTO `jobsdetail` VALUES (163,'�������',8,NULL);
INSERT INTO `jobsdetail` VALUES (164,'��ý�����',8,NULL);
INSERT INTO `jobsdetail` VALUES (165,'�������',8,NULL);
INSERT INTO `jobsdetail` VALUES (166,'չʾ��װ�����',8,NULL);
INSERT INTO `jobsdetail` VALUES (167,'���⡤�߻����İ�',8,NULL);
INSERT INTO `jobsdetail` VALUES (168,'����ְλ(��������ơ�������)',8,NULL);
INSERT INTO `jobsdetail` VALUES (169,'֤ȯ����㡤�ڻ�������',9,NULL);
INSERT INTO `jobsdetail` VALUES (170,'֤ȯ����ʦ',9,NULL);
INSERT INTO `jobsdetail` VALUES (171,'��Ʊ���ڻ�������',9,NULL);
INSERT INTO `jobsdetail` VALUES (172,'�г������г����߼�����',9,NULL);
INSERT INTO `jobsdetail` VALUES (173,'Ͷ�ʹ����о����������׹���',9,NULL);
INSERT INTO `jobsdetail` VALUES (174,'Ͷ������ҵ��',9,NULL);
INSERT INTO `jobsdetail` VALUES (175,'������Ŀ����',9,NULL);
INSERT INTO `jobsdetail` VALUES (176,'�ͻ��������ڲ�ƷӪ������',9,NULL);
INSERT INTO `jobsdetail` VALUES (177,'�ʲ������ʲ����������׹���',9,NULL);
INSERT INTO `jobsdetail` VALUES (178,'���չ������ˡ�����',9,NULL);
INSERT INTO `jobsdetail` VALUES (179,'�Ŵ��������ù���',9,NULL);
INSERT INTO `jobsdetail` VALUES (180,'�ʽ��������������㡤����',9,NULL);
INSERT INTO `jobsdetail` VALUES (181,'��Ա�������ѯ���ͻ��������л��',9,NULL);
INSERT INTO `jobsdetail` VALUES (182,'���п����������С���ҵ����չ',9,NULL);
INSERT INTO `jobsdetail` VALUES (183,'���ʽ��㡤��㽻��',9,NULL);
INSERT INTO `jobsdetail` VALUES (184,'����ʦ',9,NULL);
INSERT INTO `jobsdetail` VALUES (185,'����������ʦ',9,NULL);
INSERT INTO `jobsdetail` VALUES (186,'����ְλ(������(���С�����֤ȯ���ڻ���Ͷ�ʡ��䵱))',9,NULL);
INSERT INTO `jobsdetail` VALUES (187,'��ó�������ܡ�רԱ������',10,NULL);
INSERT INTO `jobsdetail` VALUES (188,'����ó�׾������ܡ�רԱ������',10,NULL);
INSERT INTO `jobsdetail` VALUES (189,'ҵ�����',10,NULL);
INSERT INTO `jobsdetail` VALUES (190,'��֤Ա������Ա',10,NULL);
INSERT INTO `jobsdetail` VALUES (191,'½�ˡ����ˡ�������Ա',10,NULL);
INSERT INTO `jobsdetail` VALUES (192,'���������ܡ�רԱ������',10,NULL);
INSERT INTO `jobsdetail` VALUES (193,'�ɹ���������',10,NULL);
INSERT INTO `jobsdetail` VALUES (194,'�ɹ�Ա������',10,NULL);
INSERT INTO `jobsdetail` VALUES (195,'����������������',10,NULL);
INSERT INTO `jobsdetail` VALUES (196,'����רԱ����������',10,NULL);
INSERT INTO `jobsdetail` VALUES (197,'���Ϲ���',10,NULL);
INSERT INTO `jobsdetail` VALUES (198,'�ֿ����',10,NULL);
INSERT INTO `jobsdetail` VALUES (199,'���侭������',10,NULL);
INSERT INTO `jobsdetail` VALUES (200,'���˴���',10,NULL);
INSERT INTO `jobsdetail` VALUES (201,'��½�ս�ͨ����',10,NULL);
INSERT INTO `jobsdetail` VALUES (202,'˾��',10,NULL);
INSERT INTO `jobsdetail` VALUES (203,'����Ա',10,NULL);
INSERT INTO `jobsdetail` VALUES (204,'���Ա���ٵ�Ա',10,NULL);
INSERT INTO `jobsdetail` VALUES (205,'��Ӧ������',10,NULL);
INSERT INTO `jobsdetail` VALUES (206,'����',10,NULL);
INSERT INTO `jobsdetail` VALUES (207,'�����������',10,NULL);
INSERT INTO `jobsdetail` VALUES (208,'��װ��ҵ��',10,NULL);
INSERT INTO `jobsdetail` VALUES (209,'����ְλ(ó�ס��������ɹ���������)',10,NULL);
INSERT INTO `jobsdetail` VALUES (210,'�߼���������ʦ���ܹ�',11,NULL);
INSERT INTO `jobsdetail` VALUES (211,'����ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (212,'�ṹ����ʦ����ľ��������ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (213,'������ơ�������ͼ',11,NULL);
INSERT INTO `jobsdetail` VALUES (214,'��������ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (215,'Ļǽ����ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (216,'�������̹���',11,NULL);
INSERT INTO `jobsdetail` VALUES (217,'���̼���',11,NULL);
INSERT INTO `jobsdetail` VALUES (218,'������������',11,NULL);
INSERT INTO `jobsdetail` VALUES (219,'��桤����',11,NULL);
INSERT INTO `jobsdetail` VALUES (220,'����ˮ��ǿ�硤���硤����ůͨ',11,NULL);
INSERT INTO `jobsdetail` VALUES (221,'���ز��������߻�',11,NULL);
INSERT INTO `jobsdetail` VALUES (222,'���ز���Ŀ��Ͷ��רԱ',11,NULL);
INSERT INTO `jobsdetail` VALUES (223,'���ز�����',11,NULL);
INSERT INTO `jobsdetail` VALUES (224,'���ز�����',11,NULL);
INSERT INTO `jobsdetail` VALUES (225,'�豸����ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (226,'��ۡ���Ԥ��',11,NULL);
INSERT INTO `jobsdetail` VALUES (227,'·�š�������ۿڡ���������',11,NULL);
INSERT INTO `jobsdetail` VALUES (228,'԰����ơ�԰����ơ��������',11,NULL);
INSERT INTO `jobsdetail` VALUES (229,'������װ�����',11,NULL);
INSERT INTO `jobsdetail` VALUES (230,'��ҵ����',11,NULL);
INSERT INTO `jobsdetail` VALUES (231,'��ҵ����',11,NULL);
INSERT INTO `jobsdetail` VALUES (232,'��ҵ���̡����ޡ�����',11,NULL);
INSERT INTO `jobsdetail` VALUES (233,'��ҵ��ʩ����',11,NULL);
INSERT INTO `jobsdetail` VALUES (234,'��ҵά��',11,NULL);
INSERT INTO `jobsdetail` VALUES (235,'���й滮�����',11,NULL);
INSERT INTO `jobsdetail` VALUES (236,'���ز��н顤����',11,NULL);
INSERT INTO `jobsdetail` VALUES (237,'��·������ơ���·����Ԥ��ʦ',11,NULL);
INSERT INTO `jobsdetail` VALUES (238,'ʩ��Ա',11,NULL);
INSERT INTO `jobsdetail` VALUES (239,'����ְλ(���������ز���װ��װ�ޡ���ҵ������)',11,NULL);
INSERT INTO `jobsdetail` VALUES (240,'���ݻ�Ƶ����',12,NULL);
INSERT INTO `jobsdetail` VALUES (241,'���ֻ��������',12,NULL);
INSERT INTO `jobsdetail` VALUES (242,'���þ�������',12,NULL);
INSERT INTO `jobsdetail` VALUES (243,'¥�澭��',12,NULL);
INSERT INTO `jobsdetail` VALUES (244,'��ʦ������ʦ',12,NULL);
INSERT INTO `jobsdetail` VALUES (245,'Ӫ��ʦ',12,NULL);
INSERT INTO `jobsdetail` VALUES (246,'����Ա',12,NULL);
INSERT INTO `jobsdetail` VALUES (247,'���ǡ����񡤽�����',12,NULL);
INSERT INTO `jobsdetail` VALUES (248,'ӪҵԱ������Ա�����Ա',12,NULL);
INSERT INTO `jobsdetail` VALUES (249,'���Ρ��Ƶ�',12,NULL);
INSERT INTO `jobsdetail` VALUES (250,'Ʊ��',12,NULL);
INSERT INTO `jobsdetail` VALUES (251,'�������',12,NULL);
INSERT INTO `jobsdetail` VALUES (252,'��������',12,NULL);
INSERT INTO `jobsdetail` VALUES (253,'˾��',12,NULL);
INSERT INTO `jobsdetail` VALUES (254,'����',12,NULL);
INSERT INTO `jobsdetail` VALUES (255,'Ѱ��Ա������Ա',12,NULL);
INSERT INTO `jobsdetail` VALUES (256,'�������������',12,NULL);
INSERT INTO `jobsdetail` VALUES (257,'����',12,NULL);
INSERT INTO `jobsdetail` VALUES (258,'����ְλ(�Ƶꡤ���������Ρ�������)',12,NULL);
INSERT INTO `jobsdetail` VALUES (259,'���ҡ�׫����',13,NULL);
INSERT INTO `jobsdetail` VALUES (260,'�ܱࡤ���ܱ�',13,NULL);
INSERT INTO `jobsdetail` VALUES (261,'�༭������',13,NULL);
INSERT INTO `jobsdetail` VALUES (262,'�����༭',13,NULL);
INSERT INTO `jobsdetail` VALUES (263,'�����ܼࡤ��������',13,NULL);
INSERT INTO `jobsdetail` VALUES (264,'����',13,NULL);
INSERT INTO `jobsdetail` VALUES (265,'У�ԡ�¼��',13,NULL);
INSERT INTO `jobsdetail` VALUES (266,'�Ű����',13,NULL);
INSERT INTO `jobsdetail` VALUES (267,'�����ܼࡤ����ܼ�',13,NULL);
INSERT INTO `jobsdetail` VALUES (268,'Ӱ�Ӳ߻���Ӱ������',13,NULL);
INSERT INTO `jobsdetail` VALUES (269,'���ݡ��ർ',13,NULL);
INSERT INTO `jobsdetail` VALUES (270,'��Ӱ������',13,NULL);
INSERT INTO `jobsdetail` VALUES (271,'¼������Чʦ',13,NULL);
INSERT INTO `jobsdetail` VALUES (272,'��ױʦ������ʦ',13,NULL);
INSERT INTO `jobsdetail` VALUES (273,'��Ա��������ģ��',13,NULL);
INSERT INTO `jobsdetail` VALUES (274,'�����ˡ�����Ա��DJ',13,NULL);
INSERT INTO `jobsdetail` VALUES (275,'���ջ�����������',13,NULL);
INSERT INTO `jobsdetail` VALUES (276,'����ְλ(���塤Ӱ�ӡ�д����ý����)',13,NULL);
INSERT INTO `jobsdetail` VALUES (277,'��е����ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (278,'ģ�߹���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (279,'��е���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (280,'��е��ͼԱ',14,NULL);
INSERT INTO `jobsdetail` VALUES (281,'���繤��ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (282,'���ܻ�е�������Ǳ���ʦ������Ա',14,NULL);
INSERT INTO `jobsdetail` VALUES (283,'���졤���칤��ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (284,'ע�ܹ���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (285,'CNC����ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (286,'��ѹ����ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (287,'�о߹���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (288,'��¯����ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (289,'���ӹ���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (290,'������Ħ�г�����ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (291,'��������ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (292,'���������������',14,NULL);
INSERT INTO `jobsdetail` VALUES (293,'��еά�޹���ʦ',14,NULL);
INSERT INTO `jobsdetail` VALUES (294,'��װ��ӡˢ��е',14,NULL);
INSERT INTO `jobsdetail` VALUES (295,'ʳƷ��е',14,NULL);
INSERT INTO `jobsdetail` VALUES (296,'��֯��е',14,NULL);
INSERT INTO `jobsdetail` VALUES (297,'�豸����',14,NULL);
INSERT INTO `jobsdetail` VALUES (298,'����ְλ(��е�������Ǳ���)',14,NULL);
INSERT INTO `jobsdetail` VALUES (299,'������������',15,NULL);
INSERT INTO `jobsdetail` VALUES (300,'�ܹ���ʦ�����ܹ���ʦ',15,NULL);
INSERT INTO `jobsdetail` VALUES (301,'��������ʦ',15,NULL);
INSERT INTO `jobsdetail` VALUES (302,'�ɹ�����',15,NULL);
INSERT INTO `jobsdetail` VALUES (303,'���ϻ���������',15,NULL);
INSERT INTO `jobsdetail` VALUES (304,'���̻��豸����',15,NULL);
INSERT INTO `jobsdetail` VALUES (305,'��ȫ����������������',15,NULL);
INSERT INTO `jobsdetail` VALUES (306,'��Ʒ����',15,NULL);
INSERT INTO `jobsdetail` VALUES (307,'����������ƾ���',15,NULL);
INSERT INTO `jobsdetail` VALUES (308,'��������(QA��QC)',15,NULL);
INSERT INTO `jobsdetail` VALUES (309,'���顤����',15,NULL);
INSERT INTO `jobsdetail` VALUES (310,'�ֿ����',15,NULL);
INSERT INTO `jobsdetail` VALUES (311,'ά�޹���ʦ',15,NULL);
INSERT INTO `jobsdetail` VALUES (312,'����������������',15,NULL);
INSERT INTO `jobsdetail` VALUES (313,'�鳤������',15,NULL);
INSERT INTO `jobsdetail` VALUES (314,'�ƻ�������',15,NULL);
INSERT INTO `jobsdetail` VALUES (315,'��Ʒ���������չ���ʦ(PE��ME)',15,NULL);
INSERT INTO `jobsdetail` VALUES (316,'��ҵ����ʦ(IE)',15,NULL);
INSERT INTO `jobsdetail` VALUES (317,'���칤��ʦ',15,NULL);
INSERT INTO `jobsdetail` VALUES (318,'������Ա',15,NULL);
INSERT INTO `jobsdetail` VALUES (319,'����ְλ(����������)',16,NULL);
INSERT INTO `jobsdetail` VALUES (320,'ҽ�ƹ�����Ա',16,NULL);
INSERT INTO `jobsdetail` VALUES (321,'ҽ�Ƽ�����Ա',16,NULL);
INSERT INTO `jobsdetail` VALUES (322,'ҽ����ҽʦ',16,NULL);
INSERT INTO `jobsdetail` VALUES (323,'��ҽ',16,NULL);
INSERT INTO `jobsdetail` VALUES (324,'����ҽ��',16,NULL);
INSERT INTO `jobsdetail` VALUES (325,'ҽҩ����',16,NULL);
INSERT INTO `jobsdetail` VALUES (326,'��ʿ��������Ա',16,NULL);
INSERT INTO `jobsdetail` VALUES (327,'Ӫ��ʦ',16,NULL);
INSERT INTO `jobsdetail` VALUES (328,'ҽ�������������Ա',16,NULL);
INSERT INTO `jobsdetail` VALUES (329,'�������ơ���������',16,NULL);
INSERT INTO `jobsdetail` VALUES (330,'���ݡ�����ʦ',16,NULL);
INSERT INTO `jobsdetail` VALUES (331,'��ҽ������ҽ��',16,NULL);
INSERT INTO `jobsdetail` VALUES (332,'ҩ�����Ρ�ҩ��ʦ',16,NULL);
INSERT INTO `jobsdetail` VALUES (333,'�������',16,NULL);
INSERT INTO `jobsdetail` VALUES (334,'ҩƷע��',16,NULL);
INSERT INTO `jobsdetail` VALUES (335,'������ʡ�����',16,NULL);
INSERT INTO `jobsdetail` VALUES (336,'ҽҩ����',16,NULL);
INSERT INTO `jobsdetail` VALUES (337,'ҽ����е����',16,NULL);
INSERT INTO `jobsdetail` VALUES (338,'����ְλ(ҽ�����������ݱ�����)',16,NULL);
INSERT INTO `jobsdetail` VALUES (339,'��������ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (340,'��Դ����������',17,NULL);
INSERT INTO `jobsdetail` VALUES (341,'��ѹ����ŵ繤��ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (342,'��·����ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (343,'���ܴ��á��ۺϲ��ߡ�����',17,NULL);
INSERT INTO `jobsdetail` VALUES (344,'��������ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (345,'����ά�޼���Ա',17,NULL);
INSERT INTO `jobsdetail` VALUES (346,'ˮ����ˮ�繤��ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (347,'��������������ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (348,'ȼ���ֻ�����ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (349,'�յ������ܹ���ʦ',17,NULL);
INSERT INTO `jobsdetail` VALUES (350,'ʯ����Ȼ��������Ա',17,NULL);
INSERT INTO `jobsdetail` VALUES (351,'�Զ�����',17,NULL);
INSERT INTO `jobsdetail` VALUES (352,'���䡤ůͨ',17,NULL);
INSERT INTO `jobsdetail` VALUES (353,'����ְλ(����,��Դ,������)',17,NULL);
INSERT INTO `jobsdetail` VALUES (354,'�����ܼ�',18,NULL);
INSERT INTO `jobsdetail` VALUES (355,'���������������ܡ��칫������',18,NULL);
INSERT INTO `jobsdetail` VALUES (356,'����רԱ������',18,NULL);
INSERT INTO `jobsdetail` VALUES (357,'����',18,NULL);
INSERT INTO `jobsdetail` VALUES (358,'�����������顤��Ա',18,NULL);
INSERT INTO `jobsdetail` VALUES (359,'ǰ̨���ܻ����Ӵ�',18,NULL);
INSERT INTO `jobsdetail` VALUES (360,'ͼ���鱨�����ϡ��ĵ�����',18,NULL);
INSERT INTO `jobsdetail` VALUES (361,'���Բ���Ա������Ա',18,NULL);
INSERT INTO `jobsdetail` VALUES (362,'����ְλ(������������)',18,NULL);
INSERT INTO `jobsdetail` VALUES (363,'Ӣ��',19,NULL);
INSERT INTO `jobsdetail` VALUES (364,'����',19,NULL);
INSERT INTO `jobsdetail` VALUES (365,'����',19,NULL);
INSERT INTO `jobsdetail` VALUES (366,'����',19,NULL);
INSERT INTO `jobsdetail` VALUES (367,'����',19,NULL);
INSERT INTO `jobsdetail` VALUES (368,'��������',19,NULL);
INSERT INTO `jobsdetail` VALUES (369,'����',19,NULL);
INSERT INTO `jobsdetail` VALUES (370,'��������',19,NULL);
INSERT INTO `jobsdetail` VALUES (371,'�������ַ���',19,NULL);
INSERT INTO `jobsdetail` VALUES (372,'�ͻ������ܼ�',20,NULL);
INSERT INTO `jobsdetail` VALUES (373,'�ͻ��������ͻ���������',20,NULL);
INSERT INTO `jobsdetail` VALUES (374,'�ͻ�����רԱ���ͻ���������',20,NULL);
INSERT INTO `jobsdetail` VALUES (375,'�ͻ���ϵ����',20,NULL);
INSERT INTO `jobsdetail` VALUES (376,'�ͻ���ѯ���ߡ�����������Ա',20,NULL);
INSERT INTO `jobsdetail` VALUES (377,'�ۺ�֧�־����ۺ�֧������',20,NULL);
INSERT INTO `jobsdetail` VALUES (378,'�ۺ�֧�ֹ���ʦ',20,NULL);
INSERT INTO `jobsdetail` VALUES (379,'����ְλ(�ͻ�������)',20,NULL);
INSERT INTO `jobsdetail` VALUES (380,'��ܹ��ʡ�רҵ���ʡ��߻�ʦ',21,NULL);
INSERT INTO `jobsdetail` VALUES (381,'��ѯ�ܼ�',21,NULL);
INSERT INTO `jobsdetail` VALUES (382,'��ѯ����',21,NULL);
INSERT INTO `jobsdetail` VALUES (383,'��ѯԱ',21,NULL);
INSERT INTO `jobsdetail` VALUES (384,'����Ա',21,NULL);
INSERT INTO `jobsdetail` VALUES (385,'��ѵʦ',21,NULL);
INSERT INTO `jobsdetail` VALUES (386,'������ѯʦ',21,NULL);
INSERT INTO `jobsdetail` VALUES (387,'����ְλ(��ѯ��������)',21,NULL);
INSERT INTO `jobsdetail` VALUES (388,'��Ŀ�ܼ�',22,NULL);
INSERT INTO `jobsdetail` VALUES (389,'��Ŀ����',22,NULL);
INSERT INTO `jobsdetail` VALUES (390,'����ְλ(��Ŀ������)',22,NULL);
INSERT INTO `jobsdetail` VALUES (391,'��ѧ�����������Ա',23,NULL);
INSERT INTO `jobsdetail` VALUES (392,'�׶�����',23,NULL);
INSERT INTO `jobsdetail` VALUES (393,'��ʦ',23,NULL);
INSERT INTO `jobsdetail` VALUES (394,'��ʦ',23,NULL);
INSERT INTO `jobsdetail` VALUES (395,'����',23,NULL);
INSERT INTO `jobsdetail` VALUES (396,'�ҽ�',23,NULL);
INSERT INTO `jobsdetail` VALUES (397,'�������/����',23,NULL);
INSERT INTO `jobsdetail` VALUES (398,'������Ʒ����',23,NULL);
INSERT INTO `jobsdetail` VALUES (399,'����ְλ(��������ѵ��)',23,NULL);
INSERT INTO `jobsdetail` VALUES (400,'������֤(QA)������������������',24,NULL);
INSERT INTO `jobsdetail` VALUES (401,'��������(QC)����������',24,NULL);
INSERT INTO `jobsdetail` VALUES (402,'�²�Ʒ��������',24,NULL);
INSERT INTO `jobsdetail` VALUES (403,'��Ӧ�̹����ɹ��豸�������������',24,NULL);
INSERT INTO `jobsdetail` VALUES (404,'������ϵ��֤',24,NULL);
INSERT INTO `jobsdetail` VALUES (405,'����ְλ(����������)',24,NULL);
INSERT INTO `jobsdetail` VALUES (406,'�繤��í������ǯ��',25,NULL);
INSERT INTO `jobsdetail` VALUES (407,'�յ��������ݹ�����¯��',25,NULL);
INSERT INTO `jobsdetail` VALUES (408,'���ᡤ�ӽ�',25,NULL);
INSERT INTO `jobsdetail` VALUES (409,'�ⴲ��������ĥ����ϳ�����崲���ല',25,NULL);
INSERT INTO `jobsdetail` VALUES (410,'�������泵��',25,NULL);
INSERT INTO `jobsdetail` VALUES (411,'���޹�',25,NULL);
INSERT INTO `jobsdetail` VALUES (412,'�и��',25,NULL);
INSERT INTO `jobsdetail` VALUES (413,'��Ʒ���չ���ʦ',25,NULL);
INSERT INTO `jobsdetail` VALUES (414,'�չ�',25,NULL);
INSERT INTO `jobsdetail` VALUES (415,'ˮ����ľ�������Ṥ',25,NULL);
INSERT INTO `jobsdetail` VALUES (416,'ģ�߹���ʦ',25,NULL);
INSERT INTO `jobsdetail` VALUES (417,'����ְλ(������)',25,NULL);
INSERT INTO `jobsdetail` VALUES (418,'���㡤��Ʒ�з���Ͷ�ʡ����ˡ�����',26,NULL);
INSERT INTO `jobsdetail` VALUES (419,'�˱������⡤��Լ����������̨',26,NULL);
INSERT INTO `jobsdetail` VALUES (420,'��ѵ����ѵ����Ա����ҵ���ƶ�',26,NULL);
INSERT INTO `jobsdetail` VALUES (421,'���մ����ˡ������ˡ��ͻ�����',26,NULL);
INSERT INTO `jobsdetail` VALUES (422,'�ͻ��������ڹ���',26,NULL);
INSERT INTO `jobsdetail` VALUES (423,'��������',26,NULL);
INSERT INTO `jobsdetail` VALUES (424,'����ְλ(������)',26,NULL);
INSERT INTO `jobsdetail` VALUES (425,'�곤',27,NULL);
INSERT INTO `jobsdetail` VALUES (426,'Ӫ��',27,NULL);
INSERT INTO `jobsdetail` VALUES (427,'���ʡ���������Ա',27,NULL);
INSERT INTO `jobsdetail` VALUES (428,'���Ա',27,NULL);
INSERT INTO `jobsdetail` VALUES (429,'ӪҵԱ������Ա����Ա������Ա',27,NULL);
INSERT INTO `jobsdetail` VALUES (430,'����Ա',27,NULL);
INSERT INTO `jobsdetail` VALUES (431,'����ְλ(��ҵ������)',27,NULL);
INSERT INTO `jobsdetail` VALUES (432,'��ʦ',28,NULL);
INSERT INTO `jobsdetail` VALUES (433,'���ɹ���',28,NULL);
INSERT INTO `jobsdetail` VALUES (434,'��ʦ����',28,NULL);
INSERT INTO `jobsdetail` VALUES (435,'������Ա',28,NULL);
INSERT INTO `jobsdetail` VALUES (436,'֪ʶ��Ȩ��ר������',28,NULL);
INSERT INTO `jobsdetail` VALUES (437,'����ְλ(������)',28,NULL);
INSERT INTO `jobsdetail` VALUES (438,'���﹤�̡�������ҩ',29,NULL);
INSERT INTO `jobsdetail` VALUES (439,'�ٴ����顤ҩƷע��',29,NULL);
INSERT INTO `jobsdetail` VALUES (440,'ҽҩ�з�����ѧ�Ƽ��з�',29,NULL);
INSERT INTO `jobsdetail` VALUES (441,'ҩƷ��������������',29,NULL);
INSERT INTO `jobsdetail` VALUES (442,'ҩƷ���ۡ��ƹ㡤ҵ����ѯ',29,NULL);
INSERT INTO `jobsdetail` VALUES (443,'ҽҩ����',29,NULL);
INSERT INTO `jobsdetail` VALUES (444,'��������',29,NULL);
INSERT INTO `jobsdetail` VALUES (445,'Ϳ�Ͽ�������ʦ',29,NULL);
INSERT INTO `jobsdetail` VALUES (447,'���û�����Ʒ�з�',29,NULL);
INSERT INTO `jobsdetail` VALUES (448,'��������',29,NULL);
INSERT INTO `jobsdetail` VALUES (449,'����ְλ(�����ҩ��������������)',29,NULL);
INSERT INTO `jobsdetail` VALUES (450,'Ӧ���ҵ��',30,NULL);
INSERT INTO `jobsdetail` VALUES (451,'��Ӧ���ҵ��',30,NULL);
INSERT INTO `jobsdetail` VALUES (452,'ʵϰ��',30,NULL);
INSERT INTO `jobsdetail` VALUES (453,'����(��Уѧ����)',30,NULL);
INSERT INTO `jobsdetail` VALUES (454,'���й�����Ա',31,NULL);
INSERT INTO `jobsdetail` VALUES (455,'������Ա',31,NULL);
INSERT INTO `jobsdetail` VALUES (456,'����ְλ(������)',31,NULL);
INSERT INTO `jobsdetail` VALUES (457,'���պ���',34,NULL);
INSERT INTO `jobsdetail` VALUES (458,'��ȫ����',34,NULL);
INSERT INTO `jobsdetail` VALUES (459,'����ѧ���������⼼��',34,NULL);
INSERT INTO `jobsdetail` VALUES (460,'��漼��',34,NULL);
INSERT INTO `jobsdetail` VALUES (461,'���ʿ��ұ��',34,NULL);
INSERT INTO `jobsdetail` VALUES (462,'����',34,NULL);
INSERT INTO `jobsdetail` VALUES (463,'ũ������',34,NULL);
INSERT INTO `jobsdetail` VALUES (464,'�������ְλ(������)',34,NULL);
INSERT INTO `jobsdetail` VALUES (465,'����Ա',32,NULL);
INSERT INTO `jobsdetail` VALUES (466,'��ѵ��',33,NULL);
/*!40000 ALTER TABLE `jobsdetail` ENABLE KEYS */;

#
# Source for table linkman
#

DROP TABLE IF EXISTS `linkman`;
CREATE TABLE `linkman` (
  `Linkman_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��ϵ�˱�� ��ϵ�˱��',
  `Client_id` int(11) DEFAULT NULL COMMENT '�ͻ���� �ͻ����',
  `Linkman_name` varchar(100) DEFAULT NULL COMMENT '��ϵ������ ��ϵ������',
  `Linkman_nameE` varchar(100) DEFAULT NULL COMMENT '��ϵ�����ƣ�Ӣ�ģ� ��ϵ�����ƣ�Ӣ�ģ�',
  `Linkman_position` varchar(100) DEFAULT NULL COMMENT '��ϵ��ְλ ��ϵ��ְλ',
  `Linkman_phone` varchar(100) DEFAULT NULL COMMENT '��ϵ�˵绰 ��ϵ�˵绰',
  `Linkman_mobileP` varchar(100) DEFAULT NULL COMMENT '��ϵ���ֻ� ��ϵ���ֻ�',
  `LinkMan_Email` varchar(100) DEFAULT NULL COMMENT '��ϵ������ ��ϵ������',
  `Linkman_fax` varchar(100) DEFAULT NULL COMMENT '��ϵ�˴��� ��ϵ�˴���',
  `Linkman_add` varchar(100) DEFAULT NULL COMMENT '��ϵ�˵�ַ ��ϵ�˵�ַ',
  `Comment` varchar(100) DEFAULT NULL COMMENT '��ע ��ע',
  PRIMARY KEY (`Linkman_id`),
  KEY `FK_Linkman_Client_id` (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=gb2312 COMMENT='�ͻ���ϵ��';

#
# Dumping data for table linkman
#

/*!40000 ALTER TABLE `linkman` DISABLE KEYS */;
INSERT INTO `linkman` VALUES (1,14,'dw','sdf','dff','123','456','123','123','123','123');
INSERT INTO `linkman` VALUES (2,18,'���','','��Ƹ����','021-34637358\t','13817798900','','','','');
INSERT INTO `linkman` VALUES (3,18,'','VIVIN��','��������','021-33576888\t','','','','','');
INSERT INTO `linkman` VALUES (10,18,'123','123','123','12','12','123','12','12312','123');
INSERT INTO `linkman` VALUES (11,14,'123','3','3','123','1231231','123','123','12','123');
INSERT INTO `linkman` VALUES (12,14,'123','1231','31','123','23123','3123','123','23123','123123');
/*!40000 ALTER TABLE `linkman` ENABLE KEYS */;

#
# Source for table mingz
#

DROP TABLE IF EXISTS `mingz`;
CREATE TABLE `mingz` (
  `Mingz_id` int(11) NOT NULL AUTO_INCREMENT,
  `Mingz_name` varchar(200) DEFAULT NULL,
  `Comment` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`Mingz_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312;

#
# Dumping data for table mingz
#

/*!40000 ALTER TABLE `mingz` DISABLE KEYS */;
INSERT INTO `mingz` VALUES (1,'����',NULL);
/*!40000 ALTER TABLE `mingz` ENABLE KEYS */;

#
# Source for table nationality
#

DROP TABLE IF EXISTS `nationality`;
CREATE TABLE `nationality` (
  `Nationality_id` int(11) NOT NULL COMMENT '�������',
  `Nationality_name` varchar(200) DEFAULT NULL COMMENT '��������',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Nationality_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='����';

#
# Dumping data for table nationality
#

/*!40000 ALTER TABLE `nationality` DISABLE KEYS */;
INSERT INTO `nationality` VALUES (1,'�й�',NULL);
/*!40000 ALTER TABLE `nationality` ENABLE KEYS */;

#
# Source for table operationmodel
#

DROP TABLE IF EXISTS `operationmodel`;
CREATE TABLE `operationmodel` (
  `OperationModel_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '�ͻ���Ӫģʽ���',
  `OperationModel_name` varchar(200) DEFAULT NULL COMMENT '�ͻ���Ӫģʽ����',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`OperationModel_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312 COMMENT='�ͻ���Ӫģʽ';

#
# Dumping data for table operationmodel
#

/*!40000 ALTER TABLE `operationmodel` DISABLE KEYS */;
INSERT INTO `operationmodel` VALUES (1,'����\r\n����/����/�з�/��������/��ѯ����/�ۺ��ԡ���������\r\n����',NULL);
INSERT INTO `operationmodel` VALUES (2,'����',NULL);
INSERT INTO `operationmodel` VALUES (3,'�з�',NULL);
INSERT INTO `operationmodel` VALUES (4,'��������',NULL);
INSERT INTO `operationmodel` VALUES (5,'��ѯ����',NULL);
INSERT INTO `operationmodel` VALUES (6,'�ۺ���',NULL);
/*!40000 ALTER TABLE `operationmodel` ENABLE KEYS */;

#
# Source for table order_state
#

DROP TABLE IF EXISTS `order_state`;
CREATE TABLE `order_state` (
  `Order_State_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Order_State_Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Order_State_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gb2312;

#
# Dumping data for table order_state
#

/*!40000 ALTER TABLE `order_state` DISABLE KEYS */;
INSERT INTO `order_state` VALUES (1,'Active');
INSERT INTO `order_state` VALUES (2,'pending');
INSERT INTO `order_state` VALUES (3,'filled');
INSERT INTO `order_state` VALUES (4,'future filled');
INSERT INTO `order_state` VALUES (5,'cancelled by us');
INSERT INTO `order_state` VALUES (6,'cancellde by client');
INSERT INTO `order_state` VALUES (7,'failed');
INSERT INTO `order_state` VALUES (8,'close');
/*!40000 ALTER TABLE `order_state` ENABLE KEYS */;

#
# Source for table orders
#

DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `Order_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '������� �������',
  `Order_NO` varchar(255) DEFAULT NULL,
  `Client_id` int(11) DEFAULT NULL COMMENT '�ͻ����',
  `User_id` int(11) DEFAULT NULL COMMENT '���ʱ�� �û����',
  `Order_Stime` datetime DEFAULT NULL COMMENT '������ʼʱ�� ������ʼʱ��',
  `City_id` int(11) DEFAULT NULL COMMENT '���б�� ���б��',
  `Order_positionN` varchar(255) DEFAULT NULL COMMENT 'ְλ���� ְλ����',
  `Order_positionType` varchar(255) DEFAULT NULL COMMENT 'ְλ���� ְλ����',
  `Order_joinN` int(11) DEFAULT NULL COMMENT '��Ƹ���� ��Ƹ����',
  `Order_officeT` date DEFAULT NULL COMMENT 'ϣ����ְ���� ϣ����ְ����',
  `Order_salary` int(11) DEFAULT NULL COMMENT '��н��Ԥ�� ��н��Ԥ��',
  `Order_salaryS` varchar(255) DEFAULT NULL COMMENT 'н��ṹ н��ṹ',
  `Degree_id` int(11) DEFAULT NULL COMMENT 'ѧ����� ѧ�����',
  `Order_Language` varchar(255) DEFAULT NULL COMMENT '��������Ҫ��',
  `Order_languageL` varchar(255) DEFAULT NULL COMMENT '����ˮƽ ����ˮƽ',
  `ForeignLanguage` varchar(255) DEFAULT NULL COMMENT '�����������ֱ�� ������',
  `Order_compendium` varchar(255) DEFAULT NULL COMMENT '��������/���� ��������/����',
  `Order_reportN` varchar(255) DEFAULT NULL COMMENT 'ֱ�ӻ㱨�ϼ�ְλ�Լ����� ֱ�ӻ㱨�ϼ�ְλ�Լ�����',
  `Order_reportN1` int(11) DEFAULT NULL COMMENT 'ֱ�ӻ㱨�ϼ�ְλ�Ĺ������ ֱ�ӻ㱨�ϼ�ְλ�Ĺ������',
  `Order_manageS` varchar(255) DEFAULT NULL COMMENT 'ֱ�ӻ㱨�ϼ������� ֱ�ӻ㱨�ϼ�������',
  `Order_indirectN` varchar(255) DEFAULT NULL COMMENT '��ӻ㱨�ϼ�ְλ�Լ����� ��ӻ㱨�ϼ�ְλ�Լ�����',
  `Order_indirectN1` int(11) DEFAULT NULL COMMENT '��ӻ㱨�ϼ�ְλ�Ĺ������ ��ӻ㱨�ϼ�ְλ�Ĺ������',
  `Order_indirectS` varchar(255) DEFAULT NULL COMMENT '��ӻ㱨�ϼ������� ��ӻ㱨�ϼ�������',
  `Order_subordinateN` int(11) DEFAULT NULL COMMENT '�������� ��������',
  `Order_equivalentN` varchar(255) DEFAULT NULL COMMENT 'ƽ������ ƽ������',
  `Order_equivalentP` varchar(255) DEFAULT NULL COMMENT 'ƽ��ְλ ƽ��ְλ',
  `Order_turnover` decimal(10,2) DEFAULT NULL COMMENT '������֯������Ӫҵ�� ������֯������Ӫҵ��',
  `Order_headcount` int(11) DEFAULT NULL COMMENT '������',
  `Order_share` varchar(255) DEFAULT NULL COMMENT '��ռ�������ŵĹ��׷ݶ�',
  `Order_candidate` bit(1) DEFAULT NULL COMMENT '֮ǰ�Ƿ����Թ���ѡ��',
  `Order_candidateC` varchar(255) DEFAULT NULL COMMENT '�����,����δ¼ȡԭ��',
  `Recruitment_id` int(11) DEFAULT NULL COMMENT '�ù����ַ�����Ƹ',
  `Order_instrument` varchar(255) DEFAULT NULL COMMENT '�����п��ܻ�ʹ�õ��豸/����',
  `Order_allopatry` bit(1) DEFAULT NULL COMMENT '�Ƿ�����غ�ѡ��',
  `Order_preference` tinyint(3) DEFAULT NULL COMMENT 'ƫ��ӦƸ�����Ծ������ֻ������ҵ',
  `Order_company` varchar(255) DEFAULT NULL COMMENT '����ǣ�ϣ����Щ��˾',
  `Order_promotion` varchar(255) DEFAULT NULL COMMENT 'δ��������Ǩ����',
  `Order_Interview1` varchar(255) DEFAULT NULL COMMENT '��������1',
  `Order_Interview2` varchar(255) DEFAULT NULL COMMENT '��������2',
  `Order_Interview3` varchar(255) DEFAULT NULL COMMENT '��������3',
  `Order_Interview4` varchar(255) DEFAULT NULL COMMENT '��������4',
  `Order_written` tinyint(3) DEFAULT NULL COMMENT '�Ƿ����',
  `Order_InterviewT` date DEFAULT NULL COMMENT '��������ʱ��',
  `Order_decision` varchar(255) DEFAULT NULL COMMENT '�����������վ�����',
  `Order_condition` tinyint(3) DEFAULT NULL COMMENT '���е��������Ƿ�ͬ����Ƹ����',
  `Order_InterviewADD` varchar(255) DEFAULT NULL COMMENT '���Եص�',
  `Order_Pdescribe` varchar(255) DEFAULT NULL COMMENT 'ְλ����',
  `comment` varchar(255) DEFAULT NULL COMMENT '��ע',
  `Position_Duty1` varchar(255) DEFAULT NULL COMMENT 'ְλ�ľ���ְ��',
  `Position_Duty2` varchar(255) DEFAULT NULL,
  `Position_Duty3` varchar(255) DEFAULT NULL,
  `Position_Duty4` varchar(255) DEFAULT NULL,
  `Position_Duty5` varchar(255) DEFAULT NULL,
  `Position_Duty6` varchar(255) DEFAULT NULL,
  `JobsDetailID` int(11) DEFAULT NULL COMMENT 'ְλ',
  `Trade_ID` int(11) DEFAULT NULL COMMENT '��ҵ',
  `Experience` int(3) DEFAULT NULL COMMENT '��������',
  `Education_major` varchar(255) DEFAULT NULL COMMENT 'רҵ',
  `Evaluate_Staff1` varchar(255) DEFAULT NULL COMMENT '���˸�ְλ�ϵ�Ա������',
  `Evaluate_Staff2` varchar(255) DEFAULT NULL,
  `Evaluate_Staff3` varchar(255) DEFAULT NULL,
  `Evaluate_Staff4` varchar(255) DEFAULT NULL,
  `Client_Selling1` varchar(255) DEFAULT NULL COMMENT '�ͻ�����',
  `Client_Selling2` varchar(255) DEFAULT NULL,
  `Client_Selling3` varchar(255) DEFAULT NULL,
  `Client_Selling4` varchar(255) DEFAULT NULL,
  `Client_Selling5` varchar(255) DEFAULT NULL,
  `Position_Selling1` varchar(255) DEFAULT NULL COMMENT 'ְλ����',
  `Position_Selling2` varchar(255) DEFAULT NULL,
  `Position_Selling3` varchar(255) DEFAULT NULL,
  `Position_Selling4` varchar(255) DEFAULT NULL,
  `Position_Selling5` varchar(255) DEFAULT NULL,
  `Position_Difficulty1` varchar(255) DEFAULT NULL COMMENT 'ְλ����Ƹ�ѵ�',
  `Position_Difficulty2` varchar(255) DEFAULT NULL,
  `Position_Difficulty3` varchar(255) DEFAULT NULL,
  `Position_Difficulty4` varchar(255) DEFAULT NULL,
  `Position_Difficulty5` varchar(255) DEFAULT NULL,
  `Position_Challenge1` varchar(255) DEFAULT NULL COMMENT 'ְλ�ĶԺ�ѡ�˵���ս',
  `Position_Challenge2` varchar(255) DEFAULT NULL,
  `Position_Challenge3` varchar(255) DEFAULT NULL,
  `Position_Challenge4` varchar(255) DEFAULT NULL,
  `Position_Challenge5` varchar(255) DEFAULT NULL,
  `Order_State_ID` int(11) DEFAULT NULL,
  `Order_CreateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`Order_id`),
  KEY `Client_id` (`Client_id`),
  KEY `Order_State_ID` (`Order_State_ID`),
  KEY `User_id` (`User_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312 COMMENT='����';

#
# Dumping data for table orders
#

/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2010000001',14,1,'2010-11-11',2,'','����',0,'2010-11-11',0,'',1,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-11','',0,'','',NULL,'','','','','','',1,1,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (2,'2010000002',14,1,'2010-11-14',3,'456','����',0,'2010-11-14',0,'46',2,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (3,'2010000003',14,1,'2010-11-14',1,'123','����',0,'2010-11-14',0,'',1,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','','','','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (4,'2010000004',14,1,'2010-11-14',1,'123123','����',0,'2010-11-14',0,'123',1,'','123123','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','','','','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (5,'2010000005',14,1,'2010-11-17',3,'����','����',0,'2010-11-17',0,'123',2,'12','123','123','123','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-17','',0,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (6,'2010000006',15,1,'2010-11-18',1,'123','����',0,'2010-11-18',0,'123',2,'123','123','123','123','',1,'','',1,'',0,'','',0,0,'',b'1','',1,'',b'0',-1,'','','','','','',0,'2010-11-18','',-1,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;

#
# Source for table ownership
#

DROP TABLE IF EXISTS `ownership`;
CREATE TABLE `ownership` (
  `Ownership_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '������id',
  `Ownership_name` varchar(200) DEFAULT NULL COMMENT '����������',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Ownership_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=gb2312 COMMENT='����������';

#
# Dumping data for table ownership
#

/*!40000 ALTER TABLE `ownership` DISABLE KEYS */;
INSERT INTO `ownership` VALUES (1,'ŷ������',NULL);
INSERT INTO `ownership` VALUES (2,'ŷ������',NULL);
INSERT INTO `ownership` VALUES (3,'����',NULL);
INSERT INTO `ownership` VALUES (4,'������ҵ',NULL);
INSERT INTO `ownership` VALUES (5,'NGO',NULL);
INSERT INTO `ownership` VALUES (6,'����',NULL);
INSERT INTO `ownership` VALUES (7,'��ŷ������',NULL);
/*!40000 ALTER TABLE `ownership` ENABLE KEYS */;

#
# Source for table personnel
#

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `Personnel_id` int(11) NOT NULL COMMENT '��Աid',
  `Personnel_name` int(11) DEFAULT NULL COMMENT '����',
  `comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`Personnel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='��Ա';

#
# Dumping data for table personnel
#

/*!40000 ALTER TABLE `personnel` DISABLE KEYS */;
/*!40000 ALTER TABLE `personnel` ENABLE KEYS */;

#
# Source for table province
#

DROP TABLE IF EXISTS `province`;
CREATE TABLE `province` (
  `Province_id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ʡ�ݱ��',
  `Province_name` varchar(200) DEFAULT NULL COMMENT 'ʡ������',
  `Comment` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`Province_id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=gb2312 COMMENT='ʡ��';

#
# Dumping data for table province
#

/*!40000 ALTER TABLE `province` DISABLE KEYS */;
INSERT INTO `province` VALUES (1,'������',NULL);
INSERT INTO `province` VALUES (2,'�����',NULL);
INSERT INTO `province` VALUES (3,'�ӱ�ʡ',NULL);
INSERT INTO `province` VALUES (4,'ɽ��ʡ',NULL);
INSERT INTO `province` VALUES (5,'���ɹ�������',NULL);
INSERT INTO `province` VALUES (6,'����ʡ',NULL);
INSERT INTO `province` VALUES (7,'����ʡ',NULL);
INSERT INTO `province` VALUES (8,'������ʡ',NULL);
INSERT INTO `province` VALUES (9,'�Ϻ���',NULL);
INSERT INTO `province` VALUES (10,'����ʡ',NULL);
INSERT INTO `province` VALUES (11,'�㽭ʡ',NULL);
INSERT INTO `province` VALUES (12,'����ʡ',NULL);
INSERT INTO `province` VALUES (13,'����ʡ',NULL);
INSERT INTO `province` VALUES (14,'����ʡ',NULL);
INSERT INTO `province` VALUES (15,'ɽ��ʡ',NULL);
INSERT INTO `province` VALUES (16,'����ʡ',NULL);
INSERT INTO `province` VALUES (17,'����ʡ',NULL);
INSERT INTO `province` VALUES (18,'����ʡ',NULL);
INSERT INTO `province` VALUES (19,'�㶫ʡ',NULL);
INSERT INTO `province` VALUES (20,'����׳��������',NULL);
INSERT INTO `province` VALUES (21,'����ʡ',NULL);
INSERT INTO `province` VALUES (22,'������',NULL);
INSERT INTO `province` VALUES (23,'�Ĵ�ʡ',NULL);
INSERT INTO `province` VALUES (24,'����ʡ',NULL);
INSERT INTO `province` VALUES (25,'����ʡ',NULL);
INSERT INTO `province` VALUES (26,'����������',NULL);
INSERT INTO `province` VALUES (27,'����ʡ',NULL);
INSERT INTO `province` VALUES (28,'����ʡ',NULL);
INSERT INTO `province` VALUES (29,'�ຣʡ',NULL);
INSERT INTO `province` VALUES (30,'���Ļ���������',NULL);
INSERT INTO `province` VALUES (31,'�½�ά���������',NULL);
INSERT INTO `province` VALUES (32,'����ر�������',NULL);
INSERT INTO `province` VALUES (33,'�����ر�������',NULL);
INSERT INTO `province` VALUES (34,'̨��ʡ',NULL);
/*!40000 ALTER TABLE `province` ENABLE KEYS */;

#
# Source for table recommended
#

DROP TABLE IF EXISTS `recommended`;
CREATE TABLE `recommended` (
  `Recommended_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Order_id` int(11) NOT NULL DEFAULT '0',
  `Candidate_id` int(11) NOT NULL DEFAULT '0',
  `Users_ID` int(11) NOT NULL DEFAULT '0',
  `Recommended_State_ID` int(11) NOT NULL DEFAULT '0',
  `Recommended_Order` int(11) NOT NULL DEFAULT '1',
  `Advantages` varchar(255) DEFAULT NULL,
  `Inferior` varchar(255) DEFAULT NULL,
  `Recommended_Time` datetime DEFAULT NULL,
  PRIMARY KEY (`Recommended_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=gb2312;

#
# Dumping data for table recommended
#

/*!40000 ALTER TABLE `recommended` DISABLE KEYS */;
INSERT INTO `recommended` VALUES (2,4,6,1,2,1,'wer','werwer','2009-01-01');
INSERT INTO `recommended` VALUES (3,4,4,1,2,2,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (4,4,8,1,3,3,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (5,4,7,1,2,4,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (6,4,6,1,2,5,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (7,4,5,1,2,6,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (8,3,6,1,2,1,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (9,3,8,1,2,2,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (10,3,4,1,2,3,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (11,2,4,1,2,1,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (12,2,5,1,2,2,NULL,NULL,'2009-01-01');
INSERT INTO `recommended` VALUES (13,2,8,1,2,3,'123','23231','2009-01-01');
INSERT INTO `recommended` VALUES (15,1,5,1,2,1,'123','123','2010-11-16 17:17:14');
INSERT INTO `recommended` VALUES (16,5,5,1,2,1,'123','123','2010-11-17 00:38:13');
INSERT INTO `recommended` VALUES (17,6,1,1,2,1,'123','123',NULL);
/*!40000 ALTER TABLE `recommended` ENABLE KEYS */;

#
# Source for table recommended_state
#

DROP TABLE IF EXISTS `recommended_state`;
CREATE TABLE `recommended_state` (
  `Recommended_State_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Recommended_State_Name` varchar(255) DEFAULT '',
  `Recommended_State_Remark` tinyint(3) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Recommended_State_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=gb2312;

#
# Dumping data for table recommended_state
#

/*!40000 ALTER TABLE `recommended_state` DISABLE KEYS */;
INSERT INTO `recommended_state` VALUES (1,'�ȴ�����',0);
INSERT INTO `recommended_state` VALUES (2,'��������',0);
INSERT INTO `recommended_state` VALUES (3,'�ͻ�����',0);
INSERT INTO `recommended_state` VALUES (4,'ʧ��',0);
INSERT INTO `recommended_state` VALUES (5,'�ɹ�',0);
/*!40000 ALTER TABLE `recommended_state` ENABLE KEYS */;

#
# Source for table recommended_state_remark
#

DROP TABLE IF EXISTS `recommended_state_remark`;
CREATE TABLE `recommended_state_remark` (
  `recommended_state_remark_Id` int(11) NOT NULL AUTO_INCREMENT,
  `recommended_ID` int(11) NOT NULL DEFAULT '0',
  `recommended_state_ID` int(11) NOT NULL DEFAULT '0',
  `recommended_state_remark_content` varchar(255) DEFAULT NULL,
  `recommended_state_remark_Time` datetime DEFAULT NULL,
  `User_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`recommended_state_remark_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=gb2312;

#
# Dumping data for table recommended_state_remark
#

/*!40000 ALTER TABLE `recommended_state_remark` DISABLE KEYS */;
INSERT INTO `recommended_state_remark` VALUES (1,12,1,'123$$$$123','2010-11-16 05:53:39',1);
INSERT INTO `recommended_state_remark` VALUES (2,12,2,'123$$$$123','2010-11-16 05:53:44',1);
INSERT INTO `recommended_state_remark` VALUES (3,15,2,'123','2010-11-16 17:17:42',1);
INSERT INTO `recommended_state_remark` VALUES (4,13,2,'123123','2010-11-25 03:15:24',1);
INSERT INTO `recommended_state_remark` VALUES (23,4,3,'12312','2010-11-29 21:30:50',1);
INSERT INTO `recommended_state_remark` VALUES (24,4,3,'123123','2010-11-29 21:48:35',1);
/*!40000 ALTER TABLE `recommended_state_remark` ENABLE KEYS */;

#
# Source for table recruitment
#

DROP TABLE IF EXISTS `recruitment`;
CREATE TABLE `recruitment` (
  `Recruitment_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Recruitment_Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Recruitment_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312;

#
# Dumping data for table recruitment
#

/*!40000 ALTER TABLE `recruitment` DISABLE KEYS */;
INSERT INTO `recruitment` VALUES (1,'����');
INSERT INTO `recruitment` VALUES (2,'��ֽ');
INSERT INTO `recruitment` VALUES (3,'��Ƹ��');
/*!40000 ALTER TABLE `recruitment` ENABLE KEYS */;

#
# Source for table recruitment_quantity
#

DROP TABLE IF EXISTS `recruitment_quantity`;
CREATE TABLE `recruitment_quantity` (
  `RQ_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��Ƹ�������',
  `Client_id` int(11) DEFAULT NULL COMMENT '�ͻ����',
  `RQ_Lyear` varchar(50) DEFAULT NULL COMMENT 'ȥ��',
  `RQ_LyearT` varchar(50) DEFAULT NULL COMMENT 'ȥ���ʱ��',
  `RQ_future` varchar(50) DEFAULT NULL COMMENT 'δ��',
  `RQ_futureT` varchar(50) DEFAULT NULL COMMENT 'δ����ʱ��',
  `Comment` varchar(200) DEFAULT NULL COMMENT '��ע',
  `RQ_Year` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`RQ_id`),
  KEY `FK_Recruitmeity_Client_id` (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312 COMMENT='��˾ȥ���Լ�δ������Ƹ��';

#
# Dumping data for table recruitment_quantity
#

/*!40000 ALTER TABLE `recruitment_quantity` DISABLE KEYS */;
INSERT INTO `recruitment_quantity` VALUES (-1,18,NULL,NULL,'123',NULL,NULL,NULL);
INSERT INTO `recruitment_quantity` VALUES (1,18,'123','123','123','123',NULL,'2010');
INSERT INTO `recruitment_quantity` VALUES (2,15,'','','','',NULL,'2010');
/*!40000 ALTER TABLE `recruitment_quantity` ENABLE KEYS */;

#
# Source for table resume
#

DROP TABLE IF EXISTS `resume`;
CREATE TABLE `resume` (
  `Resume_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '������� �������',
  `Candidate_id` int(11) DEFAULT NULL COMMENT '��ѡ�˱�� ��ѡ�˱��',
  `Resume_ShowName` varchar(255) DEFAULT NULL COMMENT '������ʾ������',
  `Resume_language` varchar(20) DEFAULT NULL COMMENT '�������� ��������',
  `City_id` int(11) DEFAULT NULL COMMENT '�����ر�� ������',
  `City_id1` int(11) DEFAULT NULL COMMENT '���������ر�� ����������',
  `JobsDetail_idArr` varchar(255) DEFAULT NULL COMMENT 'ְλ��� ְλ',
  `Trade_IDArr` varchar(255) DEFAULT NULL COMMENT '��ҵ���',
  `Experience` int(11) DEFAULT NULL COMMENT '��ع������� ��ع�������',
  `Resume_annual` decimal(10,2) DEFAULT '0.00' COMMENT '������н ������н',
  `Resume_expectation` decimal(10,2) DEFAULT '0.00' COMMENT '������н ������н',
  `Resume_overseas` varchar(200) DEFAULT NULL COMMENT '���⹤������ ���⹤������',
  `Resume_evaluate` varchar(200) DEFAULT NULL COMMENT '�������� ��������',
  `update_time` datetime DEFAULT NULL COMMENT '������ʱ��',
  `Comment` varchar(200) DEFAULT NULL COMMENT '��ע ��ע',
  PRIMARY KEY (`Resume_id`),
  KEY `FK_Resume_Candidate_id` (`Candidate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=gb2312 COMMENT='����';

#
# Dumping data for table resume
#

/*!40000 ALTER TABLE `resume` DISABLE KEYS */;
INSERT INTO `resume` VALUES (1,4,NULL,'����',0,0,'38,39,','11,3,',100,100,100,'123123','123','2010-11-05 14:08:24',NULL);
INSERT INTO `resume` VALUES (2,5,NULL,'����',1,1,'1,2,','1,',100,100,100,'123','123123','2010-11-07 00:28:11',NULL);
INSERT INTO `resume` VALUES (3,6,NULL,'����',1,1,'1,2,','1,',100,100,100,'123','123123','2010-11-07 00:28:28',NULL);
INSERT INTO `resume` VALUES (4,7,NULL,'����',1,1,'10,11,','1,',100,100,100,'123123','213','2010-11-07 00:30:01',NULL);
INSERT INTO `resume` VALUES (5,8,NULL,'����',0,0,'','',0,0,0,'','','2010-11-07 00:31:11',NULL);
INSERT INTO `resume` VALUES (6,6,'κ���','����',1,1,'2,1,','17,1,',100,100,100,'123','123','2010-11-11 01:02:02',NULL);
INSERT INTO `resume` VALUES (7,1,'123','����',1,1,'','',0,0,0,'','','2010-11-18 17:10:26',NULL);
INSERT INTO `resume` VALUES (8,NULL,'���','����',1,1,'','',0,0,0,'','','2010-12-01 02:43:25',NULL);
INSERT INTO `resume` VALUES (9,15,'123','Ӣ��',1,1,'','',0,0,0,'','','2010-12-01 02:48:47',NULL);
INSERT INTO `resume` VALUES (10,15,'123','����',3,1,'','',0,0,0,'','','2010-12-01 03:29:43',NULL);
/*!40000 ALTER TABLE `resume` ENABLE KEYS */;

#
# Source for table rights
#

DROP TABLE IF EXISTS `rights`;
CREATE TABLE `rights` (
  `Right_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Right_Name` varchar(50) NOT NULL,
  `Right_Func` varchar(4000) DEFAULT NULL,
  `comment` varchar(4000) DEFAULT NULL,
  PRIMARY KEY (`Right_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312;

#
# Dumping data for table rights
#

/*!40000 ALTER TABLE `rights` DISABLE KEYS */;
INSERT INTO `rights` VALUES (1,'��¼','�����û���¼',NULL);
INSERT INTO `rights` VALUES (2,'�����޸�','�����û��޸�����',NULL);
/*!40000 ALTER TABLE `rights` ENABLE KEYS */;

#
# Source for table roles
#

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT '��ɫ���',
  `Name` varchar(4000) DEFAULT NULL COMMENT '��ɫ��',
  `Rights` varchar(4000) DEFAULT NULL COMMENT 'Ȩ���б�',
  `comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312;

#
# Dumping data for table roles
#

/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'����Ա','1,2',NULL);
INSERT INTO `roles` VALUES (2,'����','1',NULL);
INSERT INTO `roles` VALUES (3,'����',NULL,NULL);
INSERT INTO `roles` VALUES (4,'����',NULL,NULL);
INSERT INTO `roles` VALUES (5,'����','1',NULL);
INSERT INTO `roles` VALUES (6,'123','1',NULL);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;

#
# Source for table team
#

DROP TABLE IF EXISTS `team`;
CREATE TABLE `team` (
  `Team_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Team_Name` varchar(255) DEFAULT NULL,
  `Team_Leader_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Team_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=gb2312;

#
# Dumping data for table team
#

/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` VALUES (1,'����һ��',1);
INSERT INTO `team` VALUES (2,'���ʶ���',4);
INSERT INTO `team` VALUES (8,'��������',5);
INSERT INTO `team` VALUES (9,'�����Ĳ�',3);
/*!40000 ALTER TABLE `team` ENABLE KEYS */;

#
# Source for table trade
#

DROP TABLE IF EXISTS `trade`;
CREATE TABLE `trade` (
  `Trade_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '��ҵ���',
  `Trade_name` varchar(200) DEFAULT NULL COMMENT '��ҵ����',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '��ҵ��ע',
  PRIMARY KEY (`Trade_id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=gb2312 COMMENT='��ҵ��';

#
# Dumping data for table trade
#

/*!40000 ALTER TABLE `trade` DISABLE KEYS */;
INSERT INTO `trade` VALUES (1,'�����',NULL);
INSERT INTO `trade` VALUES (2,'����������������',NULL);
INSERT INTO `trade` VALUES (3,'������Ϸ',NULL);
INSERT INTO `trade` VALUES (4,'���ӡ�΢����',NULL);
INSERT INTO `trade` VALUES (5,'ͨ��(�豸����Ӫ����ֵ����)',NULL);
INSERT INTO `trade` VALUES (6,'��桤��չ������',NULL);
INSERT INTO `trade` VALUES (7,'���ز������������빤��',NULL);
INSERT INTO `trade` VALUES (8,'��ҵ������ҵ����',NULL);
INSERT INTO `trade` VALUES (9,'�Ҿߡ�������ơ�װ��',NULL);
INSERT INTO `trade` VALUES (10,'�н����',NULL);
INSERT INTO `trade` VALUES (11,'רҵ����(��ѯ���ƻᡤ���ɵ�)',NULL);
INSERT INTO `trade` VALUES (12,'���顤��⡤��֤',NULL);
INSERT INTO `trade` VALUES (13,'����ҵ(Ͷ�ʡ����ա�֤ȯ�����С�����)',NULL);
INSERT INTO `trade` VALUES (14,'ó�ס�������',NULL);
INSERT INTO `trade` VALUES (15,'ý�塤���桤�Ļ�����',NULL);
INSERT INTO `trade` VALUES (16,'ӡˢ����װ����ֽ',NULL);
INSERT INTO `trade` VALUES (17,'��������Ʒ(ʳƷ�����ϡ��ջ����̾Ƶ�)',NULL);
INSERT INTO `trade` VALUES (18,'��������Ʒ(���Ρ���֯��Ƥ��Ҿ�)',NULL);
INSERT INTO `trade` VALUES (19,'��ߡ�����Ʒ���ղ�Ʒ���ݳ�Ʒ',NULL);
INSERT INTO `trade` VALUES (20,'�ҵ�ҵ',NULL);
INSERT INTO `trade` VALUES (21,'�칫�豸����Ʒ',NULL);
INSERT INTO `trade` VALUES (22,'���Ρ��Ƶꡤ��������',NULL);
INSERT INTO `trade` VALUES (23,'����������',NULL);
INSERT INTO `trade` VALUES (24,'��ͨ�����䡤����',NULL);
INSERT INTO `trade` VALUES (25,'���֡��˶�������',NULL);
INSERT INTO `trade` VALUES (26,'��ҩ�����﹤��',NULL);
INSERT INTO `trade` VALUES (27,'ҽ�ơ����������ݡ���������',NULL);
INSERT INTO `trade` VALUES (28,'ҽ���豸����е',NULL);
INSERT INTO `trade` VALUES (29,'����',NULL);
INSERT INTO `trade` VALUES (30,'ʯ�͡�������������ɾ�ұ����ԭ����',NULL);
INSERT INTO `trade` VALUES (31,'��Դ(������ʯ��)��ˮ��',NULL);
INSERT INTO `trade` VALUES (32,'�������Ǳ���ҵ�Զ���������',NULL);
INSERT INTO `trade` VALUES (33,'������Ħ�г�(���졤ά������������ۡ�����)',NULL);
INSERT INTO `trade` VALUES (34,'��е���졤���硤�ع�',NULL);
INSERT INTO `trade` VALUES (35,'ԭ���ϼ��ӹ�(������ľ�ġ��𽺡����ϡ��������մɡ�����)',NULL);
INSERT INTO `trade` VALUES (36,'����ҵ',NULL);
INSERT INTO `trade` VALUES (37,'ũ���֡�������',NULL);
INSERT INTO `trade` VALUES (38,'���ա������о�������',NULL);
INSERT INTO `trade` VALUES (39,'��������',NULL);
INSERT INTO `trade` VALUES (40,'��������ѵ�����С�ԺУ',NULL);
INSERT INTO `trade` VALUES (41,'��������Ӫ������',NULL);
INSERT INTO `trade` VALUES (42,'����',NULL);
/*!40000 ALTER TABLE `trade` ENABLE KEYS */;

#
# Source for table users
#

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `User_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '�û����',
  `User_superior_id` int(11) DEFAULT NULL COMMENT '�ϼ����',
  `User_name` varchar(4000) NOT NULL COMMENT '�û�����',
  `User_pwd` varchar(4000) NOT NULL COMMENT '�û�����',
  `User_realName` varchar(4000) DEFAULT NULL COMMENT '�û�����',
  `User_number` varchar(4000) NOT NULL COMMENT '�û��������',
  `Creation_time` datetime NOT NULL COMMENT '����ʱ��',
  `Role_ID` int(11) NOT NULL COMMENT '��ɫ���',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '��ע',
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=gb2312;

#
# Dumping data for table users
#

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'kk','123','�ɿ�','009','2010-11-03 03:01:32',1,'1123123');
INSERT INTO `users` VALUES (2,2,'123','8888','����123','1','2010-10-28 16:31:48',2,'1');
INSERT INTO `users` VALUES (3,9,'1234','8888','����1','1','2010-10-28 16:32:01',3,'11');
INSERT INTO `users` VALUES (4,2,'kkk','8888','������','3234','2010-10-28 16:32:07',4,'1');
INSERT INTO `users` VALUES (5,8,'pp','8888','��ƿ�','123','2010-10-28 16:32:12',5,'123');
INSERT INTO `users` VALUES (6,8,'gg','8888','��������12','123123','2010-10-28 16:32:18',5,'1');
INSERT INTO `users` VALUES (7,8,'dd','8888','dd','123','2010-11-03 03:01:44',4,'123');
INSERT INTO `users` VALUES (8,9,'qq','8888','123','1123123','2010-11-02 02:46:07',2,'123');
INSERT INTO `users` VALUES (9,2,'234','8888','234234','234','2010-11-14 13:31:58',5,'234');
INSERT INTO `users` VALUES (10,1,'ggg','8888','123','1','2010-11-18 14:44:18',1,'1');
INSERT INTO `users` VALUES (11,9,'ggg','8888','gggggg','1','2010-11-18 14:45:06',1,'1');
INSERT INTO `users` VALUES (12,1,'123','8888','dff1113','1','2010-11-18 14:53:45',0,'1');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

#
# Source for table weeklyc_details
#

DROP TABLE IF EXISTS `weeklyc_details`;
CREATE TABLE `weeklyc_details` (
  `WCD_id` int(11) NOT NULL AUTO_INCREMENT,
  `WC_id` int(11) DEFAULT NULL,
  `WCD_Week` int(11) DEFAULT NULL,
  `WCD_Name` varchar(50) DEFAULT NULL,
  `WCD_Targets` int(11) DEFAULT NULL,
  `WCD_Tot` int(11) DEFAULT NULL,
  `WCD_Var` int(11) DEFAULT NULL,
  `WCD_DAM` int(11) DEFAULT NULL,
  `WCD_DAT` int(11) DEFAULT NULL,
  `WCD_DAW` int(11) DEFAULT NULL,
  `WCD_DATH` int(11) DEFAULT NULL,
  `WCD_DAF` int(11) DEFAULT NULL,
  `WCD_DAS` int(11) DEFAULT NULL,
  `WCD_Time` datetime DEFAULT NULL,
  `Comment` varchar(4000) DEFAULT NULL,
  PRIMARY KEY (`WCD_id`),
  KEY `FK_WeeklyC_Details_WC_id` (`WC_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312;

#
# Dumping data for table weeklyc_details
#

/*!40000 ALTER TABLE `weeklyc_details` DISABLE KEYS */;
/*!40000 ALTER TABLE `weeklyc_details` ENABLE KEYS */;

#
# Source for table weeklyc_particulars
#

DROP TABLE IF EXISTS `weeklyc_particulars`;
CREATE TABLE `weeklyc_particulars` (
  `WCP_id` int(11) NOT NULL AUTO_INCREMENT,
  `WCP_type` int(11) DEFAULT NULL,
  `WCP_name` varchar(255) DEFAULT NULL,
  `WCP_value` int(10) DEFAULT NULL,
  `Comment` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`WCP_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=gb2312;

#
# Dumping data for table weeklyc_particulars
#

/*!40000 ALTER TABLE `weeklyc_particulars` DISABLE KEYS */;
INSERT INTO `weeklyc_particulars` VALUES (1,0,'ҵ�������ṩ�ļ�������',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (2,0,'�Լ�Ѱ�õ��ļ���',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (3,0,'������Ѱ�ҵ��ļ�������(51job etc��job posting)',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (4,0,'��Ѱ����ͨѶ¼����/��֯����ͼ',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (5,0,'��Ѱ����δ���ͻ�������',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (6,0,'��51Job��Chinahr�������Ϸ����Ĺ��ְλ����',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (7,0,'����;����ְλ��������',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (8,0,'�칫���������� BI',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (9,0,'�����ͻ��ļ������� RSO',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (10,0,'�ͻ��������� CI',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (11,0,'�¶��������� ',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (12,0,'ҵ����չ�绰����',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (13,0,'������Ӫ���ʼ�����',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (14,0,'����δ���ͻ��ķ����ƻ��������',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (15,0,'�ͻ��ݷõ�����',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (16,0,'QP1-Candidate performance with client',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (17,0,'QP2-BM service with client',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (18,0,'Qp3-Consultant performance with Candidate',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (19,1,'�ҵ���Ŀ���ѡ�˸���',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (20,1,'�õ��ĺ�ѡ�˼�������',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (21,1,'��Ч����(����ɸѡ��������)',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (22,1,'RSO����',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (23,1,'���Ժ�ѡ��',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (24,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (25,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (26,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (27,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (28,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (29,1,NULL,NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (30,1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `weeklyc_particulars` ENABLE KEYS */;

#
# Source for table wekkly_consultant
#

DROP TABLE IF EXISTS `wekkly_consultant`;
CREATE TABLE `wekkly_consultant` (
  `WC_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `WC_week` int(11) DEFAULT NULL,
  `WC_month` int(11) DEFAULT NULL,
  `WC_useN` decimal(10,1) DEFAULT NULL,
  `WC_useName` varchar(50) DEFAULT NULL,
  `WC_Milestone1` varchar(50) DEFAULT NULL,
  `WC_Milestone2` varchar(50) DEFAULT NULL,
  `WC_Milestone3` varchar(50) DEFAULT NULL,
  `WC_Thing1` varchar(50) DEFAULT NULL,
  `WC_Thing2` varchar(50) DEFAULT NULL,
  `WC_Thing3` varchar(50) DEFAULT NULL,
  `WC_cTime` datetime DEFAULT NULL,
  `WC_Path` varchar(255) DEFAULT NULL,
  `Comment` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`WC_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312;

#
# Dumping data for table wekkly_consultant
#

/*!40000 ALTER TABLE `wekkly_consultant` DISABLE KEYS */;
/*!40000 ALTER TABLE `wekkly_consultant` ENABLE KEYS */;

#
# Source for table work_experience
#

DROP TABLE IF EXISTS `work_experience`;
CREATE TABLE `work_experience` (
  `WE_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '����������� �����������',
  `Resume_id` int(11) DEFAULT NULL COMMENT '������� �������',
  `WE_DateS` datetime DEFAULT NULL COMMENT '����ʱ���� ����ʱ��',
  `WE_DateE` datetime DEFAULT NULL COMMENT '����ʱ��ֹ',
  `WE_name` varchar(4000) DEFAULT NULL COMMENT '�������� ��������',
  `WE_position` varchar(4000) DEFAULT NULL COMMENT 'ְλ ְλ',
  `WE_place` varchar(200) DEFAULT NULL COMMENT '�����ص� �����ص�',
  `WE_target` varchar(200) DEFAULT NULL COMMENT '�㱨���� �㱨����',
  `WE_responsibility` varchar(200) DEFAULT NULL COMMENT '����ְ�� ����ְ��',
  `WE_achievement` varchar(200) DEFAULT NULL COMMENT '����ҵ�� ����ҵ��',
  `WE_leave` varchar(200) DEFAULT NULL COMMENT '��ְԭ�� ��ְԭ��',
  `Comment` varchar(200) DEFAULT NULL COMMENT '��ע ��ע',
  PRIMARY KEY (`WE_id`),
  KEY `FK_Work_Expence_Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=gb2312 COMMENT='��������';

#
# Dumping data for table work_experience
#

/*!40000 ALTER TABLE `work_experience` DISABLE KEYS */;
INSERT INTO `work_experience` VALUES (13,6,'2010-11-07','2010-11-07','123','123','23','123','23123','123','123',NULL);
/*!40000 ALTER TABLE `work_experience` ENABLE KEYS */;

#
# Source for view vw_client
#

DROP VIEW IF EXISTS `vw_client`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_client` AS select `u`.`User_realName` AS `user_realname`,`cp`.`ClientProperty_name` AS `ClientProperty_name`,`t`.`Trade_name` AS `trade_name`,`p`.`Province_name` AS `province_name`,`ct`.`City_name` AS `city_name`,`o`.`Ownership_name` AS `ownership_name`,`om`.`OperationModel_name` AS `operationmodel_name`,`d`.`Dimensions_name` AS `dimensions_name`,`e`.`EmployeesNumber_name` AS `employeesnumber_name`,`c`.`Client_id` AS `Client_id`,`c`.`Client_establishT` AS `Client_establishT`,`c`.`User_id` AS `User_id`,`c`.`Client_name` AS `Client_name`,`c`.`Client_nameE` AS `Client_nameE`,`c`.`Client_Property` AS `Client_Property`,`c`.`Client_URL` AS `Client_URL`,`c`.`Client_add` AS `Client_add`,`c`.`Client_postcode` AS `Client_postcode`,`c`.`Client_product` AS `Client_product`,`c`.`Client_targetMarket` AS `Client_targetMarket`,`c`.`Trade_id` AS `Trade_id`,`c`.`Province_id` AS `Province_id`,`c`.`City_id` AS `City_id`,`c`.`Client_typical` AS `Client_typical`,`c`.`Ownership_id` AS `Ownership_id`,`c`.`OperationModel_id` AS `OperationModel_id`,`c`.`Client_summary` AS `Client_summary`,`c`.`Dimensions_id` AS `Dimensions_id`,`c`.`EmployeesNumber_id` AS `EmployeesNumber_id`,`c`.`Client_sales` AS `Client_sales`,`c`.`Client_structure` AS `Client_structure`,`c`.`Client_development` AS `Client_development`,`c`.`Client_challenge` AS `Client_challenge`,`c`.`Client_turnover` AS `Client_turnover`,`c`.`Client_Intermediate` AS `Client_Intermediate`,`c`.`Client_primary` AS `Client_primary`,`c`.`Client_Join` AS `Client_Join`,`c`.`Client_difficulty` AS `Client_difficulty`,`c`.`Client_cooperation` AS `Client_cooperation`,`c`.`Client_cooperationN` AS `Client_cooperationN`,`c`.`Client_recruitment` AS `Client_recruitment`,`c`.`Client_cooperationA` AS `Client_cooperationA`,`c`.`Client_staff` AS `Client_staff`,`c`.`Client_income1` AS `Client_income1`,`c`.`Client_income2` AS `Client_income2`,`c`.`Client_challenge1` AS `Client_challenge1`,`c`.`Client_challenge2` AS `Client_challenge2`,`c`.`Client_interviewing` AS `Client_interviewing`,`c`.`Client_way` AS `Client_way`,`c`.`Client_period` AS `Client_period`,`c`.`Client_welfare` AS `Client_welfare`,`c`.`Client_increase` AS `Client_increase`,`c`.`Client_range` AS `Client_range`,`c`.`Client_reputation` AS `Client_reputation`,`c`.`Client_hierarchy` AS `Client_hierarchy`,`c`.`Client_status` AS `Client_status`,`c`.`Client_contract` AS `Client_contract`,`c`.`Comment` AS `Comment` from (((((((((`client` `c` left join `users` `u` on((`u`.`User_id` = `c`.`User_id`))) left join `clientproperty` `cp` on((`cp`.`ClientProperty_id` = `c`.`Client_Property`))) left join `trade` `t` on((`t`.`Trade_id` = `c`.`Trade_id`))) left join `province` `p` on((`p`.`Province_id` = `c`.`Province_id`))) left join `city` `ct` on((`c`.`City_id` = `ct`.`City_id`))) left join `ownership` `o` on((`o`.`Ownership_id` = `c`.`Ownership_id`))) left join `operationmodel` `om` on((`om`.`OperationModel_id` = `c`.`OperationModel_id`))) left join `dimensions` `d` on((`d`.`Dimensions_id` = `c`.`Dimensions_id`))) left join `employeesnumber` `e` on((`e`.`EmployeesNumber_id` = `c`.`EmployeesNumber_id`)));

#
# Source for view vw_invoice
#

DROP VIEW IF EXISTS `vw_invoice`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_invoice` AS select `invoice`.`Invoice_id` AS `Invoice_id`,`invoice`.`Invoice_number` AS `Invoice_number`,`invoice`.`Invoice_State` AS `Invoice_State`,`invoice`.`Recommended_id` AS `Recommended_id`,`invoice`.`Invoice_cost` AS `Invoice_cost`,`invoice`.`Invoice_guarantee` AS `Invoice_guarantee`,`invoice`.`Invoice_paymentType` AS `Invoice_paymentType`,`invoice`.`Invoice_startT` AS `Invoice_startT`,`invoice`.`Invoice_money` AS `Invoice_money`,`invoice`.`Invoice_paymentT` AS `Invoice_paymentT`,`invoice`.`Invoice_endT` AS `Invoice_endT`,`invoice`.`Invoice_BmoneyType` AS `Invoice_BmoneyType`,`invoice`.`Invoice_BmoneyT` AS `Invoice_BmoneyT`,`invoice`.`Invoice_Bmoney` AS `Invoice_Bmoney`,`invoice`.`Invoice_delayD` AS `Invoice_delayD`,`invoice`.`User_id` AS `User_id`,`invoice`.`Comment` AS `Comment`,`invoice`.`Invoice_WorkDate` AS `Invoice_WorkDate`,`orders`.`Order_NO` AS `Order_NO`,`client`.`Client_nameE` AS `Client_nameE`,`client`.`Client_name` AS `Client_name`,`candidate`.`Candidate_name` AS `Candidate_name`,`orders`.`Order_positionN` AS `Order_positionN`,`city`.`City_name` AS `City_name`,`users`.`User_realName` AS `User_realName`,`users_1`.`User_realName` AS `User_realName1` from (((((((`invoice` join `recommended` on((`invoice`.`Recommended_id` = `recommended`.`Recommended_Id`))) join `orders` on((`recommended`.`Order_id` = `orders`.`Order_id`))) join `client` on((`orders`.`Client_id` = `client`.`Client_id`))) join `candidate` on((`recommended`.`Candidate_id` = `candidate`.`Candidate_id`))) join `city` on((`orders`.`City_id` = `city`.`City_id`))) join `users` on((`invoice`.`User_id` = `users`.`User_id`))) join `users` `users_1` on((`orders`.`User_id` = `users_1`.`User_id`)));

#
# Source for view vw_order
#

DROP VIEW IF EXISTS `vw_order`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_order` AS select `c`.`Client_name` AS `client_name`,`u`.`User_realName` AS `user_realname`,`city`.`City_name` AS `city_name`,`d`.`Degree_Name` AS `degree_name`,`rm`.`Recruitment_Name` AS `Recruitment_name`,`t`.`Trade_name` AS `trade_name`,`j`.`JobsDetail_name` AS `jobsdetail_name`,`n`.`Nationality_name` AS `Order_reportN1name`,`n`.`Nationality_name` AS `Order_indirectN1name`,`os`.`Order_State_Name` AS `Order_State_Name`,`o`.`Order_id` AS `Order_id`,`o`.`Order_NO` AS `Order_NO`,`o`.`Client_id` AS `Client_id`,`o`.`User_id` AS `User_id`,`o`.`Order_Stime` AS `Order_Stime`,`o`.`City_id` AS `City_id`,`o`.`Order_positionN` AS `Order_positionN`,`o`.`Order_positionType` AS `Order_positionType`,`o`.`Order_joinN` AS `Order_joinN`,`o`.`Order_officeT` AS `Order_officeT`,`o`.`Order_salary` AS `Order_salary`,`o`.`Order_salaryS` AS `Order_salaryS`,`o`.`Degree_id` AS `Degree_id`,`o`.`Order_Language` AS `Order_Language`,`o`.`Order_languageL` AS `Order_languageL`,`o`.`ForeignLanguage` AS `ForeignLanguage`,`o`.`Order_compendium` AS `Order_compendium`,`o`.`Order_reportN` AS `Order_reportN`,`o`.`Order_reportN1` AS `Order_reportN1`,`o`.`Order_manageS` AS `Order_manageS`,`o`.`Order_indirectN` AS `Order_indirectN`,`o`.`Order_indirectN1` AS `Order_indirectN1`,`o`.`Order_indirectS` AS `Order_indirectS`,`o`.`Order_subordinateN` AS `Order_subordinateN`,`o`.`Order_equivalentN` AS `Order_equivalentN`,`o`.`Order_equivalentP` AS `Order_equivalentP`,`o`.`Order_turnover` AS `Order_turnover`,`o`.`Order_headcount` AS `Order_headcount`,`o`.`Order_share` AS `Order_share`,`o`.`Order_candidate` AS `Order_candidate`,`o`.`Order_candidateC` AS `Order_candidateC`,`o`.`Recruitment_id` AS `Recruitment_id`,`o`.`Order_instrument` AS `Order_instrument`,`o`.`Order_allopatry` AS `Order_allopatry`,`o`.`Order_preference` AS `Order_preference`,`o`.`Order_company` AS `Order_company`,`o`.`Order_promotion` AS `Order_promotion`,`o`.`Order_Interview1` AS `Order_Interview1`,`o`.`Order_Interview2` AS `Order_Interview2`,`o`.`Order_Interview3` AS `Order_Interview3`,`o`.`Order_Interview4` AS `Order_Interview4`,`o`.`Order_written` AS `Order_written`,`o`.`Order_InterviewT` AS `Order_InterviewT`,`o`.`Order_decision` AS `Order_decision`,`o`.`Order_condition` AS `Order_condition`,`o`.`Order_InterviewADD` AS `Order_InterviewADD`,`o`.`Order_Pdescribe` AS `Order_Pdescribe`,`o`.`comment` AS `comment`,`o`.`Position_Duty1` AS `Position_Duty1`,`o`.`Position_Duty2` AS `Position_Duty2`,`o`.`Position_Duty3` AS `Position_Duty3`,`o`.`Position_Duty4` AS `Position_Duty4`,`o`.`Position_Duty5` AS `Position_Duty5`,`o`.`Position_Duty6` AS `Position_Duty6`,`o`.`JobsDetailID` AS `JobsDetailID`,`o`.`Trade_ID` AS `Trade_ID`,`o`.`Experience` AS `Experience`,`o`.`Education_major` AS `Education_major`,`o`.`Evaluate_Staff1` AS `Evaluate_Staff1`,`o`.`Evaluate_Staff2` AS `Evaluate_Staff2`,`o`.`Evaluate_Staff3` AS `Evaluate_Staff3`,`o`.`Evaluate_Staff4` AS `Evaluate_Staff4`,`o`.`Client_Selling1` AS `Client_Selling1`,`o`.`Client_Selling2` AS `Client_Selling2`,`o`.`Client_Selling3` AS `Client_Selling3`,`o`.`Client_Selling4` AS `Client_Selling4`,`o`.`Client_Selling5` AS `Client_Selling5`,`o`.`Position_Selling1` AS `Position_Selling1`,`o`.`Position_Selling2` AS `Position_Selling2`,`o`.`Position_Selling3` AS `Position_Selling3`,`o`.`Position_Selling4` AS `Position_Selling4`,`o`.`Position_Selling5` AS `Position_Selling5`,`o`.`Position_Difficulty1` AS `Position_Difficulty1`,`o`.`Position_Difficulty2` AS `Position_Difficulty2`,`o`.`Position_Difficulty3` AS `Position_Difficulty3`,`o`.`Position_Difficulty4` AS `Position_Difficulty4`,`o`.`Position_Difficulty5` AS `Position_Difficulty5`,`o`.`Position_Challenge1` AS `Position_Challenge1`,`o`.`Position_Challenge2` AS `Position_Challenge2`,`o`.`Position_Challenge3` AS `Position_Challenge3`,`o`.`Position_Challenge4` AS `Position_Challenge4`,`o`.`Position_Challenge5` AS `Position_Challenge5`,`o`.`Order_State_ID` AS `Order_State_ID` from ((((((((((`orders` `o` left join `client` `c` on((`c`.`Client_id` = `o`.`Client_id`))) left join `users` `u` on((`u`.`User_id` = `o`.`User_id`))) left join `city` on((`city`.`City_id` = `o`.`City_id`))) left join `degree` `d` on((`d`.`Degree_ID` = `o`.`Degree_id`))) left join `trade` `t` on((`t`.`Trade_id` = `o`.`Trade_ID`))) left join `jobsdetail` `j` on((`j`.`JobsDetail_id` = `o`.`JobsDetailID`))) left join `nationality` `n` on((`n`.`Nationality_id` = `o`.`Order_reportN1`))) left join `nationality` `n1` on((`n`.`Nationality_id` = `o`.`Order_indirectN1`))) left join `recruitment` `rm` on((`rm`.`Recruitment_Id` = `o`.`Recruitment_id`))) left join `order_state` `os` on((`os`.`Order_State_Id` = `o`.`Order_State_ID`)));

#
# Source for view vw_recommended
#

DROP VIEW IF EXISTS `vw_recommended`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_recommended` AS select `recommended`.`Recommended_Id` AS `Recommended_Id`,`recommended`.`Order_id` AS `Order_id`,`recommended`.`Users_ID` AS `Users_ID`,`recommended`.`Candidate_id` AS `Candidate_id`,`recommended`.`Recommended_State_ID` AS `Recommended_State_ID`,`recommended`.`Recommended_Order` AS `Recommended_Order`,`recommended`.`Advantages` AS `Advantages`,`recommended`.`Inferior` AS `Inferior`,`recommended`.`Recommended_Time` AS `Recommended_Time`,`recommended_state`.`Recommended_State_Name` AS `Recommended_State_Name`,`users`.`User_realName` AS `User_realName`,`candidate`.`Candidate_name` AS `Candidate_name`,`client`.`Client_id` AS `Client_id`,`client`.`Client_name` AS `Client_name`,`client`.`Client_nameE` AS `Client_nameE`,`orders`.`Order_positionN` AS `Order_positionN` from (((((`recommended` join `recommended_state` on((`recommended`.`Recommended_State_ID` = `recommended_state`.`Recommended_State_Id`))) join `candidate` on((`recommended`.`Candidate_id` = `candidate`.`Candidate_id`))) join `orders` on((`recommended`.`Order_id` = `orders`.`Order_id`))) join `users` on((`candidate`.`User_id` = `users`.`User_id`))) join `client` on((`orders`.`Client_id` = `client`.`Client_id`)));

#
# Source for view vw_resume_candidate
#

DROP VIEW IF EXISTS `vw_resume_candidate`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_resume_candidate` AS select `r`.`Resume_id` AS `Resume_id`,`r`.`Candidate_id` AS `Candidate_id`,`r`.`Resume_ShowName` AS `Resume_ShowName`,`r`.`Resume_language` AS `Resume_language`,`r`.`City_id` AS `City_id`,`r`.`City_id1` AS `City_id1`,`r`.`JobsDetail_idArr` AS `JobsDetail_idArr`,`r`.`Trade_IDArr` AS `Trade_IDArr`,`r`.`Experience` AS `Experience`,`r`.`Resume_annual` AS `Resume_annual`,`r`.`Resume_expectation` AS `Resume_expectation`,`r`.`Resume_overseas` AS `Resume_overseas`,`r`.`Resume_evaluate` AS `Resume_evaluate`,`r`.`update_time` AS `update_time`,`c`.`Candidate_name` AS `Candidate_name`,`c`.`Candidate_sex` AS `Candidate_sex`,`c`.`Candidate_birthday` AS `Candidate_birthday`,`c`.`Mingz_id` AS `Mingz_id`,`c`.`Nationality_id` AS `Nationality_id`,`c`.`Candidate_marriage` AS `Candidate_marriage`,`c`.`Candidate_papersT` AS `Candidate_papersT`,`c`.`Candidate_papersN` AS `Candidate_papersN`,`c`.`registered` AS `registered`,`c`.`Candidate_method1` AS `Candidate_method1`,`c`.`Candidate_method2` AS `Candidate_method2`,`c`.`Candidate_telephone` AS `Candidate_telephone`,`c`.`Candidate_Email` AS `Candidate_Email`,`c`.`recommend_mode` AS `recommend_mode`,`c`.`incumbency_mode` AS `incumbency_mode`,`c`.`User_id` AS `User_id` from (`resume` `r` join `candidate` `c` on((`r`.`Candidate_id` = `c`.`Candidate_id`)));

#
# Source for procedure Pro_DelTeam
#

DROP PROCEDURE IF EXISTS `Pro_DelTeam`;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pro_DelTeam`(`@TeamID` int(11))
BEGIN
update users set User_superior_id = 0 where User_superior_id =@TeamID;
delete from team where Team_ID = 5;
END;


#
#  Foreign keys for table invoice
#

ALTER TABLE `invoice`
ADD CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`Invoice_State`) REFERENCES `invoicestate` (`InvoiceState_Id`),
ADD CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`Recommended_id`) REFERENCES `recommended` (`Recommended_Id`),
ADD CONSTRAINT `invoice_ibfk_3` FOREIGN KEY (`User_id`) REFERENCES `users` (`User_id`);

#
#  Foreign keys for table orders
#

ALTER TABLE `orders`
ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`Client_id`) REFERENCES `client` (`Client_id`),
ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`Order_State_ID`) REFERENCES `order_state` (`Order_State_Id`),
ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`User_id`) REFERENCES `users` (`User_id`);

#
#  Foreign keys for table recruitment_quantity
#

ALTER TABLE `recruitment_quantity`
ADD CONSTRAINT `FK_Recruitmeity_Client_id` FOREIGN KEY (`Client_id`) REFERENCES `client` (`Client_id`);

#
#  Foreign keys for table resume
#

ALTER TABLE `resume`
ADD CONSTRAINT `FK_Resume_Candidate_id` FOREIGN KEY (`Candidate_id`) REFERENCES `candidate` (`Candidate_id`);

#
#  Foreign keys for table weeklyc_details
#

ALTER TABLE `weeklyc_details`
ADD CONSTRAINT `FK_WeeklyC_Details_WC_id` FOREIGN KEY (`WC_id`) REFERENCES `wekkly_consultant` (`WC_id`);

#
#  Foreign keys for table work_experience
#

ALTER TABLE `work_experience`
ADD CONSTRAINT `FK_Work_Expence_Resume_id` FOREIGN KEY (`Resume_id`) REFERENCES `resume` (`Resume_id`);


/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
