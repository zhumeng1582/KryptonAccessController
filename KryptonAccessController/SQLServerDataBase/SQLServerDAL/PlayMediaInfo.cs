/**  版本信息模板在安装目录下，可自行修改。
* PlayMediaInfo.cs
*
* 功 能： N/A
* 类 名： PlayMediaInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:30   N/A    初版
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
	/// 数据访问类:PlayMediaInfo
	/// </summary>
	public partial class PlayMediaInfo:IPlayMediaInfo
	{
		public PlayMediaInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PlayMediaID", "PlayMediaInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PlayMediaID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PlayMediaInfo");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)			};
			parameters[0].Value = PlayMediaID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.PlayMediaInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PlayMediaInfo(");
			strSql.Append("PlayMediaID,PlayMediaName,PlayReaderID,PlayLoop,PlayMediaGroupID1,STime1,ETime1,PlayMediaGroupID2,STime2,ETime2,PlayMediaGroupID3,STime3,ETime3,PlayMediaGroupID4,STime4,ETime4,PlayMediaGroupID5,STime5,ETime5,PlayMediaGroupID6,STime6,ETime6)");
			strSql.Append(" values (");
			strSql.Append("@PlayMediaID,@PlayMediaName,@PlayReaderID,@PlayLoop,@PlayMediaGroupID1,@STime1,@ETime1,@PlayMediaGroupID2,@STime2,@ETime2,@PlayMediaGroupID3,@STime3,@ETime3,@PlayMediaGroupID4,@STime4,@ETime4,@PlayMediaGroupID5,@STime5,@ETime5,@PlayMediaGroupID6,@STime6,@ETime6)");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlayReaderID", SqlDbType.Int,4),
					new SqlParameter("@PlayLoop", SqlDbType.Bit,1),
					new SqlParameter("@PlayMediaGroupID1", SqlDbType.Int,4),
					new SqlParameter("@STime1", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime1", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID2", SqlDbType.Int,4),
					new SqlParameter("@STime2", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime2", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID3", SqlDbType.Int,4),
					new SqlParameter("@STime3", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime3", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID4", SqlDbType.Int,4),
					new SqlParameter("@STime4", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime4", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID5", SqlDbType.Int,4),
					new SqlParameter("@STime5", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime5", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID6", SqlDbType.Int,4),
					new SqlParameter("@STime6", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime6", SqlDbType.NVarChar,8)};
			parameters[0].Value = model.PlayMediaID;
			parameters[1].Value = model.PlayMediaName;
			parameters[2].Value = model.PlayReaderID;
			parameters[3].Value = model.PlayLoop;
			parameters[4].Value = model.PlayMediaGroupID1;
			parameters[5].Value = model.STime1;
			parameters[6].Value = model.ETime1;
			parameters[7].Value = model.PlayMediaGroupID2;
			parameters[8].Value = model.STime2;
			parameters[9].Value = model.ETime2;
			parameters[10].Value = model.PlayMediaGroupID3;
			parameters[11].Value = model.STime3;
			parameters[12].Value = model.ETime3;
			parameters[13].Value = model.PlayMediaGroupID4;
			parameters[14].Value = model.STime4;
			parameters[15].Value = model.ETime4;
			parameters[16].Value = model.PlayMediaGroupID5;
			parameters[17].Value = model.STime5;
			parameters[18].Value = model.ETime5;
			parameters[19].Value = model.PlayMediaGroupID6;
			parameters[20].Value = model.STime6;
			parameters[21].Value = model.ETime6;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.PlayMediaInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PlayMediaInfo set ");
			strSql.Append("PlayMediaName=@PlayMediaName,");
			strSql.Append("PlayReaderID=@PlayReaderID,");
			strSql.Append("PlayLoop=@PlayLoop,");
			strSql.Append("PlayMediaGroupID1=@PlayMediaGroupID1,");
			strSql.Append("STime1=@STime1,");
			strSql.Append("ETime1=@ETime1,");
			strSql.Append("PlayMediaGroupID2=@PlayMediaGroupID2,");
			strSql.Append("STime2=@STime2,");
			strSql.Append("ETime2=@ETime2,");
			strSql.Append("PlayMediaGroupID3=@PlayMediaGroupID3,");
			strSql.Append("STime3=@STime3,");
			strSql.Append("ETime3=@ETime3,");
			strSql.Append("PlayMediaGroupID4=@PlayMediaGroupID4,");
			strSql.Append("STime4=@STime4,");
			strSql.Append("ETime4=@ETime4,");
			strSql.Append("PlayMediaGroupID5=@PlayMediaGroupID5,");
			strSql.Append("STime5=@STime5,");
			strSql.Append("ETime5=@ETime5,");
			strSql.Append("PlayMediaGroupID6=@PlayMediaGroupID6,");
			strSql.Append("STime6=@STime6,");
			strSql.Append("ETime6=@ETime6");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlayReaderID", SqlDbType.Int,4),
					new SqlParameter("@PlayLoop", SqlDbType.Bit,1),
					new SqlParameter("@PlayMediaGroupID1", SqlDbType.Int,4),
					new SqlParameter("@STime1", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime1", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID2", SqlDbType.Int,4),
					new SqlParameter("@STime2", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime2", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID3", SqlDbType.Int,4),
					new SqlParameter("@STime3", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime3", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID4", SqlDbType.Int,4),
					new SqlParameter("@STime4", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime4", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID5", SqlDbType.Int,4),
					new SqlParameter("@STime5", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime5", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaGroupID6", SqlDbType.Int,4),
					new SqlParameter("@STime6", SqlDbType.NVarChar,8),
					new SqlParameter("@ETime6", SqlDbType.NVarChar,8),
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)};
			parameters[0].Value = model.PlayMediaName;
			parameters[1].Value = model.PlayReaderID;
			parameters[2].Value = model.PlayLoop;
			parameters[3].Value = model.PlayMediaGroupID1;
			parameters[4].Value = model.STime1;
			parameters[5].Value = model.ETime1;
			parameters[6].Value = model.PlayMediaGroupID2;
			parameters[7].Value = model.STime2;
			parameters[8].Value = model.ETime2;
			parameters[9].Value = model.PlayMediaGroupID3;
			parameters[10].Value = model.STime3;
			parameters[11].Value = model.ETime3;
			parameters[12].Value = model.PlayMediaGroupID4;
			parameters[13].Value = model.STime4;
			parameters[14].Value = model.ETime4;
			parameters[15].Value = model.PlayMediaGroupID5;
			parameters[16].Value = model.STime5;
			parameters[17].Value = model.ETime5;
			parameters[18].Value = model.PlayMediaGroupID6;
			parameters[19].Value = model.STime6;
			parameters[20].Value = model.ETime6;
			parameters[21].Value = model.PlayMediaID;

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
		public bool Delete(int PlayMediaID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PlayMediaInfo ");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)			};
			parameters[0].Value = PlayMediaID;

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
		public bool DeleteList(string PlayMediaIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PlayMediaInfo ");
			strSql.Append(" where PlayMediaID in ("+PlayMediaIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.PlayMediaInfo GetModel(int PlayMediaID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PlayMediaID,PlayMediaName,PlayReaderID,PlayLoop,PlayMediaGroupID1,STime1,ETime1,PlayMediaGroupID2,STime2,ETime2,PlayMediaGroupID3,STime3,ETime3,PlayMediaGroupID4,STime4,ETime4,PlayMediaGroupID5,STime5,ETime5,PlayMediaGroupID6,STime6,ETime6 from PlayMediaInfo ");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)			};
			parameters[0].Value = PlayMediaID;

			KryptonAccessController.AccessDataBase.Model.PlayMediaInfo model=new KryptonAccessController.AccessDataBase.Model.PlayMediaInfo();
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
		public KryptonAccessController.AccessDataBase.Model.PlayMediaInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.PlayMediaInfo model=new KryptonAccessController.AccessDataBase.Model.PlayMediaInfo();
			if (row != null)
			{
				if(row["PlayMediaID"]!=null && row["PlayMediaID"].ToString()!="")
				{
					model.PlayMediaID=int.Parse(row["PlayMediaID"].ToString());
				}
				if(row["PlayMediaName"]!=null)
				{
					model.PlayMediaName=row["PlayMediaName"].ToString();
				}
				if(row["PlayReaderID"]!=null && row["PlayReaderID"].ToString()!="")
				{
					model.PlayReaderID=int.Parse(row["PlayReaderID"].ToString());
				}
				if(row["PlayLoop"]!=null && row["PlayLoop"].ToString()!="")
				{
					if((row["PlayLoop"].ToString()=="1")||(row["PlayLoop"].ToString().ToLower()=="true"))
					{
						model.PlayLoop=true;
					}
					else
					{
						model.PlayLoop=false;
					}
				}
				if(row["PlayMediaGroupID1"]!=null && row["PlayMediaGroupID1"].ToString()!="")
				{
					model.PlayMediaGroupID1=int.Parse(row["PlayMediaGroupID1"].ToString());
				}
				if(row["STime1"]!=null)
				{
					model.STime1=row["STime1"].ToString();
				}
				if(row["ETime1"]!=null)
				{
					model.ETime1=row["ETime1"].ToString();
				}
				if(row["PlayMediaGroupID2"]!=null && row["PlayMediaGroupID2"].ToString()!="")
				{
					model.PlayMediaGroupID2=int.Parse(row["PlayMediaGroupID2"].ToString());
				}
				if(row["STime2"]!=null)
				{
					model.STime2=row["STime2"].ToString();
				}
				if(row["ETime2"]!=null)
				{
					model.ETime2=row["ETime2"].ToString();
				}
				if(row["PlayMediaGroupID3"]!=null && row["PlayMediaGroupID3"].ToString()!="")
				{
					model.PlayMediaGroupID3=int.Parse(row["PlayMediaGroupID3"].ToString());
				}
				if(row["STime3"]!=null)
				{
					model.STime3=row["STime3"].ToString();
				}
				if(row["ETime3"]!=null)
				{
					model.ETime3=row["ETime3"].ToString();
				}
				if(row["PlayMediaGroupID4"]!=null && row["PlayMediaGroupID4"].ToString()!="")
				{
					model.PlayMediaGroupID4=int.Parse(row["PlayMediaGroupID4"].ToString());
				}
				if(row["STime4"]!=null)
				{
					model.STime4=row["STime4"].ToString();
				}
				if(row["ETime4"]!=null)
				{
					model.ETime4=row["ETime4"].ToString();
				}
				if(row["PlayMediaGroupID5"]!=null && row["PlayMediaGroupID5"].ToString()!="")
				{
					model.PlayMediaGroupID5=int.Parse(row["PlayMediaGroupID5"].ToString());
				}
				if(row["STime5"]!=null)
				{
					model.STime5=row["STime5"].ToString();
				}
				if(row["ETime5"]!=null)
				{
					model.ETime5=row["ETime5"].ToString();
				}
				if(row["PlayMediaGroupID6"]!=null && row["PlayMediaGroupID6"].ToString()!="")
				{
					model.PlayMediaGroupID6=int.Parse(row["PlayMediaGroupID6"].ToString());
				}
				if(row["STime6"]!=null)
				{
					model.STime6=row["STime6"].ToString();
				}
				if(row["ETime6"]!=null)
				{
					model.ETime6=row["ETime6"].ToString();
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
			strSql.Append("select PlayMediaID,PlayMediaName,PlayReaderID,PlayLoop,PlayMediaGroupID1,STime1,ETime1,PlayMediaGroupID2,STime2,ETime2,PlayMediaGroupID3,STime3,ETime3,PlayMediaGroupID4,STime4,ETime4,PlayMediaGroupID5,STime5,ETime5,PlayMediaGroupID6,STime6,ETime6 ");
			strSql.Append(" FROM PlayMediaInfo ");
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
			strSql.Append(" PlayMediaID,PlayMediaName,PlayReaderID,PlayLoop,PlayMediaGroupID1,STime1,ETime1,PlayMediaGroupID2,STime2,ETime2,PlayMediaGroupID3,STime3,ETime3,PlayMediaGroupID4,STime4,ETime4,PlayMediaGroupID5,STime5,ETime5,PlayMediaGroupID6,STime6,ETime6 ");
			strSql.Append(" FROM PlayMediaInfo ");
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
			strSql.Append("select count(1) FROM PlayMediaInfo ");
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
				strSql.Append("order by T.PlayMediaID desc");
			}
			strSql.Append(")AS Row, T.*  from PlayMediaInfo T ");
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
			parameters[0].Value = "PlayMediaInfo";
			parameters[1].Value = "PlayMediaID";
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

