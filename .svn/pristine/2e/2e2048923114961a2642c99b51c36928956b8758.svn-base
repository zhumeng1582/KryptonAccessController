/**  版本信息模板在安装目录下，可自行修改。
* PictureGroupPictureList.cs
*
* 功 能： N/A
* 类 名： PictureGroupPictureList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:19   N/A    初版
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
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.AccessSdkDataBase.DAL
{
	/// <summary>
	/// 数据访问类:PictureGroupPictureList
	/// </summary>
	public partial class PictureGroupPictureList
	{
		public PictureGroupPictureList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ListID", "PictureGroupPictureList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ListID,int PlayPriority)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PictureGroupPictureList");
			strSql.Append(" where ListID=@ListID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;
			parameters[1].Value = PlayPriority;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PictureGroupPictureList(");
			strSql.Append("ListID,ListName,MendiaPictureGroupID,MendiaPictureID,PlayPriority)");
			strSql.Append(" values (");
			strSql.Append("@ListID,@ListName,@MendiaPictureGroupID,@MendiaPictureID,@PlayPriority)");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@ListName", SqlDbType.NVarChar,50),
					new SqlParameter("@MendiaPictureGroupID", SqlDbType.Int,4),
					new SqlParameter("@MendiaPictureID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.ListID;
			parameters[1].Value = model.ListName;
			parameters[2].Value = model.MendiaPictureGroupID;
			parameters[3].Value = model.MendiaPictureID;
			parameters[4].Value = model.PlayPriority;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PictureGroupPictureList set ");
			strSql.Append("ListName=@ListName,");
			strSql.Append("MendiaPictureGroupID=@MendiaPictureGroupID,");
			strSql.Append("MendiaPictureID=@MendiaPictureID");
			strSql.Append(" where ListID=@ListID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListName", SqlDbType.NVarChar,50),
					new SqlParameter("@MendiaPictureGroupID", SqlDbType.Int,4),
					new SqlParameter("@MendiaPictureID", SqlDbType.Int,4),
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.ListName;
			parameters[1].Value = model.MendiaPictureGroupID;
			parameters[2].Value = model.MendiaPictureID;
			parameters[3].Value = model.ListID;
			parameters[4].Value = model.PlayPriority;

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
		public bool Delete(int ListID,int PlayPriority)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PictureGroupPictureList ");
			strSql.Append(" where ListID=@ListID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;
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
		public KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList GetModel(int ListID,int PlayPriority)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ListID,ListName,MendiaPictureGroupID,MendiaPictureID,PlayPriority from PictureGroupPictureList ");
			strSql.Append(" where ListID=@ListID and PlayPriority=@PlayPriority ");
			SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.Int,4),
					new SqlParameter("@PlayPriority", SqlDbType.Int,4)			};
			parameters[0].Value = ListID;
			parameters[1].Value = PlayPriority;

			KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList model=new KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList();
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
		public KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList model=new KryptonAccessController.AccessSdkDataBase.Model.PictureGroupPictureList();
			if (row != null)
			{
				if(row["ListID"]!=null && row["ListID"].ToString()!="")
				{
					model.ListID=int.Parse(row["ListID"].ToString());
				}
				if(row["ListName"]!=null)
				{
					model.ListName=row["ListName"].ToString();
				}
				if(row["MendiaPictureGroupID"]!=null && row["MendiaPictureGroupID"].ToString()!="")
				{
					model.MendiaPictureGroupID=int.Parse(row["MendiaPictureGroupID"].ToString());
				}
				if(row["MendiaPictureID"]!=null && row["MendiaPictureID"].ToString()!="")
				{
					model.MendiaPictureID=int.Parse(row["MendiaPictureID"].ToString());
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
			strSql.Append("select ListID,ListName,MendiaPictureGroupID,MendiaPictureID,PlayPriority ");
			strSql.Append(" FROM PictureGroupPictureList ");
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
			strSql.Append(" ListID,ListName,MendiaPictureGroupID,MendiaPictureID,PlayPriority ");
			strSql.Append(" FROM PictureGroupPictureList ");
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
			strSql.Append("select count(1) FROM PictureGroupPictureList ");
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
			strSql.Append(")AS Row, T.*  from PictureGroupPictureList T ");
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
			parameters[0].Value = "PictureGroupPictureList";
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

