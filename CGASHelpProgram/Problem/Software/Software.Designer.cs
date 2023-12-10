namespace CGASHelpProgram.Problem.Software
{
    partial class Software
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.softwareMenu1 = new CGASHelpProgram.Problem.Software.SoftwareMenu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Date_label);
            this.panel1.Controls.Add(this.Time_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 47);
            this.panel1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(149, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(399, 47);
            this.Title.TabIndex = 18;
            this.Title.Text = "Centre d\'aide - Problème Logiciel";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date_label
            // 
            this.Date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.Color.White;
            this.Date_label.Location = new System.Drawing.Point(629, 23);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(46, 21);
            this.Date_label.TabIndex = 15;
            this.Date_label.Text = "Date";
            this.Date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Time_label
            // 
            this.Time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.ForeColor = System.Drawing.Color.White;
            this.Time_label.Location = new System.Drawing.Point(629, 1);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(50, 22);
            this.Time_label.TabIndex = 14;
            this.Time_label.Text = "Time";
            this.Time_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CGASHelpProgram.Properties.Resources.logo_CGAS_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // softwareMenu1
            // 
            this.softwareMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.softwareMenu1.Location = new System.Drawing.Point(3, 52);
            this.softwareMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.softwareMenu1.Name = "softwareMenu1";
            this.softwareMenu1.Size = new System.Drawing.Size(731, 344);
            this.softwareMenu1.TabIndex = 2;
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.softwareMenu1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Software";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGAS Centre d\'aide - Problème Logiciel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Software_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private SoftwareMenu softwareMenu1;
    }
}