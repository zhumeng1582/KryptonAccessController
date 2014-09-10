/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardPointInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardPointInfo
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
	/// 数据访问类:ExpansionBoardPointInfo
	/// </summary>
	public partial class ExpansionBoardPointInfo
	{
		public ExpansionBoardPointInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ExpansionBoardPointID", "ExpansionBoardPointInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ExpansionBoardPointID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExpansionBoardPointInfo");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardPointID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardPointID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExpansionBoardPointInfo(");
			strSql.Append("ExpansionBoardPointID,InputName,PointType,PointID,PointState,ExpansionBoardID)");
			strSql.Append(" values (");
			strSql.Append("@ExpansionBoardPointID,@InputName,@PointType,@PointID,@PointState,@ExpansionBoardID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardPointID", DbType.Int32,4),
					new SQLiteParameter("@InputName", DbType.String),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@PointState", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4)};
			parameters[0].Value = model.ExpansionBoardPointID;
			parameters[1].Value = model.InputName;
			parameters[2].Value = model.PointType;
			parameters[3].Value = model.PointID;
			parameters[4].Value = model.PointState;
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
		/// 更新一条数据
		/// </summary>
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExpansionBoardPointInfo set ");
			strSql.Append("InputName=@InputName,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("PointState=@PointState,");
			strSql.Append("ExpansionBoardID=@ExpansionBoardID");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@InputName", DbType.String),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@PointState", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardID", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardPointID", DbType.Int32,4)};
			parameters[0].Value = model.InputName;
			parameters[1].Value = model.PointType;
			parameters[2].Value = model.PointID;
			parameters[3].Value = model.PointState;
			parameters[4].Value = model.ExpansionBoardID;
			parameters[5].Value = model.ExpansionBoardPointID;

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
		public bool Delete(int ExpansionBoardPointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardPointID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardPointID;

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
		public bool DeleteList(string ExpansionBoardPointIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID in ("+ExpansionBoardPointIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo GetModel(int ExpansionBoardPointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ExpansionBoardPointID,InputName,PointType,PointID,PointState,ExpansionBoardID from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ExpansionBoardPointID", DbType.Int32,4)			};
			parameters[0].Value = ExpansionBoardPointID;

			KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ExpansionBoardPointInfo();
			if (row != null)
			{
				if(row["ExpansionBoardPointID"]!=null && row["ExpansionBoardPointID"].ToString()!="")
				{
					model.ExpansionBoardPointID=int.Parse(row["ExpansionBoardPointID"].ToString());
				}
				if(row["InputName"]!=null)
				{
					model.InputName=row["InputName"].ToString();
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["PointState"]!=null && row["PointState"].ToString()!="")
				{
					model.PointState=int.Parse(row["PointState"].ToString());
				}
				if(row["ExpansionBoardID"]!=null && row["ExpansionBoardID"].ToString()!="")
				{
					model.ExpansionBoardID=int.Parse(row["ExpansionBoardID"].ToString());
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
			strSql.Append("select ExpansionBoardPointID,InputName,PointType,PointID,PointState,ExpansionBoardID ");
			strSql.Append(" FROM ExpansionBoardPointInfo ");
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
			strSql.Append("select count(1) FROM ExpansionBoardPointInfo ");
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
				strSql.Append("order by T.ExpansionBoardPointID desc");
			}
			strSql.Append(")AS Row, T.*  from ExpansionBoardPointInfo T ");
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
					new SQLiteParameter("@IsReCount", DbType.Boolean),
					new SQLiteParameter("@OrderType", DbType.Boolean),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "ExpansionBoardPointInfo";
			parameters[1].Value = "ExpansionBoardPointID";
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

