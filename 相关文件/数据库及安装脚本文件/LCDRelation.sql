create database LCDRelation
Use LCDRelation
drop database LCDRelation

--多媒体图片组
Create Table MendiaPictureGroup(
	MendiaPictureGroupID int primary key,
	MendiaPictureGroupName nvarchar(50),
	MendiaPictureGroupDes nvarchar(100)
);

Create Table MediaPicture(
	MediaPictureID int primary key,
	MediaPictureName nvarchar(50) not null,
	MediaPicturePath varchar(100) not null,
	MediaPictureGroupID int references MendiaPictureGroup(MendiaPictureGroupID),
	MediaPicgureType int default(1),
	PlayPriority int 
);

--多媒体视频组
Create Table MediaVideoGroup(
	MediaVideoGroupID int primary key ,
	MediaVideoGroupName nvarchar(50),
	MediaVideoGroupDes nvarchar(100)
);

--多媒体视频
Create Table MediaVideo(
	MediaVideoID int primary key,
	MediaVideoName nvarchar(50) not null,
	MediaVideoFilePath nvarchar(100) not null,
	MediaVideoGroupID int references MediaVideoGroup(MediaVideoGroupID),
	MediaVideoType int default(1),
	PlayPriority int 
);

--Alter Table MediaVideo Add MediaVideoGroupID int references MediaVideoGroup(MediaVideoGroupID)

--多媒体播放信息表
Create Table PlayMediaInfo(
	PlayMediaID int primary key,
	PlayMediaName nvarchar(50),
	PlayReaderID int,
	PlayLoop bit default(1),
	
	PlayType1 int,
	PlayMediaGroupID1 int,
	STime1 nvarchar(8) default('00:00'),
	ETime1 nvarchar(8) default('23:59'),
	
	PlayType2 int,
	PlayMediaGroupID2 int,
	STime2 nvarchar(8) default('00:00'),
	ETime2 nvarchar(8) default('00:00'),
	
	PlayType3 int,
	PlayMediaGroupID3 int,
	STime3 nvarchar(8) default('00:00'),
	ETime3 nvarchar(8) default('00:00'),
	
	PlayType4 int,
	PlayMediaGroupID4 int,
	STime4 nvarchar(8) default('00:00'),
	ETime4 nvarchar(8) default('00:00'),
	
	PlayType5 int,
	PlayMediaGroupID5 int,
	STime5 nvarchar(8) default('00:00'),
	ETime5 nvarchar(8) default('00:00'),
	
	PlayType6 int,
	PlayMediaGroupID6 int,
	STime6 nvarchar(8) default('00:00'),
	ETime6 nvarchar(8) default('00:00')
);