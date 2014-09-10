/**  版本信息模板在安装目录下，可自行修改。
* TimeZone.cs
*
* 功 能： N/A
* 类 名： TimeZone
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:36   N/A    初版
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
	/// TimeZone:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TimeZone
	{
		public TimeZone()
		{}
		#region Model
		private int _timezoneid;
		private string _stime1="00:00";
		private string _etime1="23:59";
		private string _stime2="00:00";
		private string _etime2="00:00";
		private string _stime3="00:00";
		private string _etime3="00:00";
		private string _stime4="00:00";
		private string _etime4="00:00";
		private string _stime5="00:00";
		private string _etime5="00:00";
		private string _stime6="00:00";
		private string _etime6="00:00";
		/// <summary>
		/// 
		/// </summary>
		public int TimeZoneID
		{
			set{ _timezoneid=value;}
			get{return _timezoneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime1
		{
			set{ _stime1=value;}
			get{return _stime1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime1
		{
			set{ _etime1=value;}
			get{return _etime1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime2
		{
			set{ _stime2=value;}
			get{return _stime2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime2
		{
			set{ _etime2=value;}
			get{return _etime2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime3
		{
			set{ _stime3=value;}
			get{return _stime3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime3
		{
			set{ _etime3=value;}
			get{return _etime3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime4
		{
			set{ _stime4=value;}
			get{return _stime4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime4
		{
			set{ _etime4=value;}
			get{return _etime4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime5
		{
			set{ _stime5=value;}
			get{return _stime5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime5
		{
			set{ _etime5=value;}
			get{return _etime5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STime6
		{
			set{ _stime6=value;}
			get{return _stime6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETime6
		{
			set{ _etime6=value;}
			get{return _etime6;}
		}
		#endregion Model

	}
}

