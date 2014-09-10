/**  版本信息模板在安装目录下，可自行修改。
* UserGroup.cs
*
* 功 能： N/A
* 类 名： UserGroup
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
	/// UserGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserGroup
	{
		public UserGroup()
		{}
		#region Model
		private int _usergroupid;
		private string _usergroupname;
		private string _usergroupdes;
		/// <summary>
		/// 
		/// </summary>
		public int UserGroupID
		{
			set{ _usergroupid=value;}
			get{return _usergroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserGroupName
		{
			set{ _usergroupname=value;}
			get{return _usergroupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserGroupDes
		{
			set{ _usergroupdes=value;}
			get{return _usergroupdes;}
		}
		#endregion Model

	}
}

