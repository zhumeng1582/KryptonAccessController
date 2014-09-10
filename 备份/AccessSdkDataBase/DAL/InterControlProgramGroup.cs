/**  版本信息模板在安装目录下，可自行修改。
* InterControlProgramGroup.cs
*
* 功 能： N/A
* 类 名： InterControlProgramGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:16   N/A    初版
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
	/// 数据访问类:InterControlProgramGroup
	/// </summary>
	public partial class InterControlProgramGroup
	{
		public InterControlProgramGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ICPGroupID", "InterControlProgramGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ICPGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InterControlProgramGroup");
			strSql.Append(" where ICPGroupID=@ICPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = ICPGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InterControlProgramGroup(");
			strSql.Append("ICPGroupID,ICPGroupName,ICPID1,ICPID2,ICPID3,ICPID4,ICPID5,ICPID6,ICPID7,ICPID8,ICPID9,ICPID10,ICPID11,ICPID12,ICPID13,ICPID14,ICPID15,ICPID16,NextICPGroupID)");
			strSql.Append(" values (");
			strSql.Append("@ICPGroupID,@ICPGroupName,@ICPID1,@ICPID2,@ICPID3,@ICPID4,@ICPID5,@ICPID6,@ICPID7,@ICPID8,@ICPID9,@ICPID10,@ICPID11,@ICPID12,@ICPID13,@ICPID14,@ICPID15,@ICPID16,@NextICPGroupID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4),
					new SqlParameter("@ICPGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@ICPID1", SqlDbType.Int,4),
					new SqlParameter("@ICPID2", SqlDbType.Int,4),
					new SqlParameter("@ICPID3", SqlDbType.Int,4),
					new SqlParameter("@ICPID4", SqlDbType.Int,4),
					new SqlParameter("@ICPID5", SqlDbType.Int,4),
					new SqlParameter("@ICPID6", SqlDbType.Int,4),
					new SqlParameter("@ICPID7", SqlDbType.Int,4),
					new SqlParameter("@ICPID8", SqlDbType.Int,4),
					new SqlParameter("@ICPID9", SqlDbType.Int,4),
					new SqlParameter("@ICPID10", SqlDbType.Int,4),
					new SqlParameter("@ICPID11", SqlDbType.Int,4),
					new SqlParameter("@ICPID12", SqlDbType.Int,4),
					new SqlParameter("@ICPID13", SqlDbType.Int,4),
					new SqlParameter("@ICPID14", SqlDbType.Int,4),
					new SqlParameter("@ICPID15", SqlDbType.Int,4),
					new SqlParameter("@ICPID16", SqlDbType.Int,4),
					new SqlParameter("@NextICPGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.ICPGroupID;
			parameters[1].Value = model.ICPGroupName;
			parameters[2].Value = model.ICPID1;
			parameters[3].Value = model.ICPID2;
			parameters[4].Value = model.ICPID3;
			parameters[5].Value = model.ICPID4;
			parameters[6].Value = model.ICPID5;
			parameters[7].Value = model.ICPID6;
			parameters[8].Value = model.ICPID7;
			parameters[9].Value = model.ICPID8;
			parameters[10].Value = model.ICPID9;
			parameters[11].Value = model.ICPID10;
			parameters[12].Value = model.ICPID11;
			parameters[13].Value = model.ICPID12;
			parameters[14].Value = model.ICPID13;
			parameters[15].Value = model.ICPID14;
			parameters[16].Value = model.ICPID15;
			parameters[17].Value = model.ICPID16;
			parameters[18].Value = model.NextICPGroupID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InterControlProgramGroup set ");
			strSql.Append("ICPGroupName=@ICPGroupName,");
			strSql.Append("ICPID1=@ICPID1,");
			strSql.Append("ICPID2=@ICPID2,");
			strSql.Append("ICPID3=@ICPID3,");
			strSql.Append("ICPID4=@ICPID4,");
			strSql.Append("ICPID5=@ICPID5,");
			strSql.Append("ICPID6=@ICPID6,");
			strSql.Append("ICPID7=@ICPID7,");
			strSql.Append("ICPID8=@ICPID8,");
			strSql.Append("ICPID9=@ICPID9,");
			strSql.Append("ICPID10=@ICPID10,");
			strSql.Append("ICPID11=@ICPID11,");
			strSql.Append("ICPID12=@ICPID12,");
			strSql.Append("ICPID13=@ICPID13,");
			strSql.Append("ICPID14=@ICPID14,");
			strSql.Append("ICPID15=@ICPID15,");
			strSql.Append("ICPID16=@ICPID16,");
			strSql.Append("NextICPGroupID=@NextICPGroupID");
			strSql.Append(" where ICPGroupID=@ICPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ICPGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@ICPID1", SqlDbType.Int,4),
					new SqlParameter("@ICPID2", SqlDbType.Int,4),
					new SqlParameter("@ICPID3", SqlDbType.Int,4),
					new SqlParameter("@ICPID4", SqlDbType.Int,4),
					new SqlParameter("@ICPID5", SqlDbType.Int,4),
					new SqlParameter("@ICPID6", SqlDbType.Int,4),
					new SqlParameter("@ICPID7", SqlDbType.Int,4),
					new SqlParameter("@ICPID8", SqlDbType.Int,4),
					new SqlParameter("@ICPID9", SqlDbType.Int,4),
					new SqlParameter("@ICPID10", SqlDbType.Int,4),
					new SqlParameter("@ICPID11", SqlDbType.Int,4),
					new SqlParameter("@ICPID12", SqlDbType.Int,4),
					new SqlParameter("@ICPID13", SqlDbType.Int,4),
					new SqlParameter("@ICPID14", SqlDbType.Int,4),
					new SqlParameter("@ICPID15", SqlDbType.Int,4),
					new SqlParameter("@ICPID16", SqlDbType.Int,4),
					new SqlParameter("@NextICPGroupID", SqlDbType.Int,4),
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.ICPGroupName;
			parameters[1].Value = model.ICPID1;
			parameters[2].Value = model.ICPID2;
			parameters[3].Value = model.ICPID3;
			parameters[4].Value = model.ICPID4;
			parameters[5].Value = model.ICPID5;
			parameters[6].Value = model.ICPID6;
			parameters[7].Value = model.ICPID7;
			parameters[8].Value = model.ICPID8;
			parameters[9].Value = model.ICPID9;
			parameters[10].Value = model.ICPID10;
			parameters[11].Value = model.ICPID11;
			parameters[12].Value = model.ICPID12;
			parameters[13].Value = model.ICPID13;
			parameters[14].Value = model.ICPID14;
			parameters[15].Value = model.ICPID15;
			parameters[16].Value = model.ICPID16;
			parameters[17].Value = model.NextICPGroupID;
			parameters[18].Value = model.ICPGroupID;

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
		public bool Delete(int ICPGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InterControlProgramGroup ");
			strSql.Append(" where ICPGroupID=@ICPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = ICPGroupID;

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
		public bool DeleteList(string ICPGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InterControlProgramGroup ");
			strSql.Append(" where ICPGroupID in ("+ICPGroupIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup GetModel(int ICPGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ICPGroupID,ICPGroupName,ICPID1,ICPID2,ICPID3,ICPID4,ICPID5,ICPID6,ICPID7,ICPID8,ICPID9,ICPID10,ICPID11,ICPID12,ICPID13,ICPID14,ICPID15,ICPID16,NextICPGroupID from InterControlProgramGroup ");
			strSql.Append(" where ICPGroupID=@ICPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = ICPGroupID;

			KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup model=new KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup();
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
		public KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup model=new KryptonAccessController.AccessSdkDataBase.Model.InterControlProgramGroup();
			if (row != null)
			{
				if(row["ICPGroupID"]!=null && row["ICPGroupID"].ToString()!="")
				{
					model.ICPGroupID=int.Parse(row["ICPGroupID"].ToString());
				}
				if(row["ICPGroupName"]!=null)
				{
					model.ICPGroupName=row["ICPGroupName"].ToString();
				}
				if(row["ICPID1"]!=null && row["ICPID1"].ToString()!="")
				{
					model.ICPID1=int.Parse(row["ICPID1"].ToString());
				}
				if(row["ICPID2"]!=null && row["ICPID2"].ToString()!="")
				{
					model.ICPID2=int.Parse(row["ICPID2"].ToString());
				}
				if(row["ICPID3"]!=null && row["ICPID3"].ToString()!="")
				{
					model.ICPID3=int.Parse(row["ICPID3"].ToString());
				}
				if(row["ICPID4"]!=null && row["ICPID4"].ToString()!="")
				{
					model.ICPID4=int.Parse(row["ICPID4"].ToString());
				}
				if(row["ICPID5"]!=null && row["ICPID5"].ToString()!="")
				{
					model.ICPID5=int.Parse(row["ICPID5"].ToString());
				}
				if(row["ICPID6"]!=null && row["ICPID6"].ToString()!="")
				{
					model.ICPID6=int.Parse(row["ICPID6"].ToString());
				}
				if(row["ICPID7"]!=null && row["ICPID7"].ToString()!="")
				{
					model.ICPID7=int.Parse(row["ICPID7"].ToString());
				}
				if(row["ICPID8"]!=null && row["ICPID8"].ToString()!="")
				{
					model.ICPID8=int.Parse(row["ICPID8"].ToString());
				}
				if(row["ICPID9"]!=null && row["ICPID9"].ToString()!="")
				{
					model.ICPID9=int.Parse(row["ICPID9"].ToString());
				}
				if(row["ICPID10"]!=null && row["ICPID10"].ToString()!="")
				{
					model.ICPID10=int.Parse(row["ICPID10"].ToString());
				}
				if(row["ICPID11"]!=null && row["ICPID11"].ToString()!="")
				{
					model.ICPID11=int.Parse(row["ICPID11"].ToString());
				}
				if(row["ICPID12"]!=null && row["ICPID12"].ToString()!="")
				{
					model.ICPID12=int.Parse(row["ICPID12"].ToString());
				}
				if(row["ICPID13"]!=null && row["ICPID13"].ToString()!="")
				{
					model.ICPID13=int.Parse(row["ICPID13"].ToString());
				}
				if(row["ICPID14"]!=null && row["ICPID14"].ToString()!="")
				{
					model.ICPID14=int.Parse(row["ICPID14"].ToString());
				}
				if(row["ICPID15"]!=null && row["ICPID15"].ToString()!="")
				{
					model.ICPID15=int.Parse(row["ICPID15"].ToString());
				}
				if(row["ICPID16"]!=null && row["ICPID16"].ToString()!="")
				{
					model.ICPID16=int.Parse(row["ICPID16"].ToString());
				}
				if(row["NextICPGroupID"]!=null && row["NextICPGroupID"].ToString()!="")
				{
					model.NextICPGroupID=int.Parse(row["NextICPGroupID"].ToString());
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
			strSql.Append("select ICPGroupID,ICPGroupName,ICPID1,ICPID2,ICPID3,ICPID4,ICPID5,ICPID6,ICPID7,ICPID8,ICPID9,ICPID10,ICPID11,ICPID12,ICPID13,ICPID14,ICPID15,ICPID16,NextICPGroupID ");
			strSql.Append(" FROM InterControlProgramGroup ");
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
			strSql.Append(" ICPGroupID,ICPGroupName,ICPID1,ICPID2,ICPID3,ICPID4,ICPID5,ICPID6,ICPID7,ICPID8,ICPID9,ICPID10,ICPID11,ICPID12,ICPID13,ICPID14,ICPID15,ICPID16,NextICPGroupID ");
			strSql.Append(" FROM InterControlProgramGroup ");
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
			strSql.Append("select count(1) FROM InterControlProgramGroup ");
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
				strSql.Append("order by T.ICPGroupID desc");
			}
			strSql.Append(")AS Row, T.*  from InterControlProgramGroup T ");
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
			parameters[0].Value = "InterControlProgramGroup";
			parameters[1].Value = "ICPGroupID";
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

