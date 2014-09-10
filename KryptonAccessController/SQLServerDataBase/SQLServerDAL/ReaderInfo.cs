/**  版本信息模板在安装目录下，可自行修改。
* ReaderInfo.cs
*
* 功 能： N/A
* 类 名： ReaderInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:31   N/A    初版
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
	/// 数据访问类:ReaderInfo
	/// </summary>
	public partial class ReaderInfo:IReaderInfo
	{
		public ReaderInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReaderID", "ReaderInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReaderID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReaderInfo");
			strSql.Append(" where ReaderID=@ReaderID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ReaderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReaderInfo(");
			strSql.Append("ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SuperviseMode,PINIdentify,ReaderPIN,DuressCode,ArmPassWord,UnarmPassWord,CommunicateType,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID)");
			strSql.Append(" values (");
			strSql.Append("@ReaderID,@ReaderPointID,@ReaderType,@ReaderName,@ReaderLocation,@ReaderVersion,@ReaderSAM,@ReaderSAMType,@CardType,@CardReadArea,@FingerEnable,@SercurityAccessLevel,@SuperviseMode,@PINIdentify,@ReaderPIN,@DuressCode,@ArmPassWord,@UnarmPassWord,@CommunicateType,@ReaderIP,@ReaderSubnet,@ReaderGateway,@ReaderPort,@ReaderDNS,@ReaderBuDNS,@ReaderAddr483,@ReaderBaudrate,@ReaderDataBits,@ReaderStopBits,@ReaderParityCheck,@ReaderFlowControl,@ReaderUsage,@ReadTimeAccessID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderID", SqlDbType.Int,4),
					new SqlParameter("@ReaderPointID", SqlDbType.Int,4),
					new SqlParameter("@ReaderType", SqlDbType.NVarChar,1),
					new SqlParameter("@ReaderName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReaderLocation", SqlDbType.NVarChar,100),
					new SqlParameter("@ReaderVersion", SqlDbType.NVarChar,50),
					new SqlParameter("@ReaderSAM", SqlDbType.Int,4),
					new SqlParameter("@ReaderSAMType", SqlDbType.Int,4),
					new SqlParameter("@CardType", SqlDbType.Int,4),
					new SqlParameter("@CardReadArea", SqlDbType.Int,4),
					new SqlParameter("@FingerEnable", SqlDbType.Bit,1),
					new SqlParameter("@SercurityAccessLevel", SqlDbType.Int,4),
					new SqlParameter("@SuperviseMode", SqlDbType.Int,4),
					new SqlParameter("@PINIdentify", SqlDbType.Int,4),
					new SqlParameter("@ReaderPIN", SqlDbType.NVarChar,10),
					new SqlParameter("@DuressCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ArmPassWord", SqlDbType.NVarChar,10),
					new SqlParameter("@UnarmPassWord", SqlDbType.NVarChar,10),
					new SqlParameter("@CommunicateType", SqlDbType.Int,4),
					new SqlParameter("@ReaderIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderSubnet", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderGateway", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderPort", SqlDbType.Int,4),
					new SqlParameter("@ReaderDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderBuDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderAddr483", SqlDbType.Int,4),
					new SqlParameter("@ReaderBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ReaderDataBits", SqlDbType.Int,4),
					new SqlParameter("@ReaderStopBits", SqlDbType.Int,4),
					new SqlParameter("@ReaderParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ReaderFlowControl", SqlDbType.NVarChar,8),
					new SqlParameter("@ReaderUsage", SqlDbType.Int,4),
					new SqlParameter("@ReadTimeAccessID", SqlDbType.Int,4)};
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
			parameters[12].Value = model.SuperviseMode;
			parameters[13].Value = model.PINIdentify;
			parameters[14].Value = model.ReaderPIN;
			parameters[15].Value = model.DuressCode;
			parameters[16].Value = model.ArmPassWord;
			parameters[17].Value = model.UnarmPassWord;
			parameters[18].Value = model.CommunicateType;
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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ReaderInfo model)
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
			strSql.Append("SuperviseMode=@SuperviseMode,");
			strSql.Append("PINIdentify=@PINIdentify,");
			strSql.Append("ReaderPIN=@ReaderPIN,");
			strSql.Append("DuressCode=@DuressCode,");
			strSql.Append("ArmPassWord=@ArmPassWord,");
			strSql.Append("UnarmPassWord=@UnarmPassWord,");
			strSql.Append("CommunicateType=@CommunicateType,");
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
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderPointID", SqlDbType.Int,4),
					new SqlParameter("@ReaderType", SqlDbType.NVarChar,1),
					new SqlParameter("@ReaderName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReaderLocation", SqlDbType.NVarChar,100),
					new SqlParameter("@ReaderVersion", SqlDbType.NVarChar,50),
					new SqlParameter("@ReaderSAM", SqlDbType.Int,4),
					new SqlParameter("@ReaderSAMType", SqlDbType.Int,4),
					new SqlParameter("@CardType", SqlDbType.Int,4),
					new SqlParameter("@CardReadArea", SqlDbType.Int,4),
					new SqlParameter("@FingerEnable", SqlDbType.Bit,1),
					new SqlParameter("@SercurityAccessLevel", SqlDbType.Int,4),
					new SqlParameter("@SuperviseMode", SqlDbType.Int,4),
					new SqlParameter("@PINIdentify", SqlDbType.Int,4),
					new SqlParameter("@ReaderPIN", SqlDbType.NVarChar,10),
					new SqlParameter("@DuressCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ArmPassWord", SqlDbType.NVarChar,10),
					new SqlParameter("@UnarmPassWord", SqlDbType.NVarChar,10),
					new SqlParameter("@CommunicateType", SqlDbType.Int,4),
					new SqlParameter("@ReaderIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderSubnet", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderGateway", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderPort", SqlDbType.Int,4),
					new SqlParameter("@ReaderDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderBuDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ReaderAddr483", SqlDbType.Int,4),
					new SqlParameter("@ReaderBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ReaderDataBits", SqlDbType.Int,4),
					new SqlParameter("@ReaderStopBits", SqlDbType.Int,4),
					new SqlParameter("@ReaderParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ReaderFlowControl", SqlDbType.NVarChar,8),
					new SqlParameter("@ReaderUsage", SqlDbType.Int,4),
					new SqlParameter("@ReadTimeAccessID", SqlDbType.Int,4),
					new SqlParameter("@ReaderID", SqlDbType.Int,4)};
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
			parameters[11].Value = model.SuperviseMode;
			parameters[12].Value = model.PINIdentify;
			parameters[13].Value = model.ReaderPIN;
			parameters[14].Value = model.DuressCode;
			parameters[15].Value = model.ArmPassWord;
			parameters[16].Value = model.UnarmPassWord;
			parameters[17].Value = model.CommunicateType;
			parameters[18].Value = model.ReaderIP;
			parameters[19].Value = model.ReaderSubnet;
			parameters[20].Value = model.ReaderGateway;
			parameters[21].Value = model.ReaderPort;
			parameters[22].Value = model.ReaderDNS;
			parameters[23].Value = model.ReaderBuDNS;
			parameters[24].Value = model.ReaderAddr483;
			parameters[25].Value = model.ReaderBaudrate;
			parameters[26].Value = model.ReaderDataBits;
			parameters[27].Value = model.ReaderStopBits;
			parameters[28].Value = model.ReaderParityCheck;
			parameters[29].Value = model.ReaderFlowControl;
			parameters[30].Value = model.ReaderUsage;
			parameters[31].Value = model.ReadTimeAccessID;
			parameters[32].Value = model.ReaderID;

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
		public bool Delete(int ReaderID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderInfo ");
			strSql.Append(" where ReaderID=@ReaderID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderID;

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
		public bool DeleteList(string ReaderIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReaderInfo ");
			strSql.Append(" where ReaderID in ("+ReaderIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.ReaderInfo GetModel(int ReaderID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SuperviseMode,PINIdentify,ReaderPIN,DuressCode,ArmPassWord,UnarmPassWord,CommunicateType,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID from ReaderInfo ");
			strSql.Append(" where ReaderID=@ReaderID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReaderID", SqlDbType.Int,4)			};
			parameters[0].Value = ReaderID;

			KryptonAccessController.AccessDataBase.Model.ReaderInfo model=new KryptonAccessController.AccessDataBase.Model.ReaderInfo();
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
		public KryptonAccessController.AccessDataBase.Model.ReaderInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ReaderInfo model=new KryptonAccessController.AccessDataBase.Model.ReaderInfo();
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
				if(row["SuperviseMode"]!=null && row["SuperviseMode"].ToString()!="")
				{
					model.SuperviseMode=int.Parse(row["SuperviseMode"].ToString());
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
				if(row["ArmPassWord"]!=null)
				{
					model.ArmPassWord=row["ArmPassWord"].ToString();
				}
				if(row["UnarmPassWord"]!=null)
				{
					model.UnarmPassWord=row["UnarmPassWord"].ToString();
				}
				if(row["CommunicateType"]!=null && row["CommunicateType"].ToString()!="")
				{
					model.CommunicateType=int.Parse(row["CommunicateType"].ToString());
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
			strSql.Append("select ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SuperviseMode,PINIdentify,ReaderPIN,DuressCode,ArmPassWord,UnarmPassWord,CommunicateType,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID ");
			strSql.Append(" FROM ReaderInfo ");
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
			strSql.Append(" ReaderID,ReaderPointID,ReaderType,ReaderName,ReaderLocation,ReaderVersion,ReaderSAM,ReaderSAMType,CardType,CardReadArea,FingerEnable,SercurityAccessLevel,SuperviseMode,PINIdentify,ReaderPIN,DuressCode,ArmPassWord,UnarmPassWord,CommunicateType,ReaderIP,ReaderSubnet,ReaderGateway,ReaderPort,ReaderDNS,ReaderBuDNS,ReaderAddr483,ReaderBaudrate,ReaderDataBits,ReaderStopBits,ReaderParityCheck,ReaderFlowControl,ReaderUsage,ReadTimeAccessID ");
			strSql.Append(" FROM ReaderInfo ");
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
			parameters[0].Value = "ReaderInfo";
			parameters[1].Value = "ReaderID";
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

