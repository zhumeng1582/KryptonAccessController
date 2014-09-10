/**  版本信息模板在安装目录下，可自行修改。
* TimeICP.cs
*
* 功 能： N/A
* 类 名： TimeICP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-18 16:37:42   N/A    初版
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
	/// 数据访问类:TimeICP
	/// </summary>
	public partial class TimeICP:ITimeICP
	{
		public TimeICP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TimeICPID", "TimeICP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TimeICPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TimeICP");
			strSql.Append(" where TimeICPID=@TimeICPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.TimeICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TimeICP(");
			strSql.Append("TimeICPID,TimeICPName,TimeICPEnable,TimeICPLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPID)");
			strSql.Append(" values (");
			strSql.Append("@TimeICPID,@TimeICPName,@TimeICPEnable,@TimeICPLoop,@MonEnable,@TueEnable,@WedEnable,@ThuEnable,@FriEnable,@SatEnable,@SunEnable,@TimePoint,@ICPID)");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPID", SqlDbType.Int,4),
					new SqlParameter("@TimeICPName", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeICPEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimeICPLoop", SqlDbType.Bit,1),
					new SqlParameter("@MonEnable", SqlDbType.Bit,1),
					new SqlParameter("@TueEnable", SqlDbType.Bit,1),
					new SqlParameter("@WedEnable", SqlDbType.Bit,1),
					new SqlParameter("@ThuEnable", SqlDbType.Bit,1),
					new SqlParameter("@FriEnable", SqlDbType.Bit,1),
					new SqlParameter("@SatEnable", SqlDbType.Bit,1),
					new SqlParameter("@SunEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@ICPID", SqlDbType.Int,4)};
			parameters[0].Value = model.TimeICPID;
			parameters[1].Value = model.TimeICPName;
			parameters[2].Value = model.TimeICPEnable;
			parameters[3].Value = model.TimeICPLoop;
			parameters[4].Value = model.MonEnable;
			parameters[5].Value = model.TueEnable;
			parameters[6].Value = model.WedEnable;
			parameters[7].Value = model.ThuEnable;
			parameters[8].Value = model.FriEnable;
			parameters[9].Value = model.SatEnable;
			parameters[10].Value = model.SunEnable;
			parameters[11].Value = model.TimePoint;
			parameters[12].Value = model.ICPID;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.TimeICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TimeICP set ");
			strSql.Append("TimeICPName=@TimeICPName,");
			strSql.Append("TimeICPEnable=@TimeICPEnable,");
			strSql.Append("TimeICPLoop=@TimeICPLoop,");
			strSql.Append("MonEnable=@MonEnable,");
			strSql.Append("TueEnable=@TueEnable,");
			strSql.Append("WedEnable=@WedEnable,");
			strSql.Append("ThuEnable=@ThuEnable,");
			strSql.Append("FriEnable=@FriEnable,");
			strSql.Append("SatEnable=@SatEnable,");
			strSql.Append("SunEnable=@SunEnable,");
			strSql.Append("TimePoint=@TimePoint,");
			strSql.Append("ICPID=@ICPID");
			strSql.Append(" where TimeICPID=@TimeICPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPName", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeICPEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimeICPLoop", SqlDbType.Bit,1),
					new SqlParameter("@MonEnable", SqlDbType.Bit,1),
					new SqlParameter("@TueEnable", SqlDbType.Bit,1),
					new SqlParameter("@WedEnable", SqlDbType.Bit,1),
					new SqlParameter("@ThuEnable", SqlDbType.Bit,1),
					new SqlParameter("@FriEnable", SqlDbType.Bit,1),
					new SqlParameter("@SatEnable", SqlDbType.Bit,1),
					new SqlParameter("@SunEnable", SqlDbType.Bit,1),
					new SqlParameter("@TimePoint", SqlDbType.NVarChar,8),
					new SqlParameter("@ICPID", SqlDbType.Int,4),
					new SqlParameter("@TimeICPID", SqlDbType.Int,4)};
			parameters[0].Value = model.TimeICPName;
			parameters[1].Value = model.TimeICPEnable;
			parameters[2].Value = model.TimeICPLoop;
			parameters[3].Value = model.MonEnable;
			parameters[4].Value = model.TueEnable;
			parameters[5].Value = model.WedEnable;
			parameters[6].Value = model.ThuEnable;
			parameters[7].Value = model.FriEnable;
			parameters[8].Value = model.SatEnable;
			parameters[9].Value = model.SunEnable;
			parameters[10].Value = model.TimePoint;
			parameters[11].Value = model.ICPID;
			parameters[12].Value = model.TimeICPID;

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
		public bool Delete(int TimeICPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeICP ");
			strSql.Append(" where TimeICPID=@TimeICPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPID;

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
		public bool DeleteList(string TimeICPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeICP ");
			strSql.Append(" where TimeICPID in ("+TimeICPIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.TimeICP GetModel(int TimeICPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TimeICPID,TimeICPName,TimeICPEnable,TimeICPLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPID from TimeICP ");
			strSql.Append(" where TimeICPID=@TimeICPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TimeICPID", SqlDbType.Int,4)			};
			parameters[0].Value = TimeICPID;

			KryptonAccessController.AccessDataBase.Model.TimeICP model=new KryptonAccessController.AccessDataBase.Model.TimeICP();
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
		public KryptonAccessController.AccessDataBase.Model.TimeICP DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.TimeICP model=new KryptonAccessController.AccessDataBase.Model.TimeICP();
			if (row != null)
			{
				if(row["TimeICPID"]!=null && row["TimeICPID"].ToString()!="")
				{
					model.TimeICPID=int.Parse(row["TimeICPID"].ToString());
				}
				if(row["TimeICPName"]!=null)
				{
					model.TimeICPName=row["TimeICPName"].ToString();
				}
				if(row["TimeICPEnable"]!=null && row["TimeICPEnable"].ToString()!="")
				{
					if((row["TimeICPEnable"].ToString()=="1")||(row["TimeICPEnable"].ToString().ToLower()=="true"))
					{
						model.TimeICPEnable=true;
					}
					else
					{
						model.TimeICPEnable=false;
					}
				}
				if(row["TimeICPLoop"]!=null && row["TimeICPLoop"].ToString()!="")
				{
					if((row["TimeICPLoop"].ToString()=="1")||(row["TimeICPLoop"].ToString().ToLower()=="true"))
					{
						model.TimeICPLoop=true;
					}
					else
					{
						model.TimeICPLoop=false;
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
				if(row["ICPID"]!=null && row["ICPID"].ToString()!="")
				{
					model.ICPID=int.Parse(row["ICPID"].ToString());
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
			strSql.Append("select TimeICPID,TimeICPName,TimeICPEnable,TimeICPLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPID ");
			strSql.Append(" FROM TimeICP ");
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
			strSql.Append(" TimeICPID,TimeICPName,TimeICPEnable,TimeICPLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,ICPID ");
			strSql.Append(" FROM TimeICP ");
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
			strSql.Append("select count(1) FROM TimeICP ");
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
				strSql.Append("order by T.TimeICPID desc");
			}
			strSql.Append(")AS Row, T.*  from TimeICP T ");
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
			parameters[0].Value = "TimeICP";
			parameters[1].Value = "TimeICPID";
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

