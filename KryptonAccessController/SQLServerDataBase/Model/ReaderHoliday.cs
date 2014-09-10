/**  版本信息模板在安装目录下，可自行修改。
* ReaderHoliday.cs
*
* 功 能： N/A
* 类 名： ReaderHoliday
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:31   N/A    初版
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
	/// ReaderHoliday:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReaderHoliday
	{
		public ReaderHoliday()
		{}
		#region Model
		private int _readerholidayid;
		private int? _readerid;
		private string _readerholidayname;
		private int? _readerholidaytype;
		private string _readerholidaystartdate="2014-01-01";
		private string _readerholidayenddate="2014-01-01";
		/// <summary>
		/// 
		/// </summary>
		public int ReaderHolidayID
		{
			set{ _readerholidayid=value;}
			get{return _readerholidayid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderID
		{
			set{ _readerid=value;}
			get{return _readerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderHolidayName
		{
			set{ _readerholidayname=value;}
			get{return _readerholidayname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderHolidayType
		{
			set{ _readerholidaytype=value;}
			get{return _readerholidaytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderHolidayStartDate
		{
			set{ _readerholidaystartdate=value;}
			get{return _readerholidaystartdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderHolidayEndDate
		{
			set{ _readerholidayenddate=value;}
			get{return _readerholidayenddate;}
		}
		#endregion Model

	}
}

