//Кондиляброва Вероника
//414 группа
//Вариант 8
//Практическая работа 4
//БД хранения списка книг в библиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Library
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private static SQLiteConnection con;
        private static SQLiteCommand cmd;
        // Создаем объект DataAdapter
        private static SQLiteDataAdapter adapter;
        // Создаем объект Dataset
        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable();
        public static List<int?> list_id_book = new List<int?>();
        bool verify;
        private static void setconnection()
        {
            con = new SQLiteConnection("Data Source=lib.db;version=3;New=False;Compress=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file_path = "check1.txt";
            bool check;
            using (var sr = new StreamReader(file_path))
            {

                var str_check = sr.ReadLine();
                try
                {
                    bool.TryParse(str_check, out verify);
                    check = verify;
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не читается.");
                    return;
                }
                if (check == false)
                {
                    ToolStripMenuItem.Text = "Скрыть";
                    MessageBox.Show("Кондиляброва Вероника 414 группа Вариант 8\nПрактическая работа 4\nБД хранения списка книг в библиотеке");
                }
                else
                {
                    ToolStripMenuItem.Text = "Показать";
                }
            }
            LoadData();

        }
        public void LoadData()
        {
            setconnection();
            //Открываем подключение к базе данных
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "select * from library";
            adapter = new SQLiteDataAdapter(CommandText, con);
            ds.Reset();
            // Заполняем Dataset
            adapter.Fill(ds);
            // Отображаем данные
            //Объект DataSet содержит таблицы, которые представлены типом DataTable.
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            //Закрываем подключение к базе данных
            con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!list_id_book.Contains(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)))
                {
                    list_id_book.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                }

            }
        }
        private bool change_state(bool ver)
        {
            string file_path = "check1.txt";
            using (StreamWriter sw = new StreamWriter(file_path, false))
            {
                if (ver)
                {
                    try
                    {
                        sw.WriteLine("true");
                        ToolStripMenuItem.Text = "Показать";
                        sw.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Файл не открывается");

                    }
                    return true;
                }
                else
                {
                    sw.WriteLine("false");
                    ToolStripMenuItem.Text = "Скрыть";
                    sw.Close();
                    return false;
                }
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem.Text == "Скрыть")
            {
                ToolStripMenuItem.Checked = true;
                ToolStripMenuItem.Text = "Показать";
            }
            else if (ToolStripMenuItem.Text == "Показать")
            {
                ToolStripMenuItem.Checked = false;
                ToolStripMenuItem.Text = "Скрыть";
            }
            verify = ToolStripMenuItem.Checked;
            change_state(verify);
        }

        private void add_Click(object sender, EventArgs e)
        {
            //id
            int? id_book = null;
            try
            {
                id_book = Convert.ToInt32(textBox_id.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный Id");
                return;
            }

            //book name
            string name_book = "";
            try
            {
                name_book = textBox_name_book.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //pub
            string date_pub = "";
            DateTime dDate;
            try
            {
                date_pub = textBox_date_pub.Text;
                if (DateTime.TryParse(date_pub, out dDate))
                {
                    String.Format("{0:yyyy/MM/d}", dDate);
                }
                else
                {
                    MessageBox.Show("Дата вводится другим форматом: гггг-мм-дд");
                    return;
                }
                check_date(date_pub, ref ch_date);
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }


            //action
            string action = "";
            if (comboBox1.SelectedIndex == 0)
            {
                action = "На руках";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                action = "В библиотеке";
            }
            else
            {
                MessageBox.Show("Выберите какой-нибудь вариант");
            }

            // date action
            string date_action = "";
            DateTime dDate_action;
            try
            {
                date_action = textBox_date_action.Text;
                if (DateTime.TryParse(date_action, out dDate_action))
                {
                    String.Format("{0:yyyy/MM/d}", dDate_action);
                }
                else
                {
                    MessageBox.Show("Дата вводится другим форматом: гггг-мм-дд");
                    return;
                }
                check_date(date_pub, ref ch_date);
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //name reader
            string name_reader = "";
            try
            {
                name_reader = textBox_name_reader.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            if (id_book == 0 || name_book == "" || date_pub == "" || action == "" || date_action == "" || (name_reader == "" && action == "На руках"))
            {
                MessageBox.Show("Все поля обязательно должны быть заполнены.");
            }
            else if (ch_date == false)
            {
                return;
            }
            else 
            {
                if (list_id_book.Contains(id_book))
                {
                    MessageBox.Show("Запись №" + id_book + " уже существует");
                }
                else
                {
                    try
                    {
                        string cs = @"URI = file:lib.db";
                        var con = new SQLiteConnection(cs);
                        con.Open();
                        var cmd = new SQLiteCommand(con);
                        Method_buttons.add(cmd, id_book, name_book, date_pub, action, date_action, name_reader);
                        LoadData();
                        list_id_book.Add(id_book);
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Невозможно добавить данные");
                    }
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //id
            int? id_book = null;
            try
            {
                id_book = Convert.ToInt32(textBox_id.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный Id");
                return;
            }

            //book name
            string name_book = "";
            try
            {
                name_book = textBox_name_book.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //pub
            string date_pub = "";

            DateTime dDate;
            try
            {
                date_pub = textBox_date_pub.Text;
                if (DateTime.TryParse(date_pub, out dDate))
                {
                    String.Format("{0:yyyy/MM/dd}", dDate);
                }
                else
                {
                    MessageBox.Show("Введите корректную дату.\n(формат даты: гггг-мм-дд)");
                    return;
                }
                check_date(date_pub, ref ch_date);
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }


    //action
    string action = "";
            if (comboBox1.SelectedIndex == 0)
            {
                action = "На руках";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                action = "В библиотеке";
            }
            else
            {
                MessageBox.Show("Выберите какой-нибудь вариант");
            }

            // date action
            string date_action = "";
            DateTime dDate_action;
            try
            {
                date_action = textBox_date_action.Text;
                if (DateTime.TryParse(date_action, out dDate_action) || date_action=="")
                {
                    String.Format("{0:yyyy/MM/d}", dDate_action);
                }
                else
                {
                    MessageBox.Show("Дата вводится другим форматом: гггг-мм-дд");
                    return;
                }
                if (check_date(date_pub, ref ch_date) == false)
                {
                    MessageBox.Show("Введите корректную дату");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //name reader
            string name_reader = "";
            try
            {
                name_reader = textBox_name_reader.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }


            //проверка чтобы все поля были заполнены
            if (id_book == 0 || name_book == "" || date_pub == "" || action == "" || date_action == "" || (name_reader == "" && action == "На руках"))
            {
                MessageBox.Show("Все поля обязательно должны быть заполнены.");
            }
            else if (ch_date == false)
                {
                    return;
                }
            else
            {
                try
                {
                    string cs = @"URI = file:lib.db";
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);
                    Method_buttons.edit(cmd, id_book, date_pub, name_reader);
                    LoadData();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно изменить данные");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index= dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text= dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox_name_book.Text= dataGridView1.Rows[row_index].Cells[1].Value.ToString(); 
            textBox_date_pub.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString(); 
            comboBox1.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString(); 
            textBox_date_action.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString(); 
            textBox_name_reader.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //id
            int? id_book = null;
            try
            {
                id_book = Convert.ToInt32(textBox_id.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный Id");
                return;
            }

            //book name
            string name_book = "";
            try
            {
                name_book = textBox_name_book.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //pub
            string date_pub = "";
            DateTime dDate;
            try
            {
                date_pub = textBox_date_pub.Text;
                if(DateTime.TryParse(date_pub, out dDate))
                {
                    String.Format("{0:yyyy/MM/d}", dDate);
                }
                else
                {
                    MessageBox.Show("Дата вводится другим форматом: гггг-мм-дд");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }


            //action
            string action = "";
            if (comboBox1.SelectedIndex == 0)
            {
                action = "На руках";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                action = "В библиотеке";
            }
            else
            {
                MessageBox.Show("Выберите какой-нибудь вариант");
            }

            // date action
            string date_action = "";
            DateTime dDate_action;
            try
            {
                date_action = textBox_date_action.Text;
                if (DateTime.TryParse(date_action, out dDate_action))
                {
                    String.Format("{0:yyyy/MM/d}", dDate_action);
                }
                else
                {
                    MessageBox.Show("Дата вводится другим форматом: гггг-мм-дд");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            //name reader
            string name_reader = "";
            try
            {
                name_reader = textBox_name_reader.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Удалить", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    string cs = @"URI = file:lib.db";
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);
                    Method_buttons.delete(cmd, id_book);
                    LoadData();
                    con.Close();
                    list_id_book.Remove(id_book);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно удалить данные");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }



        bool ch_date = true;
        bool check_date(string date, ref bool ch_date)
        {
            string str_year = date.Substring(0,4);
            int int_year = Convert.ToInt32(str_year);
            if (int_year > 2023)
            {
                
                ch_date = false;
            }
            string str_month = date.Substring(5, 2);
            int int_month = Convert.ToInt32(str_month);
            if (int_month > 12)
            {
                
                ch_date = false;
            }
            string str_day = date.Substring(8, 2);
            int int_day = Convert.ToInt32(str_day);
            if (int_day > 31)
            {
                
                ch_date = false;
            }
            return ch_date;
            //if (int_month == 2 && int_day > 29)
            //{
            //    MessageBox.Show("Введите корректную дату");
            //    return;
            //}
        }
    }
}
