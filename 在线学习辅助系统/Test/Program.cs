using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        { //创业基础考试
            string s = "server=127.0.0.1;port=3306;user=root;password=testuse;database=learning_mysql;";
            MySqlConnection conn = new MySqlConnection(s);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            conn.ChangeDatabase("mysql");
            cmd.CommandText = "create user xyz identified by '123456'";
            cmd.ExecuteNonQuery();

            //cmd.CommandText = "p1";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@o", MySqlDbType.Int32);
            //cmd.Parameters["@o"].Direction = ParameterDirection.Output;
            //cmd.ExecuteNonQuery();
            //var x = cmd.Parameters;
            //Console.WriteLine(x["@o"].Value.ToString());
            conn.Close();
            
        }
    }

    /// <summary>
    /// 表示MySql存储过程或存储函数的参数，是对MySqlParameter的进一步封装。
    /// </summary>
    public sealed class StoredParameter
    {
        public string Name { get; private set; }
        public MySqlDbType Type { get; private set; }
        public ParameterDirection Direction { get; private set; }

        /// <summary>
        /// 构建一个参数的唯一途径。
        /// </summary>
        /// <param name="name">创建存储过程时指定的参数名</param>
        /// <param name="type">参数类型</param>
        /// <param name="direction">输入参数/输出参数/输入输出参数</param>
        public StoredParameter(string name, MySqlDbType type, ParameterDirection direction)
        {
            Name = name;
            Type = type;
            Direction = direction;
        }
    }
}
