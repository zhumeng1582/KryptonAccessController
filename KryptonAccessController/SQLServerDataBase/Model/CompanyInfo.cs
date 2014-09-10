/**  版本信息模板在安装目录下，可自行修改。
* CompanyInfo.cs
*
* 功 能： N/A
* 类 名： CompanyInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:20   N/A    初版
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
	/// CompanyInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CompanyInfo
	{
		public CompanyInfo()
		{}
		#region Model
		private int _companyid;
		private string _companyname;
		private string _companydes;
		private string _companyaddress;
		private string _companytel1;
		private string _companytel2;
		/// <summary>
		/// 
		/// </summary>
		public int CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyDes
		{
			set{ _companydes=value;}
			get{return _companydes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyTel1
		{
			set{ _companytel1=value;}
			get{return _companytel1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyTel2
		{
			set{ _companytel2=value;}
			get{return _companytel2;}
		}
		#endregion Model

	}
}

