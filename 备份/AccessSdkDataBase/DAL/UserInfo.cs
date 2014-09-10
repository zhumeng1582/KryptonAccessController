/**  版本信息模板在安装目录下，可自行修改。
* UserInfo.cs
*
* 功 能： N/A
* 类 名： UserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:26   N/A    初版
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
	/// 数据访问类:UserInfo
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "UserInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("UserID,UserName,Photograph,UserGroupID1,UserGroupID2,UserGroupID3,UserGroupID4,FingerPosition0,FingerPrint0,FingerPosition1,FingerPrint1,SercurityAccessLevel,PrimaryCardID,SecondCardID)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@UserName,@Photograph,@UserGroupID1,@UserGroupID2,@UserGroupID3,@UserGroupID4,@FingerPosition0,@FingerPrint0,@FingerPosition1,@FingerPrint1,@SercurityAccessLevel,@PrimaryCardID,@SecondCardID)");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Photograph", SqlDbType.Image),
					new SqlParameter("@UserGroupID1", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID2", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID3", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID4", SqlDbType.Int,4),
					new SqlParameter("@FingerPosition0", SqlDbType.Int,4),
					new SqlParameter("@FingerPrint0", SqlDbType.Image),
					new SqlParameter("@FingerPosition1", SqlDbType.Int,4),
					new SqlParameter("@FingerPrint1", SqlDbType.Image),
					new SqlParameter("@SercurityAccessLevel", SqlDbType.Int,4),
					new SqlParameter("@PrimaryCardID", SqlDbType.NVarChar,10),
					new SqlParameter("@SecondCardID", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Photograph;
			parameters[3].Value = model.UserGroupID1;
			parameters[4].Value = model.UserGroupID2;
			parameters[5].Value = model.UserGroupID3;
			parameters[6].Value = model.UserGroupID4;
			parameters[7].Value = model.FingerPosition0;
			parameters[8].Value = model.FingerPrint0;
			parameters[9].Value = model.FingerPosition1;
			parameters[10].Value = model.FingerPrint1;
			parameters[11].Value = model.SercurityAccessLevel;
			parameters[12].Value = model.PrimaryCardID;
			parameters[13].Value = model.SecondCardID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Photograph=@Photograph,");
			strSql.Append("UserGroupID1=@UserGroupID1,");
			strSql.Append("UserGroupID2=@UserGroupID2,");
			strSql.Append("UserGroupID3=@UserGroupID3,");
			strSql.Append("UserGroupID4=@UserGroupID4,");
			strSql.Append("FingerPosition0=@FingerPosition0,");
			strSql.Append("FingerPrint0=@FingerPrint0,");
			strSql.Append("FingerPosition1=@FingerPosition1,");
			strSql.Append("FingerPrint1=@FingerPrint1,");
			strSql.Append("SercurityAccessLevel=@SercurityAccessLevel,");
			strSql.Append("PrimaryCardID=@PrimaryCardID,");
			strSql.Append("SecondCardID=@SecondCardID");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Photograph", SqlDbType.Image),
					new SqlParameter("@UserGroupID1", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID2", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID3", SqlDbType.Int,4),
					new SqlParameter("@UserGroupID4", SqlDbType.Int,4),
					new SqlParameter("@FingerPosition0", SqlDbType.Int,4),
					new SqlParameter("@FingerPrint0", SqlDbType.Image),
					new SqlParameter("@FingerPosition1", SqlDbType.Int,4),
					new SqlParameter("@FingerPrint1", SqlDbType.Image),
					new SqlParameter("@SercurityAccessLevel", SqlDbType.Int,4),
					new SqlParameter("@PrimaryCardID", SqlDbType.NVarChar,10),
					new SqlParameter("@SecondCardID", SqlDbType.NVarChar,10),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Photograph;
			parameters[2].Value = model.UserGroupID1;
			parameters[3].Value = model.UserGroupID2;
			parameters[4].Value = model.UserGroupID3;
			parameters[5].Value = model.UserGroupID4;
			parameters[6].Value = model.FingerPosition0;
			parameters[7].Value = model.FingerPrint0;
			parameters[8].Value = model.FingerPosition1;
			parameters[9].Value = model.FingerPrint1;
			parameters[10].Value = model.SercurityAccessLevel;
			parameters[11].Value = model.PrimaryCardID;
			parameters[12].Value = model.SecondCardID;
			parameters[13].Value = model.UserID;

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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)			};
			parameters[0].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.UserInfo GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,UserName,Photograph,UserGroupID1,UserGroupID2,UserGroupID3,UserGroupID4,FingerPosition0,FingerPrint0,FingerPosition1,FingerPrint1,SercurityAccessLevel,PrimaryCardID,SecondCardID from UserInfo ");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)			};
			parameters[0].Value = UserID;

			KryptonAccessController.AccessSdkDataBase.Model.UserInfo model=new KryptonAccessController.AccessSdkDataBase.Model.UserInfo();
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
		public KryptonAccessController.AccessSdkDataBase.Model.UserInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.UserInfo model=new KryptonAccessController.AccessSdkDataBase.Model.UserInfo();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Photograph"]!=null && row["Photograph"].ToString()!="")
				{
					model.Photograph=(byte[])row["Photograph"];
				}
				if(row["UserGroupID1"]!=null && row["UserGroupID1"].ToString()!="")
				{
					model.UserGroupID1=int.Parse(row["UserGroupID1"].ToString());
				}
				if(row["UserGroupID2"]!=null && row["UserGroupID2"].ToString()!="")
				{
					model.UserGroupID2=int.Parse(row["UserGroupID2"].ToString());
				}
				if(row["UserGroupID3"]!=null && row["UserGroupID3"].ToString()!="")
				{
					model.UserGroupID3=int.Parse(row["UserGroupID3"].ToString());
				}
				if(row["UserGroupID4"]!=null && row["UserGroupID4"].ToString()!="")
				{
					model.UserGroupID4=int.Parse(row["UserGroupID4"].ToString());
				}
				if(row["FingerPosition0"]!=null && row["FingerPosition0"].ToString()!="")
				{
					model.FingerPosition0=int.Parse(row["FingerPosition0"].ToString());
				}
				if(row["FingerPrint0"]!=null && row["FingerPrint0"].ToString()!="")
				{
					model.FingerPrint0=(byte[])row["FingerPrint0"];
				}
				if(row["FingerPosition1"]!=null && row["FingerPosition1"].ToString()!="")
				{
					model.FingerPosition1=int.Parse(row["FingerPosition1"].ToString());
				}
				if(row["FingerPrint1"]!=null && row["FingerPrint1"].ToString()!="")
				{
					model.FingerPrint1=(byte[])row["FingerPrint1"];
				}
				if(row["SercurityAccessLevel"]!=null && row["SercurityAccessLevel"].ToString()!="")
				{
					model.SercurityAccessLevel=int.Parse(row["SercurityAccessLevel"].ToString());
				}
				if(row["PrimaryCardID"]!=null)
				{
					model.PrimaryCardID=row["PrimaryCardID"].ToString();
				}
				if(row["SecondCardID"]!=null)
				{
					model.SecondCardID=row["SecondCardID"].ToString();
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
			strSql.Append("select UserID,UserName,Photograph,UserGroupID1,UserGroupID2,UserGroupID3,UserGroupID4,FingerPosition0,FingerPrint0,FingerPosition1,FingerPrint1,SercurityAccessLevel,PrimaryCardID,SecondCardID ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append(" UserID,UserName,Photograph,UserGroupID1,UserGroupID2,UserGroupID3,UserGroupID4,FingerPosition0,FingerPrint0,FingerPosition1,FingerPrint1,SercurityAccessLevel,PrimaryCardID,SecondCardID ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append("select count(1) FROM UserInfo ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from UserInfo T ");
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
			parameters[0].Value = "UserInfo";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListWithoutPhotograph(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserID,UserName,UserGroupID1,UserGroupID2,UserGroupID3,UserGroupID4,SercurityAccessLevel,PrimaryCardID,SecondCardID ");
            strSql.Append(" FROM UserInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

		#endregion  ExtensionMethod
	}
}

