/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 11.09.2013
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

using System.Windows.Forms;

namespace managment
{
	/// <summary>
	/// Description of Mysql.
	/// </summary>
	public class Mysql
	{

		private MySqlConnection myConnection;
		
		public Mysql()
		{
			string Connect="Database=sarnii;Data Source=sarnii.ru;User Id=sarnii;Password=Dominator13;charset=utf8;";
			myConnection = new MySqlConnection(Connect);
		}
		
		public Dictionary<int, Dictionary<string, string>> Get(string table, int id = 0)
		{
			string CommandText = "SELECT * FROM " + table;
			if(id != 0) CommandText += " WHERE id="+id;
			MySqlCommand command = new MySqlCommand(CommandText, myConnection);
			
			var result = new Dictionary<int, Dictionary<string, string>>();
			
			MySqlDataReader reader;
			try
			{
				command.Connection.Open();
				reader = command.ExecuteReader();
				int i = 0;
				while (reader.Read())
				{				
					var field = new Dictionary<string, string>();
					for(int y = 0; y < reader.FieldCount; y++)
					{
						field[reader.GetName(y).ToString()] = reader[y].ToString();						
					}
					
					result[i] = field;
					i++;
				}
				reader.Close();
			}
			finally
			{
				myConnection.Close();
			}
			return result;
		}

        public int GetType(string name)
        {
            string CommandText = "SELECT id FROM contract_type WHERE title='" + name + "'";
            MySqlCommand command = new MySqlCommand(CommandText, myConnection);

            var result = new Dictionary<int, Dictionary<string, string>>();

            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    var field = new Dictionary<string, string>();
                    for (int y = 0; y < reader.FieldCount; y++)
                    {
                        field[reader.GetName(y).ToString()] = reader[y].ToString();
                    }

                    result[i] = field;
                    i++;
                }
                reader.Close();
            }
            finally
            {
                myConnection.Close();
            }
            return Convert.ToInt32(result[0]["id"]);
        }
        
        public Dictionary<int, Dictionary<string, string>> GetDate(string date)
        {
            string CommandText = "SELECT * FROM contracts WHERE date_end < '" + date + "'";
            MySqlCommand command = new MySqlCommand(CommandText, myConnection);

            var result = new Dictionary<int, Dictionary<string, string>>();

            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    var field = new Dictionary<string, string>();
                    for (int y = 0; y < reader.FieldCount; y++)
                    {
                        field[reader.GetName(y).ToString()] = reader[y].ToString();
                    }

                    result[i] = field;
                    i++;
                }
                reader.Close();
            }
            finally
            {
                myConnection.Close();
            }
            return result;
        }
		
		public void Set(string table, Dictionary<string, string> data, int id = 0)
		{
			List<string> name = new List<string>(data.Keys);
			
			
			string commandText = "INSERT INTO "+table+" ("+string.Join(",", name.ToArray())+") VALUES (@"+string.Join(", @", name.ToArray())+")";
			MySqlCommand cmd = new MySqlCommand(commandText, myConnection);
			
			try
			{
				cmd.Connection.Open();
				cmd.Prepare();
				
				foreach(var item in data)
				{
					cmd.Parameters.AddWithValue("@"+item.Key, item.Value);			
				}
				//MessageBox.Show(cmd.Parameters.ToString());
				cmd.ExecuteNonQuery();
			}
			finally
			{
				myConnection.Close();
			}
		}
		
		public  void Delete(string id)
		{
			string commandText = "DELETE FROM contracts WHERE id = " + id;
			MySqlCommand cmd = new MySqlCommand(commandText, myConnection);
			
			try
			{
				cmd.Connection.Open();
				cmd.ExecuteNonQuery();
			}
			finally
			{
				myConnection.Close();
			}
		}
	}
}
