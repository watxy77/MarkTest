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
  `Candidate_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '编号',
  `Candidate_name` varchar(200) DEFAULT NULL COMMENT '姓名',
  `Candidate_sex` int(2) DEFAULT NULL COMMENT '性别',
  `Candidate_birthday` date DEFAULT NULL COMMENT '出生日期',
  `Mingz_id` int(11) DEFAULT NULL COMMENT '名族编号',
  `Nationality_id` int(11) DEFAULT NULL COMMENT '国籍编号',
  `Candidate_marriage` varchar(200) DEFAULT NULL COMMENT '婚姻状况',
  `Candidate_papersT` varchar(200) DEFAULT NULL COMMENT '证件类型',
  `Candidate_papersN` varchar(200) DEFAULT NULL COMMENT '证件号码',
  `registered` varchar(200) DEFAULT NULL COMMENT '户口所在地',
  `Candidate_method1` varchar(255) DEFAULT NULL COMMENT '联系方式1',
  `Candidate_method2` varchar(255) DEFAULT NULL COMMENT '联系方式2',
  `Candidate_telephone` varchar(200) DEFAULT NULL COMMENT '固定电话',
  `Candidate_Email` varchar(200) DEFAULT NULL COMMENT '电子邮箱',
  `recommend_mode` varchar(200) DEFAULT NULL COMMENT '推荐状态',
  `incumbency_mode` varchar(200) DEFAULT NULL COMMENT '在职状态',
  `User_id` int(11) DEFAULT NULL COMMENT '顾问编号',
  `Comment` varchar(200) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Candidate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=gb2312 COMMENT='候选人';

#
# Dumping data for table candidate
#

/*!40000 ALTER TABLE `candidate` DISABLE KEYS */;
INSERT INTO `candidate` VALUES (1,'曾盟桓',0,'2010-11-05',0,0,'未知','身份证','123','3123','12312','123','12312','1231','未推荐','在职',1,'123123');
INSERT INTO `candidate` VALUES (2,'12312',0,'2010-11-05',0,0,'未知','身份证','123','3123','12312','123','12312','1231','未推荐','在职',1,'123123');
INSERT INTO `candidate` VALUES (3,'werwer',0,'2010-11-05',0,0,'未知','身份证','','werwe','1231','123123','12312','12312','未推荐','在职',2,'123');
INSERT INTO `candidate` VALUES (4,'werwer',0,'2010-11-05',0,0,'未知','身份证','','werwe','1231','123123','12312','12312','未推荐','在职',2,'123');
INSERT INTO `candidate` VALUES (5,'魏建楠',0,'2010-11-07',1,1,'未知','身份证','1231','123123123','123','123123','2312','12','未推荐','离职',1,'123123');
INSERT INTO `candidate` VALUES (6,'魏建楠',1,'2010-11-07',1,1,'未知','身份证','1231','123123123','123','123123','2312','12','未推荐','离职',1,'123123');
INSERT INTO `candidate` VALUES (7,'魏建楠',0,'2010-11-07',1,1,'未知','身份证','123','12312','123','12','123','123','未推荐','离职',2,'123');
INSERT INTO `candidate` VALUES (8,'123123',0,'2010-11-07',1,1,'未知','身份证','123','123','123','123','123','123','未推荐','离职',2,'123');
INSERT INTO `candidate` VALUES (9,'qweqwe',0,'2010-11-07',1,1,'未知','身份证','123123','qqwe','123123','123','123123','123123','未推荐','离职',1,'123');
INSERT INTO `candidate` VALUES (10,'123123',1,'2010-11-18',1,1,NULL,'身份证','','','123','2312','123','123','未推荐','离职',1,'23123');
INSERT INTO `candidate` VALUES (11,'1231',1,'2010-11-18',1,1,'未知','身份证','','123123','','123','','123','未推荐','离职',1,'123');
INSERT INTO `candidate` VALUES (12,'123',1,'2010-11-18',1,1,'未婚','身份证','123','123','123','123','123','123','未推荐','离职',1,'123');
INSERT INTO `candidate` VALUES (13,'刁刁',1,'2010-12-01',1,1,'未婚','身份证','','','','','','','未推荐',NULL,1,'?\t有着较为丰富的理论和财务与会计管理实践工作经验；\r\n?\t具有扎实的会计处理及财务管理、税务筹化、理财及投资分析、内部控制实务操作水平；\r\n?\t熟悉国家的各项税收、财务会计法律、法规和相关经济法，熟悉银行融资业务；\r\n?\t具有较强的组织协调能力、合作与沟通能力；\r\n?\t自信、办事果断、思维严谨、富有团队、积极实干精神。\r\n');
INSERT INTO `candidate` VALUES (14,'123123',1,'2010-12-01',1,1,NULL,'身份证','','123123','','','','','未推荐','离职',1,'');
INSERT INTO `candidate` VALUES (15,'123',1,'2010-12-01',1,1,'未知','身份证','123123','123','123','123','123','123','未推荐','在职',1,'');
/*!40000 ALTER TABLE `candidate` ENABLE KEYS */;

#
# Source for table city
#

DROP TABLE IF EXISTS `city`;
CREATE TABLE `city` (
  `City_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '城市编号',
  `City_name` varchar(200) DEFAULT NULL COMMENT '城市名称',
  `postcode` varchar(11) DEFAULT NULL COMMENT '城市邮编',
  `Province_id` int(6) DEFAULT NULL COMMENT '省份编号',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`City_id`),
  KEY `FK_City_Province_id` (`Province_id`)
) ENGINE=InnoDB AUTO_INCREMENT=346 DEFAULT CHARSET=gb2312 COMMENT='城市';

#
# Dumping data for table city
#

