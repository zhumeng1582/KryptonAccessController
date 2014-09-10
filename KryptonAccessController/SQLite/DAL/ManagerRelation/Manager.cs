/**  版本信息模板在安装目录下，可自行修改。
* Manager.cs
*
* 功 能： N/A
* 类 名： Manager
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:40   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.ManagerRelation
{
	/// <summary>
	/// 数据访问类:Manager
	/// </summary>
	public partial class Manager
	{
		public Manager()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ManagerID", "Manager"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ManagerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Manager");
			strSql.Append(" where ManagerID=@ManagerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ManagerID", DbType.Int32,4)			};
			parameters[0].Value = ManagerID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ManagerRelation.Manager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Manager(");
			strSql.Append("ManagerID,ManagerName,ManagerPassWord,IsSuperManager)");
			strSql.Append(" values (");
			strSql.Append("@ManagerID,@ManagerName,@ManagerPassWord,@IsSuperManager)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ManagerID", DbType.Int32,4),
					new SQLiteParameter("@ManagerName", DbType.String),
					new SQLiteParameter("@ManagerPassWord", DbType.String),
					new SQLiteParameter("@IsSuperManager", DbType.Boolean,1)};
			parameters[0].Value = model.ManagerID;
			parameters[1].Value = model.ManagerName;
			parameters[2].Value = model.ManagerPassWord;
			parameters[3].Value = model.IsSuperManager;

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
		public bool Update(KryptonAccessController.SQLite.Model.ManagerRelation.Manager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Manager set ");
			strSql.Append("ManagerName=@ManagerName,");
			strSql.Append("ManagerPassWord=@ManagerPassWord,");
			strSql.Append("IsSuperManager=@IsSuperManager");
			strSql.Append(" where ManagerID=@ManagerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ManagerName", DbType.String),
					new SQLiteParameter("@ManagerPassWord", DbType.String),
					new SQLiteParameter("@IsSuperManager", DbType.Boolean,1),
					new SQLiteParameter("@ManagerID", DbType.Int32,4)};
			parameters[0].Value = model.ManagerName;
			parameters[1].Value = model.ManagerPassWord;
			parameters[2].Value = model.IsSuperManager;
			parameters[3].Value = model.ManagerID;

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
		public bool Delete(int ManagerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Manager ");
			strSql.Append(" where ManagerID=@ManagerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ManagerID", DbType.Int32,4)			};
			parameters[0].Value = ManagerID;

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
		public bool DeleteList(string ManagerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Manager ");
			strSql.Append(" where ManagerID in ("+ManagerIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.Manager GetModel(int ManagerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ManagerID,ManagerName,ManagerPassWord,IsSuperManager from Manager ");
			strSql.Append(" where ManagerID=@ManagerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ManagerID", DbType.Int32,4)			};
			parameters[0].Value = ManagerID;

			KryptonAccessController.SQLite.Model.ManagerRelation.Manager model=new KryptonAccessController.SQLite.Model.ManagerRelation.Manager();
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.Manager DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ManagerRelation.Manager model=new KryptonAccessController.SQLite.Model.ManagerRelation.Manager();
			if (row != null)
			{
				if(row["ManagerID"]!=null && row["ManagerID"].ToString()!="")
				{
					model.ManagerID=int.Parse(row["ManagerID"].ToString());
				}
				if(row["ManagerName"]!=null)
				{
					model.ManagerName=row["ManagerName"].ToString();
				}
				if(row["ManagerPassWord"]!=null)
				{
					model.ManagerPassWord=row["ManagerPassWord"].ToString();
				}
				if(row["IsSuperManager"]!=null && row["IsSuperManager"].ToString()!="")
				{
					if((row["IsSuperManager"].ToString()=="1")||(row["IsSuperManager"].ToString().ToLower()=="true"))
					{
						model.IsSuperManager=true;
					}
					else
					{
						model.IsSuperManager=false;
					}
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
			strSql.Append("select ManagerID,ManagerName,ManagerPassWord,IsSuperManager ");
			strSql.Append(" FROM Manager ");
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
			strSql.Append("select count(1) FROM Manager ");
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
				strSql.Append("order by T.ManagerID desc");
			}
			strSql.Append(")AS Row, T.*  from Manager T ");
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
			parameters[0].Value = "Manager";
			parameters[1].Value = "ManagerID";
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

