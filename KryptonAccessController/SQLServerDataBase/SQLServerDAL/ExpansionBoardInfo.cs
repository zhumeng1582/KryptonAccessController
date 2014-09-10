/**  版本信息模板在安装目录下，可自行修改。
* ExpansionBoardInfo.cs
*
* 功 能： N/A
* 类 名： ExpansionBoardInfo
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
	/// 数据访问类:ExpansionBoardInfo
	/// </summary>
	public partial class ExpansionBoardInfo:IExpansionBoardInfo
	{
		public ExpansionBoardInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ExpansionBoardID", "ExpansionBoardInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ExpansionBoardID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ExpansionBoardInfo");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ExpansionBoardInfo(");
			strSql.Append("ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation)");
			strSql.Append(" values (");
			strSql.Append("@ExpansionBoardID,@ExpansionBoardType,@ExpansionBoardName,@ExpansionBoardAddr,@InputStateType,@ExpansionBoardLocation)");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardType", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardName", SqlDbType.NVarChar,50),
					new SqlParameter("@ExpansionBoardAddr", SqlDbType.Int,4),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardLocation", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ExpansionBoardID;
			parameters[1].Value = model.ExpansionBoardType;
			parameters[2].Value = model.ExpansionBoardName;
			parameters[3].Value = model.ExpansionBoardAddr;
			parameters[4].Value = model.InputStateType;
			parameters[5].Value = model.ExpansionBoardLocation;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ExpansionBoardInfo set ");
			strSql.Append("ExpansionBoardType=@ExpansionBoardType,");
			strSql.Append("ExpansionBoardName=@ExpansionBoardName,");
			strSql.Append("ExpansionBoardAddr=@ExpansionBoardAddr,");
			strSql.Append("InputStateType=@InputStateType,");
			strSql.Append("ExpansionBoardLocation=@ExpansionBoardLocation");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardType", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardName", SqlDbType.NVarChar,50),
					new SqlParameter("@ExpansionBoardAddr", SqlDbType.Int,4),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardLocation", SqlDbType.NVarChar,100),
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)};
			parameters[0].Value = model.ExpansionBoardType;
			parameters[1].Value = model.ExpansionBoardName;
			parameters[2].Value = model.ExpansionBoardAddr;
			parameters[3].Value = model.InputStateType;
			parameters[4].Value = model.ExpansionBoardLocation;
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ExpansionBoardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardID;

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
		public bool DeleteList(string ExpansionBoardIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID in ("+ExpansionBoardIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo GetModel(int ExpansionBoardID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation from ExpansionBoardInfo ");
			strSql.Append(" where ExpansionBoardID=@ExpansionBoardID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)			};
			parameters[0].Value = ExpansionBoardID;

			KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo model=new KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo();
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
		public KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo model=new KryptonAccessController.AccessDataBase.Model.ExpansionBoardInfo();
			if (row != null)
			{
				if(row["ExpansionBoardID"]!=null && row["ExpansionBoardID"].ToString()!="")
				{
					model.ExpansionBoardID=int.Parse(row["ExpansionBoardID"].ToString());
				}
				if(row["ExpansionBoardType"]!=null && row["ExpansionBoardType"].ToString()!="")
				{
					model.ExpansionBoardType=int.Parse(row["ExpansionBoardType"].ToString());
				}
				if(row["ExpansionBoardName"]!=null)
				{
					model.ExpansionBoardName=row["ExpansionBoardName"].ToString();
				}
				if(row["ExpansionBoardAddr"]!=null && row["ExpansionBoardAddr"].ToString()!="")
				{
					model.ExpansionBoardAddr=int.Parse(row["ExpansionBoardAddr"].ToString());
				}
				if(row["InputStateType"]!=null && row["InputStateType"].ToString()!="")
				{
					model.InputStateType=int.Parse(row["InputStateType"].ToString());
				}
				if(row["ExpansionBoardLocation"]!=null)
				{
					model.ExpansionBoardLocation=row["ExpansionBoardLocation"].ToString();
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
			strSql.Append("select ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation ");
			strSql.Append(" FROM ExpansionBoardInfo ");
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
			strSql.Append(" ExpansionBoardID,ExpansionBoardType,ExpansionBoardName,ExpansionBoardAddr,InputStateType,ExpansionBoardLocation ");
			strSql.Append(" FROM ExpansionBoardInfo ");
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
			strSql.Append("select count(1) FROM ExpansionBoardInfo ");
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
				strSql.Append("order by T.ExpansionBoardID desc");
			}
			strSql.Append(")AS Row, T.*  from ExpansionBoardInfo T ");
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
			parameters[0].Value = "ExpansionBoardInfo";
			parameters[1].Value = "ExpansionBoardID";
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

