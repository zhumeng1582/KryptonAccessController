/**  版本信息模板在安装目录下，可自行修改。
* ControllerInfo.cs
*
* 功 能： N/A
* 类 名： ControllerInfo
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
	/// 数据访问类:ControllerInfo
	/// </summary>
	public partial class ControllerInfo:IControllerInfo
	{
		public ControllerInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ControllerID", "ControllerInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ControllerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ControllerInfo");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4)			};
			parameters[0].Value = ControllerID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.ControllerInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ControllerInfo(");
			strSql.Append("ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable,DoorUnitID1,DoorUnitEnable1,DoorUnitID2,DoorUnitEnable2,DoorUnitID3,DoorUnitEnable3,DoorUnitID4,DoorUnitEnable4,ExpansionBoardID1,ExpansionBoardEnable1,ExpansionBoardID2,ExpansionBoardEnable2,ExpansionBoardID3,ExpansionBoardEnable3,ExpansionBoardID4,ExpansionBoardEnable4)");
			strSql.Append(" values (");
			strSql.Append("@ControllerID,@ControllerType,@ControllerName,@ControllerLocation,@EncryptionType,@CommunicateType,@ControllerVersion,@ControllerMAC,@ControllerIP,@ControllerSubnetMask,@ControllerGateway,@ControllerPort,@ControllerDNS,@ControllerBUDNS,@ControllerAddr485,@ControllerBaudrate,@ControllerDataBits,@ControllerParityCheck,@ControllerFlowControl,@ControllerSAM,@ControllerSAMType,@AuxOutPutPointID,@InputStateType,@FireSensingID,@FireSensingMode,@FireSensingEnable,@TamperSensingID,@TamperSensingMode,@TamperSensingEnable,@LowVoltageID,@LowVoltageMode,@LowVoltageEnable,@PowerOutageID,@PowerOutageMode,@PowerOutageEnable,@DoorUnitID1,@DoorUnitEnable1,@DoorUnitID2,@DoorUnitEnable2,@DoorUnitID3,@DoorUnitEnable3,@DoorUnitID4,@DoorUnitEnable4,@ExpansionBoardID1,@ExpansionBoardEnable1,@ExpansionBoardID2,@ExpansionBoardEnable2,@ExpansionBoardID3,@ExpansionBoardEnable3,@ExpansionBoardID4,@ExpansionBoardEnable4)");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4),
					new SqlParameter("@ControllerType", SqlDbType.Int,4),
					new SqlParameter("@ControllerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ControllerLocation", SqlDbType.NVarChar,100),
					new SqlParameter("@EncryptionType", SqlDbType.Int,4),
					new SqlParameter("@CommunicateType", SqlDbType.Int,4),
					new SqlParameter("@ControllerVersion", SqlDbType.NVarChar,50),
					new SqlParameter("@ControllerMAC", SqlDbType.NVarChar,17),
					new SqlParameter("@ControllerIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerSubnetMask", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerGateway", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerPort", SqlDbType.Int,4),
					new SqlParameter("@ControllerDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerBUDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerAddr485", SqlDbType.Int,4),
					new SqlParameter("@ControllerBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ControllerDataBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerFlowControl", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerSAM", SqlDbType.Int,4),
					new SqlParameter("@ControllerSAMType", SqlDbType.Int,4),
					new SqlParameter("@AuxOutPutPointID", SqlDbType.Int,4),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@FireSensingID", SqlDbType.Int,4),
					new SqlParameter("@FireSensingMode", SqlDbType.Int,4),
					new SqlParameter("@FireSensingEnable", SqlDbType.Bit,1),
					new SqlParameter("@TamperSensingID", SqlDbType.Int,4),
					new SqlParameter("@TamperSensingMode", SqlDbType.Int,4),
					new SqlParameter("@TamperSensingEnable", SqlDbType.Bit,1),
					new SqlParameter("@LowVoltageID", SqlDbType.Int,4),
					new SqlParameter("@LowVoltageMode", SqlDbType.Int,4),
					new SqlParameter("@LowVoltageEnable", SqlDbType.Bit,1),
					new SqlParameter("@PowerOutageID", SqlDbType.Int,4),
					new SqlParameter("@PowerOutageMode", SqlDbType.Int,4),
					new SqlParameter("@PowerOutageEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable1", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable2", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID3", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable3", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID4", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable4", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID1", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable1", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID2", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable2", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID3", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable3", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID4", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable4", SqlDbType.Bit,1)};
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
			parameters[17].Value = model.ControllerParityCheck;
			parameters[18].Value = model.ControllerFlowControl;
			parameters[19].Value = model.ControllerSAM;
			parameters[20].Value = model.ControllerSAMType;
			parameters[21].Value = model.AuxOutPutPointID;
			parameters[22].Value = model.InputStateType;
			parameters[23].Value = model.FireSensingID;
			parameters[24].Value = model.FireSensingMode;
			parameters[25].Value = model.FireSensingEnable;
			parameters[26].Value = model.TamperSensingID;
			parameters[27].Value = model.TamperSensingMode;
			parameters[28].Value = model.TamperSensingEnable;
			parameters[29].Value = model.LowVoltageID;
			parameters[30].Value = model.LowVoltageMode;
			parameters[31].Value = model.LowVoltageEnable;
			parameters[32].Value = model.PowerOutageID;
			parameters[33].Value = model.PowerOutageMode;
			parameters[34].Value = model.PowerOutageEnable;
			parameters[35].Value = model.DoorUnitID1;
			parameters[36].Value = model.DoorUnitEnable1;
			parameters[37].Value = model.DoorUnitID2;
			parameters[38].Value = model.DoorUnitEnable2;
			parameters[39].Value = model.DoorUnitID3;
			parameters[40].Value = model.DoorUnitEnable3;
			parameters[41].Value = model.DoorUnitID4;
			parameters[42].Value = model.DoorUnitEnable4;
			parameters[43].Value = model.ExpansionBoardID1;
			parameters[44].Value = model.ExpansionBoardEnable1;
			parameters[45].Value = model.ExpansionBoardID2;
			parameters[46].Value = model.ExpansionBoardEnable2;
			parameters[47].Value = model.ExpansionBoardID3;
			parameters[48].Value = model.ExpansionBoardEnable3;
			parameters[49].Value = model.ExpansionBoardID4;
			parameters[50].Value = model.ExpansionBoardEnable4;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.ControllerInfo model)
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
			strSql.Append("ControllerParityCheck=@ControllerParityCheck,");
			strSql.Append("ControllerFlowControl=@ControllerFlowControl,");
			strSql.Append("ControllerSAM=@ControllerSAM,");
			strSql.Append("ControllerSAMType=@ControllerSAMType,");
			strSql.Append("AuxOutPutPointID=@AuxOutPutPointID,");
			strSql.Append("InputStateType=@InputStateType,");
			strSql.Append("FireSensingID=@FireSensingID,");
			strSql.Append("FireSensingMode=@FireSensingMode,");
			strSql.Append("FireSensingEnable=@FireSensingEnable,");
			strSql.Append("TamperSensingID=@TamperSensingID,");
			strSql.Append("TamperSensingMode=@TamperSensingMode,");
			strSql.Append("TamperSensingEnable=@TamperSensingEnable,");
			strSql.Append("LowVoltageID=@LowVoltageID,");
			strSql.Append("LowVoltageMode=@LowVoltageMode,");
			strSql.Append("LowVoltageEnable=@LowVoltageEnable,");
			strSql.Append("PowerOutageID=@PowerOutageID,");
			strSql.Append("PowerOutageMode=@PowerOutageMode,");
			strSql.Append("PowerOutageEnable=@PowerOutageEnable,");
			strSql.Append("DoorUnitID1=@DoorUnitID1,");
			strSql.Append("DoorUnitEnable1=@DoorUnitEnable1,");
			strSql.Append("DoorUnitID2=@DoorUnitID2,");
			strSql.Append("DoorUnitEnable2=@DoorUnitEnable2,");
			strSql.Append("DoorUnitID3=@DoorUnitID3,");
			strSql.Append("DoorUnitEnable3=@DoorUnitEnable3,");
			strSql.Append("DoorUnitID4=@DoorUnitID4,");
			strSql.Append("DoorUnitEnable4=@DoorUnitEnable4,");
			strSql.Append("ExpansionBoardID1=@ExpansionBoardID1,");
			strSql.Append("ExpansionBoardEnable1=@ExpansionBoardEnable1,");
			strSql.Append("ExpansionBoardID2=@ExpansionBoardID2,");
			strSql.Append("ExpansionBoardEnable2=@ExpansionBoardEnable2,");
			strSql.Append("ExpansionBoardID3=@ExpansionBoardID3,");
			strSql.Append("ExpansionBoardEnable3=@ExpansionBoardEnable3,");
			strSql.Append("ExpansionBoardID4=@ExpansionBoardID4,");
			strSql.Append("ExpansionBoardEnable4=@ExpansionBoardEnable4");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerType", SqlDbType.Int,4),
					new SqlParameter("@ControllerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ControllerLocation", SqlDbType.NVarChar,100),
					new SqlParameter("@EncryptionType", SqlDbType.Int,4),
					new SqlParameter("@CommunicateType", SqlDbType.Int,4),
					new SqlParameter("@ControllerVersion", SqlDbType.NVarChar,50),
					new SqlParameter("@ControllerMAC", SqlDbType.NVarChar,17),
					new SqlParameter("@ControllerIP", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerSubnetMask", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerGateway", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerPort", SqlDbType.Int,4),
					new SqlParameter("@ControllerDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerBUDNS", SqlDbType.NVarChar,20),
					new SqlParameter("@ControllerAddr485", SqlDbType.Int,4),
					new SqlParameter("@ControllerBaudrate", SqlDbType.Int,4),
					new SqlParameter("@ControllerDataBits", SqlDbType.Int,4),
					new SqlParameter("@ControllerParityCheck", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerFlowControl", SqlDbType.NVarChar,8),
					new SqlParameter("@ControllerSAM", SqlDbType.Int,4),
					new SqlParameter("@ControllerSAMType", SqlDbType.Int,4),
					new SqlParameter("@AuxOutPutPointID", SqlDbType.Int,4),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@FireSensingID", SqlDbType.Int,4),
					new SqlParameter("@FireSensingMode", SqlDbType.Int,4),
					new SqlParameter("@FireSensingEnable", SqlDbType.Bit,1),
					new SqlParameter("@TamperSensingID", SqlDbType.Int,4),
					new SqlParameter("@TamperSensingMode", SqlDbType.Int,4),
					new SqlParameter("@TamperSensingEnable", SqlDbType.Bit,1),
					new SqlParameter("@LowVoltageID", SqlDbType.Int,4),
					new SqlParameter("@LowVoltageMode", SqlDbType.Int,4),
					new SqlParameter("@LowVoltageEnable", SqlDbType.Bit,1),
					new SqlParameter("@PowerOutageID", SqlDbType.Int,4),
					new SqlParameter("@PowerOutageMode", SqlDbType.Int,4),
					new SqlParameter("@PowerOutageEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID1", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable1", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID2", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable2", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID3", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable3", SqlDbType.Bit,1),
					new SqlParameter("@DoorUnitID4", SqlDbType.Int,4),
					new SqlParameter("@DoorUnitEnable4", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID1", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable1", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID2", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable2", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID3", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable3", SqlDbType.Bit,1),
					new SqlParameter("@ExpansionBoardID4", SqlDbType.Int,4),
					new SqlParameter("@ExpansionBoardEnable4", SqlDbType.Bit,1),
					new SqlParameter("@ControllerID", SqlDbType.Int,4)};
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
			parameters[16].Value = model.ControllerParityCheck;
			parameters[17].Value = model.ControllerFlowControl;
			parameters[18].Value = model.ControllerSAM;
			parameters[19].Value = model.ControllerSAMType;
			parameters[20].Value = model.AuxOutPutPointID;
			parameters[21].Value = model.InputStateType;
			parameters[22].Value = model.FireSensingID;
			parameters[23].Value = model.FireSensingMode;
			parameters[24].Value = model.FireSensingEnable;
			parameters[25].Value = model.TamperSensingID;
			parameters[26].Value = model.TamperSensingMode;
			parameters[27].Value = model.TamperSensingEnable;
			parameters[28].Value = model.LowVoltageID;
			parameters[29].Value = model.LowVoltageMode;
			parameters[30].Value = model.LowVoltageEnable;
			parameters[31].Value = model.PowerOutageID;
			parameters[32].Value = model.PowerOutageMode;
			parameters[33].Value = model.PowerOutageEnable;
			parameters[34].Value = model.DoorUnitID1;
			parameters[35].Value = model.DoorUnitEnable1;
			parameters[36].Value = model.DoorUnitID2;
			parameters[37].Value = model.DoorUnitEnable2;
			parameters[38].Value = model.DoorUnitID3;
			parameters[39].Value = model.DoorUnitEnable3;
			parameters[40].Value = model.DoorUnitID4;
			parameters[41].Value = model.DoorUnitEnable4;
			parameters[42].Value = model.ExpansionBoardID1;
			parameters[43].Value = model.ExpansionBoardEnable1;
			parameters[44].Value = model.ExpansionBoardID2;
			parameters[45].Value = model.ExpansionBoardEnable2;
			parameters[46].Value = model.ExpansionBoardID3;
			parameters[47].Value = model.ExpansionBoardEnable3;
			parameters[48].Value = model.ExpansionBoardID4;
			parameters[49].Value = model.ExpansionBoardEnable4;
			parameters[50].Value = model.ControllerID;

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
			strSql.Append("delete from ControllerInfo ");
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
			strSql.Append("delete from ControllerInfo ");
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
		public KryptonAccessController.AccessDataBase.Model.ControllerInfo GetModel(int ControllerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable,DoorUnitID1,DoorUnitEnable1,DoorUnitID2,DoorUnitEnable2,DoorUnitID3,DoorUnitEnable3,DoorUnitID4,DoorUnitEnable4,ExpansionBoardID1,ExpansionBoardEnable1,ExpansionBoardID2,ExpansionBoardEnable2,ExpansionBoardID3,ExpansionBoardEnable3,ExpansionBoardID4,ExpansionBoardEnable4 from ControllerInfo ");
			strSql.Append(" where ControllerID=@ControllerID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ControllerID", SqlDbType.Int,4)			};
			parameters[0].Value = ControllerID;

			KryptonAccessController.AccessDataBase.Model.ControllerInfo model=new KryptonAccessController.AccessDataBase.Model.ControllerInfo();
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
		public KryptonAccessController.AccessDataBase.Model.ControllerInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.ControllerInfo model=new KryptonAccessController.AccessDataBase.Model.ControllerInfo();
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
				if(row["AuxOutPutPointID"]!=null && row["AuxOutPutPointID"].ToString()!="")
				{
					model.AuxOutPutPointID=int.Parse(row["AuxOutPutPointID"].ToString());
				}
				if(row["InputStateType"]!=null && row["InputStateType"].ToString()!="")
				{
					model.InputStateType=int.Parse(row["InputStateType"].ToString());
				}
				if(row["FireSensingID"]!=null && row["FireSensingID"].ToString()!="")
				{
					model.FireSensingID=int.Parse(row["FireSensingID"].ToString());
				}
				if(row["FireSensingMode"]!=null && row["FireSensingMode"].ToString()!="")
				{
					model.FireSensingMode=int.Parse(row["FireSensingMode"].ToString());
				}
				if(row["FireSensingEnable"]!=null && row["FireSensingEnable"].ToString()!="")
				{
					if((row["FireSensingEnable"].ToString()=="1")||(row["FireSensingEnable"].ToString().ToLower()=="true"))
					{
						model.FireSensingEnable=true;
					}
					else
					{
						model.FireSensingEnable=false;
					}
				}
				if(row["TamperSensingID"]!=null && row["TamperSensingID"].ToString()!="")
				{
					model.TamperSensingID=int.Parse(row["TamperSensingID"].ToString());
				}
				if(row["TamperSensingMode"]!=null && row["TamperSensingMode"].ToString()!="")
				{
					model.TamperSensingMode=int.Parse(row["TamperSensingMode"].ToString());
				}
				if(row["TamperSensingEnable"]!=null && row["TamperSensingEnable"].ToString()!="")
				{
					if((row["TamperSensingEnable"].ToString()=="1")||(row["TamperSensingEnable"].ToString().ToLower()=="true"))
					{
						model.TamperSensingEnable=true;
					}
					else
					{
						model.TamperSensingEnable=false;
					}
				}
				if(row["LowVoltageID"]!=null && row["LowVoltageID"].ToString()!="")
				{
					model.LowVoltageID=int.Parse(row["LowVoltageID"].ToString());
				}
				if(row["LowVoltageMode"]!=null && row["LowVoltageMode"].ToString()!="")
				{
					model.LowVoltageMode=int.Parse(row["LowVoltageMode"].ToString());
				}
				if(row["LowVoltageEnable"]!=null && row["LowVoltageEnable"].ToString()!="")
				{
					if((row["LowVoltageEnable"].ToString()=="1")||(row["LowVoltageEnable"].ToString().ToLower()=="true"))
					{
						model.LowVoltageEnable=true;
					}
					else
					{
						model.LowVoltageEnable=false;
					}
				}
				if(row["PowerOutageID"]!=null && row["PowerOutageID"].ToString()!="")
				{
					model.PowerOutageID=int.Parse(row["PowerOutageID"].ToString());
				}
				if(row["PowerOutageMode"]!=null && row["PowerOutageMode"].ToString()!="")
				{
					model.PowerOutageMode=int.Parse(row["PowerOutageMode"].ToString());
				}
				if(row["PowerOutageEnable"]!=null && row["PowerOutageEnable"].ToString()!="")
				{
					if((row["PowerOutageEnable"].ToString()=="1")||(row["PowerOutageEnable"].ToString().ToLower()=="true"))
					{
						model.PowerOutageEnable=true;
					}
					else
					{
						model.PowerOutageEnable=false;
					}
				}
				if(row["DoorUnitID1"]!=null && row["DoorUnitID1"].ToString()!="")
				{
					model.DoorUnitID1=int.Parse(row["DoorUnitID1"].ToString());
				}
				if(row["DoorUnitEnable1"]!=null && row["DoorUnitEnable1"].ToString()!="")
				{
					if((row["DoorUnitEnable1"].ToString()=="1")||(row["DoorUnitEnable1"].ToString().ToLower()=="true"))
					{
						model.DoorUnitEnable1=true;
					}
					else
					{
						model.DoorUnitEnable1=false;
					}
				}
				if(row["DoorUnitID2"]!=null && row["DoorUnitID2"].ToString()!="")
				{
					model.DoorUnitID2=int.Parse(row["DoorUnitID2"].ToString());
				}
				if(row["DoorUnitEnable2"]!=null && row["DoorUnitEnable2"].ToString()!="")
				{
					if((row["DoorUnitEnable2"].ToString()=="1")||(row["DoorUnitEnable2"].ToString().ToLower()=="true"))
					{
						model.DoorUnitEnable2=true;
					}
					else
					{
						model.DoorUnitEnable2=false;
					}
				}
				if(row["DoorUnitID3"]!=null && row["DoorUnitID3"].ToString()!="")
				{
					model.DoorUnitID3=int.Parse(row["DoorUnitID3"].ToString());
				}
				if(row["DoorUnitEnable3"]!=null && row["DoorUnitEnable3"].ToString()!="")
				{
					if((row["DoorUnitEnable3"].ToString()=="1")||(row["DoorUnitEnable3"].ToString().ToLower()=="true"))
					{
						model.DoorUnitEnable3=true;
					}
					else
					{
						model.DoorUnitEnable3=false;
					}
				}
				if(row["DoorUnitID4"]!=null && row["DoorUnitID4"].ToString()!="")
				{
					model.DoorUnitID4=int.Parse(row["DoorUnitID4"].ToString());
				}
				if(row["DoorUnitEnable4"]!=null && row["DoorUnitEnable4"].ToString()!="")
				{
					if((row["DoorUnitEnable4"].ToString()=="1")||(row["DoorUnitEnable4"].ToString().ToLower()=="true"))
					{
						model.DoorUnitEnable4=true;
					}
					else
					{
						model.DoorUnitEnable4=false;
					}
				}
				if(row["ExpansionBoardID1"]!=null && row["ExpansionBoardID1"].ToString()!="")
				{
					model.ExpansionBoardID1=int.Parse(row["ExpansionBoardID1"].ToString());
				}
				if(row["ExpansionBoardEnable1"]!=null && row["ExpansionBoardEnable1"].ToString()!="")
				{
					if((row["ExpansionBoardEnable1"].ToString()=="1")||(row["ExpansionBoardEnable1"].ToString().ToLower()=="true"))
					{
						model.ExpansionBoardEnable1=true;
					}
					else
					{
						model.ExpansionBoardEnable1=false;
					}
				}
				if(row["ExpansionBoardID2"]!=null && row["ExpansionBoardID2"].ToString()!="")
				{
					model.ExpansionBoardID2=int.Parse(row["ExpansionBoardID2"].ToString());
				}
				if(row["ExpansionBoardEnable2"]!=null && row["ExpansionBoardEnable2"].ToString()!="")
				{
					if((row["ExpansionBoardEnable2"].ToString()=="1")||(row["ExpansionBoardEnable2"].ToString().ToLower()=="true"))
					{
						model.ExpansionBoardEnable2=true;
					}
					else
					{
						model.ExpansionBoardEnable2=false;
					}
				}
				if(row["ExpansionBoardID3"]!=null && row["ExpansionBoardID3"].ToString()!="")
				{
					model.ExpansionBoardID3=int.Parse(row["ExpansionBoardID3"].ToString());
				}
				if(row["ExpansionBoardEnable3"]!=null && row["ExpansionBoardEnable3"].ToString()!="")
				{
					if((row["ExpansionBoardEnable3"].ToString()=="1")||(row["ExpansionBoardEnable3"].ToString().ToLower()=="true"))
					{
						model.ExpansionBoardEnable3=true;
					}
					else
					{
						model.ExpansionBoardEnable3=false;
					}
				}
				if(row["ExpansionBoardID4"]!=null && row["ExpansionBoardID4"].ToString()!="")
				{
					model.ExpansionBoardID4=int.Parse(row["ExpansionBoardID4"].ToString());
				}
				if(row["ExpansionBoardEnable4"]!=null && row["ExpansionBoardEnable4"].ToString()!="")
				{
					if((row["ExpansionBoardEnable4"].ToString()=="1")||(row["ExpansionBoardEnable4"].ToString().ToLower()=="true"))
					{
						model.ExpansionBoardEnable4=true;
					}
					else
					{
						model.ExpansionBoardEnable4=false;
					}
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
			strSql.Append("select ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable,DoorUnitID1,DoorUnitEnable1,DoorUnitID2,DoorUnitEnable2,DoorUnitID3,DoorUnitEnable3,DoorUnitID4,DoorUnitEnable4,ExpansionBoardID1,ExpansionBoardEnable1,ExpansionBoardID2,ExpansionBoardEnable2,ExpansionBoardID3,ExpansionBoardEnable3,ExpansionBoardID4,ExpansionBoardEnable4 ");
			strSql.Append(" FROM ControllerInfo ");
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
			strSql.Append(" ControllerID,ControllerType,ControllerName,ControllerLocation,EncryptionType,CommunicateType,ControllerVersion,ControllerMAC,ControllerIP,ControllerSubnetMask,ControllerGateway,ControllerPort,ControllerDNS,ControllerBUDNS,ControllerAddr485,ControllerBaudrate,ControllerDataBits,ControllerParityCheck,ControllerFlowControl,ControllerSAM,ControllerSAMType,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable,DoorUnitID1,DoorUnitEnable1,DoorUnitID2,DoorUnitEnable2,DoorUnitID3,DoorUnitEnable3,DoorUnitID4,DoorUnitEnable4,ExpansionBoardID1,ExpansionBoardEnable1,ExpansionBoardID2,ExpansionBoardEnable2,ExpansionBoardID3,ExpansionBoardEnable3,ExpansionBoardID4,ExpansionBoardEnable4 ");
			strSql.Append(" FROM ControllerInfo ");
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
			parameters[0].Value = "ControllerInfo";
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

