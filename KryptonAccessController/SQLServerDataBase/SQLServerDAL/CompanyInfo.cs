/**  版本信息模板在安装目录下，可自行修改。
* CompanyInfo.cs
*
* 功 能： N/A
* 类 名： CompanyInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:20   N/A    初版
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
	/// 数据访问类:CompanyInfo
	/// </summary>
	public partial class CompanyInfo:ICompanyInfo
	{
		public CompanyInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CompanyID", "CompanyInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CompanyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CompanyInfo");
			strSql.Append(" where CompanyID=@CompanyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)			};
			parameters[0].Value = CompanyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.CompanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CompanyInfo(");
			strSql.Append("CompanyID,CompanyName,CompanyDes,CompanyAddress,CompanyTel1,CompanyTel2)");
			strSql.Append(" values (");
			strSql.Append("@CompanyID,@CompanyName,@CompanyDes,@CompanyAddress,@CompanyTel1,@CompanyTel2)");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyDes", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyTel1", SqlDbType.NVarChar,15),
					new SqlParameter("@CompanyTel2", SqlDbType.NVarChar,15)};
			parameters[0].Value = model.CompanyID;
			parameters[1].Value = model.CompanyName;
			parameters[2].Value = model.CompanyDes;
			parameters[3].Value = model.CompanyAddress;
			parameters[4].Value = model.CompanyTel1;
			parameters[5].Value = model.CompanyTel2;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.CompanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CompanyInfo set ");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyDes=@CompanyDes,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("CompanyTel1=@CompanyTel1,");
			strSql.Append("CompanyTel2=@CompanyTel2");
			strSql.Append(" where CompanyID=@CompanyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyDes", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyTel1", SqlDbType.NVarChar,15),
					new SqlParameter("@CompanyTel2", SqlDbType.NVarChar,15),
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = model.CompanyName;
			parameters[1].Value = model.CompanyDes;
			parameters[2].Value = model.CompanyAddress;
			parameters[3].Value = model.CompanyTel1;
			parameters[4].Value = model.CompanyTel2;
			parameters[5].Value = model.CompanyID;

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
		public bool Delete(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CompanyInfo ");
			strSql.Append(" where CompanyID=@CompanyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)			};
			parameters[0].Value = CompanyID;

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
		public bool DeleteList(string CompanyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CompanyInfo ");
			strSql.Append(" where CompanyID in ("+CompanyIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.CompanyInfo GetModel(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyID,CompanyName,CompanyDes,CompanyAddress,CompanyTel1,CompanyTel2 from CompanyInfo ");
			strSql.Append(" where CompanyID=@CompanyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)			};
			parameters[0].Value = CompanyID;

			KryptonAccessController.AccessDataBase.Model.CompanyInfo model=new KryptonAccessController.AccessDataBase.Model.CompanyInfo();
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
		public KryptonAccessController.AccessDataBase.Model.CompanyInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.CompanyInfo model=new KryptonAccessController.AccessDataBase.Model.CompanyInfo();
			if (row != null)
			{
				if(row["CompanyID"]!=null && row["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(row["CompanyID"].ToString());
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["CompanyDes"]!=null)
				{
					model.CompanyDes=row["CompanyDes"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["CompanyTel1"]!=null)
				{
					model.CompanyTel1=row["CompanyTel1"].ToString();
				}
				if(row["CompanyTel2"]!=null)
				{
					model.CompanyTel2=row["CompanyTel2"].ToString();
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
			strSql.Append("select CompanyID,CompanyName,CompanyDes,CompanyAddress,CompanyTel1,CompanyTel2 ");
			strSql.Append(" FROM CompanyInfo ");
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
			strSql.Append(" CompanyID,CompanyName,CompanyDes,CompanyAddress,CompanyTel1,CompanyTel2 ");
			strSql.Append(" FROM CompanyInfo ");
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
			strSql.Append("select count(1) FROM CompanyInfo ");
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
				strSql.Append("order by T.CompanyID desc");
			}
			strSql.Append(")AS Row, T.*  from CompanyInfo T ");
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
			parameters[0].Value = "CompanyInfo";
			parameters[1].Value = "CompanyID";
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

