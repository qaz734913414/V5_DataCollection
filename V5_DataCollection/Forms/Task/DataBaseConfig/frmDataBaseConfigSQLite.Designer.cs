﻿namespace V5_DataCollection.Forms.Task.DataBaseConfig {
    partial class frmDataBaseConfigSQLite {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkAccessIsValied = new System.Windows.Forms.CheckBox();
            this.btnAccessBrowsePath = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDataBaseTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "密码";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(99, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 21);
            this.txtPass.TabIndex = 12;
            // 
            // chkAccessIsValied
            // 
            this.chkAccessIsValied.AutoSize = true;
            this.chkAccessIsValied.Location = new System.Drawing.Point(99, 65);
            this.chkAccessIsValied.Name = "chkAccessIsValied";
            this.chkAccessIsValied.Size = new System.Drawing.Size(96, 16);
            this.chkAccessIsValied.TabIndex = 10;
            this.chkAccessIsValied.Text = "需要进行验证";
            this.chkAccessIsValied.UseVisualStyleBackColor = true;
            this.chkAccessIsValied.CheckedChanged += new System.EventHandler(this.chkAccessIsValied_CheckedChanged);
            // 
            // btnAccessBrowsePath
            // 
            this.btnAccessBrowsePath.Location = new System.Drawing.Point(99, 36);
            this.btnAccessBrowsePath.Name = "btnAccessBrowsePath";
            this.btnAccessBrowsePath.Size = new System.Drawing.Size(75, 23);
            this.btnAccessBrowsePath.TabIndex = 9;
            this.btnAccessBrowsePath.Text = "浏览...";
            this.btnAccessBrowsePath.UseVisualStyleBackColor = true;
            this.btnAccessBrowsePath.Click += new System.EventHandler(this.btnAccessBrowsePath_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(99, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(253, 21);
            this.txtServer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "数据库文件";
            // 
            // btnDataBaseTest
            // 
            this.btnDataBaseTest.Location = new System.Drawing.Point(121, 137);
            this.btnDataBaseTest.Name = "btnDataBaseTest";
            this.btnDataBaseTest.Size = new System.Drawing.Size(75, 23);
            this.btnDataBaseTest.TabIndex = 22;
            this.btnDataBaseTest.Text = "测试";
            this.btnDataBaseTest.UseVisualStyleBackColor = true;
            this.btnDataBaseTest.Click += new System.EventHandler(this.btnDataBaseTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmDataBaseConfigSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 172);
            this.Controls.Add(this.btnDataBaseTest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.chkAccessIsValied);
            this.Controls.Add(this.btnAccessBrowsePath);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDataBaseConfigSQLite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite数据库配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkAccessIsValied;
        private System.Windows.Forms.Button btnAccessBrowsePath;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDataBaseTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}