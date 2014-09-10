/**  版本信息模板在安装目录下，可自行修改。
* MediaPicture.cs
*
* 功 能： N/A
* 类 名： MediaPicture
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
	/// 数据访问类:MediaPicture
	/// </summary>
	public partial class MediaPicture
	{
		public MediaPicture()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MediaPictureID", "MediaPicture"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaPictureID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MediaPicture");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaPictureID", DbType.Int32,4)			};
			parameters[0].Value = MediaPictureID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MediaPicture(");
			strSql.Append("MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@MediaPictureID,@MediaPictureName,@MediaPicturePath,@MediaPictureGroupID,@MediaPicgureType,@PlayPriority)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaPictureID", DbType.Int32,4),
					new SQLiteParameter("@MediaPictureName", DbType.String),
					new SQLiteParameter("@MediaPicturePath", DbType.String,100),
					new SQLiteParameter("@MediaPictureGroupID", DbType.Int32,4),
					new SQLiteParameter("@MediaPicgureType", DbType.Int32,4),
					new SQLiteParameter("@PlayPriority", DbType.Int32,4)};
			parameters[0].Value = model.MediaPictureID;
			parameters[1].Value = model.MediaPictureName;
			parameters[2].Value = model.MediaPicturePath;
			parameters[3].Value = model.MediaPictureGroupID;
			parameters[4].Value = model.MediaPicgureType;
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
		public bool Update(KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MediaPicture set ");
			strSql.Append("MediaPictureName=@MediaPictureName,");
			strSql.Append("MediaPicturePath=@MediaPicturePath,");
			strSql.Append("MediaPictureGroupID=@MediaPictureGroupID,");
			strSql.Append("MediaPicgureType=@MediaPicgureType,");
			strSql.Append("PlayPriority=@PlayPriority");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaPictureName", DbType.String),
					new SQLiteParameter("@MediaPicturePath", DbType.String,100),
					new SQLiteParameter("@MediaPictureGroupID", DbType.Int32,4),
					new SQLiteParameter("@MediaPicgureType", DbType.Int32,4),
					new SQLiteParameter("@PlayPriority", DbType.Int32,4),
					new SQLiteParameter("@MediaPictureID", DbType.Int32,4)};
			parameters[0].Value = model.MediaPictureName;
			parameters[1].Value = model.MediaPicturePath;
			parameters[2].Value = model.MediaPictureGroupID;
			parameters[3].Value = model.MediaPicgureType;
			parameters[4].Value = model.PlayPriority;
			parameters[5].Value = model.MediaPictureID;

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
		public bool Delete(int MediaPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaPicture ");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaPictureID", DbType.Int32,4)			};
			parameters[0].Value = MediaPictureID;

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
		public bool DeleteList(string MediaPictureIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaPicture ");
			strSql.Append(" where MediaPictureID in ("+MediaPictureIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture GetModel(int MediaPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority from MediaPicture ");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MediaPictureID", DbType.Int32,4)			};
			parameters[0].Value = MediaPictureID;

			KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture();
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture model=new KryptonAccessController.SQLite.Model.LCDRelation.MediaPicture();
			if (row != null)
			{
				if(row["MediaPictureID"]!=null && row["MediaPictureID"].ToString()!="")
				{
					model.MediaPictureID=int.Parse(row["MediaPictureID"].ToString());
				}
				if(row["MediaPictureName"]!=null)
				{
					model.MediaPictureName=row["MediaPictureName"].ToString();
				}
				if(row["MediaPicturePath"]!=null)
				{
					model.MediaPicturePath=row["MediaPicturePath"].ToString();
				}
				if(row["MediaPictureGroupID"]!=null && row["MediaPictureGroupID"].ToString()!="")
				{
					model.MediaPictureGroupID=int.Parse(row["MediaPictureGroupID"].ToString());
				}
				if(row["MediaPicgureType"]!=null && row["MediaPicgureType"].ToString()!="")
				{
					model.MediaPicgureType=int.Parse(row["MediaPicgureType"].ToString());
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
			strSql.Append("select MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority ");
			strSql.Append(" FROM MediaPicture ");
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
			strSql.Append("select count(1) FROM MediaPicture ");
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
				strSql.Append("order by T.MediaPictureID desc");
			}
			strSql.Append(")AS Row, T.*  from MediaPicture T ");
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
			parameters[0].Value = "MediaPicture";
			parameters[1].Value = "MediaPictureID";
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

