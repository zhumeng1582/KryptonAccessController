/**  版本信息模板在安装目录下，可自行修改。
* TimeInterControlProgram.cs
*
* 功 能： N/A
* 类 名： TimeInterControlProgram
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
	/// TimeInterControlProgram:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TimeInterControlProgram
	{
		public TimeInterControlProgram()
		{}
		#region Model
		private int _timeicpid;
		private string _timeicpname;
		private bool _timeicpenable= true;
		private bool _timeicploop= true;
		private bool _monenable= true;
		private bool _tueenable= true;
		private bool _wedenable= true;
		private bool _thuenable= true;
		private bool _frienable= true;
		private bool _satenable= true;
		private bool _sunenable= true;
		private string _timepoint="00:00:00";
		private int? _icpid;
		/// <summary>
		/// 
		/// </summary>
		public int TimeICPID
		{
			set{ _timeicpid=value;}
			get{return _timeicpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeICPName
		{
			set{ _timeicpname=value;}
			get{return _timeicpname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeICPEnable
		{
			set{ _timeicpenable=value;}
			get{return _timeicpenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TimeICPLoop
		{
			set{ _timeicploop=value;}
			get{return _timeicploop;}
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
		public int? ICPID
		{
			set{ _icpid=value;}
			get{return _icpid;}
		}
		#endregion Model

	}
}

