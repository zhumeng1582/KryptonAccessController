/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfoInLAN.cs
*
* 功 能： N/A
* 类 名： ControllerInfoInLAN
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:20   N/A    初版
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
	/// 数据访问类:ControllerInfoInLAN
	/// </summary>
	public partial class ControllerInfoInLAN:IControllerInfoInLAN
	{
		public ControllerInfoInLAN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ControllerID", "ControllerInfoInLAN"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ControllerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ControllerInfoInLAN");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4)			};
			parameters[0].Value = ControllerID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ControllerInfoInLAN(");
			strSql.Append("ControllerID,ControllerName,ControllerType,ComunicateType,ControllerIP,ControllerPort,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl)");
			strSql.Append(" values (");
			strSql.Append("@ControllerID,@ControllerName,@ControllerType,@ComunicateType,@ControllerIP,@ControllerPort,@ControllerAddr485,@ControllerBaudrate,@ControllerDataBits,@ControllerStopBits,@ControllerParityCheck,@ControllerFlowControl)");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4),
					new SqlParameter("@ControllerName", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerType", SqlDbType.Int,4),
					new SqlParameter("@ComunicateType", SqlDbType.Int,4),
					new SqlParameter("@ControllerIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerPort", SqlDbType.Int,4),
					new SqlParameter("@ControllerAddr485", SqlDbType.Int,4),
					new SqlParameter("@ControllerBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ControllerDataBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerStopBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerFlowControl", SqlDbType.NVarChar,8)};
			parameters[0].Value = model.ControllerID;
			parameters[1].Value = model.ControllerName;
			parameters[2].Value = model.ControllerType;
			parameters[3].Value = model.ComunicateType;
			parameters[4].Value = model.ControllerIP;
			parameters[5].Value = model.ControllerPort;
			parameters[6].Value = model.ControllerAddr485;
			parameters[7].Value = model.ControllerBaudrate;
			parameters[8].Value = model.ControllerDataBits;
			parameters[9].Value = model.ControllerStopBits;
			parameters[10].Value = model.ControllerParityCheck;
			parameters[11].Value = model.ControllerFlowControl;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ControllerInfoInLAN set ");
			strSql.Append("ControllerName=@ControllerName,");
			strSql.Append("ControllerType=@ControllerType,");
			strSql.Append("ComunicateType=@ComunicateType,");
			strSql.Append("ControllerIP=@ControllerIP,");
			strSql.Append("ControllerPort=@ControllerPort,");
			strSql.Append("ControllerAddr485=@ControllerAddr485,");
			strSql.Append("ControllerBaudrate=@ControllerBaudrate,");
			strSql.Append("ControllerDataBits=@ControllerDataBits,");
			strSql.Append("ControllerStopBits=@ControllerStopBits,");
			strSql.Append("ControllerParityCheck=@ControllerParityCheck,");
			strSql.Append("ControllerFlowControl=@ControllerFlowControl");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerName", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerType", SqlDbType.Int,4),
					new SqlParameter("@ComunicateType", SqlDbType.Int,4),
					new SqlParameter("@ControllerIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerPort", SqlDbType.Int,4),
					new SqlParameter("@ControllerAddr485", SqlDbType.Int,4),
					new SqlParameter("@ControllerBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ControllerDataBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerStopBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerFlowControl", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerID", SqlDbType.Int,4)};
			parameters[0].Value = model.ControllerName;
			parameters[1].Value = model.ControllerType;
			parameters[2].Value = model.ComunicateType;
			parameters[3].Value = model.ControllerIP;
			parameters[4].Value = model.ControllerPort;
			parameters[5].Value = model.ControllerAddr485;
			parameters[6].Value = model.ControllerBaudrate;
			parameters[7].Value = model.ControllerDataBits;
			parameters[8].Value = model.ControllerStopBits;
			parameters[9].Value = model.ControllerParityCheck;
			parameters[10].Value = model.ControllerFlowControl;
			parameters[11].Value = model.ControllerID;

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
		public bool Delete(int ControllerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ControllerInfoInLAN ");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4)			};
			parameters[0].Value = ControllerID;

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
		public bool DeleteList(string ControllerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ControllerInfoInLAN ");
			strSql.Append(" where ControllerID in ("+ControllerIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN GetModel(int ControllerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ControllerID,ControllerName,ControllerType,ComunicateType,ControllerIP,ControllerPort,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl from ControllerInfoInLAN ");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4)			};
			parameters[0].Value = ControllerID;

			KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN model=new KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN();
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
		public KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN model=new KryptonAccessController.AccessDataBase.Model.ControllerInfoInLAN();
			if (row != null)
			{
				if(row["ControllerID"]!=null && row["ControllerID"].ToString()!="")
				{
					model.ControllerID=int.Parse(row["ControllerID"].ToString());
				}
				if(row["ControllerName"]!=null)
				{
					model.ControllerName=row["ControllerName"].ToString();
				}
				if(row["ControllerType"]!=null && row["ControllerType"].ToString()!="")
				{
					model.ControllerType=int.Parse(row["ControllerType"].ToString());
				}
				if(row["ComunicateType"]!=null && row["ComunicateType"].ToString()!="")
				{
					model.ComunicateType=int.Parse(row["ComunicateType"].ToString());
				}
				if(row["ControllerIP"]!=null)
				{
					model.ControllerIP=row["ControllerIP"].ToString();
				}
				if(row["ControllerPort"]!=null && row["ControllerPort"].ToString()!="")
				{
					model.ControllerPort=int.Parse(row["ControllerPort"].ToString());
				}
				if(row["ControllerAddr485"]!=null && row["ControllerAddr485"].ToString()!="")
				{
					model.ControllerAddr485=int.Parse(row["ControllerAddr485"].ToString());
				}
				if(row["ControllerBaudrate"]!=null && row["ControllerBaudrate"].ToString()!="")
				{
					model.ControllerBaudrate=int.Parse(row["ControllerBaudrate"].ToString());
				}
				if(row["ControllerDataBits"]!=null && row["ControllerDataBits"].ToString()!="")
				{
					model.ControllerDataBits=int.Parse(row["ControllerDataBits"].ToString());
				}
				if(row["ControllerStopBits"]!=null && row["ControllerStopBits"].ToString()!="")
				{
					model.ControllerStopBits=int.Parse(row["ControllerStopBits"].ToString());
				}
				if(row["ControllerParityCheck"]!=null)
				{
					model.ControllerParityCheck=row["ControllerParityCheck"].ToString();
				}
				if(row["ControllerFlowControl"]!=null)
				{
					model.ControllerFlowControl=row["ControllerFlowControl"].ToString();
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
			strSql.Append("select ControllerID,ControllerName,ControllerType,ComunicateType,ControllerIP,ControllerPort,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl ");
			strSql.Append(" FROM ControllerInfoInLAN ");
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
			strSql.Append(" ControllerID,ControllerName,ControllerType,ComunicateType,ControllerIP,ControllerPort,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl ");
			strSql.Append(" FROM ControllerInfoInLAN ");
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
			strSql.Append("select count(1) FROM ControllerInfoInLAN ");
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
				strSql.Append("order by T.ControllerID desc");
			}
			strSql.Append(")AS Row, T.*  from ControllerInfoInLAN T ");
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
			parameters[0].Value = "ControllerInfoInLAN";
			parameters[1].Value = "ControllerID";
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

