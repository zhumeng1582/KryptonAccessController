/**  版本信息模板在安装目录下，可自行修改。
* ReaderInfo.cs
*
* 功 能： N/A
* 类 名： ReaderInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:51   N/A    初版
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
	/// 数据访问类:ReaderInfo
	/// </summary>
	public partial class ReaderInfo
	{
		public ReaderInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ReaderID", "ReaderInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderInfo");
			strSql.Append(" where ReaderID=@ReaderID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderID", DbType.Int32,4)			};
			parameters[0].Value = ReaderID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderInfo(");
			strSql.Append("ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SupervisedMode,PINIdentify,ReaderPIN,DuressCode,ArmPassword,UnarmPassword,CommunicateType,ReaderMAC,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID)");
			strSql.Append(" values (");
			strSql.Append("@ReaderID,@ReaderPointID,@ReaderType,@ReaderName,@ReaderLocation,@ReaderVersion,@ReaderSAM,@ReaderSAMType,@CardType,@CardReadArea,@FingerEnable,@SercurityAccessLevel,@SupervisedMode,@PINIdentify,@ReaderPIN,@DuressCode,@ArmPassword,@UnarmPassword,@CommunicateType,@ReaderMAC,@ReaderIP,@ReaderSubnet,@ReaderGateway,@ReaderPort,@ReaderDNS,@ReaderBuDNS,@ReaderAddr483,@ReaderBaudrate,@ReaderDataBits,@ReaderStopBits,@ReaderParityCheck,@ReaderFlowControl,@ReaderUsage,@ReadTimeAccessID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderID", DbType.Int32,4),
					new SQLiteParameter("@ReaderPointID", DbType.Int32,4),
					new SQLiteParameter("@ReaderType", DbType.String),
					new SQLiteParameter("@ReaderName", DbType.String),
					new SQLiteParameter("@ReaderLocation", DbType.String),
					new SQLiteParameter("@ReaderVersion", DbType.String),
					new SQLiteParameter("@ReaderSAM", DbType.Int32,4),
					new SQLiteParameter("@ReaderSAMType", DbType.Int32,4),
					new SQLiteParameter("@CardType", DbType.Int32,4),
					new SQLiteParameter("@CardReadArea", DbType.Int32,4),
					new SQLiteParameter("@FingerEnable", DbType.Boolean,1),
					new SQLiteParameter("@SercurityAccessLevel", DbType.Int32,4),
					new SQLiteParameter("@SupervisedMode", DbType.Int32,4),
					new SQLiteParameter("@PINIdentify", DbType.Int32,4),
					new SQLiteParameter("@ReaderPIN", DbType.String),
					new SQLiteParameter("@DuressCode", DbType.String),
					new SQLiteParameter("@ArmPassword", DbType.String),
					new SQLiteParameter("@UnarmPassword", DbType.String),
					new SQLiteParameter("@CommunicateType", DbType.Int32,4),
					new SQLiteParameter("@ReaderMAC", DbType.String),
					new SQLiteParameter("@ReaderIP", DbType.String),
					new SQLiteParameter("@ReaderSubnet", DbType.String),
					new SQLiteParameter("@ReaderGateway", DbType.String),
					new SQLiteParameter("@ReaderPort", DbType.Int32,4),
					new SQLiteParameter("@ReaderDNS", DbType.String),
					new SQLiteParameter("@ReaderBuDNS", DbType.String),
					new SQLiteParameter("@ReaderAddr483", DbType.Int32,4),
					new SQLiteParameter("@ReaderBaudrate", DbType.Int32,4),
					new SQLiteParameter("@ReaderDataBits", DbType.Int32,4),
					new SQLiteParameter("@ReaderStopBits", DbType.Int32,4),
					new SQLiteParameter("@ReaderParityCheck", DbType.String),
					new SQLiteParameter("@ReaderFlowControl", DbType.String),
					new SQLiteParameter("@ReaderUsage", DbType.Int32,4),
					new SQLiteParameter("@ReadTimeAccessID", DbType.Int32,4)};
			parameters[0].Value = model.ReaderID;
			parameters[1].Value = model.ReaderPointID;
			parameters[2].Value = model.ReaderType;
			parameters[3].Value = model.ReaderName;
			parameters[4].Value = model.ReaderLocation;
			parameters[5].Value = model.ReaderVersion;
			parameters[6].Value = model.ReaderSAM;
			parameters[7].Value = model.ReaderSAMType;
			parameters[8].Value = model.CardType;
			parameters[9].Value = model.CardReadArea;
			parameters[10].Value = model.FingerEnable;
			parameters[11].Value = model.SercurityAccessLevel;
			parameters[12].Value = model.SupervisedMode;
			parameters[13].Value = model.PINIdentify;
			parameters[14].Value = model.ReaderPIN;
			parameters[15].Value = model.DuressCode;
			parameters[16].Value = model.ArmPassword;
			parameters[17].Value = model.UnarmPassword;
			parameters[18].Value = model.CommunicateType;
			parameters[19].Value = model.ReaderMAC;
			parameters[20].Value = model.ReaderIP;
			parameters[21].Value = model.ReaderSubnet;
			parameters[22].Value = model.ReaderGateway;
			parameters[23].Value = model.ReaderPort;
			parameters[24].Value = model.ReaderDNS;
			parameters[25].Value = model.ReaderBuDNS;
			parameters[26].Value = model.ReaderAddr483;
			parameters[27].Value = model.ReaderBaudrate;
			parameters[28].Value = model.ReaderDataBits;
			parameters[29].Value = model.ReaderStopBits;
			parameters[30].Value = model.ReaderParityCheck;
			parameters[31].Value = model.ReaderFlowControl;
			parameters[32].Value = model.ReaderUsage;
			parameters[33].Value = model.ReadTimeAccessID;

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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReaderInfo set ");
			strSql.Append("ReaderPointID=@ReaderPointID,");
			strSql.Append("ReaderType=@ReaderType,");
			strSql.Append("ReaderName=@ReaderName,");
			strSql.Append("ReaderLocation=@ReaderLocation,");
			strSql.Append("ReaderVersion=@ReaderVersion,");
			strSql.Append("ReaderSAM=@ReaderSAM,");
			strSql.Append("ReaderSAMType=@ReaderSAMType,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("CardReadArea=@CardReadArea,");
			strSql.Append("FingerEnable=@FingerEnable,");
			strSql.Append("SercurityAccessLevel=@SercurityAccessLevel,");
			strSql.Append("SupervisedMode=@SupervisedMode,");
			strSql.Append("PINIdentify=@PINIdentify,");
			strSql.Append("ReaderPIN=@ReaderPIN,");
			strSql.Append("DuressCode=@DuressCode,");
			strSql.Append("ArmPassword=@ArmPassword,");
			strSql.Append("UnarmPassword=@UnarmPassword,");
			strSql.Append("CommunicateType=@CommunicateType,");
			strSql.Append("ReaderMAC=@ReaderMAC,");
			strSql.Append("ReaderIP=@ReaderIP,");
			strSql.Append("ReaderSubnet=@ReaderSubnet,");
			strSql.Append("ReaderGateway=@ReaderGateway,");
			strSql.Append("ReaderPort=@ReaderPort,");
			strSql.Append("ReaderDNS=@ReaderDNS,");
			strSql.Append("ReaderBuDNS=@ReaderBuDNS,");
			strSql.Append("ReaderAddr483=@ReaderAddr483,");
			strSql.Append("ReaderBaudrate=@ReaderBaudrate,");
			strSql.Append("ReaderDataBits=@ReaderDataBits,");
			strSql.Append("ReaderStopBits=@ReaderStopBits,");
			strSql.Append("ReaderParityCheck=@ReaderParityCheck,");
			strSql.Append("ReaderFlowControl=@ReaderFlowControl,");
			strSql.Append("ReaderUsage=@ReaderUsage,");
			strSql.Append("ReadTimeAccessID=@ReadTimeAccessID");
			strSql.Append(" where ReaderID=@ReaderID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderPointID", DbType.Int32,4),
					new SQLiteParameter("@ReaderType", DbType.String),
					new SQLiteParameter("@ReaderName", DbType.String),
					new SQLiteParameter("@ReaderLocation", DbType.String),
					new SQLiteParameter("@ReaderVersion", DbType.String),
					new SQLiteParameter("@ReaderSAM", DbType.Int32,4),
					new SQLiteParameter("@ReaderSAMType", DbType.Int32,4),
					new SQLiteParameter("@CardType", DbType.Int32,4),
					new SQLiteParameter("@CardReadArea", DbType.Int32,4),
					new SQLiteParameter("@FingerEnable", DbType.Boolean,1),
					new SQLiteParameter("@SercurityAccessLevel", DbType.Int32,4),
					new SQLiteParameter("@SupervisedMode", DbType.Int32,4),
					new SQLiteParameter("@PINIdentify", DbType.Int32,4),
					new SQLiteParameter("@ReaderPIN", DbType.String),
					new SQLiteParameter("@DuressCode", DbType.String),
					new SQLiteParameter("@ArmPassword", DbType.String),
					new SQLiteParameter("@UnarmPassword", DbType.String),
					new SQLiteParameter("@CommunicateType", DbType.Int32,4),
					new SQLiteParameter("@ReaderMAC", DbType.String),
					new SQLiteParameter("@ReaderIP", DbType.String),
					new SQLiteParameter("@ReaderSubnet", DbType.String),
					new SQLiteParameter("@ReaderGateway", DbType.String),
					new SQLiteParameter("@ReaderPort", DbType.Int32,4),
					new SQLiteParameter("@ReaderDNS", DbType.String),
					new SQLiteParameter("@ReaderBuDNS", DbType.String),
					new SQLiteParameter("@ReaderAddr483", DbType.Int32,4),
					new SQLiteParameter("@ReaderBaudrate", DbType.Int32,4),
					new SQLiteParameter("@ReaderDataBits", DbType.Int32,4),
					new SQLiteParameter("@ReaderStopBits", DbType.Int32,4),
					new SQLiteParameter("@ReaderParityCheck", DbType.String),
					new SQLiteParameter("@ReaderFlowControl", DbType.String),
					new SQLiteParameter("@ReaderUsage", DbType.Int32,4),
					new SQLiteParameter("@ReadTimeAccessID", DbType.Int32,4),
					new SQLiteParameter("@ReaderID", DbType.Int32,4)};
			parameters[0].Value = model.ReaderPointID;
			parameters[1].Value = model.ReaderType;
			parameters[2].Value = model.ReaderName;
			parameters[3].Value = model.ReaderLocation;
			parameters[4].Value = model.ReaderVersion;
			parameters[5].Value = model.ReaderSAM;
			parameters[6].Value = model.ReaderSAMType;
			parameters[7].Value = model.CardType;
			parameters[8].Value = model.CardReadArea;
			parameters[9].Value = model.FingerEnable;
			parameters[10].Value = model.SercurityAccessLevel;
			parameters[11].Value = model.SupervisedMode;
			parameters[12].Value = model.PINIdentify;
			parameters[13].Value = model.ReaderPIN;
			parameters[14].Value = model.DuressCode;
			parameters[15].Value = model.ArmPassword;
			parameters[16].Value = model.UnarmPassword;
			parameters[17].Value = model.CommunicateType;
			parameters[18].Value = model.ReaderMAC;
			parameters[19].Value = model.ReaderIP;
			parameters[20].Value = model.ReaderSubnet;
			parameters[21].Value = model.ReaderGateway;
			parameters[22].Value = model.ReaderPort;
			parameters[23].Value = model.ReaderDNS;
			parameters[24].Value = model.ReaderBuDNS;
			parameters[25].Value = model.ReaderAddr483;
			parameters[26].Value = model.ReaderBaudrate;
			parameters[27].Value = model.ReaderDataBits;
			parameters[28].Value = model.ReaderStopBits;
			parameters[29].Value = model.ReaderParityCheck;
			parameters[30].Value = model.ReaderFlowControl;
			parameters[31].Value = model.ReaderUsage;
			parameters[32].Value = model.ReadTimeAccessID;
			parameters[33].Value = model.ReaderID;

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
		public bool Delete(int ReaderID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderInfo ");
			strSql.Append(" where ReaderID=@ReaderID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderID", DbType.Int32,4)			};
			parameters[0].Value = ReaderID;

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
		public bool DeleteList(string ReaderIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderInfo ");
			strSql.Append(" where ReaderID in ("+ReaderIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo GetModel(int ReaderID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SupervisedMode,PINIdentify,ReaderPIN,DuressCode,ArmPassword,UnarmPassword,CommunicateType,ReaderMAC,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID from ReaderInfo ");
			strSql.Append(" where ReaderID=@ReaderID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReaderID", DbType.Int32,4)			};
			parameters[0].Value = ReaderID;

			KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.ReaderInfo();
			if (row != null)
			{
				if(row["ReaderID"]!=null && row["ReaderID"].ToString()!="")
				{
					model.ReaderID=int.Parse(row["ReaderID"].ToString());
				}
				if(row["ReaderPointID"]!=null && row["ReaderPointID"].ToString()!="")
				{
					model.ReaderPointID=int.Parse(row["ReaderPointID"].ToString());
				}
				if(row["ReaderType"]!=null)
				{
					model.ReaderType=row["ReaderType"].ToString();
				}
				if(row["ReaderName"]!=null)
				{
					model.ReaderName=row["ReaderName"].ToString();
				}
				if(row["ReaderLocation"]!=null)
				{
					model.ReaderLocation=row["ReaderLocation"].ToString();
				}
				if(row["ReaderVersion"]!=null)
				{
					model.ReaderVersion=row["ReaderVersion"].ToString();
				}
				if(row["ReaderSAM"]!=null && row["ReaderSAM"].ToString()!="")
				{
					model.ReaderSAM=int.Parse(row["ReaderSAM"].ToString());
				}
				if(row["ReaderSAMType"]!=null && row["ReaderSAMType"].ToString()!="")
				{
					model.ReaderSAMType=int.Parse(row["ReaderSAMType"].ToString());
				}
				if(row["CardType"]!=null && row["CardType"].ToString()!="")
				{
					model.CardType=int.Parse(row["CardType"].ToString());
				}
				if(row["CardReadArea"]!=null && row["CardReadArea"].ToString()!="")
				{
					model.CardReadArea=int.Parse(row["CardReadArea"].ToString());
				}
				if(row["FingerEnable"]!=null && row["FingerEnable"].ToString()!="")
				{
					if((row["FingerEnable"].ToString()=="1")||(row["FingerEnable"].ToString().ToLower()=="true"))
					{
						model.FingerEnable=true;
					}
					else
					{
						model.FingerEnable=false;
					}
				}
				if(row["SercurityAccessLevel"]!=null && row["SercurityAccessLevel"].ToString()!="")
				{
					model.SercurityAccessLevel=int.Parse(row["SercurityAccessLevel"].ToString());
				}
				if(row["SupervisedMode"]!=null && row["SupervisedMode"].ToString()!="")
				{
					model.SupervisedMode=int.Parse(row["SupervisedMode"].ToString());
				}
				if(row["PINIdentify"]!=null && row["PINIdentify"].ToString()!="")
				{
					model.PINIdentify=int.Parse(row["PINIdentify"].ToString());
				}
				if(row["ReaderPIN"]!=null)
				{
					model.ReaderPIN=row["ReaderPIN"].ToString();
				}
				if(row["DuressCode"]!=null)
				{
					model.DuressCode=row["DuressCode"].ToString();
				}
				if(row["ArmPassword"]!=null)
				{
					model.ArmPassword=row["ArmPassword"].ToString();
				}
				if(row["UnarmPassword"]!=null)
				{
					model.UnarmPassword=row["UnarmPassword"].ToString();
				}
				if(row["CommunicateType"]!=null && row["CommunicateType"].ToString()!="")
				{
					model.CommunicateType=int.Parse(row["CommunicateType"].ToString());
				}
				if(row["ReaderMAC"]!=null)
				{
					model.ReaderMAC=row["ReaderMAC"].ToString();
				}
				if(row["ReaderIP"]!=null)
				{
					model.ReaderIP=row["ReaderIP"].ToString();
				}
				if(row["ReaderSubnet"]!=null)
				{
					model.ReaderSubnet=row["ReaderSubnet"].ToString();
				}
				if(row["ReaderGateway"]!=null)
				{
					model.ReaderGateway=row["ReaderGateway"].ToString();
				}
				if(row["ReaderPort"]!=null && row["ReaderPort"].ToString()!="")
				{
					model.ReaderPort=int.Parse(row["ReaderPort"].ToString());
				}
				if(row["ReaderDNS"]!=null)
				{
					model.ReaderDNS=row["ReaderDNS"].ToString();
				}
				if(row["ReaderBuDNS"]!=null)
				{
					model.ReaderBuDNS=row["ReaderBuDNS"].ToString();
				}
				if(row["ReaderAddr483"]!=null && row["ReaderAddr483"].ToString()!="")
				{
					model.ReaderAddr483=int.Parse(row["ReaderAddr483"].ToString());
				}
				if(row["ReaderBaudrate"]!=null && row["ReaderBaudrate"].ToString()!="")
				{
					model.ReaderBaudrate=int.Parse(row["ReaderBaudrate"].ToString());
				}
				if(row["ReaderDataBits"]!=null && row["ReaderDataBits"].ToString()!="")
				{
					model.ReaderDataBits=int.Parse(row["ReaderDataBits"].ToString());
				}
				if(row["ReaderStopBits"]!=null && row["ReaderStopBits"].ToString()!="")
				{
					model.ReaderStopBits=int.Parse(row["ReaderStopBits"].ToString());
				}
				if(row["ReaderParityCheck"]!=null)
				{
					model.ReaderParityCheck=row["ReaderParityCheck"].ToString();
				}
				if(row["ReaderFlowControl"]!=null)
				{
					model.ReaderFlowControl=row["ReaderFlowControl"].ToString();
				}
				if(row["ReaderUsage"]!=null && row["ReaderUsage"].ToString()!="")
				{
					model.ReaderUsage=int.Parse(row["ReaderUsage"].ToString());
				}
				if(row["ReadTimeAccessID"]!=null && row["ReadTimeAccessID"].ToString()!="")
				{
					model.ReadTimeAccessID=int.Parse(row["ReadTimeAccessID"].ToString());
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
			strSql.Append("select ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SupervisedMode,PINIdentify,ReaderPIN,DuressCode,ArmPassword,UnarmPassword,CommunicateType,ReaderMAC,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID ");
			strSql.Append(" FROM ReaderInfo ");
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
			strSql.Append("select count(1) FROM ReaderInfo ");
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
				strSql.Append("order by T.ReaderID desc");
			}
			strSql.Append(")AS Row, T.*  from ReaderInfo T ");
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
			parameters[0].Value = "ReaderInfo";
			parameters[1].Value = "ReaderID";
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

