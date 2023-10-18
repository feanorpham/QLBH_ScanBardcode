using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class LoginBus
    {
        public dbConnect db = new dbConnect();
        public UserName userName = new UserName();
        public DataTable login(UserName userName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec LoginUsers '" + userName.Users + "','" + userName.Password + "'";
            return db.ExeReader(cmd);
        }
    }
}
