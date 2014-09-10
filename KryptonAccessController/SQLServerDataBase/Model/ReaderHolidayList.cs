/**  版本信息模板在安装目录下，可自行修改。
* ReaderHolidayList.cs
*
* 功 能： N/A
* 类 名： ReaderHolidayList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 14:46:02   N/A    初版
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
	/// ReaderHolidayList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReaderHolidayList
	{
		public ReaderHolidayList()
		{}
		#region Model
		private int _readerholidaylistid;
		private int? _readerid;
		private int? _readerholidayid;
		/// <summary>
		/// 
		/// </summary>
		public int ReaderHolidayListID
		{
			set{ _readerholidaylistid=value;}
			get{return _readerholidaylistid;}
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
		public int? ReaderHolidayID
		{
			set{ _readerholidayid=value;}
			get{return _readerholidayid;}
		}
		#endregion Model

	}
}

