/**  版本信息模板在安装目录下，可自行修改。
* StandardOperateProcedure.cs
*
* 功 能： N/A
* 类 名： StandardOperateProcedure
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:15   N/A    初版
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
	/// 数据访问类:StandardOperateProcedure
	/// </summary>
	public partial class StandardOperateProcedure
	{
		public StandardOperateProcedure()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("SOPID", "StandardOperateProcedure"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SOPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StandardOperateProcedure");
			strSql.Append(" where SOPID=@SOPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SOPID", DbType.Int32,4)			};
			parameters[0].Value = SOPID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StandardOperateProcedure(");
			strSql.Append("SOPID,SOPName,SOPWaitTimeLength,DesControllerInfoInLANID,Action,OutPutLength)");
			strSql.Append(" values (");
			strSql.Append("@SOPID,@SOPName,@SOPWaitTimeLength,@DesControllerInfoInLANID,@Action,@OutPutLength)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SOPID", DbType.Int32,4),
					new SQLiteParameter("@SOPName", DbType.String),
					new SQLiteParameter("@SOPWaitTimeLength", DbType.Int32,4),
					new SQLiteParameter("@DesControllerInfoInLANID", DbType.Int32,4),
					new SQLiteParameter("@Action", DbType.String),
					new SQLiteParameter("@OutPutLength", DbType.Int32,4)};
			parameters[0].Value = model.SOPID;
			parameters[1].Value = model.SOPName;
			parameters[2].Value = model.SOPWaitTimeLength;
			parameters[3].Value = model.DesControllerInfoInLANID;
			parameters[4].Value = model.Action;
			parameters[5].Value = model.OutPutLength;

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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StandardOperateProcedure set ");
			strSql.Append("SOPName=@SOPName,");
			strSql.Append("SOPWaitTimeLength=@SOPWaitTimeLength,");
			strSql.Append("DesControllerInfoInLANID=@DesControllerInfoInLANID,");
			strSql.Append("Action=@Action,");
			strSql.Append("OutPutLength=@OutPutLength");
			strSql.Append(" where SOPID=@SOPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SOPName", DbType.String),
					new SQLiteParameter("@SOPWaitTimeLength", DbType.Int32,4),
					new SQLiteParameter("@DesControllerInfoInLANID", DbType.Int32,4),
					new SQLiteParameter("@Action", DbType.String),
					new SQLiteParameter("@OutPutLength", DbType.Int32,4),
					new SQLiteParameter("@SOPID", DbType.Int32,4)};
			parameters[0].Value = model.SOPName;
			parameters[1].Value = model.SOPWaitTimeLength;
			parameters[2].Value = model.DesControllerInfoInLANID;
			parameters[3].Value = model.Action;
			parameters[4].Value = model.OutPutLength;
			parameters[5].Value = model.SOPID;

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
		public bool Delete(int SOPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StandardOperateProcedure ");
			strSql.Append(" where SOPID=@SOPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SOPID", DbType.Int32,4)			};
			parameters[0].Value = SOPID;

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
		public bool DeleteList(string SOPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StandardOperateProcedure ");
			strSql.Append(" where SOPID in ("+SOPIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure GetModel(int SOPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SOPID,SOPName,SOPWaitTimeLength,DesControllerInfoInLANID,Action,OutPutLength from StandardOperateProcedure ");
			strSql.Append(" where SOPID=@SOPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SOPID", DbType.Int32,4)			};
			parameters[0].Value = SOPID;

			KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure model=new KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure();
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
		public KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure model=new KryptonAccessController.SQLite.Model.InteractRelation.StandardOperateProcedure();
			if (row != null)
			{
				if(row["SOPID"]!=null && row["SOPID"].ToString()!="")
				{
					model.SOPID=int.Parse(row["SOPID"].ToString());
				}
				if(row["SOPName"]!=null)
				{
					model.SOPName=row["SOPName"].ToString();
				}
				if(row["SOPWaitTimeLength"]!=null && row["SOPWaitTimeLength"].ToString()!="")
				{
					model.SOPWaitTimeLength=int.Parse(row["SOPWaitTimeLength"].ToString());
				}
				if(row["DesControllerInfoInLANID"]!=null && row["DesControllerInfoInLANID"].ToString()!="")
				{
					model.DesControllerInfoInLANID=int.Parse(row["DesControllerInfoInLANID"].ToString());
				}
				if(row["Action"]!=null)
				{
					model.Action=row["Action"].ToString();
				}
				if(row["OutPutLength"]!=null && row["OutPutLength"].ToString()!="")
				{
					model.OutPutLength=int.Parse(row["OutPutLength"].ToString());
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
			strSql.Append("select SOPID,SOPName,SOPWaitTimeLength,DesControllerInfoInLANID,Action,OutPutLength ");
			strSql.Append(" FROM StandardOperateProcedure ");
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
			strSql.Append("select count(1) FROM StandardOperateProcedure ");
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
				strSql.Append("order by T.SOPID desc");
			}
			strSql.Append(")AS Row, T.*  from StandardOperateProcedure T ");
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
			parameters[0].Value = "StandardOperateProcedure";
			parameters[1].Value = "SOPID";
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

