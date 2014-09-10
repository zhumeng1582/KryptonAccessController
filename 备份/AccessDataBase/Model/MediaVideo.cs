/**  版本信息模板在安装目录下，可自行修改。
* MediaVideo.cs
*
* 功 能： N/A
* 类 名： MediaVideo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:35:07   N/A    初版
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
	/// MediaVideo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MediaVideo
	{
		public MediaVideo()
		{}
		#region Model
		private int _mediavideoid;
		private string _mediavideoname;
		private string _mediavideofilepath;
		private int? _mediavideogroupid;
		private int? _mediavideotype=1;
		private int? _playpriority;
		/// <summary>
		/// 
		/// </summary>
		public int MediaVideoID
		{
			set{ _mediavideoid=value;}
			get{return _mediavideoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaVideoName
		{
			set{ _mediavideoname=value;}
			get{return _mediavideoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaVideoFilePath
		{
			set{ _mediavideofilepath=value;}
			get{return _mediavideofilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaVideoGroupID
		{
			set{ _mediavideogroupid=value;}
			get{return _mediavideogroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaVideoType
		{
			set{ _mediavideotype=value;}
			get{return _mediavideotype;}
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

