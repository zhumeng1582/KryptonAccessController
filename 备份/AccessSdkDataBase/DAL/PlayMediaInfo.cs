/**  版本信息模板在安装目录下，可自行修改。
* PlayMediaInfo.cs
*
* 功 能： N/A
* 类 名： PlayMediaInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-04-09 11:42:19   N/A    初版
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
	/// 数据访问类:PlayMediaInfo
	/// </summary>
	public partial class PlayMediaInfo
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
		public bool Add(KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PlayMediaInfo(");
			strSql.Append("PlayMediaID,PlayMediaName,PlayReaderID,PlayTimeZone,PlayLoop,PlayType1,PlayMediaGroupID1,PlayType2,PlayMediaGroupID2,PlayType3,PlayMediaGroupID3,PlayType4,PlayMediaGroupID4,PlayType5,PlayMediaGroupID5,PlayType6,PlayMediaGroupID6)");
			strSql.Append(" values (");
			strSql.Append("@PlayMediaID,@PlayMediaName,@PlayReaderID,@PlayTimeZone,@PlayLoop,@PlayType1,@PlayMediaGroupID1,@PlayType2,@PlayMediaGroupID2,@PlayType3,@PlayMediaGroupID3,@PlayType4,@PlayMediaGroupID4,@PlayType5,@PlayMediaGroupID5,@PlayType6,@PlayMediaGroupID6)");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlayReaderID", SqlDbType.Int,4),
					new SqlParameter("@PlayTimeZone", SqlDbType.Int,4),
					new SqlParameter("@PlayLoop", SqlDbType.Bit,1),
					new SqlParameter("@PlayType1", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID1", SqlDbType.Int,4),
					new SqlParameter("@PlayType2", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID2", SqlDbType.Int,4),
					new SqlParameter("@PlayType3", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID3", SqlDbType.Int,4),
					new SqlParameter("@PlayType4", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID4", SqlDbType.Int,4),
					new SqlParameter("@PlayType5", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID5", SqlDbType.Int,4),
					new SqlParameter("@PlayType6", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID6", SqlDbType.Int,4)};
			parameters[0].Value = model.PlayMediaID;
			parameters[1].Value = model.PlayMediaName;
			parameters[2].Value = model.PlayReaderID;
			parameters[3].Value = model.PlayTimeZone;
			parameters[4].Value = model.PlayLoop;
			parameters[5].Value = model.PlayType1;
			parameters[6].Value = model.PlayMediaGroupID1;
			parameters[7].Value = model.PlayType2;
			parameters[8].Value = model.PlayMediaGroupID2;
			parameters[9].Value = model.PlayType3;
			parameters[10].Value = model.PlayMediaGroupID3;
			parameters[11].Value = model.PlayType4;
			parameters[12].Value = model.PlayMediaGroupID4;
			parameters[13].Value = model.PlayType5;
			parameters[14].Value = model.PlayMediaGroupID5;
			parameters[15].Value = model.PlayType6;
			parameters[16].Value = model.PlayMediaGroupID6;

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
		public bool Update(KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PlayMediaInfo set ");
			strSql.Append("PlayMediaName=@PlayMediaName,");
			strSql.Append("PlayReaderID=@PlayReaderID,");
			strSql.Append("PlayTimeZone=@PlayTimeZone,");
			strSql.Append("PlayLoop=@PlayLoop,");
			strSql.Append("PlayType1=@PlayType1,");
			strSql.Append("PlayMediaGroupID1=@PlayMediaGroupID1,");
			strSql.Append("PlayType2=@PlayType2,");
			strSql.Append("PlayMediaGroupID2=@PlayMediaGroupID2,");
			strSql.Append("PlayType3=@PlayType3,");
			strSql.Append("PlayMediaGroupID3=@PlayMediaGroupID3,");
			strSql.Append("PlayType4=@PlayType4,");
			strSql.Append("PlayMediaGroupID4=@PlayMediaGroupID4,");
			strSql.Append("PlayType5=@PlayType5,");
			strSql.Append("PlayMediaGroupID5=@PlayMediaGroupID5,");
			strSql.Append("PlayType6=@PlayType6,");
			strSql.Append("PlayMediaGroupID6=@PlayMediaGroupID6");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlayReaderID", SqlDbType.Int,4),
					new SqlParameter("@PlayTimeZone", SqlDbType.Int,4),
					new SqlParameter("@PlayLoop", SqlDbType.Bit,1),
					new SqlParameter("@PlayType1", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID1", SqlDbType.Int,4),
					new SqlParameter("@PlayType2", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID2", SqlDbType.Int,4),
					new SqlParameter("@PlayType3", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID3", SqlDbType.Int,4),
					new SqlParameter("@PlayType4", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID4", SqlDbType.Int,4),
					new SqlParameter("@PlayType5", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID5", SqlDbType.Int,4),
					new SqlParameter("@PlayType6", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaGroupID6", SqlDbType.Int,4),
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)};
			parameters[0].Value = model.PlayMediaName;
			parameters[1].Value = model.PlayReaderID;
			parameters[2].Value = model.PlayTimeZone;
			parameters[3].Value = model.PlayLoop;
			parameters[4].Value = model.PlayType1;
			parameters[5].Value = model.PlayMediaGroupID1;
			parameters[6].Value = model.PlayType2;
			parameters[7].Value = model.PlayMediaGroupID2;
			parameters[8].Value = model.PlayType3;
			parameters[9].Value = model.PlayMediaGroupID3;
			parameters[10].Value = model.PlayType4;
			parameters[11].Value = model.PlayMediaGroupID4;
			parameters[12].Value = model.PlayType5;
			parameters[13].Value = model.PlayMediaGroupID5;
			parameters[14].Value = model.PlayType6;
			parameters[15].Value = model.PlayMediaGroupID6;
			parameters[16].Value = model.PlayMediaID;

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
		public KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo GetModel(int PlayMediaID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PlayMediaID,PlayMediaName,PlayReaderID,PlayTimeZone,PlayLoop,PlayType1,PlayMediaGroupID1,PlayType2,PlayMediaGroupID2,PlayType3,PlayMediaGroupID3,PlayType4,PlayMediaGroupID4,PlayType5,PlayMediaGroupID5,PlayType6,PlayMediaGroupID6 from PlayMediaInfo ");
			strSql.Append(" where PlayMediaID=@PlayMediaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlayMediaID", SqlDbType.Int,4)			};
			parameters[0].Value = PlayMediaID;

			KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo model=new KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo();
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
		public KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo model=new KryptonAccessController.AccessSdkDataBase.Model.PlayMediaInfo();
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
				if(row["PlayTimeZone"]!=null && row["PlayTimeZone"].ToString()!="")
				{
					model.PlayTimeZone=int.Parse(row["PlayTimeZone"].ToString());
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
				if(row["PlayType1"]!=null && row["PlayType1"].ToString()!="")
				{
					model.PlayType1=int.Parse(row["PlayType1"].ToString());
				}
				if(row["PlayMediaGroupID1"]!=null && row["PlayMediaGroupID1"].ToString()!="")
				{
					model.PlayMediaGroupID1=int.Parse(row["PlayMediaGroupID1"].ToString());
				}
				if(row["PlayType2"]!=null && row["PlayType2"].ToString()!="")
				{
					model.PlayType2=int.Parse(row["PlayType2"].ToString());
				}
				if(row["PlayMediaGroupID2"]!=null && row["PlayMediaGroupID2"].ToString()!="")
				{
					model.PlayMediaGroupID2=int.Parse(row["PlayMediaGroupID2"].ToString());
				}
				if(row["PlayType3"]!=null && row["PlayType3"].ToString()!="")
				{
					model.PlayType3=int.Parse(row["PlayType3"].ToString());
				}
				if(row["PlayMediaGroupID3"]!=null && row["PlayMediaGroupID3"].ToString()!="")
				{
					model.PlayMediaGroupID3=int.Parse(row["PlayMediaGroupID3"].ToString());
				}
				if(row["PlayType4"]!=null && row["PlayType4"].ToString()!="")
				{
					model.PlayType4=int.Parse(row["PlayType4"].ToString());
				}
				if(row["PlayMediaGroupID4"]!=null && row["PlayMediaGroupID4"].ToString()!="")
				{
					model.PlayMediaGroupID4=int.Parse(row["PlayMediaGroupID4"].ToString());
				}
				if(row["PlayType5"]!=null && row["PlayType5"].ToString()!="")
				{
					model.PlayType5=int.Parse(row["PlayType5"].ToString());
				}
				if(row["PlayMediaGroupID5"]!=null && row["PlayMediaGroupID5"].ToString()!="")
				{
					model.PlayMediaGroupID5=int.Parse(row["PlayMediaGroupID5"].ToString());
				}
				if(row["PlayType6"]!=null && row["PlayType6"].ToString()!="")
				{
					model.PlayType6=int.Parse(row["PlayType6"].ToString());
				}
				if(row["PlayMediaGroupID6"]!=null && row["PlayMediaGroupID6"].ToString()!="")
				{
					model.PlayMediaGroupID6=int.Parse(row["PlayMediaGroupID6"].ToString());
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
			strSql.Append("select PlayMediaID,PlayMediaName,PlayReaderID,PlayTimeZone,PlayLoop,PlayType1,PlayMediaGroupID1,PlayType2,PlayMediaGroupID2,PlayType3,PlayMediaGroupID3,PlayType4,PlayMediaGroupID4,PlayType5,PlayMediaGroupID5,PlayType6,PlayMediaGroupID6 ");
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
			strSql.Append(" PlayMediaID,PlayMediaName,PlayReaderID,PlayTimeZone,PlayLoop,PlayType1,PlayMediaGroupID1,PlayType2,PlayMediaGroupID2,PlayType3,PlayMediaGroupID3,PlayType4,PlayMediaGroupID4,PlayType5,PlayMediaGroupID5,PlayType6,PlayMediaGroupID6 ");
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

