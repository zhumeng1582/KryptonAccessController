using System;
using System.Reflection;
using System.Configuration;
using KryptonAccessController.AccessDataBase.IDAL;
using Maticsoft.Common;
namespace KryptonAccessController.AccessDataBase.DALFactory
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口) 
	/// DataCache类在导出代码的文件夹里
	/// <appSettings> 
	/// <add key="DAL" value="KryptonAccessController.AccessDataBase.SQLServerDAL" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess//<t>
	{
		//private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
        private static readonly string AssemblyPath = "KryptonAccessController.AccessDataBase.SQLServerDAL";
        private static readonly string AssembleName = "AccessController";
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string AssemblyPath,string ClassNamespace)
		{
			object objType = DataCache.GetCache(ClassNamespace);//从缓存读取
			if (objType == null)
			{
				try
				{
                    objType = Assembly.Load(AssembleName).CreateInstance(ClassNamespace);//反射创建
					DataCache.SetCache(ClassNamespace, objType);// 写入缓存
				}
				catch
				{}
			}
			return objType;
		}
		/// <summary>
		/// 创建数据层接口
		/// </summary>
		//public static t Create(string ClassName)
		//{
			//string ClassNamespace = AssemblyPath +"."+ ClassName;
			//object objType = CreateObject(AssemblyPath, ClassNamespace);
			//return (t)objType;
		//}
		/// <summary>
		/// 创建AntiPassBack数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IAntiPassBack CreateAntiPassBack()
		{

			string ClassNamespace = AssemblyPath +".AntiPassBack";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IAntiPassBack)objType;
		}


		/// <summary>
		/// 创建BlackListCardInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IBlackListCardInfo CreateBlackListCardInfo()
		{

			string ClassNamespace = AssemblyPath +".BlackListCardInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IBlackListCardInfo)objType;
		}


		/// <summary>
		/// 创建CardInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ICardInfo CreateCardInfo()
		{

			string ClassNamespace = AssemblyPath +".CardInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ICardInfo)objType;
		}


		/// <summary>
		/// 创建CompanyInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ICompanyInfo CreateCompanyInfo()
		{

			string ClassNamespace = AssemblyPath +".CompanyInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ICompanyInfo)objType;
		}


		/// <summary>
		/// 创建ControllerInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IControllerInfo CreateControllerInfo()
		{

			string ClassNamespace = AssemblyPath +".ControllerInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IControllerInfo)objType;
		}


		/// <summary>
		/// 创建ControllerInfoInLAN数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IControllerInfoInLAN CreateControllerInfoInLAN()
		{

			string ClassNamespace = AssemblyPath +".ControllerInfoInLAN";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IControllerInfoInLAN)objType;
		}


		/// <summary>
		/// 创建DepartmentInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IDepartmentInfo CreateDepartmentInfo()
		{

			string ClassNamespace = AssemblyPath +".DepartmentInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IDepartmentInfo)objType;
		}


		/// <summary>
		/// 创建DoorUnitInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IDoorUnitInfo CreateDoorUnitInfo()
		{

			string ClassNamespace = AssemblyPath +".DoorUnitInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IDoorUnitInfo)objType;
		}


		/// <summary>
		/// 创建ElectronicMap数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IElectronicMap CreateElectronicMap()
		{

			string ClassNamespace = AssemblyPath +".ElectronicMap";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IElectronicMap)objType;
		}


		/// <summary>
		/// 创建EventCodeInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IEventCodeInfo CreateEventCodeInfo()
		{

			string ClassNamespace = AssemblyPath +".EventCodeInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IEventCodeInfo)objType;
		}


		/// <summary>
		/// 创建EventInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IEventInfo CreateEventInfo()
		{

			string ClassNamespace = AssemblyPath +".EventInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IEventInfo)objType;
		}


		/// <summary>
		/// 创建EventInterControlProgram数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IEventInterControlProgram CreateEventInterControlProgram()
		{

			string ClassNamespace = AssemblyPath +".EventInterControlProgram";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IEventInterControlProgram)objType;
		}


		/// <summary>
		/// 创建EventPictureInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IEventPictureInfo CreateEventPictureInfo()
		{

			string ClassNamespace = AssemblyPath +".EventPictureInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IEventPictureInfo)objType;
		}


		/// <summary>
		/// 创建EventStandardOperateProcedureGroup数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IEventStandardOperateProcedureGroup CreateEventStandardOperateProcedureGroup()
		{

			string ClassNamespace = AssemblyPath +".EventStandardOperateProcedureGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IEventStandardOperateProcedureGroup)objType;
		}


		/// <summary>
		/// 创建ExpansionBoardInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IExpansionBoardInfo CreateExpansionBoardInfo()
		{

			string ClassNamespace = AssemblyPath +".ExpansionBoardInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IExpansionBoardInfo)objType;
		}


		/// <summary>
		/// 创建ExpansionBoardPointInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IExpansionBoardPointInfo CreateExpansionBoardPointInfo()
		{

			string ClassNamespace = AssemblyPath +".ExpansionBoardPointInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IExpansionBoardPointInfo)objType;
		}


		/// <summary>
		/// 创建Holiday数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IHoliday CreateHoliday()
		{

			string ClassNamespace = AssemblyPath +".Holiday";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IHoliday)objType;
		}


		/// <summary>
		/// 创建HolidayICP数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IHolidayICP CreateHolidayICP()
		{

			string ClassNamespace = AssemblyPath +".HolidayICP";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IHolidayICP)objType;
		}


		/// <summary>
		/// 创建HolidayStandardOperateProcedure数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IHolidayStandardOperateProcedure CreateHolidayStandardOperateProcedure()
		{

			string ClassNamespace = AssemblyPath +".HolidayStandardOperateProcedure";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IHolidayStandardOperateProcedure)objType;
		}


		/// <summary>
		/// 创建InteractHoliday数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IInteractHoliday CreateInteractHoliday()
		{

			string ClassNamespace = AssemblyPath +".InteractHoliday";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IInteractHoliday)objType;
		}


		/// <summary>
		/// 创建InterControlProgram数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IInterControlProgram CreateInterControlProgram()
		{

			string ClassNamespace = AssemblyPath +".InterControlProgram";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IInterControlProgram)objType;
		}


		/// <summary>
		/// 创建InterLock数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IInterLock CreateInterLock()
		{

			string ClassNamespace = AssemblyPath +".InterLock";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IInterLock)objType;
		}


		/// <summary>
		/// 创建Manager数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IManager CreateManager()
		{

			string ClassNamespace = AssemblyPath +".Manager";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IManager)objType;
		}


		/// <summary>
		/// 创建ManagerRightList数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IManagerRightList CreateManagerRightList()
		{

			string ClassNamespace = AssemblyPath +".ManagerRightList";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IManagerRightList)objType;
		}


		/// <summary>
		/// 创建Media数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IMedia CreateMedia()
		{

			string ClassNamespace = AssemblyPath +".Media";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IMedia)objType;
		}


		/// <summary>
		/// 创建MendiaGroup数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IMendiaGroup CreateMendiaGroup()
		{

			string ClassNamespace = AssemblyPath +".MendiaGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IMendiaGroup)objType;
		}


		/// <summary>
		/// 创建MenuInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IMenuInfo CreateMenuInfo()
		{

			string ClassNamespace = AssemblyPath +".MenuInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IMenuInfo)objType;
		}


		/// <summary>
		/// 创建PlayMediaInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IPlayMediaInfo CreatePlayMediaInfo()
		{

			string ClassNamespace = AssemblyPath +".PlayMediaInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IPlayMediaInfo)objType;
		}


		/// <summary>
		/// 创建ReaderHoliday数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IReaderHoliday CreateReaderHoliday()
		{

			string ClassNamespace = AssemblyPath +".ReaderHoliday";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IReaderHoliday)objType;
		}


		/// <summary>
		/// 创建ReaderInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IReaderInfo CreateReaderInfo()
		{

			string ClassNamespace = AssemblyPath +".ReaderInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IReaderInfo)objType;
		}


		/// <summary>
		/// 创建ReaderTimeAccess数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IReaderTimeAccess CreateReaderTimeAccess()
		{

			string ClassNamespace = AssemblyPath +".ReaderTimeAccess";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IReaderTimeAccess)objType;
		}


		/// <summary>
		/// 创建ReaderTimeZone数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IReaderTimeZone CreateReaderTimeZone()
		{

			string ClassNamespace = AssemblyPath +".ReaderTimeZone";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IReaderTimeZone)objType;
		}


		/// <summary>
		/// 创建StandardOperateProcedure数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IStandardOperateProcedure CreateStandardOperateProcedure()
		{

			string ClassNamespace = AssemblyPath +".StandardOperateProcedure";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IStandardOperateProcedure)objType;
		}


		/// <summary>
		/// 创建TimeAccess数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ITimeAccess CreateTimeAccess()
		{

			string ClassNamespace = AssemblyPath +".TimeAccess";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ITimeAccess)objType;
		}


		/// <summary>
		/// 创建TimeInterControlProgram数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ITimeInterControlProgram CreateTimeInterControlProgram()
		{

			string ClassNamespace = AssemblyPath +".TimeInterControlProgram";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ITimeInterControlProgram)objType;
		}


		/// <summary>
		/// 创建TimeStandardOperateProcedure数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ITimeStandardOperateProcedure CreateTimeStandardOperateProcedure()
		{

			string ClassNamespace = AssemblyPath +".TimeStandardOperateProcedure";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ITimeStandardOperateProcedure)objType;
		}


		/// <summary>
		/// 创建TimeZone数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.ITimeZone CreateTimeZone()
		{

			string ClassNamespace = AssemblyPath +".TimeZone";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.ITimeZone)objType;
		}


		/// <summary>
		/// 创建UserGroup数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IUserGroup CreateUserGroup()
		{

			string ClassNamespace = AssemblyPath +".UserGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IUserGroup)objType;
		}


		/// <summary>
		/// 创建UserInfo数据层接口。
		/// </summary>
		public static KryptonAccessController.AccessDataBase.IDAL.IUserInfo CreateUserInfo()
		{

			string ClassNamespace = AssemblyPath +".UserInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (KryptonAccessController.AccessDataBase.IDAL.IUserInfo)objType;
		}

}
}