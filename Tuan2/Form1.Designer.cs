namespace Tuan2
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
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDomain = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfor
            // 
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Location = new System.Drawing.Point(12, 180);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.Size = new System.Drawing.Size(765, 253);
            this.dgvInfor.TabIndex = 0;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(13, 13);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(79, 17);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Description";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(521, 47);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(39, 17);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Pass";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(285, 45);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(38, 17);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "User";
            // 
            // lbDomain
            // 
            this.lbDomain.AutoSize = true;
            this.lbDomain.Location = new System.Drawing.Point(12, 47);
            this.lbDomain.Name = "lbDomain";
            this.lbDomain.Size = new System.Drawing.Size(56, 17);
            this.lbDomain.TabIndex = 6;
            this.lbDomain.Text = "Domain";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(94, 10);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(683, 22);
            this.txtDesc.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(573, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(204, 22);
            this.txtPass.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(337, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 22);
            this.txtUser.TabIndex = 9;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(94, 42);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(158, 22);
            this.txtDomain.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(482, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(573, 85);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(187, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "show pass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbDomain);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.dgvInfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfor;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDomain;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button1;
    }
}

