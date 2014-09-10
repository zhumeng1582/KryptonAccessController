/**  版本信息模板在安装目录下，可自行修改。
* MenuIconInfo.cs
*
* 功 能： N/A
* 类 名： MenuIconInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:41   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.SQLite.Model.ManagerRelation
{
	/// <summary>
	/// MenuIconInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MenuIconInfo
	{
		public MenuIconInfo()
		{}
		#region Model
		private int _menuiconid;
		private string _menuiconname;
		private int? _menuiconcommercial;
		private byte[] _menuiconimage;
		/// <summary>
		/// 
		/// </summary>
		public int MenuIconID
		{
			set{ _menuiconid=value;}
			get{return _menuiconid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuIconName
		{
			set{ _menuiconname=value;}
			get{return _menuiconname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MenuIconCommercial
		{
			set{ _menuiconcommercial=value;}
			get{return _menuiconcommercial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] MenuIconImage
		{
			set{ _menuiconimage=value;}
			get{return _menuiconimage;}
		}
		#endregion Model

	}
}

