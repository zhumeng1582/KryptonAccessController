/**  版本信息模板在安装目录下，可自行修改。
* ReaderTimeZone.cs
*
* 功 能： N/A
* 类 名： ReaderTimeZone
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:32   N/A    初版
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
	/// 数据访问类:ReaderTimeZone
	/// </summary>
	public partial class ReaderTimeZone:IReaderTimeZone
	{
		public ReaderTimeZone()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReaderTimeZoneID", "ReaderTimeZone"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderTimeZoneID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderTimeZone");
			strSql.Append(" where ReaderTimeZoneID=@ReaderTimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeZoneID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ReaderTimeZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderTimeZone(");
			strSql.Append("ReaderTimeZoneID,OperateMode1,TimeZone1,OperateMode2,TimeZone2,OperateMode3,TimeZone3,OperateMode4,TimeZone4,OperateMode5,TimeZone5,OperateMode6,TimeZone6)");
			strSql.Append(" values (");
			strSql.Append("@ReaderTimeZoneID,@OperateMode1,@TimeZone1,@OperateMode2,@TimeZone2,@OperateMode3,@TimeZone3,@OperateMode4,@TimeZone4,@OperateMode5,@TimeZone5,@OperateMode6,@TimeZone6)");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeZoneID", SqlDbType.Int,4),
					new SqlParameter("@OperateMode1", SqlDbType.Int,4),
					new SqlParameter("@TimeZone1", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode2", SqlDbType.Int,4),
					new SqlParameter("@TimeZone2", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode3", SqlDbType.Int,4),
					new SqlParameter("@TimeZone3", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode4", SqlDbType.Int,4),
					new SqlParameter("@TimeZone4", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode5", SqlDbType.Int,4),
					new SqlParameter("@TimeZone5", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode6", SqlDbType.Int,4),
					new SqlParameter("@TimeZone6", SqlDbType.NVarChar,8)};
			parameters[0].Value = model.ReaderTimeZoneID;
			parameters[1].Value = model.OperateMode1;
			parameters[2].Value = model.TimeZone1;
			parameters[3].Value = model.OperateMode2;
			parameters[4].Value = model.TimeZone2;
			parameters[5].Value = model.OperateMode3;
			parameters[6].Value = model.TimeZone3;
			parameters[7].Value = model.OperateMode4;
			parameters[8].Value = model.TimeZone4;
			parameters[9].Value = model.OperateMode5;
			parameters[10].Value = model.TimeZone5;
			parameters[11].Value = model.OperateMode6;
			parameters[12].Value = model.TimeZone6;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ReaderTimeZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReaderTimeZone set ");
			strSql.Append("OperateMode1=@OperateMode1,");
			strSql.Append("TimeZone1=@TimeZone1,");
			strSql.Append("OperateMode2=@OperateMode2,");
			strSql.Append("TimeZone2=@TimeZone2,");
			strSql.Append("OperateMode3=@OperateMode3,");
			strSql.Append("TimeZone3=@TimeZone3,");
			strSql.Append("OperateMode4=@OperateMode4,");
			strSql.Append("TimeZone4=@TimeZone4,");
			strSql.Append("OperateMode5=@OperateMode5,");
			strSql.Append("TimeZone5=@TimeZone5,");
			strSql.Append("OperateMode6=@OperateMode6,");
			strSql.Append("TimeZone6=@TimeZone6");
			strSql.Append(" where ReaderTimeZoneID=@ReaderTimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperateMode1", SqlDbType.Int,4),
					new SqlParameter("@TimeZone1", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode2", SqlDbType.Int,4),
					new SqlParameter("@TimeZone2", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode3", SqlDbType.Int,4),
					new SqlParameter("@TimeZone3", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode4", SqlDbType.Int,4),
					new SqlParameter("@TimeZone4", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode5", SqlDbType.Int,4),
					new SqlParameter("@TimeZone5", SqlDbType.NVarChar,8),
					new SqlParameter("@OperateMode6", SqlDbType.Int,4),
					new SqlParameter("@TimeZone6", SqlDbType.NVarChar,8),
					new SqlParameter("@ReaderTimeZoneID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperateMode1;
			parameters[1].Value = model.TimeZone1;
			parameters[2].Value = model.OperateMode2;
			parameters[3].Value = model.TimeZone2;
			parameters[4].Value = model.OperateMode3;
			parameters[5].Value = model.TimeZone3;
			parameters[6].Value = model.OperateMode4;
			parameters[7].Value = model.TimeZone4;
			parameters[8].Value = model.OperateMode5;
			parameters[9].Value = model.TimeZone5;
			parameters[10].Value = model.OperateMode6;
			parameters[11].Value = model.TimeZone6;
			parameters[12].Value = model.ReaderTimeZoneID;

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
		public bool Delete(int ReaderTimeZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderTimeZone ");
			strSql.Append(" where ReaderTimeZoneID=@ReaderTimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeZoneID;

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
		public bool DeleteList(string ReaderTimeZoneIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderTimeZone ");
			strSql.Append(" where ReaderTimeZoneID in ("+ReaderTimeZoneIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ReaderTimeZone GetModel(int ReaderTimeZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReaderTimeZoneID,OperateMode1,TimeZone1,OperateMode2,TimeZone2,OperateMode3,TimeZone3,OperateMode4,TimeZone4,OperateMode5,TimeZone5,OperateMode6,TimeZone6 from ReaderTimeZone ");
			strSql.Append(" where ReaderTimeZoneID=@ReaderTimeZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeZoneID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeZoneID;

			KryptonAccessController.AccessDataBase.Model.ReaderTimeZone model=new KryptonAccessController.AccessDataBase.Model.ReaderTimeZone();
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
		public KryptonAccessController.AccessDataBase.Model.ReaderTimeZone DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ReaderTimeZone model=new KryptonAccessController.AccessDataBase.Model.ReaderTimeZone();
			if (row != null)
			{
				if(row["ReaderTimeZoneID"]!=null && row["ReaderTimeZoneID"].ToString()!="")
				{
					model.ReaderTimeZoneID=int.Parse(row["ReaderTimeZoneID"].ToString());
				}
				if(row["OperateMode1"]!=null && row["OperateMode1"].ToString()!="")
				{
					model.OperateMode1=int.Parse(row["OperateMode1"].ToString());
				}
				if(row["TimeZone1"]!=null)
				{
					model.TimeZone1=row["TimeZone1"].ToString();
				}
				if(row["OperateMode2"]!=null && row["OperateMode2"].ToString()!="")
				{
					model.OperateMode2=int.Parse(row["OperateMode2"].ToString());
				}
				if(row["TimeZone2"]!=null)
				{
					model.TimeZone2=row["TimeZone2"].ToString();
				}
				if(row["OperateMode3"]!=null && row["OperateMode3"].ToString()!="")
				{
					model.OperateMode3=int.Parse(row["OperateMode3"].ToString());
				}
				if(row["TimeZone3"]!=null)
				{
					model.TimeZone3=row["TimeZone3"].ToString();
				}
				if(row["OperateMode4"]!=null && row["OperateMode4"].ToString()!="")
				{
					model.OperateMode4=int.Parse(row["OperateMode4"].ToString());
				}
				if(row["TimeZone4"]!=null)
				{
					model.TimeZone4=row["TimeZone4"].ToString();
				}
				if(row["OperateMode5"]!=null && row["OperateMode5"].ToString()!="")
				{
					model.OperateMode5=int.Parse(row["OperateMode5"].ToString());
				}
				if(row["TimeZone5"]!=null)
				{
					model.TimeZone5=row["TimeZone5"].ToString();
				}
				if(row["OperateMode6"]!=null && row["OperateMode6"].ToString()!="")
				{
					model.OperateMode6=int.Parse(row["OperateMode6"].ToString());
				}
				if(row["TimeZone6"]!=null)
				{
					model.TimeZone6=row["TimeZone6"].ToString();
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
			strSql.Append("select ReaderTimeZoneID,OperateMode1,TimeZone1,OperateMode2,TimeZone2,OperateMode3,TimeZone3,OperateMode4,TimeZone4,OperateMode5,TimeZone5,OperateMode6,TimeZone6 ");
			strSql.Append(" FROM ReaderTimeZone ");
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
			strSql.Append(" ReaderTimeZoneID,OperateMode1,TimeZone1,OperateMode2,TimeZone2,OperateMode3,TimeZone3,OperateMode4,TimeZone4,OperateMode5,TimeZone5,OperateMode6,TimeZone6 ");
			strSql.Append(" FROM ReaderTimeZone ");
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
			strSql.Append("select count(1) FROM ReaderTimeZone ");
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
				strSql.Append("order by T.ReaderTimeZoneID desc");
			}
			strSql.Append(")AS Row, T.*  from ReaderTimeZone T ");
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
			parameters[0].Value = "ReaderTimeZone";
			parameters[1].Value = "ReaderTimeZoneID";
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

