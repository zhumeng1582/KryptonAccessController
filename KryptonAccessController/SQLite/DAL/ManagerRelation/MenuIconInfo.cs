/**  版本信息模板在安装目录下，可自行修改。
* MenuIconInfo.cs
*
* 功 能： N/A
* 类 名： MenuIconInfo
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
	/// 数据访问类:MenuIconInfo
	/// </summary>
	public partial class MenuIconInfo
	{
		public MenuIconInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MenuIconID", "MenuIconInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MenuIconID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MenuIconInfo");
			strSql.Append(" where MenuIconID=@MenuIconID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuIconID", DbType.Int32,4)			};
			parameters[0].Value = MenuIconID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MenuIconInfo(");
			strSql.Append("MenuIconID,MenuIconName,MenuIconCommercial,MenuIconImage)");
			strSql.Append(" values (");
			strSql.Append("@MenuIconID,@MenuIconName,@MenuIconCommercial,@MenuIconImage)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuIconID", DbType.Int32,4),
					new SQLiteParameter("@MenuIconName", DbType.String),
					new SQLiteParameter("@MenuIconCommercial", DbType.Int32,4),
					new SQLiteParameter("@MenuIconImage", DbType.Binary)};
			parameters[0].Value = model.MenuIconID;
			parameters[1].Value = model.MenuIconName;
			parameters[2].Value = model.MenuIconCommercial;
			parameters[3].Value = model.MenuIconImage;

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
		public bool Update(KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MenuIconInfo set ");
			strSql.Append("MenuIconName=@MenuIconName,");
			strSql.Append("MenuIconCommercial=@MenuIconCommercial,");
			strSql.Append("MenuIconImage=@MenuIconImage");
			strSql.Append(" where MenuIconID=@MenuIconID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuIconName", DbType.String),
					new SQLiteParameter("@MenuIconCommercial", DbType.Int32,4),
					new SQLiteParameter("@MenuIconImage", DbType.Binary),
					new SQLiteParameter("@MenuIconID", DbType.Int32,4)};
			parameters[0].Value = model.MenuIconName;
			parameters[1].Value = model.MenuIconCommercial;
			parameters[2].Value = model.MenuIconImage;
			parameters[3].Value = model.MenuIconID;

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
		public bool Delete(int MenuIconID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MenuIconInfo ");
			strSql.Append(" where MenuIconID=@MenuIconID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuIconID", DbType.Int32,4)			};
			parameters[0].Value = MenuIconID;

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
		public bool DeleteList(string MenuIconIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MenuIconInfo ");
			strSql.Append(" where MenuIconID in ("+MenuIconIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo GetModel(int MenuIconID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MenuIconID,MenuIconName,MenuIconCommercial,MenuIconImage from MenuIconInfo ");
			strSql.Append(" where MenuIconID=@MenuIconID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MenuIconID", DbType.Int32,4)			};
			parameters[0].Value = MenuIconID;

			KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo model=new KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo();
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
		public KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo model=new KryptonAccessController.SQLite.Model.ManagerRelation.MenuIconInfo();
			if (row != null)
			{
				if(row["MenuIconID"]!=null && row["MenuIconID"].ToString()!="")
				{
					model.MenuIconID=int.Parse(row["MenuIconID"].ToString());
				}
				if(row["MenuIconName"]!=null)
				{
					model.MenuIconName=row["MenuIconName"].ToString();
				}
				if(row["MenuIconCommercial"]!=null && row["MenuIconCommercial"].ToString()!="")
				{
					model.MenuIconCommercial=int.Parse(row["MenuIconCommercial"].ToString());
				}
				if(row["MenuIconImage"]!=null && row["MenuIconImage"].ToString()!="")
				{
					model.MenuIconImage=(byte[])row["MenuIconImage"];
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
			strSql.Append("select MenuIconID,MenuIconName,MenuIconCommercial,MenuIconImage ");
			strSql.Append(" FROM MenuIconInfo ");
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
			strSql.Append("select count(1) FROM MenuIconInfo ");
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
				strSql.Append("order by T.MenuIconID desc");
			}
			strSql.Append(")AS Row, T.*  from MenuIconInfo T ");
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
			parameters[0].Value = "MenuIconInfo";
			parameters[1].Value = "MenuIconID";
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

