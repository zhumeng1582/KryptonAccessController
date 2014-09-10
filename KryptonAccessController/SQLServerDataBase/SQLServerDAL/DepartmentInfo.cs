/**  版本信息模板在安装目录下，可自行修改。
* DepartmentInfo.cs
*
* 功 能： N/A
* 类 名： DepartmentInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:21   N/A    初版
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
	/// 数据访问类:DepartmentInfo
	/// </summary>
	public partial class DepartmentInfo:IDepartmentInfo
	{
		public DepartmentInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DepartmentID", "DepartmentInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DepartmentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DepartmentInfo");
			strSql.Append(" where DepartmentID=@DepartmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)			};
			parameters[0].Value = DepartmentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.DepartmentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DepartmentInfo(");
			strSql.Append("DepartmentID,DepartmentName,DepartmentDes,CompanyName,DepartmentTel1,DepartmentTel2)");
			strSql.Append(" values (");
			strSql.Append("@DepartmentID,@DepartmentName,@DepartmentDes,@CompanyName,@DepartmentTel1,@DepartmentTel2)");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentDes", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentTel1", SqlDbType.NVarChar,15),
					new SqlParameter("@DepartmentTel2", SqlDbType.NVarChar,15)};
			parameters[0].Value = model.DepartmentID;
			parameters[1].Value = model.DepartmentName;
			parameters[2].Value = model.DepartmentDes;
			parameters[3].Value = model.CompanyName;
			parameters[4].Value = model.DepartmentTel1;
			parameters[5].Value = model.DepartmentTel2;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.DepartmentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DepartmentInfo set ");
			strSql.Append("DepartmentName=@DepartmentName,");
			strSql.Append("DepartmentDes=@DepartmentDes,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("DepartmentTel1=@DepartmentTel1,");
			strSql.Append("DepartmentTel2=@DepartmentTel2");
			strSql.Append(" where DepartmentID=@DepartmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentDes", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentTel1", SqlDbType.NVarChar,15),
					new SqlParameter("@DepartmentTel2", SqlDbType.NVarChar,15),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)};
			parameters[0].Value = model.DepartmentName;
			parameters[1].Value = model.DepartmentDes;
			parameters[2].Value = model.CompanyName;
			parameters[3].Value = model.DepartmentTel1;
			parameters[4].Value = model.DepartmentTel2;
			parameters[5].Value = model.DepartmentID;

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
		public bool Delete(int DepartmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DepartmentInfo ");
			strSql.Append(" where DepartmentID=@DepartmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)			};
			parameters[0].Value = DepartmentID;

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
		public bool DeleteList(string DepartmentIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DepartmentInfo ");
			strSql.Append(" where DepartmentID in ("+DepartmentIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.DepartmentInfo GetModel(int DepartmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DepartmentID,DepartmentName,DepartmentDes,CompanyName,DepartmentTel1,DepartmentTel2 from DepartmentInfo ");
			strSql.Append(" where DepartmentID=@DepartmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)			};
			parameters[0].Value = DepartmentID;

			KryptonAccessController.AccessDataBase.Model.DepartmentInfo model=new KryptonAccessController.AccessDataBase.Model.DepartmentInfo();
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
		public KryptonAccessController.AccessDataBase.Model.DepartmentInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.DepartmentInfo model=new KryptonAccessController.AccessDataBase.Model.DepartmentInfo();
			if (row != null)
			{
				if(row["DepartmentID"]!=null && row["DepartmentID"].ToString()!="")
				{
					model.DepartmentID=int.Parse(row["DepartmentID"].ToString());
				}
				if(row["DepartmentName"]!=null)
				{
					model.DepartmentName=row["DepartmentName"].ToString();
				}
				if(row["DepartmentDes"]!=null)
				{
					model.DepartmentDes=row["DepartmentDes"].ToString();
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["DepartmentTel1"]!=null)
				{
					model.DepartmentTel1=row["DepartmentTel1"].ToString();
				}
				if(row["DepartmentTel2"]!=null)
				{
					model.DepartmentTel2=row["DepartmentTel2"].ToString();
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
			strSql.Append("select DepartmentID,DepartmentName,DepartmentDes,CompanyName,DepartmentTel1,DepartmentTel2 ");
			strSql.Append(" FROM DepartmentInfo ");
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
			strSql.Append(" DepartmentID,DepartmentName,DepartmentDes,CompanyName,DepartmentTel1,DepartmentTel2 ");
			strSql.Append(" FROM DepartmentInfo ");
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
			strSql.Append("select count(1) FROM DepartmentInfo ");
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
				strSql.Append("order by T.DepartmentID desc");
			}
			strSql.Append(")AS Row, T.*  from DepartmentInfo T ");
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
			parameters[0].Value = "DepartmentInfo";
			parameters[1].Value = "DepartmentID";
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

