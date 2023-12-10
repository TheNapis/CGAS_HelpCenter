namespace CGASHelpProgram.Home
{
    partial class HomeMenu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.PowerOptions_Button = new FontAwesome.Sharp.IconButton();
            this.CGASDocs_Button = new FontAwesome.Sharp.IconButton();
            this.ProbOther_Button = new FontAwesome.Sharp.IconButton();
            this.ProbSystem_Button = new FontAwesome.Sharp.IconButton();
            this.ProbSoftware_Button = new FontAwesome.Sharp.IconButton();
            this.ProbHardware_Button = new FontAwesome.Sharp.IconButton();
            this.powerOptionMenu1 = new CGASHelpProgram.PowerOptions.PowerOptionMenu();
            this.softwareMenu1 = new CGASHelpProgram.Problem.Software.SoftwareMenu();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "J\'ai un problème sur :";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.HomeButton.IconColor = System.Drawing.Color.White;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.Location = new System.Drawing.Point(674, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(60, 60);
            this.HomeButton.TabIndex = 17;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PowerOptions_Button
            // 
            this.PowerOptions_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.PowerOptions_Button.FlatAppearance.BorderSize = 0;
            this.PowerOptions_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerOptions_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerOptions_Button.ForeColor = System.Drawing.Color.White;
            this.PowerOptions_Button.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.PowerOptions_Button.IconColor = System.Drawing.Color.Black;
            this.PowerOptions_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PowerOptions_Button.Location = new System.Drawing.Point(573, 83);
            this.PowerOptions_Button.Name = "PowerOptions_Button";
            this.PowerOptions_Button.Size = new System.Drawing.Size(158, 201);
            this.PowerOptions_Button.TabIndex = 15;
            this.PowerOptions_Button.Text = "Options d\'alimentation";
            this.PowerOptions_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PowerOptions_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PowerOptions_Button.UseVisualStyleBackColor = false;
            this.PowerOptions_Button.Click += new System.EventHandler(this.PowerOptions_Button_Click);
            // 
            // CGASDocs_Button
            // 
            this.CGASDocs_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.CGASDocs_Button.FlatAppearance.BorderSize = 0;
            this.CGASDocs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CGASDocs_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGASDocs_Button.ForeColor = System.Drawing.Color.White;
            this.CGASDocs_Button.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.CGASDocs_Button.IconColor = System.Drawing.Color.Black;
            this.CGASDocs_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CGASDocs_Button.Location = new System.Drawing.Point(400, 83);
            this.CGASDocs_Button.Name = "CGASDocs_Button";
            this.CGASDocs_Button.Size = new System.Drawing.Size(167, 201);
            this.CGASDocs_Button.TabIndex = 14;
            this.CGASDocs_Button.Text = "Documentation\r\nC.G.A.S.\r\n";
            this.CGASDocs_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CGASDocs_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CGASDocs_Button.UseVisualStyleBackColor = false;
            this.CGASDocs_Button.Click += new System.EventHandler(this.CGASDocs_Button_Click);
            // 
            // ProbOther_Button
            // 
            this.ProbOther_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.ProbOther_Button.FlatAppearance.BorderSize = 0;
            this.ProbOther_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbOther_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbOther_Button.ForeColor = System.Drawing.Color.White;
            this.ProbOther_Button.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ProbOther_Button.IconColor = System.Drawing.Color.Black;
            this.ProbOther_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProbOther_Button.Location = new System.Drawing.Point(170, 188);
            this.ProbOther_Button.Name = "ProbOther_Button";
            this.ProbOther_Button.Size = new System.Drawing.Size(136, 96);
            this.ProbOther_Button.TabIndex = 12;
            this.ProbOther_Button.Text = "Autre";
            this.ProbOther_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProbOther_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProbOther_Button.UseVisualStyleBackColor = false;
            // 
            // ProbSystem_Button
            // 
            this.ProbSystem_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.ProbSystem_Button.FlatAppearance.BorderSize = 0;
            this.ProbSystem_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbSystem_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbSystem_Button.ForeColor = System.Drawing.Color.White;
            this.ProbSystem_Button.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.ProbSystem_Button.IconColor = System.Drawing.Color.Black;
            this.ProbSystem_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProbSystem_Button.Location = new System.Drawing.Point(20, 188);
            this.ProbSystem_Button.Name = "ProbSystem_Button";
            this.ProbSystem_Button.Size = new System.Drawing.Size(136, 96);
            this.ProbSystem_Button.TabIndex = 11;
            this.ProbSystem_Button.Text = "Système";
            this.ProbSystem_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProbSystem_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProbSystem_Button.UseVisualStyleBackColor = false;
            // 
            // ProbSoftware_Button
            // 
            this.ProbSoftware_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProbSoftware_Button.FlatAppearance.BorderSize = 0;
            this.ProbSoftware_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbSoftware_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbSoftware_Button.ForeColor = System.Drawing.Color.White;
            this.ProbSoftware_Button.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.ProbSoftware_Button.IconColor = System.Drawing.Color.Black;
            this.ProbSoftware_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProbSoftware_Button.Location = new System.Drawing.Point(170, 83);
            this.ProbSoftware_Button.Name = "ProbSoftware_Button";
            this.ProbSoftware_Button.Size = new System.Drawing.Size(136, 96);
            this.ProbSoftware_Button.TabIndex = 10;
            this.ProbSoftware_Button.Text = "Logiciel";
            this.ProbSoftware_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProbSoftware_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProbSoftware_Button.UseVisualStyleBackColor = false;
            this.ProbSoftware_Button.Click += new System.EventHandler(this.ProbSoftware_Button_Click);
            // 
            // ProbHardware_Button
            // 
            this.ProbHardware_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
            this.ProbHardware_Button.FlatAppearance.BorderSize = 0;
            this.ProbHardware_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbHardware_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbHardware_Button.ForeColor = System.Drawing.Color.White;
            this.ProbHardware_Button.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ProbHardware_Button.IconColor = System.Drawing.Color.Black;
            this.ProbHardware_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProbHardware_Button.Location = new System.Drawing.Point(20, 83);
            this.ProbHardware_Button.Name = "ProbHardware_Button";
            this.ProbHardware_Button.Size = new System.Drawing.Size(136, 96);
            this.ProbHardware_Button.TabIndex = 9;
            this.ProbHardware_Button.Text = "Matériel";
            this.ProbHardware_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProbHardware_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProbHardware_Button.UseVisualStyleBackColor = false;
            // 
            // powerOptionMenu1
            // 
            this.powerOptionMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.powerOptionMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerOptionMenu1.Location = new System.Drawing.Point(0, 0);
            this.powerOptionMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.powerOptionMenu1.Name = "powerOptionMenu1";
            this.powerOptionMenu1.Size = new System.Drawing.Size(734, 387);
            this.powerOptionMenu1.TabIndex = 16;
            this.powerOptionMenu1.Visible = false;
            // 
            // softwareMenu1
            // 
            this.softwareMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.softwareMenu1.Location = new System.Drawing.Point(0, 0);
            this.softwareMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.softwareMenu1.Name = "softwareMenu1";
            this.softwareMenu1.Size = new System.Drawing.Size(734, 387);
            this.softwareMenu1.TabIndex = 18;
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PowerOptions_Button);
            this.Controls.Add(this.CGASDocs_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProbOther_Button);
            this.Controls.Add(this.ProbSystem_Button);
            this.Controls.Add(this.ProbSoftware_Button);
            this.Controls.Add(this.ProbHardware_Button);
            this.Controls.Add(this.powerOptionMenu1);
            this.Controls.Add(this.softwareMenu1);
            this.Name = "HomeMenu";
            this.Size = new System.Drawing.Size(734, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ProbHardware_Button;
        private FontAwesome.Sharp.IconButton ProbSoftware_Button;
        private FontAwesome.Sharp.IconButton ProbSystem_Button;
        private FontAwesome.Sharp.IconButton ProbOther_Button;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton CGASDocs_Button;
        private FontAwesome.Sharp.IconButton PowerOptions_Button;
        private PowerOptions.PowerOptionMenu powerOptionMenu1;
        private FontAwesome.Sharp.IconButton HomeButton;
        private Problem.Software.SoftwareMenu softwareMenu1;
    }
}
