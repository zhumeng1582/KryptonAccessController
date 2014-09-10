/**  版本信息模板在安装目录下，可自行修改。
* TimeAccess.cs
*
* 功 能： N/A
* 类 名： TimeAccess
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:34   N/A    初版
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
	/// TimeAccess:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TimeAccess
	{
		public TimeAccess()
		{}
		#region Model
		private int _timeaccessid;
		private int? _usergroupid;
		private int? _mon;
		private int? _tue;
		private int? _wed;
		private int? _thu;
		private int? _fri;
		private int? _sat;
		private int? _sun;
		/// <summary>
		/// 
		/// </summary>
		public int TimeAccessID
		{
			set{ _timeaccessid=value;}
			get{return _timeaccessid;}
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
		public int? Mon
		{
			set{ _mon=value;}
			get{return _mon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Tue
		{
			set{ _tue=value;}
			get{return _tue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Wed
		{
			set{ _wed=value;}
			get{return _wed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Thu
		{
			set{ _thu=value;}
			get{return _thu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Fri
		{
			set{ _fri=value;}
			get{return _fri;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sat
		{
			set{ _sat=value;}
			get{return _sat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sun
		{
			set{ _sun=value;}
			get{return _sun;}
		}
		#endregion Model

	}
}

