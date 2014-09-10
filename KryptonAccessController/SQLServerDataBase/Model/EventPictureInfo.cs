/**  版本信息模板在安装目录下，可自行修改。
* EventPictureInfo.cs
*
* 功 能： N/A
* 类 名： EventPictureInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:23   N/A    初版
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
	/// EventPictureInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EventPictureInfo
	{
		public EventPictureInfo()
		{}
		#region Model
		private int _eventpictureid;
		private string _eventpicturename;
		private int? _eventpicturecomercial=1;
		private int? _eventpicturetype=1;
		private byte[] _eventpictureimage;
		/// <summary>
		/// 
		/// </summary>
		public int EventPictureID
		{
			set{ _eventpictureid=value;}
			get{return _eventpictureid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EventPictureName
		{
			set{ _eventpicturename=value;}
			get{return _eventpicturename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventPictureComercial
		{
			set{ _eventpicturecomercial=value;}
			get{return _eventpicturecomercial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EventPictureType
		{
			set{ _eventpicturetype=value;}
			get{return _eventpicturetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] EventPictureImage
		{
			set{ _eventpictureimage=value;}
			get{return _eventpictureimage;}
		}
		#endregion Model

	}
}

