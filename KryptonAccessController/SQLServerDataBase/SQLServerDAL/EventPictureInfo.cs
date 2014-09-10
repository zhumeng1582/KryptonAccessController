/**  版本信息模板在安装目录下，可自行修改。
* EventPictureInfo.cs
*
* 功 能： N/A
* 类 名： EventPictureInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:23   N/A    初版
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
	/// 数据访问类:EventPictureInfo
	/// </summary>
	public partial class EventPictureInfo:IEventPictureInfo
	{
		public EventPictureInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EventPictureID", "EventPictureInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventPictureID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventPictureInfo");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = EventPictureID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.EventPictureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventPictureInfo(");
			strSql.Append("EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage)");
			strSql.Append(" values (");
			strSql.Append("@EventPictureID,@EventPictureName,@EventPictureComercial,@EventPictureType,@EventPictureImage)");
			SqlParameter[] parameters = {
					new SqlParameter("@EventPictureID", SqlDbType.Int,4),
					new SqlParameter("@EventPictureName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventPictureComercial", SqlDbType.Int,4),
					new SqlParameter("@EventPictureType", SqlDbType.Int,4),
					new SqlParameter("@EventPictureImage", SqlDbType.Image)};
			parameters[0].Value = model.EventPictureID;
			parameters[1].Value = model.EventPictureName;
			parameters[2].Value = model.EventPictureComercial;
			parameters[3].Value = model.EventPictureType;
			parameters[4].Value = model.EventPictureImage;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.EventPictureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventPictureInfo set ");
			strSql.Append("EventPictureName=@EventPictureName,");
			strSql.Append("EventPictureComercial=@EventPictureComercial,");
			strSql.Append("EventPictureType=@EventPictureType,");
			strSql.Append("EventPictureImage=@EventPictureImage");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventPictureName", SqlDbType.NVarChar,50),
					new SqlParameter("@EventPictureComercial", SqlDbType.Int,4),
					new SqlParameter("@EventPictureType", SqlDbType.Int,4),
					new SqlParameter("@EventPictureImage", SqlDbType.Image),
					new SqlParameter("@EventPictureID", SqlDbType.Int,4)};
			parameters[0].Value = model.EventPictureName;
			parameters[1].Value = model.EventPictureComercial;
			parameters[2].Value = model.EventPictureType;
			parameters[3].Value = model.EventPictureImage;
			parameters[4].Value = model.EventPictureID;

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
		public bool Delete(int EventPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventPictureInfo ");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = EventPictureID;

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
		public bool DeleteList(string EventPictureIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventPictureInfo ");
			strSql.Append(" where EventPictureID in ("+EventPictureIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.EventPictureInfo GetModel(int EventPictureID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage from EventPictureInfo ");
			strSql.Append(" where EventPictureID=@EventPictureID ");
			SqlParameter[] parameters = {
					new SqlParameter("@EventPictureID", SqlDbType.Int,4)			};
			parameters[0].Value = EventPictureID;

			KryptonAccessController.AccessDataBase.Model.EventPictureInfo model=new KryptonAccessController.AccessDataBase.Model.EventPictureInfo();
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
		public KryptonAccessController.AccessDataBase.Model.EventPictureInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.EventPictureInfo model=new KryptonAccessController.AccessDataBase.Model.EventPictureInfo();
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
			strSql.Append(" EventPictureID,EventPictureName,EventPictureComercial,EventPictureType,EventPictureImage ");
			strSql.Append(" FROM EventPictureInfo ");
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
			parameters[0].Value = "EventPictureInfo";
			parameters[1].Value = "EventPictureID";
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

