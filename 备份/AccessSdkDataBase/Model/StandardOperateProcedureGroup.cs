/**  版本信息模板在安装目录下，可自行修改。
* StandardOperateProcedureGroup.cs
*
* 功 能： N/A
* 类 名： StandardOperateProcedureGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:22   N/A    初版
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
	/// StandardOperateProcedureGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StandardOperateProcedureGroup
	{
		public StandardOperateProcedureGroup()
		{}
		#region Model
		private int _sopgroupid;
		private string _sopgroupname;
		private int? _sopid1;
		private int? _sopid2;
		private int? _sopid3;
		private int? _sopid4;
		private int? _sopid5;
		private int? _sopid6;
		private int? _sopid7;
		private int? _sopid8;
		private int? _sopid9;
		private int? _sopid10;
		private int? _sopid11;
		private int? _sopid12;
		private int? _sopid13;
		private int? _sopid14;
		private int? _sopid15;
		private int? _sopid16;
		private int? _nextsopgroupid=0;
		/// <summary>
		/// 
		/// </summary>
		public int SOPGroupID
		{
			set{ _sopgroupid=value;}
			get{return _sopgroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOPGroupName
		{
			set{ _sopgroupname=value;}
			get{return _sopgroupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID1
		{
			set{ _sopid1=value;}
			get{return _sopid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID2
		{
			set{ _sopid2=value;}
			get{return _sopid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID3
		{
			set{ _sopid3=value;}
			get{return _sopid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID4
		{
			set{ _sopid4=value;}
			get{return _sopid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID5
		{
			set{ _sopid5=value;}
			get{return _sopid5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID6
		{
			set{ _sopid6=value;}
			get{return _sopid6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID7
		{
			set{ _sopid7=value;}
			get{return _sopid7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID8
		{
			set{ _sopid8=value;}
			get{return _sopid8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID9
		{
			set{ _sopid9=value;}
			get{return _sopid9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID10
		{
			set{ _sopid10=value;}
			get{return _sopid10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID11
		{
			set{ _sopid11=value;}
			get{return _sopid11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID12
		{
			set{ _sopid12=value;}
			get{return _sopid12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID13
		{
			set{ _sopid13=value;}
			get{return _sopid13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID14
		{
			set{ _sopid14=value;}
			get{return _sopid14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID15
		{
			set{ _sopid15=value;}
			get{return _sopid15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SOPID16
		{
			set{ _sopid16=value;}
			get{return _sopid16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NextSOPGroupID
		{
			set{ _nextsopgroupid=value;}
			get{return _nextsopgroupid;}
		}
		#endregion Model

	}
}

