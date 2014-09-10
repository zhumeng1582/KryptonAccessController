/**  版本信息模板在安装目录下，可自行修改。
* MediaPicture.cs
*
* 功 能： N/A
* 类 名： MediaPicture
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:17   N/A    初版
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
		private byte[] _mediapictureimage;
		private int? _mediapicguretype=1;
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
		public byte[] MediaPictureImage
		{
			set{ _mediapictureimage=value;}
			get{return _mediapictureimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaPicgureType
		{
			set{ _mediapicguretype=value;}
			get{return _mediapicguretype;}
		}
		#endregion Model

	}
}

