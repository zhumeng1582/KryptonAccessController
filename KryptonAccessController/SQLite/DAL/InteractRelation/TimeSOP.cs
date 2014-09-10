/**  版本信息模板在安装目录下，可自行修改。
* TimeSOP.cs
*
* 功 能： N/A
* 类 名： TimeSOP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:16   N/A    初版
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
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.SQLite.DAL.InteractRelation
{
	/// <summary>
	/// 数据访问类:TimeSOP
	/// </summary>
	public partial class TimeSOP
	{
		public TimeSOP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("TimeSOPGID", "TimeSOP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TimeSOPGID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TimeSOP");
			strSql.Append(" where TimeSOPGID=@TimeSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TimeSOPGID", DbType.Int32,4)			};
			parameters[0].Value = TimeSOPGID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TimeSOP(");
			strSql.Append("TimeSOPGID,TimeSOPGName,TimeSOPGEnable,TimeSOPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,SOPID)");
			strSql.Append(" values (");
			strSql.Append("@TimeSOPGID,@TimeSOPGName,@TimeSOPGEnable,@TimeSOPGLoop,@MonEnable,@TueEnable,@WedEnable,@ThuEnable,@FriEnable,@SatEnable,@SunEnable,@TimePoint,@SOPID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TimeSOPGID", DbType.Int32,4),
					new SQLiteParameter("@TimeSOPGName", DbType.String),
					new SQLiteParameter("@TimeSOPGEnable", DbType.Boolean,1),
					new SQLiteParameter("@TimeSOPGLoop", DbType.Boolean,1),
					new SQLiteParameter("@MonEnable", DbType.Boolean,1),
					new SQLiteParameter("@TueEnable", DbType.Boolean,1),
					new SQLiteParameter("@WedEnable", DbType.Boolean,1),
					new SQLiteParameter("@ThuEnable", DbType.Boolean,1),
					new SQLiteParameter("@FriEnable", DbType.Boolean,1),
					new SQLiteParameter("@SatEnable", DbType.Boolean,1),
					new SQLiteParameter("@SunEnable", DbType.Boolean,1),
					new SQLiteParameter("@TimePoint", DbType.String),
					new SQLiteParameter("@SOPID", DbType.Int32,4)};
			parameters[0].Value = model.TimeSOPGID;
			parameters[1].Value = model.TimeSOPGName;
			parameters[2].Value = model.TimeSOPGEnable;
			parameters[3].Value = model.TimeSOPGLoop;
			parameters[4].Value = model.MonEnable;
			parameters[5].Value = model.TueEnable;
			parameters[6].Value = model.WedEnable;
			parameters[7].Value = model.ThuEnable;
			parameters[8].Value = model.FriEnable;
			parameters[9].Value = model.SatEnable;
			parameters[10].Value = model.SunEnable;
			parameters[11].Value = model.TimePoint;
			parameters[12].Value = model.SOPID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TimeSOP set ");
			strSql.Append("TimeSOPGName=@TimeSOPGName,");
			strSql.Append("TimeSOPGEnable=@TimeSOPGEnable,");
			strSql.Append("TimeSOPGLoop=@TimeSOPGLoop,");
			strSql.Append("MonEnable=@MonEnable,");
			strSql.Append("TueEnable=@TueEnable,");
			strSql.Append("WedEnable=@WedEnable,");
			strSql.Append("ThuEnable=@ThuEnable,");
			strSql.Append("FriEnable=@FriEnable,");
			strSql.Append("SatEnable=@SatEnable,");
			strSql.Append("SunEnable=@SunEnable,");
			strSql.Append("TimePoint=@TimePoint,");
			strSql.Append("SOPID=@SOPID");
			strSql.Append(" where TimeSOPGID=@TimeSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TimeSOPGName", DbType.String),
					new SQLiteParameter("@TimeSOPGEnable", DbType.Boolean,1),
					new SQLiteParameter("@TimeSOPGLoop", DbType.Boolean,1),
					new SQLiteParameter("@MonEnable", DbType.Boolean,1),
					new SQLiteParameter("@TueEnable", DbType.Boolean,1),
					new SQLiteParameter("@WedEnable", DbType.Boolean,1),
					new SQLiteParameter("@ThuEnable", DbType.Boolean,1),
					new SQLiteParameter("@FriEnable", DbType.Boolean,1),
					new SQLiteParameter("@SatEnable", DbType.Boolean,1),
					new SQLiteParameter("@SunEnable", DbType.Boolean,1),
					new SQLiteParameter("@TimePoint", DbType.String),
					new SQLiteParameter("@SOPID", DbType.Int32,4),
					new SQLiteParameter("@TimeSOPGID", DbType.Int32,4)};
			parameters[0].Value = model.TimeSOPGName;
			parameters[1].Value = model.TimeSOPGEnable;
			parameters[2].Value = model.TimeSOPGLoop;
			parameters[3].Value = model.MonEnable;
			parameters[4].Value = model.TueEnable;
			parameters[5].Value = model.WedEnable;
			parameters[6].Value = model.ThuEnable;
			parameters[7].Value = model.FriEnable;
			parameters[8].Value = model.SatEnable;
			parameters[9].Value = model.SunEnable;
			parameters[10].Value = model.TimePoint;
			parameters[11].Value = model.SOPID;
			parameters[12].Value = model.TimeSOPGID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int TimeSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeSOP ");
			strSql.Append(" where TimeSOPGID=@TimeSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TimeSOPGID", DbType.Int32,4)			};
			parameters[0].Value = TimeSOPGID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string TimeSOPGIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TimeSOP ");
			strSql.Append(" where TimeSOPGID in ("+TimeSOPGIDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
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
		public KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP GetModel(int TimeSOPGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TimeSOPGID,TimeSOPGName,TimeSOPGEnable,TimeSOPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,SOPID from TimeSOP ");
			strSql.Append(" where TimeSOPGID=@TimeSOPGID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TimeSOPGID", DbType.Int32,4)			};
			parameters[0].Value = TimeSOPGID;

			KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP model=new KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
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
		public KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP model=new KryptonAccessController.SQLite.Model.InteractRelation.TimeSOP();
			if (row != null)
			{
				if(row["TimeSOPGID"]!=null && row["TimeSOPGID"].ToString()!="")
				{
					model.TimeSOPGID=int.Parse(row["TimeSOPGID"].ToString());
				}
				if(row["TimeSOPGName"]!=null)
				{
					model.TimeSOPGName=row["TimeSOPGName"].ToString();
				}
				if(row["TimeSOPGEnable"]!=null && row["TimeSOPGEnable"].ToString()!="")
				{
					if((row["TimeSOPGEnable"].ToString()=="1")||(row["TimeSOPGEnable"].ToString().ToLower()=="true"))
					{
						model.TimeSOPGEnable=true;
					}
					else
					{
						model.TimeSOPGEnable=false;
					}
				}
				if(row["TimeSOPGLoop"]!=null && row["TimeSOPGLoop"].ToString()!="")
				{
					if((row["TimeSOPGLoop"].ToString()=="1")||(row["TimeSOPGLoop"].ToString().ToLower()=="true"))
					{
						model.TimeSOPGLoop=true;
					}
					else
					{
						model.TimeSOPGLoop=false;
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
				if(row["SOPID"]!=null && row["SOPID"].ToString()!="")
				{
					model.SOPID=int.Parse(row["SOPID"].ToString());
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
			strSql.Append("select TimeSOPGID,TimeSOPGName,TimeSOPGEnable,TimeSOPGLoop,MonEnable,TueEnable,WedEnable,ThuEnable,FriEnable,SatEnable,SunEnable,TimePoint,SOPID ");
			strSql.Append(" FROM TimeSOP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TimeSOP ");
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
				strSql.Append("order by T.TimeSOPGID desc");
			}
			strSql.Append(")AS Row, T.*  from TimeSOP T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.Boolean),
					new SQLiteParameter("@OrderType", DbType.Boolean),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "TimeSOP";
			parameters[1].Value = "TimeSOPGID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

