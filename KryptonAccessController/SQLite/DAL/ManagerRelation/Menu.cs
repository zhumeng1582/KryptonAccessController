/**  版本信息模板在安装目录下，可自行修改。
* Menu.cs
*
* 功 能： N/A
* 类 名： Menu
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:41   N/A    初版
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
	/// 数据访问类:Menu
	/// </summary>
	public partial class Menu
	{
		public Menu()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MenuID", "Menu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MenuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Menu");
			strSql.Append(" where MenuID=@MenuID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuID", DbType.Int32,4)			};
			parameters[0].Value = MenuID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ManagerRelation.Menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Menu(");
			strSql.Append("MenuID,MenuName,MenuIcoID)");
			strSql.Append(" values (");
			strSql.Append("@MenuID,@MenuName,@MenuIcoID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuID", DbType.Int32,4),
					new SQLiteParameter("@MenuName", DbType.String),
					new SQLiteParameter("@MenuIcoID", DbType.Int32,4)};
			parameters[0].Value = model.MenuID;
			parameters[1].Value = model.MenuName;
			parameters[2].Value = model.MenuIcoID;

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
		public bool Update(KryptonAccessController.SQLite.Model.ManagerRelation.Menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Menu set ");
			strSql.Append("MenuName=@MenuName,");
			strSql.Append("MenuIcoID=@MenuIcoID");
			strSql.Append(" where MenuID=@MenuID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuName", DbType.String),
					new SQLiteParameter("@MenuIcoID", DbType.Int32,4),
					new SQLiteParameter("@MenuID", DbType.Int32,4)};
			parameters[0].Value = model.MenuName;
			parameters[1].Value = model.MenuIcoID;
			parameters[2].Value = model.MenuID;

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
		public bool Delete(int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menu ");
			strSql.Append(" where MenuID=@MenuID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuID", DbType.Int32,4)			};
			parameters[0].Value = MenuID;

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
		public bool DeleteList(string MenuIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menu ");
			strSql.Append(" where MenuID in ("+MenuIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.Menu GetModel(int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MenuID,MenuName,MenuIcoID from Menu ");
			strSql.Append(" where MenuID=@MenuID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuID", DbType.Int32,4)			};
			parameters[0].Value = MenuID;

			KryptonAccessController.SQLite.Model.ManagerRelation.Menu model=new KryptonAccessController.SQLite.Model.ManagerRelation.Menu();
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.Menu DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ManagerRelation.Menu model=new KryptonAccessController.SQLite.Model.ManagerRelation.Menu();
			if (row != null)
			{
				if(row["MenuID"]!=null && row["MenuID"].ToString()!="")
				{
					model.MenuID=int.Parse(row["MenuID"].ToString());
				}
				if(row["MenuName"]!=null)
				{
					model.MenuName=row["MenuName"].ToString();
				}
				if(row["MenuIcoID"]!=null && row["MenuIcoID"].ToString()!="")
				{
					model.MenuIcoID=int.Parse(row["MenuIcoID"].ToString());
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
			strSql.Append("select MenuID,MenuName,MenuIcoID ");
			strSql.Append(" FROM Menu ");
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
			strSql.Append("select count(1) FROM Menu ");
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
				strSql.Append("order by T.MenuID desc");
			}
			strSql.Append(")AS Row, T.*  from Menu T ");
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
			parameters[0].Value = "Menu";
			parameters[1].Value = "MenuID";
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

