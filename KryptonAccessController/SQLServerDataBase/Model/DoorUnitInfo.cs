/**  版本信息模板在安装目录下，可自行修改。
* DoorUnitInfo.cs
*
* 功 能： N/A
* 类 名： DoorUnitInfo
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
	/// DoorUnitInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DoorUnitInfo
	{
		public DoorUnitInfo()
		{}
		#region Model
		private int _doorunitid;
		private int? _outputlockid;
		private int? _outputtimelen=6;
		private int? _opendoorovertimelen=20;
		private bool _zonecountlimitenable= false;
		private int? _zonecountlimitmax=0;
		private int? _zonecountlimitmed=0;
		private int? _zonecountlimitmin=0;
		private int? _readid1;
		private bool _readidenable1= true;
		private int? _readid2;
		private bool _readidenable2= false;
		private int? _inputstatetype=2;
		private int? _exitbuttonid=1;
		private int? _exitbuttonmode=1;
		private bool _extibuttonenable= true;
		private int? _doorcontactid=2;
		private int? _doorcontactmode=1;
		private bool _doorcontactenable= true;
		private int? _doorpositionid=3;
		private int? _doorpositionmode=1;
		private bool _doorpositionenable= true;
		private int? _breakglassid=4;
		private int? _breakglassmode=1;
		private bool _breakglassenable= true;
		private int? _electronicmapid=0;
		private int? _positionx=0;
		private int? _positiony=0;
		private byte[] _stateimageopen;
		private byte[] _stateimageclose;
		private byte[] _stateimagealarmopen;
		private byte[] _stateimagealarmclose;
		/// <summary>
		/// 
		/// </summary>
		public int DoorUnitID
		{
			set{ _doorunitid=value;}
			get{return _doorunitid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutPutLockID
		{
			set{ _outputlockid=value;}
			get{return _outputlockid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutPutTimeLen
		{
			set{ _outputtimelen=value;}
			get{return _outputtimelen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OpenDoorOverTimeLen
		{
			set{ _opendoorovertimelen=value;}
			get{return _opendoorovertimelen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ZoneCountLimitEnable
		{
			set{ _zonecountlimitenable=value;}
			get{return _zonecountlimitenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZoneCountLimitMax
		{
			set{ _zonecountlimitmax=value;}
			get{return _zonecountlimitmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZoneCountLimitMed
		{
			set{ _zonecountlimitmed=value;}
			get{return _zonecountlimitmed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZoneCountLimitMin
		{
			set{ _zonecountlimitmin=value;}
			get{return _zonecountlimitmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReadID1
		{
			set{ _readid1=value;}
			get{return _readid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ReadIDEnable1
		{
			set{ _readidenable1=value;}
			get{return _readidenable1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReadID2
		{
			set{ _readid2=value;}
			get{return _readid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ReadIDEnable2
		{
			set{ _readidenable2=value;}
			get{return _readidenable2;}
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
		public int? ExitButtonID
		{
			set{ _exitbuttonid=value;}
			get{return _exitbuttonid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExitButtonMode
		{
			set{ _exitbuttonmode=value;}
			get{return _exitbuttonmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ExtiButtonEnable
		{
			set{ _extibuttonenable=value;}
			get{return _extibuttonenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorContactID
		{
			set{ _doorcontactid=value;}
			get{return _doorcontactid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorContactMode
		{
			set{ _doorcontactmode=value;}
			get{return _doorcontactmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorContactEnable
		{
			set{ _doorcontactenable=value;}
			get{return _doorcontactenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorPositionID
		{
			set{ _doorpositionid=value;}
			get{return _doorpositionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DoorPositionMode
		{
			set{ _doorpositionmode=value;}
			get{return _doorpositionmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DoorPositionEnable
		{
			set{ _doorpositionenable=value;}
			get{return _doorpositionenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BreakGlassID
		{
			set{ _breakglassid=value;}
			get{return _breakglassid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BreakGlassMode
		{
			set{ _breakglassmode=value;}
			get{return _breakglassmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool BreakGlassEnable
		{
			set{ _breakglassenable=value;}
			get{return _breakglassenable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ElectronicMapID
		{
			set{ _electronicmapid=value;}
			get{return _electronicmapid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PositionX
		{
			set{ _positionx=value;}
			get{return _positionx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PositionY
		{
			set{ _positiony=value;}
			get{return _positiony;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] StateImageOpen
		{
			set{ _stateimageopen=value;}
			get{return _stateimageopen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] StateImageClose
		{
			set{ _stateimageclose=value;}
			get{return _stateimageclose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] StateImageAlarmOpen
		{
			set{ _stateimagealarmopen=value;}
			get{return _stateimagealarmopen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] StateImageAlarmClose
		{
			set{ _stateimagealarmclose=value;}
			get{return _stateimagealarmclose;}
		}
		#endregion Model

	}
}

