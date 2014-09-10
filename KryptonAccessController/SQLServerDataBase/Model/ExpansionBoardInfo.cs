/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:24   N/A    初版
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
	/// ExpansionBoardInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpansionBoardInfo
	{
		public ExpansionBoardInfo()
		{}
		#region Model
		private int _expansionboardid;
		private int? _expansionboardtype=1;
		private string _expansionboardname="ExpansionBoard1";
		private int? _expansionboardaddr;
		private int? _inputstatetype=2;
		private string _expansionboardlocation;
		/// <summary>
		/// 
		/// </summary>
		public int ExpansionBoardID
		{
			set{ _expansionboardid=value;}
			get{return _expansionboardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardType
		{
			set{ _expansionboardtype=value;}
			get{return _expansionboardtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpansionBoardName
		{
			set{ _expansionboardname=value;}
			get{return _expansionboardname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardAddr
		{
			set{ _expansionboardaddr=value;}
			get{return _expansionboardaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InputStateType
		{
			set{ _inputstatetype=value;}
			get{return _inputstatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpansionBoardLocation
		{
			set{ _expansionboardlocation=value;}
			get{return _expansionboardlocation;}
		}
		#endregion Model

	}
}

