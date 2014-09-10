/**  版本信息模板在安装目录下，可自行修改。
* InteractHolidayTimeSOPGList.cs
*
* 功 能： N/A
* 类 名： InteractHolidayTimeSOPGList
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
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.AccessSdkDataBase.DAL
{
	/// <summary>
	/// 数据访问类:InteractHolidayTimeSOPGList
	/// </summary>
	public partial class InteractHolidayTimeSOPGList
	{
		public InteractHolidayTimeSOPGList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ListID", "InteractHolidayTimeSOPGList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ListID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InteractHolidayTimeSOPGList");
			strSql.Append(" where ListID=@ListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InteractHolidayTimeSOPGList(");
			strSql.Append("ListID,TimeSOPGID,InteractHolidayID)");
			strSql.Append(" values (");
			strSql.Append("@ListID,@TimeSOPGID,@InteractHolidayID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@TimeSOPGID", SqlDbType.Int,4),
					new SqlParameter("@InteractHolidayID", SqlDbType.Int,4)};
			parameters[0].Value = model.ListID;
			parameters[1].Value = model.TimeSOPGID;
			parameters[2].Value = model.InteractHolidayID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InteractHolidayTimeSOPGList set ");
			strSql.Append("TimeSOPGID=@TimeSOPGID,");
			strSql.Append("InteractHolidayID=@InteractHolidayID");
			strSql.Append(" where ListID=@ListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeSOPGID", SqlDbType.Int,4),
					new SqlParameter("@InteractHolidayID", SqlDbType.Int,4),
					new SqlParameter("@ListID", SqlDbType.Int,4)};
			parameters[0].Value = model.TimeSOPGID;
			parameters[1].Value = model.InteractHolidayID;
			parameters[2].Value = model.ListID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InteractHolidayTimeSOPGList ");
			strSql.Append(" where ListID=@ListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string ListIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InteractHolidayTimeSOPGList ");
			strSql.Append(" where ListID in ("+ListIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList GetModel(int ListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ListID,TimeSOPGID,InteractHolidayID from InteractHolidayTimeSOPGList ");
			strSql.Append(" where ListID=@ListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;

			KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList model=new KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList model=new KryptonAccessController.AccessSdkDataBase.Model.InteractHolidayTimeSOPGList();
			if (row != null)
			{
				if(row["ListID"]!=null && row["ListID"].ToString()!="")
				{
					model.ListID=int.Parse(row["ListID"].ToString());
				}
				if(row["TimeSOPGID"]!=null && row["TimeSOPGID"].ToString()!="")
				{
					model.TimeSOPGID=int.Parse(row["TimeSOPGID"].ToString());
				}
				if(row["InteractHolidayID"]!=null && row["InteractHolidayID"].ToString()!="")
				{
					model.InteractHolidayID=int.Parse(row["InteractHolidayID"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ListID,TimeSOPGID,InteractHolidayID ");
			strSql.Append(" FROM InteractHolidayTimeSOPGList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ListID,TimeSOPGID,InteractHolidayID ");
			strSql.Append(" FROM InteractHolidayTimeSOPGList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM InteractHolidayTimeSOPGList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ListID desc");
			}
			strSql.Append(")AS Row, T.*  from InteractHolidayTimeSOPGList T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "InteractHolidayTimeSOPGList";
			parameters[1].Value = "ListID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

