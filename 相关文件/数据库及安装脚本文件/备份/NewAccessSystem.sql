create database NewAccessSystem
use NewAccessSystem

create table Administrator(
num	int not null Primary key identity(1,1),
name nvarchar(8),
psw nvarchar(8)
)
insert into Administrator(name,psw)values ('admin','rdm123') 

Create table Controller(
ControllerID int primary key,
ControllerName nchar(10) not null,
ControllerLoction nchar(100),
CommunicateType int,
ControllerIP nchar(20),
ControllerDNS nchar(20),
ControllerGateway nchar(20),
ControllerPort int,
ControllerBaudrate int
)
insert into Controller values(1,'Controll1','综合楼A栋101',0,'192.168.001.233','192.168.001.001','255.255.255.000',1200,0)

Create table DevPoint(
Num int Primary key,
DevID int not null,
ControllerID int foreign key references Controller(ControllerID),
DevName nchar(50) not null unique,
DevTypeDes nchar(50),
DevLoction nchar(100),
PIN nchar(10)
)

create table Company(
CompanyID int primary key,
CompanyName nchar(20),
CompanyAddress nchar(100),
CompanyTel1 nchar(15),
CompanyTel2 nchar(15)
)

insert into Company values(0,'深圳市瑞德玛泰玛实业有限公司','广东省深圳市南山区西丽镇官龙村综合楼A栋3H','75526504562','75526639115')

Create Table Department(
DepartmentID int primary key,
DepartmentName nchar(50),
CompanyID int foreign key references Company(CompanyID), 
DepartmentTel1 nchar(15),
DepartmentTel2 nchar(15)
)

insert into Department values(0,'行政部',0,'75526504562','75526639115')



Create table UserInfo(
	UserID int not null primary key,
	UserName nchar(20) not null,
	Photograph image,
	NRIC nchar(20),
	CompanyID int foreign key references Company(CompanyID),
	UserAddress nchar(100),
	PostalCode nchar(10),
	Gender nchar(1),
	BOB nchar(10),
	TelHome nchar(12),
	TelOffice nchar(12),
	Email nchar(32),
	DepartmentID int foreign key references Department(DepartmentID),
	Designation nchar(50),
	Remarks nchar(100),
	
	FingerPosition0 int,
	FingerPrint0 image,
	FingerPosition1 int,
	FingerPrint1 image
 )

create table CardInfo(
	CardID nchar(10)not null primary key ,
	AccessAreaID bigint,
	PSW nchar(10),
	CardType int,
	CardLevel nchar,
	Times int,
	CardVersion int,
	CardActivationDate nchar(10),
	CardValidATillDate nchar(10),
	GTFlag bit,
	DualBadgeFlag bit,
	ElevatorFlag bit,
	
	WhilteListFlag bit,
	UserID int
 )
 
Create Table TimeZone(
TimeZoneID int primary key,
STime1 nchar(8),
ETime1 nchar(8),
STime2 nchar(8),
ETime2 nchar(8),
STime3 nchar(8),
ETime3 nchar(8),
STime4 nchar(8),
ETime4 nchar(8),
STime5 nchar(8),
ETime5 nchar(8),
STime6 nchar(8),
ETime6 nchar(8),
)

Create Table TimeAccess(
TimeAccessID int primary key,
TimeAccessDes nchar(50),
Sun int foreign key references TimeZone(TimeZoneID),
Mon int foreign key references TimeZone(TimeZoneID),
Tue int foreign key references TimeZone(TimeZoneID),
Wed int foreign key references TimeZone(TimeZoneID),
Thu int foreign key references TimeZone(TimeZoneID),
Fri int foreign key references TimeZone(TimeZoneID),
Sat int foreign key references TimeZone(TimeZoneID)

)

Create Table Holiday (
HolidayID int primary key,
HolidayName nchar(10),
HolidayType nchar,
HolidayDes nchar(50),
HolidayDate nchar(10),
HolidayTimeZone int foreign key references TimeZone(TimeZoneID)
)
Create Table Record(
RecordNum int primary key identity(1,1),
ControllerDevicePoint int,
CardID nchar(6),
RecordState  nchar(20),
RecordTime nchar(19)
)



Create Table ElectronicMap(
ElectronicMapID int primary key identity(0,1),
ElectronicMapName nchar(10)not null unique,
ElectronicMapDes nchar(100),
Map image
)
insert into ElectronicMap(ElectronicMapName,ElectronicMapDes)values('空地图','此地图保存未分配的设备地点')

Create Table ConsolePoint(
ConsolePointID int primary key references DevPoint(Num),
ConsolePointName nchar(50),
ConsolePointX int,
ConsolePointY int,
ElectronicMapID int foreign key references ElectronicMap(ElectronicMapID),
OpenImage image,
CloseImage image
)

if (exists (select * from sys.objects where name = 'PRO_getTimeAccess'))
    drop proc PRO_getTimeAccess
go

create procedure PRO_getTimeAccess
AS
select*from
(
 select TimeAccessID , Weekday ='Sun' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Sun = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Mon' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Mon = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Tue' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Tue = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Wed' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Wed = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Thu' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Thu = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Fri' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Fri = TimeZone.TimeZoneID 
 union all
 select TimeAccessID , Weekday ='Sat' ,TimeZone.* from TimeAccess,TimeZone where TimeAccess.Sat = TimeZone.TimeZoneID 
) t
order by TimeAccessID , case Weekday 
when'Sun'then 1 when'Mon'then 2 when'Tue'then 3
when'Wed'then 4when'Thu'then 5when'Fri'then 6
when'Sat'then 7
end

Create Table TriggerEvent(
TriggerEventID nchar(10) primary key,
InAddr int,
InPort int,
InType int,
InEventDes nchar(50),
OutAddr int,
OutPort int,
OutType int,
OutEventDes nchar(50),
TimeLength int,
TriggerEventDes nchar(50)
)

