namespace Last_project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.r100 = new System.Windows.Forms.RadioButton();
            this.r010 = new System.Windows.Forms.RadioButton();
            this.r110 = new System.Windows.Forms.RadioButton();
            this.r001 = new System.Windows.Forms.RadioButton();
            this.r000 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1242, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.datagrid.Location = new System.Drawing.Point(-1, 453);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(1315, 326);
            this.datagrid.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fayl nomi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fayl kengaytmasi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fayl hajmi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Atribut";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Yaratilgan vaqt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "O\'zgargan vaqt";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Adres";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.r100);
            this.panel2.Controls.Add(this.r010);
            this.panel2.Controls.Add(this.r110);
            this.panel2.Controls.Add(this.r001);
            this.panel2.Controls.Add(this.r000);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 48);
            this.panel2.TabIndex = 3;
            // 
            // r100
            // 
            this.r100.AutoSize = true;
            this.r100.Location = new System.Drawing.Point(510, 15);
            this.r100.Name = "r100";
            this.r100.Size = new System.Drawing.Size(77, 20);
            this.r100.TabIndex = 5;
            this.r100.TabStop = true;
            this.r100.Text = "Sistema";
            this.r100.UseVisualStyleBackColor = true;
            // 
            // r010
            // 
            this.r010.AutoSize = true;
            this.r010.Location = new System.Drawing.Point(646, 14);
            this.r010.Name = "r010";
            this.r010.Size = new System.Drawing.Size(108, 20);
            this.r010.TabIndex = 4;
            this.r010.TabStop = true;
            this.r010.Text = "O\'qish-yozish";
            this.r010.UseVisualStyleBackColor = true;
            // 
            // r110
            // 
            this.r110.AutoSize = true;
            this.r110.Location = new System.Drawing.Point(378, 14);
            this.r110.Name = "r110";
            this.r110.Size = new System.Drawing.Size(71, 20);
            this.r110.TabIndex = 2;
            this.r110.TabStop = true;
            this.r110.Text = "Rezerv";
            this.r110.UseVisualStyleBackColor = true;
            // 
            // r001
            // 
            this.r001.AutoSize = true;
            this.r001.Location = new System.Drawing.Point(180, 15);
            this.r001.Name = "r001";
            this.r001.Size = new System.Drawing.Size(140, 20);
            this.r001.TabIndex = 1;
            this.r001.TabStop = true;
            this.r001.Text = "Faqat o\'qish uchun";
            this.r001.UseVisualStyleBackColor = true;
            // 
            // r000
            // 
            this.r000.AutoSize = true;
            this.r000.Location = new System.Drawing.Point(14, 15);
            this.r000.Name = "r000";
            this.r000.Size = new System.Drawing.Size(123, 20);
            this.r000.TabIndex = 0;
            this.r000.TabStop = true;
            this.r000.Text = "Nomni yashirish";
            this.r000.UseVisualStyleBackColor = true;
            this.r000.CheckedChanged += new System.EventHandler(this.r000_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(1172, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 60);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(1102, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 60);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(1032, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 60);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(962, 387);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 60);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 779);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton r100;
        private System.Windows.Forms.RadioButton r010;
        private System.Windows.Forms.RadioButton r110;
        private System.Windows.Forms.RadioButton r001;
        private System.Windows.Forms.RadioButton r000;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

