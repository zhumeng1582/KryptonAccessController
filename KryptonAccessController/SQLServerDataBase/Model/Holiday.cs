/**  版本信息模板在安装目录下，可自行修改。
* Holiday.cs
*
* 功 能： N/A
* 类 名： Holiday
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:24   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.AccessDataBase.Model
{
	/// <summary>
	/// Holiday:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Holiday
	{
		public Holiday()
		{}
		#region Model
		private int _holidayid;
		private string _holidayname;
		private int? _usergroupid;
		private int? _holidaytype;
		private string _holidaystartdate;
		private string _holidayenddate;
		private int? _timezoneid;
		/// <summary>
		/// 
		/// </summary>
		public int HolidayID
		{
			set{ _holidayid=value;}
			get{return _holidayid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HolidayName
		{
			set{ _holidayname=value;}
			get{return _holidayname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserGroupID
		{
			set{ _usergroupid=value;}
			get{return _usergroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HolidayType
		{
			set{ _holidaytype=value;}
			get{return _holidaytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HolidayStartDate
		{
			set{ _holidaystartdate=value;}
			get{return _holidaystartdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HolidayEndDate
		{
			set{ _holidayenddate=value;}
			get{return _holidayenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TimeZoneID
		{
			set{ _timezoneid=value;}
			get{return _timezoneid;}
		}
		#endregion Model

	}
}