/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'北京市','100000',1,NULL);
INSERT INTO `city` VALUES (2,'天津市','100000',2,NULL);
INSERT INTO `city` VALUES (3,'石家庄市','50000',3,NULL);
INSERT INTO `city` VALUES (4,'唐山市','63000',3,NULL);
INSERT INTO `city` VALUES (5,'秦皇岛市','66000',3,NULL);
INSERT INTO `city` VALUES (6,'邯郸市','56000',3,NULL);
INSERT INTO `city` VALUES (7,'邢台市','54000',3,NULL);
INSERT INTO `city` VALUES (8,'保定市','71000',3,NULL);
INSERT INTO `city` VALUES (9,'张家口市','75000',3,NULL);
INSERT INTO `city` VALUES (10,'承德市','67000',3,NULL);
INSERT INTO `city` VALUES (11,'沧州市','61000',3,NULL);
INSERT INTO `city` VALUES (12,'廊坊市','65000',3,NULL);
INSERT INTO `city` VALUES (13,'衡水市','53000',3,NULL);
INSERT INTO `city` VALUES (14,'太原市','30000',4,NULL);
INSERT INTO `city` VALUES (15,'大同市','37000',4,NULL);
INSERT INTO `city` VALUES (16,'阳泉市','45000',4,NULL);
INSERT INTO `city` VALUES (17,'长治市','46000',4,NULL);
INSERT INTO `city` VALUES (18,'晋城市','48000',4,NULL);
INSERT INTO `city` VALUES (19,'朔州市','36000',4,NULL);
INSERT INTO `city` VALUES (20,'晋中市','30600',4,NULL);
INSERT INTO `city` VALUES (21,'运城市','44000',4,NULL);
INSERT INTO `city` VALUES (22,'忻州市','34000',4,NULL);
INSERT INTO `city` VALUES (23,'临汾市','41000',4,NULL);
INSERT INTO `city` VALUES (24,'吕梁市','30500',4,NULL);
INSERT INTO `city` VALUES (25,'呼和浩特市','10000',5,NULL);
INSERT INTO `city` VALUES (26,'包头市','14000',5,NULL);
INSERT INTO `city` VALUES (27,'乌海市','16000',5,NULL);
INSERT INTO `city` VALUES (28,'赤峰市','24000',5,NULL);
INSERT INTO `city` VALUES (29,'通辽市','28000',5,NULL);
INSERT INTO `city` VALUES (30,'鄂尔多斯市','10300',5,NULL);
INSERT INTO `city` VALUES (31,'呼伦贝尔市','21000',5,NULL);
INSERT INTO `city` VALUES (32,'巴彦淖尔市','14400',5,NULL);
INSERT INTO `city` VALUES (33,'乌兰察布市','11800',5,NULL);
INSERT INTO `city` VALUES (34,'兴安盟','137500',5,NULL);
INSERT INTO `city` VALUES (35,'锡林郭勒盟','11100',5,NULL);
INSERT INTO `city` VALUES (36,'阿拉善盟','16000',5,NULL);
INSERT INTO `city` VALUES (37,'沈阳市','110000',6,NULL);
INSERT INTO `city` VALUES (38,'大连市','116000',6,NULL);
INSERT INTO `city` VALUES (39,'鞍山市','114000',6,NULL);
INSERT INTO `city` VALUES (40,'抚顺市','113000',6,NULL);
INSERT INTO `city` VALUES (41,'本溪市','117000',6,NULL);
INSERT INTO `city` VALUES (42,'丹东市','118000',6,NULL);
INSERT INTO `city` VALUES (43,'锦州市','121000',6,NULL);
INSERT INTO `city` VALUES (44,'营口市','115000',6,NULL);
INSERT INTO `city` VALUES (45,'阜新市','123000',6,NULL);
INSERT INTO `city` VALUES (46,'辽阳市','111000',6,NULL);
INSERT INTO `city` VALUES (47,'盘锦市','124000',6,NULL);
INSERT INTO `city` VALUES (48,'铁岭市','112000',6,NULL);
INSERT INTO `city` VALUES (49,'朝阳市','122000',6,NULL);
INSERT INTO `city` VALUES (50,'葫芦岛市','125000',6,NULL);
INSERT INTO `city` VALUES (51,'长春市','130000',7,NULL);
INSERT INTO `city` VALUES (52,'吉林市','132000',7,NULL);
INSERT INTO `city` VALUES (53,'四平市','136000',7,NULL);
INSERT INTO `city` VALUES (54,'辽源市','136200',7,NULL);
INSERT INTO `city` VALUES (55,'通化市','134000',7,NULL);
INSERT INTO `city` VALUES (56,'白山市','134300',7,NULL);
INSERT INTO `city` VALUES (57,'松原市','131100',7,NULL);
INSERT INTO `city` VALUES (58,'白城市','137000',7,NULL);
INSERT INTO `city` VALUES (59,'延边朝鲜族自治州','133000',7,NULL);
INSERT INTO `city` VALUES (60,'哈尔滨市','150000',8,NULL);
INSERT INTO `city` VALUES (61,'齐齐哈尔市','161000',8,NULL);
INSERT INTO `city` VALUES (62,'鸡西市','158100',8,NULL);
INSERT INTO `city` VALUES (63,'鹤岗市','154100',8,NULL);
INSERT INTO `city` VALUES (64,'双鸭山市','155100',8,NULL);
INSERT INTO `city` VALUES (65,'大庆市','163000',8,NULL);
INSERT INTO `city` VALUES (66,'伊春市','152300',8,NULL);
INSERT INTO `city` VALUES (67,'佳木斯市','154000',8,NULL);
INSERT INTO `city` VALUES (68,'七台河市','154600',8,NULL);
INSERT INTO `city` VALUES (69,'牡丹江市','157000',8,NULL);
INSERT INTO `city` VALUES (70,'黑河市','164300',8,NULL);
INSERT INTO `city` VALUES (71,'绥化市','152000',8,NULL);
INSERT INTO `city` VALUES (72,'大兴安岭地区','165000',8,NULL);
INSERT INTO `city` VALUES (73,'上海市','200000',9,NULL);
INSERT INTO `city` VALUES (74,'南京市','210000',10,NULL);
INSERT INTO `city` VALUES (75,'无锡市','214000',10,NULL);
INSERT INTO `city` VALUES (76,'徐州市','221000',10,NULL);
INSERT INTO `city` VALUES (77,'常州市','213000',10,NULL);
INSERT INTO `city` VALUES (78,'苏州市','215000',10,NULL);
INSERT INTO `city` VALUES (79,'南通市','226000',10,NULL);
INSERT INTO `city` VALUES (80,'连云港市','222000',10,NULL);
INSERT INTO `city` VALUES (81,'淮安市','223200',10,NULL);
INSERT INTO `city` VALUES (82,'盐城市','224000',10,NULL);
INSERT INTO `city` VALUES (83,'扬州市','225000',10,NULL);
INSERT INTO `city` VALUES (84,'镇江市','212000',10,NULL);
INSERT INTO `city` VALUES (85,'泰州市','225300',10,NULL);
INSERT INTO `city` VALUES (86,'宿迁市','223800',10,NULL);
INSERT INTO `city` VALUES (87,'杭州市','310000',11,NULL);
INSERT INTO `city` VALUES (88,'宁波市','315000',11,NULL);
INSERT INTO `city` VALUES (89,'温州市','325000',11,NULL);
INSERT INTO `city` VALUES (90,'嘉兴市','314000',11,NULL);
INSERT INTO `city` VALUES (91,'湖州市','313000',11,NULL);
INSERT INTO `city` VALUES (92,'绍兴市','312000',11,NULL);
INSERT INTO `city` VALUES (93,'金华市','321000',11,NULL);
INSERT INTO `city` VALUES (94,'衢州市','324000',11,NULL);
INSERT INTO `city` VALUES (95,'舟山市','316000',11,NULL);
INSERT INTO `city` VALUES (96,'台州市','318000',11,NULL);
INSERT INTO `city` VALUES (97,'丽水市','323000',11,NULL);
INSERT INTO `city` VALUES (98,'合肥市','230000',12,NULL);
INSERT INTO `city` VALUES (99,'芜湖市','241000',12,NULL);
INSERT INTO `city` VALUES (100,'蚌埠市','233000',12,NULL);
INSERT INTO `city` VALUES (101,'淮南市','232000',12,NULL);
INSERT INTO `city` VALUES (102,'马鞍山市','243000',12,NULL);
INSERT INTO `city` VALUES (103,'淮北市','235000',12,NULL);
INSERT INTO `city` VALUES (104,'铜陵市','244000',12,NULL);
INSERT INTO `city` VALUES (105,'安庆市','246000',12,NULL);
INSERT INTO `city` VALUES (106,'黄山市','242700',12,NULL);
INSERT INTO `city` VALUES (107,'滁州市','239000',12,NULL);
INSERT INTO `city` VALUES (108,'阜阳市','236100',12,NULL);
INSERT INTO `city` VALUES (109,'宿州市','234100',12,NULL);
INSERT INTO `city` VALUES (110,'巢湖市','238000',12,NULL);
INSERT INTO `city` VALUES (111,'六安市','237000',12,NULL);
INSERT INTO `city` VALUES (112,'亳州市','236800',12,NULL);
INSERT INTO `city` VALUES (113,'池州市','247100',12,NULL);
INSERT INTO `city` VALUES (114,'宣城市','366000',12,NULL);
INSERT INTO `city` VALUES (115,'福州市','350000',13,NULL);
INSERT INTO `city` VALUES (116,'厦门市','361000',13,NULL);
INSERT INTO `city` VALUES (117,'莆田市','351100',13,NULL);
INSERT INTO `city` VALUES (118,'三明市','365000',13,NULL);
INSERT INTO `city` VALUES (119,'泉州市','362000',13,NULL);
INSERT INTO `city` VALUES (120,'漳州市','363000',13,NULL);
INSERT INTO `city` VALUES (121,'南平市','353000',13,NULL);
INSERT INTO `city` VALUES (122,'龙岩市','364000',13,NULL);
INSERT INTO `city` VALUES (123,'宁德市','352100',13,NULL);
INSERT INTO `city` VALUES (124,'南昌市','330000',14,NULL);
INSERT INTO `city` VALUES (125,'景德镇市','333000',14,NULL);
INSERT INTO `city` VALUES (126,'萍乡市','337000',14,NULL);
INSERT INTO `city` VALUES (127,'九江市','332000',14,NULL);
INSERT INTO `city` VALUES (128,'新余市','338000',14,NULL);
INSERT INTO `city` VALUES (129,'鹰潭市','335000',14,NULL);
INSERT INTO `city` VALUES (130,'赣州市','341000',14,NULL);
INSERT INTO `city` VALUES (131,'吉安市','343000',14,NULL);
INSERT INTO `city` VALUES (132,'宜春市','336000',14,NULL);
INSERT INTO `city` VALUES (133,'抚州市','332900',14,NULL);
INSERT INTO `city` VALUES (134,'上饶市','334000',14,NULL);
INSERT INTO `city` VALUES (135,'济南市','250000',15,NULL);
INSERT INTO `city` VALUES (136,'青岛市','266000',15,NULL);
INSERT INTO `city` VALUES (137,'淄博市','255000',15,NULL);
INSERT INTO `city` VALUES (138,'枣庄市','277100',15,NULL);
INSERT INTO `city` VALUES (139,'东营市','257000',15,NULL);
INSERT INTO `city` VALUES (140,'烟台市','264000',15,NULL);
INSERT INTO `city` VALUES (141,'潍坊市','261000',15,NULL);
INSERT INTO `city` VALUES (142,'济宁市','272100',15,NULL);
INSERT INTO `city` VALUES (143,'泰安市','271000',15,NULL);
INSERT INTO `city` VALUES (144,'威海市','265700',15,NULL);
INSERT INTO `city` VALUES (145,'日照市','276800',15,NULL);
INSERT INTO `city` VALUES (146,'莱芜市','271100',15,NULL);
INSERT INTO `city` VALUES (147,'临沂市','276000',15,NULL);
INSERT INTO `city` VALUES (148,'德州市','253000',15,NULL);
INSERT INTO `city` VALUES (149,'聊城市','252000',15,NULL);
INSERT INTO `city` VALUES (150,'滨州市','256600',15,NULL);
INSERT INTO `city` VALUES (151,'荷泽市','255000',15,NULL);
INSERT INTO `city` VALUES (152,'郑州市','450000',16,NULL);
INSERT INTO `city` VALUES (153,'开封市','475000',16,NULL);
INSERT INTO `city` VALUES (154,'洛阳市','471000',16,NULL);
INSERT INTO `city` VALUES (155,'平顶山市','467000',16,NULL);
INSERT INTO `city` VALUES (156,'安阳市','454900',16,NULL);
INSERT INTO `city` VALUES (157,'鹤壁市','456600',16,NULL);
INSERT INTO `city` VALUES (158,'新乡市','453000',16,NULL);
INSERT INTO `city` VALUES (159,'焦作市','454100',16,NULL);
INSERT INTO `city` VALUES (160,'濮阳市','457000',16,NULL);
INSERT INTO `city` VALUES (161,'许昌市','461000',16,NULL);
INSERT INTO `city` VALUES (162,'漯河市','462000',16,NULL);
INSERT INTO `city` VALUES (163,'三门峡市','472000',16,NULL);
INSERT INTO `city` VALUES (164,'南阳市','473000',16,NULL);
INSERT INTO `city` VALUES (165,'商丘市','476000',16,NULL);
INSERT INTO `city` VALUES (166,'信阳市','464000',16,NULL);
INSERT INTO `city` VALUES (167,'周口市','466000',16,NULL);
INSERT INTO `city` VALUES (168,'驻马店市','463000',16,NULL);
INSERT INTO `city` VALUES (169,'武汉市','430000',17,NULL);
INSERT INTO `city` VALUES (170,'黄石市','435000',17,NULL);
INSERT INTO `city` VALUES (171,'十堰市','442000',17,NULL);
INSERT INTO `city` VALUES (172,'宜昌市','443000',17,NULL);
INSERT INTO `city` VALUES (173,'襄樊市','441000',17,NULL);
INSERT INTO `city` VALUES (174,'鄂州市','436000',17,NULL);
INSERT INTO `city` VALUES (175,'荆门市','448000',17,NULL);
INSERT INTO `city` VALUES (176,'孝感市','432100',17,NULL);
INSERT INTO `city` VALUES (177,'荆州市','434000',17,NULL);
INSERT INTO `city` VALUES (178,'黄冈市','438000',17,NULL);
INSERT INTO `city` VALUES (179,'咸宁市','437000',17,NULL);
INSERT INTO `city` VALUES (180,'随州市','441300',17,NULL);
INSERT INTO `city` VALUES (181,'恩施土家族苗族自治州','445000',17,NULL);
INSERT INTO `city` VALUES (182,'神农架','442400',17,NULL);
INSERT INTO `city` VALUES (183,'长沙市','410000',18,NULL);
INSERT INTO `city` VALUES (184,'株洲市','412000',18,NULL);
INSERT INTO `city` VALUES (185,'湘潭市','411100',18,NULL);
INSERT INTO `city` VALUES (186,'衡阳市','421000',18,NULL);
INSERT INTO `city` VALUES (187,'邵阳市','422000',18,NULL);
INSERT INTO `city` VALUES (188,'岳阳市','414000',18,NULL);
INSERT INTO `city` VALUES (189,'常德市','415000',18,NULL);
INSERT INTO `city` VALUES (190,'张家界市','427000',18,NULL);
INSERT INTO `city` VALUES (191,'益阳市','413000',18,NULL);
INSERT INTO `city` VALUES (192,'郴州市','423000',18,NULL);
INSERT INTO `city` VALUES (193,'永州市','425000',18,NULL);
INSERT INTO `city` VALUES (194,'怀化市','418000',18,NULL);
INSERT INTO `city` VALUES (195,'娄底市','417000',18,NULL);
INSERT INTO `city` VALUES (196,'湘西土家族苗族自治州','416000',18,NULL);
INSERT INTO `city` VALUES (197,'广州市','510000',19,NULL);
INSERT INTO `city` VALUES (198,'韶关市','521000',19,NULL);
INSERT INTO `city` VALUES (199,'深圳市','518000',19,NULL);
INSERT INTO `city` VALUES (200,'珠海市','519000',19,NULL);
INSERT INTO `city` VALUES (201,'汕头市','515000',19,NULL);
INSERT INTO `city` VALUES (202,'佛山市','528000',19,NULL);
INSERT INTO `city` VALUES (203,'江门市','529000',19,NULL);
INSERT INTO `city` VALUES (204,'湛江市','524000',19,NULL);
INSERT INTO `city` VALUES (205,'茂名市','525000',19,NULL);
INSERT INTO `city` VALUES (206,'肇庆市','526000',19,NULL);
INSERT INTO `city` VALUES (207,'惠州市','516000',19,NULL);
INSERT INTO `city` VALUES (208,'梅州市','514000',19,NULL);
INSERT INTO `city` VALUES (209,'汕尾市','516600',19,NULL);
INSERT INTO `city` VALUES (210,'河源市','517000',19,NULL);
INSERT INTO `city` VALUES (211,'阳江市','529500',19,NULL);
INSERT INTO `city` VALUES (212,'清远市','511500',19,NULL);
INSERT INTO `city` VALUES (213,'东莞市','511700',19,NULL);
INSERT INTO `city` VALUES (214,'中山市','528400',19,NULL);
INSERT INTO `city` VALUES (215,'潮州市','515600',19,NULL);
INSERT INTO `city` VALUES (216,'揭阳市','522000',19,NULL);
INSERT INTO `city` VALUES (217,'云浮市','527300',19,NULL);
INSERT INTO `city` VALUES (218,'南宁市','530000',20,NULL);
INSERT INTO `city` VALUES (219,'柳州市','545000',20,NULL);
INSERT INTO `city` VALUES (220,'桂林市','541000',20,NULL);
INSERT INTO `city` VALUES (221,'梧州市','543000',20,NULL);
INSERT INTO `city` VALUES (222,'北海市','536000',20,NULL);
INSERT INTO `city` VALUES (223,'防城港市','538000',20,NULL);
INSERT INTO `city` VALUES (224,'钦州市','535000',20,NULL);
INSERT INTO `city` VALUES (225,'贵港市','537100',20,NULL);
INSERT INTO `city` VALUES (226,'玉林市','537000',20,NULL);
INSERT INTO `city` VALUES (227,'百色市','533000',20,NULL);
INSERT INTO `city` VALUES (228,'贺州市','542800',20,NULL);
INSERT INTO `city` VALUES (229,'河池市','547000',20,NULL);
INSERT INTO `city` VALUES (230,'来宾市','546100',20,NULL);
INSERT INTO `city` VALUES (231,'崇左市','532200',20,NULL);
INSERT INTO `city` VALUES (232,'海口市','570000',21,NULL);
INSERT INTO `city` VALUES (233,'三亚市','572000',21,NULL);
INSERT INTO `city` VALUES (234,'重庆市','400000',22,NULL);
INSERT INTO `city` VALUES (235,'成都市','610000',23,NULL);
INSERT INTO `city` VALUES (236,'自贡市','643000',23,NULL);
INSERT INTO `city` VALUES (237,'攀枝花市','617000',23,NULL);
INSERT INTO `city` VALUES (238,'泸州市','646100',23,NULL);
INSERT INTO `city` VALUES (239,'德阳市','618000',23,NULL);
INSERT INTO `city` VALUES (240,'绵阳市','621000',23,NULL);
INSERT INTO `city` VALUES (241,'广元市','628000',23,NULL);
INSERT INTO `city` VALUES (242,'遂宁市','629000',23,NULL);
INSERT INTO `city` VALUES (243,'内江市','641000',23,NULL);
INSERT INTO `city` VALUES (244,'乐山市','614000',23,NULL);
INSERT INTO `city` VALUES (245,'南充市','637000',23,NULL);
INSERT INTO `city` VALUES (246,'眉山市','612100',23,NULL);
INSERT INTO `city` VALUES (247,'宜宾市','644000',23,NULL);
INSERT INTO `city` VALUES (248,'广安市','638000',23,NULL);
INSERT INTO `city` VALUES (249,'达州市','635000',23,NULL);
INSERT INTO `city` VALUES (250,'雅安市','625000',23,NULL);
INSERT INTO `city` VALUES (251,'巴中市','635500',23,NULL);
INSERT INTO `city` VALUES (252,'资阳市','641300',23,NULL);
INSERT INTO `city` VALUES (253,'阿坝藏族羌族自治州','624600',23,NULL);
INSERT INTO `city` VALUES (254,'甘孜藏族自治州','626000',23,NULL);
INSERT INTO `city` VALUES (255,'凉山彝族自治州','615000',23,NULL);
INSERT INTO `city` VALUES (256,'贵阳市','55000',24,NULL);
INSERT INTO `city` VALUES (257,'六盘水市','553000',24,NULL);
INSERT INTO `city` VALUES (258,'遵义市','563000',24,NULL);
INSERT INTO `city` VALUES (259,'安顺市','561000',24,NULL);
INSERT INTO `city` VALUES (260,'铜仁地区','554300',24,NULL);
INSERT INTO `city` VALUES (261,'黔西南布依族苗族自治州','551500',24,NULL);
INSERT INTO `city` VALUES (262,'毕节地区','551700',24,NULL);
INSERT INTO `city` VALUES (263,'黔东南苗族侗族自治州','551500',24,NULL);
INSERT INTO `city` VALUES (264,'黔南布依族苗族自治州','550100',24,NULL);
INSERT INTO `city` VALUES (265,'昆明市','650000',25,NULL);
INSERT INTO `city` VALUES (266,'曲靖市','655000',25,NULL);
INSERT INTO `city` VALUES (267,'玉溪市','653100',25,NULL);
INSERT INTO `city` VALUES (268,'保山市','678000',25,NULL);
INSERT INTO `city` VALUES (269,'昭通市','657000',25,NULL);
INSERT INTO `city` VALUES (270,'丽江市','674100',25,NULL);
INSERT INTO `city` VALUES (271,'思茅市','665000',25,NULL);
INSERT INTO `city` VALUES (272,'临沧市','677000',25,NULL);
INSERT INTO `city` VALUES (273,'楚雄彝族自治州','675000',25,NULL);
INSERT INTO `city` VALUES (274,'红河哈尼族彝族自治州','654400',25,NULL);
INSERT INTO `city` VALUES (275,'文山壮族苗族自治州','663000',25,NULL);
INSERT INTO `city` VALUES (276,'西双版纳傣族自治州','666200',25,NULL);
INSERT INTO `city` VALUES (277,'大理白族自治州','671000',25,NULL);
INSERT INTO `city` VALUES (278,'德宏傣族景颇族自治州','678400',25,NULL);
INSERT INTO `city` VALUES (279,'怒江傈僳族自治州','671400',25,NULL);
INSERT INTO `city` VALUES (280,'迪庆藏族自治州','674400',25,NULL);
INSERT INTO `city` VALUES (281,'拉萨市','850000',26,NULL);
INSERT INTO `city` VALUES (282,'昌都地区','854000',26,NULL);
INSERT INTO `city` VALUES (283,'山南地区','856000',26,NULL);
INSERT INTO `city` VALUES (284,'日喀则地区','857000',26,NULL);
INSERT INTO `city` VALUES (285,'那曲地区','852000',26,NULL);
INSERT INTO `city` VALUES (286,'阿里地区','859100',26,NULL);
INSERT INTO `city` VALUES (287,'林芝地区','860100',26,NULL);
INSERT INTO `city` VALUES (288,'西安市','710000',27,NULL);
INSERT INTO `city` VALUES (289,'铜川市','727000',27,NULL);
INSERT INTO `city` VALUES (290,'宝鸡市','721000',27,NULL);
INSERT INTO `city` VALUES (291,'咸阳市','712000',27,NULL);
INSERT INTO `city` VALUES (292,'渭南市','714000',27,NULL);
INSERT INTO `city` VALUES (293,'延安市','716000',27,NULL);
INSERT INTO `city` VALUES (294,'汉中市','723000',27,NULL);
INSERT INTO `city` VALUES (295,'榆林市','719000',27,NULL);
INSERT INTO `city` VALUES (296,'安康市','725000',27,NULL);
INSERT INTO `city` VALUES (297,'商洛市','711500',27,NULL);
INSERT INTO `city` VALUES (298,'兰州市','730000',28,NULL);
INSERT INTO `city` VALUES (299,'嘉峪关市','735100',28,NULL);
INSERT INTO `city` VALUES (300,'金昌市','737100',28,NULL);
INSERT INTO `city` VALUES (301,'白银市','730900',28,NULL);
INSERT INTO `city` VALUES (302,'天水市','741000',28,NULL);
INSERT INTO `city` VALUES (303,'武威市','733000',28,NULL);
INSERT INTO `city` VALUES (304,'张掖市','734000',28,NULL);
INSERT INTO `city` VALUES (305,'平凉市','744000',28,NULL);
INSERT INTO `city` VALUES (306,'酒泉市','735000',28,NULL);
INSERT INTO `city` VALUES (307,'庆阳市','744500',28,NULL);
INSERT INTO `city` VALUES (308,'定西市','743000',28,NULL);
INSERT INTO `city` VALUES (309,'陇南市','742100',28,NULL);
INSERT INTO `city` VALUES (310,'临夏回族自治州','731100',28,NULL);
INSERT INTO `city` VALUES (311,'甘南藏族自治州','747000',28,NULL);
INSERT INTO `city` VALUES (312,'西宁市','810000',29,NULL);
INSERT INTO `city` VALUES (313,'海东地区','810600',29,NULL);
INSERT INTO `city` VALUES (314,'海北藏族自治州','810300',29,NULL);
INSERT INTO `city` VALUES (315,'黄南藏族自治州','811300',29,NULL);
INSERT INTO `city` VALUES (316,'海南藏族自治州','813000',29,NULL);
INSERT INTO `city` VALUES (317,'果洛藏族自治州','814000',29,NULL);
INSERT INTO `city` VALUES (318,'玉树藏族自治州','815000',29,NULL);
INSERT INTO `city` VALUES (319,'海西蒙古族藏族自治州','817000',29,NULL);
INSERT INTO `city` VALUES (320,'银川市','750000',30,NULL);
INSERT INTO `city` VALUES (321,'石嘴山市','753000',30,NULL);
INSERT INTO `city` VALUES (322,'吴忠市','751100',30,NULL);
INSERT INTO `city` VALUES (323,'固原市','756000',30,NULL);
INSERT INTO `city` VALUES (324,'中卫市','751700',30,NULL);
INSERT INTO `city` VALUES (325,'乌鲁木齐市','830000',31,NULL);
INSERT INTO `city` VALUES (326,'克拉玛依市','834000',31,NULL);
INSERT INTO `city` VALUES (327,'吐鲁番地区','838000',31,NULL);
INSERT INTO `city` VALUES (328,'哈密地区','839000',31,NULL);
INSERT INTO `city` VALUES (329,'昌吉回族自治州','831100',31,NULL);
INSERT INTO `city` VALUES (330,'博尔塔拉蒙古自治州','833400',31,NULL);
INSERT INTO `city` VALUES (331,'巴音郭楞蒙古自治州','841000',31,NULL);
INSERT INTO `city` VALUES (332,'阿克苏地区','843000',31,NULL);
INSERT INTO `city` VALUES (333,'克孜勒苏柯尔克孜自治州','835600',31,NULL);
INSERT INTO `city` VALUES (334,'喀什地区','844000',31,NULL);
INSERT INTO `city` VALUES (335,'和田地区','848000',31,NULL);
INSERT INTO `city` VALUES (336,'伊犁哈萨克自治州','833200',31,NULL);
INSERT INTO `city` VALUES (337,'塔城地区','834700',31,NULL);
INSERT INTO `city` VALUES (338,'阿勒泰地区','836500',31,NULL);
INSERT INTO `city` VALUES (339,'石河子市','832000',31,NULL);
INSERT INTO `city` VALUES (340,'阿拉尔市','843300',31,NULL);
INSERT INTO `city` VALUES (341,'图木舒克市','843900',31,NULL);
INSERT INTO `city` VALUES (342,'五家渠市','831300',31,NULL);
INSERT INTO `city` VALUES (343,'香港特别行政区','0',32,NULL);
INSERT INTO `city` VALUES (344,'澳门特别行政区','0',33,NULL);
INSERT INTO `city` VALUES (345,'台湾省','0',34,NULL);
/*!40000 ALTER TABLE `city` ENABLE KEYS */;

