/**  版本信息模板在安装目录下，可自行修改。
* PlayMediaInfo.cs
*
* 功 能： N/A
* 类 名： PlayMediaInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:19   N/A    初版
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
	/// PlayMediaInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PlayMediaInfo
	{
		public PlayMediaInfo()
		{}
		#region Model
		private int _playmediaid;
		private string _playmedianame;
		private int? _playreaderid;
		private int? _playtimezone;
		private bool _playloop= true;
		private int? _playtype1;
		private int? _playmediagroupid1;
		private int? _playtype2;
		private int? _playmediagroupid2;
		private int? _playtype3;
		private int? _playmediagroupid3;
		private int? _playtype4;
		private int? _playmediagroupid4;
		private int? _playtype5;
		private int? _playmediagroupid5;
		private int? _playtype6;
		private int? _playmediagroupid6;
		/// <summary>
		/// 
		/// </summary>
		public int PlayMediaID
		{
			set{ _playmediaid=value;}
			get{return _playmediaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlayMediaName
		{
			set{ _playmedianame=value;}
			get{return _playmedianame;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayReaderID
		{
			set{ _playreaderid=value;}
			get{return _playreaderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayTimeZone
		{
			set{ _playtimezone=value;}
			get{return _playtimezone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PlayLoop
		{
			set{ _playloop=value;}
			get{return _playloop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType1
		{
			set{ _playtype1=value;}
			get{return _playtype1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID1
		{
			set{ _playmediagroupid1=value;}
			get{return _playmediagroupid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType2
		{
			set{ _playtype2=value;}
			get{return _playtype2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID2
		{
			set{ _playmediagroupid2=value;}
			get{return _playmediagroupid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType3
		{
			set{ _playtype3=value;}
			get{return _playtype3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID3
		{
			set{ _playmediagroupid3=value;}
			get{return _playmediagroupid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType4
		{
			set{ _playtype4=value;}
			get{return _playtype4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID4
		{
			set{ _playmediagroupid4=value;}
			get{return _playmediagroupid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType5
		{
			set{ _playtype5=value;}
			get{return _playtype5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID5
		{
			set{ _playmediagroupid5=value;}
			get{return _playmediagroupid5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayType6
		{
			set{ _playtype6=value;}
			get{return _playtype6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayMediaGroupID6
		{
			set{ _playmediagroupid6=value;}
			get{return _playmediagroupid6;}
		}
		#endregion Model

	}
}

