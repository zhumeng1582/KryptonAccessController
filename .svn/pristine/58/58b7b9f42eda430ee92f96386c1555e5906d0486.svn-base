/**  版本信息模板在安装目录下，可自行修改。
* TimeInterControlProgramGroup.cs
*
* 功 能： N/A
* 类 名： TimeInterControlProgramGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:23   N/A    初版
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
	/// 数据访问类:TimeInterControlProgramGroup
	/// </summary>
	public partial class TimeInterControlProgramGroup
	{
		public TimeInterControlProgramGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TimeICPGID", "TimeInterControlProgramGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TimeICPGID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TimeInterControlProgramGroup");
			strSql.Append(" where TimeICPGID=@TimeICPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPGID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPGID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TimeInterControlProgramGroup(");
			strSql.Append("TimeICPGID,TimeICPGName,TimeICPGEnable,TimeICPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPGroupID)");
			strSql.Append(" values (");
			strSql.Append("@TimeICPGID,@TimeICPGName,@TimeICPGEnable,@TimeICPGLoop,@MonEnable,@TueEnable,@WedEnable,@ThuEnable,@FriEnable,@SatEnable,@SunEnable,@TimePoint,@ICPGroupID)");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPGID", SqlDbType.Int,4),
					new SqlParameter("@TimeICPGName", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeICPGEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimeICPGLoop", SqlDbType.Bit,1),
					new SqlParameter("@MonEnable", SqlDbType.Bit,1),
					new SqlParameter("@TueEnable", SqlDbType.Bit,1),
					new SqlParameter("@WedEnable", SqlDbType.Bit,1),
					new SqlParameter("@ThuEnable", SqlDbType.Bit,1),
					new SqlParameter("@FriEnable", SqlDbType.Bit,1),
					new SqlParameter("@SatEnable", SqlDbType.Bit,1),
					new SqlParameter("@SunEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.TimeICPGID;
			parameters[1].Value = model.TimeICPGName;
			parameters[2].Value = model.TimeICPGEnable;
			parameters[3].Value = model.TimeICPGLoop;
			parameters[4].Value = model.MonEnable;
			parameters[5].Value = model.TueEnable;
			parameters[6].Value = model.WedEnable;
			parameters[7].Value = model.ThuEnable;
			parameters[8].Value = model.FriEnable;
			parameters[9].Value = model.SatEnable;
			parameters[10].Value = model.SunEnable;
			parameters[11].Value = model.TimePoint;
			parameters[12].Value = model.ICPGroupID;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TimeInterControlProgramGroup set ");
			strSql.Append("TimeICPGName=@TimeICPGName,");
			strSql.Append("TimeICPGEnable=@TimeICPGEnable,");
			strSql.Append("TimeICPGLoop=@TimeICPGLoop,");
			strSql.Append("MonEnable=@MonEnable,");
			strSql.Append("TueEnable=@TueEnable,");
			strSql.Append("WedEnable=@WedEnable,");
			strSql.Append("ThuEnable=@ThuEnable,");
			strSql.Append("FriEnable=@FriEnable,");
			strSql.Append("SatEnable=@SatEnable,");
			strSql.Append("SunEnable=@SunEnable,");
			strSql.Append("TimePoint=@TimePoint,");
			strSql.Append("ICPGroupID=@ICPGroupID");
			strSql.Append(" where TimeICPGID=@TimeICPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPGName", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeICPGEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimeICPGLoop", SqlDbType.Bit,1),
					new SqlParameter("@MonEnable", SqlDbType.Bit,1),
					new SqlParameter("@TueEnable", SqlDbType.Bit,1),
					new SqlParameter("@WedEnable", SqlDbType.Bit,1),
					new SqlParameter("@ThuEnable", SqlDbType.Bit,1),
					new SqlParameter("@FriEnable", SqlDbType.Bit,1),
					new SqlParameter("@SatEnable", SqlDbType.Bit,1),
					new SqlParameter("@SunEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@ICPGroupID", SqlDbType.Int,4),
					new SqlParameter("@TimeICPGID", SqlDbType.Int,4)};
			parameters[0].Value = model.TimeICPGName;
			parameters[1].Value = model.TimeICPGEnable;
			parameters[2].Value = model.TimeICPGLoop;
			parameters[3].Value = model.MonEnable;
			parameters[4].Value = model.TueEnable;
			parameters[5].Value = model.WedEnable;
			parameters[6].Value = model.ThuEnable;
			parameters[7].Value = model.FriEnable;
			parameters[8].Value = model.SatEnable;
			parameters[9].Value = model.SunEnable;
			parameters[10].Value = model.TimePoint;
			parameters[11].Value = model.ICPGroupID;
			parameters[12].Value = model.TimeICPGID;

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
		public bool Delete(int TimeICPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeInterControlProgramGroup ");
			strSql.Append(" where TimeICPGID=@TimeICPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPGID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPGID;

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
		public bool DeleteList(string TimeICPGIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeInterControlProgramGroup ");
			strSql.Append(" where TimeICPGID in ("+TimeICPGIDlist + ")  ");
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
		public KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup GetModel(int TimeICPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TimeICPGID,TimeICPGName,TimeICPGEnable,TimeICPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPGroupID from TimeInterControlProgramGroup ");
			strSql.Append(" where TimeICPGID=@TimeICPGID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPGID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPGID;

			KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup model=new KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup();
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
		public KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup model=new KryptonAccessController.AccessSdkDataBase.Model.TimeInterControlProgramGroup();
			if (row != null)
			{
				if(row["TimeICPGID"]!=null && row["TimeICPGID"].ToString()!="")
				{
					model.TimeICPGID=int.Parse(row["TimeICPGID"].ToString());
				}
				if(row["TimeICPGName"]!=null)
				{
					model.TimeICPGName=row["TimeICPGName"].ToString();
				}
				if(row["TimeICPGEnable"]!=null && row["TimeICPGEnable"].ToString()!="")
				{
					if((row["TimeICPGEnable"].ToString()=="1")||(row["TimeICPGEnable"].ToString().ToLower()=="true"))
					{
						model.TimeICPGEnable=true;
					}
					else
					{
						model.TimeICPGEnable=false;
					}
				}
				if(row["TimeICPGLoop"]!=null && row["TimeICPGLoop"].ToString()!="")
				{
					if((row["TimeICPGLoop"].ToString()=="1")||(row["TimeICPGLoop"].ToString().ToLower()=="true"))
					{
						model.TimeICPGLoop=true;
					}
					else
					{
						model.TimeICPGLoop=false;
					}
				}
				if(row["MonEnable"]!=null && row["MonEnable"].ToString()!="")
				{
					if((row["MonEnable"].ToString()=="1")||(row["MonEnable"].ToString().ToLower()=="true"))
					{
						model.MonEnable=true;
					}
					else
					{
						model.MonEnable=false;
					}
				}
				if(row["TueEnable"]!=null && row["TueEnable"].ToString()!="")
				{
					if((row["TueEnable"].ToString()=="1")||(row["TueEnable"].ToString().ToLower()=="true"))
					{
						model.TueEnable=true;
					}
					else
					{
						model.TueEnable=false;
					}
				}
				if(row["WedEnable"]!=null && row["WedEnable"].ToString()!="")
				{
					if((row["WedEnable"].ToString()=="1")||(row["WedEnable"].ToString().ToLower()=="true"))
					{
						model.WedEnable=true;
					}
					else
					{
						model.WedEnable=false;
					}
				}
				if(row["ThuEnable"]!=null && row["ThuEnable"].ToString()!="")
				{
					if((row["ThuEnable"].ToString()=="1")||(row["ThuEnable"].ToString().ToLower()=="true"))
					{
						model.ThuEnable=true;
					}
					else
					{
						model.ThuEnable=false;
					}
				}
				if(row["FriEnable"]!=null && row["FriEnable"].ToString()!="")
				{
					if((row["FriEnable"].ToString()=="1")||(row["FriEnable"].ToString().ToLower()=="true"))
					{
						model.FriEnable=true;
					}
					else
					{
						model.FriEnable=false;
					}
				}
				if(row["SatEnable"]!=null && row["SatEnable"].ToString()!="")
				{
					if((row["SatEnable"].ToString()=="1")||(row["SatEnable"].ToString().ToLower()=="true"))
					{
						model.SatEnable=true;
					}
					else
					{
						model.SatEnable=false;
					}
				}
				if(row["SunEnable"]!=null && row["SunEnable"].ToString()!="")
				{
					if((row["SunEnable"].ToString()=="1")||(row["SunEnable"].ToString().ToLower()=="true"))
					{
						model.SunEnable=true;
					}
					else
					{
						model.SunEnable=false;
					}
				}
				if(row["TimePoint"]!=null)
				{
					model.TimePoint=row["TimePoint"].ToString();
				}
				if(row["ICPGroupID"]!=null && row["ICPGroupID"].ToString()!="")
				{
					model.ICPGroupID=int.Parse(row["ICPGroupID"].ToString());
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
			strSql.Append("select TimeICPGID,TimeICPGName,TimeICPGEnable,TimeICPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPGroupID ");
			strSql.Append(" FROM TimeInterControlProgramGroup ");
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
			strSql.Append(" TimeICPGID,TimeICPGName,TimeICPGEnable,TimeICPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPGroupID ");
			strSql.Append(" FROM TimeInterControlProgramGroup ");
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
			strSql.Append("select count(1) FROM TimeInterControlProgramGroup ");
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
				strSql.Append("order by T.TimeICPGID desc");
			}
			strSql.Append(")AS Row, T.*  from TimeInterControlProgramGroup T ");
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
			parameters[0].Value = "TimeInterControlProgramGroup";
			parameters[1].Value = "TimeICPGID";
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

