namespace Movies_Manager
{
    partial class AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleBx = new System.Windows.Forms.TextBox();
            this.yearBx = new System.Windows.Forms.TextBox();
            this.directorBx = new System.Windows.Forms.TextBox();
            this.rottenBx = new System.Windows.Forms.TextBox();
            this.earningBx = new System.Windows.Forms.TextBox();
            this.genreBx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a Movie to Your Master List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rotten Tomatoes Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Box Office Earnings:";
            // 
            // titleBx
            // 
            this.titleBx.Location = new System.Drawing.Point(189, 47);
            this.titleBx.Name = "titleBx";
            this.titleBx.Size = new System.Drawing.Size(222, 20);
            this.titleBx.TabIndex = 7;
            this.titleBx.TextChanged += new System.EventHandler(this.titleBx_TextChanged);
            // 
            // yearBx
            // 
            this.yearBx.Location = new System.Drawing.Point(189, 88);
            this.yearBx.Name = "yearBx";
            this.yearBx.Size = new System.Drawing.Size(75, 20);
            this.yearBx.TabIndex = 8;
            this.yearBx.TextChanged += new System.EventHandler(this.yearBx_TextChanged);
            // 
            // directorBx
            // 
            this.directorBx.Location = new System.Drawing.Point(189, 129);
            this.directorBx.Name = "directorBx";
            this.directorBx.Size = new System.Drawing.Size(189, 20);
            this.directorBx.TabIndex = 9;
            this.directorBx.TextChanged += new System.EventHandler(this.directorBx_TextChanged);
            // 
            // rottenBx
            // 
            this.rottenBx.Location = new System.Drawing.Point(189, 211);
            this.rottenBx.Name = "rottenBx";
            this.rottenBx.Size = new System.Drawing.Size(62, 20);
            this.rottenBx.TabIndex = 10;
            // 
            // earningBx
            // 
            this.earningBx.Location = new System.Drawing.Point(403, 211);
            this.earningBx.Name = "earningBx";
            this.earningBx.Size = new System.Drawing.Size(95, 20);
            this.earningBx.TabIndex = 11;
            // 
            // genreBx
            // 
            this.genreBx.FormattingEnabled = true;
            this.genreBx.Location = new System.Drawing.Point(189, 170);
            this.genreBx.Name = "genreBx";
            this.genreBx.Size = new System.Drawing.Size(189, 21);
            this.genreBx.TabIndex = 12;
            this.genreBx.SelectedIndexChanged += new System.EventHandler(this.genreBx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(73, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 41);
            this.panel1.TabIndex = 13;
            this.panel1.TabStop = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(358, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 22);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(114, 7);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 22);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(14, 7);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 22);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.genreBx);
            this.Controls.Add(this.earningBx);
            this.Controls.Add(this.rottenBx);
            this.Controls.Add(this.directorBx);
            this.Controls.Add(this.yearBx);
            this.Controls.Add(this.titleBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(564, 349);
            this.MinimumSize = new System.Drawing.Size(564, 349);
            this.Name = "AddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleBx;
        private System.Windows.Forms.TextBox yearBx;
        private System.Windows.Forms.TextBox directorBx;
        private System.Windows.Forms.TextBox rottenBx;
        private System.Windows.Forms.TextBox earningBx;
        private System.Windows.Forms.ComboBox genreBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
    }
}