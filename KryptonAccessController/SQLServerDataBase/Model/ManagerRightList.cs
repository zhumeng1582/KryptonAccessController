/**  版本信息模板在安装目录下，可自行修改。
* ManagerRightList.cs
*
* 功 能： N/A
* 类 名： ManagerRightList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:27   N/A    初版
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
	/// ManagerRightList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManagerRightList
	{
		public ManagerRightList()
		{}
		#region Model
		private int _managerrightlistid;
		private int? _managerid;
		private int? _menuid;
		/// <summary>
		/// 
		/// </summary>
		public int ManagerRightListID
		{
			set{ _managerrightlistid=value;}
			get{return _managerrightlistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ManagerID
		{
			set{ _managerid=value;}
			get{return _managerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		#endregion Model

	}
}

