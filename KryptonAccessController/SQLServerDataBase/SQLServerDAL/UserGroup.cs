/**  版本信息模板在安装目录下，可自行修改。
* UserGroup.cs
*
* 功 能： N/A
* 类 名： UserGroup
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
	/// 数据访问类:UserGroup
	/// </summary>
	public partial class UserGroup:IUserGroup
	{
		public UserGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserGroupID", "UserGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserGroup");
			strSql.Append(" where UserGroupID=@UserGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = UserGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.UserGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserGroup(");
			strSql.Append("UserGroupID,UserGroupName,UserGroupDes)");
			strSql.Append(" values (");
			strSql.Append("@UserGroupID,@UserGroupName,@UserGroupDes)");
			SqlParameter[] parameters = {
					new SqlParameter("@UserGroupID", SqlDbType.Int,4),
					new SqlParameter("@UserGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserGroupDes", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.UserGroupID;
			parameters[1].Value = model.UserGroupName;
			parameters[2].Value = model.UserGroupDes;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.UserGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserGroup set ");
			strSql.Append("UserGroupName=@UserGroupName,");
			strSql.Append("UserGroupDes=@UserGroupDes");
			strSql.Append(" where UserGroupID=@UserGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserGroupDes", SqlDbType.NVarChar,100),
					new SqlParameter("@UserGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserGroupName;
			parameters[1].Value = model.UserGroupDes;
			parameters[2].Value = model.UserGroupID;

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
		public bool Delete(int UserGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserGroup ");
			strSql.Append(" where UserGroupID=@UserGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = UserGroupID;

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
		public bool DeleteList(string UserGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserGroup ");
			strSql.Append(" where UserGroupID in ("+UserGroupIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.UserGroup GetModel(int UserGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserGroupID,UserGroupName,UserGroupDes from UserGroup ");
			strSql.Append(" where UserGroupID=@UserGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = UserGroupID;

			KryptonAccessController.AccessDataBase.Model.UserGroup model=new KryptonAccessController.AccessDataBase.Model.UserGroup();
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
		public KryptonAccessController.AccessDataBase.Model.UserGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.UserGroup model=new KryptonAccessController.AccessDataBase.Model.UserGroup();
			if (row != null)
			{
				if(row["UserGroupID"]!=null && row["UserGroupID"].ToString()!="")
				{
					model.UserGroupID=int.Parse(row["UserGroupID"].ToString());
				}
				if(row["UserGroupName"]!=null)
				{
					model.UserGroupName=row["UserGroupName"].ToString();
				}
				if(row["UserGroupDes"]!=null)
				{
					model.UserGroupDes=row["UserGroupDes"].ToString();
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
			strSql.Append("select UserGroupID,UserGroupName,UserGroupDes ");
			strSql.Append(" FROM UserGroup ");
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
			strSql.Append(" UserGroupID,UserGroupName,UserGroupDes ");
			strSql.Append(" FROM UserGroup ");
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
			strSql.Append("select count(1) FROM UserGroup ");
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
				strSql.Append("order by T.UserGroupID desc");
			}
			strSql.Append(")AS Row, T.*  from UserGroup T ");
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
			parameters[0].Value = "UserGroup";
			parameters[1].Value = "UserGroupID";
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

