/**  版本信息模板在安装目录下，可自行修改。
* EventSOP.cs
*
* 功 能： N/A
* 类 名： EventSOP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:32:47   N/A    初版
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
	/// EventSOP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EventSOP
	{
		public EventSOP()
		{}
		#region Model
		private int _eventsopgid;
		private string _eventsopgname;
		private bool _eventsopgenable= true;
		private int? _pointtype;
		private int? _pointid;
		private int? _eventcodeid;
		private int? _sopid;
		/// <summary>
		/// 
		/// </summary>
		public int EventSOPGID
		{
			set{ _eventsopgid=value;}
			get{return _eventsopgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EventSOPGName
		{
			set{ _eventsopgname=value;}
			get{return _eventsopgname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool EventSOPGEnable
		{
			set{ _eventsopgenable=value;}
			get{return _eventsopgenable;}
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
		public int? EventCodeID
		{
			set{ _eventcodeid=value;}
			get{return _eventcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID
		{
			set{ _sopid=value;}
			get{return _sopid;}
		}
		#endregion Model

	}
}

