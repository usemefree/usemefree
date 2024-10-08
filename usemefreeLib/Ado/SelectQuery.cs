using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usemefreeLib.Ado;

public class SelectQuery : getSqlConnection
{
    public DataTable QueryResult(string query)
    {
        DataTable dataTable = new DataTable();
        using (var con = new SqlConnection(getSqlConnection.conString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }

    public bool getScaller(string query)
    {
        DataTable dataTable = new DataTable();
        using (var con = new SqlConnection(getSqlConnection.conString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dataTable);
        }
        return dataTable != null && dataTable.Rows.Count > 0;
    }

    public int InsertUpdate(string query, SqlParameter[] pram, CommandType commandType)
    {
        using (var con = new SqlConnection(getSqlConnection.conString))
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = commandType;
            foreach (var param in pram)
                cmd.Parameters.Add(param);

            con.Open();
            return cmd.ExecuteNonQuery();
        }
        return -1;
    }
}
