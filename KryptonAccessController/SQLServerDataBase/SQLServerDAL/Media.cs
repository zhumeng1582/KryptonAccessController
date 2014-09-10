/**  版本信息模板在安装目录下，可自行修改。
* Media.cs
*
* 功 能： N/A
* 类 名： Media
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:28   N/A    初版
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
	/// 数据访问类:Media
	/// </summary>
	public partial class Media:IMedia
	{
		public Media()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MediaID", "Media"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MediaID,int PlayPriority)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Media");
			strSql.Append(" where MediaID=@MediaID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = MediaID;
			parameters[1].Value = PlayPriority;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.Media model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Media(");
			strSql.Append("MediaID,MediaFileName,MediaFilePath,MediaGroupID,MediaType,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@MediaID,@MediaFileName,@MediaFilePath,@MediaGroupID,@MediaType,@PlayPriority)");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaID", SqlDbType.Int,4),
					new SqlParameter("@MediaFileName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaFilePath", SqlDbType.NVarChar,100),
					new SqlParameter("@MediaGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaType", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaID;
			parameters[1].Value = model.MediaFileName;
			parameters[2].Value = model.MediaFilePath;
			parameters[3].Value = model.MediaGroupID;
			parameters[4].Value = model.MediaType;
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.Media model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Media set ");
			strSql.Append("MediaFileName=@MediaFileName,");
			strSql.Append("MediaFilePath=@MediaFilePath,");
			strSql.Append("MediaGroupID=@MediaGroupID,");
			strSql.Append("MediaType=@MediaType");
			strSql.Append(" where MediaID=@MediaID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaFileName", SqlDbType.NVarChar,50),
					new SqlParameter("@MediaFilePath", SqlDbType.NVarChar,100),
					new SqlParameter("@MediaGroupID", SqlDbType.Int,4),
					new SqlParameter("@MediaType", SqlDbType.Int,4),
					new SqlParameter("@MediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.MediaFileName;
			parameters[1].Value = model.MediaFilePath;
			parameters[2].Value = model.MediaGroupID;
			parameters[3].Value = model.MediaType;
			parameters[4].Value = model.MediaID;
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MediaID,int PlayPriority)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Media ");
			strSql.Append(" where MediaID=@MediaID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = MediaID;
			parameters[1].Value = PlayPriority;

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
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.AccessDataBase.Model.Media GetModel(int MediaID,int PlayPriority)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MediaID,MediaFileName,MediaFilePath,MediaGroupID,MediaType,PlayPriority from Media ");
			strSql.Append(" where MediaID=@MediaID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@MediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = MediaID;
			parameters[1].Value = PlayPriority;

			KryptonAccessController.AccessDataBase.Model.Media model=new KryptonAccessController.AccessDataBase.Model.Media();
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
		public KryptonAccessController.AccessDataBase.Model.Media DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.Media model=new KryptonAccessController.AccessDataBase.Model.Media();
			if (row != null)
			{
				if(row["MediaID"]!=null && row["MediaID"].ToString()!="")
				{
					model.MediaID=int.Parse(row["MediaID"].ToString());
				}
				if(row["MediaFileName"]!=null)
				{
					model.MediaFileName=row["MediaFileName"].ToString();
				}
				if(row["MediaFilePath"]!=null)
				{
					model.MediaFilePath=row["MediaFilePath"].ToString();
				}
				if(row["MediaGroupID"]!=null && row["MediaGroupID"].ToString()!="")
				{
					model.MediaGroupID=int.Parse(row["MediaGroupID"].ToString());
				}
				if(row["MediaType"]!=null && row["MediaType"].ToString()!="")
				{
					model.MediaType=int.Parse(row["MediaType"].ToString());
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
			strSql.Append("select MediaID,MediaFileName,MediaFilePath,MediaGroupID,MediaType,PlayPriority ");
			strSql.Append(" FROM Media ");
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
			strSql.Append(" MediaID,MediaFileName,MediaFilePath,MediaGroupID,MediaType,PlayPriority ");
			strSql.Append(" FROM Media ");
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
			strSql.Append("select count(1) FROM Media ");
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
				strSql.Append("order by T.PlayPriority desc");
			}
			strSql.Append(")AS Row, T.*  from Media T ");
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
			parameters[0].Value = "Media";
			parameters[1].Value = "PlayPriority";
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

