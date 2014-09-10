/**  版本信息模板在安装目录下，可自行修改。
* DepartmentInfo.cs
*
* 功 能： N/A
* 类 名： DepartmentInfo
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
using System.Data;
namespace KryptonAccessController.AccessDataBase.IDAL
{
	/// <summary>
	/// 接口层DepartmentInfo
	/// </summary>
	public interface IDepartmentInfo
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int DepartmentID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(KryptonAccessController.AccessDataBase.Model.DepartmentInfo model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(KryptonAccessController.AccessDataBase.Model.DepartmentInfo model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int DepartmentID);
		bool DeleteList(string DepartmentIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		KryptonAccessController.AccessDataBase.Model.DepartmentInfo GetModel(int DepartmentID);
		KryptonAccessController.AccessDataBase.Model.DepartmentInfo DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
