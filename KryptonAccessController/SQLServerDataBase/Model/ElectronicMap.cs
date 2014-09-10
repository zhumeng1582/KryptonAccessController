/**  版本信息模板在安装目录下，可自行修改。
* ElectronicMap.cs
*
* 功 能： N/A
* 类 名： ElectronicMap
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
	/// ElectronicMap:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ElectronicMap
	{
		public ElectronicMap()
		{}
		#region Model
		private int _electronicmapid;
		private string _electronicmapname;
		private string _electronicmapdes;
		private byte[] _map;
		/// <summary>
		/// 
		/// </summary>
		public int ElectronicMapID
		{
			set{ _electronicmapid=value;}
			get{return _electronicmapid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ElectronicMapName
		{
			set{ _electronicmapname=value;}
			get{return _electronicmapname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ElectronicMapDes
		{
			set{ _electronicmapdes=value;}
			get{return _electronicmapdes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] Map
		{
			set{ _map=value;}
			get{return _map;}
		}
		#endregion Model

	}
}

