/**  版本信息模板在安装目录下，可自行修改。
* StandardOperateProcedureGroup.cs
*
* 功 能： N/A
* 类 名： StandardOperateProcedureGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:22   N/A    初版
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
	/// 数据访问类:StandardOperateProcedureGroup
	/// </summary>
	public partial class StandardOperateProcedureGroup
	{
		public StandardOperateProcedureGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SOPGroupID", "StandardOperateProcedureGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SOPGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StandardOperateProcedureGroup");
			strSql.Append(" where SOPGroupID=@SOPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SOPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = SOPGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StandardOperateProcedureGroup(");
			strSql.Append("SOPGroupID,SOPGroupName,SOPID1,SOPID2,SOPID3,SOPID4,SOPID5,SOPID6,SOPID7,SOPID8,SOPID9,SOPID10,SOPID11,SOPID12,SOPID13,SOPID14,SOPID15,SOPID16,NextSOPGroupID)");
			strSql.Append(" values (");
			strSql.Append("@SOPGroupID,@SOPGroupName,@SOPID1,@SOPID2,@SOPID3,@SOPID4,@SOPID5,@SOPID6,@SOPID7,@SOPID8,@SOPID9,@SOPID10,@SOPID11,@SOPID12,@SOPID13,@SOPID14,@SOPID15,@SOPID16,@NextSOPGroupID)");
			SqlParameter[] parameters = {
					new SqlParameter("@SOPGroupID", SqlDbType.Int,4),
					new SqlParameter("@SOPGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@SOPID1", SqlDbType.Int,4),
					new SqlParameter("@SOPID2", SqlDbType.Int,4),
					new SqlParameter("@SOPID3", SqlDbType.Int,4),
					new SqlParameter("@SOPID4", SqlDbType.Int,4),
					new SqlParameter("@SOPID5", SqlDbType.Int,4),
					new SqlParameter("@SOPID6", SqlDbType.Int,4),
					new SqlParameter("@SOPID7", SqlDbType.Int,4),
					new SqlParameter("@SOPID8", SqlDbType.Int,4),
					new SqlParameter("@SOPID9", SqlDbType.Int,4),
					new SqlParameter("@SOPID10", SqlDbType.Int,4),
					new SqlParameter("@SOPID11", SqlDbType.Int,4),
					new SqlParameter("@SOPID12", SqlDbType.Int,4),
					new SqlParameter("@SOPID13", SqlDbType.Int,4),
					new SqlParameter("@SOPID14", SqlDbType.Int,4),
					new SqlParameter("@SOPID15", SqlDbType.Int,4),
					new SqlParameter("@SOPID16", SqlDbType.Int,4),
					new SqlParameter("@NextSOPGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.SOPGroupID;
			parameters[1].Value = model.SOPGroupName;
			parameters[2].Value = model.SOPID1;
			parameters[3].Value = model.SOPID2;
			parameters[4].Value = model.SOPID3;
			parameters[5].Value = model.SOPID4;
			parameters[6].Value = model.SOPID5;
			parameters[7].Value = model.SOPID6;
			parameters[8].Value = model.SOPID7;
			parameters[9].Value = model.SOPID8;
			parameters[10].Value = model.SOPID9;
			parameters[11].Value = model.SOPID10;
			parameters[12].Value = model.SOPID11;
			parameters[13].Value = model.SOPID12;
			parameters[14].Value = model.SOPID13;
			parameters[15].Value = model.SOPID14;
			parameters[16].Value = model.SOPID15;
			parameters[17].Value = model.SOPID16;
			parameters[18].Value = model.NextSOPGroupID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StandardOperateProcedureGroup set ");
			strSql.Append("SOPGroupName=@SOPGroupName,");
			strSql.Append("SOPID1=@SOPID1,");
			strSql.Append("SOPID2=@SOPID2,");
			strSql.Append("SOPID3=@SOPID3,");
			strSql.Append("SOPID4=@SOPID4,");
			strSql.Append("SOPID5=@SOPID5,");
			strSql.Append("SOPID6=@SOPID6,");
			strSql.Append("SOPID7=@SOPID7,");
			strSql.Append("SOPID8=@SOPID8,");
			strSql.Append("SOPID9=@SOPID9,");
			strSql.Append("SOPID10=@SOPID10,");
			strSql.Append("SOPID11=@SOPID11,");
			strSql.Append("SOPID12=@SOPID12,");
			strSql.Append("SOPID13=@SOPID13,");
			strSql.Append("SOPID14=@SOPID14,");
			strSql.Append("SOPID15=@SOPID15,");
			strSql.Append("SOPID16=@SOPID16,");
			strSql.Append("NextSOPGroupID=@NextSOPGroupID");
			strSql.Append(" where SOPGroupID=@SOPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SOPGroupName", SqlDbType.NVarChar,50),
					new SqlParameter("@SOPID1", SqlDbType.Int,4),
					new SqlParameter("@SOPID2", SqlDbType.Int,4),
					new SqlParameter("@SOPID3", SqlDbType.Int,4),
					new SqlParameter("@SOPID4", SqlDbType.Int,4),
					new SqlParameter("@SOPID5", SqlDbType.Int,4),
					new SqlParameter("@SOPID6", SqlDbType.Int,4),
					new SqlParameter("@SOPID7", SqlDbType.Int,4),
					new SqlParameter("@SOPID8", SqlDbType.Int,4),
					new SqlParameter("@SOPID9", SqlDbType.Int,4),
					new SqlParameter("@SOPID10", SqlDbType.Int,4),
					new SqlParameter("@SOPID11", SqlDbType.Int,4),
					new SqlParameter("@SOPID12", SqlDbType.Int,4),
					new SqlParameter("@SOPID13", SqlDbType.Int,4),
					new SqlParameter("@SOPID14", SqlDbType.Int,4),
					new SqlParameter("@SOPID15", SqlDbType.Int,4),
					new SqlParameter("@SOPID16", SqlDbType.Int,4),
					new SqlParameter("@NextSOPGroupID", SqlDbType.Int,4),
					new SqlParameter("@SOPGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.SOPGroupName;
			parameters[1].Value = model.SOPID1;
			parameters[2].Value = model.SOPID2;
			parameters[3].Value = model.SOPID3;
			parameters[4].Value = model.SOPID4;
			parameters[5].Value = model.SOPID5;
			parameters[6].Value = model.SOPID6;
			parameters[7].Value = model.SOPID7;
			parameters[8].Value = model.SOPID8;
			parameters[9].Value = model.SOPID9;
			parameters[10].Value = model.SOPID10;
			parameters[11].Value = model.SOPID11;
			parameters[12].Value = model.SOPID12;
			parameters[13].Value = model.SOPID13;
			parameters[14].Value = model.SOPID14;
			parameters[15].Value = model.SOPID15;
			parameters[16].Value = model.SOPID16;
			parameters[17].Value = model.NextSOPGroupID;
			parameters[18].Value = model.SOPGroupID;

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
		public bool Delete(int SOPGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StandardOperateProcedureGroup ");
			strSql.Append(" where SOPGroupID=@SOPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SOPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = SOPGroupID;

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
		public bool DeleteList(string SOPGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StandardOperateProcedureGroup ");
			strSql.Append(" where SOPGroupID in ("+SOPGroupIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup GetModel(int SOPGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SOPGroupID,SOPGroupName,SOPID1,SOPID2,SOPID3,SOPID4,SOPID5,SOPID6,SOPID7,SOPID8,SOPID9,SOPID10,SOPID11,SOPID12,SOPID13,SOPID14,SOPID15,SOPID16,NextSOPGroupID from StandardOperateProcedureGroup ");
			strSql.Append(" where SOPGroupID=@SOPGroupID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SOPGroupID", SqlDbType.Int,4)			};
			parameters[0].Value = SOPGroupID;

			KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup model=new KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup();
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
		public KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup model=new KryptonAccessController.AccessSdkDataBase.Model.StandardOperateProcedureGroup();
			if (row != null)
			{
				if(row["SOPGroupID"]!=null && row["SOPGroupID"].ToString()!="")
				{
					model.SOPGroupID=int.Parse(row["SOPGroupID"].ToString());
				}
				if(row["SOPGroupName"]!=null)
				{
					model.SOPGroupName=row["SOPGroupName"].ToString();
				}
				if(row["SOPID1"]!=null && row["SOPID1"].ToString()!="")
				{
					model.SOPID1=int.Parse(row["SOPID1"].ToString());
				}
				if(row["SOPID2"]!=null && row["SOPID2"].ToString()!="")
				{
					model.SOPID2=int.Parse(row["SOPID2"].ToString());
				}
				if(row["SOPID3"]!=null && row["SOPID3"].ToString()!="")
				{
					model.SOPID3=int.Parse(row["SOPID3"].ToString());
				}
				if(row["SOPID4"]!=null && row["SOPID4"].ToString()!="")
				{
					model.SOPID4=int.Parse(row["SOPID4"].ToString());
				}
				if(row["SOPID5"]!=null && row["SOPID5"].ToString()!="")
				{
					model.SOPID5=int.Parse(row["SOPID5"].ToString());
				}
				if(row["SOPID6"]!=null && row["SOPID6"].ToString()!="")
				{
					model.SOPID6=int.Parse(row["SOPID6"].ToString());
				}
				if(row["SOPID7"]!=null && row["SOPID7"].ToString()!="")
				{
					model.SOPID7=int.Parse(row["SOPID7"].ToString());
				}
				if(row["SOPID8"]!=null && row["SOPID8"].ToString()!="")
				{
					model.SOPID8=int.Parse(row["SOPID8"].ToString());
				}
				if(row["SOPID9"]!=null && row["SOPID9"].ToString()!="")
				{
					model.SOPID9=int.Parse(row["SOPID9"].ToString());
				}
				if(row["SOPID10"]!=null && row["SOPID10"].ToString()!="")
				{
					model.SOPID10=int.Parse(row["SOPID10"].ToString());
				}
				if(row["SOPID11"]!=null && row["SOPID11"].ToString()!="")
				{
					model.SOPID11=int.Parse(row["SOPID11"].ToString());
				}
				if(row["SOPID12"]!=null && row["SOPID12"].ToString()!="")
				{
					model.SOPID12=int.Parse(row["SOPID12"].ToString());
				}
				if(row["SOPID13"]!=null && row["SOPID13"].ToString()!="")
				{
					model.SOPID13=int.Parse(row["SOPID13"].ToString());
				}
				if(row["SOPID14"]!=null && row["SOPID14"].ToString()!="")
				{
					model.SOPID14=int.Parse(row["SOPID14"].ToString());
				}
				if(row["SOPID15"]!=null && row["SOPID15"].ToString()!="")
				{
					model.SOPID15=int.Parse(row["SOPID15"].ToString());
				}
				if(row["SOPID16"]!=null && row["SOPID16"].ToString()!="")
				{
					model.SOPID16=int.Parse(row["SOPID16"].ToString());
				}
				if(row["NextSOPGroupID"]!=null && row["NextSOPGroupID"].ToString()!="")
				{
					model.NextSOPGroupID=int.Parse(row["NextSOPGroupID"].ToString());
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
			strSql.Append("select SOPGroupID,SOPGroupName,SOPID1,SOPID2,SOPID3,SOPID4,SOPID5,SOPID6,SOPID7,SOPID8,SOPID9,SOPID10,SOPID11,SOPID12,SOPID13,SOPID14,SOPID15,SOPID16,NextSOPGroupID ");
			strSql.Append(" FROM StandardOperateProcedureGroup ");
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
			strSql.Append(" SOPGroupID,SOPGroupName,SOPID1,SOPID2,SOPID3,SOPID4,SOPID5,SOPID6,SOPID7,SOPID8,SOPID9,SOPID10,SOPID11,SOPID12,SOPID13,SOPID14,SOPID15,SOPID16,NextSOPGroupID ");
			strSql.Append(" FROM StandardOperateProcedureGroup ");
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
			strSql.Append("select count(1) FROM StandardOperateProcedureGroup ");
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
				strSql.Append("order by T.SOPGroupID desc");
			}
			strSql.Append(")AS Row, T.*  from StandardOperateProcedureGroup T ");
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
			parameters[0].Value = "StandardOperateProcedureGroup";
			parameters[1].Value = "SOPGroupID";
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

