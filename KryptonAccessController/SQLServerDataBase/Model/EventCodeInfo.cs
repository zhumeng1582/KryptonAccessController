/**  版本信息模板在安装目录下，可自行修改。
* EventCodeInfo.cs
*
* 功 能： N/A
* 类 名： EventCodeInfo
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
	/// EventCodeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EventCodeInfo
	{
		public EventCodeInfo()
		{}
		#region Model
		private int _eventcodeid;
		private int? _eventcodetype;
		private string _eventcodename;
		private int? _eventcodepictureid;
		private int? _eventuploadpriority=1;
		/// <summary>
		/// 
		/// </summary>
		public int EventCodeID
		{
			set{ _eventcodeid=value;}
			get{return _eventcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventCodeType
		{
			set{ _eventcodetype=value;}
			get{return _eventcodetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EventCodeName
		{
			set{ _eventcodename=value;}
			get{return _eventcodename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventCodePictureID
		{
			set{ _eventcodepictureid=value;}
			get{return _eventcodepictureid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventUpLoadPriority
		{
			set{ _eventuploadpriority=value;}
			get{return _eventuploadpriority;}
		}
		#endregion Model

	}
}

