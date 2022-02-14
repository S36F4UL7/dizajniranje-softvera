using SloziSliku_80_2018.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloziSliku_80_2018
{
    class GameDB
    {
        SqlConnection con = DbConnection.Instance;

        public List<Game> getGames(int row, int col)
        {
            List<Game> games = new List<Game>();

            con.Open();
            string query = "select top 10 * from game where row = " + row + " and col = " + col + " order by moveCount asc, time asc";

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Game game = new Game
                {
                    ID = int.Parse(reader["ID"].ToString()),
                    username = reader["username"].ToString(),
                    col = int.Parse(reader["col"].ToString()),
                    row = int.Parse(reader["row"].ToString()),
                    moveCount = int.Parse(reader["moveCount"].ToString()),
                    time = reader["time"].ToString(),
                };
                games.Add(game);
            }
            con.Close();

            return games;
        }

        public void insertGame(string username, int col, int row, int moveCount, string time)
        {
            string query = "insert into game values(@username,@col,@row,@moveCount,@time)";
            SqlCommand command = new SqlCommand(query, con);

            con.Open();
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@col", col);
            command.Parameters.AddWithValue("@row", row);
            command.Parameters.AddWithValue("@moveCount", moveCount);
            command.Parameters.AddWithValue("@time", time);

            int res = command.ExecuteNonQuery();
            con.Close();
            if (res > 0)
            {
                MessageBox.Show("Rezultat upisan!");
            }
            else
            {
                MessageBox.Show("Greska! Rezultat nije upisan!");
            }
        }
    }
}
