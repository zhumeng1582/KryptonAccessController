/**  版本信息模板在安装目录下，可自行修改。
* HolidayStandardOperateProcedure.cs
*
* 功 能： N/A
* 类 名： HolidayStandardOperateProcedure
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:25   N/A    初版
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
	/// 数据访问类:HolidayStandardOperateProcedure
	/// </summary>
	public partial class HolidayStandardOperateProcedure:IHolidayStandardOperateProcedure
	{
		public HolidayStandardOperateProcedure()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HolidayStandardOperateProcedure(");
			strSql.Append("HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimePoint,SOPID)");
			strSql.Append(" values (");
			strSql.Append("@HolidayID,@HolidayName,@HolidayStartDate,@HolidayEndDate,@HolidayType,@TimePoint,@SOPID)");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4),
					new SqlParameter("@HolidayName", SqlDbType.NVarChar,50),
					new SqlParameter("@HolidayStartDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayEndDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayType", SqlDbType.Int,4),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@SOPID", SqlDbType.Int,4)};
			parameters[0].Value = model.HolidayID;
			parameters[1].Value = model.HolidayName;
			parameters[2].Value = model.HolidayStartDate;
			parameters[3].Value = model.HolidayEndDate;
			parameters[4].Value = model.HolidayType;
			parameters[5].Value = model.TimePoint;
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HolidayStandardOperateProcedure set ");
			strSql.Append("HolidayID=@HolidayID,");
			strSql.Append("HolidayName=@HolidayName,");
			strSql.Append("HolidayStartDate=@HolidayStartDate,");
			strSql.Append("HolidayEndDate=@HolidayEndDate,");
			strSql.Append("HolidayType=@HolidayType,");
			strSql.Append("TimePoint=@TimePoint,");
			strSql.Append("SOPID=@SOPID");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4),
					new SqlParameter("@HolidayName", SqlDbType.NVarChar,50),
					new SqlParameter("@HolidayStartDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayEndDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayType", SqlDbType.Int,4),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@SOPID", SqlDbType.Int,4)};
			parameters[0].Value = model.HolidayID;
			parameters[1].Value = model.HolidayName;
			parameters[2].Value = model.HolidayStartDate;
			parameters[3].Value = model.HolidayEndDate;
			parameters[4].Value = model.HolidayType;
			parameters[5].Value = model.TimePoint;
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
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidayStandardOperateProcedure ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimePoint,SOPID from HolidayStandardOperateProcedure ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure model=new KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure();
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
		public KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure model=new KryptonAccessController.AccessDataBase.Model.HolidayStandardOperateProcedure();
			if (row != null)
			{
				if(row["HolidayID"]!=null && row["HolidayID"].ToString()!="")
				{
					model.HolidayID=int.Parse(row["HolidayID"].ToString());
				}
				if(row["HolidayName"]!=null)
				{
					model.HolidayName=row["HolidayName"].ToString();
				}
				if(row["HolidayStartDate"]!=null)
				{
					model.HolidayStartDate=row["HolidayStartDate"].ToString();
				}
				if(row["HolidayEndDate"]!=null)
				{
					model.HolidayEndDate=row["HolidayEndDate"].ToString();
				}
				if(row["HolidayType"]!=null && row["HolidayType"].ToString()!="")
				{
					model.HolidayType=int.Parse(row["HolidayType"].ToString());
				}
				if(row["TimePoint"]!=null)
				{
					model.TimePoint=row["TimePoint"].ToString();
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
			strSql.Append("select HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimePoint,SOPID ");
			strSql.Append(" FROM HolidayStandardOperateProcedure ");
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
			strSql.Append(" HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimePoint,SOPID ");
			strSql.Append(" FROM HolidayStandardOperateProcedure ");
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
			strSql.Append("select count(1) FROM HolidayStandardOperateProcedure ");
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
				strSql.Append("order by T.HolidayID desc");
			}
			strSql.Append(")AS Row, T.*  from HolidayStandardOperateProcedure T ");
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
			parameters[0].Value = "HolidayStandardOperateProcedure";
			parameters[1].Value = "HolidayID";
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

