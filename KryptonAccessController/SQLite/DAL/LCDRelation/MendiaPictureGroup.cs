/**  版本信息模板在安装目录下，可自行修改。
* MendiaPictureGroup.cs
*
* 功 能： N/A
* 类 名： MendiaPictureGroup
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
	/// 数据访问类:MendiaPictureGroup
	/// </summary>
	public partial class MendiaPictureGroup
	{
		public MendiaPictureGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("MendiaPictureGroupID", "MendiaPictureGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MendiaPictureGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MendiaPictureGroup");
			strSql.Append(" where MendiaPictureGroupID=@MendiaPictureGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MendiaPictureGroupID", DbType.Int32,4)			};
			parameters[0].Value = MendiaPictureGroupID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MendiaPictureGroup(");
			strSql.Append("MendiaPictureGroupID,MendiaPictureGroupName,MendiaPictureGroupDes)");
			strSql.Append(" values (");
			strSql.Append("@MendiaPictureGroupID,@MendiaPictureGroupName,@MendiaPictureGroupDes)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MendiaPictureGroupID", DbType.Int32,4),
					new SQLiteParameter("@MendiaPictureGroupName", DbType.String),
					new SQLiteParameter("@MendiaPictureGroupDes", DbType.String)};
			parameters[0].Value = model.MendiaPictureGroupID;
			parameters[1].Value = model.MendiaPictureGroupName;
			parameters[2].Value = model.MendiaPictureGroupDes;

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
		public bool Update(KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MendiaPictureGroup set ");
			strSql.Append("MendiaPictureGroupName=@MendiaPictureGroupName,");
			strSql.Append("MendiaPictureGroupDes=@MendiaPictureGroupDes");
			strSql.Append(" where MendiaPictureGroupID=@MendiaPictureGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MendiaPictureGroupName", DbType.String),
					new SQLiteParameter("@MendiaPictureGroupDes", DbType.String),
					new SQLiteParameter("@MendiaPictureGroupID", DbType.Int32,4)};
			parameters[0].Value = model.MendiaPictureGroupName;
			parameters[1].Value = model.MendiaPictureGroupDes;
			parameters[2].Value = model.MendiaPictureGroupID;

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
		public bool Delete(int MendiaPictureGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MendiaPictureGroup ");
			strSql.Append(" where MendiaPictureGroupID=@MendiaPictureGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MendiaPictureGroupID", DbType.Int32,4)			};
			parameters[0].Value = MendiaPictureGroupID;

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
		public bool DeleteList(string MendiaPictureGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MendiaPictureGroup ");
			strSql.Append(" where MendiaPictureGroupID in ("+MendiaPictureGroupIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup GetModel(int MendiaPictureGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MendiaPictureGroupID,MendiaPictureGroupName,MendiaPictureGroupDes from MendiaPictureGroup ");
			strSql.Append(" where MendiaPictureGroupID=@MendiaPictureGroupID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MendiaPictureGroupID", DbType.Int32,4)			};
			parameters[0].Value = MendiaPictureGroupID;

			KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup model=new KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup();
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
		public KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup model=new KryptonAccessController.SQLite.Model.LCDRelation.MendiaPictureGroup();
			if (row != null)
			{
				if(row["MendiaPictureGroupID"]!=null && row["MendiaPictureGroupID"].ToString()!="")
				{
					model.MendiaPictureGroupID=int.Parse(row["MendiaPictureGroupID"].ToString());
				}
				if(row["MendiaPictureGroupName"]!=null)
				{
					model.MendiaPictureGroupName=row["MendiaPictureGroupName"].ToString();
				}
				if(row["MendiaPictureGroupDes"]!=null)
				{
					model.MendiaPictureGroupDes=row["MendiaPictureGroupDes"].ToString();
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
			strSql.Append("select MendiaPictureGroupID,MendiaPictureGroupName,MendiaPictureGroupDes ");
			strSql.Append(" FROM MendiaPictureGroup ");
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
			strSql.Append("select count(1) FROM MendiaPictureGroup ");
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
				strSql.Append("order by T.MendiaPictureGroupID desc");
			}
			strSql.Append(")AS Row, T.*  from MendiaPictureGroup T ");
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
			parameters[0].Value = "MendiaPictureGroup";
			parameters[1].Value = "MendiaPictureGroupID";
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

