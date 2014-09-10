/**  版本信息模板在安装目录下，可自行修改。
* ReaderHolidayList.cs
*
* 功 能： N/A
* 类 名： ReaderHolidayList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:20   N/A    初版
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
	/// 数据访问类:ReaderHolidayList
	/// </summary>
	public partial class ReaderHolidayList
	{
		public ReaderHolidayList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReaderHolidayListID", "ReaderHolidayList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderHolidayListID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderHolidayList");
			strSql.Append(" where ReaderHolidayListID=@ReaderHolidayListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderHolidayListID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderHolidayListID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderHolidayList(");
			strSql.Append("ReaderHolidayListID,ReaderID,ReaderHolidayID)");
			strSql.Append(" values (");
			strSql.Append("@ReaderHolidayListID,@ReaderID,@ReaderHolidayID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderHolidayListID", SqlDbType.Int,4),
					new SqlParameter("@ReaderID", SqlDbType.Int,4),
					new SqlParameter("@ReaderHolidayID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReaderHolidayListID;
			parameters[1].Value = model.ReaderID;
			parameters[2].Value = model.ReaderHolidayID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReaderHolidayList set ");
			strSql.Append("ReaderID=@ReaderID,");
			strSql.Append("ReaderHolidayID=@ReaderHolidayID");
			strSql.Append(" where ReaderHolidayListID=@ReaderHolidayListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderID", SqlDbType.Int,4),
					new SqlParameter("@ReaderHolidayID", SqlDbType.Int,4),
					new SqlParameter("@ReaderHolidayListID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReaderID;
			parameters[1].Value = model.ReaderHolidayID;
			parameters[2].Value = model.ReaderHolidayListID;

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
		public bool Delete(int ReaderHolidayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderHolidayList ");
			strSql.Append(" where ReaderHolidayListID=@ReaderHolidayListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderHolidayListID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderHolidayListID;

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
		public bool DeleteList(string ReaderHolidayListIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderHolidayList ");
			strSql.Append(" where ReaderHolidayListID in ("+ReaderHolidayListIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList GetModel(int ReaderHolidayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReaderHolidayListID,ReaderID,ReaderHolidayID from ReaderHolidayList ");
			strSql.Append(" where ReaderHolidayListID=@ReaderHolidayListID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderHolidayListID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderHolidayListID;

			KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList model=new KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList();
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
		public KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList model=new KryptonAccessController.AccessSdkDataBase.Model.ReaderHolidayList();
			if (row != null)
			{
				if(row["ReaderHolidayListID"]!=null && row["ReaderHolidayListID"].ToString()!="")
				{
					model.ReaderHolidayListID=int.Parse(row["ReaderHolidayListID"].ToString());
				}
				if(row["ReaderID"]!=null && row["ReaderID"].ToString()!="")
				{
					model.ReaderID=int.Parse(row["ReaderID"].ToString());
				}
				if(row["ReaderHolidayID"]!=null && row["ReaderHolidayID"].ToString()!="")
				{
					model.ReaderHolidayID=int.Parse(row["ReaderHolidayID"].ToString());
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
			strSql.Append("select ReaderHolidayListID,ReaderID,ReaderHolidayID ");
			strSql.Append(" FROM ReaderHolidayList ");
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
			strSql.Append(" ReaderHolidayListID,ReaderID,ReaderHolidayID ");
			strSql.Append(" FROM ReaderHolidayList ");
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
			strSql.Append("select count(1) FROM ReaderHolidayList ");
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
				strSql.Append("order by T.ReaderHolidayListID desc");
			}
			strSql.Append(")AS Row, T.*  from ReaderHolidayList T ");
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
			parameters[0].Value = "ReaderHolidayList";
			parameters[1].Value = "ReaderHolidayListID";
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

