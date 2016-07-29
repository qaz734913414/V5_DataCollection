﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using V5_WinLibs.DBHelper;

namespace V5_DataCollection._Class.DAL {
    /// <summary>
    /// 采集库
    /// </summary>
    public class DALContentHelper {
        /// <summary>
        /// 检查任务结果是否存在
        /// </summary>
        /// <param name="taskName">任务名称</param>
        /// <param name="url">采集地址</param>
        /// <returns></returns>
        public static bool ChkExistSpiderResult(string taskName, string url) {
            string LocalSQLiteName = "Data\\Collection\\" + taskName + "\\SpiderResult.db";
            string sql = " Select Count(1) From Content Where HrefSource='" + url + "' ";
            string msg = url;
            object o = SQLiteHelper.ExecuteScalar(LocalSQLiteName,sql);
            if (o != null && V5_Utility.Core.StringHelper.Instance.SetNumber(o) > 0) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取指定内容
        /// </summary>
        /// <param name="taskName">任务名称</param>
        /// <param name="Id">任务Id</param>
        public static object GetContent(string taskName, string Id, string colName) {
            string LocalSQLiteName = "Data\\Collection\\" + taskName + "\\SpiderResult.db";
            string sql = " Select " + colName + " From Content Where Id=" + Id;
            object o = SQLiteHelper.ExecuteScalar( LocalSQLiteName,sql);
            return o;
        }

        /// <summary>
        /// 更新指定的内容
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="Id"></param>
        /// <param name="colName"></param>
        /// <param name="colValue"></param>
        public static void UpdateContent(string taskName, string Id, string colName, string colValue) {
            string LocalSQLiteName = "Data\\Collection\\" + taskName + "\\SpiderResult.db";
            string sql = " Update Content Set " + colName + "='" + colValue + "' Where Id=" + Id;
            object o = SQLiteHelper.Execute(LocalSQLiteName,sql);
        }

        /// <summary>
        /// 获取所有内容
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sCount"></param>
        /// <returns></returns>
        public static DataTable GetContentList(string taskName, int startIndex, int pageSize, ref int sCount) {
            string LocalSQLiteName = "Data\\Collection\\" + taskName + "\\SpiderResult.db";
            string SQL = "Select Count(*) From Content ";
            sCount = V5_Utility.Core.StringHelper.Instance.SetNumber(SQLiteHelper.ExecuteScalar(LocalSQLiteName,SQL));

            SQL = string.Format("Select * From Content Order By Id Desc Limit {0},{1}", startIndex, pageSize);
            DataTable dt = SQLiteHelper.Query1(LocalSQLiteName,SQL).Tables[0];
            return dt;
        }
    }
}
