namespace Movies_Manager
{
    partial class DeleteMovie
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
            this.findBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.genreBx = new System.Windows.Forms.ComboBox();
            this.earningBx = new System.Windows.Forms.TextBox();
            this.rottenBx = new System.Windows.Forms.TextBox();
            this.directorBx = new System.Windows.Forms.TextBox();
            this.yearBx = new System.Windows.Forms.TextBox();
            this.titleBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(417, 50);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(60, 20);
            this.findBtn.TabIndex = 43;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Location = new System.Drawing.Point(73, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 41);
            this.panel1.TabIndex = 42;
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
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(14, 7);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 22);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // genreBx
            // 
            this.genreBx.FormattingEnabled = true;
            this.genreBx.Location = new System.Drawing.Point(189, 173);
            this.genreBx.Name = "genreBx";
            this.genreBx.Size = new System.Drawing.Size(189, 21);
            this.genreBx.TabIndex = 41;
            // 
            // earningBx
            // 
            this.earningBx.Location = new System.Drawing.Point(403, 214);
            this.earningBx.Name = "earningBx";
            this.earningBx.Size = new System.Drawing.Size(95, 20);
            this.earningBx.TabIndex = 40;
            // 
            // rottenBx
            // 
            this.rottenBx.Location = new System.Drawing.Point(189, 214);
            this.rottenBx.Name = "rottenBx";
            this.rottenBx.Size = new System.Drawing.Size(62, 20);
            this.rottenBx.TabIndex = 39;
            // 
            // directorBx
            // 
            this.directorBx.Location = new System.Drawing.Point(189, 132);
            this.directorBx.Name = "directorBx";
            this.directorBx.Size = new System.Drawing.Size(189, 20);
            this.directorBx.TabIndex = 38;
            // 
            // yearBx
            // 
            this.yearBx.Location = new System.Drawing.Point(189, 91);
            this.yearBx.Name = "yearBx";
            this.yearBx.Size = new System.Drawing.Size(75, 20);
            this.yearBx.TabIndex = 37;
            // 
            // titleBx
            // 
            this.titleBx.Location = new System.Drawing.Point(189, 50);
            this.titleBx.Name = "titleBx";
            this.titleBx.Size = new System.Drawing.Size(222, 20);
            this.titleBx.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Box Office Earnings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rotten Tomatoes Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Movie Title:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(212, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Delete A Movie ";
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.findBtn);
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
            this.Name = "DeleteMovie";
            this.Text = "Delete Movie";
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox genreBx;
        private System.Windows.Forms.TextBox earningBx;
        private System.Windows.Forms.TextBox rottenBx;
        private System.Windows.Forms.TextBox directorBx;
        private System.Windows.Forms.TextBox yearBx;
        private System.Windows.Forms.TextBox titleBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}