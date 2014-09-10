/**  版本信息模板在安装目录下，可自行修改。
* BlackListCardInfo.cs
*
* 功 能： N/A
* 类 名： BlackListCardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:19   N/A    初版
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
	/// BlackListCardInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlackListCardInfo
	{
		public BlackListCardInfo()
		{}
		#region Model
		private string _cardid;
		private string _cardversion= "1";
		private string _carddeactivedatetime;
		private string _username;
		private string _markblistreason;
		private string _bliststateflag;
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardVersion
		{
			set{ _cardversion=value;}
			get{return _cardversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardDeactiveDateTime
		{
			set{ _carddeactivedatetime=value;}
			get{return _carddeactivedatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MarkBListReason
		{
			set{ _markblistreason=value;}
			get{return _markblistreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BListStateFlag
		{
			set{ _bliststateflag=value;}
			get{return _bliststateflag;}
		}
		#endregion Model

	}
}

