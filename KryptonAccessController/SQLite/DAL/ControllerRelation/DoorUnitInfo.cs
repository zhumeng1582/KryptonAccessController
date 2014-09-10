/**  版本信息模板在安装目录下，可自行修改。
* DoorUnitInfo.cs
*
* 功 能： N/A
* 类 名： DoorUnitInfo
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
	/// 数据访问类:DoorUnitInfo
	/// </summary>
	public partial class DoorUnitInfo
	{
		public DoorUnitInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("DoorUnitID", "DoorUnitInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DoorUnitID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DoorUnitInfo");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DoorUnitID", DbType.Int32,4)			};
			parameters[0].Value = DoorUnitID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DoorUnitInfo(");
			strSql.Append("DoorUnitID,OutPutLockID,OutPutTimeLength,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReaderID1,ReaderEnable1,ReaderID2,ReaderEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable)");
			strSql.Append(" values (");
			strSql.Append("@DoorUnitID,@OutPutLockID,@OutPutTimeLength,@OpenDoorOverTimeLen,@ZoneCountLimitEnable,@ZoneCountLimitMax,@ZoneCountLimitMed,@ZoneCountLimitMin,@ReaderID1,@ReaderEnable1,@ReaderID2,@ReaderEnable2,@InputStateType,@ExitButtonID,@ExitButtonMode,@ExtiButtonEnable,@DoorContactID,@DoorContactMode,@DoorContactEnable,@DoorPositionID,@DoorPositionMode,@DoorPositionEnable,@BreakGlassID,@BreakGlassMode,@BreakGlassEnable)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DoorUnitID", DbType.Int32,4),
					new SQLiteParameter("@OutPutLockID", DbType.Int32,4),
					new SQLiteParameter("@OutPutTimeLength", DbType.Int32,4),
					new SQLiteParameter("@OpenDoorOverTimeLen", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitEnable", DbType.Boolean,1),
					new SQLiteParameter("@ZoneCountLimitMax", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitMed", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitMin", DbType.Int32,4),
					new SQLiteParameter("@ReaderID1", DbType.Int32,4),
					new SQLiteParameter("@ReaderEnable1", DbType.Boolean,1),
					new SQLiteParameter("@ReaderID2", DbType.Int32,4),
					new SQLiteParameter("@ReaderEnable2", DbType.Boolean,1),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@ExitButtonID", DbType.Int32,4),
					new SQLiteParameter("@ExitButtonMode", DbType.Int32,4),
					new SQLiteParameter("@ExtiButtonEnable", DbType.Boolean,1),
					new SQLiteParameter("@DoorContactID", DbType.Int32,4),
					new SQLiteParameter("@DoorContactMode", DbType.Int32,4),
					new SQLiteParameter("@DoorContactEnable", DbType.Boolean,1),
					new SQLiteParameter("@DoorPositionID", DbType.Int32,4),
					new SQLiteParameter("@DoorPositionMode", DbType.Int32,4),
					new SQLiteParameter("@DoorPositionEnable", DbType.Boolean,1),
					new SQLiteParameter("@BreakGlassID", DbType.Int32,4),
					new SQLiteParameter("@BreakGlassMode", DbType.Int32,4),
					new SQLiteParameter("@BreakGlassEnable", DbType.Boolean,1)};
			parameters[0].Value = model.DoorUnitID;
			parameters[1].Value = model.OutPutLockID;
			parameters[2].Value = model.OutPutTimeLength;
			parameters[3].Value = model.OpenDoorOverTimeLen;
			parameters[4].Value = model.ZoneCountLimitEnable;
			parameters[5].Value = model.ZoneCountLimitMax;
			parameters[6].Value = model.ZoneCountLimitMed;
			parameters[7].Value = model.ZoneCountLimitMin;
			parameters[8].Value = model.ReaderID1;
			parameters[9].Value = model.ReaderEnable1;
			parameters[10].Value = model.ReaderID2;
			parameters[11].Value = model.ReaderEnable2;
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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DoorUnitInfo set ");
			strSql.Append("OutPutLockID=@OutPutLockID,");
			strSql.Append("OutPutTimeLength=@OutPutTimeLength,");
			strSql.Append("OpenDoorOverTimeLen=@OpenDoorOverTimeLen,");
			strSql.Append("ZoneCountLimitEnable=@ZoneCountLimitEnable,");
			strSql.Append("ZoneCountLimitMax=@ZoneCountLimitMax,");
			strSql.Append("ZoneCountLimitMed=@ZoneCountLimitMed,");
			strSql.Append("ZoneCountLimitMin=@ZoneCountLimitMin,");
			strSql.Append("ReaderID1=@ReaderID1,");
			strSql.Append("ReaderEnable1=@ReaderEnable1,");
			strSql.Append("ReaderID2=@ReaderID2,");
			strSql.Append("ReaderEnable2=@ReaderEnable2,");
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
			strSql.Append("BreakGlassEnable=@BreakGlassEnable");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@OutPutLockID", DbType.Int32,4),
					new SQLiteParameter("@OutPutTimeLength", DbType.Int32,4),
					new SQLiteParameter("@OpenDoorOverTimeLen", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitEnable", DbType.Boolean,1),
					new SQLiteParameter("@ZoneCountLimitMax", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitMed", DbType.Int32,4),
					new SQLiteParameter("@ZoneCountLimitMin", DbType.Int32,4),
					new SQLiteParameter("@ReaderID1", DbType.Int32,4),
					new SQLiteParameter("@ReaderEnable1", DbType.Boolean,1),
					new SQLiteParameter("@ReaderID2", DbType.Int32,4),
					new SQLiteParameter("@ReaderEnable2", DbType.Boolean,1),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@ExitButtonID", DbType.Int32,4),
					new SQLiteParameter("@ExitButtonMode", DbType.Int32,4),
					new SQLiteParameter("@ExtiButtonEnable", DbType.Boolean,1),
					new SQLiteParameter("@DoorContactID", DbType.Int32,4),
					new SQLiteParameter("@DoorContactMode", DbType.Int32,4),
					new SQLiteParameter("@DoorContactEnable", DbType.Boolean,1),
					new SQLiteParameter("@DoorPositionID", DbType.Int32,4),
					new SQLiteParameter("@DoorPositionMode", DbType.Int32,4),
					new SQLiteParameter("@DoorPositionEnable", DbType.Boolean,1),
					new SQLiteParameter("@BreakGlassID", DbType.Int32,4),
					new SQLiteParameter("@BreakGlassMode", DbType.Int32,4),
					new SQLiteParameter("@BreakGlassEnable", DbType.Boolean,1),
					new SQLiteParameter("@DoorUnitID", DbType.Int32,4)};
			parameters[0].Value = model.OutPutLockID;
			parameters[1].Value = model.OutPutTimeLength;
			parameters[2].Value = model.OpenDoorOverTimeLen;
			parameters[3].Value = model.ZoneCountLimitEnable;
			parameters[4].Value = model.ZoneCountLimitMax;
			parameters[5].Value = model.ZoneCountLimitMed;
			parameters[6].Value = model.ZoneCountLimitMin;
			parameters[7].Value = model.ReaderID1;
			parameters[8].Value = model.ReaderEnable1;
			parameters[9].Value = model.ReaderID2;
			parameters[10].Value = model.ReaderEnable2;
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
			parameters[24].Value = model.DoorUnitID;

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
		public bool Delete(int DoorUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DoorUnitID", DbType.Int32,4)			};
			parameters[0].Value = DoorUnitID;

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
		public bool DeleteList(string DoorUnitIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID in ("+DoorUnitIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo GetModel(int DoorUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DoorUnitID,OutPutLockID,OutPutTimeLength,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReaderID1,ReaderEnable1,ReaderID2,ReaderEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable from DoorUnitInfo ");
			strSql.Append(" where DoorUnitID=@DoorUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DoorUnitID", DbType.Int32,4)			};
			parameters[0].Value = DoorUnitID;

			KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo model=new KryptonAccessController.SQLite.Model.ControllerRelation.DoorUnitInfo();
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
				if(row["OutPutTimeLength"]!=null && row["OutPutTimeLength"].ToString()!="")
				{
					model.OutPutTimeLength=int.Parse(row["OutPutTimeLength"].ToString());
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
				if(row["ReaderID1"]!=null && row["ReaderID1"].ToString()!="")
				{
					model.ReaderID1=int.Parse(row["ReaderID1"].ToString());
				}
				if(row["ReaderEnable1"]!=null && row["ReaderEnable1"].ToString()!="")
				{
					if((row["ReaderEnable1"].ToString()=="1")||(row["ReaderEnable1"].ToString().ToLower()=="true"))
					{
						model.ReaderEnable1=true;
					}
					else
					{
						model.ReaderEnable1=false;
					}
				}
				if(row["ReaderID2"]!=null && row["ReaderID2"].ToString()!="")
				{
					model.ReaderID2=int.Parse(row["ReaderID2"].ToString());
				}
				if(row["ReaderEnable2"]!=null && row["ReaderEnable2"].ToString()!="")
				{
					if((row["ReaderEnable2"].ToString()=="1")||(row["ReaderEnable2"].ToString().ToLower()=="true"))
					{
						model.ReaderEnable2=true;
					}
					else
					{
						model.ReaderEnable2=false;
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DoorUnitID,OutPutLockID,OutPutTimeLength,OpenDoorOverTimeLen,ZoneCountLimitEnable,ZoneCountLimitMax,ZoneCountLimitMed,ZoneCountLimitMin,ReaderID1,ReaderEnable1,ReaderID2,ReaderEnable2,InputStateType,ExitButtonID,ExitButtonMode,ExtiButtonEnable,DoorContactID,DoorContactMode,DoorContactEnable,DoorPositionID,DoorPositionMode,DoorPositionEnable,BreakGlassID,BreakGlassMode,BreakGlassEnable ");
			strSql.Append(" FROM DoorUnitInfo ");
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
			parameters[0].Value = "DoorUnitInfo";
			parameters[1].Value = "DoorUnitID";
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

