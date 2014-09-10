/**  版本信息模板在安装目录下，可自行修改。
* BlackListCardInfo.cs
*
* 功 能： N/A
* 类 名： BlackListCardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:19   N/A    初版
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
	/// 数据访问类:BlackListCardInfo
	/// </summary>
	public partial class BlackListCardInfo:IBlackListCardInfo
	{
		public BlackListCardInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CardID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlackListCardInfo");
			strSql.Append(" where CardID=@CardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = CardID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.BlackListCardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlackListCardInfo(");
			strSql.Append("CardID,CardVersion,CardDeactiveDateTime,UserName,MarkBListReason,BListStateFlag)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@CardVersion,@CardDeactiveDateTime,@UserName,@MarkBListReason,@BListStateFlag)");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.NVarChar,10),
					new SqlParameter("@CardVersion", SqlDbType.NVarChar,10),
					new SqlParameter("@CardDeactiveDateTime", SqlDbType.NVarChar,10),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@MarkBListReason", SqlDbType.NVarChar,100),
					new SqlParameter("@BListStateFlag", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardVersion;
			parameters[2].Value = model.CardDeactiveDateTime;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.MarkBListReason;
			parameters[5].Value = model.BListStateFlag;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.BlackListCardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlackListCardInfo set ");
			strSql.Append("CardVersion=@CardVersion,");
			strSql.Append("CardDeactiveDateTime=@CardDeactiveDateTime,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("MarkBListReason=@MarkBListReason,");
			strSql.Append("BListStateFlag=@BListStateFlag");
			strSql.Append(" where CardID=@CardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardVersion", SqlDbType.NVarChar,10),
					new SqlParameter("@CardDeactiveDateTime", SqlDbType.NVarChar,10),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@MarkBListReason", SqlDbType.NVarChar,100),
					new SqlParameter("@BListStateFlag", SqlDbType.NVarChar,1),
					new SqlParameter("@CardID", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.CardVersion;
			parameters[1].Value = model.CardDeactiveDateTime;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.MarkBListReason;
			parameters[4].Value = model.BListStateFlag;
			parameters[5].Value = model.CardID;

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
		public bool Delete(string CardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlackListCardInfo ");
			strSql.Append(" where CardID=@CardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = CardID;

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
		public bool DeleteList(string CardIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlackListCardInfo ");
			strSql.Append(" where CardID in ("+CardIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.BlackListCardInfo GetModel(string CardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CardID,CardVersion,CardDeactiveDateTime,UserName,MarkBListReason,BListStateFlag from BlackListCardInfo ");
			strSql.Append(" where CardID=@CardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = CardID;

			KryptonAccessController.AccessDataBase.Model.BlackListCardInfo model=new KryptonAccessController.AccessDataBase.Model.BlackListCardInfo();
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
		public KryptonAccessController.AccessDataBase.Model.BlackListCardInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.BlackListCardInfo model=new KryptonAccessController.AccessDataBase.Model.BlackListCardInfo();
			if (row != null)
			{
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["CardVersion"]!=null)
				{
					model.CardVersion=row["CardVersion"].ToString();
				}
				if(row["CardDeactiveDateTime"]!=null)
				{
					model.CardDeactiveDateTime=row["CardDeactiveDateTime"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["MarkBListReason"]!=null)
				{
					model.MarkBListReason=row["MarkBListReason"].ToString();
				}
				if(row["BListStateFlag"]!=null)
				{
					model.BListStateFlag=row["BListStateFlag"].ToString();
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
			strSql.Append("select CardID,CardVersion,CardDeactiveDateTime,UserName,MarkBListReason,BListStateFlag ");
			strSql.Append(" FROM BlackListCardInfo ");
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
			strSql.Append(" CardID,CardVersion,CardDeactiveDateTime,UserName,MarkBListReason,BListStateFlag ");
			strSql.Append(" FROM BlackListCardInfo ");
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
			strSql.Append("select count(1) FROM BlackListCardInfo ");
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
				strSql.Append("order by T.CardID desc");
			}
			strSql.Append(")AS Row, T.*  from BlackListCardInfo T ");
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
			parameters[0].Value = "BlackListCardInfo";
			parameters[1].Value = "CardID";
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

