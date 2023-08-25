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
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 8.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(42, 58);
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
            button2.Location = new Point(42, 123);
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
            checkBox1.Location = new Point(42, 244);
            checkBox1.MaximumSize = new Size(200, 400);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(143, 312);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "exampl.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 241);
            label1.MaximumSize = new Size(300, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 60);
            label1.TabIndex = 4;
            label1.Text = "Подтверждаю своё ознакомление и согласие с пользовательским соглашением";
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(134, 386);
            button3.Name = "button3";
            button3.Size = new Size(119, 43);
            button3.TabIndex = 5;
            button3.Text = "Начать";
            button3.UseVisualStyleBackColor = true;
            // 
            // FirstMeet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(400, 500);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
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
        private LinkLabel linkLabel1;
        private Label label1;
        private Button button3;
    }
}