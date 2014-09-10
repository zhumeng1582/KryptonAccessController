/**  版本信息模板在安装目录下，可自行修改。
* AntiPassBack.cs
*
* 功 能： N/A
* 类 名： AntiPassBack
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:07   N/A    初版
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
	/// 数据访问类:AntiPassBack
	/// </summary>
	public partial class AntiPassBack
	{
		public AntiPassBack()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("AntiPassBackID", "AntiPassBack"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AntiPassBackID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AntiPassBack");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AntiPassBackID", DbType.Int32,4)			};
			parameters[0].Value = AntiPassBackID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AntiPassBack(");
			strSql.Append("AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4)");
			strSql.Append(" values (");
			strSql.Append("@AntiPassBackID,@AntiPassBackMode,@AntiPassEnable,@ControlerInfoInLANID1,@DoorUnitID1,@ControlerInfoInLANID2,@DoorUnitID2,@ControlerInfoInLANID3,@DoorUnitID3,@ControlerInfoInLANID4,@DoorUnitID4)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AntiPassBackID", DbType.Int32,4),
					new SQLiteParameter("@AntiPassBackMode", DbType.Int32,4),
					new SQLiteParameter("@AntiPassEnable", DbType.Boolean,1),
					new SQLiteParameter("@ControlerInfoInLANID1", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID1", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID2", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID2", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID3", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID3", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID4", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID4", DbType.Int32,4)};
			parameters[0].Value = model.AntiPassBackID;
			parameters[1].Value = model.AntiPassBackMode;
			parameters[2].Value = model.AntiPassEnable;
			parameters[3].Value = model.ControlerInfoInLANID1;
			parameters[4].Value = model.DoorUnitID1;
			parameters[5].Value = model.ControlerInfoInLANID2;
			parameters[6].Value = model.DoorUnitID2;
			parameters[7].Value = model.ControlerInfoInLANID3;
			parameters[8].Value = model.DoorUnitID3;
			parameters[9].Value = model.ControlerInfoInLANID4;
			parameters[10].Value = model.DoorUnitID4;

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
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AntiPassBack set ");
			strSql.Append("AntiPassBackMode=@AntiPassBackMode,");
			strSql.Append("AntiPassEnable=@AntiPassEnable,");
			strSql.Append("ControlerInfoInLANID1=@ControlerInfoInLANID1,");
			strSql.Append("DoorUnitID1=@DoorUnitID1,");
			strSql.Append("ControlerInfoInLANID2=@ControlerInfoInLANID2,");
			strSql.Append("DoorUnitID2=@DoorUnitID2,");
			strSql.Append("ControlerInfoInLANID3=@ControlerInfoInLANID3,");
			strSql.Append("DoorUnitID3=@DoorUnitID3,");
			strSql.Append("ControlerInfoInLANID4=@ControlerInfoInLANID4,");
			strSql.Append("DoorUnitID4=@DoorUnitID4");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AntiPassBackMode", DbType.Int32,4),
					new SQLiteParameter("@AntiPassEnable", DbType.Boolean,1),
					new SQLiteParameter("@ControlerInfoInLANID1", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID1", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID2", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID2", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID3", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID3", DbType.Int32,4),
					new SQLiteParameter("@ControlerInfoInLANID4", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitID4", DbType.Int32,4),
					new SQLiteParameter("@AntiPassBackID", DbType.Int32,4)};
			parameters[0].Value = model.AntiPassBackMode;
			parameters[1].Value = model.AntiPassEnable;
			parameters[2].Value = model.ControlerInfoInLANID1;
			parameters[3].Value = model.DoorUnitID1;
			parameters[4].Value = model.ControlerInfoInLANID2;
			parameters[5].Value = model.DoorUnitID2;
			parameters[6].Value = model.ControlerInfoInLANID3;
			parameters[7].Value = model.DoorUnitID3;
			parameters[8].Value = model.ControlerInfoInLANID4;
			parameters[9].Value = model.DoorUnitID4;
			parameters[10].Value = model.AntiPassBackID;

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
		public bool Delete(int AntiPassBackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AntiPassBack ");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AntiPassBackID", DbType.Int32,4)			};
			parameters[0].Value = AntiPassBackID;

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
		public bool DeleteList(string AntiPassBackIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AntiPassBack ");
			strSql.Append(" where AntiPassBackID in ("+AntiPassBackIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack GetModel(int AntiPassBackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4 from AntiPassBack ");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AntiPassBackID", DbType.Int32,4)			};
			parameters[0].Value = AntiPassBackID;

			KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack model=new KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack();
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
		public KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack model=new KryptonAccessController.SQLite.Model.InteractRelation.AntiPassBack();
			if (row != null)
			{
				if(row["AntiPassBackID"]!=null && row["AntiPassBackID"].ToString()!="")
				{
					model.AntiPassBackID=int.Parse(row["AntiPassBackID"].ToString());
				}
				if(row["AntiPassBackMode"]!=null && row["AntiPassBackMode"].ToString()!="")
				{
					model.AntiPassBackMode=int.Parse(row["AntiPassBackMode"].ToString());
				}
				if(row["AntiPassEnable"]!=null && row["AntiPassEnable"].ToString()!="")
				{
					if((row["AntiPassEnable"].ToString()=="1")||(row["AntiPassEnable"].ToString().ToLower()=="true"))
					{
						model.AntiPassEnable=true;
					}
					else
					{
						model.AntiPassEnable=false;
					}
				}
				if(row["ControlerInfoInLANID1"]!=null && row["ControlerInfoInLANID1"].ToString()!="")
				{
					model.ControlerInfoInLANID1=int.Parse(row["ControlerInfoInLANID1"].ToString());
				}
				if(row["DoorUnitID1"]!=null && row["DoorUnitID1"].ToString()!="")
				{
					model.DoorUnitID1=int.Parse(row["DoorUnitID1"].ToString());
				}
				if(row["ControlerInfoInLANID2"]!=null && row["ControlerInfoInLANID2"].ToString()!="")
				{
					model.ControlerInfoInLANID2=int.Parse(row["ControlerInfoInLANID2"].ToString());
				}
				if(row["DoorUnitID2"]!=null && row["DoorUnitID2"].ToString()!="")
				{
					model.DoorUnitID2=int.Parse(row["DoorUnitID2"].ToString());
				}
				if(row["ControlerInfoInLANID3"]!=null && row["ControlerInfoInLANID3"].ToString()!="")
				{
					model.ControlerInfoInLANID3=int.Parse(row["ControlerInfoInLANID3"].ToString());
				}
				if(row["DoorUnitID3"]!=null && row["DoorUnitID3"].ToString()!="")
				{
					model.DoorUnitID3=int.Parse(row["DoorUnitID3"].ToString());
				}
				if(row["ControlerInfoInLANID4"]!=null && row["ControlerInfoInLANID4"].ToString()!="")
				{
					model.ControlerInfoInLANID4=int.Parse(row["ControlerInfoInLANID4"].ToString());
				}
				if(row["DoorUnitID4"]!=null && row["DoorUnitID4"].ToString()!="")
				{
					model.DoorUnitID4=int.Parse(row["DoorUnitID4"].ToString());
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
			strSql.Append("select AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4 ");
			strSql.Append(" FROM AntiPassBack ");
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
			strSql.Append("select count(1) FROM AntiPassBack ");
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
				strSql.Append("order by T.AntiPassBackID desc");
			}
			strSql.Append(")AS Row, T.*  from AntiPassBack T ");
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
			parameters[0].Value = "AntiPassBack";
			parameters[1].Value = "AntiPassBackID";
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

