/**  版本信息模板在安装目录下，可自行修改。
* HolidaySOP.cs
*
* 功 能： N/A
* 类 名： HolidaySOP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:33:40   N/A    初版
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
	/// 数据访问类:HolidaySOP
	/// </summary>
	public partial class HolidaySOP:IHolidaySOP
	{
		public HolidaySOP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("HolidayID", "HolidaySOP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HolidayID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HolidaySOP");
			strSql.Append(" where HolidayID=@HolidayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4)			};
			parameters[0].Value = HolidayID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.HolidaySOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HolidaySOP(");
			strSql.Append("HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeSOPID)");
			strSql.Append(" values (");
			strSql.Append("@HolidayID,@HolidayName,@HolidayStartDate,@HolidayEndDate,@HolidayType,@TimeSOPID)");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4),
					new SqlParameter("@HolidayName", SqlDbType.NVarChar,50),
					new SqlParameter("@HolidayStartDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayEndDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayType", SqlDbType.Int,4),
					new SqlParameter("@TimeSOPID", SqlDbType.Int,4)};
			parameters[0].Value = model.HolidayID;
			parameters[1].Value = model.HolidayName;
			parameters[2].Value = model.HolidayStartDate;
			parameters[3].Value = model.HolidayEndDate;
			parameters[4].Value = model.HolidayType;
			parameters[5].Value = model.TimeSOPID;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.HolidaySOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HolidaySOP set ");
			strSql.Append("HolidayName=@HolidayName,");
			strSql.Append("HolidayStartDate=@HolidayStartDate,");
			strSql.Append("HolidayEndDate=@HolidayEndDate,");
			strSql.Append("HolidayType=@HolidayType,");
			strSql.Append("TimeSOPID=@TimeSOPID");
			strSql.Append(" where HolidayID=@HolidayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayName", SqlDbType.NVarChar,50),
					new SqlParameter("@HolidayStartDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayEndDate", SqlDbType.NVarChar,10),
					new SqlParameter("@HolidayType", SqlDbType.Int,4),
					new SqlParameter("@TimeSOPID", SqlDbType.Int,4),
					new SqlParameter("@HolidayID", SqlDbType.Int,4)};
			parameters[0].Value = model.HolidayName;
			parameters[1].Value = model.HolidayStartDate;
			parameters[2].Value = model.HolidayEndDate;
			parameters[3].Value = model.HolidayType;
			parameters[4].Value = model.TimeSOPID;
			parameters[5].Value = model.HolidayID;

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
		public bool Delete(int HolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidaySOP ");
			strSql.Append(" where HolidayID=@HolidayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4)			};
			parameters[0].Value = HolidayID;

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
		public bool DeleteList(string HolidayIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidaySOP ");
			strSql.Append(" where HolidayID in ("+HolidayIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.HolidaySOP GetModel(int HolidayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeSOPID from HolidaySOP ");
			strSql.Append(" where HolidayID=@HolidayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HolidayID", SqlDbType.Int,4)			};
			parameters[0].Value = HolidayID;

			KryptonAccessController.AccessDataBase.Model.HolidaySOP model=new KryptonAccessController.AccessDataBase.Model.HolidaySOP();
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
		public KryptonAccessController.AccessDataBase.Model.HolidaySOP DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.HolidaySOP model=new KryptonAccessController.AccessDataBase.Model.HolidaySOP();
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
				if(row["TimeSOPID"]!=null && row["TimeSOPID"].ToString()!="")
				{
					model.TimeSOPID=int.Parse(row["TimeSOPID"].ToString());
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
			strSql.Append("select HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeSOPID ");
			strSql.Append(" FROM HolidaySOP ");
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
			strSql.Append(" HolidayID,HolidayName,HolidayStartDate,HolidayEndDate,HolidayType,TimeSOPID ");
			strSql.Append(" FROM HolidaySOP ");
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
			strSql.Append("select count(1) FROM HolidaySOP ");
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
			strSql.Append(")AS Row, T.*  from HolidaySOP T ");
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
			parameters[0].Value = "HolidaySOP";
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