#
# Source for table client
#

DROP TABLE IF EXISTS `client`;
CREATE TABLE `client` (
  `Client_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '客户编号 客户编号',
  `Client_establishT` datetime DEFAULT NULL COMMENT '订单创建时间',
  `User_id` int(11) DEFAULT NULL COMMENT '用户编号',
  `Client_name` varchar(100) DEFAULT NULL COMMENT '客户名称 客户名称',
  `Client_nameE` varchar(100) DEFAULT NULL COMMENT '客户名称（英文） 客户名称（英文）',
  `Client_Property` int(11) DEFAULT NULL COMMENT '客户属性 客户属性',
  `Client_URL` varchar(100) DEFAULT NULL COMMENT '客户网址 客户网址',
  `Client_add` varchar(100) DEFAULT NULL COMMENT '客户地址 客户地址',
  `Client_postcode` varchar(100) DEFAULT NULL COMMENT '客户邮编 客户邮编',
  `Client_product` varchar(100) DEFAULT NULL COMMENT '主要产品 主要产品',
  `Client_targetMarket` varchar(100) DEFAULT NULL COMMENT '目标市场 目标市场',
  `Trade_id` int(11) DEFAULT NULL COMMENT '行业编号 行业编号',
  `Province_id` int(11) DEFAULT NULL COMMENT '省份编号 省份编号',
  `City_id` int(11) DEFAULT '0' COMMENT '城市编号 城市编号',
  `Client_typical` varchar(100) DEFAULT NULL COMMENT '典型客户 典型客户',
  `Ownership_id` int(11) DEFAULT NULL COMMENT '所有制性质编号 所有制性质编号',
  `OperationModel_id` int(11) DEFAULT NULL COMMENT '客户运营模式编号 客户运营模式编号',
  `Client_summary` varchar(100) DEFAULT NULL COMMENT '简单介绍 简单介绍',
  `Dimensions_id` int(11) DEFAULT NULL COMMENT '公司规模编号 公司规模编号',
  `EmployeesNumber_id` int(11) DEFAULT NULL COMMENT '员工人数编号 员工人数编号',
  `Client_sales` double DEFAULT NULL COMMENT '年销售额 年销售额',
  `Client_structure` varchar(100) DEFAULT NULL COMMENT '公司组织结构 公司组织结构',
  `Client_development` varchar(100) DEFAULT NULL COMMENT '公司业务发展方向以及近3-5年的规划 公司业务发展方向以及近3-5年的规划',
  `Client_challenge` varchar(100) DEFAULT NULL COMMENT '现在公司面临的挑战是什么 现在公司面临的挑战是什么',
  `Client_turnover` varchar(100) DEFAULT NULL COMMENT '员工流动率 员工流动率',
  `Client_Intermediate` varchar(100) DEFAULT NULL COMMENT '中高级员工 中高级员工',
  `Client_primary` varchar(100) DEFAULT NULL COMMENT '初级员工 初级员工',
  `Client_Join` varchar(100) DEFAULT NULL COMMENT '最常招的人员类型及最聘的职位 最常招的人员类型及最聘的职位',
  `Client_difficulty` varchar(100) DEFAULT NULL COMMENT '招聘时通常遇到的困难是 招聘时通常遇到的困难是',
  `Client_cooperation` tinyint(1) DEFAULT NULL COMMENT '是否与猎头合作过 是否与猎头合作过',
  `Client_cooperationN` varchar(100) DEFAULT NULL COMMENT '合作成功个数/年 合作个数',
  `Client_recruitment` varchar(100) DEFAULT NULL COMMENT '公司最近/未来有怎样的招聘计划 公司最近/未来有怎样的招聘计划',
  `Client_cooperationA` varchar(100) DEFAULT NULL COMMENT '可能合作的领域 可能合作的领域',
  `Client_staff` varchar(100) DEFAULT NULL COMMENT '公司希望招聘到什么样的员工 公司希望招聘到什么样的员工',
  `Client_income1` varchar(100) DEFAULT NULL COMMENT '加入贵公司,员工的最大收益1 加入贵公司,员工的最大收益1',
  `Client_income2` varchar(100) DEFAULT NULL COMMENT '加入贵公司,员工的最大收益2 加入贵公司,员工的最大收益2',
  `Client_challenge1` varchar(100) DEFAULT NULL COMMENT '最大挑战1 最大挑战1',
  `Client_challenge2` varchar(100) DEFAULT NULL COMMENT '最大挑战2 最大挑战2',
  `Client_interviewing` varchar(100) DEFAULT NULL COMMENT '公司的面试流程通常是什么 公司的面试流程通常是什么',
  `Client_way` varchar(100) DEFAULT NULL COMMENT '面试方式 面试方式',
  `Client_period` varchar(100) DEFAULT NULL COMMENT '面试的周期 面试的周期',
  `Client_welfare` varchar(100) DEFAULT NULL COMMENT '贵司的薪资福利和同行相比,属于那个层次 贵司的薪资福利和同行相比,属于那个层次',
  `Client_increase` varchar(100) DEFAULT NULL COMMENT '调薪日期 调薪日期',
  `Client_range` varchar(100) DEFAULT NULL COMMENT '每年的调薪幅度 每年的调薪幅度',
  `Client_reputation` varchar(100) DEFAULT NULL COMMENT '公司信誉 公司信誉',
  `Client_hierarchy` varchar(100) DEFAULT NULL COMMENT '重要层级 重要层级',
  `Client_status` varchar(100) DEFAULT NULL COMMENT '合作状态 合作状态',
  `Client_contract` varchar(100) DEFAULT NULL COMMENT '合同是否签订',
  `Comment` varchar(100) DEFAULT NULL COMMENT '备注 备注',
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
INSERT INTO `client` VALUES (18,'2010-12-01 00:57:13',1,'阿海珐技术中心','Areva',1,'http://www.areva.com/','上海闵行区浦江镇浦江高科技园区','222222','继电保护','高端/中端市场',31,9,0,'电力公司、房地产等',1,1,'',3,3,5,'GM，下：财务部、人事部、生产部、工程部、厂务部、EHS部门、研发部、销售部','在电力成为龙头企业','公司被施耐德和阿尔斯通的联合体公司收购，内部正在调整','9','50人以上','100人以上','继保研发工程师、硬件工程师、软件工程师','目标公司很少，人员流动相对较低',1,'5个/年','明天有很大扩张计划，正在做人员的架构调整','研发工程师','相关经验丰富、踏实稳定','良好的职业发展空间','很好的薪酬福利','公司产品的竞争力稍弱','','HRM，部门经理，','','一般2周','中上','每年3月','8%','','','',NULL,NULL);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

#
# Source for table client_follow
#

DROP TABLE IF EXISTS `client_follow`;
CREATE TABLE `client_follow` (
  `CF_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '跟进编号',
  `User_id` int(11) DEFAULT NULL COMMENT '用户编号',
  `Client_id` int(11) DEFAULT NULL COMMENT '客户编号',
  `CF_time` date DEFAULT NULL COMMENT '跟进时间',
  `CF_target` varchar(4000) DEFAULT NULL COMMENT '跟进目标',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '备注',
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
  `ClientProperty_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '客户属性编号',
  `ClientProperty_name` varchar(4000) DEFAULT NULL COMMENT '客户属性名称',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`ClientProperty_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312 COMMENT='客户属性';

#
# Dumping data for table clientproperty
#

/*!40000 ALTER TABLE `clientproperty` DISABLE KEYS */;
INSERT INTO `clientproperty` VALUES (1,'总部',NULL);
INSERT INTO `clientproperty` VALUES (2,'分支机构',NULL);
/*!40000 ALTER TABLE `clientproperty` ENABLE KEYS */;

#
# Source for table contract
#

DROP TABLE IF EXISTS `contract`;
CREATE TABLE `contract` (
  `Contract_id` int(11) NOT NULL COMMENT '合同编号',
  `Client_id` int(11) DEFAULT NULL COMMENT '客户编号',
  `Contract_number` varchar(4000) DEFAULT NULL COMMENT '合同号',
  `Contract_validS` datetime DEFAULT NULL COMMENT '合同开始时间',
  `Contract_validE` datetime DEFAULT NULL COMMENT '合同结束时间',
  `Contract_reputation` varchar(4000) DEFAULT NULL COMMENT '信用（付款）等级',
  `Contract_payment` varchar(4000) DEFAULT NULL COMMENT '平均付款周期（天）',
  `Contract_rate` varchar(4000) DEFAULT NULL COMMENT '费率是多少',
  `Contract_calculate` varchar(4000) DEFAULT NULL COMMENT '计算公式',
  `Contract_guaranteeT` varchar(4000) DEFAULT NULL COMMENT '担保期多长',
  `Contract_guaranteeD` varchar(4000) DEFAULT NULL COMMENT '担保责任',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Contract_id`),
  KEY `FK_Contract_Client_id` (`Client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='合同';

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
  `Degree_ID` int(11) NOT NULL AUTO_INCREMENT COMMENT '学历编号',
  `Degree_Name` varchar(200) DEFAULT NULL,
  `Degree_Order` int(11) DEFAULT NULL,
  PRIMARY KEY (`Degree_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gb2312 COMMENT='学历';

#
# Dumping data for table degree
#

/*!40000 ALTER TABLE `degree` DISABLE KEYS */;
INSERT INTO `degree` VALUES (1,'博士',0);
INSERT INTO `degree` VALUES (2,'研究生',1);
INSERT INTO `degree` VALUES (3,'本科',2);
INSERT INTO `degree` VALUES (4,'专科',3);
INSERT INTO `degree` VALUES (5,'中专',4);
INSERT INTO `degree` VALUES (6,'高中',5);
INSERT INTO `degree` VALUES (7,'初中',6);
INSERT INTO `degree` VALUES (8,'小学',7);
/*!40000 ALTER TABLE `degree` ENABLE KEYS */;

#
# Source for table dimensions
#

DROP TABLE IF EXISTS `dimensions`;
CREATE TABLE `dimensions` (
  `Dimensions_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '编号 公司规模编号',
  `Dimensions_name` varchar(200) DEFAULT NULL COMMENT '公司规模名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Dimensions_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312 COMMENT='公司规模';

#
# Dumping data for table dimensions
#

/*!40000 ALTER TABLE `dimensions` DISABLE KEYS */;
INSERT INTO `dimensions` VALUES (1,'小型',NULL);
INSERT INTO `dimensions` VALUES (2,'中型',NULL);
INSERT INTO `dimensions` VALUES (3,'大型',NULL);
/*!40000 ALTER TABLE `dimensions` ENABLE KEYS */;

#
# Source for table education
#

DROP TABLE IF EXISTS `education`;
CREATE TABLE `education` (
  `Education_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '教育编号 教育编号',
  `Resume_id` int(11) DEFAULT NULL COMMENT '简历编号 简历编号',
  `degree_id` int(11) DEFAULT NULL COMMENT '获得文凭',
  `Education_DateS` datetime DEFAULT NULL COMMENT '教育时间起 教育时间',
  `Education_DateE` datetime DEFAULT NULL COMMENT '教育时间止',
  `Education_school` varchar(200) DEFAULT NULL COMMENT '学校名称 学校名称\r\n',
  `Education_major` varchar(200) DEFAULT NULL COMMENT '专业名称 专业名称',
  `comment` varchar(200) DEFAULT NULL COMMENT '备注 备注',
  `Education_References` varchar(50) DEFAULT NULL COMMENT '证明人',
  `Education_References_Contect` varchar(255) DEFAULT NULL COMMENT '证明人联系方式',
  PRIMARY KEY (`Education_id`),
  KEY `FK_Education_Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=gb2312 COMMENT='教育经历';

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
  `EmployeesNumber_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '员工人数编号',
  `EmployeesNumber_name` varchar(200) DEFAULT NULL COMMENT '员工人数名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`EmployeesNumber_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312 COMMENT='员工人数';

#
# Dumping data for table employeesnumber
#

/*!40000 ALTER TABLE `employeesnumber` DISABLE KEYS */;
INSERT INTO `employeesnumber` VALUES (1,'50人以下',NULL);
INSERT INTO `employeesnumber` VALUES (2,'50-500人',NULL);
INSERT INTO `employeesnumber` VALUES (3,'500人以上',NULL);
/*!40000 ALTER TABLE `employeesnumber` ENABLE KEYS */;

#
# Source for table evaluate
#

DROP TABLE IF EXISTS `evaluate`;
CREATE TABLE `evaluate` (
  `Evaluate_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '评价编号 评价编号',
  `Evaluate_value` varchar(200) DEFAULT NULL COMMENT '评价内容 评价内容',
  `Resume_id` int(11) NOT NULL DEFAULT '0' COMMENT '简历编号 简历编号',
  `comment` varchar(200) DEFAULT NULL COMMENT '备注 备注',
  `User_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Evaluate_id`),
  KEY `Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312 COMMENT='评价';

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
  `Invoice_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '发票编号',
  `Invoice_number` varchar(20) DEFAULT NULL COMMENT '发票号',
  `Invoice_State` int(11) NOT NULL DEFAULT '0' COMMENT '发票状态',
  `Recommended_id` int(11) NOT NULL DEFAULT '0' COMMENT '推荐记录',
  `Invoice_cost` decimal(10,2) DEFAULT NULL COMMENT '总服务费金额（元）',
  `Invoice_guarantee` int(11) DEFAULT NULL COMMENT '担保期',
  `Invoice_paymentType` varchar(255) DEFAULT NULL COMMENT '付款类别',
  `Invoice_startT` datetime DEFAULT NULL COMMENT '本次开票日期',
  `Invoice_money` decimal(10,2) DEFAULT NULL COMMENT '开票金额（元）',
  `Invoice_paymentT` int(11) DEFAULT NULL COMMENT '约定付款期',
  `Invoice_endT` datetime DEFAULT NULL COMMENT '付款截止日期',
  `Invoice_BmoneyType` tinyint(3) NOT NULL DEFAULT '0' COMMENT '是否已经回款',
  `Invoice_BmoneyT` datetime DEFAULT '0000-00-00 00:00:00' COMMENT '回款日期',
  `Invoice_Bmoney` decimal(10,2) DEFAULT '0.00' COMMENT '回款金额',
  `Invoice_delayD` int(11) DEFAULT NULL COMMENT '延迟天数（提前+推迟-）',
  `User_id` int(11) DEFAULT NULL COMMENT '回款确认财务负责人',
  `Comment` varchar(255) DEFAULT NULL COMMENT '备注',
  `Invoice_WorkDate` date DEFAULT '0000-00-00',
  PRIMARY KEY (`Invoice_id`),
  KEY `Invoice_State` (`Invoice_State`),
  KEY `Recommended_id` (`Recommended_id`),
  KEY `User_id` (`User_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='发票';

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
INSERT INTO `invoicestate` VALUES (1,'未出票');
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
INSERT INTO `jobs` VALUES (1,'计算机·网络·技术类',NULL);
INSERT INTO `jobs` VALUES (2,'电子·电器·通信技术类',NULL);
INSERT INTO `jobs` VALUES (3,'销售类',NULL);
INSERT INTO `jobs` VALUES (4,'市场·公关·媒介类',NULL);
INSERT INTO `jobs` VALUES (5,'财务·审计·统计类',NULL);
INSERT INTO `jobs` VALUES (6,'人力资源类',NULL);
INSERT INTO `jobs` VALUES (7,'经营管理类',NULL);
INSERT INTO `jobs` VALUES (8,'美术·设计·创意类',NULL);
INSERT INTO `jobs` VALUES (9,'金融类(银行·基金·证券·期货·投资·典当)',NULL);
INSERT INTO `jobs` VALUES (10,'贸易·物流·采购·运输类',NULL);
INSERT INTO `jobs` VALUES (11,'建筑·房地产·装饰装修·物业管理类',NULL);
INSERT INTO `jobs` VALUES (12,'酒店·餐饮·旅游·服务类',NULL);
INSERT INTO `jobs` VALUES (13,'文体·影视·写作·媒体类',NULL);
INSERT INTO `jobs` VALUES (14,'机械·仪器仪表类',NULL);
INSERT INTO `jobs` VALUES (15,'工厂生产类',NULL);
INSERT INTO `jobs` VALUES (16,'医疗卫生·美容保健类',NULL);
INSERT INTO `jobs` VALUES (17,'电气·能源·动力类',NULL);
INSERT INTO `jobs` VALUES (18,'行政·后勤类',NULL);
INSERT INTO `jobs` VALUES (19,'翻译类',NULL);
INSERT INTO `jobs` VALUES (20,'客户服务类',NULL);
INSERT INTO `jobs` VALUES (21,'咨询·顾问类',NULL);
INSERT INTO `jobs` VALUES (22,'项目管理类',NULL);
INSERT INTO `jobs` VALUES (23,'教育·培训类',NULL);
INSERT INTO `jobs` VALUES (24,'质量管理类',NULL);
INSERT INTO `jobs` VALUES (25,'技工类',NULL);
INSERT INTO `jobs` VALUES (26,'保险类',NULL);
INSERT INTO `jobs` VALUES (27,'商业零售类',NULL);
INSERT INTO `jobs` VALUES (28,'法律类',NULL);
INSERT INTO `jobs` VALUES (29,'生物·制药·化工·环保类',NULL);
INSERT INTO `jobs` VALUES (30,'在校学生类',NULL);
INSERT INTO `jobs` VALUES (31,'科研类',NULL);
INSERT INTO `jobs` VALUES (32,'公务员类',NULL);
INSERT INTO `jobs` VALUES (33,'培训生类',NULL);
INSERT INTO `jobs` VALUES (34,'其他类',NULL);
/*!40000 ALTER TABLE `jobs` ENABLE KEYS */;

#
# Source for table jobsdetail
#

DROP TABLE IF EXISTS `jobsdetail`;
CREATE TABLE `jobsdetail` (
  `JobsDetail_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '行业明细id',
  `JobsDetail_name` varchar(200) DEFAULT NULL COMMENT '行业明细名称',
  `Jobs_id` int(11) DEFAULT NULL COMMENT '行业id',
  `Comment` varchar(200) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`JobsDetail_id`),
  KEY `FK_JobsDetail_Jobs_id` (`Jobs_id`)
) ENGINE=InnoDB AUTO_INCREMENT=467 DEFAULT CHARSET=gb2312 COMMENT='行业明细表';

#
# Dumping data for table jobsdetail
#

/*!40000 ALTER TABLE `jobsdetail` DISABLE KEYS */;
INSERT INTO `jobsdetail` VALUES (1,'首席技术官CTO·首席信息官CIO',1,NULL);
INSERT INTO `jobsdetail` VALUES (2,'技术总监·技术经理',1,NULL);
INSERT INTO `jobsdetail` VALUES (3,'信息技术经理·信息技术主管',1,NULL);
INSERT INTO `jobsdetail` VALUES (4,'信息技术专员',1,NULL);
INSERT INTO `jobsdetail` VALUES (5,'产品经理',1,NULL);
INSERT INTO `jobsdetail` VALUES (6,'项目经理·技术主管',1,NULL);
INSERT INTO `jobsdetail` VALUES (7,'项目执行·协调人员',1,NULL);
INSERT INTO `jobsdetail` VALUES (8,'架构师',1,NULL);
INSERT INTO `jobsdetail` VALUES (9,'系统分析员',1,NULL);
INSERT INTO `jobsdetail` VALUES (10,'研发工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (11,'高级软件工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (12,'软件工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (13,'互联网软件开发工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (14,'高级硬件工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (15,'系统集成工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (16,'硬件工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (17,'通信技术工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (18,'工程与项目实施',1,NULL);
INSERT INTO `jobsdetail` VALUES (19,'ERP技术应用顾问·ERP实施工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (20,'数据库管理员·数据库开发工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (21,'技术支持·维护经理',1,NULL);
INSERT INTO `jobsdetail` VALUES (22,'技术支持·维护工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (23,'品质经理·质量工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (24,'网络与信息安全工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (25,'软件测试',1,NULL);
INSERT INTO `jobsdetail` VALUES (26,'硬件测试',1,NULL);
INSERT INTO `jobsdetail` VALUES (27,'文档工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (28,'系统管理员·网管',1,NULL);
INSERT INTO `jobsdetail` VALUES (29,'语音·视频·多媒体开发',1,NULL);
INSERT INTO `jobsdetail` VALUES (30,'游戏设计与开发',1,NULL);
INSERT INTO `jobsdetail` VALUES (31,'网站营运管理',1,NULL);
INSERT INTO `jobsdetail` VALUES (32,'网站编辑',1,NULL);
INSERT INTO `jobsdetail` VALUES (33,'网站策划',1,NULL);
INSERT INTO `jobsdetail` VALUES (34,'网络工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (35,'UI设计·网页设计与制作',1,NULL);
INSERT INTO `jobsdetail` VALUES (36,'计算机辅助设计工程师',1,NULL);
INSERT INTO `jobsdetail` VALUES (37,'其他职位(计算机·网络·技术类)',1,NULL);
INSERT INTO `jobsdetail` VALUES (38,'电子工程师·电路工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (39,'电器工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (40,'电信工程师·通讯工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (41,'移动通信工程师·无限通信工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (42,'有线传输工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (43,'增值产品研发',2,NULL);
INSERT INTO `jobsdetail` VALUES (44,'通信电源工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (45,'数据通信工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (46,'工艺工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (47,'电声工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (48,'数码产品开发工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (49,'嵌入式系统软件开发',2,NULL);
INSERT INTO `jobsdetail` VALUES (50,'无线电工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (51,'半导体工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (52,'电子元器件工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (53,'电子·电器维修',2,NULL);
INSERT INTO `jobsdetail` VALUES (54,'光源与照明工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (55,'激光·光电子技术',2,NULL);
INSERT INTO `jobsdetail` VALUES (56,'集成电路(IC)芯片开发',2,NULL);
INSERT INTO `jobsdetail` VALUES (57,'版图设计工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (58,'技术文档工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (59,'测试工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (60,'机械工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (61,'电气工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (62,'电池·电源开发',2,NULL);
INSERT INTO `jobsdetail` VALUES (63,'研发工程师',2,NULL);
INSERT INTO `jobsdetail` VALUES (64,'工程与项目实施',2,NULL);
INSERT INTO `jobsdetail` VALUES (65,'现场应用工程师+FAE',2,NULL);
INSERT INTO `jobsdetail` VALUES (66,'其他职位(电子·电器·通信技术类)',2,NULL);
INSERT INTO `jobsdetail` VALUES (67,'销售总监',3,NULL);
INSERT INTO `jobsdetail` VALUES (68,'销售经理·销售主管',3,NULL);
INSERT INTO `jobsdetail` VALUES (69,'销售代表·客户经理',3,NULL);
INSERT INTO `jobsdetail` VALUES (70,'渠道总监·分销总监',3,NULL);
INSERT INTO `jobsdetail` VALUES (71,'渠道分销经理·渠道分销主管',3,NULL);
INSERT INTO `jobsdetail` VALUES (72,'渠道代表',3,NULL);
INSERT INTO `jobsdetail` VALUES (73,'区域销售经理',3,NULL);
INSERT INTO `jobsdetail` VALUES (74,'售前支持经理·售前支持主管',3,NULL);
INSERT INTO `jobsdetail` VALUES (75,'售前支持工程师',3,NULL);
INSERT INTO `jobsdetail` VALUES (76,'销售助理',3,NULL);
INSERT INTO `jobsdetail` VALUES (77,'商务经理·商务主管',3,NULL);
INSERT INTO `jobsdetail` VALUES (78,'商务专员·商务助理',3,NULL);
INSERT INTO `jobsdetail` VALUES (79,'业务拓展(BD)经理',3,NULL);
INSERT INTO `jobsdetail` VALUES (80,'电话销售',3,NULL);
INSERT INTO `jobsdetail` VALUES (81,'医药代表',3,NULL);
INSERT INTO `jobsdetail` VALUES (82,'医疗器械销售',3,NULL);
INSERT INTO `jobsdetail` VALUES (83,'保险代理人·经纪人·客户经理',3,NULL);
INSERT INTO `jobsdetail` VALUES (84,'其他职位(销售类)',3,NULL);
INSERT INTO `jobsdetail` VALUES (85,'市场总监',4,NULL);
INSERT INTO `jobsdetail` VALUES (86,'市场经理·市场主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (87,'市场专员·市场助理',4,NULL);
INSERT INTO `jobsdetail` VALUES (88,'公关媒介经理·公关媒介主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (89,'公关媒介专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (90,'市场调研与分析',4,NULL);
INSERT INTO `jobsdetail` VALUES (91,'会务经理·会务主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (92,'会务专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (93,'产品经理·品牌经理·主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (94,'产品专员·品牌专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (95,'促销经理·促销主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (96,'促销员',4,NULL);
INSERT INTO `jobsdetail` VALUES (97,'市场规划经理·市场规划主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (98,'市场规划专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (99,'广告创意·策划·设计及文案',4,NULL);
INSERT INTO `jobsdetail` VALUES (100,'广告客户经理',4,NULL);
INSERT INTO `jobsdetail` VALUES (101,'广告客户主管·广告客户专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (102,'市场营销经理·市场营销主管',4,NULL);
INSERT INTO `jobsdetail` VALUES (103,'市场营销专员',4,NULL);
INSERT INTO `jobsdetail` VALUES (104,'其他(市场·公关·媒介类)',4,NULL);
INSERT INTO `jobsdetail` VALUES (105,'首席财务官CFO',5,NULL);
INSERT INTO `jobsdetail` VALUES (106,'财务总监',5,NULL);
INSERT INTO `jobsdetail` VALUES (107,'财务经理',5,NULL);
INSERT INTO `jobsdetail` VALUES (108,'财务主管·总账主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (109,'会计经理·会计主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (110,'会计',5,NULL);
INSERT INTO `jobsdetail` VALUES (111,'出纳',5,NULL);
INSERT INTO `jobsdetail` VALUES (112,'财务分析经理·财务分析主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (113,'财务分析员',5,NULL);
INSERT INTO `jobsdetail` VALUES (114,'成本经理·成本主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (115,'成本管理员',5,NULL);
INSERT INTO `jobsdetail` VALUES (116,'审计经理·审计主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (117,'审计专员·审计助理',5,NULL);
INSERT INTO `jobsdetail` VALUES (118,'财务助理·会计助理',5,NULL);
INSERT INTO `jobsdetail` VALUES (119,'统计',5,NULL);
INSERT INTO `jobsdetail` VALUES (120,'税务经理·税务主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (121,'税务专员·税务助理',5,NULL);
INSERT INTO `jobsdetail` VALUES (122,'投融资经理·投融资主管',5,NULL);
INSERT INTO `jobsdetail` VALUES (123,'其他职位(财务·审计·统计类)',5,NULL);
INSERT INTO `jobsdetail` VALUES (124,'人力资源总监',6,NULL);
INSERT INTO `jobsdetail` VALUES (125,'人力资源经理·人力资源主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (126,'人力资源专员·人力资源助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (127,'人事主管·人事专员',6,NULL);
INSERT INTO `jobsdetail` VALUES (128,'招聘经理·招聘主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (129,'招聘专员·招聘助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (130,'培训经理·培训主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (131,'培训专员·培训助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (132,'培训师',6,NULL);
INSERT INTO `jobsdetail` VALUES (133,'薪资福利经理·主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (134,'薪资福利专员·薪资福利助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (135,'绩效考核经理·绩效考核主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (136,'绩效考核专员·绩效考核助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (137,'员工关系经理·员工关系主管',6,NULL);
INSERT INTO `jobsdetail` VALUES (138,'员工关系专员·员工关系助理',6,NULL);
INSERT INTO `jobsdetail` VALUES (139,'猎头顾问',6,NULL);
INSERT INTO `jobsdetail` VALUES (140,'其他职位(人力资源类)',6,NULL);
INSERT INTO `jobsdetail` VALUES (141,'首席执行官CEO·总裁·总经理',7,NULL);
INSERT INTO `jobsdetail` VALUES (142,'首席运营官COO',7,NULL);
INSERT INTO `jobsdetail` VALUES (143,'首席技术官CTO·首席信息官CIO',7,NULL);
INSERT INTO `jobsdetail` VALUES (144,'首席财务官CFO',7,NULL);
INSERT INTO `jobsdetail` VALUES (145,'副总裁·副总经理',7,NULL);
INSERT INTO `jobsdetail` VALUES (146,'合伙人',7,NULL);
INSERT INTO `jobsdetail` VALUES (147,'总监·事业部总经理',7,NULL);
INSERT INTO `jobsdetail` VALUES (148,'总裁助理·总经理助理',7,NULL);
INSERT INTO `jobsdetail` VALUES (149,'分公司经理·分支机构经理·办事处经理',7,NULL);
INSERT INTO `jobsdetail` VALUES (150,'部门经理',7,NULL);
INSERT INTO `jobsdetail` VALUES (151,'厂长·副厂长',7,NULL);
INSERT INTO `jobsdetail` VALUES (152,'店长',7,NULL);
INSERT INTO `jobsdetail` VALUES (153,'其他职位(经营管理类)',7,NULL);
INSERT INTO `jobsdetail` VALUES (154,'设计管理人员',8,NULL);
INSERT INTO `jobsdetail` VALUES (155,'美术·图形设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (156,'工业·产品设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (157,'服装·纺织品设计师',8,NULL);
INSERT INTO `jobsdetail` VALUES (158,'服装打样·服装制板',8,NULL);
INSERT INTO `jobsdetail` VALUES (159,'工艺品·珠宝设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (160,'家具设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (161,'平面设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (162,'媒体广告设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (163,'造型设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (164,'多媒体设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (165,'动画设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (166,'展示·装潢设计',8,NULL);
INSERT INTO `jobsdetail` VALUES (167,'创意·策划·文案',8,NULL);
INSERT INTO `jobsdetail` VALUES (168,'其他职位(美术·设计·创意类)',8,NULL);
INSERT INTO `jobsdetail` VALUES (169,'证券·外汇·期货经纪人',9,NULL);
INSERT INTO `jobsdetail` VALUES (170,'证券分析师',9,NULL);
INSERT INTO `jobsdetail` VALUES (171,'股票·期货操盘手',9,NULL);
INSERT INTO `jobsdetail` VALUES (172,'行长·副行长·高级管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (173,'投资管理·研究分析·交易管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (174,'投资银行业务',9,NULL);
INSERT INTO `jobsdetail` VALUES (175,'融资项目管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (176,'客户经理·金融产品营销管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (177,'资产管理·资产评估·交易管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (178,'风险管理·稽核·法律',9,NULL);
INSERT INTO `jobsdetail` VALUES (179,'信贷管理·信用管理',9,NULL);
INSERT INTO `jobsdetail` VALUES (180,'资金管理·财务管理·清算·结算',9,NULL);
INSERT INTO `jobsdetail` VALUES (181,'柜员·理财咨询·客户服务·银行会计',9,NULL);
INSERT INTO `jobsdetail` VALUES (182,'银行卡·电子银行·新业务拓展',9,NULL);
INSERT INTO `jobsdetail` VALUES (183,'国际结算·外汇交易',9,NULL);
INSERT INTO `jobsdetail` VALUES (184,'拍卖师',9,NULL);
INSERT INTO `jobsdetail` VALUES (185,'鉴定·估价师',9,NULL);
INSERT INTO `jobsdetail` VALUES (186,'其他职位(金融类(银行·基金·证券·期货·投资·典当))',9,NULL);
INSERT INTO `jobsdetail` VALUES (187,'外贸经理·主管·专员·助理',10,NULL);
INSERT INTO `jobsdetail` VALUES (188,'国内贸易经理·主管·专员·助理',10,NULL);
INSERT INTO `jobsdetail` VALUES (189,'业务跟单',10,NULL);
INSERT INTO `jobsdetail` VALUES (190,'单证员·报关员',10,NULL);
INSERT INTO `jobsdetail` VALUES (191,'陆运·海运·空运人员',10,NULL);
INSERT INTO `jobsdetail` VALUES (192,'商务经理·主管·专员·助理',10,NULL);
INSERT INTO `jobsdetail` VALUES (193,'采购经理·主管',10,NULL);
INSERT INTO `jobsdetail` VALUES (194,'采购员·助理',10,NULL);
INSERT INTO `jobsdetail` VALUES (195,'物流经理·物流主管',10,NULL);
INSERT INTO `jobsdetail` VALUES (196,'物流专员·物流助理',10,NULL);
INSERT INTO `jobsdetail` VALUES (197,'物料管理',10,NULL);
INSERT INTO `jobsdetail` VALUES (198,'仓库管理',10,NULL);
INSERT INTO `jobsdetail` VALUES (199,'运输经理·主管',10,NULL);
INSERT INTO `jobsdetail` VALUES (200,'货运代理',10,NULL);
INSERT INTO `jobsdetail` VALUES (201,'海陆空交通运输',10,NULL);
INSERT INTO `jobsdetail` VALUES (202,'司机',10,NULL);
INSERT INTO `jobsdetail` VALUES (203,'调度员',10,NULL);
INSERT INTO `jobsdetail` VALUES (204,'快递员·速递员',10,NULL);
INSERT INTO `jobsdetail` VALUES (205,'供应链管理',10,NULL);
INSERT INTO `jobsdetail` VALUES (206,'买手',10,NULL);
INSERT INTO `jobsdetail` VALUES (207,'海关事务管理',10,NULL);
INSERT INTO `jobsdetail` VALUES (208,'集装箱业务',10,NULL);
INSERT INTO `jobsdetail` VALUES (209,'其他职位(贸易·物流·采购·运输类)',10,NULL);
INSERT INTO `jobsdetail` VALUES (210,'高级建筑工程师·总工',11,NULL);
INSERT INTO `jobsdetail` VALUES (211,'建筑师',11,NULL);
INSERT INTO `jobsdetail` VALUES (212,'结构工程师·土木土建工程师',11,NULL);
INSERT INTO `jobsdetail` VALUES (213,'建筑设计·建筑制图',11,NULL);
INSERT INTO `jobsdetail` VALUES (214,'岩土工程师',11,NULL);
INSERT INTO `jobsdetail` VALUES (215,'幕墙工程师',11,NULL);
INSERT INTO `jobsdetail` VALUES (216,'建筑工程管理',11,NULL);
INSERT INTO `jobsdetail` VALUES (217,'工程监理',11,NULL);
INSERT INTO `jobsdetail` VALUES (218,'建筑工程验收',11,NULL);
INSERT INTO `jobsdetail` VALUES (219,'测绘·测量',11,NULL);
INSERT INTO `jobsdetail` VALUES (220,'给排水·强电·弱电·制冷暖通',11,NULL);
INSERT INTO `jobsdetail` VALUES (221,'房地产开发·策划',11,NULL);
INSERT INTO `jobsdetail` VALUES (222,'房地产项目招投标专员',11,NULL);
INSERT INTO `jobsdetail` VALUES (223,'房地产评估',11,NULL);
INSERT INTO `jobsdetail` VALUES (224,'房地产销售',11,NULL);
INSERT INTO `jobsdetail` VALUES (225,'设备工程师',11,NULL);
INSERT INTO `jobsdetail` VALUES (226,'造价·概预算',11,NULL);
INSERT INTO `jobsdetail` VALUES (227,'路桥·隧道·港口·航道工程',11,NULL);
INSERT INTO `jobsdetail` VALUES (228,'园艺设计·园林设计·景观设计',11,NULL);
INSERT INTO `jobsdetail` VALUES (229,'室内外装潢设计',11,NULL);
INSERT INTO `jobsdetail` VALUES (230,'物业管理',11,NULL);
INSERT INTO `jobsdetail` VALUES (231,'物业顾问',11,NULL);
INSERT INTO `jobsdetail` VALUES (232,'物业招商·租赁·租售',11,NULL);
INSERT INTO `jobsdetail` VALUES (233,'物业设施管理',11,NULL);
INSERT INTO `jobsdetail` VALUES (234,'物业维修',11,NULL);
INSERT INTO `jobsdetail` VALUES (235,'城市规划与设计',11,NULL);
INSERT INTO `jobsdetail` VALUES (236,'房地产中介·交易',11,NULL);
INSERT INTO `jobsdetail` VALUES (237,'公路桥梁设计·公路桥梁预算师',11,NULL);
INSERT INTO `jobsdetail` VALUES (238,'施工员',11,NULL);
INSERT INTO `jobsdetail` VALUES (239,'其他职位(建筑·房地产·装饰装修·物业管理类)',11,NULL);
INSERT INTO `jobsdetail` VALUES (240,'宾馆或酒店管理',12,NULL);
INSERT INTO `jobsdetail` VALUES (241,'娱乐或餐饮管理',12,NULL);
INSERT INTO `jobsdetail` VALUES (242,'大堂经理·副理',12,NULL);
INSERT INTO `jobsdetail` VALUES (243,'楼面经理',12,NULL);
INSERT INTO `jobsdetail` VALUES (244,'厨师·调酒师',12,NULL);
INSERT INTO `jobsdetail` VALUES (245,'营养师',12,NULL);
INSERT INTO `jobsdetail` VALUES (246,'服务员',12,NULL);
INSERT INTO `jobsdetail` VALUES (247,'礼仪·商务·接线生',12,NULL);
INSERT INTO `jobsdetail` VALUES (248,'营业员·收银员·理货员',12,NULL);
INSERT INTO `jobsdetail` VALUES (249,'导游·计调',12,NULL);
INSERT INTO `jobsdetail` VALUES (250,'票务',12,NULL);
INSERT INTO `jobsdetail` VALUES (251,'健身教练',12,NULL);
INSERT INTO `jobsdetail` VALUES (252,'美容美发',12,NULL);
INSERT INTO `jobsdetail` VALUES (253,'司机',12,NULL);
INSERT INTO `jobsdetail` VALUES (254,'保安',12,NULL);
INSERT INTO `jobsdetail` VALUES (255,'寻呼员·话务员',12,NULL);
INSERT INTO `jobsdetail` VALUES (256,'社区或家政服务',12,NULL);
INSERT INTO `jobsdetail` VALUES (257,'保洁',12,NULL);
INSERT INTO `jobsdetail` VALUES (258,'其他职位(酒店·餐饮·旅游·服务类)',12,NULL);
INSERT INTO `jobsdetail` VALUES (259,'作家·撰稿人',13,NULL);
INSERT INTO `jobsdetail` VALUES (260,'总编·副总编',13,NULL);
INSERT INTO `jobsdetail` VALUES (261,'编辑·记者',13,NULL);
INSERT INTO `jobsdetail` VALUES (262,'美术编辑',13,NULL);
INSERT INTO `jobsdetail` VALUES (263,'发行总监·经理·主管',13,NULL);
INSERT INTO `jobsdetail` VALUES (264,'出版',13,NULL);
INSERT INTO `jobsdetail` VALUES (265,'校对·录入',13,NULL);
INSERT INTO `jobsdetail` VALUES (266,'排版设计',13,NULL);
INSERT INTO `jobsdetail` VALUES (267,'艺术总监·设计总监',13,NULL);
INSERT INTO `jobsdetail` VALUES (268,'影视策划·影视制作',13,NULL);
INSERT INTO `jobsdetail` VALUES (269,'导演·编导',13,NULL);
INSERT INTO `jobsdetail` VALUES (270,'摄影·摄像',13,NULL);
INSERT INTO `jobsdetail` VALUES (271,'录音·音效师',13,NULL);
INSERT INTO `jobsdetail` VALUES (272,'化妆师·造型师',13,NULL);
INSERT INTO `jobsdetail` VALUES (273,'演员·配音·模特',13,NULL);
INSERT INTO `jobsdetail` VALUES (274,'主持人·播音员·DJ',13,NULL);
INSERT INTO `jobsdetail` VALUES (275,'演艺或体育经纪人',13,NULL);
INSERT INTO `jobsdetail` VALUES (276,'其他职位(文体·影视·写作·媒体类)',13,NULL);
INSERT INTO `jobsdetail` VALUES (277,'机械工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (278,'模具工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (279,'机械设计师',14,NULL);
INSERT INTO `jobsdetail` VALUES (280,'机械制图员',14,NULL);
INSERT INTO `jobsdetail` VALUES (281,'机电工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (282,'精密机械·仪器仪表工程师·技术员',14,NULL);
INSERT INTO `jobsdetail` VALUES (283,'铸造·锻造工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (284,'注塑工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (285,'CNC工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (286,'冲压工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (287,'夹具工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (288,'锅炉工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (289,'焊接工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (290,'汽车·摩托车工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (291,'船舶工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (292,'飞行器设计与制造',14,NULL);
INSERT INTO `jobsdetail` VALUES (293,'机械维修工程师',14,NULL);
INSERT INTO `jobsdetail` VALUES (294,'包装·印刷机械',14,NULL);
INSERT INTO `jobsdetail` VALUES (295,'食品机械',14,NULL);
INSERT INTO `jobsdetail` VALUES (296,'纺织机械',14,NULL);
INSERT INTO `jobsdetail` VALUES (297,'设备修理',14,NULL);
INSERT INTO `jobsdetail` VALUES (298,'其他职位(机械·仪器仪表类)',14,NULL);
INSERT INTO `jobsdetail` VALUES (299,'厂长·副厂长',15,NULL);
INSERT INTO `jobsdetail` VALUES (300,'总工程师·副总工程师',15,NULL);
INSERT INTO `jobsdetail` VALUES (301,'技术工程师',15,NULL);
INSERT INTO `jobsdetail` VALUES (302,'采购管理',15,NULL);
INSERT INTO `jobsdetail` VALUES (303,'物料或物流管理',15,NULL);
INSERT INTO `jobsdetail` VALUES (304,'工程或设备管理',15,NULL);
INSERT INTO `jobsdetail` VALUES (305,'安全·健康·环境管理',15,NULL);
INSERT INTO `jobsdetail` VALUES (306,'产品开发',15,NULL);
INSERT INTO `jobsdetail` VALUES (307,'技术或工艺设计经理',15,NULL);
INSERT INTO `jobsdetail` VALUES (308,'质量管理(QA·QC)',15,NULL);
INSERT INTO `jobsdetail` VALUES (309,'化验·检验',15,NULL);
INSERT INTO `jobsdetail` VALUES (310,'仓库管理',15,NULL);
INSERT INTO `jobsdetail` VALUES (311,'维修工程师',15,NULL);
INSERT INTO `jobsdetail` VALUES (312,'生产经理·车间主任',15,NULL);
INSERT INTO `jobsdetail` VALUES (313,'组长·拉长',15,NULL);
INSERT INTO `jobsdetail` VALUES (314,'计划·调度',15,NULL);
INSERT INTO `jobsdetail` VALUES (315,'产品或生产工艺工程师(PE·ME)',15,NULL);
INSERT INTO `jobsdetail` VALUES (316,'工业工程师(IE)',15,NULL);
INSERT INTO `jobsdetail` VALUES (317,'制造工程师',15,NULL);
INSERT INTO `jobsdetail` VALUES (318,'生产文员',15,NULL);
INSERT INTO `jobsdetail` VALUES (319,'其他职位(工厂生产类)',16,NULL);
INSERT INTO `jobsdetail` VALUES (320,'医疗管理人员',16,NULL);
INSERT INTO `jobsdetail` VALUES (321,'医疗技术人员',16,NULL);
INSERT INTO `jobsdetail` VALUES (322,'医生·医师',16,NULL);
INSERT INTO `jobsdetail` VALUES (323,'中医',16,NULL);
INSERT INTO `jobsdetail` VALUES (324,'心理医生',16,NULL);
INSERT INTO `jobsdetail` VALUES (325,'医药检验',16,NULL);
INSERT INTO `jobsdetail` VALUES (326,'护士·护理人员',16,NULL);
INSERT INTO `jobsdetail` VALUES (327,'营养师',16,NULL);
INSERT INTO `jobsdetail` VALUES (328,'医生技术与管理人员',16,NULL);
INSERT INTO `jobsdetail` VALUES (329,'疾病控制·公共卫生',16,NULL);
INSERT INTO `jobsdetail` VALUES (330,'美容·整形师',16,NULL);
INSERT INTO `jobsdetail` VALUES (331,'兽医·宠物医生',16,NULL);
INSERT INTO `jobsdetail` VALUES (332,'药库主任·药剂师',16,NULL);
INSERT INTO `jobsdetail` VALUES (333,'针灸推拿',16,NULL);
INSERT INTO `jobsdetail` VALUES (334,'药品注册',16,NULL);
INSERT INTO `jobsdetail` VALUES (335,'健身顾问·教练',16,NULL);
INSERT INTO `jobsdetail` VALUES (336,'医药代表',16,NULL);
INSERT INTO `jobsdetail` VALUES (337,'医疗器械销售',16,NULL);
INSERT INTO `jobsdetail` VALUES (338,'其他职位(医疗卫生·美容保健类)',16,NULL);
INSERT INTO `jobsdetail` VALUES (339,'电气工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (340,'光源与照明工程',17,NULL);
INSERT INTO `jobsdetail` VALUES (341,'变压器与磁电工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (342,'电路工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (343,'智能大厦·综合布线·弱点',17,NULL);
INSERT INTO `jobsdetail` VALUES (344,'电力工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (345,'电气维修技术员',17,NULL);
INSERT INTO `jobsdetail` VALUES (346,'水利·水电工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (347,'核力·火力工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (348,'燃气轮机工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (349,'空调·热能工程师',17,NULL);
INSERT INTO `jobsdetail` VALUES (350,'石油天然气技术人员',17,NULL);
INSERT INTO `jobsdetail` VALUES (351,'自动控制',17,NULL);
INSERT INTO `jobsdetail` VALUES (352,'制冷·暖通',17,NULL);
INSERT INTO `jobsdetail` VALUES (353,'其他职位(电气,能源,动力类)',17,NULL);
INSERT INTO `jobsdetail` VALUES (354,'行政总监',18,NULL);
INSERT INTO `jobsdetail` VALUES (355,'行政经理·行政主管·办公室主任',18,NULL);
INSERT INTO `jobsdetail` VALUES (356,'行政专员·助理',18,NULL);
INSERT INTO `jobsdetail` VALUES (357,'后勤',18,NULL);
INSERT INTO `jobsdetail` VALUES (358,'经理助理·秘书·文员',18,NULL);
INSERT INTO `jobsdetail` VALUES (359,'前台·总机·接待',18,NULL);
INSERT INTO `jobsdetail` VALUES (360,'图书情报·资料·文档管理',18,NULL);
INSERT INTO `jobsdetail` VALUES (361,'电脑操作员·打字员',18,NULL);
INSERT INTO `jobsdetail` VALUES (362,'其他职位(行政·后勤类)',18,NULL);
INSERT INTO `jobsdetail` VALUES (363,'英语',19,NULL);
INSERT INTO `jobsdetail` VALUES (364,'日语',19,NULL);
INSERT INTO `jobsdetail` VALUES (365,'法语',19,NULL);
INSERT INTO `jobsdetail` VALUES (366,'德语',19,NULL);
INSERT INTO `jobsdetail` VALUES (367,'俄语',19,NULL);
INSERT INTO `jobsdetail` VALUES (368,'西班牙语',19,NULL);
INSERT INTO `jobsdetail` VALUES (369,'韩语',19,NULL);
INSERT INTO `jobsdetail` VALUES (370,'阿拉伯语',19,NULL);
INSERT INTO `jobsdetail` VALUES (371,'其他语种翻译',19,NULL);
INSERT INTO `jobsdetail` VALUES (372,'客户服务总监',20,NULL);
INSERT INTO `jobsdetail` VALUES (373,'客户服务经理·客户服务主管',20,NULL);
INSERT INTO `jobsdetail` VALUES (374,'客户服务专员·客户服务助理',20,NULL);
INSERT INTO `jobsdetail` VALUES (375,'客户关系管理',20,NULL);
INSERT INTO `jobsdetail` VALUES (376,'客户咨询热线·呼叫中心人员',20,NULL);
INSERT INTO `jobsdetail` VALUES (377,'售后支持经理·售后支持主管',20,NULL);
INSERT INTO `jobsdetail` VALUES (378,'售后支持工程师',20,NULL);
INSERT INTO `jobsdetail` VALUES (379,'其他职位(客户服务类)',20,NULL);
INSERT INTO `jobsdetail` VALUES (380,'企管顾问·专业顾问·策划师',21,NULL);
INSERT INTO `jobsdetail` VALUES (381,'咨询总监',21,NULL);
INSERT INTO `jobsdetail` VALUES (382,'咨询经理',21,NULL);
INSERT INTO `jobsdetail` VALUES (383,'咨询员',21,NULL);
INSERT INTO `jobsdetail` VALUES (384,'调研员',21,NULL);
INSERT INTO `jobsdetail` VALUES (385,'培训师',21,NULL);
INSERT INTO `jobsdetail` VALUES (386,'涉外咨询师',21,NULL);
INSERT INTO `jobsdetail` VALUES (387,'其他职位(咨询·顾问类)',21,NULL);
INSERT INTO `jobsdetail` VALUES (388,'项目总监',22,NULL);
INSERT INTO `jobsdetail` VALUES (389,'项目经理',22,NULL);
INSERT INTO `jobsdetail` VALUES (390,'其他职位(项目管理类)',22,NULL);
INSERT INTO `jobsdetail` VALUES (391,'教学·教务管理人员',23,NULL);
INSERT INTO `jobsdetail` VALUES (392,'幼儿教育',23,NULL);
INSERT INTO `jobsdetail` VALUES (393,'教师',23,NULL);
INSERT INTO `jobsdetail` VALUES (394,'讲师',23,NULL);
INSERT INTO `jobsdetail` VALUES (395,'助教',23,NULL);
INSERT INTO `jobsdetail` VALUES (396,'家教',23,NULL);
INSERT INTO `jobsdetail` VALUES (397,'健身顾问/教练',23,NULL);
INSERT INTO `jobsdetail` VALUES (398,'教育产品开发',23,NULL);
INSERT INTO `jobsdetail` VALUES (399,'其他职位(教育·培训类)',23,NULL);
INSERT INTO `jobsdetail` VALUES (400,'质量保证(QA)·质量管理·质量督导',24,NULL);
INSERT INTO `jobsdetail` VALUES (401,'质量控制(QC)·质量检验',24,NULL);
INSERT INTO `jobsdetail` VALUES (402,'新产品开发测试',24,NULL);
INSERT INTO `jobsdetail` VALUES (403,'供应商管理·采购设备与材料质量管理',24,NULL);
INSERT INTO `jobsdetail` VALUES (404,'质量体系认证',24,NULL);
INSERT INTO `jobsdetail` VALUES (405,'其他职位(质量管理类)',24,NULL);
INSERT INTO `jobsdetail` VALUES (406,'电工·铆焊工·钳工',25,NULL);
INSERT INTO `jobsdetail` VALUES (407,'空调工·电梯工·锅炉工',25,NULL);
INSERT INTO `jobsdetail` VALUES (408,'油漆·钣金',25,NULL);
INSERT INTO `jobsdetail` VALUES (409,'锯床·车床·磨床·铣床·冲床·锣床',25,NULL);
INSERT INTO `jobsdetail` VALUES (410,'铲车·叉车工',25,NULL);
INSERT INTO `jobsdetail` VALUES (411,'机修工',25,NULL);
INSERT INTO `jobsdetail` VALUES (412,'切割技工',25,NULL);
INSERT INTO `jobsdetail` VALUES (413,'产品或工艺工程师',25,NULL);
INSERT INTO `jobsdetail` VALUES (414,'普工',25,NULL);
INSERT INTO `jobsdetail` VALUES (415,'水工·木工·油漆工',25,NULL);
INSERT INTO `jobsdetail` VALUES (416,'模具工程师',25,NULL);
INSERT INTO `jobsdetail` VALUES (417,'其他职位(技工类)',25,NULL);
INSERT INTO `jobsdetail` VALUES (418,'精算·产品研发·投资·稽核·法律',26,NULL);
INSERT INTO `jobsdetail` VALUES (419,'核保·理赔·契约管理·手受理台',26,NULL);
INSERT INTO `jobsdetail` VALUES (420,'组训·培训·人员管理·业务推动',26,NULL);
INSERT INTO `jobsdetail` VALUES (421,'保险代理人·经纪人·客户经理',26,NULL);
INSERT INTO `jobsdetail` VALUES (422,'客户服务·续期管理',26,NULL);
INSERT INTO `jobsdetail` VALUES (423,'保险内勤',26,NULL);
INSERT INTO `jobsdetail` VALUES (424,'其他职位(保险类)',26,NULL);
INSERT INTO `jobsdetail` VALUES (425,'店长',27,NULL);
INSERT INTO `jobsdetail` VALUES (426,'营运',27,NULL);
INSERT INTO `jobsdetail` VALUES (427,'生鲜·防损技术人员',27,NULL);
INSERT INTO `jobsdetail` VALUES (428,'理货员',27,NULL);
INSERT INTO `jobsdetail` VALUES (429,'营业员·服务员·店员·导购员',27,NULL);
INSERT INTO `jobsdetail` VALUES (430,'收银员',27,NULL);
INSERT INTO `jobsdetail` VALUES (431,'其他职位(商业零售类)',27,NULL);
INSERT INTO `jobsdetail` VALUES (432,'律师',28,NULL);
INSERT INTO `jobsdetail` VALUES (433,'法律顾问',28,NULL);
INSERT INTO `jobsdetail` VALUES (434,'律师助理',28,NULL);
INSERT INTO `jobsdetail` VALUES (435,'法务人员',28,NULL);
INSERT INTO `jobsdetail` VALUES (436,'知识产权·专利顾问',28,NULL);
INSERT INTO `jobsdetail` VALUES (437,'其他职位(法律类)',28,NULL);
INSERT INTO `jobsdetail` VALUES (438,'生物工程·生物制药',29,NULL);
INSERT INTO `jobsdetail` VALUES (439,'临床试验·药品注册',29,NULL);
INSERT INTO `jobsdetail` VALUES (440,'医药研发·化学制剂研发',29,NULL);
INSERT INTO `jobsdetail` VALUES (441,'药品生产·质量管理',29,NULL);
INSERT INTO `jobsdetail` VALUES (442,'药品销售·推广·业务咨询',29,NULL);
INSERT INTO `jobsdetail` VALUES (443,'医药招商',29,NULL);
INSERT INTO `jobsdetail` VALUES (444,'化工技术',29,NULL);
INSERT INTO `jobsdetail` VALUES (445,'涂料开发工程师',29,NULL);
INSERT INTO `jobsdetail` VALUES (447,'日用化工产品研发',29,NULL);
INSERT INTO `jobsdetail` VALUES (448,'环保技术',29,NULL);
INSERT INTO `jobsdetail` VALUES (449,'其他职位(生物·制药·化工·环保类)',29,NULL);
INSERT INTO `jobsdetail` VALUES (450,'应届毕业生',30,NULL);
INSERT INTO `jobsdetail` VALUES (451,'非应届毕业生',30,NULL);
INSERT INTO `jobsdetail` VALUES (452,'实习生',30,NULL);
INSERT INTO `jobsdetail` VALUES (453,'其他(在校学生类)',30,NULL);
INSERT INTO `jobsdetail` VALUES (454,'科研管理人员',31,NULL);
INSERT INTO `jobsdetail` VALUES (455,'科研人员',31,NULL);
INSERT INTO `jobsdetail` VALUES (456,'其他职位(科研类)',31,NULL);
INSERT INTO `jobsdetail` VALUES (457,'航空航天',34,NULL);
INSERT INTO `jobsdetail` VALUES (458,'安全消防',34,NULL);
INSERT INTO `jobsdetail` VALUES (459,'声光学技术·激光技术',34,NULL);
INSERT INTO `jobsdetail` VALUES (460,'测绘技术',34,NULL);
INSERT INTO `jobsdetail` VALUES (461,'地质矿产冶金',34,NULL);
INSERT INTO `jobsdetail` VALUES (462,'气象',34,NULL);
INSERT INTO `jobsdetail` VALUES (463,'农林牧渔',34,NULL);
INSERT INTO `jobsdetail` VALUES (464,'其他类别职位(其他类)',34,NULL);
INSERT INTO `jobsdetail` VALUES (465,'公务员',32,NULL);
INSERT INTO `jobsdetail` VALUES (466,'培训生',33,NULL);
/*!40000 ALTER TABLE `jobsdetail` ENABLE KEYS */;

#
# Source for table linkman
#

DROP TABLE IF EXISTS `linkman`;
CREATE TABLE `linkman` (
  `Linkman_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '联系人编号 联系人编号',
  `Client_id` int(11) DEFAULT NULL COMMENT '客户编号 客户编号',
  `Linkman_name` varchar(100) DEFAULT NULL COMMENT '联系人名称 联系人名称',
  `Linkman_nameE` varchar(100) DEFAULT NULL COMMENT '联系人名称（英文） 联系人名称（英文）',
  `Linkman_position` varchar(100) DEFAULT NULL COMMENT '联系人职位 联系人职位',
  `Linkman_phone` varchar(100) DEFAULT NULL COMMENT '联系人电话 联系人电话',
  `Linkman_mobileP` varchar(100) DEFAULT NULL COMMENT '联系人手机 联系人手机',
  `LinkMan_Email` varchar(100) DEFAULT NULL COMMENT '联系人邮箱 联系人邮箱',
  `Linkman_fax` varchar(100) DEFAULT NULL COMMENT '联系人传真 联系人传真',
  `Linkman_add` varchar(100) DEFAULT NULL COMMENT '联系人地址 联系人地址',
  `Comment` varchar(100) DEFAULT NULL COMMENT '备注 备注',
  PRIMARY KEY (`Linkman_id`),
  KEY `FK_Linkman_Client_id` (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=gb2312 COMMENT='客户联系人';

#
# Dumping data for table linkman
#

/*!40000 ALTER TABLE `linkman` DISABLE KEYS */;
INSERT INTO `linkman` VALUES (1,14,'dw','sdf','dff','123','456','123','123','123','123');
INSERT INTO `linkman` VALUES (2,18,'张琛','','招聘人事','021-34637358\t','13817798900','','','','');
INSERT INTO `linkman` VALUES (3,18,'','VIVIN陈','人事主管','021-33576888\t','','','','','');
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
INSERT INTO `mingz` VALUES (1,'汉族',NULL);
/*!40000 ALTER TABLE `mingz` ENABLE KEYS */;

#
# Source for table nationality
#

DROP TABLE IF EXISTS `nationality`;
CREATE TABLE `nationality` (
  `Nationality_id` int(11) NOT NULL COMMENT '国籍编号',
  `Nationality_name` varchar(200) DEFAULT NULL COMMENT '国籍名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Nationality_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='国籍';

#
# Dumping data for table nationality
#

/*!40000 ALTER TABLE `nationality` DISABLE KEYS */;
INSERT INTO `nationality` VALUES (1,'中国',NULL);
/*!40000 ALTER TABLE `nationality` ENABLE KEYS */;

#
# Source for table operationmodel
#

DROP TABLE IF EXISTS `operationmodel`;
CREATE TABLE `operationmodel` (
  `OperationModel_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '客户运营模式编号',
  `OperationModel_name` varchar(200) DEFAULT NULL COMMENT '客户运营模式名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`OperationModel_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312 COMMENT='客户运营模式';

#
# Dumping data for table operationmodel
#

/*!40000 ALTER TABLE `operationmodel` DISABLE KEYS */;
INSERT INTO `operationmodel` VALUES (1,'销售\r\n销售/制造/研发/服务中心/咨询服务/综合性。。。。。\r\n销售',NULL);
INSERT INTO `operationmodel` VALUES (2,'制造',NULL);
INSERT INTO `operationmodel` VALUES (3,'研发',NULL);
INSERT INTO `operationmodel` VALUES (4,'服务中心',NULL);
INSERT INTO `operationmodel` VALUES (5,'咨询服务',NULL);
INSERT INTO `operationmodel` VALUES (6,'综合性',NULL);
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
  `Order_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '订单编号 订单编号',
  `Order_NO` varchar(255) DEFAULT NULL,
  `Client_id` int(11) DEFAULT NULL COMMENT '客户编号',
  `User_id` int(11) DEFAULT NULL COMMENT '顾问编号 用户编号',
  `Order_Stime` datetime DEFAULT NULL COMMENT '订单开始时间 订单开始时间',
  `City_id` int(11) DEFAULT NULL COMMENT '城市编号 城市编号',
  `Order_positionN` varchar(255) DEFAULT NULL COMMENT '职位名称 职位名称',
  `Order_positionType` varchar(255) DEFAULT NULL COMMENT '职位类型 职位类型',
  `Order_joinN` int(11) DEFAULT NULL COMMENT '招聘人数 招聘人数',
  `Order_officeT` date DEFAULT NULL COMMENT '希望就职日期 希望就职日期',
  `Order_salary` int(11) DEFAULT NULL COMMENT '年薪酬预算 年薪酬预算',
  `Order_salaryS` varchar(255) DEFAULT NULL COMMENT '薪酬结构 薪酬结构',
  `Degree_id` int(11) DEFAULT NULL COMMENT '学历编号 学历编号',
  `Order_Language` varchar(255) DEFAULT NULL COMMENT '外语语种要求',
  `Order_languageL` varchar(255) DEFAULT NULL COMMENT '流利水平 外语水平',
  `ForeignLanguage` varchar(255) DEFAULT NULL COMMENT '其他外语语种编号 外语编号',
  `Order_compendium` varchar(255) DEFAULT NULL COMMENT '简诉语言/方言 简诉语言/方言',
  `Order_reportN` varchar(255) DEFAULT NULL COMMENT '直接汇报上级职位以及姓名 直接汇报上级职位以及姓名',
  `Order_reportN1` int(11) DEFAULT NULL COMMENT '直接汇报上级职位的国籍编号 直接汇报上级职位的国籍编号',
  `Order_manageS` varchar(255) DEFAULT NULL COMMENT '直接汇报上级管理风格 直接汇报上级管理风格',
  `Order_indirectN` varchar(255) DEFAULT NULL COMMENT '间接汇报上级职位以及姓名 间接汇报上级职位以及姓名',
  `Order_indirectN1` int(11) DEFAULT NULL COMMENT '间接汇报上级职位的国籍编号 间接汇报上级职位的国籍编号',
  `Order_indirectS` varchar(255) DEFAULT NULL COMMENT '间接汇报上级管理风格 间接汇报上级管理风格',
  `Order_subordinateN` int(11) DEFAULT NULL COMMENT '下属人数 下属人数',
  `Order_equivalentN` varchar(255) DEFAULT NULL COMMENT '平级个数 平级个数',
  `Order_equivalentP` varchar(255) DEFAULT NULL COMMENT '平级职位 平级职位',
  `Order_turnover` decimal(10,2) DEFAULT NULL COMMENT '所属组织机构的营业额 所属组织机构的营业额',
  `Order_headcount` int(11) DEFAULT NULL COMMENT '总人数',
  `Order_share` varchar(255) DEFAULT NULL COMMENT '所占整个集团的贡献份额',
  `Order_candidate` bit(1) DEFAULT NULL COMMENT '之前是否面试过候选人',
  `Order_candidateC` varchar(255) DEFAULT NULL COMMENT '如果有,简述未录取原因',
  `Recruitment_id` int(11) DEFAULT NULL COMMENT '用过何种方法招聘',
  `Order_instrument` varchar(255) DEFAULT NULL COMMENT '工作中可能会使用的设备/工具',
  `Order_allopatry` bit(1) DEFAULT NULL COMMENT '是否考虑异地候选人',
  `Order_preference` tinyint(3) DEFAULT NULL COMMENT '偏好应聘者来自竞争对手或相关行业',
  `Order_company` varchar(255) DEFAULT NULL COMMENT '如果是，希望哪些公司',
  `Order_promotion` varchar(255) DEFAULT NULL COMMENT '未来可能升迁机会',
  `Order_Interview1` varchar(255) DEFAULT NULL COMMENT '面试流程1',
  `Order_Interview2` varchar(255) DEFAULT NULL COMMENT '面试流程2',
  `Order_Interview3` varchar(255) DEFAULT NULL COMMENT '面试流程3',
  `Order_Interview4` varchar(255) DEFAULT NULL COMMENT '面试流程4',
  `Order_written` tinyint(3) DEFAULT NULL COMMENT '是否笔试',
  `Order_InterviewT` date DEFAULT NULL COMMENT '方便面试时间',
  `Order_decision` varchar(255) DEFAULT NULL COMMENT '人事任用最终决策者',
  `Order_condition` tinyint(3) DEFAULT NULL COMMENT '所有的面试者是否都同意招聘条件',
  `Order_InterviewADD` varchar(255) DEFAULT NULL COMMENT '面试地点',
  `Order_Pdescribe` varchar(255) DEFAULT NULL COMMENT '职位描述',
  `comment` varchar(255) DEFAULT NULL COMMENT '备注',
  `Position_Duty1` varchar(255) DEFAULT NULL COMMENT '职位的具体职责',
  `Position_Duty2` varchar(255) DEFAULT NULL,
  `Position_Duty3` varchar(255) DEFAULT NULL,
  `Position_Duty4` varchar(255) DEFAULT NULL,
  `Position_Duty5` varchar(255) DEFAULT NULL,
  `Position_Duty6` varchar(255) DEFAULT NULL,
  `JobsDetailID` int(11) DEFAULT NULL COMMENT '职位',
  `Trade_ID` int(11) DEFAULT NULL COMMENT '行业',
  `Experience` int(3) DEFAULT NULL COMMENT '工作年限',
  `Education_major` varchar(255) DEFAULT NULL COMMENT '专业',
  `Evaluate_Staff1` varchar(255) DEFAULT NULL COMMENT '考核该职位上的员工表现',
  `Evaluate_Staff2` varchar(255) DEFAULT NULL,
  `Evaluate_Staff3` varchar(255) DEFAULT NULL,
  `Evaluate_Staff4` varchar(255) DEFAULT NULL,
  `Client_Selling1` varchar(255) DEFAULT NULL COMMENT '客户卖点',
  `Client_Selling2` varchar(255) DEFAULT NULL,
  `Client_Selling3` varchar(255) DEFAULT NULL,
  `Client_Selling4` varchar(255) DEFAULT NULL,
  `Client_Selling5` varchar(255) DEFAULT NULL,
  `Position_Selling1` varchar(255) DEFAULT NULL COMMENT '职位卖点',
  `Position_Selling2` varchar(255) DEFAULT NULL,
  `Position_Selling3` varchar(255) DEFAULT NULL,
  `Position_Selling4` varchar(255) DEFAULT NULL,
  `Position_Selling5` varchar(255) DEFAULT NULL,
  `Position_Difficulty1` varchar(255) DEFAULT NULL COMMENT '职位的招聘难点',
  `Position_Difficulty2` varchar(255) DEFAULT NULL,
  `Position_Difficulty3` varchar(255) DEFAULT NULL,
  `Position_Difficulty4` varchar(255) DEFAULT NULL,
  `Position_Difficulty5` varchar(255) DEFAULT NULL,
  `Position_Challenge1` varchar(255) DEFAULT NULL COMMENT '职位的对候选人的挑战',
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312 COMMENT='订单';

#
# Dumping data for table orders
#

/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2010000001',14,1,'2010-11-11',2,'','新增',0,'2010-11-11',0,'',1,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-11','',0,'','',NULL,'','','','','','',1,1,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (2,'2010000002',14,1,'2010-11-14',3,'456','新增',0,'2010-11-14',0,'46',2,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (3,'2010000003',14,1,'2010-11-14',1,'123','新增',0,'2010-11-14',0,'',1,'','','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','','','','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (4,'2010000004',14,1,'2010-11-14',1,'123123','新增',0,'2010-11-14',0,'123',1,'','123123','','','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-14','',0,'','','','','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (5,'2010000005',14,1,'2010-11-17',3,'经理','新增',0,'2010-11-17',0,'123',2,'12','123','123','123','',1,'','',1,'',0,'','',0,0,'',b'0','',1,'',b'0',-1,'','','','','','',-1,'2010-11-17','',0,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
INSERT INTO `orders` VALUES (6,'2010000006',15,1,'2010-11-18',1,'123','新增',0,'2010-11-18',0,'123',2,'123','123','123','123','',1,'','',1,'',0,'','',0,0,'',b'1','',1,'',b'0',-1,'','','','','','',0,'2010-11-18','',-1,'','',NULL,'','','','','','',0,0,0,'','','','','','','','','','','','','','','','','','','','','','','','','',1,NULL);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;

#
# Source for table ownership
#

DROP TABLE IF EXISTS `ownership`;
CREATE TABLE `ownership` (
  `Ownership_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '所有制id',
  `Ownership_name` varchar(200) DEFAULT NULL COMMENT '所有制名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Ownership_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=gb2312 COMMENT='所有制性质';

#
# Dumping data for table ownership
#

/*!40000 ALTER TABLE `ownership` DISABLE KEYS */;
INSERT INTO `ownership` VALUES (1,'欧美独资',NULL);
INSERT INTO `ownership` VALUES (2,'欧美合资',NULL);
INSERT INTO `ownership` VALUES (3,'民企',NULL);
INSERT INTO `ownership` VALUES (4,'国有事业',NULL);
INSERT INTO `ownership` VALUES (5,'NGO',NULL);
INSERT INTO `ownership` VALUES (6,'其它',NULL);
INSERT INTO `ownership` VALUES (7,'非欧美外资',NULL);
/*!40000 ALTER TABLE `ownership` ENABLE KEYS */;

#
# Source for table personnel
#

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `Personnel_id` int(11) NOT NULL COMMENT '人员id',
  `Personnel_name` int(11) DEFAULT NULL COMMENT '名称',
  `comment` varchar(4000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Personnel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312 COMMENT='人员';

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
  `Province_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '省份编号',
  `Province_name` varchar(200) DEFAULT NULL COMMENT '省份名称',
  `Comment` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`Province_id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=gb2312 COMMENT='省份';

#
# Dumping data for table province
#

/*!40000 ALTER TABLE `province` DISABLE KEYS */;
INSERT INTO `province` VALUES (1,'北京市',NULL);
INSERT INTO `province` VALUES (2,'天津市',NULL);
INSERT INTO `province` VALUES (3,'河北省',NULL);
INSERT INTO `province` VALUES (4,'山西省',NULL);
INSERT INTO `province` VALUES (5,'内蒙古自治区',NULL);
INSERT INTO `province` VALUES (6,'辽宁省',NULL);
INSERT INTO `province` VALUES (7,'吉林省',NULL);
INSERT INTO `province` VALUES (8,'黑龙江省',NULL);
INSERT INTO `province` VALUES (9,'上海市',NULL);
INSERT INTO `province` VALUES (10,'江苏省',NULL);
INSERT INTO `province` VALUES (11,'浙江省',NULL);
INSERT INTO `province` VALUES (12,'安徽省',NULL);
INSERT INTO `province` VALUES (13,'福建省',NULL);
INSERT INTO `province` VALUES (14,'江西省',NULL);
INSERT INTO `province` VALUES (15,'山东省',NULL);
INSERT INTO `province` VALUES (16,'河南省',NULL);
INSERT INTO `province` VALUES (17,'湖北省',NULL);
INSERT INTO `province` VALUES (18,'湖南省',NULL);
INSERT INTO `province` VALUES (19,'广东省',NULL);
INSERT INTO `province` VALUES (20,'广西壮族自治区',NULL);
INSERT INTO `province` VALUES (21,'海南省',NULL);
INSERT INTO `province` VALUES (22,'重庆市',NULL);
INSERT INTO `province` VALUES (23,'四川省',NULL);
INSERT INTO `province` VALUES (24,'贵州省',NULL);
INSERT INTO `province` VALUES (25,'云南省',NULL);
INSERT INTO `province` VALUES (26,'西藏自治区',NULL);
INSERT INTO `province` VALUES (27,'陕西省',NULL);
INSERT INTO `province` VALUES (28,'甘肃省',NULL);
INSERT INTO `province` VALUES (29,'青海省',NULL);
INSERT INTO `province` VALUES (30,'宁夏回族自治区',NULL);
INSERT INTO `province` VALUES (31,'新疆维吾尔自治区',NULL);
INSERT INTO `province` VALUES (32,'香港特别行政区',NULL);
INSERT INTO `province` VALUES (33,'澳门特别行政区',NULL);
INSERT INTO `province` VALUES (34,'台湾省',NULL);
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
INSERT INTO `recommended_state` VALUES (1,'等待面试',0);
INSERT INTO `recommended_state` VALUES (2,'顾问面试',0);
INSERT INTO `recommended_state` VALUES (3,'客户面试',0);
INSERT INTO `recommended_state` VALUES (4,'失败',0);
INSERT INTO `recommended_state` VALUES (5,'成功',0);
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
INSERT INTO `recruitment` VALUES (1,'网络');
INSERT INTO `recruitment` VALUES (2,'报纸');
INSERT INTO `recruitment` VALUES (3,'招聘会');
/*!40000 ALTER TABLE `recruitment` ENABLE KEYS */;

#
# Source for table recruitment_quantity
#

DROP TABLE IF EXISTS `recruitment_quantity`;
CREATE TABLE `recruitment_quantity` (
  `RQ_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '招聘数量编号',
  `Client_id` int(11) DEFAULT NULL COMMENT '客户编号',
  `RQ_Lyear` varchar(50) DEFAULT NULL COMMENT '去年',
  `RQ_LyearT` varchar(50) DEFAULT NULL COMMENT '去年的时间',
  `RQ_future` varchar(50) DEFAULT NULL COMMENT '未来',
  `RQ_futureT` varchar(50) DEFAULT NULL COMMENT '未来的时间',
  `Comment` varchar(200) DEFAULT NULL COMMENT '备注',
  `RQ_Year` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`RQ_id`),
  KEY `FK_Recruitmeity_Client_id` (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312 COMMENT='贵公司去年以及未来的招聘量';

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
  `Resume_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '简历编号 简历编号',
  `Candidate_id` int(11) DEFAULT NULL COMMENT '候选人编号 候选人编号',
  `Resume_ShowName` varchar(255) DEFAULT NULL COMMENT '简历显示的姓名',
  `Resume_language` varchar(20) DEFAULT NULL COMMENT '简历语种 简历语种',
  `City_id` int(11) DEFAULT NULL COMMENT '工作地编号 工作地',
  `City_id1` int(11) DEFAULT NULL COMMENT '期望工作地编号 期望工作地',
  `JobsDetail_idArr` varchar(255) DEFAULT NULL COMMENT '职位编号 职位',
  `Trade_IDArr` varchar(255) DEFAULT NULL COMMENT '行业编号',
  `Experience` int(11) DEFAULT NULL COMMENT '相关工作经验 相关工作经验',
  `Resume_annual` decimal(10,2) DEFAULT '0.00' COMMENT '现在年薪 现在年薪',
  `Resume_expectation` decimal(10,2) DEFAULT '0.00' COMMENT '期望年薪 期望年薪',
  `Resume_overseas` varchar(200) DEFAULT NULL COMMENT '海外工作经历 海外工作经历',
  `Resume_evaluate` varchar(200) DEFAULT NULL COMMENT '自我评价 自我评价',
  `update_time` datetime DEFAULT NULL COMMENT '最后更新时间',
  `Comment` varchar(200) DEFAULT NULL COMMENT '备注 备注',
  PRIMARY KEY (`Resume_id`),
  KEY `FK_Resume_Candidate_id` (`Candidate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=gb2312 COMMENT='简历';

#
# Dumping data for table resume
#

/*!40000 ALTER TABLE `resume` DISABLE KEYS */;
INSERT INTO `resume` VALUES (1,4,NULL,'中文',0,0,'38,39,','11,3,',100,100,100,'123123','123','2010-11-05 14:08:24',NULL);
INSERT INTO `resume` VALUES (2,5,NULL,'中文',1,1,'1,2,','1,',100,100,100,'123','123123','2010-11-07 00:28:11',NULL);
INSERT INTO `resume` VALUES (3,6,NULL,'中文',1,1,'1,2,','1,',100,100,100,'123','123123','2010-11-07 00:28:28',NULL);
INSERT INTO `resume` VALUES (4,7,NULL,'中文',1,1,'10,11,','1,',100,100,100,'123123','213','2010-11-07 00:30:01',NULL);
INSERT INTO `resume` VALUES (5,8,NULL,'中文',0,0,'','',0,0,0,'','','2010-11-07 00:31:11',NULL);
INSERT INTO `resume` VALUES (6,6,'魏建楠','中文',1,1,'2,1,','17,1,',100,100,100,'123','123','2010-11-11 01:02:02',NULL);
INSERT INTO `resume` VALUES (7,1,'123','中文',1,1,'','',0,0,0,'','','2010-11-18 17:10:26',NULL);
INSERT INTO `resume` VALUES (8,NULL,'刁刁','中文',1,1,'','',0,0,0,'','','2010-12-01 02:43:25',NULL);
INSERT INTO `resume` VALUES (9,15,'123','英文',1,1,'','',0,0,0,'','','2010-12-01 02:48:47',NULL);
INSERT INTO `resume` VALUES (10,15,'123','中文',3,1,'','',0,0,0,'','','2010-12-01 03:29:43',NULL);
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
INSERT INTO `rights` VALUES (1,'登录','允许用户登录',NULL);
INSERT INTO `rights` VALUES (2,'密码修改','允许用户修改密码',NULL);
/*!40000 ALTER TABLE `rights` ENABLE KEYS */;

#
# Source for table roles
#

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT '角色编号',
  `Name` varchar(4000) DEFAULT NULL COMMENT '角色名',
  `Rights` varchar(4000) DEFAULT NULL COMMENT '权限列表',
  `comment` varchar(4000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312;

#
# Dumping data for table roles
#

/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'管理员','1,2',NULL);
INSERT INTO `roles` VALUES (2,'顾问','1',NULL);
INSERT INTO `roles` VALUES (3,'行政',NULL,NULL);
INSERT INTO `roles` VALUES (4,'财务',NULL,NULL);
INSERT INTO `roles` VALUES (5,'助理','1',NULL);
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
INSERT INTO `team` VALUES (1,'顾问一部',1);
INSERT INTO `team` VALUES (2,'顾问二部',4);
INSERT INTO `team` VALUES (8,'顾问三部',5);
INSERT INTO `team` VALUES (9,'顾问四部',3);
/*!40000 ALTER TABLE `team` ENABLE KEYS */;

#
# Source for table trade
#

DROP TABLE IF EXISTS `trade`;
CREATE TABLE `trade` (
  `Trade_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '行业编号',
  `Trade_name` varchar(200) DEFAULT NULL COMMENT '行业名称',
  `Comment` varchar(2000) DEFAULT NULL COMMENT '行业备注',
  PRIMARY KEY (`Trade_id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=gb2312 COMMENT='行业表';

#
# Dumping data for table trade
#

/*!40000 ALTER TABLE `trade` DISABLE KEYS */;
INSERT INTO `trade` VALUES (1,'计算机',NULL);
INSERT INTO `trade` VALUES (2,'互联网·电子商务',NULL);
INSERT INTO `trade` VALUES (3,'网络游戏',NULL);
INSERT INTO `trade` VALUES (4,'电子·微电子',NULL);
INSERT INTO `trade` VALUES (5,'通信(设备·运营·增值服务)',NULL);
INSERT INTO `trade` VALUES (6,'广告·会展·公关',NULL);
INSERT INTO `trade` VALUES (7,'房地产开发·建筑与工程',NULL);
INSERT INTO `trade` VALUES (8,'物业管理·商业中心',NULL);
INSERT INTO `trade` VALUES (9,'家具·室内设计·装潢',NULL);
INSERT INTO `trade` VALUES (10,'中介服务',NULL);
INSERT INTO `trade` VALUES (11,'专业服务(咨询·财会·法律等)',NULL);
INSERT INTO `trade` VALUES (12,'检验·检测·认证',NULL);
INSERT INTO `trade` VALUES (13,'金融业(投资·保险·证券·银行·基金)',NULL);
INSERT INTO `trade` VALUES (14,'贸易·进出口',NULL);
INSERT INTO `trade` VALUES (15,'媒体·出版·文化传播',NULL);
INSERT INTO `trade` VALUES (16,'印刷·包装·造纸',NULL);
INSERT INTO `trade` VALUES (17,'快速消费品(食品·饮料·日化·烟酒等)',NULL);
INSERT INTO `trade` VALUES (18,'耐用消费品(服饰·纺织·皮革·家具)',NULL);
INSERT INTO `trade` VALUES (19,'玩具·工艺品·收藏品·奢侈品',NULL);
INSERT INTO `trade` VALUES (20,'家电业',NULL);
INSERT INTO `trade` VALUES (21,'办公设备·用品',NULL);
INSERT INTO `trade` VALUES (22,'旅游·酒店·餐饮服务',NULL);
INSERT INTO `trade` VALUES (23,'批发·零售',NULL);
INSERT INTO `trade` VALUES (24,'交通·运输·物流',NULL);
INSERT INTO `trade` VALUES (25,'娱乐·运动·休闲',NULL);
INSERT INTO `trade` VALUES (26,'制药·生物工程',NULL);
INSERT INTO `trade` VALUES (27,'医疗·保健·美容·卫生服务',NULL);
INSERT INTO `trade` VALUES (28,'医疗设备·器械',NULL);
INSERT INTO `trade` VALUES (29,'环保',NULL);
INSERT INTO `trade` VALUES (30,'石油·化工·矿产·采掘·冶炼·原材料',NULL);
INSERT INTO `trade` VALUES (31,'能源(电力·石油)·水利',NULL);
INSERT INTO `trade` VALUES (32,'仪器·仪表·工业自动化·电气',NULL);
INSERT INTO `trade` VALUES (33,'汽车·摩托车(制造·维护·配件·销售·服务)',NULL);
INSERT INTO `trade` VALUES (34,'机械制造·机电·重工',NULL);
INSERT INTO `trade` VALUES (35,'原材料及加工(金属·木材·橡胶·塑料·玻璃·陶瓷·建材)',NULL);
INSERT INTO `trade` VALUES (36,'服务业',NULL);
INSERT INTO `trade` VALUES (37,'农·林·牧·渔',NULL);
INSERT INTO `trade` VALUES (38,'航空·航天研究与制造',NULL);
INSERT INTO `trade` VALUES (39,'船舶制造',NULL);
INSERT INTO `trade` VALUES (40,'教育·培训·科研·院校',NULL);
INSERT INTO `trade` VALUES (41,'政府·非营利机构',NULL);
INSERT INTO `trade` VALUES (42,'其他',NULL);
/*!40000 ALTER TABLE `trade` ENABLE KEYS */;

#
# Source for table users
#

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `User_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '用户编号',
  `User_superior_id` int(11) DEFAULT NULL COMMENT '上级编号',
  `User_name` varchar(4000) NOT NULL COMMENT '用户名称',
  `User_pwd` varchar(4000) NOT NULL COMMENT '用户密码',
  `User_realName` varchar(4000) DEFAULT NULL COMMENT '用户姓名',
  `User_number` varchar(4000) NOT NULL COMMENT '用户工作编号',
  `Creation_time` datetime NOT NULL COMMENT '创建时间',
  `Role_ID` int(11) NOT NULL COMMENT '角色编号',
  `Comment` varchar(4000) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=gb2312;

#
# Dumping data for table users
#

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'kk','123','可可','009','2010-11-03 03:01:32',1,'1123123');
INSERT INTO `users` VALUES (2,2,'123','8888','方法123','1','2010-10-28 16:31:48',2,'1');
INSERT INTO `users` VALUES (3,9,'1234','8888','方法1','1','2010-10-28 16:32:01',3,'11');
INSERT INTO `users` VALUES (4,2,'kkk','8888','淡淡的','3234','2010-10-28 16:32:07',4,'1');
INSERT INTO `users` VALUES (5,8,'pp','8888','会计科','123','2010-10-28 16:32:12',5,'123');
INSERT INTO `users` VALUES (6,8,'gg','8888','开机开机12','123123','2010-10-28 16:32:18',5,'1');
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
INSERT INTO `weeklyc_particulars` VALUES (1,0,'业务助理提供的简历数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (2,0,'自己寻访到的简历',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (3,0,'网络上寻找到的简历数量(51job etc，job posting)',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (4,0,'搜寻到的通讯录份数/组织机构图',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (5,0,'搜寻到的未来客户的数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (6,0,'在51Job、Chinahr等网络上发布的广告职位数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (7,0,'其它途径的职位发布数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (8,0,'办公室面试数量 BI',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (9,0,'发给客户的简历数量 RSO',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (10,0,'客户面试数量 CI',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (11,0,'新订单的数量 ',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (12,0,'业务拓展电话数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (13,0,'发出的营销邮件数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (14,0,'发给未来客户的方案计划书的数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (15,0,'客户拜访的数量',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (16,0,'QP1-Candidate performance with client',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (17,0,'QP2-BM service with client',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (18,0,'Qp3-Consultant performance with Candidate',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (19,1,'找到的目标候选人个数',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (20,1,'拿到的候选人简历个数',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (21,1,'有效简历(顾问筛选出来面试)',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (22,1,'RSO个数',NULL,NULL);
INSERT INTO `weeklyc_particulars` VALUES (23,1,'面试候选人',NULL,NULL);
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
  `WE_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '工作经历编号 工作经历编号',
  `Resume_id` int(11) DEFAULT NULL COMMENT '简历编号 简历编号',
  `WE_DateS` datetime DEFAULT NULL COMMENT '工作时间起 工作时间',
  `WE_DateE` datetime DEFAULT NULL COMMENT '工作时间止',
  `WE_name` varchar(4000) DEFAULT NULL COMMENT '雇主名称 雇主名称',
  `WE_position` varchar(4000) DEFAULT NULL COMMENT '职位 职位',
  `WE_place` varchar(200) DEFAULT NULL COMMENT '工作地点 工作地点',
  `WE_target` varchar(200) DEFAULT NULL COMMENT '汇报对象 汇报对象',
  `WE_responsibility` varchar(200) DEFAULT NULL COMMENT '工作职责 工作职责',
  `WE_achievement` varchar(200) DEFAULT NULL COMMENT '工作业绩 工作业绩',
  `WE_leave` varchar(200) DEFAULT NULL COMMENT '离职原因 离职原因',
  `Comment` varchar(200) DEFAULT NULL COMMENT '备注 备注',
  PRIMARY KEY (`WE_id`),
  KEY `FK_Work_Expence_Resume_id` (`Resume_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=gb2312 COMMENT='工作经历';

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
