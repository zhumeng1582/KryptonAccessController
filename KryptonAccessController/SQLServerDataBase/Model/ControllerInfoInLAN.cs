/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfoInLAN.cs
*
* 功 能： N/A
* 类 名： ControllerInfoInLAN
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
	/// ControllerInfoInLAN:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ControllerInfoInLAN
	{
		public ControllerInfoInLAN()
		{}
		#region Model
		private int _controllerid;
		private string _controllername;
		private int? _controllertype=1;
		private int? _comunicatetype=0;
		private string _controllerip="192.168.1.241";
		private int? _controllerport;
		private int? _controlleraddr485;
		private int? _controllerbaudrate;
		private int? _controllerdatabits;
		private int? _controllerstopbits;
		private string _controllerparitycheck="None";
		private string _controllerflowcontrol="None";
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
		public string ControllerName
		{
			set{ _controllername=value;}
			get{return _controllername;}
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
		public int? ComunicateType
		{
			set{ _comunicatetype=value;}
			get{return _comunicatetype;}
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
		public int? ControllerPort
		{
			set{ _controllerport=value;}
			get{return _controllerport;}
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
		#endregion Model

	}
}

