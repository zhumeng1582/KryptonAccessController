/**  版本信息模板在安装目录下，可自行修改。
* InterLock.cs
*
* 功 能： N/A
* 类 名： InterLock
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:26   N/A    初版
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
	/// InterLock:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InterLock
	{
		public InterLock()
		{}
		#region Model
		private int _interlockid;
		private bool _interlockenable= true;
		private int? _controlerinfoinlanid1;
		private int? _doorunitid1;
		private int? _controlerinfoinlanid2;
		private int? _doorunitid2;
		/// <summary>
		/// 
		/// </summary>
		public int InterLockID
		{
			set{ _interlockid=value;}
			get{return _interlockid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool InterLockEnable
		{
			set{ _interlockenable=value;}
			get{return _interlockenable;}
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
		#endregion Model

	}
}

