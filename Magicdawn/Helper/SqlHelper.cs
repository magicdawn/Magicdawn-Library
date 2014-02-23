using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 介绍
/*
 *sql helper 非静态类
 *
 *分为 nonwuery scalar datareader 以及用adapter实现的datatable
 *
 */

#endregion

namespace Magicdawn
{
    /// <summary>
    /// 分为 nonwuery scalar datareader 以及用adapter实现的datatable
    /// </summary>
    public class SqlHelper
    {
        //连接字符串
        public  string ConnStr = ConfigurationManager.ConnectionStrings["Magicdawn"]
            != null ? ConfigurationManager.ConnectionStrings["Magicdawn"].ConnectionString
            : string.Empty;

        public SqlHelper(string connStr)
        {
            this.ConnStr = connStr;
        }

        #region 标量结果ExecuteScalar
        /// <summary>
        /// 标量结果ExecuteScalar
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="cmdType">(sql语句 or 存储过程)可选参数</param>
        /// <param name="paras">sql参数,sql语句,用命名参数实现</param>
        /// <returns>Object结果</returns>
        public object ExecuteScalar(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    cmd.Parameters.Clear();
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region 非查询操作ExecuteNonQuery
        /// <summary>
        /// 非查询操作ExecuteNonQuery
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="cmdType">(sql语句 or 存储过程)可选参数</param>
        /// <param name="paras">sql参数,sql语句,用命名参数实现</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    cmd.Parameters.Clear();
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 查询操作ExecuteTable
        /// <summary>
        /// 查询操作,返回DataTable
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="cmdType">(sql语句 or 存储过程)可选参数</param>
        /// <param name="paras">sql参数,sql语句,用命名参数实现</param>
        /// <returns>返回DataTable</returns>
        public DataTable ExecuteTable(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.CommandType = cmdType;
                    adapter.SelectCommand.Parameters.Clear();
                    if (paras != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(paras);
                    }
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        #endregion

        #region 查询操作,提供DataReader
        /// <summary>
        /// 查询操作,提供DataReader
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="cmdType">(sql语句 or 存储过程)可选参数</param>
        /// <param name="paras">sql参数,sql语句,用命名参数实现</param>
        /// <returns>DataReader</returns>
        public SqlDataReader ExecuteReader(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Clear();
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        #endregion
    }
}