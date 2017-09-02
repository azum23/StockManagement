namespace SM
{
    partial class Login
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
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CLear = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(150, 42);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(181, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // txb_Pass
            // 
            this.txb_Pass.Location = new System.Drawing.Point(150, 68);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.Size = new System.Drawing.Size(181, 20);
            this.txb_Pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // btn_CLear
            // 
            this.btn_CLear.Location = new System.Drawing.Point(150, 126);
            this.btn_CLear.Name = "btn_CLear";
            this.btn_CLear.Size = new System.Drawing.Size(86, 44);
            this.btn_CLear.TabIndex = 0;
            this.btn_CLear.TabStop = false;
            this.btn_CLear.Text = "Clear";
            this.btn_CLear.UseVisualStyleBackColor = true;
            this.btn_CLear.Click += new System.EventHandler(this.btn_CLear_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(245, 126);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(86, 44);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(236, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Text = "Forget Password ?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 213);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Pass);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_CLear);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CLear;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}