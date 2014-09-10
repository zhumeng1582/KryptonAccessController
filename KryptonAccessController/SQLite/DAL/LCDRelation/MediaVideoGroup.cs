/**  版本信息模板在安装目录下，可自行修改。
* MediaVideoGroup.cs
*
* 功 能： N/A
* 类 名： MediaVideoGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:03   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.LCDRelation
{
	/// <summary>
	/// 数据访问类:MediaVideoGroup
	/// </summary>
	public partial class MediaVideoGroup
	{
		public MediaVideoGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MediaVideoGroupID", "MediaVideoGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaVideoGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MediaVideoGroup");
			strSql.Append(" where MediaVideoGroupID=@MediaVideoGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoGroupID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MediaVideoGroup(");
			strSql.Append("MediaVideoGroupID,MediaVideoGroupName,MediaVideoGroupDes)");
			strSql.Append(" values (");
			strSql.Append("@MediaVideoGroupID,@MediaVideoGroupName,@MediaVideoGroupDes)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4),
					new SQLiteParameter("@MediaVideoGroupName", DbType.String),
					new SQLiteParameter("@MediaVideoGroupDes", DbType.String)};
			parameters[0].Value = model.MediaVideoGroupID;
			parameters[1].Value = model.MediaVideoGroupName;
			parameters[2].Value = model.MediaVideoGroupDes;

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
		public bool Update(KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MediaVideoGroup set ");
			strSql.Append("MediaVideoGroupName=@MediaVideoGroupName,");
			strSql.Append("MediaVideoGroupDes=@MediaVideoGroupDes");
			strSql.Append(" where MediaVideoGroupID=@MediaVideoGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoGroupName", DbType.String),
					new SQLiteParameter("@MediaVideoGroupDes", DbType.String),
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4)};
			parameters[0].Value = model.MediaVideoGroupName;
			parameters[1].Value = model.MediaVideoGroupDes;
			parameters[2].Value = model.MediaVideoGroupID;

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
		public bool Delete(int MediaVideoGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideoGroup ");
			strSql.Append(" where MediaVideoGroupID=@MediaVideoGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoGroupID;

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
		public bool DeleteList(string MediaVideoGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideoGroup ");
			strSql.Append(" where MediaVideoGroupID in ("+MediaVideoGroupIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup GetModel(int MediaVideoGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MediaVideoGroupID,MediaVideoGroupName,MediaVideoGroupDes from MediaVideoGroup ");
			strSql.Append(" where MediaVideoGroupID=@MediaVideoGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoGroupID;

			KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup();
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaVideoGroup();
			if (row != null)
			{
				if(row["MediaVideoGroupID"]!=null && row["MediaVideoGroupID"].ToString()!="")
				{
					model.MediaVideoGroupID=int.Parse(row["MediaVideoGroupID"].ToString());
				}
				if(row["MediaVideoGroupName"]!=null)
				{
					model.MediaVideoGroupName=row["MediaVideoGroupName"].ToString();
				}
				if(row["MediaVideoGroupDes"]!=null)
				{
					model.MediaVideoGroupDes=row["MediaVideoGroupDes"].ToString();
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
			strSql.Append("select MediaVideoGroupID,MediaVideoGroupName,MediaVideoGroupDes ");
			strSql.Append(" FROM MediaVideoGroup ");
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
			strSql.Append("select count(1) FROM MediaVideoGroup ");
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
				strSql.Append("order by T.MediaVideoGroupID desc");
			}
			strSql.Append(")AS Row, T.*  from MediaVideoGroup T ");
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
			parameters[0].Value = "MediaVideoGroup";
			parameters[1].Value = "MediaVideoGroupID";
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

