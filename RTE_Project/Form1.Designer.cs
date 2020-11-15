namespace RTE_Project
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Die1 = new System.Windows.Forms.Button();
            this.Die2 = new System.Windows.Forms.Button();
            this.Die3 = new System.Windows.Forms.Button();
            this.Die4 = new System.Windows.Forms.Button();
            this.Die5 = new System.Windows.Forms.Button();
            this.Die6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CounterRound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игрок 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Игрок 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(315, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Правила игры";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Die1
            // 
            this.Die1.BackColor = System.Drawing.Color.White;
            this.Die1.Enabled = false;
            this.Die1.Location = new System.Drawing.Point(25, 194);
            this.Die1.Name = "Die1";
            this.Die1.Size = new System.Drawing.Size(60, 62);
            this.Die1.TabIndex = 6;
            this.Die1.UseVisualStyleBackColor = false;
            this.Die1.Click += new System.EventHandler(this.Die1_Click);
            // 
            // Die2
            // 
            this.Die2.BackColor = System.Drawing.Color.White;
            this.Die2.Enabled = false;
            this.Die2.Location = new System.Drawing.Point(91, 194);
            this.Die2.Name = "Die2";
            this.Die2.Size = new System.Drawing.Size(60, 62);
            this.Die2.TabIndex = 7;
            this.Die2.UseVisualStyleBackColor = false;
            this.Die2.Click += new System.EventHandler(this.Die2_Click_1);
            // 
            // Die3
            // 
            this.Die3.BackColor = System.Drawing.Color.White;
            this.Die3.Enabled = false;
            this.Die3.Location = new System.Drawing.Point(157, 194);
            this.Die3.Name = "Die3";
            this.Die3.Size = new System.Drawing.Size(60, 62);
            this.Die3.TabIndex = 8;
            this.Die3.UseVisualStyleBackColor = false;
            this.Die3.Click += new System.EventHandler(this.Die3_Click_1);
            // 
            // Die4
            // 
            this.Die4.BackColor = System.Drawing.Color.White;
            this.Die4.Enabled = false;
            this.Die4.Location = new System.Drawing.Point(223, 194);
            this.Die4.Name = "Die4";
            this.Die4.Size = new System.Drawing.Size(60, 62);
            this.Die4.TabIndex = 9;
            this.Die4.UseVisualStyleBackColor = false;
            this.Die4.Click += new System.EventHandler(this.Die4_Click_1);
            // 
            // Die5
            // 
            this.Die5.BackColor = System.Drawing.Color.White;
            this.Die5.Enabled = false;
            this.Die5.Location = new System.Drawing.Point(289, 194);
            this.Die5.Name = "Die5";
            this.Die5.Size = new System.Drawing.Size(60, 62);
            this.Die5.TabIndex = 10;
            this.Die5.UseVisualStyleBackColor = false;
            this.Die5.Click += new System.EventHandler(this.Die5_Click_1);
            // 
            // Die6
            // 
            this.Die6.BackColor = System.Drawing.Color.White;
            this.Die6.Enabled = false;
            this.Die6.Location = new System.Drawing.Point(355, 194);
            this.Die6.Name = "Die6";
            this.Die6.Size = new System.Drawing.Size(60, 62);
            this.Die6.TabIndex = 11;
            this.Die6.UseVisualStyleBackColor = false;
            this.Die6.Click += new System.EventHandler(this.Die6_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Начать игру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(104, 286);
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Size = new System.Drawing.Size(100, 22);
            this.Counter.TabIndex = 13;
            this.Counter.Text = "0";
            this.Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Очки за ход";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 51);
            this.button4.TabIndex = 15;
            this.button4.Text = "Бросить ещё раз";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(315, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 51);
            this.button5.TabIndex = 16;
            this.button5.Text = "Передать ход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Очки за раунд";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CounterRound
            // 
            this.CounterRound.Location = new System.Drawing.Point(236, 286);
            this.CounterRound.Name = "CounterRound";
            this.CounterRound.ReadOnly = true;
            this.CounterRound.Size = new System.Drawing.Size(100, 22);
            this.CounterRound.TabIndex = 18;
            this.CounterRound.Text = "0";
            this.CounterRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 338);
            this.Controls.Add(this.CounterRound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Die6);
            this.Controls.Add(this.Die5);
            this.Controls.Add(this.Die4);
            this.Controls.Add(this.Die3);
            this.Controls.Add(this.Die2);
            this.Controls.Add(this.Die1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Зонк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Die1;
        private System.Windows.Forms.Button Die2;
        private System.Windows.Forms.Button Die3;
        private System.Windows.Forms.Button Die4;
        private System.Windows.Forms.Button Die5;
        private System.Windows.Forms.Button Die6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CounterRound;
    }
}

