/**  版本信息模板在安装目录下，可自行修改。
* ReaderTimeAccess.cs
*
* 功 能： N/A
* 类 名： ReaderTimeAccess
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
	/// 数据访问类:ReaderTimeAccess
	/// </summary>
	public partial class ReaderTimeAccess:IReaderTimeAccess
	{
		public ReaderTimeAccess()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReaderTimeAccessID", "ReaderTimeAccess"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderTimeAccessID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderTimeAccess");
			strSql.Append(" where ReaderTimeAccessID=@ReaderTimeAccessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeAccessID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeAccessID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderTimeAccess(");
			strSql.Append("ReaderTimeAccessID,ReaderTimeAccessName,Mon,Tue,Wed,Thu,Fri,Sat,Sun)");
			strSql.Append(" values (");
			strSql.Append("@ReaderTimeAccessID,@ReaderTimeAccessName,@Mon,@Tue,@Wed,@Thu,@Fri,@Sat,@Sun)");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeAccessID", SqlDbType.Int,4),
					new SqlParameter("@ReaderTimeAccessName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mon", SqlDbType.Int,4),
					new SqlParameter("@Tue", SqlDbType.Int,4),
					new SqlParameter("@Wed", SqlDbType.Int,4),
					new SqlParameter("@Thu", SqlDbType.Int,4),
					new SqlParameter("@Fri", SqlDbType.Int,4),
					new SqlParameter("@Sat", SqlDbType.Int,4),
					new SqlParameter("@Sun", SqlDbType.Int,4)};
			parameters[0].Value = model.ReaderTimeAccessID;
			parameters[1].Value = model.ReaderTimeAccessName;
			parameters[2].Value = model.Mon;
			parameters[3].Value = model.Tue;
			parameters[4].Value = model.Wed;
			parameters[5].Value = model.Thu;
			parameters[6].Value = model.Fri;
			parameters[7].Value = model.Sat;
			parameters[8].Value = model.Sun;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReaderTimeAccess set ");
			strSql.Append("ReaderTimeAccessName=@ReaderTimeAccessName,");
			strSql.Append("Mon=@Mon,");
			strSql.Append("Tue=@Tue,");
			strSql.Append("Wed=@Wed,");
			strSql.Append("Thu=@Thu,");
			strSql.Append("Fri=@Fri,");
			strSql.Append("Sat=@Sat,");
			strSql.Append("Sun=@Sun");
			strSql.Append(" where ReaderTimeAccessID=@ReaderTimeAccessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeAccessName", SqlDbType.NVarChar,50),
					new SqlParameter("@Mon", SqlDbType.Int,4),
					new SqlParameter("@Tue", SqlDbType.Int,4),
					new SqlParameter("@Wed", SqlDbType.Int,4),
					new SqlParameter("@Thu", SqlDbType.Int,4),
					new SqlParameter("@Fri", SqlDbType.Int,4),
					new SqlParameter("@Sat", SqlDbType.Int,4),
					new SqlParameter("@Sun", SqlDbType.Int,4),
					new SqlParameter("@ReaderTimeAccessID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReaderTimeAccessName;
			parameters[1].Value = model.Mon;
			parameters[2].Value = model.Tue;
			parameters[3].Value = model.Wed;
			parameters[4].Value = model.Thu;
			parameters[5].Value = model.Fri;
			parameters[6].Value = model.Sat;
			parameters[7].Value = model.Sun;
			parameters[8].Value = model.ReaderTimeAccessID;

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
		public bool Delete(int ReaderTimeAccessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderTimeAccess ");
			strSql.Append(" where ReaderTimeAccessID=@ReaderTimeAccessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeAccessID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeAccessID;

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
		public bool DeleteList(string ReaderTimeAccessIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderTimeAccess ");
			strSql.Append(" where ReaderTimeAccessID in ("+ReaderTimeAccessIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess GetModel(int ReaderTimeAccessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReaderTimeAccessID,ReaderTimeAccessName,Mon,Tue,Wed,Thu,Fri,Sat,Sun from ReaderTimeAccess ");
			strSql.Append(" where ReaderTimeAccessID=@ReaderTimeAccessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderTimeAccessID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderTimeAccessID;

			KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess model=new KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess();
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
		public KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess model=new KryptonAccessController.AccessDataBase.Model.ReaderTimeAccess();
			if (row != null)
			{
				if(row["ReaderTimeAccessID"]!=null && row["ReaderTimeAccessID"].ToString()!="")
				{
					model.ReaderTimeAccessID=int.Parse(row["ReaderTimeAccessID"].ToString());
				}
				if(row["ReaderTimeAccessName"]!=null)
				{
					model.ReaderTimeAccessName=row["ReaderTimeAccessName"].ToString();
				}
				if(row["Mon"]!=null && row["Mon"].ToString()!="")
				{
					model.Mon=int.Parse(row["Mon"].ToString());
				}
				if(row["Tue"]!=null && row["Tue"].ToString()!="")
				{
					model.Tue=int.Parse(row["Tue"].ToString());
				}
				if(row["Wed"]!=null && row["Wed"].ToString()!="")
				{
					model.Wed=int.Parse(row["Wed"].ToString());
				}
				if(row["Thu"]!=null && row["Thu"].ToString()!="")
				{
					model.Thu=int.Parse(row["Thu"].ToString());
				}
				if(row["Fri"]!=null && row["Fri"].ToString()!="")
				{
					model.Fri=int.Parse(row["Fri"].ToString());
				}
				if(row["Sat"]!=null && row["Sat"].ToString()!="")
				{
					model.Sat=int.Parse(row["Sat"].ToString());
				}
				if(row["Sun"]!=null && row["Sun"].ToString()!="")
				{
					model.Sun=int.Parse(row["Sun"].ToString());
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
			strSql.Append("select ReaderTimeAccessID,ReaderTimeAccessName,Mon,Tue,Wed,Thu,Fri,Sat,Sun ");
			strSql.Append(" FROM ReaderTimeAccess ");
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
			strSql.Append(" ReaderTimeAccessID,ReaderTimeAccessName,Mon,Tue,Wed,Thu,Fri,Sat,Sun ");
			strSql.Append(" FROM ReaderTimeAccess ");
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
			strSql.Append("select count(1) FROM ReaderTimeAccess ");
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
				strSql.Append("order by T.ReaderTimeAccessID desc");
			}
			strSql.Append(")AS Row, T.*  from ReaderTimeAccess T ");
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
			parameters[0].Value = "ReaderTimeAccess";
			parameters[1].Value = "ReaderTimeAccessID";
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

