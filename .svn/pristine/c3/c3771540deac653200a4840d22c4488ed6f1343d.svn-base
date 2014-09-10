/**  版本信息模板在安装目录下，可自行修改。
* MediaVideo.cs
*
* 功 能： N/A
* 类 名： MediaVideo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:35:07   N/A    初版
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
	/// 数据访问类:MediaVideo
	/// </summary>
	public partial class MediaVideo:IMediaVideo
	{
		public MediaVideo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MediaVideoID", "MediaVideo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaVideoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MediaVideo");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaVideoID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaVideoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.MediaVideo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MediaVideo(");
			strSql.Append("MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@MediaVideoID,@MediaVideoName,@MediaVideoFilePath,@MediaVideoGroupID,@MediaVideoType,@PlayPriority)");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaVideoID", SqlDbType.Int,4),
					new SqlParameter("@MediaVideoName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaVideoFilePath", SqlDbType.NVarChar,100),
					new SqlParameter("@MediaVideoGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaVideoType", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaVideoID;
			parameters[1].Value = model.MediaVideoName;
			parameters[2].Value = model.MediaVideoFilePath;
			parameters[3].Value = model.MediaVideoGroupID;
			parameters[4].Value = model.MediaVideoType;
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.MediaVideo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MediaVideo set ");
			strSql.Append("MediaVideoName=@MediaVideoName,");
			strSql.Append("MediaVideoFilePath=@MediaVideoFilePath,");
			strSql.Append("MediaVideoGroupID=@MediaVideoGroupID,");
			strSql.Append("MediaVideoType=@MediaVideoType,");
			strSql.Append("PlayPriority=@PlayPriority");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaVideoName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaVideoFilePath", SqlDbType.NVarChar,100),
					new SqlParameter("@MediaVideoGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaVideoType", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4),
					new SqlParameter("@MediaVideoID", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaVideoName;
			parameters[1].Value = model.MediaVideoFilePath;
			parameters[2].Value = model.MediaVideoGroupID;
			parameters[3].Value = model.MediaVideoType;
			parameters[4].Value = model.PlayPriority;
			parameters[5].Value = model.MediaVideoID;

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
		public bool Delete(int MediaVideoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideo ");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaVideoID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaVideoID;

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
		public bool DeleteList(string MediaVideoIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MediaVideo ");
			strSql.Append(" where MediaVideoID in ("+MediaVideoIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.MediaVideo GetModel(int MediaVideoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority from MediaVideo ");
			strSql.Append(" where MediaVideoID=@MediaVideoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaVideoID", SqlDbType.Int,4)			};
			parameters[0].Value = MediaVideoID;

			KryptonAccessController.AccessDataBase.Model.MediaVideo model=new KryptonAccessController.AccessDataBase.Model.MediaVideo();
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
		public KryptonAccessController.AccessDataBase.Model.MediaVideo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.MediaVideo model=new KryptonAccessController.AccessDataBase.Model.MediaVideo();
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
			strSql.Append(" MediaVideoID,MediaVideoName,MediaVideoFilePath,MediaVideoGroupID,MediaVideoType,PlayPriority ");
			strSql.Append(" FROM MediaVideo ");
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
			parameters[0].Value = "MediaVideo";
			parameters[1].Value = "MediaVideoID";
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

