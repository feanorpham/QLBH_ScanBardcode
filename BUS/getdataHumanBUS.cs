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
    public class getdataHumanBUS
    {
        public dbConnect db = new dbConnect();
        public Human human = new Human();
        public DataTable getHuman(Human human)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getName '" + human.UserName + "'";
            return db.ExeReader(cmd);
        }
    }
}
