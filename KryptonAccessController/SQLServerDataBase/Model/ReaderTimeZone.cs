/**  版本信息模板在安装目录下，可自行修改。
* ReaderTimeZone.cs
*
* 功 能： N/A
* 类 名： ReaderTimeZone
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:32   N/A    初版
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
	/// ReaderTimeZone:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReaderTimeZone
	{
		public ReaderTimeZone()
		{}
		#region Model
		private int _readertimezoneid;
		private int? _operatemode1=1;
		private string _timezone1="00:00";
		private int? _operatemode2=1;
		private string _timezone2="23:59";
		private int? _operatemode3=1;
		private string _timezone3="00:00";
		private int? _operatemode4=1;
		private string _timezone4="00:00";
		private int? _operatemode5=1;
		private string _timezone5="00:00";
		private int? _operatemode6=1;
		private string _timezone6="00:00";
		/// <summary>
		/// 
		/// </summary>
		public int ReaderTimeZoneID
		{
			set{ _readertimezoneid=value;}
			get{return _readertimezoneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode1
		{
			set{ _operatemode1=value;}
			get{return _operatemode1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone1
		{
			set{ _timezone1=value;}
			get{return _timezone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode2
		{
			set{ _operatemode2=value;}
			get{return _operatemode2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone2
		{
			set{ _timezone2=value;}
			get{return _timezone2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode3
		{
			set{ _operatemode3=value;}
			get{return _operatemode3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone3
		{
			set{ _timezone3=value;}
			get{return _timezone3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode4
		{
			set{ _operatemode4=value;}
			get{return _operatemode4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone4
		{
			set{ _timezone4=value;}
			get{return _timezone4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode5
		{
			set{ _operatemode5=value;}
			get{return _operatemode5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone5
		{
			set{ _timezone5=value;}
			get{return _timezone5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateMode6
		{
			set{ _operatemode6=value;}
			get{return _operatemode6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TimeZone6
		{
			set{ _timezone6=value;}
			get{return _timezone6;}
		}
		#endregion Model

	}
}

