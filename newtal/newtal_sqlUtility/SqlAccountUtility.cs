using newtal_core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtal_sqlUtility
{
    public class SqlAccountUtility
    {
        private string _connectionStringName;

        //constructor
        public SqlAccountUtility(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
        }

        //Add
        public Account AddAccount(Account accObj)
        {
            throw new NotImplementedException();
        }

        //Update
        public Account UpdateAccount(Account accObj)
        {
            throw new NotImplementedException();
        }

        //Delete
        public void DeleteAccount(Account accObj)
        {
            throw new NotImplementedException();
        }

        //GetAll
        public List<Account> GetAllAccounts()
        {
            List<Account> allAccounts;
            DbConnection conn = GetConnection();
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM USER";

            //execute query
            try
            {
                conn.Open();
                DbDataReader reader = cmd.ExecuteReader();
                allAccounts = MapFromSqlReader(reader);
            }
            catch (Exception ex)
            {
                throw;
            }

            if (allAccounts == null)
            {
                return new List<Account>(); 
            }
            else
            {
                return allAccounts;
            }

            
        }
        
        //Connection Object Helper
        private DbConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings[_connectionStringName].ConnectionString;

            return conn;
        }

        //MapFromSqlReader
        private List<Account> MapFromSqlReader(DbDataReader reader)
        {
            //return list of accounts
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account accDTO = new Account()
                {
                    AccountID = (int)reader["AccountID"],
                    Name = (string)reader["Name"],
                    StartYear = (DateTime)reader["StartYear"],
                    EndYear = (DateTime)reader["EndYear"]
                };

                accounts.Add(accDTO);


            }
            return accounts;
        }

        //BuildParameters
        private DbParameterCollection BuildParameters(Account accObj)
        {
            throw new NotImplementedException();
        }
    }
}
