using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usemefreeLib.Ado;

public class ScallerValue
{
    public dynamic getScaller(string query, SqlParameter[] pram)
    {
        using (var con = new SqlConnection(getSqlConnection.conString))
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            foreach (var param in pram)
                cmd.Parameters.Add(param);
            con.Open();
            return cmd.ExecuteScalar();
        }
    }
}
