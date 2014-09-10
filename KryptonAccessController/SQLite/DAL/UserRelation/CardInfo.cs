/**  版本信息模板在安装目录下，可自行修改。
* CardInfo.cs
*
* 功 能： N/A
* 类 名： CardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:33   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.UserRelation
{
	/// <summary>
	/// 数据访问类:CardInfo
	/// </summary>
	public partial class CardInfo
	{
		public CardInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CardID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CardInfo");
			strSql.Append(" where CardID=@CardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CardID", DbType.String)			};
			parameters[0].Value = CardID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.UserRelation.CardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CardInfo(");
			strSql.Append("CardID,CardVersion,CardType,CardLevel,CardPassword,CardIssueDateTime,CardValidDateTime,StateFlag)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@CardVersion,@CardType,@CardLevel,@CardPassword,@CardIssueDateTime,@CardValidDateTime,@StateFlag)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CardID", DbType.String),
					new SQLiteParameter("@CardVersion", DbType.String),
					new SQLiteParameter("@CardType", DbType.Int32,4),
					new SQLiteParameter("@CardLevel", DbType.String),
					new SQLiteParameter("@CardPassword", DbType.String),
					new SQLiteParameter("@CardIssueDateTime", DbType.String),
					new SQLiteParameter("@CardValidDateTime", DbType.String),
					new SQLiteParameter("@StateFlag", DbType.String)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardVersion;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.CardLevel;
			parameters[4].Value = model.CardPassword;
			parameters[5].Value = model.CardIssueDateTime;
			parameters[6].Value = model.CardValidDateTime;
			parameters[7].Value = model.StateFlag;

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
		public bool Update(KryptonAccessController.SQLite.Model.UserRelation.CardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CardInfo set ");
			strSql.Append("CardVersion=@CardVersion,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("CardLevel=@CardLevel,");
			strSql.Append("CardPassword=@CardPassword,");
			strSql.Append("CardIssueDateTime=@CardIssueDateTime,");
			strSql.Append("CardValidDateTime=@CardValidDateTime,");
			strSql.Append("StateFlag=@StateFlag");
			strSql.Append(" where CardID=@CardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CardVersion", DbType.String),
					new SQLiteParameter("@CardType", DbType.Int32,4),
					new SQLiteParameter("@CardLevel", DbType.String),
					new SQLiteParameter("@CardPassword", DbType.String),
					new SQLiteParameter("@CardIssueDateTime", DbType.String),
					new SQLiteParameter("@CardValidDateTime", DbType.String),
					new SQLiteParameter("@StateFlag", DbType.String),
					new SQLiteParameter("@CardID", DbType.String)};
			parameters[0].Value = model.CardVersion;
			parameters[1].Value = model.CardType;
			parameters[2].Value = model.CardLevel;
			parameters[3].Value = model.CardPassword;
			parameters[4].Value = model.CardIssueDateTime;
			parameters[5].Value = model.CardValidDateTime;
			parameters[6].Value = model.StateFlag;
			parameters[7].Value = model.CardID;

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
		public bool Delete(string CardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardInfo ");
			strSql.Append(" where CardID=@CardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CardID", DbType.String)			};
			parameters[0].Value = CardID;

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
		public bool DeleteList(string CardIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardInfo ");
			strSql.Append(" where CardID in ("+CardIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.UserRelation.CardInfo GetModel(string CardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CardID,CardVersion,CardType,CardLevel,CardPassword,CardIssueDateTime,CardValidDateTime,StateFlag from CardInfo ");
			strSql.Append(" where CardID=@CardID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CardID", DbType.String)			};
			parameters[0].Value = CardID;

			KryptonAccessController.SQLite.Model.UserRelation.CardInfo model=new KryptonAccessController.SQLite.Model.UserRelation.CardInfo();
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
		public KryptonAccessController.SQLite.Model.UserRelation.CardInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.UserRelation.CardInfo model=new KryptonAccessController.SQLite.Model.UserRelation.CardInfo();
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
				if(row["CardType"]!=null && row["CardType"].ToString()!="")
				{
					model.CardType=int.Parse(row["CardType"].ToString());
				}
				if(row["CardLevel"]!=null)
				{
					model.CardLevel=row["CardLevel"].ToString();
				}
				if(row["CardPassword"]!=null)
				{
					model.CardPassword=row["CardPassword"].ToString();
				}
				if(row["CardIssueDateTime"]!=null)
				{
					model.CardIssueDateTime=row["CardIssueDateTime"].ToString();
				}
				if(row["CardValidDateTime"]!=null)
				{
					model.CardValidDateTime=row["CardValidDateTime"].ToString();
				}
				if(row["StateFlag"]!=null)
				{
					model.StateFlag=row["StateFlag"].ToString();
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
			strSql.Append("select CardID,CardVersion,CardType,CardLevel,CardPassword,CardIssueDateTime,CardValidDateTime,StateFlag ");
			strSql.Append(" FROM CardInfo ");
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
			strSql.Append("select count(1) FROM CardInfo ");
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
			strSql.Append(")AS Row, T.*  from CardInfo T ");
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
			parameters[0].Value = "CardInfo";
			parameters[1].Value = "CardID";
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

