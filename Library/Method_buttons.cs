using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Method_buttons
    {
        public void add(SQLiteCommand cmd, int? id_book,string name_book,
            string date_pub,string action,string date_action, string name_reader)
        {
            //Возвращает или задает SQL для выполнения в базе данных.
            cmd.CommandText = 
                "Insert into library(ID_book, Name_book, Date_of_pub, Action, Date_action, Name_reader) values (@id, @book_name, @pub_date, @action, @action_date, @reader_name)";
            //Возвращает коллекцию параметров, используемых командой .
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.Parameters.AddWithValue("book_name", name_book);
            cmd.Parameters.AddWithValue("pub_date", date_pub);
            cmd.Parameters.AddWithValue("action", action);
            cmd.Parameters.AddWithValue("action_date", date_action);
            cmd.Parameters.AddWithValue("reader_name", name_reader);
            //Создает подготовленную версию команды в базе данных.
            cmd.Prepare();
            //Выполняет для CommandText базы данных.
            cmd.ExecuteNonQuery();

        }

        public void edit(SQLiteCommand cmd, int? id_book, string date_pub, string name_reader)
        {
            cmd.CommandText =
                "update library set Date_of_pub=@pub_date, Name_reader=@reader_name WHERE ID_book=@id";
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.Parameters.AddWithValue("pub_date", date_pub);
            cmd.Parameters.AddWithValue("reader_name", name_reader);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        public void delete(SQLiteCommand cmd, int? id_book)
        {
            cmd.CommandText =
                "delete from library WHERE ID_book=@id";
            cmd.Parameters.AddWithValue("id", id_book);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
    }
}
