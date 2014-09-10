/**  版本信息模板在安装目录下，可自行修改。
* ReaderInfo.cs
*
* 功 能： N/A
* 类 名： ReaderInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:31   N/A    初版
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
	/// ReaderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReaderInfo
	{
		public ReaderInfo()
		{}
		#region Model
		private int _readerid;
		private int _readerpointid;
		private string _readertype="A";
		private string _readername;
		private string _readerlocation;
		private string _readerversion;
		private int? _readersam;
		private int? _readersamtype;
		private int? _cardtype;
		private int? _cardreadarea;
		private bool _fingerenable= false;
		private int? _sercurityaccesslevel=1;
		private int? _supervisemode=0;
		private int? _pinidentify=0;
		private string _readerpin="000000";
		private string _duresscode="00001";
		private string _armpassword="000001";
		private string _unarmpassword="000001";
		private int? _communicatetype=0;
		private string _readerip="192.168.1.231";
		private string _readersubnet="255.255.255.0";
		private string _readergateway="192.168.1.1";
		private int? _readerport=1200;
		private string _readerdns;
		private string _readerbudns;
		private int? _readeraddr483;
		private int? _readerbaudrate=115200;
		private int? _readerdatabits=8;
		private int? _readerstopbits=1;
		private string _readerparitycheck="None";
		private string _readerflowcontrol="None";
		private int? _readerusage=1;
		private int? _readtimeaccessid;
		/// <summary>
		/// 
		/// </summary>
		public int ReaderID
		{
			set{ _readerid=value;}
			get{return _readerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReaderPointID
		{
			set{ _readerpointid=value;}
			get{return _readerpointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderType
		{
			set{ _readertype=value;}
			get{return _readertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderName
		{
			set{ _readername=value;}
			get{return _readername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderLocation
		{
			set{ _readerlocation=value;}
			get{return _readerlocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderVersion
		{
			set{ _readerversion=value;}
			get{return _readerversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderSAM
		{
			set{ _readersam=value;}
			get{return _readersam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderSAMType
		{
			set{ _readersamtype=value;}
			get{return _readersamtype;}
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
		public int? CardReadArea
		{
			set{ _cardreadarea=value;}
			get{return _cardreadarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool FingerEnable
		{
			set{ _fingerenable=value;}
			get{return _fingerenable;}
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
		public int? SuperviseMode
		{
			set{ _supervisemode=value;}
			get{return _supervisemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PINIdentify
		{
			set{ _pinidentify=value;}
			get{return _pinidentify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderPIN
		{
			set{ _readerpin=value;}
			get{return _readerpin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DuressCode
		{
			set{ _duresscode=value;}
			get{return _duresscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ArmPassWord
		{
			set{ _armpassword=value;}
			get{return _armpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnarmPassWord
		{
			set{ _unarmpassword=value;}
			get{return _unarmpassword;}
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
		public string ReaderIP
		{
			set{ _readerip=value;}
			get{return _readerip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderSubnet
		{
			set{ _readersubnet=value;}
			get{return _readersubnet;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderGateway
		{
			set{ _readergateway=value;}
			get{return _readergateway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderPort
		{
			set{ _readerport=value;}
			get{return _readerport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderDNS
		{
			set{ _readerdns=value;}
			get{return _readerdns;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderBuDNS
		{
			set{ _readerbudns=value;}
			get{return _readerbudns;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderAddr483
		{
			set{ _readeraddr483=value;}
			get{return _readeraddr483;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderBaudrate
		{
			set{ _readerbaudrate=value;}
			get{return _readerbaudrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderDataBits
		{
			set{ _readerdatabits=value;}
			get{return _readerdatabits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderStopBits
		{
			set{ _readerstopbits=value;}
			get{return _readerstopbits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderParityCheck
		{
			set{ _readerparitycheck=value;}
			get{return _readerparitycheck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReaderFlowControl
		{
			set{ _readerflowcontrol=value;}
			get{return _readerflowcontrol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReaderUsage
		{
			set{ _readerusage=value;}
			get{return _readerusage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReadTimeAccessID
		{
			set{ _readtimeaccessid=value;}
			get{return _readtimeaccessid;}
		}
		#endregion Model

	}
}

