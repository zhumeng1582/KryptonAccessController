/**  版本信息模板在安装目录下，可自行修改。
* MediaVideo.cs
*
* 功 能： N/A
* 类 名： MediaVideo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:02   N/A    初版
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
	/// 数据访问类:MediaVideo
	/// </summary>
	public partial class MediaVideo
	{
		public MediaVideo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MediaVideoID", "MediaVideo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaVideoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MediaVideo");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MediaVideo(");
			strSql.Append("MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@MediaVideoID,@MediaVideoName,@MediaVideoFilePath,@MediaVideoGroupID,@MediaVideoType,@PlayPriority)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoID", DbType.Int32,4),
					new SQLiteParameter("@MediaVideoName", DbType.String),
					new SQLiteParameter("@MediaVideoFilePath", DbType.String),
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4),
					new SQLiteParameter("@MediaVideoType", DbType.Int32,4),
					new SQLiteParameter("@PlayPriority", DbType.Int32,4)};
			parameters[0].Value = model.MediaVideoID;
			parameters[1].Value = model.MediaVideoName;
			parameters[2].Value = model.MediaVideoFilePath;
			parameters[3].Value = model.MediaVideoGroupID;
			parameters[4].Value = model.MediaVideoType;
			parameters[5].Value = model.PlayPriority;

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
		public bool Update(KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MediaVideo set ");
			strSql.Append("MediaVideoName=@MediaVideoName,");
			strSql.Append("MediaVideoFilePath=@MediaVideoFilePath,");
			strSql.Append("MediaVideoGroupID=@MediaVideoGroupID,");
			strSql.Append("MediaVideoType=@MediaVideoType,");
			strSql.Append("PlayPriority=@PlayPriority");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoName", DbType.String),
					new SQLiteParameter("@MediaVideoFilePath", DbType.String),
					new SQLiteParameter("@MediaVideoGroupID", DbType.Int32,4),
					new SQLiteParameter("@MediaVideoType", DbType.Int32,4),
					new SQLiteParameter("@PlayPriority", DbType.Int32,4),
					new SQLiteParameter("@MediaVideoID", DbType.Int32,4)};
			parameters[0].Value = model.MediaVideoName;
			parameters[1].Value = model.MediaVideoFilePath;
			parameters[2].Value = model.MediaVideoGroupID;
			parameters[3].Value = model.MediaVideoType;
			parameters[4].Value = model.PlayPriority;
			parameters[5].Value = model.MediaVideoID;

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
		public bool Delete(int MediaVideoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideo ");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoID;

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
		public bool DeleteList(string MediaVideoIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideo ");
			strSql.Append(" where MediaVideoID in ("+MediaVideoIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo GetModel(int MediaVideoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority from MediaVideo ");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaVideoID", DbType.Int32,4)			};
			parameters[0].Value = MediaVideoID;

			KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo();
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaVideo();
			if (row != null)
			{
				if(row["MediaVideoID"]!=null && row["MediaVideoID"].ToString()!="")
				{
					model.MediaVideoID=int.Parse(row["MediaVideoID"].ToString());
				}
				if(row["MediaVideoName"]!=null)
				{
					model.MediaVideoName=row["MediaVideoName"].ToString();
				}
				if(row["MediaVideoFilePath"]!=null)
				{
					model.MediaVideoFilePath=row["MediaVideoFilePath"].ToString();
				}
				if(row["MediaVideoGroupID"]!=null && row["MediaVideoGroupID"].ToString()!="")
				{
					model.MediaVideoGroupID=int.Parse(row["MediaVideoGroupID"].ToString());
				}
				if(row["MediaVideoType"]!=null && row["MediaVideoType"].ToString()!="")
				{
					model.MediaVideoType=int.Parse(row["MediaVideoType"].ToString());
				}
				if(row["PlayPriority"]!=null && row["PlayPriority"].ToString()!="")
				{
					model.PlayPriority=int.Parse(row["PlayPriority"].ToString());
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
			strSql.Append("select MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority ");
			strSql.Append(" FROM MediaVideo ");
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
			strSql.Append("select count(1) FROM MediaVideo ");
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
				strSql.Append("order by T.MediaVideoID desc");
			}
			strSql.Append(")AS Row, T.*  from MediaVideo T ");
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
			parameters[0].Value = "MediaVideo";
			parameters[1].Value = "MediaVideoID";
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

