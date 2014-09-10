/**  版本信息模板在安装目录下，可自行修改。
* DoorUnitInfo.cs
*
* 功 能： N/A
* 类 名： DoorUnitInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/16 15:24:21   N/A    初版
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
	/// 数据访问类:DoorUnitInfo
	/// </summary>
	public partial class DoorUnitInfo:IDoorUnitInfo
	{
		public DoorUnitInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DoorUnitID", "DoorUnitInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DoorUnitID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DoorUnitInfo");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DoorUnitID", SqlDbType.Int,4)			};
			parameters[0].Value = DoorUnitID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.AccessDataBase.Model.DoorUnitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DoorUnitInfo(");
			strSql.Append("DoorUnitID,OutPutLockID,OutPutTimeLen,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReadID1,ReadIDEnable1,ReadID2,ReadIDEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable,ElectronicMapID,PositionX,PositionY,StateImageOpen,StateImageClose,StateImageAlarmOpen,StateImageAlarmClose)");
			strSql.Append(" values (");
			strSql.Append("@DoorUnitID,@OutPutLockID,@OutPutTimeLen,@OpenDoorOverTimeLen,@ZoneCountLimitEnable,@ZoneCountLimitMax,@ZoneCountLimitMed,@ZoneCountLimitMin,@ReadID1,@ReadIDEnable1,@ReadID2,@ReadIDEnable2,@InputStateType,@ExitButtonID,@ExitButtonMode,@ExtiButtonEnable,@DoorContactID,@DoorContactMode,@DoorContactEnable,@DoorPositionID,@DoorPositionMode,@DoorPositionEnable,@BreakGlassID,@BreakGlassMode,@BreakGlassEnable,@ElectronicMapID,@PositionX,@PositionY,@StateImageOpen,@StateImageClose,@StateImageAlarmOpen,@StateImageAlarmClose)");
			SqlParameter[] parameters = {
					new SqlParameter("@DoorUnitID", SqlDbType.Int,4),
					new SqlParameter("@OutPutLockID", SqlDbType.Int,4),
					new SqlParameter("@OutPutTimeLen", SqlDbType.Int,4),
					new SqlParameter("@OpenDoorOverTimeLen", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitEnable", SqlDbType.Bit,1),
					new SqlParameter("@ZoneCountLimitMax", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitMed", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitMin", SqlDbType.Int,4),
					new SqlParameter("@ReadID1", SqlDbType.Int,4),
					new SqlParameter("@ReadIDEnable1", SqlDbType.Bit,1),
					new SqlParameter("@ReadID2", SqlDbType.Int,4),
					new SqlParameter("@ReadIDEnable2", SqlDbType.Bit,1),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@ExitButtonID", SqlDbType.Int,4),
					new SqlParameter("@ExitButtonMode", SqlDbType.Int,4),
					new SqlParameter("@ExtiButtonEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorContactID", SqlDbType.Int,4),
					new SqlParameter("@DoorContactMode", SqlDbType.Int,4),
					new SqlParameter("@DoorContactEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorPositionID", SqlDbType.Int,4),
					new SqlParameter("@DoorPositionMode", SqlDbType.Int,4),
					new SqlParameter("@DoorPositionEnable", SqlDbType.Bit,1),
					new SqlParameter("@BreakGlassID", SqlDbType.Int,4),
					new SqlParameter("@BreakGlassMode", SqlDbType.Int,4),
					new SqlParameter("@BreakGlassEnable", SqlDbType.Bit,1),
					new SqlParameter("@ElectronicMapID", SqlDbType.Int,4),
					new SqlParameter("@PositionX", SqlDbType.Int,4),
					new SqlParameter("@PositionY", SqlDbType.Int,4),
					new SqlParameter("@StateImageOpen", SqlDbType.Image),
					new SqlParameter("@StateImageClose", SqlDbType.Image),
					new SqlParameter("@StateImageAlarmOpen", SqlDbType.Image),
					new SqlParameter("@StateImageAlarmClose", SqlDbType.Image)};
			parameters[0].Value = model.DoorUnitID;
			parameters[1].Value = model.OutPutLockID;
			parameters[2].Value = model.OutPutTimeLen;
			parameters[3].Value = model.OpenDoorOverTimeLen;
			parameters[4].Value = model.ZoneCountLimitEnable;
			parameters[5].Value = model.ZoneCountLimitMax;
			parameters[6].Value = model.ZoneCountLimitMed;
			parameters[7].Value = model.ZoneCountLimitMin;
			parameters[8].Value = model.ReadID1;
			parameters[9].Value = model.ReadIDEnable1;
			parameters[10].Value = model.ReadID2;
			parameters[11].Value = model.ReadIDEnable2;
			parameters[12].Value = model.InputStateType;
			parameters[13].Value = model.ExitButtonID;
			parameters[14].Value = model.ExitButtonMode;
			parameters[15].Value = model.ExtiButtonEnable;
			parameters[16].Value = model.DoorContactID;
			parameters[17].Value = model.DoorContactMode;
			parameters[18].Value = model.DoorContactEnable;
			parameters[19].Value = model.DoorPositionID;
			parameters[20].Value = model.DoorPositionMode;
			parameters[21].Value = model.DoorPositionEnable;
			parameters[22].Value = model.BreakGlassID;
			parameters[23].Value = model.BreakGlassMode;
			parameters[24].Value = model.BreakGlassEnable;
			parameters[25].Value = model.ElectronicMapID;
			parameters[26].Value = model.PositionX;
			parameters[27].Value = model.PositionY;
			parameters[28].Value = model.StateImageOpen;
			parameters[29].Value = model.StateImageClose;
			parameters[30].Value = model.StateImageAlarmOpen;
			parameters[31].Value = model.StateImageAlarmClose;

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
		public bool Update(KryptonAccessController.AccessDataBase.Model.DoorUnitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DoorUnitInfo set ");
			strSql.Append("OutPutLockID=@OutPutLockID,");
			strSql.Append("OutPutTimeLen=@OutPutTimeLen,");
			strSql.Append("OpenDoorOverTimeLen=@OpenDoorOverTimeLen,");
			strSql.Append("ZoneCountLimitEnable=@ZoneCountLimitEnable,");
			strSql.Append("ZoneCountLimitMax=@ZoneCountLimitMax,");
			strSql.Append("ZoneCountLimitMed=@ZoneCountLimitMed,");
			strSql.Append("ZoneCountLimitMin=@ZoneCountLimitMin,");
			strSql.Append("ReadID1=@ReadID1,");
			strSql.Append("ReadIDEnable1=@ReadIDEnable1,");
			strSql.Append("ReadID2=@ReadID2,");
			strSql.Append("ReadIDEnable2=@ReadIDEnable2,");
			strSql.Append("InputStateType=@InputStateType,");
			strSql.Append("ExitButtonID=@ExitButtonID,");
			strSql.Append("ExitButtonMode=@ExitButtonMode,");
			strSql.Append("ExtiButtonEnable=@ExtiButtonEnable,");
			strSql.Append("DoorContactID=@DoorContactID,");
			strSql.Append("DoorContactMode=@DoorContactMode,");
			strSql.Append("DoorContactEnable=@DoorContactEnable,");
			strSql.Append("DoorPositionID=@DoorPositionID,");
			strSql.Append("DoorPositionMode=@DoorPositionMode,");
			strSql.Append("DoorPositionEnable=@DoorPositionEnable,");
			strSql.Append("BreakGlassID=@BreakGlassID,");
			strSql.Append("BreakGlassMode=@BreakGlassMode,");
			strSql.Append("BreakGlassEnable=@BreakGlassEnable,");
			strSql.Append("ElectronicMapID=@ElectronicMapID,");
			strSql.Append("PositionX=@PositionX,");
			strSql.Append("PositionY=@PositionY,");
			strSql.Append("StateImageOpen=@StateImageOpen,");
			strSql.Append("StateImageClose=@StateImageClose,");
			strSql.Append("StateImageAlarmOpen=@StateImageAlarmOpen,");
			strSql.Append("StateImageAlarmClose=@StateImageAlarmClose");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OutPutLockID", SqlDbType.Int,4),
					new SqlParameter("@OutPutTimeLen", SqlDbType.Int,4),
					new SqlParameter("@OpenDoorOverTimeLen", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitEnable", SqlDbType.Bit,1),
					new SqlParameter("@ZoneCountLimitMax", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitMed", SqlDbType.Int,4),
					new SqlParameter("@ZoneCountLimitMin", SqlDbType.Int,4),
					new SqlParameter("@ReadID1", SqlDbType.Int,4),
					new SqlParameter("@ReadIDEnable1", SqlDbType.Bit,1),
					new SqlParameter("@ReadID2", SqlDbType.Int,4),
					new SqlParameter("@ReadIDEnable2", SqlDbType.Bit,1),
					new SqlParameter("@InputStateType", SqlDbType.Int,4),
					new SqlParameter("@ExitButtonID", SqlDbType.Int,4),
					new SqlParameter("@ExitButtonMode", SqlDbType.Int,4),
					new SqlParameter("@ExtiButtonEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorContactID", SqlDbType.Int,4),
					new SqlParameter("@DoorContactMode", SqlDbType.Int,4),
					new SqlParameter("@DoorContactEnable", SqlDbType.Bit,1),
					new SqlParameter("@DoorPositionID", SqlDbType.Int,4),
					new SqlParameter("@DoorPositionMode", SqlDbType.Int,4),
					new SqlParameter("@DoorPositionEnable", SqlDbType.Bit,1),
					new SqlParameter("@BreakGlassID", SqlDbType.Int,4),
					new SqlParameter("@BreakGlassMode", SqlDbType.Int,4),
					new SqlParameter("@BreakGlassEnable", SqlDbType.Bit,1),
					new SqlParameter("@ElectronicMapID", SqlDbType.Int,4),
					new SqlParameter("@PositionX", SqlDbType.Int,4),
					new SqlParameter("@PositionY", SqlDbType.Int,4),
					new SqlParameter("@StateImageOpen", SqlDbType.Image),
					new SqlParameter("@StateImageClose", SqlDbType.Image),
					new SqlParameter("@StateImageAlarmOpen", SqlDbType.Image),
					new SqlParameter("@StateImageAlarmClose", SqlDbType.Image),
					new SqlParameter("@DoorUnitID", SqlDbType.Int,4)};
			parameters[0].Value = model.OutPutLockID;
			parameters[1].Value = model.OutPutTimeLen;
			parameters[2].Value = model.OpenDoorOverTimeLen;
			parameters[3].Value = model.ZoneCountLimitEnable;
			parameters[4].Value = model.ZoneCountLimitMax;
			parameters[5].Value = model.ZoneCountLimitMed;
			parameters[6].Value = model.ZoneCountLimitMin;
			parameters[7].Value = model.ReadID1;
			parameters[8].Value = model.ReadIDEnable1;
			parameters[9].Value = model.ReadID2;
			parameters[10].Value = model.ReadIDEnable2;
			parameters[11].Value = model.InputStateType;
			parameters[12].Value = model.ExitButtonID;
			parameters[13].Value = model.ExitButtonMode;
			parameters[14].Value = model.ExtiButtonEnable;
			parameters[15].Value = model.DoorContactID;
			parameters[16].Value = model.DoorContactMode;
			parameters[17].Value = model.DoorContactEnable;
			parameters[18].Value = model.DoorPositionID;
			parameters[19].Value = model.DoorPositionMode;
			parameters[20].Value = model.DoorPositionEnable;
			parameters[21].Value = model.BreakGlassID;
			parameters[22].Value = model.BreakGlassMode;
			parameters[23].Value = model.BreakGlassEnable;
			parameters[24].Value = model.ElectronicMapID;
			parameters[25].Value = model.PositionX;
			parameters[26].Value = model.PositionY;
			parameters[27].Value = model.StateImageOpen;
			parameters[28].Value = model.StateImageClose;
			parameters[29].Value = model.StateImageAlarmOpen;
			parameters[30].Value = model.StateImageAlarmClose;
			parameters[31].Value = model.DoorUnitID;

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
		public bool Delete(int DoorUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DoorUnitID", SqlDbType.Int,4)			};
			parameters[0].Value = DoorUnitID;

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
		public bool DeleteList(string DoorUnitIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID in ("+DoorUnitIDlist + ")  ");
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
		public KryptonAccessController.AccessDataBase.Model.DoorUnitInfo GetModel(int DoorUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DoorUnitID,OutPutLockID,OutPutTimeLen,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReadID1,ReadIDEnable1,ReadID2,ReadIDEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable,ElectronicMapID,PositionX,PositionY,StateImageOpen,StateImageClose,StateImageAlarmOpen,StateImageAlarmClose from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DoorUnitID", SqlDbType.Int,4)			};
			parameters[0].Value = DoorUnitID;

			KryptonAccessController.AccessDataBase.Model.DoorUnitInfo model=new KryptonAccessController.AccessDataBase.Model.DoorUnitInfo();
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
		public KryptonAccessController.AccessDataBase.Model.DoorUnitInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.AccessDataBase.Model.DoorUnitInfo model=new KryptonAccessController.AccessDataBase.Model.DoorUnitInfo();
			if (row != null)
			{
				if(row["DoorUnitID"]!=null && row["DoorUnitID"].ToString()!="")
				{
					model.DoorUnitID=int.Parse(row["DoorUnitID"].ToString());
				}
				if(row["OutPutLockID"]!=null && row["OutPutLockID"].ToString()!="")
				{
					model.OutPutLockID=int.Parse(row["OutPutLockID"].ToString());
				}
				if(row["OutPutTimeLen"]!=null && row["OutPutTimeLen"].ToString()!="")
				{
					model.OutPutTimeLen=int.Parse(row["OutPutTimeLen"].ToString());
				}
				if(row["OpenDoorOverTimeLen"]!=null && row["OpenDoorOverTimeLen"].ToString()!="")
				{
					model.OpenDoorOverTimeLen=int.Parse(row["OpenDoorOverTimeLen"].ToString());
				}
				if(row["ZoneCountLimitEnable"]!=null && row["ZoneCountLimitEnable"].ToString()!="")
				{
					if((row["ZoneCountLimitEnable"].ToString()=="1")||(row["ZoneCountLimitEnable"].ToString().ToLower()=="true"))
					{
						model.ZoneCountLimitEnable=true;
					}
					else
					{
						model.ZoneCountLimitEnable=false;
					}
				}
				if(row["ZoneCountLimitMax"]!=null && row["ZoneCountLimitMax"].ToString()!="")
				{
					model.ZoneCountLimitMax=int.Parse(row["ZoneCountLimitMax"].ToString());
				}
				if(row["ZoneCountLimitMed"]!=null && row["ZoneCountLimitMed"].ToString()!="")
				{
					model.ZoneCountLimitMed=int.Parse(row["ZoneCountLimitMed"].ToString());
				}
				if(row["ZoneCountLimitMin"]!=null && row["ZoneCountLimitMin"].ToString()!="")
				{
					model.ZoneCountLimitMin=int.Parse(row["ZoneCountLimitMin"].ToString());
				}
				if(row["ReadID1"]!=null && row["ReadID1"].ToString()!="")
				{
					model.ReadID1=int.Parse(row["ReadID1"].ToString());
				}
				if(row["ReadIDEnable1"]!=null && row["ReadIDEnable1"].ToString()!="")
				{
					if((row["ReadIDEnable1"].ToString()=="1")||(row["ReadIDEnable1"].ToString().ToLower()=="true"))
					{
						model.ReadIDEnable1=true;
					}
					else
					{
						model.ReadIDEnable1=false;
					}
				}
				if(row["ReadID2"]!=null && row["ReadID2"].ToString()!="")
				{
					model.ReadID2=int.Parse(row["ReadID2"].ToString());
				}
				if(row["ReadIDEnable2"]!=null && row["ReadIDEnable2"].ToString()!="")
				{
					if((row["ReadIDEnable2"].ToString()=="1")||(row["ReadIDEnable2"].ToString().ToLower()=="true"))
					{
						model.ReadIDEnable2=true;
					}
					else
					{
						model.ReadIDEnable2=false;
					}
				}
				if(row["InputStateType"]!=null && row["InputStateType"].ToString()!="")
				{
					model.InputStateType=int.Parse(row["InputStateType"].ToString());
				}
				if(row["ExitButtonID"]!=null && row["ExitButtonID"].ToString()!="")
				{
					model.ExitButtonID=int.Parse(row["ExitButtonID"].ToString());
				}
				if(row["ExitButtonMode"]!=null && row["ExitButtonMode"].ToString()!="")
				{
					model.ExitButtonMode=int.Parse(row["ExitButtonMode"].ToString());
				}
				if(row["ExtiButtonEnable"]!=null && row["ExtiButtonEnable"].ToString()!="")
				{
					if((row["ExtiButtonEnable"].ToString()=="1")||(row["ExtiButtonEnable"].ToString().ToLower()=="true"))
					{
						model.ExtiButtonEnable=true;
					}
					else
					{
						model.ExtiButtonEnable=false;
					}
				}
				if(row["DoorContactID"]!=null && row["DoorContactID"].ToString()!="")
				{
					model.DoorContactID=int.Parse(row["DoorContactID"].ToString());
				}
				if(row["DoorContactMode"]!=null && row["DoorContactMode"].ToString()!="")
				{
					model.DoorContactMode=int.Parse(row["DoorContactMode"].ToString());
				}
				if(row["DoorContactEnable"]!=null && row["DoorContactEnable"].ToString()!="")
				{
					if((row["DoorContactEnable"].ToString()=="1")||(row["DoorContactEnable"].ToString().ToLower()=="true"))
					{
						model.DoorContactEnable=true;
					}
					else
					{
						model.DoorContactEnable=false;
					}
				}
				if(row["DoorPositionID"]!=null && row["DoorPositionID"].ToString()!="")
				{
					model.DoorPositionID=int.Parse(row["DoorPositionID"].ToString());
				}
				if(row["DoorPositionMode"]!=null && row["DoorPositionMode"].ToString()!="")
				{
					model.DoorPositionMode=int.Parse(row["DoorPositionMode"].ToString());
				}
				if(row["DoorPositionEnable"]!=null && row["DoorPositionEnable"].ToString()!="")
				{
					if((row["DoorPositionEnable"].ToString()=="1")||(row["DoorPositionEnable"].ToString().ToLower()=="true"))
					{
						model.DoorPositionEnable=true;
					}
					else
					{
						model.DoorPositionEnable=false;
					}
				}
				if(row["BreakGlassID"]!=null && row["BreakGlassID"].ToString()!="")
				{
					model.BreakGlassID=int.Parse(row["BreakGlassID"].ToString());
				}
				if(row["BreakGlassMode"]!=null && row["BreakGlassMode"].ToString()!="")
				{
					model.BreakGlassMode=int.Parse(row["BreakGlassMode"].ToString());
				}
				if(row["BreakGlassEnable"]!=null && row["BreakGlassEnable"].ToString()!="")
				{
					if((row["BreakGlassEnable"].ToString()=="1")||(row["BreakGlassEnable"].ToString().ToLower()=="true"))
					{
						model.BreakGlassEnable=true;
					}
					else
					{
						model.BreakGlassEnable=false;
					}
				}
				if(row["ElectronicMapID"]!=null && row["ElectronicMapID"].ToString()!="")
				{
					model.ElectronicMapID=int.Parse(row["ElectronicMapID"].ToString());
				}
				if(row["PositionX"]!=null && row["PositionX"].ToString()!="")
				{
					model.PositionX=int.Parse(row["PositionX"].ToString());
				}
				if(row["PositionY"]!=null && row["PositionY"].ToString()!="")
				{
					model.PositionY=int.Parse(row["PositionY"].ToString());
				}
				if(row["StateImageOpen"]!=null && row["StateImageOpen"].ToString()!="")
				{
					model.StateImageOpen=(byte[])row["StateImageOpen"];
				}
				if(row["StateImageClose"]!=null && row["StateImageClose"].ToString()!="")
				{
					model.StateImageClose=(byte[])row["StateImageClose"];
				}
				if(row["StateImageAlarmOpen"]!=null && row["StateImageAlarmOpen"].ToString()!="")
				{
					model.StateImageAlarmOpen=(byte[])row["StateImageAlarmOpen"];
				}
				if(row["StateImageAlarmClose"]!=null && row["StateImageAlarmClose"].ToString()!="")
				{
					model.StateImageAlarmClose=(byte[])row["StateImageAlarmClose"];
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
			strSql.Append("select DoorUnitID,OutPutLockID,OutPutTimeLen,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReadID1,ReadIDEnable1,ReadID2,ReadIDEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable,ElectronicMapID,PositionX,PositionY,StateImageOpen,StateImageClose,StateImageAlarmOpen,StateImageAlarmClose ");
			strSql.Append(" FROM DoorUnitInfo ");
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
			strSql.Append(" DoorUnitID,OutPutLockID,OutPutTimeLen,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReadID1,ReadIDEnable1,ReadID2,ReadIDEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable,ElectronicMapID,PositionX,PositionY,StateImageOpen,StateImageClose,StateImageAlarmOpen,StateImageAlarmClose ");
			strSql.Append(" FROM DoorUnitInfo ");
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
			strSql.Append("select count(1) FROM DoorUnitInfo ");
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
				strSql.Append("order by T.DoorUnitID desc");
			}
			strSql.Append(")AS Row, T.*  from DoorUnitInfo T ");
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
			parameters[0].Value = "DoorUnitInfo";
			parameters[1].Value = "DoorUnitID";
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

