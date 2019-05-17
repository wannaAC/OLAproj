using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace OlaLibrary
{
    /// <summary>
    /// 表示MySql存储过程或存储函数的一个参数。
    /// </summary>
    public sealed class StoredParameter
    {
        public string Name { get; private set; }
        public MySqlDbType Type { get; private set; }
        public ParameterDirection Direction { get; private set; }

        /// <summary>
        /// 构建一个存储参数的唯一途径。
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




    /// <summary>
    /// 与MySql交互的接口。
    /// </summary>
    public sealed class DatabaseService
    {
        MySqlConnection con;
        MySqlCommand cmd;

        /// <summary>
        /// 初始化MySql通信接口。
        /// </summary>
        public DatabaseService()
        {

        }

        public CreateUser(string userName, string password,)
    }
}
