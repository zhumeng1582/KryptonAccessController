/**  版本信息模板在安装目录下，可自行修改。
* InterLock.cs
*
* 功 能： N/A
* 类 名： InterLock
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:26   N/A    初版
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
	/// 数据访问类:InterLock
	/// </summary>
	public partial class InterLock:IInterLock
	{
		public InterLock()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InterLockID", "InterLock"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InterLockID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InterLock");
			strSql.Append(" where InterLockID=@InterLockID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InterLockID", SqlDbType.Int,4)			};
			parameters[0].Value = InterLockID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.InterLock model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InterLock(");
			strSql.Append("InterLockID,InterLockEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2)");
			strSql.Append(" values (");
			strSql.Append("@InterLockID,@InterLockEnable,@ControlerInfoInLANID1,@DoorUnitID1,@ControlerInfoInLANID2,@DoorUnitID2)");
			SqlParameter[] parameters = {
					new SqlParameter("@InterLockID", SqlDbType.Int,4),
					new SqlParameter("@InterLockEnable", SqlDbType.Bit,1),
					new SqlParameter("@ControlerInfoInLANID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4)};
			parameters[0].Value = model.InterLockID;
			parameters[1].Value = model.InterLockEnable;
			parameters[2].Value = model.ControlerInfoInLANID1;
			parameters[3].Value = model.DoorUnitID1;
			parameters[4].Value = model.ControlerInfoInLANID2;
			parameters[5].Value = model.DoorUnitID2;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.InterLock model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InterLock set ");
			strSql.Append("InterLockEnable=@InterLockEnable,");
			strSql.Append("ControlerInfoInLANID1=@ControlerInfoInLANID1,");
			strSql.Append("DoorUnitID1=@DoorUnitID1,");
			strSql.Append("ControlerInfoInLANID2=@ControlerInfoInLANID2,");
			strSql.Append("DoorUnitID2=@DoorUnitID2");
			strSql.Append(" where InterLockID=@InterLockID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InterLockEnable", SqlDbType.Bit,1),
					new SqlParameter("@ControlerInfoInLANID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@ControlerInfoInLANID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4),
					new SqlParameter("@InterLockID", SqlDbType.Int,4)};
			parameters[0].Value = model.InterLockEnable;
			parameters[1].Value = model.ControlerInfoInLANID1;
			parameters[2].Value = model.DoorUnitID1;
			parameters[3].Value = model.ControlerInfoInLANID2;
			parameters[4].Value = model.DoorUnitID2;
			parameters[5].Value = model.InterLockID;

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
		public bool Delete(int InterLockID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InterLock ");
			strSql.Append(" where InterLockID=@InterLockID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InterLockID", SqlDbType.Int,4)			};
			parameters[0].Value = InterLockID;

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
		public bool DeleteList(string InterLockIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InterLock ");
			strSql.Append(" where InterLockID in ("+InterLockIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.InterLock GetModel(int InterLockID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InterLockID,InterLockEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2 from InterLock ");
			strSql.Append(" where InterLockID=@InterLockID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InterLockID", SqlDbType.Int,4)			};
			parameters[0].Value = InterLockID;

			KryptonAccessController.AccessDataBase.Model.InterLock model=new KryptonAccessController.AccessDataBase.Model.InterLock();
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
		public KryptonAccessController.AccessDataBase.Model.InterLock DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.InterLock model=new KryptonAccessController.AccessDataBase.Model.InterLock();
			if (row != null)
			{
				if(row["InterLockID"]!=null && row["InterLockID"].ToString()!="")
				{
					model.InterLockID=int.Parse(row["InterLockID"].ToString());
				}
				if(row["InterLockEnable"]!=null && row["InterLockEnable"].ToString()!="")
				{
					if((row["InterLockEnable"].ToString()=="1")||(row["InterLockEnable"].ToString().ToLower()=="true"))
					{
						model.InterLockEnable=true;
					}
					else
					{
						model.InterLockEnable=false;
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select InterLockID,InterLockEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2 ");
			strSql.Append(" FROM InterLock ");
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
			strSql.Append(" InterLockID,InterLockEnable,ControlerInfoInLANID1,DoorUnitID1,ControlerInfoInLANID2,DoorUnitID2 ");
			strSql.Append(" FROM InterLock ");
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
			strSql.Append("select count(1) FROM InterLock ");
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
				strSql.Append("order by T.InterLockID desc");
			}
			strSql.Append(")AS Row, T.*  from InterLock T ");
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
			parameters[0].Value = "InterLock";
			parameters[1].Value = "InterLockID";
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

