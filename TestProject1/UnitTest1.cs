using Library;
using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int? id_book = 1;
            string name_book = "Мальчик в полосатой пижаме";
            string date_pub = "2014-10-20";
            string action = "В библиотеке";
            string date_action = "2016-04-06";
            string name_reader = "";
            string cs = @"URI = file:lib.db";
            var con = new SQLiteConnection(cs);
            con.Open();


            var cmd = new SQLiteCommand(con);
            Method_buttons.add(cmd, id_book, name_book, date_pub, action, date_action, name_reader);
            cmd.ExecuteNonQuery();
            Assert.IsTrue(con != null && con.State == System.Data.ConnectionState.Open);
            cmd.CommandText = "SELECT COUNT(*) FROM library where ID_book =@id";
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.Prepare();
            cmd.CommandType = System.Data.CommandType.Text;
            int RowCount = 0;
            RowCount = Convert.ToInt32(cmd.ExecuteScalar());
            Assert.AreEqual(1, RowCount);

            Method_buttons.edit(cmd, id_book, date_pub, name_reader);
            cmd.ExecuteNonQuery();
            Assert.IsTrue(con != null && con.State == System.Data.ConnectionState.Open);
            cmd.CommandText = "SELECT COUNT(*) FROM library WHERE ID_book=@id";
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.Parameters.AddWithValue("pub_date", date_pub);
            cmd.Parameters.AddWithValue("reader_name", name_reader);
            RowCount = 0;
            RowCount = Convert.ToInt32(cmd.ExecuteScalar());
            Assert.AreEqual(1, RowCount);

            Method_buttons.delete(cmd, id_book);
            cmd.ExecuteNonQuery();
            Assert.IsTrue(con != null && con.State == System.Data.ConnectionState.Open);
            cmd.CommandText = "SELECT COUNT(*) FROM library WHERE ID_book=@id";
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.CommandType = System.Data.CommandType.Text;
            RowCount = 0;
            RowCount = Convert.ToInt32(cmd.ExecuteScalar());
            Assert.AreEqual(0, RowCount);

            con.Close();

            Assert.IsTrue(con != null && con.State == System.Data.ConnectionState.Closed);
        }
    }
}
