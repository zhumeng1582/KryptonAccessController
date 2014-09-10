/**  版本信息模板在安装目录下，可自行修改。
* EventICP.cs
*
* 功 能： N/A
* 类 名： EventICP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:32:11   N/A    初版
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
	/// EventICP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EventICP
	{
		public EventICP()
		{}
		#region Model
		private int _eventicpid;
		private string _eventicpname;
		private bool _eventicpenable= true;
		private int? _pointtype;
		private int? _pointid;
		private int? _eventcodeid;
		private int? _icpid;
		/// <summary>
		/// 
		/// </summary>
		public int EventICPID
		{
			set{ _eventicpid=value;}
			get{return _eventicpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EventICPName
		{
			set{ _eventicpname=value;}
			get{return _eventicpname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool EventICPEnable
		{
			set{ _eventicpenable=value;}
			get{return _eventicpenable;}
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
		public int? ICPID
		{
			set{ _icpid=value;}
			get{return _icpid;}
		}
		#endregion Model

	}
}

