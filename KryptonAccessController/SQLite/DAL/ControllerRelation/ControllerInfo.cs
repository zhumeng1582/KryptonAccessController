/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfo.cs
*
* 功 能： N/A
* 类 名： ControllerInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:50   N/A    初版
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
namespace KryptonAccessController.SQLite.DAL.ControllerRelation
{
	/// <summary>
	/// 数据访问类:ControllerInfo
	/// </summary>
	public partial class ControllerInfo
	{
		public ControllerInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ControllerID", "ControllerInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ControllerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ControllerInfo");
			strSql.Append(" where ControllerID=@ControllerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ControllerID", DbType.Int32,4)			};
			parameters[0].Value = ControllerID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ControllerInfo(");
			strSql.Append("ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,DoorUnitCounts,ExpansionBoardCounts)");
			strSql.Append(" values (");
			strSql.Append("@ControllerID,@ControllerType,@ControllerName,@ControllerLocation,@EncryptionType,@CommunicateType,@ControllerVersion,@ControllerMAC,@ControllerIP,@ControllerSubnetMask,@ControllerGateway,@ControllerPort,@ControllerDNS,@ControllerBUDNS,@ControllerAddr485,@ControllerBaudrate,@ControllerDataBits,@ControllerStopBits,@ControllerParityCheck,@ControllerFlowControl,@ControllerSAM,@ControllerSAMType,@DoorUnitCounts,@ExpansionBoardCounts)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ControllerID", DbType.Int32,4),
					new SQLiteParameter("@ControllerType", DbType.Int32,4),
					new SQLiteParameter("@ControllerName", DbType.String),
					new SQLiteParameter("@ControllerLocation", DbType.String),
					new SQLiteParameter("@EncryptionType", DbType.Int32,4),
					new SQLiteParameter("@CommunicateType", DbType.Int32,4),
					new SQLiteParameter("@ControllerVersion", DbType.String),
					new SQLiteParameter("@ControllerMAC", DbType.String),
					new SQLiteParameter("@ControllerIP", DbType.String),
					new SQLiteParameter("@ControllerSubnetMask", DbType.String),
					new SQLiteParameter("@ControllerGateway", DbType.String),
					new SQLiteParameter("@ControllerPort", DbType.Int32,4),
					new SQLiteParameter("@ControllerDNS", DbType.String),
					new SQLiteParameter("@ControllerBUDNS", DbType.String),
					new SQLiteParameter("@ControllerAddr485", DbType.Int32,4),
					new SQLiteParameter("@ControllerBaudrate", DbType.Int32,4),
					new SQLiteParameter("@ControllerDataBits", DbType.Int32,4),
					new SQLiteParameter("@ControllerStopBits", DbType.Int32,4),
					new SQLiteParameter("@ControllerParityCheck", DbType.String),
					new SQLiteParameter("@ControllerFlowControl", DbType.String),
					new SQLiteParameter("@ControllerSAM", DbType.Int32,4),
					new SQLiteParameter("@ControllerSAMType", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitCounts", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardCounts", DbType.Int32,4)};
			parameters[0].Value = model.ControllerID;
			parameters[1].Value = model.ControllerType;
			parameters[2].Value = model.ControllerName;
			parameters[3].Value = model.ControllerLocation;
			parameters[4].Value = model.EncryptionType;
			parameters[5].Value = model.CommunicateType;
			parameters[6].Value = model.ControllerVersion;
			parameters[7].Value = model.ControllerMAC;
			parameters[8].Value = model.ControllerIP;
			parameters[9].Value = model.ControllerSubnetMask;
			parameters[10].Value = model.ControllerGateway;
			parameters[11].Value = model.ControllerPort;
			parameters[12].Value = model.ControllerDNS;
			parameters[13].Value = model.ControllerBUDNS;
			parameters[14].Value = model.ControllerAddr485;
			parameters[15].Value = model.ControllerBaudrate;
			parameters[16].Value = model.ControllerDataBits;
			parameters[17].Value = model.ControllerStopBits;
			parameters[18].Value = model.ControllerParityCheck;
			parameters[19].Value = model.ControllerFlowControl;
			parameters[20].Value = model.ControllerSAM;
			parameters[21].Value = model.ControllerSAMType;
			parameters[22].Value = model.DoorUnitCounts;
			parameters[23].Value = model.ExpansionBoardCounts;

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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ControllerInfo set ");
			strSql.Append("ControllerType=@ControllerType,");
			strSql.Append("ControllerName=@ControllerName,");
			strSql.Append("ControllerLocation=@ControllerLocation,");
			strSql.Append("EncryptionType=@EncryptionType,");
			strSql.Append("CommunicateType=@CommunicateType,");
			strSql.Append("ControllerVersion=@ControllerVersion,");
			strSql.Append("ControllerMAC=@ControllerMAC,");
			strSql.Append("ControllerIP=@ControllerIP,");
			strSql.Append("ControllerSubnetMask=@ControllerSubnetMask,");
			strSql.Append("ControllerGateway=@ControllerGateway,");
			strSql.Append("ControllerPort=@ControllerPort,");
			strSql.Append("ControllerDNS=@ControllerDNS,");
			strSql.Append("ControllerBUDNS=@ControllerBUDNS,");
			strSql.Append("ControllerAddr485=@ControllerAddr485,");
			strSql.Append("ControllerBaudrate=@ControllerBaudrate,");
			strSql.Append("ControllerDataBits=@ControllerDataBits,");
			strSql.Append("ControllerStopBits=@ControllerStopBits,");
			strSql.Append("ControllerParityCheck=@ControllerParityCheck,");
			strSql.Append("ControllerFlowControl=@ControllerFlowControl,");
			strSql.Append("ControllerSAM=@ControllerSAM,");
			strSql.Append("ControllerSAMType=@ControllerSAMType,");
			strSql.Append("DoorUnitCounts=@DoorUnitCounts,");
			strSql.Append("ExpansionBoardCounts=@ExpansionBoardCounts");
			strSql.Append(" where ControllerID=@ControllerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ControllerType", DbType.Int32,4),
					new SQLiteParameter("@ControllerName", DbType.String),
					new SQLiteParameter("@ControllerLocation", DbType.String),
					new SQLiteParameter("@EncryptionType", DbType.Int32,4),
					new SQLiteParameter("@CommunicateType", DbType.Int32,4),
					new SQLiteParameter("@ControllerVersion", DbType.String),
					new SQLiteParameter("@ControllerMAC", DbType.String),
					new SQLiteParameter("@ControllerIP", DbType.String),
					new SQLiteParameter("@ControllerSubnetMask", DbType.String),
					new SQLiteParameter("@ControllerGateway", DbType.String),
					new SQLiteParameter("@ControllerPort", DbType.Int32,4),
					new SQLiteParameter("@ControllerDNS", DbType.String),
					new SQLiteParameter("@ControllerBUDNS", DbType.String),
					new SQLiteParameter("@ControllerAddr485", DbType.Int32,4),
					new SQLiteParameter("@ControllerBaudrate", DbType.Int32,4),
					new SQLiteParameter("@ControllerDataBits", DbType.Int32,4),
					new SQLiteParameter("@ControllerStopBits", DbType.Int32,4),
					new SQLiteParameter("@ControllerParityCheck", DbType.String),
					new SQLiteParameter("@ControllerFlowControl", DbType.String),
					new SQLiteParameter("@ControllerSAM", DbType.Int32,4),
					new SQLiteParameter("@ControllerSAMType", DbType.Int32,4),
					new SQLiteParameter("@DoorUnitCounts", DbType.Int32,4),
					new SQLiteParameter("@ExpansionBoardCounts", DbType.Int32,4),
					new SQLiteParameter("@ControllerID", DbType.Int32,4)};
			parameters[0].Value = model.ControllerType;
			parameters[1].Value = model.ControllerName;
			parameters[2].Value = model.ControllerLocation;
			parameters[3].Value = model.EncryptionType;
			parameters[4].Value = model.CommunicateType;
			parameters[5].Value = model.ControllerVersion;
			parameters[6].Value = model.ControllerMAC;
			parameters[7].Value = model.ControllerIP;
			parameters[8].Value = model.ControllerSubnetMask;
			parameters[9].Value = model.ControllerGateway;
			parameters[10].Value = model.ControllerPort;
			parameters[11].Value = model.ControllerDNS;
			parameters[12].Value = model.ControllerBUDNS;
			parameters[13].Value = model.ControllerAddr485;
			parameters[14].Value = model.ControllerBaudrate;
			parameters[15].Value = model.ControllerDataBits;
			parameters[16].Value = model.ControllerStopBits;
			parameters[17].Value = model.ControllerParityCheck;
			parameters[18].Value = model.ControllerFlowControl;
			parameters[19].Value = model.ControllerSAM;
			parameters[20].Value = model.ControllerSAMType;
			parameters[21].Value = model.DoorUnitCounts;
			parameters[22].Value = model.ExpansionBoardCounts;
			parameters[23].Value = model.ControllerID;

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
		public bool Delete(int ControllerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ControllerInfo ");
			strSql.Append(" where ControllerID=@ControllerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ControllerID", DbType.Int32,4)			};
			parameters[0].Value = ControllerID;

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
		public bool DeleteList(string ControllerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ControllerInfo ");
			strSql.Append(" where ControllerID in ("+ControllerIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo GetModel(int ControllerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,DoorUnitCounts,ExpansionBoardCounts from ControllerInfo ");
			strSql.Append(" where ControllerID=@ControllerID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ControllerID", DbType.Int32,4)			};
			parameters[0].Value = ControllerID;

			KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ControllerInfo();
			if (row != null)
			{
				if(row["ControllerID"]!=null && row["ControllerID"].ToString()!="")
				{
					model.ControllerID=int.Parse(row["ControllerID"].ToString());
				}
				if(row["ControllerType"]!=null && row["ControllerType"].ToString()!="")
				{
					model.ControllerType=int.Parse(row["ControllerType"].ToString());
				}
				if(row["ControllerName"]!=null)
				{
					model.ControllerName=row["ControllerName"].ToString();
				}
				if(row["ControllerLocation"]!=null)
				{
					model.ControllerLocation=row["ControllerLocation"].ToString();
				}
				if(row["EncryptionType"]!=null && row["EncryptionType"].ToString()!="")
				{
					model.EncryptionType=int.Parse(row["EncryptionType"].ToString());
				}
				if(row["CommunicateType"]!=null && row["CommunicateType"].ToString()!="")
				{
					model.CommunicateType=int.Parse(row["CommunicateType"].ToString());
				}
				if(row["ControllerVersion"]!=null)
				{
					model.ControllerVersion=row["ControllerVersion"].ToString();
				}
				if(row["ControllerMAC"]!=null)
				{
					model.ControllerMAC=row["ControllerMAC"].ToString();
				}
				if(row["ControllerIP"]!=null)
				{
					model.ControllerIP=row["ControllerIP"].ToString();
				}
				if(row["ControllerSubnetMask"]!=null)
				{
					model.ControllerSubnetMask=row["ControllerSubnetMask"].ToString();
				}
				if(row["ControllerGateway"]!=null)
				{
					model.ControllerGateway=row["ControllerGateway"].ToString();
				}
				if(row["ControllerPort"]!=null && row["ControllerPort"].ToString()!="")
				{
					model.ControllerPort=int.Parse(row["ControllerPort"].ToString());
				}
				if(row["ControllerDNS"]!=null)
				{
					model.ControllerDNS=row["ControllerDNS"].ToString();
				}
				if(row["ControllerBUDNS"]!=null)
				{
					model.ControllerBUDNS=row["ControllerBUDNS"].ToString();
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
				if(row["ControllerSAM"]!=null && row["ControllerSAM"].ToString()!="")
				{
					model.ControllerSAM=int.Parse(row["ControllerSAM"].ToString());
				}
				if(row["ControllerSAMType"]!=null && row["ControllerSAMType"].ToString()!="")
				{
					model.ControllerSAMType=int.Parse(row["ControllerSAMType"].ToString());
				}
				if(row["DoorUnitCounts"]!=null && row["DoorUnitCounts"].ToString()!="")
				{
					model.DoorUnitCounts=int.Parse(row["DoorUnitCounts"].ToString());
				}
				if(row["ExpansionBoardCounts"]!=null && row["ExpansionBoardCounts"].ToString()!="")
				{
					model.ExpansionBoardCounts=int.Parse(row["ExpansionBoardCounts"].ToString());
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
			strSql.Append("select ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerStopBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,DoorUnitCounts,ExpansionBoardCounts ");
			strSql.Append(" FROM ControllerInfo ");
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
			strSql.Append("select count(1) FROM ControllerInfo ");
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
			strSql.Append(")AS Row, T.*  from ControllerInfo T ");
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
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "ControllerInfo";
			parameters[1].Value = "ControllerID";
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

