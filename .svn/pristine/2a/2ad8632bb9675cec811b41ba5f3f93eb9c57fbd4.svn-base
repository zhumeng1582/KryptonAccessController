/**  版本信息模板在安装目录下，可自行修改。
* EventSOP.cs
*
* 功 能： N/A
* 类 名： EventSOP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:32:47   N/A    初版
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
	/// 数据访问类:EventSOP
	/// </summary>
	public partial class EventSOP:IEventSOP
	{
		public EventSOP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EventSOPGID", "EventSOP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventSOPGID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventSOP");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventSOPGID", SqlDbType.Int,4)			};
			parameters[0].Value = EventSOPGID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.EventSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventSOP(");
			strSql.Append("EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID)");
			strSql.Append(" values (");
			strSql.Append("@EventSOPGID,@EventSOPGName,@EventSOPGEnable,@PointType,@PointID,@EventCodeID,@SOPID)");
			SqlParameter[] parameters = {
					new SqlParameter("@EventSOPGID", SqlDbType.Int,4),
					new SqlParameter("@EventSOPGName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventSOPGEnable", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@EventCodeID", SqlDbType.Int,4),
					new SqlParameter("@SOPID", SqlDbType.Int,4)};
			parameters[0].Value = model.EventSOPGID;
			parameters[1].Value = model.EventSOPGName;
			parameters[2].Value = model.EventSOPGEnable;
			parameters[3].Value = model.PointType;
			parameters[4].Value = model.PointID;
			parameters[5].Value = model.EventCodeID;
			parameters[6].Value = model.SOPID;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.EventSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventSOP set ");
			strSql.Append("EventSOPGName=@EventSOPGName,");
			strSql.Append("EventSOPGEnable=@EventSOPGEnable,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("EventCodeID=@EventCodeID,");
			strSql.Append("SOPID=@SOPID");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventSOPGName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventSOPGEnable", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@EventCodeID", SqlDbType.Int,4),
					new SqlParameter("@SOPID", SqlDbType.Int,4),
					new SqlParameter("@EventSOPGID", SqlDbType.Int,4)};
			parameters[0].Value = model.EventSOPGName;
			parameters[1].Value = model.EventSOPGEnable;
			parameters[2].Value = model.PointType;
			parameters[3].Value = model.PointID;
			parameters[4].Value = model.EventCodeID;
			parameters[5].Value = model.SOPID;
			parameters[6].Value = model.EventSOPGID;

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
		public bool Delete(int EventSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventSOP ");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventSOPGID", SqlDbType.Int,4)			};
			parameters[0].Value = EventSOPGID;

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
		public bool DeleteList(string EventSOPGIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventSOP ");
			strSql.Append(" where EventSOPGID in ("+EventSOPGIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.EventSOP GetModel(int EventSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID from EventSOP ");
			strSql.Append(" where EventSOPGID=@EventSOPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventSOPGID", SqlDbType.Int,4)			};
			parameters[0].Value = EventSOPGID;

			KryptonAccessController.AccessDataBase.Model.EventSOP model=new KryptonAccessController.AccessDataBase.Model.EventSOP();
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
		public KryptonAccessController.AccessDataBase.Model.EventSOP DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.EventSOP model=new KryptonAccessController.AccessDataBase.Model.EventSOP();
			if (row != null)
			{
				if(row["EventSOPGID"]!=null && row["EventSOPGID"].ToString()!="")
				{
					model.EventSOPGID=int.Parse(row["EventSOPGID"].ToString());
				}
				if(row["EventSOPGName"]!=null)
				{
					model.EventSOPGName=row["EventSOPGName"].ToString();
				}
				if(row["EventSOPGEnable"]!=null && row["EventSOPGEnable"].ToString()!="")
				{
					if((row["EventSOPGEnable"].ToString()=="1")||(row["EventSOPGEnable"].ToString().ToLower()=="true"))
					{
						model.EventSOPGEnable=true;
					}
					else
					{
						model.EventSOPGEnable=false;
					}
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["EventCodeID"]!=null && row["EventCodeID"].ToString()!="")
				{
					model.EventCodeID=int.Parse(row["EventCodeID"].ToString());
				}
				if(row["SOPID"]!=null && row["SOPID"].ToString()!="")
				{
					model.SOPID=int.Parse(row["SOPID"].ToString());
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
			strSql.Append("select EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID ");
			strSql.Append(" FROM EventSOP ");
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
			strSql.Append(" EventSOPGID,EventSOPGName,EventSOPGEnable,PointType,PointID,EventCodeID,SOPID ");
			strSql.Append(" FROM EventSOP ");
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
			strSql.Append("select count(1) FROM EventSOP ");
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
				strSql.Append("order by T.EventSOPGID desc");
			}
			strSql.Append(")AS Row, T.*  from EventSOP T ");
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
			parameters[0].Value = "EventSOP";
			parameters[1].Value = "EventSOPGID";
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

