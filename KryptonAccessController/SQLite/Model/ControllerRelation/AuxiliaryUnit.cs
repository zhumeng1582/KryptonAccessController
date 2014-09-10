/**  版本信息模板在安装目录下，可自行修改。
* AuxiliaryUnit.cs
*
* 功 能： N/A
* 类 名： AuxiliaryUnit
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
	/// AuxiliaryUnit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AuxiliaryUnit
	{
		public AuxiliaryUnit()
		{}
		#region Model
		private int _auxiliaryunitid;
		private int? _auxoutputpointid=10;
		private int? _inputstatetype=2;
		private int? _firesensingid=10;
		private int? _firesensingmode=1;
		private bool _firesensingenable= true;
		private int? _tampersensingid=11;
		private int? _tampersensingmode=1;
		private bool _tampersensingenable= true;
		private int? _lowvoltageid=12;
		private int? _lowvoltagemode=1;
		private bool _lowvoltageenable= true;
		private int? _poweroutageid=13;
		private int? _poweroutagemode=1;
		private bool _poweroutageenable= true;
		/// <summary>
		/// 
		/// </summary>
		public int AuxiliaryUnitID
		{
			set{ _auxiliaryunitid=value;}
			get{return _auxiliaryunitid;}
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
		#endregion Model

	}
}

