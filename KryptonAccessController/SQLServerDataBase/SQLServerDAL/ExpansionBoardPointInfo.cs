/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardPointInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardPointInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:24   N/A    初版
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
	/// 数据访问类:ExpansionBoardPointInfo
	/// </summary>
	public partial class ExpansionBoardPointInfo:IExpansionBoardPointInfo
	{
		public ExpansionBoardPointInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ExpansionBoardPointID", "ExpansionBoardPointInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ExpansionBoardPointID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExpansionBoardPointInfo");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardPointID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardPointID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExpansionBoardPointInfo(");
			strSql.Append("ExpansionBoardPointID,PointName,PointType,PointID,PointState,ExpansionBoardID)");
			strSql.Append(" values (");
			strSql.Append("@ExpansionBoardPointID,@PointName,@PointType,@PointID,@PointState,@ExpansionBoardID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardPointID", SqlDbType.Int,4),
					new SqlParameter("@PointName", SqlDbType.NVarChar,50),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@PointState", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)};
			parameters[0].Value = model.ExpansionBoardPointID;
			parameters[1].Value = model.PointName;
			parameters[2].Value = model.PointType;
			parameters[3].Value = model.PointID;
			parameters[4].Value = model.PointState;
			parameters[5].Value = model.ExpansionBoardID;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExpansionBoardPointInfo set ");
			strSql.Append("PointName=@PointName,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("PointState=@PointState,");
			strSql.Append("ExpansionBoardID=@ExpansionBoardID");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointName", SqlDbType.NVarChar,50),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@PointState", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardPointID", SqlDbType.Int,4)};
			parameters[0].Value = model.PointName;
			parameters[1].Value = model.PointType;
			parameters[2].Value = model.PointID;
			parameters[3].Value = model.PointState;
			parameters[4].Value = model.ExpansionBoardID;
			parameters[5].Value = model.ExpansionBoardPointID;

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
		public bool Delete(int ExpansionBoardPointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardPointID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardPointID;

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
		public bool DeleteList(string ExpansionBoardPointIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID in ("+ExpansionBoardPointIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo GetModel(int ExpansionBoardPointID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ExpansionBoardPointID,PointName,PointType,PointID,PointState,ExpansionBoardID from ExpansionBoardPointInfo ");
			strSql.Append(" where ExpansionBoardPointID=@ExpansionBoardPointID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardPointID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardPointID;

			KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo model=new KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo();
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
		public KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo model=new KryptonAccessController.AccessDataBase.Model.ExpansionBoardPointInfo();
			if (row != null)
			{
				if(row["ExpansionBoardPointID"]!=null && row["ExpansionBoardPointID"].ToString()!="")
				{
					model.ExpansionBoardPointID=int.Parse(row["ExpansionBoardPointID"].ToString());
				}
				if(row["PointName"]!=null)
				{
					model.PointName=row["PointName"].ToString();
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["PointState"]!=null && row["PointState"].ToString()!="")
				{
					model.PointState=int.Parse(row["PointState"].ToString());
				}
				if(row["ExpansionBoardID"]!=null && row["ExpansionBoardID"].ToString()!="")
				{
					model.ExpansionBoardID=int.Parse(row["ExpansionBoardID"].ToString());
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
			strSql.Append("select ExpansionBoardPointID,PointName,PointType,PointID,PointState,ExpansionBoardID ");
			strSql.Append(" FROM ExpansionBoardPointInfo ");
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
			strSql.Append(" ExpansionBoardPointID,PointName,PointType,PointID,PointState,ExpansionBoardID ");
			strSql.Append(" FROM ExpansionBoardPointInfo ");
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
			strSql.Append("select count(1) FROM ExpansionBoardPointInfo ");
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
				strSql.Append("order by T.ExpansionBoardPointID desc");
			}
			strSql.Append(")AS Row, T.*  from ExpansionBoardPointInfo T ");
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
			parameters[0].Value = "ExpansionBoardPointInfo";
			parameters[1].Value = "ExpansionBoardPointID";
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

