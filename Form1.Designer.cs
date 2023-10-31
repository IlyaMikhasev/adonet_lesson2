namespace adonet_lesson2
{
    partial class Form1
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
            this.tb_connectStrimg = new System.Windows.Forms.TextBox();
            this.b_connect = new System.Windows.Forms.Button();
            this.b_con2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.t_tt = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.chb_add = new System.Windows.Forms.CheckBox();
            this.b_update = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_connectStrimg
            // 
            this.tb_connectStrimg.Location = new System.Drawing.Point(132, 78);
            this.tb_connectStrimg.Name = "tb_connectStrimg";
            this.tb_connectStrimg.Size = new System.Drawing.Size(236, 20);
            this.tb_connectStrimg.TabIndex = 0;
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(398, 76);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 1;
            this.b_connect.Text = "connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // b_con2
            // 
            this.b_con2.Location = new System.Drawing.Point(398, 124);
            this.b_con2.Name = "b_con2";
            this.b_con2.Size = new System.Drawing.Size(75, 23);
            this.b_con2.TabIndex = 2;
            this.b_con2.Text = "input";
            this.b_con2.UseVisualStyleBackColor = true;
            this.b_con2.Click += new System.EventHandler(this.b_con2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 147);
            this.textBox1.TabIndex = 4;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(132, 42);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 5;
            // 
            // t_tt
            // 
            this.t_tt.Location = new System.Drawing.Point(272, 42);
            this.t_tt.Name = "t_tt";
            this.t_tt.Size = new System.Drawing.Size(100, 20);
            this.t_tt.TabIndex = 6;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(398, 166);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 7;
            this.b_add.Text = "DataGrew";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // chb_add
            // 
            this.chb_add.AutoSize = true;
            this.chb_add.Location = new System.Drawing.Point(398, 44);
            this.chb_add.Name = "chb_add";
            this.chb_add.Size = new System.Drawing.Size(80, 17);
            this.chb_add.TabIndex = 8;
            this.chb_add.Text = "checkBox1";
            this.chb_add.UseVisualStyleBackColor = true;
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(398, 206);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 9;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(488, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 302);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.chb_add);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_tt);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_con2);
            this.Controls.Add(this.b_connect);
            this.Controls.Add(this.tb_connectStrimg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_connectStrimg;
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.Button b_con2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox t_tt;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.CheckBox chb_add;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

