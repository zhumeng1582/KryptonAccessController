/**  版本信息模板在安装目录下，可自行修改。
* EventPictureInfo.cs
*
* 功 能： N/A
* 类 名： EventPictureInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:10   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.InteractRelation
{
	/// <summary>
	/// 数据访问类:EventPictureInfo
	/// </summary>
	public partial class EventPictureInfo
	{
		public EventPictureInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("EventPictureID", "EventPictureInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventPictureID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventPictureInfo");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventPictureID", DbType.Int32,4)			};
			parameters[0].Value = EventPictureID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventPictureInfo(");
			strSql.Append("EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage)");
			strSql.Append(" values (");
			strSql.Append("@EventPictureID,@EventPictureName,@EventPictureComercial,@EventPictureType,@EventPictureImage)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventPictureID", DbType.Int32,4),
					new SQLiteParameter("@EventPictureName", DbType.String),
					new SQLiteParameter("@EventPictureComercial", DbType.Int32,4),
					new SQLiteParameter("@EventPictureType", DbType.Int32,4),
					new SQLiteParameter("@EventPictureImage", DbType.Binary)};
			parameters[0].Value = model.EventPictureID;
			parameters[1].Value = model.EventPictureName;
			parameters[2].Value = model.EventPictureComercial;
			parameters[3].Value = model.EventPictureType;
			parameters[4].Value = model.EventPictureImage;

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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventPictureInfo set ");
			strSql.Append("EventPictureName=@EventPictureName,");
			strSql.Append("EventPictureComercial=@EventPictureComercial,");
			strSql.Append("EventPictureType=@EventPictureType,");
			strSql.Append("EventPictureImage=@EventPictureImage");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventPictureName", DbType.String),
					new SQLiteParameter("@EventPictureComercial", DbType.Int32,4),
					new SQLiteParameter("@EventPictureType", DbType.Int32,4),
					new SQLiteParameter("@EventPictureImage", DbType.Binary),
					new SQLiteParameter("@EventPictureID", DbType.Int32,4)};
			parameters[0].Value = model.EventPictureName;
			parameters[1].Value = model.EventPictureComercial;
			parameters[2].Value = model.EventPictureType;
			parameters[3].Value = model.EventPictureImage;
			parameters[4].Value = model.EventPictureID;

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
		public bool Delete(int EventPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventPictureInfo ");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventPictureID", DbType.Int32,4)			};
			parameters[0].Value = EventPictureID;

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
		public bool DeleteList(string EventPictureIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventPictureInfo ");
			strSql.Append(" where EventPictureID in ("+EventPictureIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo GetModel(int EventPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage from EventPictureInfo ");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventPictureID", DbType.Int32,4)			};
			parameters[0].Value = EventPictureID;

			KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo model=new KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo();
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
		public KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo model=new KryptonAccessController.SQLite.Model.InteractRelation.EventPictureInfo();
			if (row != null)
			{
				if(row["EventPictureID"]!=null && row["EventPictureID"].ToString()!="")
				{
					model.EventPictureID=int.Parse(row["EventPictureID"].ToString());
				}
				if(row["EventPictureName"]!=null)
				{
					model.EventPictureName=row["EventPictureName"].ToString();
				}
				if(row["EventPictureComercial"]!=null && row["EventPictureComercial"].ToString()!="")
				{
					model.EventPictureComercial=int.Parse(row["EventPictureComercial"].ToString());
				}
				if(row["EventPictureType"]!=null && row["EventPictureType"].ToString()!="")
				{
					model.EventPictureType=int.Parse(row["EventPictureType"].ToString());
				}
				if(row["EventPictureImage"]!=null && row["EventPictureImage"].ToString()!="")
				{
					model.EventPictureImage=(byte[])row["EventPictureImage"];
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
			strSql.Append("select EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage ");
			strSql.Append(" FROM EventPictureInfo ");
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
			strSql.Append("select count(1) FROM EventPictureInfo ");
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
				strSql.Append("order by T.EventPictureID desc");
			}
			strSql.Append(")AS Row, T.*  from EventPictureInfo T ");
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
			parameters[0].Value = "EventPictureInfo";
			parameters[1].Value = "EventPictureID";
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

