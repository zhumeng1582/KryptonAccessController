/**  版本信息模板在安装目录下，可自行修改。
* MediaPicture.cs
*
* 功 能： N/A
* 类 名： MediaPicture
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:35:00   N/A    初版
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
using System.Data.SqlClient;
using KryptonAccessController.AccessDataBase.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.AccessDataBase.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:MediaPicture
	/// </summary>
	public partial class MediaPicture:IMediaPicture
	{
		public MediaPicture()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MediaPictureID", "MediaPicture"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaPictureID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MediaPicture");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaPictureID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.MediaPicture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MediaPicture(");
			strSql.Append("MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@MediaPictureID,@MediaPictureName,@MediaPicturePath,@MediaPictureGroupID,@MediaPicgureType,@PlayPriority)");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaPictureID", SqlDbType.Int,4),
					new SqlParameter("@MediaPictureName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaPicturePath", SqlDbType.VarChar,100),
					new SqlParameter("@MediaPictureGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaPicgureType", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaPictureID;
			parameters[1].Value = model.MediaPictureName;
			parameters[2].Value = model.MediaPicturePath;
			parameters[3].Value = model.MediaPictureGroupID;
			parameters[4].Value = model.MediaPicgureType;
			parameters[5].Value = model.PlayPriority;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.MediaPicture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MediaPicture set ");
			strSql.Append("MediaPictureName=@MediaPictureName,");
			strSql.Append("MediaPicturePath=@MediaPicturePath,");
			strSql.Append("MediaPictureGroupID=@MediaPictureGroupID,");
			strSql.Append("MediaPicgureType=@MediaPicgureType,");
			strSql.Append("PlayPriority=@PlayPriority");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaPictureName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaPicturePath", SqlDbType.VarChar,100),
					new SqlParameter("@MediaPictureGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaPicgureType", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4),
					new SqlParameter("@MediaPictureID", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaPictureName;
			parameters[1].Value = model.MediaPicturePath;
			parameters[2].Value = model.MediaPictureGroupID;
			parameters[3].Value = model.MediaPicgureType;
			parameters[4].Value = model.PlayPriority;
			parameters[5].Value = model.MediaPictureID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			SqlParameter[] parameters = {
					new SqlParameter("@MediaPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaPictureID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public KryptonAccessController.AccessDataBase.Model.MediaPicture GetModel(int MediaPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority from MediaPicture ");
			strSql.Append(" where MediaPictureID=@MediaPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaPictureID;

			KryptonAccessController.AccessDataBase.Model.MediaPicture model=new KryptonAccessController.AccessDataBase.Model.MediaPicture();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public KryptonAccessController.AccessDataBase.Model.MediaPicture DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.MediaPicture model=new KryptonAccessController.AccessDataBase.Model.MediaPicture();
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
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" MediaPictureID,MediaPictureName,MediaPicturePath,MediaPictureGroupID,MediaPicgureType,PlayPriority ");
			strSql.Append(" FROM MediaPicture ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
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
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "MediaPicture";
			parameters[1].Value = "MediaPictureID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

