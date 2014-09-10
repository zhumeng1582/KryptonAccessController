/**  版本信息模板在安装目录下，可自行修改。
* AntiPassBack.cs
*
* 功 能： N/A
* 类 名： AntiPassBack
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:19   N/A    初版
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
	/// AntiPassBack:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AntiPassBack
	{
		public AntiPassBack()
		{}
		#region Model
		private int _antipassbackid;
		private int? _antipassbackmode=0;
		private bool _antipassenable= true;
		private int? _controlerinfoinlanid1;
		private int? _doorunitid1;
		private int? _controlerinfoinlanid2;
		private int? _doorunitid2;
		private int? _controlerinfoinlanid3;
		private int? _doorunitid3;
		private int? _controlerinfoinlanid4;
		private int? _doorunitid4;
		/// <summary>
		/// 
		/// </summary>
		public int AntiPassBackID
		{
			set{ _antipassbackid=value;}
			get{return _antipassbackid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AntiPassBackMode
		{
			set{ _antipassbackmode=value;}
			get{return _antipassbackmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool AntiPassEnable
		{
			set{ _antipassenable=value;}
			get{return _antipassenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControlerInfoInLANID1
		{
			set{ _controlerinfoinlanid1=value;}
			get{return _controlerinfoinlanid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID1
		{
			set{ _doorunitid1=value;}
			get{return _doorunitid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControlerInfoInLANID2
		{
			set{ _controlerinfoinlanid2=value;}
			get{return _controlerinfoinlanid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID2
		{
			set{ _doorunitid2=value;}
			get{return _doorunitid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControlerInfoInLANID3
		{
			set{ _controlerinfoinlanid3=value;}
			get{return _controlerinfoinlanid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID3
		{
			set{ _doorunitid3=value;}
			get{return _doorunitid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControlerInfoInLANID4
		{
			set{ _controlerinfoinlanid4=value;}
			get{return _controlerinfoinlanid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID4
		{
			set{ _doorunitid4=value;}
			get{return _doorunitid4;}
		}
		#endregion Model

	}
}

