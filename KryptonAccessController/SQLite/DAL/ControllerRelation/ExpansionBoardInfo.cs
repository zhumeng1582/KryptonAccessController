/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:50   N/A    初版
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
	/// 数据访问类:ExpansionBoardInfo
	/// </summary>
	public partial class ExpansionBoardInfo
	{
		public ExpansionBoardInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ExpansionBoardID", "ExpansionBoardInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ExpansionBoardID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExpansionBoardInfo");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExpansionBoardInfo(");
			strSql.Append("ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation)");
			strSql.Append(" values (");
			strSql.Append("@ExpansionBoardID,@ExpansionBoardType,@ExpansionBoardName,@ExpansionBoardAddr,@InputStateType,@ExpansionBoardLocation)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardType", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardName", DbType.String),
					new SQLiteParameter("@ExpansionBoardAddr", DbType.Int32,4),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardLocation", DbType.String)};
			parameters[0].Value = model.ExpansionBoardID;
			parameters[1].Value = model.ExpansionBoardType;
			parameters[2].Value = model.ExpansionBoardName;
			parameters[3].Value = model.ExpansionBoardAddr;
			parameters[4].Value = model.InputStateType;
			parameters[5].Value = model.ExpansionBoardLocation;

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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExpansionBoardInfo set ");
			strSql.Append("ExpansionBoardType=@ExpansionBoardType,");
			strSql.Append("ExpansionBoardName=@ExpansionBoardName,");
			strSql.Append("ExpansionBoardAddr=@ExpansionBoardAddr,");
			strSql.Append("InputStateType=@InputStateType,");
			strSql.Append("ExpansionBoardLocation=@ExpansionBoardLocation");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardType", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardName", DbType.String),
					new SQLiteParameter("@ExpansionBoardAddr", DbType.Int32,4),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardLocation", DbType.String),
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4)};
			parameters[0].Value = model.ExpansionBoardType;
			parameters[1].Value = model.ExpansionBoardName;
			parameters[2].Value = model.ExpansionBoardAddr;
			parameters[3].Value = model.InputStateType;
			parameters[4].Value = model.ExpansionBoardLocation;
			parameters[5].Value = model.ExpansionBoardID;

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
		public bool Delete(int ExpansionBoardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardID;

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
		public bool DeleteList(string ExpansionBoardIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID in ("+ExpansionBoardIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo GetModel(int ExpansionBoardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardID;

			KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardInfo();
			if (row != null)
			{
				if(row["ExpansionBoardID"]!=null && row["ExpansionBoardID"].ToString()!="")
				{
					model.ExpansionBoardID=int.Parse(row["ExpansionBoardID"].ToString());
				}
				if(row["ExpansionBoardType"]!=null && row["ExpansionBoardType"].ToString()!="")
				{
					model.ExpansionBoardType=int.Parse(row["ExpansionBoardType"].ToString());
				}
				if(row["ExpansionBoardName"]!=null)
				{
					model.ExpansionBoardName=row["ExpansionBoardName"].ToString();
				}
				if(row["ExpansionBoardAddr"]!=null && row["ExpansionBoardAddr"].ToString()!="")
				{
					model.ExpansionBoardAddr=int.Parse(row["ExpansionBoardAddr"].ToString());
				}
				if(row["InputStateType"]!=null && row["InputStateType"].ToString()!="")
				{
					model.InputStateType=int.Parse(row["InputStateType"].ToString());
				}
				if(row["ExpansionBoardLocation"]!=null)
				{
					model.ExpansionBoardLocation=row["ExpansionBoardLocation"].ToString();
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
			strSql.Append("select ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation ");
			strSql.Append(" FROM ExpansionBoardInfo ");
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
			strSql.Append("select count(1) FROM ExpansionBoardInfo ");
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
				strSql.Append("order by T.ExpansionBoardID desc");
			}
			strSql.Append(")AS Row, T.*  from ExpansionBoardInfo T ");
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
			parameters[0].Value = "ExpansionBoardInfo";
			parameters[1].Value = "ExpansionBoardID";
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

