/**  版本信息模板在安装目录下，可自行修改。
* TimeStandardOperateProcedureGroup.cs
*
* 功 能： N/A
* 类 名： TimeStandardOperateProcedureGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:23   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.AccessSdkDataBase.Model
{
	/// <summary>
	/// TimeStandardOperateProcedureGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TimeStandardOperateProcedureGroup
	{
		public TimeStandardOperateProcedureGroup()
		{}
		#region Model
		private int _timesopgid;
		private string _timesopgname;
		private bool _timesopgenable= true;
		private bool _timesopgloop= true;
		private bool _monenable= true;
		private bool _tueenable= true;
		private bool _wedenable= true;
		private bool _thuenable= true;
		private bool _frienable= true;
		private bool _satenable= true;
		private bool _sunenable= true;
		private string _timepoint;
		private int? _sopgroupid;
		/// <summary>
		/// 
		/// </summary>
		public int TimeSOPGID
		{
			set{ _timesopgid=value;}
			get{return _timesopgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeSOPGName
		{
			set{ _timesopgname=value;}
			get{return _timesopgname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeSOPGEnable
		{
			set{ _timesopgenable=value;}
			get{return _timesopgenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeSOPGLoop
		{
			set{ _timesopgloop=value;}
			get{return _timesopgloop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool MonEnable
		{
			set{ _monenable=value;}
			get{return _monenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TueEnable
		{
			set{ _tueenable=value;}
			get{return _tueenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool WedEnable
		{
			set{ _wedenable=value;}
			get{return _wedenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ThuEnable
		{
			set{ _thuenable=value;}
			get{return _thuenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool FriEnable
		{
			set{ _frienable=value;}
			get{return _frienable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SatEnable
		{
			set{ _satenable=value;}
			get{return _satenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SunEnable
		{
			set{ _sunenable=value;}
			get{return _sunenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimePoint
		{
			set{ _timepoint=value;}
			get{return _timepoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPGroupID
		{
			set{ _sopgroupid=value;}
			get{return _sopgroupid;}
		}
		#endregion Model

	}
}

