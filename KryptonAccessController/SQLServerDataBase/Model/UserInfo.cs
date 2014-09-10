/**  版本信息模板在安装目录下，可自行修改。
* UserInfo.cs
*
* 功 能： N/A
* 类 名： UserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:37   N/A    初版
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
	/// UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region Model
		private int _userid;
		private string _username;
		private byte[] _photograph;
		private int? _departmentid;
		private string _employeddate;
		private string _duty;
		private string _telphone;
		private string _email;
		private int? _usergroupid1;
		private int? _usergroupid2;
		private int? _usergroupid3;
		private int? _usergroupid4;
		private int? _fingerposition0;
		private byte[] _fingerprint0;
		private int? _fingerposition1;
		private byte[] _fingerprint1;
		private int? _sercurityaccesslevel=1;
		private string _primarycardid;
		private string _secondcardid;
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
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
		public byte[] Photograph
		{
			set{ _photograph=value;}
			get{return _photograph;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DepartmentID
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmployedDate
		{
			set{ _employeddate=value;}
			get{return _employeddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Duty
		{
			set{ _duty=value;}
			get{return _duty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telphone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserGroupID1
		{
			set{ _usergroupid1=value;}
			get{return _usergroupid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserGroupID2
		{
			set{ _usergroupid2=value;}
			get{return _usergroupid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserGroupID3
		{
			set{ _usergroupid3=value;}
			get{return _usergroupid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserGroupID4
		{
			set{ _usergroupid4=value;}
			get{return _usergroupid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FingerPosition0
		{
			set{ _fingerposition0=value;}
			get{return _fingerposition0;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] FingerPrint0
		{
			set{ _fingerprint0=value;}
			get{return _fingerprint0;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FingerPosition1
		{
			set{ _fingerposition1=value;}
			get{return _fingerposition1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] FingerPrint1
		{
			set{ _fingerprint1=value;}
			get{return _fingerprint1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SercurityAccessLevel
		{
			set{ _sercurityaccesslevel=value;}
			get{return _sercurityaccesslevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrimaryCardID
		{
			set{ _primarycardid=value;}
			get{return _primarycardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SecondCardID
		{
			set{ _secondcardid=value;}
			get{return _secondcardid;}
		}
		#endregion Model

	}
}

