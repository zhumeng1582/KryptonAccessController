/**  版本信息模板在安装目录下，可自行修改。
* EventCodeInfo.cs
*
* 功 能： N/A
* 类 名： EventCodeInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:22   N/A    初版
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
	/// 数据访问类:EventCodeInfo
	/// </summary>
	public partial class EventCodeInfo:IEventCodeInfo
	{
		public EventCodeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EventCodeID", "EventCodeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventCodeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventCodeInfo");
			strSql.Append(" where EventCodeID=@EventCodeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventCodeID", SqlDbType.Int,4)			};
			parameters[0].Value = EventCodeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.EventCodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventCodeInfo(");
			strSql.Append("EventCodeID,EventCodeType,EventCodeName,EventCodePictureID,EventUpLoadPriority)");
			strSql.Append(" values (");
			strSql.Append("@EventCodeID,@EventCodeType,@EventCodeName,@EventCodePictureID,@EventUpLoadPriority)");
			SqlParameter[] parameters = {
					new SqlParameter("@EventCodeID", SqlDbType.Int,4),
					new SqlParameter("@EventCodeType", SqlDbType.Int,4),
					new SqlParameter("@EventCodeName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventCodePictureID", SqlDbType.Int,4),
					new SqlParameter("@EventUpLoadPriority", SqlDbType.Int,4)};
			parameters[0].Value = model.EventCodeID;
			parameters[1].Value = model.EventCodeType;
			parameters[2].Value = model.EventCodeName;
			parameters[3].Value = model.EventCodePictureID;
			parameters[4].Value = model.EventUpLoadPriority;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.EventCodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventCodeInfo set ");
			strSql.Append("EventCodeType=@EventCodeType,");
			strSql.Append("EventCodeName=@EventCodeName,");
			strSql.Append("EventCodePictureID=@EventCodePictureID,");
			strSql.Append("EventUpLoadPriority=@EventUpLoadPriority");
			strSql.Append(" where EventCodeID=@EventCodeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventCodeType", SqlDbType.Int,4),
					new SqlParameter("@EventCodeName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventCodePictureID", SqlDbType.Int,4),
					new SqlParameter("@EventUpLoadPriority", SqlDbType.Int,4),
					new SqlParameter("@EventCodeID", SqlDbType.Int,4)};
			parameters[0].Value = model.EventCodeType;
			parameters[1].Value = model.EventCodeName;
			parameters[2].Value = model.EventCodePictureID;
			parameters[3].Value = model.EventUpLoadPriority;
			parameters[4].Value = model.EventCodeID;

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
		public bool Delete(int EventCodeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventCodeInfo ");
			strSql.Append(" where EventCodeID=@EventCodeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventCodeID", SqlDbType.Int,4)			};
			parameters[0].Value = EventCodeID;

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
		public bool DeleteList(string EventCodeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventCodeInfo ");
			strSql.Append(" where EventCodeID in ("+EventCodeIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.EventCodeInfo GetModel(int EventCodeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EventCodeID,EventCodeType,EventCodeName,EventCodePictureID,EventUpLoadPriority from EventCodeInfo ");
			strSql.Append(" where EventCodeID=@EventCodeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventCodeID", SqlDbType.Int,4)			};
			parameters[0].Value = EventCodeID;

			KryptonAccessController.AccessDataBase.Model.EventCodeInfo model=new KryptonAccessController.AccessDataBase.Model.EventCodeInfo();
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
		public KryptonAccessController.AccessDataBase.Model.EventCodeInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.EventCodeInfo model=new KryptonAccessController.AccessDataBase.Model.EventCodeInfo();
			if (row != null)
			{
				if(row["EventCodeID"]!=null && row["EventCodeID"].ToString()!="")
				{
					model.EventCodeID=int.Parse(row["EventCodeID"].ToString());
				}
				if(row["EventCodeType"]!=null && row["EventCodeType"].ToString()!="")
				{
					model.EventCodeType=int.Parse(row["EventCodeType"].ToString());
				}
				if(row["EventCodeName"]!=null)
				{
					model.EventCodeName=row["EventCodeName"].ToString();
				}
				if(row["EventCodePictureID"]!=null && row["EventCodePictureID"].ToString()!="")
				{
					model.EventCodePictureID=int.Parse(row["EventCodePictureID"].ToString());
				}
				if(row["EventUpLoadPriority"]!=null && row["EventUpLoadPriority"].ToString()!="")
				{
					model.EventUpLoadPriority=int.Parse(row["EventUpLoadPriority"].ToString());
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
			strSql.Append("select EventCodeID,EventCodeType,EventCodeName,EventCodePictureID,EventUpLoadPriority ");
			strSql.Append(" FROM EventCodeInfo ");
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
			strSql.Append(" EventCodeID,EventCodeType,EventCodeName,EventCodePictureID,EventUpLoadPriority ");
			strSql.Append(" FROM EventCodeInfo ");
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
			strSql.Append("select count(1) FROM EventCodeInfo ");
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
				strSql.Append("order by T.EventCodeID desc");
			}
			strSql.Append(")AS Row, T.*  from EventCodeInfo T ");
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
			parameters[0].Value = "EventCodeInfo";
			parameters[1].Value = "EventCodeID";
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

