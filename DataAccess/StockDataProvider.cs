﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StockDataProvider
    {
        public StockDataProvider() { }
        public string ConnectionString { get; set; }
        public StockDataProvider(string connectionString) => ConnectionString = connectionString;
        public void CloseConnection(SqlConnection connection) => connection.Close();
        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                ParameterName = name,
                DbType = dbType,
                Size = size,
                Direction = direction,
                Value = value
            };
        }
        public IDataReader GetDataReader(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        public void UpdateDB(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType= commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }
    }
}
