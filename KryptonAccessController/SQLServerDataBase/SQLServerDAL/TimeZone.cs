/**  版本信息模板在安装目录下，可自行修改。
* TimeZone.cs
*
* 功 能： N/A
* 类 名： TimeZone
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:36   N/A    初版
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
	/// 数据访问类:TimeZone
	/// </summary>
	public partial class TimeZone:ITimeZone
	{
		public TimeZone()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TimeZoneID", "TimeZone"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TimeZoneID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TimeZone");
			strSql.Append(" where TimeZoneID=@TimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeZoneID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.TimeZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TimeZone(");
			strSql.Append("TimeZoneID,STime1,ETime1,STime2,ETime2,STime3,ETime3,STime4,ETime4,STime5,ETime5,STime6,ETime6)");
			strSql.Append(" values (");
			strSql.Append("@TimeZoneID,@STime1,@ETime1,@STime2,@ETime2,@STime3,@ETime3,@STime4,@ETime4,@STime5,@ETime5,@STime6,@ETime6)");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeZoneID", SqlDbType.Int,4),
					new SqlParameter("@STime1", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime1", SqlDbType.NVarChar,8),
					new SqlParameter("@STime2", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime2", SqlDbType.NVarChar,8),
					new SqlParameter("@STime3", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime3", SqlDbType.NVarChar,8),
					new SqlParameter("@STime4", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime4", SqlDbType.NVarChar,8),
					new SqlParameter("@STime5", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime5", SqlDbType.NVarChar,8),
					new SqlParameter("@STime6", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime6", SqlDbType.NVarChar,8)};
			parameters[0].Value = model.TimeZoneID;
			parameters[1].Value = model.STime1;
			parameters[2].Value = model.ETime1;
			parameters[3].Value = model.STime2;
			parameters[4].Value = model.ETime2;
			parameters[5].Value = model.STime3;
			parameters[6].Value = model.ETime3;
			parameters[7].Value = model.STime4;
			parameters[8].Value = model.ETime4;
			parameters[9].Value = model.STime5;
			parameters[10].Value = model.ETime5;
			parameters[11].Value = model.STime6;
			parameters[12].Value = model.ETime6;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.TimeZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TimeZone set ");
			strSql.Append("STime1=@STime1,");
			strSql.Append("ETime1=@ETime1,");
			strSql.Append("STime2=@STime2,");
			strSql.Append("ETime2=@ETime2,");
			strSql.Append("STime3=@STime3,");
			strSql.Append("ETime3=@ETime3,");
			strSql.Append("STime4=@STime4,");
			strSql.Append("ETime4=@ETime4,");
			strSql.Append("STime5=@STime5,");
			strSql.Append("ETime5=@ETime5,");
			strSql.Append("STime6=@STime6,");
			strSql.Append("ETime6=@ETime6");
			strSql.Append(" where TimeZoneID=@TimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@STime1", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime1", SqlDbType.NVarChar,8),
					new SqlParameter("@STime2", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime2", SqlDbType.NVarChar,8),
					new SqlParameter("@STime3", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime3", SqlDbType.NVarChar,8),
					new SqlParameter("@STime4", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime4", SqlDbType.NVarChar,8),
					new SqlParameter("@STime5", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime5", SqlDbType.NVarChar,8),
					new SqlParameter("@STime6", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime6", SqlDbType.NVarChar,8),
					new SqlParameter("@TimeZoneID", SqlDbType.Int,4)};
			parameters[0].Value = model.STime1;
			parameters[1].Value = model.ETime1;
			parameters[2].Value = model.STime2;
			parameters[3].Value = model.ETime2;
			parameters[4].Value = model.STime3;
			parameters[5].Value = model.ETime3;
			parameters[6].Value = model.STime4;
			parameters[7].Value = model.ETime4;
			parameters[8].Value = model.STime5;
			parameters[9].Value = model.ETime5;
			parameters[10].Value = model.STime6;
			parameters[11].Value = model.ETime6;
			parameters[12].Value = model.TimeZoneID;

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
		public bool Delete(int TimeZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeZone ");
			strSql.Append(" where TimeZoneID=@TimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeZoneID;

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
		public bool DeleteList(string TimeZoneIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeZone ");
			strSql.Append(" where TimeZoneID in ("+TimeZoneIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.TimeZone GetModel(int TimeZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TimeZoneID,STime1,ETime1,STime2,ETime2,STime3,ETime3,STime4,ETime4,STime5,ETime5,STime6,ETime6 from TimeZone ");
			strSql.Append(" where TimeZoneID=@TimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeZoneID;

			KryptonAccessController.AccessDataBase.Model.TimeZone model=new KryptonAccessController.AccessDataBase.Model.TimeZone();
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
		public KryptonAccessController.AccessDataBase.Model.TimeZone DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.TimeZone model=new KryptonAccessController.AccessDataBase.Model.TimeZone();
			if (row != null)
			{
				if(row["TimeZoneID"]!=null && row["TimeZoneID"].ToString()!="")
				{
					model.TimeZoneID=int.Parse(row["TimeZoneID"].ToString());
				}
				if(row["STime1"]!=null)
				{
					model.STime1=row["STime1"].ToString();
				}
				if(row["ETime1"]!=null)
				{
					model.ETime1=row["ETime1"].ToString();
				}
				if(row["STime2"]!=null)
				{
					model.STime2=row["STime2"].ToString();
				}
				if(row["ETime2"]!=null)
				{
					model.ETime2=row["ETime2"].ToString();
				}
				if(row["STime3"]!=null)
				{
					model.STime3=row["STime3"].ToString();
				}
				if(row["ETime3"]!=null)
				{
					model.ETime3=row["ETime3"].ToString();
				}
				if(row["STime4"]!=null)
				{
					model.STime4=row["STime4"].ToString();
				}
				if(row["ETime4"]!=null)
				{
					model.ETime4=row["ETime4"].ToString();
				}
				if(row["STime5"]!=null)
				{
					model.STime5=row["STime5"].ToString();
				}
				if(row["ETime5"]!=null)
				{
					model.ETime5=row["ETime5"].ToString();
				}
				if(row["STime6"]!=null)
				{
					model.STime6=row["STime6"].ToString();
				}
				if(row["ETime6"]!=null)
				{
					model.ETime6=row["ETime6"].ToString();
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
			strSql.Append("select TimeZoneID,STime1,ETime1,STime2,ETime2,STime3,ETime3,STime4,ETime4,STime5,ETime5,STime6,ETime6 ");
			strSql.Append(" FROM TimeZone ");
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
			strSql.Append(" TimeZoneID,STime1,ETime1,STime2,ETime2,STime3,ETime3,STime4,ETime4,STime5,ETime5,STime6,ETime6 ");
			strSql.Append(" FROM TimeZone ");
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
			strSql.Append("select count(1) FROM TimeZone ");
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
				strSql.Append("order by T.TimeZoneID desc");
			}
			strSql.Append(")AS Row, T.*  from TimeZone T ");
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
			parameters[0].Value = "TimeZone";
			parameters[1].Value = "TimeZoneID";
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

