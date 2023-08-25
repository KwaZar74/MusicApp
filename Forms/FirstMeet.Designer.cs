namespace MusicApp.Forms
{
    partial class FirstMeet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "(*.userkey)|*.userkey";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 8.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(41, 139);
            button1.Name = "button1";
            button1.Size = new Size(136, 30);
            button1.TabIndex = 0;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 8.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(41, 228);
            button2.Name = "button2";
            button2.Size = new Size(136, 28);
            button2.TabIndex = 1;
            button2.Text = "Получить новый";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 292);
            checkBox1.MaximumSize = new Size(200, 400);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Consolas", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(119, 377);
            button3.Name = "button3";
            button3.Size = new Size(137, 56);
            button3.TabIndex = 5;
            button3.Text = "Начать";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 76);
            label2.MaximumSize = new Size(300, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 60);
            label2.TabIndex = 6;
            label2.Text = "Выберите файл с ключем аунтефикации, чтобы получить доступ к предыдущим настройкам (кроме музыки)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 185);
            label3.MaximumSize = new Size(300, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 40);
            label3.TabIndex = 7;
            label3.Text = "Или получите новый ключ, что иметь настройки нового пользователя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(77, -1);
            label4.Name = "label4";
            label4.Size = new Size(238, 46);
            label4.TabIndex = 8;
            label4.Text = "Авторизация";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkArea = new LinkArea(72, 83);
            linkLabel1.Location = new Point(65, 292);
            linkLabel1.MaximumSize = new Size(300, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(267, 65);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Подтверждаю своё ознакомление и согласие с пользовательским соглашением example.com";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(183, 143);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 10;
            label1.Text = "Готово";
            label1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(183, 231);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 11;
            label5.Text = "Готово";
            label5.Visible = false;
            // 
            // FirstMeet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(400, 491);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FirstMeet";
            Text = "FirstMeet";
            Load += FirstMeet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label5;
    }
}