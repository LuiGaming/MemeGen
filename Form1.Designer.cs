namespace $safeprojectname$
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.meme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meme
            // 
            this.meme.Cursor = System.Windows.Forms.Cursors.Cross;
            this.meme.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.meme.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meme.ForeColor = System.Drawing.Color.Black;
            this.meme.Location = new System.Drawing.Point(250, 127);
            this.meme.Name = "meme";
            this.meme.Size = new System.Drawing.Size(387, 181);
            this.meme.TabIndex = 0;
            this.meme.Text = "Makey Memey";
            this.meme.UseVisualStyleBackColor = true;
            this.meme.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "The MEME Gen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warning: we are not responseble for any damage done to your comptuer. If it break" +
    "s its your fault. And we are not saying this breaks your pc\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verison 1.0 Troll.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "New and legit meme gen coming soon!";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(646, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(232, 390);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Github Project.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meme);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Meme Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button meme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label5;
    }
}

