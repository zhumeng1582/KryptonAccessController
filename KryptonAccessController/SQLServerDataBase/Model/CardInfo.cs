/**  版本信息模板在安装目录下，可自行修改。
* CardInfo.cs
*
* 功 能： N/A
* 类 名： CardInfo
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
	/// CardInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CardInfo
	{
		public CardInfo()
		{}
		#region Model
		private string _cardid;
		private string _cardversion= "1";
		private int? _cardtype;
		private string _cardlevel="E";
		private string _cardpassword="000000";
		private string _cardissuedatetime;
		private string _cardvaliddatetime;
		private string _stateflag;
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
		public int? CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardLevel
		{
			set{ _cardlevel=value;}
			get{return _cardlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardPassword
		{
			set{ _cardpassword=value;}
			get{return _cardpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardIssueDateTime
		{
			set{ _cardissuedatetime=value;}
			get{return _cardissuedatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardValidDateTime
		{
			set{ _cardvaliddatetime=value;}
			get{return _cardvaliddatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateFlag
		{
			set{ _stateflag=value;}
			get{return _stateflag;}
		}
		#endregion Model

	}
}

