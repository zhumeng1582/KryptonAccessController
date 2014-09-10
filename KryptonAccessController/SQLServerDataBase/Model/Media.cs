/**  版本信息模板在安装目录下，可自行修改。
* Media.cs
*
* 功 能： N/A
* 类 名： Media
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:28   N/A    初版
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
	/// Media:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Media
	{
		public Media()
		{}
		#region Model
		private int _mediaid;
		private string _mediafilename;
		private string _mediafilepath;
		private int? _mediagroupid;
		private int? _mediatype;
		private int _playpriority;
		/// <summary>
		/// 
		/// </summary>
		public int MediaID
		{
			set{ _mediaid=value;}
			get{return _mediaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaFileName
		{
			set{ _mediafilename=value;}
			get{return _mediafilename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaFilePath
		{
			set{ _mediafilepath=value;}
			get{return _mediafilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaGroupID
		{
			set{ _mediagroupid=value;}
			get{return _mediagroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaType
		{
			set{ _mediatype=value;}
			get{return _mediatype;}
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

