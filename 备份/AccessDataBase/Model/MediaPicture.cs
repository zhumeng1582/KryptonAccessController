/**  版本信息模板在安装目录下，可自行修改。
* MediaPicture.cs
*
* 功 能： N/A
* 类 名： MediaPicture
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:34:54   N/A    初版
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
	/// MediaPicture:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MediaPicture
	{
		public MediaPicture()
		{}
		#region Model
		private int _mediapictureid;
		private string _mediapicturename;
		private string _mediapicturepath;
		private int? _mediapicturegroupid;
		private int? _mediapicguretype=1;
		private int? _playpriority;
		/// <summary>
		/// 
		/// </summary>
		public int MediaPictureID
		{
			set{ _mediapictureid=value;}
			get{return _mediapictureid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaPictureName
		{
			set{ _mediapicturename=value;}
			get{return _mediapicturename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaPicturePath
		{
			set{ _mediapicturepath=value;}
			get{return _mediapicturepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaPictureGroupID
		{
			set{ _mediapicturegroupid=value;}
			get{return _mediapicturegroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaPicgureType
		{
			set{ _mediapicguretype=value;}
			get{return _mediapicguretype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayPriority
		{
			set{ _playpriority=value;}
			get{return _playpriority;}
		}
		#endregion Model

	}
}

