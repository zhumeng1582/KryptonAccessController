/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfo.cs
*
* 功 能： N/A
* 类 名： ControllerInfo
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
		private string _controllerparitycheck="None";
		private string _controllerflowcontrol="None";
		private int? _controllersam;
		private int? _controllersamtype;
		private int? _auxoutputpointid=0x0A;
		private int? _inputstatetype=2;
		private int? _firesensingid=0x0A;
		private int? _firesensingmode=1;
		private bool _firesensingenable= true;
		private int? _tampersensingid=0x0B;
		private int? _tampersensingmode=1;
		private bool _tampersensingenable= true;
		private int? _lowvoltageid=0x0C;
		private int? _lowvoltagemode=1;
		private bool _lowvoltageenable= true;
		private int? _poweroutageid=0x0D;
		private int? _poweroutagemode=1;
		private bool _poweroutageenable= true;
		private int? _doorunitid1;
		private bool _doorunitenable1;
		private int? _doorunitid2;
		private bool _doorunitenable2;
		private int? _doorunitid3;
		private bool _doorunitenable3;
		private int? _doorunitid4;
		private bool _doorunitenable4;
		private int? _expansionboardid1;
		private bool _expansionboardenable1;
		private int? _expansionboardid2;
		private bool _expansionboardenable2;
		private int? _expansionboardid3;
		private bool _expansionboardenable3;
		private int? _expansionboardid4;
		private bool _expansionboardenable4;
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
		public int? AuxOutPutPointID
		{
			set{ _auxoutputpointid=value;}
			get{return _auxoutputpointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InputStateType
		{
			set{ _inputstatetype=value;}
			get{return _inputstatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FireSensingID
		{
			set{ _firesensingid=value;}
			get{return _firesensingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FireSensingMode
		{
			set{ _firesensingmode=value;}
			get{return _firesensingmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool FireSensingEnable
		{
			set{ _firesensingenable=value;}
			get{return _firesensingenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TamperSensingID
		{
			set{ _tampersensingid=value;}
			get{return _tampersensingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TamperSensingMode
		{
			set{ _tampersensingmode=value;}
			get{return _tampersensingmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool TamperSensingEnable
		{
			set{ _tampersensingenable=value;}
			get{return _tampersensingenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LowVoltageID
		{
			set{ _lowvoltageid=value;}
			get{return _lowvoltageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LowVoltageMode
		{
			set{ _lowvoltagemode=value;}
			get{return _lowvoltagemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool LowVoltageEnable
		{
			set{ _lowvoltageenable=value;}
			get{return _lowvoltageenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PowerOutageID
		{
			set{ _poweroutageid=value;}
			get{return _poweroutageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PowerOutageMode
		{
			set{ _poweroutagemode=value;}
			get{return _poweroutagemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PowerOutageEnable
		{
			set{ _poweroutageenable=value;}
			get{return _poweroutageenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID1
		{
			set{ _doorunitid1=value;}
			get{return _doorunitid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorUnitEnable1
		{
			set{ _doorunitenable1=value;}
			get{return _doorunitenable1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID2
		{
			set{ _doorunitid2=value;}
			get{return _doorunitid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorUnitEnable2
		{
			set{ _doorunitenable2=value;}
			get{return _doorunitenable2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID3
		{
			set{ _doorunitid3=value;}
			get{return _doorunitid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorUnitEnable3
		{
			set{ _doorunitenable3=value;}
			get{return _doorunitenable3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorUnitID4
		{
			set{ _doorunitid4=value;}
			get{return _doorunitid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorUnitEnable4
		{
			set{ _doorunitenable4=value;}
			get{return _doorunitenable4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID1
		{
			set{ _expansionboardid1=value;}
			get{return _expansionboardid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ExpansionBoardEnable1
		{
			set{ _expansionboardenable1=value;}
			get{return _expansionboardenable1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID2
		{
			set{ _expansionboardid2=value;}
			get{return _expansionboardid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ExpansionBoardEnable2
		{
			set{ _expansionboardenable2=value;}
			get{return _expansionboardenable2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID3
		{
			set{ _expansionboardid3=value;}
			get{return _expansionboardid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ExpansionBoardEnable3
		{
			set{ _expansionboardenable3=value;}
			get{return _expansionboardenable3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID4
		{
			set{ _expansionboardid4=value;}
			get{return _expansionboardid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ExpansionBoardEnable4
		{
			set{ _expansionboardenable4=value;}
			get{return _expansionboardenable4;}
		}
		#endregion Model

	}
}

