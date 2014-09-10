/**  版本信息模板在安装目录下，可自行修改。
* DepartmentInfo.cs
*
* 功 能： N/A
* 类 名： DepartmentInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:21   N/A    初版
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
	/// DepartmentInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DepartmentInfo
	{
		public DepartmentInfo()
		{}
		#region Model
		private int _departmentid;
		private string _departmentname;
		private string _departmentdes;
		private string _companyname;
		private string _departmenttel1;
		private string _departmenttel2;
		/// <summary>
		/// 
		/// </summary>
		public int DepartmentID
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentName
		{
			set{ _departmentname=value;}
			get{return _departmentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentDes
		{
			set{ _departmentdes=value;}
			get{return _departmentdes;}
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
		public string DepartmentTel1
		{
			set{ _departmenttel1=value;}
			get{return _departmenttel1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentTel2
		{
			set{ _departmenttel2=value;}
			get{return _departmenttel2;}
		}
		#endregion Model

	}
}

