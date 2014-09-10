/**  版本信息模板在安装目录下，可自行修改。
* InteractHolidayTimeICPGList.cs
*
* 功 能： N/A
* 类 名： InteractHolidayTimeICPGList
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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KryptonAccessController.AccessSdkDataBase.Model;
namespace KryptonAccessController.AccessSdkDataBase.BLL
{
	/// <summary>
	/// InteractHolidayTimeICPGList
	/// </summary>
	public partial class InteractHolidayTimeICPGList
	{
		private readonly KryptonAccessController.AccessSdkDataBase.DAL.InteractHolidayTimeICPGList dal=new KryptonAccessController.AccessSdkDataBase.DAL.InteractHolidayTimeICPGList();
		public InteractHolidayTimeICPGList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ListID)
		{
			return dal.Exists(ListID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ListID)
		{
			
			return dal.Delete(ListID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ListIDlist )
		{
			return dal.DeleteList(ListIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList GetModel(int ListID)
		{
			
			return dal.GetModel(ListID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList GetModelByCache(int ListID)
		{
			
			string CacheKey = "InteractHolidayTimeICPGListModel-" + ListID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ListID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList> DataTableToList(DataTable dt)
		{
			List<KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList> modelList = new List<KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeICPGList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

