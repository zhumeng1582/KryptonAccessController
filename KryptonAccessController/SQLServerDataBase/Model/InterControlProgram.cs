/**  版本信息模板在安装目录下，可自行修改。
* InterControlProgram.cs
*
* 功 能： N/A
* 类 名： InterControlProgram
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:26   N/A    初版
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
	/// InterControlProgram:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InterControlProgram
	{
		public InterControlProgram()
		{}
		#region Model
		private int _icpid;
		private string _icpname;
		private int? _icpwaittimelength;
		private int? _descontrollerinfoinlanid;
		private int? _pointtype;
		private int? _pointid;
		private int? _pointstate;
		private int? _outputlength;
		/// <summary>
		/// 
		/// </summary>
		public int ICPID
		{
			set{ _icpid=value;}
			get{return _icpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ICPName
		{
			set{ _icpname=value;}
			get{return _icpname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICPWaitTimeLength
		{
			set{ _icpwaittimelength=value;}
			get{return _icpwaittimelength;}
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
		public int? PointType
		{
			set{ _pointtype=value;}
			get{return _pointtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointState
		{
			set{ _pointstate=value;}
			get{return _pointstate;}
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

