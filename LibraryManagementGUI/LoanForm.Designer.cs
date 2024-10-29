namespace LibraryManagementGUI
{
    partial class LoanForm
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
            dgvBookLoan = new DataGridView();
            btnDelete = new Button();
            btnHide = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            Loan = new GroupBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtDepartment = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            lbl = new Label();
            txtStudentId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookLoan).BeginInit();
            Loan.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBookLoan
            // 
            dgvBookLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookLoan.Location = new Point(26, 23);
            dgvBookLoan.Name = "dgvBookLoan";
            dgvBookLoan.RowHeadersWidth = 51;
            dgvBookLoan.Size = new Size(846, 389);
            dgvBookLoan.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(898, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(898, 216);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(94, 29);
            btnHide.TabIndex = 2;
            btnHide.Text = "Hide";
            btnHide.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(768, 185);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(612, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Loan
            // 
            Loan.Controls.Add(txtPhone);
            Loan.Controls.Add(btnOK);
            Loan.Controls.Add(btnCancel);
            Loan.Controls.Add(label5);
            Loan.Controls.Add(txtDepartment);
            Loan.Controls.Add(label4);
            Loan.Controls.Add(txtFullName);
            Loan.Controls.Add(label3);
            Loan.Controls.Add(txtEmail);
            Loan.Controls.Add(lbl);
            Loan.Controls.Add(txtStudentId);
            Loan.Controls.Add(label1);
            Loan.Location = new Point(30, 448);
            Loan.Name = "Loan";
            Loan.Size = new Size(962, 261);
            Loan.TabIndex = 5;
            Loan.TabStop = false;
            Loan.Text = "Loan";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(597, 113);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(288, 27);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 185);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 8;
            label5.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(124, 182);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(306, 27);
            txtDepartment.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 116);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(597, 51);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(288, 27);
            txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 54);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Full Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 27);
            txtEmail.TabIndex = 3;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(26, 116);
            lbl.Name = "lbl";
            lbl.Size = new Size(46, 20);
            lbl.TabIndex = 2;
            lbl.Text = "Email";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(124, 51);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(306, 27);
            txtStudentId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Id";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 721);
            Controls.Add(Loan);
            Controls.Add(btnHide);
            Controls.Add(btnDelete);
            Controls.Add(dgvBookLoan);
            Name = "LoanForm";
            Text = "Book Loan";
            ((System.ComponentModel.ISupportInitialize)dgvBookLoan).EndInit();
            Loan.ResumeLayout(false);
            Loan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBookLoan;
        private Button btnDelete;
        private Button btnHide;
        private Button btnOK;
        private Button btnCancel;
        private GroupBox Loan;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtDepartment;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtEmail;
        private Label lbl;
        private TextBox txtStudentId;
        private Label label1;
    }
}