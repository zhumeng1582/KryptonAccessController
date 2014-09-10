/**  版本信息模板在安装目录下，可自行修改。
* AuxiliaryUnit.cs
*
* 功 能： N/A
* 类 名： AuxiliaryUnit
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:06:49   N/A    初版
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
	/// 数据访问类:AuxiliaryUnit
	/// </summary>
	public partial class AuxiliaryUnit
	{
		public AuxiliaryUnit()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("AuxiliaryUnitID", "AuxiliaryUnit"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AuxiliaryUnitID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AuxiliaryUnit");
			strSql.Append(" where AuxiliaryUnitID=@AuxiliaryUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AuxiliaryUnitID", DbType.Int32,4)			};
			parameters[0].Value = AuxiliaryUnitID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AuxiliaryUnit(");
			strSql.Append("AuxiliaryUnitID,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable)");
			strSql.Append(" values (");
			strSql.Append("@AuxiliaryUnitID,@AuxOutPutPointID,@InputStateType,@FireSensingID,@FireSensingMode,@FireSensingEnable,@TamperSensingID,@TamperSensingMode,@TamperSensingEnable,@LowVoltageID,@LowVoltageMode,@LowVoltageEnable,@PowerOutageID,@PowerOutageMode,@PowerOutageEnable)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AuxiliaryUnitID", DbType.Int32,4),
					new SQLiteParameter("@AuxOutPutPointID", DbType.Int32,4),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@FireSensingID", DbType.Int32,4),
					new SQLiteParameter("@FireSensingMode", DbType.Int32,4),
					new SQLiteParameter("@FireSensingEnable", DbType.Boolean,1),
					new SQLiteParameter("@TamperSensingID", DbType.Int32,4),
					new SQLiteParameter("@TamperSensingMode", DbType.Int32,4),
					new SQLiteParameter("@TamperSensingEnable", DbType.Boolean,1),
					new SQLiteParameter("@LowVoltageID", DbType.Int32,4),
					new SQLiteParameter("@LowVoltageMode", DbType.Int32,4),
					new SQLiteParameter("@LowVoltageEnable", DbType.Boolean,1),
					new SQLiteParameter("@PowerOutageID", DbType.Int32,4),
					new SQLiteParameter("@PowerOutageMode", DbType.Int32,4),
					new SQLiteParameter("@PowerOutageEnable", DbType.Boolean,1)};
			parameters[0].Value = model.AuxiliaryUnitID;
			parameters[1].Value = model.AuxOutPutPointID;
			parameters[2].Value = model.InputStateType;
			parameters[3].Value = model.FireSensingID;
			parameters[4].Value = model.FireSensingMode;
			parameters[5].Value = model.FireSensingEnable;
			parameters[6].Value = model.TamperSensingID;
			parameters[7].Value = model.TamperSensingMode;
			parameters[8].Value = model.TamperSensingEnable;
			parameters[9].Value = model.LowVoltageID;
			parameters[10].Value = model.LowVoltageMode;
			parameters[11].Value = model.LowVoltageEnable;
			parameters[12].Value = model.PowerOutageID;
			parameters[13].Value = model.PowerOutageMode;
			parameters[14].Value = model.PowerOutageEnable;

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
		public bool Update(KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AuxiliaryUnit set ");
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
			strSql.Append("PowerOutageEnable=@PowerOutageEnable");
			strSql.Append(" where AuxiliaryUnitID=@AuxiliaryUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AuxOutPutPointID", DbType.Int32,4),
					new SQLiteParameter("@InputStateType", DbType.Int32,4),
					new SQLiteParameter("@FireSensingID", DbType.Int32,4),
					new SQLiteParameter("@FireSensingMode", DbType.Int32,4),
					new SQLiteParameter("@FireSensingEnable", DbType.Boolean,1),
					new SQLiteParameter("@TamperSensingID", DbType.Int32,4),
					new SQLiteParameter("@TamperSensingMode", DbType.Int32,4),
					new SQLiteParameter("@TamperSensingEnable", DbType.Boolean,1),
					new SQLiteParameter("@LowVoltageID", DbType.Int32,4),
					new SQLiteParameter("@LowVoltageMode", DbType.Int32,4),
					new SQLiteParameter("@LowVoltageEnable", DbType.Boolean,1),
					new SQLiteParameter("@PowerOutageID", DbType.Int32,4),
					new SQLiteParameter("@PowerOutageMode", DbType.Int32,4),
					new SQLiteParameter("@PowerOutageEnable", DbType.Boolean,1),
					new SQLiteParameter("@AuxiliaryUnitID", DbType.Int32,4)};
			parameters[0].Value = model.AuxOutPutPointID;
			parameters[1].Value = model.InputStateType;
			parameters[2].Value = model.FireSensingID;
			parameters[3].Value = model.FireSensingMode;
			parameters[4].Value = model.FireSensingEnable;
			parameters[5].Value = model.TamperSensingID;
			parameters[6].Value = model.TamperSensingMode;
			parameters[7].Value = model.TamperSensingEnable;
			parameters[8].Value = model.LowVoltageID;
			parameters[9].Value = model.LowVoltageMode;
			parameters[10].Value = model.LowVoltageEnable;
			parameters[11].Value = model.PowerOutageID;
			parameters[12].Value = model.PowerOutageMode;
			parameters[13].Value = model.PowerOutageEnable;
			parameters[14].Value = model.AuxiliaryUnitID;

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
		public bool Delete(int AuxiliaryUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AuxiliaryUnit ");
			strSql.Append(" where AuxiliaryUnitID=@AuxiliaryUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AuxiliaryUnitID", DbType.Int32,4)			};
			parameters[0].Value = AuxiliaryUnitID;

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
		public bool DeleteList(string AuxiliaryUnitIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AuxiliaryUnit ");
			strSql.Append(" where AuxiliaryUnitID in ("+AuxiliaryUnitIDlist + ")  ");
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit GetModel(int AuxiliaryUnitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AuxiliaryUnitID,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable from AuxiliaryUnit ");
			strSql.Append(" where AuxiliaryUnitID=@AuxiliaryUnitID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AuxiliaryUnitID", DbType.Int32,4)			};
			parameters[0].Value = AuxiliaryUnitID;

			KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit model=new KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit();
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
		public KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit model=new KryptonAccessController.SQLite.Model.ControllerRelation.AuxiliaryUnit();
			if (row != null)
			{
				if(row["AuxiliaryUnitID"]!=null && row["AuxiliaryUnitID"].ToString()!="")
				{
					model.AuxiliaryUnitID=int.Parse(row["AuxiliaryUnitID"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AuxiliaryUnitID,AuxOutPutPointID,InputStateType,FireSensingID,FireSensingMode,FireSensingEnable,TamperSensingID,TamperSensingMode,TamperSensingEnable,LowVoltageID,LowVoltageMode,LowVoltageEnable,PowerOutageID,PowerOutageMode,PowerOutageEnable ");
			strSql.Append(" FROM AuxiliaryUnit ");
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
			strSql.Append("select count(1) FROM AuxiliaryUnit ");
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
				strSql.Append("order by T.AuxiliaryUnitID desc");
			}
			strSql.Append(")AS Row, T.*  from AuxiliaryUnit T ");
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
			parameters[0].Value = "AuxiliaryUnit";
			parameters[1].Value = "AuxiliaryUnitID";
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

