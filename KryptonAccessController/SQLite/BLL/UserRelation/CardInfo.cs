﻿/**  版本信息模板在安装目录下，可自行修改。
* CardInfo.cs
*
* 功 能： N/A
* 类 名： CardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:33   N/A    初版
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
using KryptonAccessController.SQLite.Model.UserRelation;
namespace KryptonAccessController.SQLite.BLL.UserRelation
{
	/// <summary>
	/// CardInfo
	/// </summary>
	public partial class CardInfo
	{
		private readonly KryptonAccessController.SQLite.DAL.UserRelation.CardInfo dal=new KryptonAccessController.SQLite.DAL.UserRelation.CardInfo();
		public CardInfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CardID)
		{
			return dal.Exists(CardID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.UserRelation.CardInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KryptonAccessController.SQLite.Model.UserRelation.CardInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CardID)
		{
			
			return dal.Delete(CardID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CardIDlist )
		{
			return dal.DeleteList(CardIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.SQLite.Model.UserRelation.CardInfo GetModel(string CardID)
		{
			
			return dal.GetModel(CardID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KryptonAccessController.SQLite.Model.UserRelation.CardInfo GetModelByCache(string CardID)
		{
			
			string CacheKey = "CardInfoModel-" + CardID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CardID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KryptonAccessController.SQLite.Model.UserRelation.CardInfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KryptonAccessController.SQLite.Model.UserRelation.CardInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KryptonAccessController.SQLite.Model.UserRelation.CardInfo> DataTableToList(DataTable dt)
		{
			List<KryptonAccessController.SQLite.Model.UserRelation.CardInfo> modelList = new List<KryptonAccessController.SQLite.Model.UserRelation.CardInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KryptonAccessController.SQLite.Model.UserRelation.CardInfo model;
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

