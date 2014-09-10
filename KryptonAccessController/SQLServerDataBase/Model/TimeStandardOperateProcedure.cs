/**  版本信息模板在安装目录下，可自行修改。
* TimeStandardOperateProcedure.cs
*
* 功 能： N/A
* 类 名： TimeStandardOperateProcedure
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:35   N/A    初版
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
	/// TimeStandardOperateProcedure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TimeStandardOperateProcedure
	{
		public TimeStandardOperateProcedure()
		{}
		#region Model
		private int _timesopid;
		private string _timesopname;
		private bool _timesopenable= true;
		private bool _timesoploop= true;
		private bool _monenable= true;
		private bool _tueenable= true;
		private bool _wedenable= true;
		private bool _thuenable= true;
		private bool _frienable= true;
		private bool _satenable= true;
		private bool _sunenable= true;
		private string _timepoint="00:00:00";
		private int? _sopid;
		/// <summary>
		/// 
		/// </summary>
		public int TimeSOPID
		{
			set{ _timesopid=value;}
			get{return _timesopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeSOPName
		{
			set{ _timesopname=value;}
			get{return _timesopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeSOPEnable
		{
			set{ _timesopenable=value;}
			get{return _timesopenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeSOPLoop
		{
			set{ _timesoploop=value;}
			get{return _timesoploop;}
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
		public int? SOPID
		{
			set{ _sopid=value;}
			get{return _sopid;}
		}
		#endregion Model

	}
}

