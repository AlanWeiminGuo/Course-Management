namespace first_try
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textpass1 = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密    码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认：";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(90, 95);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(173, 21);
            this.textpass.TabIndex = 3;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(90, 41);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(173, 21);
            this.textname.TabIndex = 4;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            this.textname.Leave += new System.EventHandler(this.textname_Leave);
            // 
            // textpass1
            // 
            this.textpass1.Location = new System.Drawing.Point(90, 144);
            this.textpass1.Name = "textpass1";
            this.textpass1.PasswordChar = '*';
            this.textpass1.Size = new System.Drawing.Size(172, 21);
            this.textpass1.TabIndex = 5;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(119, 219);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(105, 28);
            this.btnreg.TabIndex = 6;
            this.btnreg.Text = "注册";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.textpass1);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpass1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}