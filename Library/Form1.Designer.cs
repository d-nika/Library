namespace Library
{
    partial class form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.name_book_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.date_pub_label = new System.Windows.Forms.Label();
            this.action_label = new System.Windows.Forms.Label();
            this.date_action_label = new System.Windows.Forms.Label();
            this.name_reader_label = new System.Windows.Forms.Label();
            this.textBox_name_book = new System.Windows.Forms.TextBox();
            this.textBox_date_pub = new System.Windows.Forms.TextBox();
            this.textBox_date_action = new System.Windows.Forms.TextBox();
            this.textBox_name_reader = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(559, 42);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 47);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.Location = new System.Drawing.Point(537, 124);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(170, 47);
            this.edit.TabIndex = 2;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(559, 207);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 47);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_label.Location = new System.Drawing.Point(50, 42);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(74, 20);
            this.id_label.TabIndex = 4;
            this.id_label.Text = "Id книги";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(296, 39);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(186, 22);
            this.textBox_id.TabIndex = 5;
            // 
            // name_book_label
            // 
            this.name_book_label.AutoSize = true;
            this.name_book_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_book_label.Location = new System.Drawing.Point(50, 83);
            this.name_book_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_book_label.Name = "name_book_label";
            this.name_book_label.Size = new System.Drawing.Size(143, 20);
            this.name_book_label.TabIndex = 6;
            this.name_book_label.Text = "Название книги";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "На руках",
            "В библиотеке"});
            this.comboBox1.Location = new System.Drawing.Point(296, 162);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // date_pub_label
            // 
            this.date_pub_label.AutoSize = true;
            this.date_pub_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_pub_label.Location = new System.Drawing.Point(50, 124);
            this.date_pub_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_pub_label.Name = "date_pub_label";
            this.date_pub_label.Size = new System.Drawing.Size(154, 20);
            this.date_pub_label.TabIndex = 8;
            this.date_pub_label.Text = "Дата публикации";
            // 
            // action_label
            // 
            this.action_label.AutoSize = true;
            this.action_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_label.Location = new System.Drawing.Point(50, 166);
            this.action_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action_label.Name = "action_label";
            this.action_label.Size = new System.Drawing.Size(68, 20);
            this.action_label.TabIndex = 9;
            this.action_label.Text = "Статус";
            // 
            // date_action_label
            // 
            this.date_action_label.AutoSize = true;
            this.date_action_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_action_label.Location = new System.Drawing.Point(50, 207);
            this.date_action_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_action_label.Name = "date_action_label";
            this.date_action_label.Size = new System.Drawing.Size(219, 20);
            this.date_action_label.TabIndex = 10;
            this.date_action_label.Text = "Дата изменения статуса";
            // 
            // name_reader_label
            // 
            this.name_reader_label.AutoSize = true;
            this.name_reader_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_reader_label.Location = new System.Drawing.Point(50, 248);
            this.name_reader_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_reader_label.Name = "name_reader_label";
            this.name_reader_label.Size = new System.Drawing.Size(127, 20);
            this.name_reader_label.TabIndex = 11;
            this.name_reader_label.Text = "Имя читателя";
            // 
            // textBox_name_book
            // 
            this.textBox_name_book.Location = new System.Drawing.Point(296, 81);
            this.textBox_name_book.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name_book.Name = "textBox_name_book";
            this.textBox_name_book.Size = new System.Drawing.Size(186, 22);
            this.textBox_name_book.TabIndex = 12;
            // 
            // textBox_date_pub
            // 
            this.textBox_date_pub.Location = new System.Drawing.Point(296, 122);
            this.textBox_date_pub.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_date_pub.Name = "textBox_date_pub";
            this.textBox_date_pub.Size = new System.Drawing.Size(186, 22);
            this.textBox_date_pub.TabIndex = 13;
            // 
            // textBox_date_action
            // 
            this.textBox_date_action.Location = new System.Drawing.Point(296, 206);
            this.textBox_date_action.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_date_action.Name = "textBox_date_action";
            this.textBox_date_action.Size = new System.Drawing.Size(186, 22);
            this.textBox_date_action.TabIndex = 14;
            // 
            // textBox_name_reader
            // 
            this.textBox_name_reader.Location = new System.Drawing.Point(296, 248);
            this.textBox_name_reader.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name_reader.Name = "textBox_name_reader";
            this.textBox_name_reader.Size = new System.Drawing.Size(186, 22);
            this.textBox_name_reader.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "Справка";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.textBox_name_reader);
            this.Controls.Add(this.textBox_date_action);
            this.Controls.Add(this.textBox_date_pub);
            this.Controls.Add(this.textBox_name_book);
            this.Controls.Add(this.name_reader_label);
            this.Controls.Add(this.date_action_label);
            this.Controls.Add(this.action_label);
            this.Controls.Add(this.date_pub_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.name_book_label);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label name_book_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label date_pub_label;
        private System.Windows.Forms.Label action_label;
        private System.Windows.Forms.Label date_action_label;
        private System.Windows.Forms.Label name_reader_label;
        private System.Windows.Forms.TextBox textBox_name_book;
        private System.Windows.Forms.TextBox textBox_date_pub;
        private System.Windows.Forms.TextBox textBox_date_action;
        private System.Windows.Forms.TextBox textBox_name_reader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}

