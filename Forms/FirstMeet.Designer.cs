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
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(76, 124);
            button1.Name = "button1";
            button1.Size = new Size(255, 49);
            button1.TabIndex = 0;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(76, 284);
            button2.Name = "button2";
            button2.Size = new Size(255, 49);
            button2.TabIndex = 1;
            button2.Text = "Получить новый";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FirstMeet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31,40,51);
            ClientSize = new Size(400, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FirstMeet";
            Text = "FirstMeet";
            Load += FirstMeet_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
    }
}