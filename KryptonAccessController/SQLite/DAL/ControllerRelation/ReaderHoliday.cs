/**  版本信息模板在安装目录下，可自行修改。
* ReaderHoliday.cs
*
* 功 能： N/A
* 类 名： ReaderHoliday
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:51   N/A    初版
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
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.SQLite.DAL.ControllerRelation
{
	/// <summary>
	/// 数据访问类:ReaderHoliday
	/// </summary>
	public partial class ReaderHoliday
	{
		public ReaderHoliday()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ReaderHolidayID", "ReaderHoliday"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderHolidayID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderHoliday");
			strSql.Append(" where ReaderHolidayID=@ReaderHolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderHolidayID", DbType.Int32,4)			};
			parameters[0].Value = ReaderHolidayID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderHoliday(");
			strSql.Append("ReaderHolidayID,ReaderID,ReaderHolidayName,ReaderHolidayType,ReaderHolidayStartDate,ReaderHolidayEndDate)");
			strSql.Append(" values (");
			strSql.Append("@ReaderHolidayID,@ReaderID,@ReaderHolidayName,@ReaderHolidayType,@ReaderHolidayStartDate,@ReaderHolidayEndDate)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderHolidayID", DbType.Int32,4),
					new SQLiteParameter("@ReaderID", DbType.Int32,4),
					new SQLiteParameter("@ReaderHolidayName", DbType.String),
					new SQLiteParameter("@ReaderHolidayType", DbType.Int32,4),
					new SQLiteParameter("@ReaderHolidayStartDate", DbType.String),
					new SQLiteParameter("@ReaderHolidayEndDate", DbType.String)};
			parameters[0].Value = model.ReaderHolidayID;
			parameters[1].Value = model.ReaderID;
			parameters[2].Value = model.ReaderHolidayName;
			parameters[3].Value = model.ReaderHolidayType;
			parameters[4].Value = model.ReaderHolidayStartDate;
			parameters[5].Value = model.ReaderHolidayEndDate;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReaderHoliday set ");
			strSql.Append("ReaderID=@ReaderID,");
			strSql.Append("ReaderHolidayName=@ReaderHolidayName,");
			strSql.Append("ReaderHolidayType=@ReaderHolidayType,");
			strSql.Append("ReaderHolidayStartDate=@ReaderHolidayStartDate,");
			strSql.Append("ReaderHolidayEndDate=@ReaderHolidayEndDate");
			strSql.Append(" where ReaderHolidayID=@ReaderHolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderID", DbType.Int32,4),
					new SQLiteParameter("@ReaderHolidayName", DbType.String),
					new SQLiteParameter("@ReaderHolidayType", DbType.Int32,4),
					new SQLiteParameter("@ReaderHolidayStartDate", DbType.String),
					new SQLiteParameter("@ReaderHolidayEndDate", DbType.String),
					new SQLiteParameter("@ReaderHolidayID", DbType.Int32,4)};
			parameters[0].Value = model.ReaderID;
			parameters[1].Value = model.ReaderHolidayName;
			parameters[2].Value = model.ReaderHolidayType;
			parameters[3].Value = model.ReaderHolidayStartDate;
			parameters[4].Value = model.ReaderHolidayEndDate;
			parameters[5].Value = model.ReaderHolidayID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int ReaderHolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderHoliday ");
			strSql.Append(" where ReaderHolidayID=@ReaderHolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderHolidayID", DbType.Int32,4)			};
			parameters[0].Value = ReaderHolidayID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string ReaderHolidayIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderHoliday ");
			strSql.Append(" where ReaderHolidayID in ("+ReaderHolidayIDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday GetModel(int ReaderHolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ReaderHolidayID,ReaderID,ReaderHolidayName,ReaderHolidayType,ReaderHolidayStartDate,ReaderHolidayEndDate from ReaderHoliday ");
			strSql.Append(" where ReaderHolidayID=@ReaderHolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderHolidayID", DbType.Int32,4)			};
			parameters[0].Value = ReaderHolidayID;

			KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday model=new KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday model=new KryptonAccessController.SQLite.Model.ControllerRelation.ReaderHoliday();
			if (row != null)
			{
				if(row["ReaderHolidayID"]!=null && row["ReaderHolidayID"].ToString()!="")
				{
					model.ReaderHolidayID=int.Parse(row["ReaderHolidayID"].ToString());
				}
				if(row["ReaderID"]!=null && row["ReaderID"].ToString()!="")
				{
					model.ReaderID=int.Parse(row["ReaderID"].ToString());
				}
				if(row["ReaderHolidayName"]!=null)
				{
					model.ReaderHolidayName=row["ReaderHolidayName"].ToString();
				}
				if(row["ReaderHolidayType"]!=null && row["ReaderHolidayType"].ToString()!="")
				{
					model.ReaderHolidayType=int.Parse(row["ReaderHolidayType"].ToString());
				}
				if(row["ReaderHolidayStartDate"]!=null)
				{
					model.ReaderHolidayStartDate=row["ReaderHolidayStartDate"].ToString();
				}
				if(row["ReaderHolidayEndDate"]!=null)
				{
					model.ReaderHolidayEndDate=row["ReaderHolidayEndDate"].ToString();
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
			strSql.Append("select ReaderHolidayID,ReaderID,ReaderHolidayName,ReaderHolidayType,ReaderHolidayStartDate,ReaderHolidayEndDate ");
			strSql.Append(" FROM ReaderHoliday ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ReaderHoliday ");
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
				strSql.Append("order by T.ReaderHolidayID desc");
			}
			strSql.Append(")AS Row, T.*  from ReaderHoliday T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "ReaderHoliday";
			parameters[1].Value = "ReaderHolidayID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

