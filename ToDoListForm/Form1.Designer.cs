namespace ToDoListForm
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            txtGorev = new TextBox();
            btnEkle = new Button();
            listTasks = new CheckedListBox();
            btnSil = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGorev
            // 
            txtGorev.BorderStyle = BorderStyle.FixedSingle;
            txtGorev.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGorev.Location = new Point(189, 99);
            txtGorev.Margin = new Padding(4, 3, 4, 3);
            txtGorev.Name = "txtGorev";
            txtGorev.RightToLeft = RightToLeft.No;
            txtGorev.Size = new Size(215, 38);
            txtGorev.TabIndex = 0;
            txtGorev.TextAlign = HorizontalAlignment.Center;
            txtGorev.KeyDown += txtGorev_KeyDown;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumVioletRed;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(125, 414);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(118, 33);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "ADD";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // listTasks
            // 
            listTasks.BorderStyle = BorderStyle.None;
            listTasks.CheckOnClick = true;
            listTasks.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listTasks.FormattingEnabled = true;
            listTasks.Location = new Point(125, 159);
            listTasks.Margin = new Padding(4, 3, 4, 3);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(329, 232);
            listTasks.TabIndex = 2;
            listTasks.SelectedIndexChanged += listTasks_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.PaleVioletRed;
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(336, 414);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(118, 33);
            btnSil.TabIndex = 3;
            btnSil.Text = "DELETE";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(214, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 0;
            label1.Text = "TO-DO LIST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 76);
            panel1.TabIndex = 4;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(608, 459);
            Controls.Add(panel1);
            Controls.Add(btnSil);
            Controls.Add(listTasks);
            Controls.Add(btnEkle);
            Controls.Add(txtGorev);
            Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoList";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGorev;
        private Button btnEkle;
        private CheckedListBox listTasks;
        private Button btnSil;
        private Label label1;
        private Panel panel1;
    }
}
