/**  版本信息模板在安装目录下，可自行修改。
* EventSOP.cs
*
* 功 能： N/A
* 类 名： EventSOP
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
	/// 数据访问类:EventSOP
	/// </summary>
	public partial class EventSOP
	{
		public EventSOP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("EventSOPGID", "EventSOP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventSOPGID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventSOP");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventSOPGID", DbType.Int32,4)			};
			parameters[0].Value = EventSOPGID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.EventSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventSOP(");
			strSql.Append("EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID)");
			strSql.Append(" values (");
			strSql.Append("@EventSOPGID,@EventSOPGName,@EventSOPGEnable,@PointType,@PointID,@EventCodeID,@SOPID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventSOPGID", DbType.Int32,4),
					new SQLiteParameter("@EventSOPGName", DbType.String),
					new SQLiteParameter("@EventSOPGEnable", DbType.Boolean,1),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@EventCodeID", DbType.Int32,4),
					new SQLiteParameter("@SOPID", DbType.Int32,4)};
			parameters[0].Value = model.EventSOPGID;
			parameters[1].Value = model.EventSOPGName;
			parameters[2].Value = model.EventSOPGEnable;
			parameters[3].Value = model.PointType;
			parameters[4].Value = model.PointID;
			parameters[5].Value = model.EventCodeID;
			parameters[6].Value = model.SOPID;

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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.EventSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventSOP set ");
			strSql.Append("EventSOPGName=@EventSOPGName,");
			strSql.Append("EventSOPGEnable=@EventSOPGEnable,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("EventCodeID=@EventCodeID,");
			strSql.Append("SOPID=@SOPID");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventSOPGName", DbType.String),
					new SQLiteParameter("@EventSOPGEnable", DbType.Boolean,1),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@EventCodeID", DbType.Int32,4),
					new SQLiteParameter("@SOPID", DbType.Int32,4),
					new SQLiteParameter("@EventSOPGID", DbType.Int32,4)};
			parameters[0].Value = model.EventSOPGName;
			parameters[1].Value = model.EventSOPGEnable;
			parameters[2].Value = model.PointType;
			parameters[3].Value = model.PointID;
			parameters[4].Value = model.EventCodeID;
			parameters[5].Value = model.SOPID;
			parameters[6].Value = model.EventSOPGID;

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
		public bool Delete(int EventSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventSOP ");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventSOPGID", DbType.Int32,4)			};
			parameters[0].Value = EventSOPGID;

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
		public bool DeleteList(string EventSOPGIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventSOP ");
			strSql.Append(" where EventSOPGID in ("+EventSOPGIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.InteractRelation.EventSOP GetModel(int EventSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID from EventSOP ");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventSOPGID", DbType.Int32,4)			};
			parameters[0].Value = EventSOPGID;

			KryptonAccessController.SQLite.Model.InteractRelation.EventSOP model=new KryptonAccessController.SQLite.Model.InteractRelation.EventSOP();
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
		public KryptonAccessController.SQLite.Model.InteractRelation.EventSOP DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.EventSOP model=new KryptonAccessController.SQLite.Model.InteractRelation.EventSOP();
			if (row != null)
			{
				if(row["EventSOPGID"]!=null && row["EventSOPGID"].ToString()!="")
				{
					model.EventSOPGID=int.Parse(row["EventSOPGID"].ToString());
				}
				if(row["EventSOPGName"]!=null)
				{
					model.EventSOPGName=row["EventSOPGName"].ToString();
				}
				if(row["EventSOPGEnable"]!=null && row["EventSOPGEnable"].ToString()!="")
				{
					if((row["EventSOPGEnable"].ToString()=="1")||(row["EventSOPGEnable"].ToString().ToLower()=="true"))
					{
						model.EventSOPGEnable=true;
					}
					else
					{
						model.EventSOPGEnable=false;
					}
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["EventCodeID"]!=null && row["EventCodeID"].ToString()!="")
				{
					model.EventCodeID=int.Parse(row["EventCodeID"].ToString());
				}
				if(row["SOPID"]!=null && row["SOPID"].ToString()!="")
				{
					model.SOPID=int.Parse(row["SOPID"].ToString());
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
			strSql.Append("select EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID ");
			strSql.Append(" FROM EventSOP ");
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
			strSql.Append("select count(1) FROM EventSOP ");
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
				strSql.Append("order by T.EventSOPGID desc");
			}
			strSql.Append(")AS Row, T.*  from EventSOP T ");
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
			parameters[0].Value = "EventSOP";
			parameters[1].Value = "EventSOPGID";
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

