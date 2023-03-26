using Library;
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
            int? id_book = null;
            string name_book = "";
            string date_pub = "";
            string action = "";
            string date_action = "";
            string name_reader = "";
            string cs = @"URI = file:lib.db";
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            Method_buttons.add(cmd, id_book, name_book, date_pub, action, date_action, name_reader);

            //Test for open connection
            Assert.IsTrue(con != null && con.State == System.Data.ConnectionState.Open);

            cmd.CommandText = "SELECT COUNT(*) FROM library where ID_book =@book_id";
            cmd.Parameters.AddWithValue("boo_id", id_book);
            cmd.Prepare();
            cmd.CommandType = System.Data.CommandType.Text;
            int RowCount = 0;

            //Check if data was added to database
            RowCount = Convert.ToInt32(cmd.ExecuteScalar());
            Assert.AreEqual(1, RowCount);
        }
    }
}