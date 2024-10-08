using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usemefreeLib.Ado;

public class RecordSet
{
    public DataTable getData(string query, SqlParameter[] pram, CommandType commandType,int Timout = 60)
    {
        DataTable dt = new DataTable();
        using (var con = new SqlConnection(getSqlConnection.conString))
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = commandType;
            foreach (var param in pram)
                cmd.Parameters.Add(param);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
        return dt;
    }
}