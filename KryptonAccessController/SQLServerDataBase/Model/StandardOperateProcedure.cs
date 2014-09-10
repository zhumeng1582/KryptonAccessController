/**  版本信息模板在安装目录下，可自行修改。
* StandardOperateProcedure.cs
*
* 功 能： N/A
* 类 名： StandardOperateProcedure
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:33   N/A    初版
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
	/// StandardOperateProcedure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StandardOperateProcedure
	{
		public StandardOperateProcedure()
		{}
		#region Model
		private int _sopid;
		private string _sopname;
		private int? _sopwaittimelength;
		private int? _descontrollerinfoinlanid;
		private string _action;
		private int? _outputlength;
		/// <summary>
		/// 
		/// </summary>
		public int SOPID
		{
			set{ _sopid=value;}
			get{return _sopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOPName
		{
			set{ _sopname=value;}
			get{return _sopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPWaitTimeLength
		{
			set{ _sopwaittimelength=value;}
			get{return _sopwaittimelength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DesControllerInfoInLANID
		{
			set{ _descontrollerinfoinlanid=value;}
			get{return _descontrollerinfoinlanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutPutLength
		{
			set{ _outputlength=value;}
			get{return _outputlength;}
		}
		#endregion Model

	}
}

