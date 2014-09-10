Create Table CardInfo(
	CardID nvarchar(10) primary key,
	CardVersion nvarchar(10)default(1),
	CardType int,
	CardLevel nvarchar(1)default('E'),
	CardPassword nvarchar(10) default('000000'),
	CardIssueDateTime nvarchar(10),
	CardValidDateTime nvarchar(10),
	StateFlag nvarchar(1)
);

--时区表
Create Table TimeZone(
	TimeZoneID int primary key,
	STime1 nvarchar(8) default('00:00'),
	ETime1 nvarchar(8) default('23:59'),
	STime2 nvarchar(8) default('00:00'),
	ETime2 nvarchar(8) default('00:00'),
	STime3 nvarchar(8) default('00:00'),
	ETime3 nvarchar(8) default('00:00'),
	STime4 nvarchar(8) default('00:00'),
	ETime4 nvarchar(8) default('00:00'),
	STime5 nvarchar(8) default('00:00'),
	ETime5 nvarchar(8) default('00:00'),
	STime6 nvarchar(8) default('00:00'),
	ETime6 nvarchar(8) default('00:00')
);

--用户组表
Create Table UserGroup(
	UserGroupID int primary key,
	UserGroupName nvarchar(50) not null,
	UserGroupDes nvarchar(100)
) ;

--时间计划表
Create Table TimeAccess(
	TimeAccessID int primary key,
	UserGroupID int references UserGroup(UserGroupID),
	Mon int references TimeZone(TimeZoneID),
	Tue int references TimeZone(TimeZoneID),
	Wed int references TimeZone(TimeZoneID),
	Thu int references TimeZone(TimeZoneID),
	Fri int references TimeZone(TimeZoneID),
	Sat int references TimeZone(TimeZoneID),
	Sun int references TimeZone(TimeZoneID)
);

--节假日表
Create Table Holiday(
	HolidayID int primary key,
	HolidayName nvarchar(50),
	UserGroupID int references UserGroup(UserGroupID),
	HolidayType int,
	HolidayStartDate nvarchar(10),
	HolidayEndDate nvarchar(10)
);
--黑名单信息表
Create Table BlackListCardInfo(
	CardID nvarchar(10) primary key,
	CardVersion nvarchar(10)default(1),
	CardDeactiveDateTime nvarchar(10),
	UserName nvarchar(50),
	MarkBListReason nvarchar(100),
	BListStateFlag nvarchar(1)
);
--用户信息
Create Table UserInfo(
	UserID int primary key,
	UserName nvarchar(50) not null,
	Photograph image,
	UserGroupID1 int references UserGroup(UserGroupID),
	UserGroupID2 int references UserGroup(UserGroupID),
	UserGroupID3 int references UserGroup(UserGroupID),
	UserGroupID4 int references UserGroup(UserGroupID),
	FingerPosition0 int,
	FingerPrint0 image,
	FingerPosition1 int,
	FingerPrint1 image,
	SercurityAccessLevel int default(1),
	PrimaryCardID nvarchar(10) references CardInfo(CardID),
	SecondCardID nvarchar(10) references CardInfo(CardID)
);

