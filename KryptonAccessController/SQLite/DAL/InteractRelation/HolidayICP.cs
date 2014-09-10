/**  版本信息模板在安装目录下，可自行修改。
* HolidayICP.cs
*
* 功 能： N/A
* 类 名： HolidayICP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:11   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.InteractRelation
{
	/// <summary>
	/// 数据访问类:HolidayICP
	/// </summary>
	public partial class HolidayICP
	{
		public HolidayICP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("HolidayID", "HolidayICP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HolidayID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HolidayICP");
			strSql.Append(" where HolidayID=@HolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HolidayID", DbType.Int32,4)			};
			parameters[0].Value = HolidayID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HolidayICP(");
			strSql.Append("HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeICPID)");
			strSql.Append(" values (");
			strSql.Append("@HolidayID,@HolidayName,@HolidayStartDate,@HolidayEndDate,@HolidayType,@TimeICPID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HolidayID", DbType.Int32,4),
					new SQLiteParameter("@HolidayName", DbType.String),
					new SQLiteParameter("@HolidayStartDate", DbType.String),
					new SQLiteParameter("@HolidayEndDate", DbType.String),
					new SQLiteParameter("@HolidayType", DbType.Int32,4),
					new SQLiteParameter("@TimeICPID", DbType.Int32,4)};
			parameters[0].Value = model.HolidayID;
			parameters[1].Value = model.HolidayName;
			parameters[2].Value = model.HolidayStartDate;
			parameters[3].Value = model.HolidayEndDate;
			parameters[4].Value = model.HolidayType;
			parameters[5].Value = model.TimeICPID;

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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HolidayICP set ");
			strSql.Append("HolidayName=@HolidayName,");
			strSql.Append("HolidayStartDate=@HolidayStartDate,");
			strSql.Append("HolidayEndDate=@HolidayEndDate,");
			strSql.Append("HolidayType=@HolidayType,");
			strSql.Append("TimeICPID=@TimeICPID");
			strSql.Append(" where HolidayID=@HolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HolidayName", DbType.String),
					new SQLiteParameter("@HolidayStartDate", DbType.String),
					new SQLiteParameter("@HolidayEndDate", DbType.String),
					new SQLiteParameter("@HolidayType", DbType.Int32,4),
					new SQLiteParameter("@TimeICPID", DbType.Int32,4),
					new SQLiteParameter("@HolidayID", DbType.Int32,4)};
			parameters[0].Value = model.HolidayName;
			parameters[1].Value = model.HolidayStartDate;
			parameters[2].Value = model.HolidayEndDate;
			parameters[3].Value = model.HolidayType;
			parameters[4].Value = model.TimeICPID;
			parameters[5].Value = model.HolidayID;

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
		public bool Delete(int HolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidayICP ");
			strSql.Append(" where HolidayID=@HolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HolidayID", DbType.Int32,4)			};
			parameters[0].Value = HolidayID;

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
		public bool DeleteList(string HolidayIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidayICP ");
			strSql.Append(" where HolidayID in ("+HolidayIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP GetModel(int HolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeICPID from HolidayICP ");
			strSql.Append(" where HolidayID=@HolidayID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HolidayID", DbType.Int32,4)			};
			parameters[0].Value = HolidayID;

			KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP model=new KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP();
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
		public KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP model=new KryptonAccessController.SQLite.Model.InteractRelation.HolidayICP();
			if (row != null)
			{
				if(row["HolidayID"]!=null && row["HolidayID"].ToString()!="")
				{
					model.HolidayID=int.Parse(row["HolidayID"].ToString());
				}
				if(row["HolidayName"]!=null)
				{
					model.HolidayName=row["HolidayName"].ToString();
				}
				if(row["HolidayStartDate"]!=null)
				{
					model.HolidayStartDate=row["HolidayStartDate"].ToString();
				}
				if(row["HolidayEndDate"]!=null)
				{
					model.HolidayEndDate=row["HolidayEndDate"].ToString();
				}
				if(row["HolidayType"]!=null && row["HolidayType"].ToString()!="")
				{
					model.HolidayType=int.Parse(row["HolidayType"].ToString());
				}
				if(row["TimeICPID"]!=null && row["TimeICPID"].ToString()!="")
				{
					model.TimeICPID=int.Parse(row["TimeICPID"].ToString());
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
			strSql.Append("select HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeICPID ");
			strSql.Append(" FROM HolidayICP ");
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
			strSql.Append("select count(1) FROM HolidayICP ");
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
				strSql.Append("order by T.HolidayID desc");
			}
			strSql.Append(")AS Row, T.*  from HolidayICP T ");
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
			parameters[0].Value = "HolidayICP";
			parameters[1].Value = "HolidayID";
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

