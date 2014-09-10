/**  版本信息模板在安装目录下，可自行修改。
* InputInfo.cs
*
* 功 能： N/A
* 类 名： InputInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:15   N/A    初版
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
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.AccessSdkDataBase.DAL
{
	/// <summary>
	/// 数据访问类:InputInfo
	/// </summary>
	public partial class InputInfo
	{
		public InputInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InputID", "InputInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InputID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InputInfo");
			strSql.Append(" where InputID=@InputID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InputID", SqlDbType.Int,4)			};
			parameters[0].Value = InputID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.InputInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InputInfo(");
			strSql.Append("InputID,InputName,InputPointID,InputPointState,ExpansionBoardID)");
			strSql.Append(" values (");
			strSql.Append("@InputID,@InputName,@InputPointID,@InputPointState,@ExpansionBoardID)");
			SqlParameter[] parameters = {
					new SqlParameter("@InputID", SqlDbType.Int,4),
					new SqlParameter("@InputName", SqlDbType.NVarChar,50),
					new SqlParameter("@InputPointID", SqlDbType.Int,4),
					new SqlParameter("@InputPointState", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4)};
			parameters[0].Value = model.InputID;
			parameters[1].Value = model.InputName;
			parameters[2].Value = model.InputPointID;
			parameters[3].Value = model.InputPointState;
			parameters[4].Value = model.ExpansionBoardID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.InputInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InputInfo set ");
			strSql.Append("InputName=@InputName,");
			strSql.Append("InputPointID=@InputPointID,");
			strSql.Append("InputPointState=@InputPointState,");
			strSql.Append("ExpansionBoardID=@ExpansionBoardID");
			strSql.Append(" where InputID=@InputID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InputName", SqlDbType.NVarChar,50),
					new SqlParameter("@InputPointID", SqlDbType.Int,4),
					new SqlParameter("@InputPointState", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardID", SqlDbType.Int,4),
					new SqlParameter("@InputID", SqlDbType.Int,4)};
			parameters[0].Value = model.InputName;
			parameters[1].Value = model.InputPointID;
			parameters[2].Value = model.InputPointState;
			parameters[3].Value = model.ExpansionBoardID;
			parameters[4].Value = model.InputID;

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
		public bool Delete(int InputID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InputInfo ");
			strSql.Append(" where InputID=@InputID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InputID", SqlDbType.Int,4)			};
			parameters[0].Value = InputID;

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
		public bool DeleteList(string InputIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InputInfo ");
			strSql.Append(" where InputID in ("+InputIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.InputInfo GetModel(int InputID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InputID,InputName,InputPointID,InputPointState,ExpansionBoardID from InputInfo ");
			strSql.Append(" where InputID=@InputID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InputID", SqlDbType.Int,4)			};
			parameters[0].Value = InputID;

			KryptonAccessController.AccessSdkDataBase.Model.InputInfo model=new KryptonAccessController.AccessSdkDataBase.Model.InputInfo();
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
		public KryptonAccessController.AccessSdkDataBase.Model.InputInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.InputInfo model=new KryptonAccessController.AccessSdkDataBase.Model.InputInfo();
			if (row != null)
			{
				if(row["InputID"]!=null && row["InputID"].ToString()!="")
				{
					model.InputID=int.Parse(row["InputID"].ToString());
				}
				if(row["InputName"]!=null)
				{
					model.InputName=row["InputName"].ToString();
				}
				if(row["InputPointID"]!=null && row["InputPointID"].ToString()!="")
				{
					model.InputPointID=int.Parse(row["InputPointID"].ToString());
				}
				if(row["InputPointState"]!=null && row["InputPointState"].ToString()!="")
				{
					model.InputPointState=int.Parse(row["InputPointState"].ToString());
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
			strSql.Append("select InputID,InputName,InputPointID,InputPointState,ExpansionBoardID ");
			strSql.Append(" FROM InputInfo ");
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
			strSql.Append(" InputID,InputName,InputPointID,InputPointState,ExpansionBoardID ");
			strSql.Append(" FROM InputInfo ");
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
			strSql.Append("select count(1) FROM InputInfo ");
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
				strSql.Append("order by T.InputID desc");
			}
			strSql.Append(")AS Row, T.*  from InputInfo T ");
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
			parameters[0].Value = "InputInfo";
			parameters[1].Value = "InputID";
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

