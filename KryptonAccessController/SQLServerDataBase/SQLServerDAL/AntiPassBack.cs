/**  版本信息模板在安装目录下，可自行修改。
* AntiPassBack.cs
*
* 功 能： N/A
* 类 名： AntiPassBack
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:19   N/A    初版
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
	/// 数据访问类:AntiPassBack
	/// </summary>
	public partial class AntiPassBack:IAntiPassBack
	{
		public AntiPassBack()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AntiPassBackID", "AntiPassBack"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AntiPassBackID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AntiPassBack");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AntiPassBackID", SqlDbType.Int,4)			};
			parameters[0].Value = AntiPassBackID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.AntiPassBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AntiPassBack(");
			strSql.Append("AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4)");
			strSql.Append(" values (");
			strSql.Append("@AntiPassBackID,@AntiPassBackMode,@AntiPassEnable,@ControlerInfoInLANID1,@DoorUnitID1,@ControlerInfoInLANID2,@DoorUnitID2,@ControlerInfoInLANID3,@DoorUnitID3,@ControlerInfoInLANID4,@DoorUnitID4)");
			SqlParameter[] parameters = {
					new SqlParameter("@AntiPassBackID", SqlDbType.Int,4),
					new SqlParameter("@AntiPassBackMode", SqlDbType.Int,4),
					new SqlParameter("@AntiPassEnable", SqlDbType.Bit,1),
					new SqlParameter("@ControlerInfoInLANID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID3", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID3", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID4", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID4", SqlDbType.Int,4)};
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.AntiPassBack model)
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
			SqlParameter[] parameters = {
					new SqlParameter("@AntiPassBackMode", SqlDbType.Int,4),
					new SqlParameter("@AntiPassEnable", SqlDbType.Bit,1),
					new SqlParameter("@ControlerInfoInLANID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID3", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID3", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID4", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID4", SqlDbType.Int,4),
					new SqlParameter("@AntiPassBackID", SqlDbType.Int,4)};
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
		public bool Delete(int AntiPassBackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AntiPassBack ");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AntiPassBackID", SqlDbType.Int,4)			};
			parameters[0].Value = AntiPassBackID;

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
		public bool DeleteList(string AntiPassBackIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AntiPassBack ");
			strSql.Append(" where AntiPassBackID in ("+AntiPassBackIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.AntiPassBack GetModel(int AntiPassBackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4 from AntiPassBack ");
			strSql.Append(" where AntiPassBackID=@AntiPassBackID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AntiPassBackID", SqlDbType.Int,4)			};
			parameters[0].Value = AntiPassBackID;

			KryptonAccessController.AccessDataBase.Model.AntiPassBack model=new KryptonAccessController.AccessDataBase.Model.AntiPassBack();
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
		public KryptonAccessController.AccessDataBase.Model.AntiPassBack DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.AntiPassBack model=new KryptonAccessController.AccessDataBase.Model.AntiPassBack();
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
			strSql.Append(" AntiPassBackID,AntiPassBackMode,AntiPassEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2,ControlerInfoInLANID3,DoorUnitID3,ControlerInfoInLANID4,DoorUnitID4 ");
			strSql.Append(" FROM AntiPassBack ");
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
					new SqlParameter("@IsReCount", SqlDbType.Boolean),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "AntiPassBack";
			parameters[1].Value = "AntiPassBackID";
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

