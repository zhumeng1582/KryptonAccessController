/**  版本信息模板在安装目录下，可自行修改。
* OutPutInfo.cs
*
* 功 能： N/A
* 类 名： OutPutInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:19   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.AccessSdkDataBase.Model
{
	/// <summary>
	/// OutPutInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OutPutInfo
	{
		public OutPutInfo()
		{}
		#region Model
		private int _ouputid;
		private string _outputname="Output1";
		private int? _outputpointid;
		private int? _outputpointstate;
		private int? _expansionboardid;
		/// <summary>
		/// 
		/// </summary>
		public int OuputID
		{
			set{ _ouputid=value;}
			get{return _ouputid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutputName
		{
			set{ _outputname=value;}
			get{return _outputname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutputPointID
		{
			set{ _outputpointid=value;}
			get{return _outputpointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutputPointState
		{
			set{ _outputpointstate=value;}
			get{return _outputpointstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpansionBoardID
		{
			set{ _expansionboardid=value;}
			get{return _expansionboardid;}
		}
		#endregion Model

	}
}

