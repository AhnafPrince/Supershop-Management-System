namespace Super_Shop_Management
{
    partial class Manage_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Customer));
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.customer_Delete = new System.Windows.Forms.Button();
            this.customer_Update = new System.Windows.Forms.Button();
            this.customer_Insert = new System.Windows.Forms.Button();
            this.customer_Email = new System.Windows.Forms.TextBox();
            this.customer_Fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_View = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customer_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(693, 162);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowTemplate.Height = 28;
            this.customerGridView.Size = new System.Drawing.Size(460, 434);
            this.customerGridView.TabIndex = 46;
            this.customerGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerGridView_RowHeaderMouseClick);
            // 
            // customer_Delete
            // 
            this.customer_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_Delete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_Delete.Location = new System.Drawing.Point(21, 268);
            this.customer_Delete.Name = "customer_Delete";
            this.customer_Delete.Size = new System.Drawing.Size(189, 51);
            this.customer_Delete.TabIndex = 44;
            this.customer_Delete.Text = "Delete";
            this.customer_Delete.UseVisualStyleBackColor = false;
            this.customer_Delete.Click += new System.EventHandler(this.customer_Delete_Click);
            // 
            // customer_Update
            // 
            this.customer_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_Update.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_Update.Location = new System.Drawing.Point(26, 185);
            this.customer_Update.Name = "customer_Update";
            this.customer_Update.Size = new System.Drawing.Size(184, 51);
            this.customer_Update.TabIndex = 43;
            this.customer_Update.Text = "Update";
            this.customer_Update.UseVisualStyleBackColor = false;
            this.customer_Update.Click += new System.EventHandler(this.customer_Update_Click);
            // 
            // customer_Insert
            // 
            this.customer_Insert.BackColor = System.Drawing.Color.Black;
            this.customer_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_Insert.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Insert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_Insert.Location = new System.Drawing.Point(26, 111);
            this.customer_Insert.Name = "customer_Insert";
            this.customer_Insert.Size = new System.Drawing.Size(184, 51);
            this.customer_Insert.TabIndex = 42;
            this.customer_Insert.Text = "Insert";
            this.customer_Insert.UseVisualStyleBackColor = false;
            this.customer_Insert.Click += new System.EventHandler(this.customer_Insert_Click);
            // 
            // customer_Email
            // 
            this.customer_Email.Location = new System.Drawing.Point(216, 129);
            this.customer_Email.Name = "customer_Email";
            this.customer_Email.Size = new System.Drawing.Size(212, 39);
            this.customer_Email.TabIndex = 36;
            // 
            // customer_Fname
            // 
            this.customer_Fname.Location = new System.Drawing.Point(216, 62);
            this.customer_Fname.Name = "customer_Fname";
            this.customer_Fname.Size = new System.Drawing.Size(212, 39);
            this.customer_Fname.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.customer_Insert);
            this.panel1.Controls.Add(this.customer_View);
            this.panel1.Controls.Add(this.customer_Update);
            this.panel1.Controls.Add(this.customer_Delete);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 655);
            this.panel1.TabIndex = 28;
            // 
            // customer_View
            // 
            this.customer_View.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_View.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_View.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_View.Location = new System.Drawing.Point(26, 520);
            this.customer_View.Name = "customer_View";
            this.customer_View.Size = new System.Drawing.Size(184, 51);
            this.customer_View.TabIndex = 52;
            this.customer_View.Text = "View";
            this.customer_View.UseVisualStyleBackColor = false;
            this.customer_View.Click += new System.EventHandler(this.customer_View_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Membership Type  :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 75);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1082, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1126, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customer_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.customer_Fname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.customer_Email);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(248, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(438, 302);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // customer_comboBox
            // 
            this.customer_comboBox.FormattingEnabled = true;
            this.customer_comboBox.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum"});
            this.customer_comboBox.Location = new System.Drawing.Point(218, 188);
            this.customer_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customer_comboBox.Name = "customer_comboBox";
            this.customer_comboBox.Size = new System.Drawing.Size(210, 41);
            this.customer_comboBox.TabIndex = 51;
            // 
            // Manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1170, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Manage_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Button customer_Delete;
        private System.Windows.Forms.Button customer_Update;
        private System.Windows.Forms.Button customer_Insert;
        private System.Windows.Forms.TextBox customer_Email;
        private System.Windows.Forms.TextBox customer_Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button customer_View;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox customer_comboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}