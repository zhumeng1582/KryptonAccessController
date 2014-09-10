/**  版本信息模板在安装目录下，可自行修改。
* InputInfo.cs
*
* 功 能： N/A
* 类 名： InputInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:15   N/A    初版
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
	/// InputInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InputInfo
	{
		public InputInfo()
		{}
		#region Model
		private int _inputid;
		private string _inputname="Input1";
		private int? _inputpointid;
		private int? _inputpointstate;
		private int? _expansionboardid;
		/// <summary>
		/// 
		/// </summary>
		public int InputID
		{
			set{ _inputid=value;}
			get{return _inputid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InputName
		{
			set{ _inputname=value;}
			get{return _inputname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InputPointID
		{
			set{ _inputpointid=value;}
			get{return _inputpointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InputPointState
		{
			set{ _inputpointstate=value;}
			get{return _inputpointstate;}
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

