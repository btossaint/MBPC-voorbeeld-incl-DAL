using MBPC001.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MBPC001.DAL
{
    /// <summary>
    /// Singleton class for the DAL
    /// More info: https://en.wikipedia.org/wiki/Singleton_pattern
    /// </summary>
    public sealed class DALSingleton
    {
        private static iDAL instance = null;
        private static readonly object padlock = new object();

        private DALSingleton()
        {
        }

        public static iDAL GetInstance()
        {
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        //instance = new MSSQLDAL();
                        instance = new MySQLDAL();
                    }
                    return instance;
                }
            }
        }
    }
}