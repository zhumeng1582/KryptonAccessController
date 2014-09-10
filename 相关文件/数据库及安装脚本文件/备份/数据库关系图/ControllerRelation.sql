Create Table ControllerInfo(
	ControllerID int primary key,
	ControllerType int default(1),
	ControllerName nvarchar(50) not null default('Controller1'),
	ControllerLocation nvarchar(100),
	EncryptionType int default(0),
	CommunicateType int default(0),
	ControllerVersion nvarchar(50),
	ControllerMAC nvarchar(17),
	ControllerIP nvarchar(20) default('192.168.1.241'),
	ControllerSubnetMask nvarchar(20) default('255.255.255.0'),
	ControllerGateway nvarchar(20) default('192.168.1.1'),
	ControllerPort int default(1200),
	ControllerDNS nvarchar(20),
	ControllerBUDNS nvarchar(20),
	ControllerAddr485 int ,
	ControllerBaudrate int default(115200),
	ControllerDataBits int default(8),
	ControllerParityCheck nvarchar(8) default('None'),
	ControllerFlowControl nvarchar(8) default('None'),
	ControllerSAM int,
	ControllerSAMType int,
	DoorUnitCounts int default(2),
	ExpansionBoardCounts int
);

--读卡器工作时区表
Create Table ReaderTimeZone(
	ReaderTimeZoneID int primary key,
	TimeZone1 nvarchar(8) default('00:00'),
	OperateMode1 int default(1),
	TimeZone2 nvarchar(8) default('23:59'),
	OperateMode2 int default(1),
	TimeZone3 nvarchar(8) default('00:00'),
	OperateMode3 int default(1),
	TimeZone4 nvarchar(8) default('00:00'),
	OperateMode4 int default(1),
	TimeZone5 nvarchar(8) default('00:00'),
	OperateMode5 int default(1),
	TimeZone6 nvarchar(8) default('00:00'),
	OperateMode6 int default(1)
);

--读卡器周工作模式
Create Table ReaderTimeAccess(
	ReaderTimeAccessID int primary key,
	ReaderTimeAccessName nvarchar(50) not null,
	Mon int references ReaderTimeZone(ReaderTimeZoneID),
	Tue int references ReaderTimeZone(ReaderTimeZoneID),
	Wed int references ReaderTimeZone(ReaderTimeZoneID),
	Thu int references ReaderTimeZone(ReaderTimeZoneID),
	Fri int references ReaderTimeZone(ReaderTimeZoneID),
	Sat int references ReaderTimeZone(ReaderTimeZoneID),
	Sun int references ReaderTimeZone(ReaderTimeZoneID)
);

--读卡器信息
Create Table ReaderInfo(
	ReaderID int primary key,
	ReaderPointID int not null,
	ReaderType nvarchar(1) default('A'),
	ReaderName nvarchar(50),
	ReaderLocation nvarchar(100),
	ReaderVersion nvarchar(50),
	ReaderSAM int,
	ReaderSAMType int,
	CardType int,
	CardReadArea int,
	FingerEnable bit default(0),
	SercurityAccessLevel int default(1),
	SuperviseMode int default(0),
	PINIdentify int default(0),
	ReaderPIN nvarchar(10) default('000000'),
	DuressCode nvarchar(10) default('00001'),
	ArmPassWord nvarchar(10) default('000001'),
	UnarmPassWord nvarchar(10) default('000001'),
	CommunicateType int default(0),
	ReaderIP nvarchar(20) default('192.168.1.231'),
	ReaderSubnet nvarchar(20) default('255.255.255.0'),
	ReaderGateway nvarchar(20) default('192.168.1.1'),
	ReaderPort int default(1200),
	ReaderDNS nvarchar(20),
	ReaderBuDNS nvarchar(20),
	ReaderAddr483 int,
	ReaderBaudrate int default(115200),
	ReaderDataBits int default(8),
	ReaderStopBits int default(1),
	ReaderParityCheck nvarchar(8) default('None'),
	ReaderFlowControl nvarchar(8) default('None'),
	ReaderUsage int default(1),
	ReadTimeAccessID int references ReaderTimeAccess(ReaderTimeAccessID)
);


--读卡器节假日时间段表
Create Table ReaderHoliday(
	ReaderHolidayID int primary key,
	ReaderID int references ReaderInfo(ReaderID),
	ReaderHolidayName nvarchar(50)not null,
	ReaderHolidayType int,
	ReaderHolidayStartDate nvarchar(10) default ('2014-01-01'),
	ReaderHolidayEndDate nvarchar(10) default ('2014-01-01')
) ;
--门单元信息
Create Table DoorUnitInfo(
	DoorUnitID int primary key,
	OutPutLockID int unique,
	OutPutTimeLeng int default(6),
	OpenDoorOverTimeLen int default (20),
	ZoneCountLimitEnable bit default (0),
	ZoneCountLimitMax int default(0),
	ZoneCountLimitMed int default(0),
	ZoneCountLimitMin int default(0),
	ReadID1 int references ReaderInfo(ReaderID),
	ReadIDEnable1 bit default(1),
	ReadID2 int references ReaderInfo(ReaderID),
	ReadIDEnable2 bit default(0),
	InputStateType int default(2),
	ExitButtonID int default (1),
	ExitButtonMode int default(1),
	ExtiButtonEnable bit default(1),
	DoorContactID int default (2),
	DoorContactMode int default(1),
	DoorContactEnable bit default(1),
	DoorPositionID int default (3),
	DoorPositionMode int default(1),
	DoorPositionEnable bit default(1),
	BreakGlassID int default (4),
	BreakGlassMode int default(1),
	BreakGlassEnable bit default(1)
);

--辅助单元信息表
Create Table AuxiliaryUnit(
	AuxiliaryUnitID int primary key,
	AuxOutPutPointID int default(10),
	InputStateType int default(2),
	FireSensingID int default(10),
	FireSensingMode int default(1),
	FireSensingEnable bit default(1),
	TamperSensingID int default(11),
	TamperSensingMode int default(1),
	TamperSensingEnable bit default(1),
	LowVoltageID int default(12),
	LowVoltageMode int default(1),
	LowVoltageEnable bit default(1),
	PowerOutageID int default(13),
	PowerOutageMode int default(1),
	PowerOutageEnable bit default(1)
);
--扩展板信息表
Create Table ExpansionBoardInfo(
	ExpansionBoardID int primary key,
	ExpansionBoardType int default(1),
	ExpansionBoardName nvarchar(50) default('ExpansionBoard1'),
	ExpansionBoardAddr int,
	InputStateType int default(2),
	ExpansionBoardLocation nvarchar(100)
);
--扩展板端口点信息表
Create Table ExpansionBoardPointInfo(
	ExpansionBoardPointID int primary key,
	InputName nvarchar(50)Default('Input1'),
	PointType int not null,
	PointID int not null,
	PointState int,
	ExpansionBoardID int references ExpansionBoardInfo(ExpansionBoardID)
);
