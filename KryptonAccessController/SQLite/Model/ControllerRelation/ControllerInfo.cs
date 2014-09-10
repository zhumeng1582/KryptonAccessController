/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfo.cs
*
* 功 能： N/A
* 类 名： ControllerInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:49   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.SQLite.Model.ControllerRelation
{
	/// <summary>
	/// ControllerInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ControllerInfo
	{
		public ControllerInfo()
		{}
		#region Model
		private int _controllerid;
		private int? _controllertype=1;
		private string _controllername="Controller1";
		private string _controllerlocation;
		private int? _encryptiontype=0;
		private int? _communicatetype=0;
		private string _controllerversion;
		private string _controllermac;
		private string _controllerip="192.168.1.241";
		private string _controllersubnetmask="255.255.255.0";
		private string _controllergateway="192.168.1.1";
		private int? _controllerport=1200;
		private string _controllerdns;
		private string _controllerbudns;
		private int? _controlleraddr485;
		private int? _controllerbaudrate=115200;
		private int? _controllerdatabits=8;
		private int? _controllerstopbits=1;
		private string _controllerparitycheck="None";
		private string _controllerflowcontrol="None";
		private int? _controllersam;
		private int? _controllersamtype;
		private int? _doorunitcounts=2;
		private int? _expansionboardcounts;
		/// <summary>
		/// 
		/// </summary>
		public int ControllerID
		{
			set{ _controllerid=value;}
			get{return _controllerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerType
		{
			set{ _controllertype=value;}
			get{return _controllertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerName
		{
			set{ _controllername=value;}
			get{return _controllername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerLocation
		{
			set{ _controllerlocation=value;}
			get{return _controllerlocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EncryptionType
		{
			set{ _encryptiontype=value;}
			get{return _encryptiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommunicateType
		{
			set{ _communicatetype=value;}
			get{return _communicatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerVersion
		{
			set{ _controllerversion=value;}
			get{return _controllerversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerMAC
		{
			set{ _controllermac=value;}
			get{return _controllermac;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerIP
		{
			set{ _controllerip=value;}
			get{return _controllerip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerSubnetMask
		{
			set{ _controllersubnetmask=value;}
			get{return _controllersubnetmask;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerGateway
		{
			set{ _controllergateway=value;}
			get{return _controllergateway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerPort
		{
			set{ _controllerport=value;}
			get{return _controllerport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerDNS
		{
			set{ _controllerdns=value;}
			get{return _controllerdns;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerBUDNS
		{
			set{ _controllerbudns=value;}
			get{return _controllerbudns;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerAddr485
		{
			set{ _controlleraddr485=value;}
			get{return _controlleraddr485;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerBaudrate
		{
			set{ _controllerbaudrate=value;}
			get{return _controllerbaudrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerDataBits
		{
			set{ _controllerdatabits=value;}
			get{return _controllerdatabits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerStopBits
		{
			set{ _controllerstopbits=value;}
			get{return _controllerstopbits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerParityCheck
		{
			set{ _controllerparitycheck=value;}
			get{return _controllerparitycheck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ControllerFlowControl
		{
			set{ _controllerflowcontrol=value;}
			get{return _controllerflowcontrol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerSAM
		{
			set{ _controllersam=value;}
			get{return _controllersam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControllerSAMType
		{
			set{ _controllersamtype=value;}
			get{return _controllersamtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitCounts
		{
			set{ _doorunitcounts=value;}
			get{return _doorunitcounts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardCounts
		{
			set{ _expansionboardcounts=value;}
			get{return _expansionboardcounts;}
		}
		#endregion Model

	}
}

