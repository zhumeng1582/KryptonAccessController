/**  版本信息模板在安装目录下，可自行修改。
* EventInfo.cs
*
* 功 能： N/A
* 类 名： EventInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:22   N/A    初版
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
	/// EventInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EventInfo
	{
		public EventInfo()
		{}
		#region Model
		private int _eventid;
		private int? _controllerid;
		private int? _pointtype;
		private int? _pointid;
		private string _cardid;
		private int? _eventcodeid;
		private string _eventdatetime;
		/// <summary>
		/// 
		/// </summary>
		public int EventID
		{
			set{ _eventid=value;}
			get{return _eventid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerID
		{
			set{ _controllerid=value;}
			get{return _controllerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointType
		{
			set{ _pointtype=value;}
			get{return _pointtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventCodeID
		{
			set{ _eventcodeid=value;}
			get{return _eventcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EventDateTime
		{
			set{ _eventdatetime=value;}
			get{return _eventdatetime;}
		}
		#endregion Model

	}
}

