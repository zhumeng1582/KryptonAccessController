/**  版本信息模板在安装目录下，可自行修改。
* PictureGroupPictureList.cs
*
* 功 能： N/A
* 类 名： PictureGroupPictureList
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
	/// PictureGroupPictureList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PictureGroupPictureList
	{
		public PictureGroupPictureList()
		{}
		#region Model
		private int _listid;
		private string _listname;
		private int? _mendiapicturegroupid;
		private int? _mendiapictureid;
		private int _playpriority;
		/// <summary>
		/// 
		/// </summary>
		public int ListID
		{
			set{ _listid=value;}
			get{return _listid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ListName
		{
			set{ _listname=value;}
			get{return _listname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MendiaPictureGroupID
		{
			set{ _mendiapicturegroupid=value;}
			get{return _mendiapicturegroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MendiaPictureID
		{
			set{ _mendiapictureid=value;}
			get{return _mendiapictureid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PlayPriority
		{
			set{ _playpriority=value;}
			get{return _playpriority;}
		}
		#endregion Model

	}
}

