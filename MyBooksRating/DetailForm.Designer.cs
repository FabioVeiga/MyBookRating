namespace MyBooksRating
{
    partial class DetailForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateRead = new System.Windows.Forms.DateTimePicker();
            this.cbxReading = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMyReview = new System.Windows.Forms.TextBox();
            this.btnSalve = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(47, 32);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(207, 20);
            this.txtUrl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate";
            // 
            // cbxRate
            // 
            this.cbxRate.FormattingEnabled = true;
            this.cbxRate.Items.AddRange(new object[] {
            "1 heart",
            "2 heart",
            "3 heart",
            "4 heart",
            "5 heart",
            "No rate"});
            this.cbxRate.Location = new System.Drawing.Point(47, 58);
            this.cbxRate.Name = "cbxRate";
            this.cbxRate.Size = new System.Drawing.Size(207, 21);
            this.cbxRate.TabIndex = 5;
            this.cbxRate.Text = "No rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Finish date";
            // 
            // dtpDateRead
            // 
            this.dtpDateRead.Location = new System.Drawing.Point(60, 86);
            this.dtpDateRead.Name = "dtpDateRead";
            this.dtpDateRead.Size = new System.Drawing.Size(115, 20);
            this.dtpDateRead.TabIndex = 7;
            // 
            // cbxReading
            // 
            this.cbxReading.AutoSize = true;
            this.cbxReading.Location = new System.Drawing.Point(181, 90);
            this.cbxReading.Name = "cbxReading";
            this.cbxReading.Size = new System.Drawing.Size(77, 17);
            this.cbxReading.TabIndex = 8;
            this.cbxReading.Text = "I\'m reading";
            this.cbxReading.UseVisualStyleBackColor = true;
            this.cbxReading.CheckedChanged += new System.EventHandler(this.CbxReading_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "My review";
            // 
            // txtMyReview
            // 
            this.txtMyReview.Location = new System.Drawing.Point(8, 133);
            this.txtMyReview.Multiline = true;
            this.txtMyReview.Name = "txtMyReview";
            this.txtMyReview.Size = new System.Drawing.Size(246, 144);
            this.txtMyReview.TabIndex = 10;
            // 
            // btnSalve
            // 
            this.btnSalve.Location = new System.Drawing.Point(8, 284);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(75, 32);
            this.btnSalve.TabIndex = 11;
            this.btnSalve.Text = "Salve";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.BtnSalve_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(179, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 320);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalve);
            this.Controls.Add(this.txtMyReview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxReading);
            this.Controls.Add(this.dtpDateRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit or Delete";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateRead;
        private System.Windows.Forms.CheckBox cbxReading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMyReview;
        private System.Windows.Forms.Button btnSalve;
        private System.Windows.Forms.Button btnDelete;
    }
}