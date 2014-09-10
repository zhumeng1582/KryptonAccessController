/**  版本信息模板在安装目录下，可自行修改。
* Manager.cs
*
* 功 能： N/A
* 类 名： Manager
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
	/// Manager:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Manager
	{
		public Manager()
		{}
		#region Model
		private int _managerid;
		private string _managername;
		private string _managerpassword;
		private bool _issupermanager= true;
		/// <summary>
		/// 
		/// </summary>
		public int ManagerID
		{
			set{ _managerid=value;}
			get{return _managerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManagerName
		{
			set{ _managername=value;}
			get{return _managername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManagerPassWord
		{
			set{ _managerpassword=value;}
			get{return _managerpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsSuperManager
		{
			set{ _issupermanager=value;}
			get{return _issupermanager;}
		}
		#endregion Model

	}
}

