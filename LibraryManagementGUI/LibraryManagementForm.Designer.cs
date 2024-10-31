namespace LibraryManagementGUI
{
    partial class LibraryManagementForm
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mntrLogout = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            bookManagementToolStripMenuItem = new ToolStripMenuItem();
            categoryManagementToolStripMenuItem = new ToolStripMenuItem();
            memberManagementToolStripMenuItem = new ToolStripMenuItem();
            dgvBookList = new DataGridView();
            groupBox1 = new GroupBox();
            cboCategory = new ComboBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSearch = new Button();
            label2 = new Label();
            txtAuthor = new TextBox();
            label1 = new Label();
            txtTitle = new TextBox();
            btnAddToLoan = new Button();
            btnBookLoan = new Button();
            txtCurrentLibrarian = new TextBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, bookManagementToolStripMenuItem, categoryManagementToolStripMenuItem, memberManagementToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1226, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntrLogout, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // mntrLogout
            // 
            mntrLogout.Name = "mntrLogout";
            mntrLogout.Size = new Size(143, 26);
            mntrLogout.Text = "Log out";
            mntrLogout.Click += mntrLogout_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // bookManagementToolStripMenuItem
            // 
            bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            bookManagementToolStripMenuItem.Size = new Size(149, 24);
            bookManagementToolStripMenuItem.Text = "Book Management";
            // 
            // categoryManagementToolStripMenuItem
            // 
            categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            categoryManagementToolStripMenuItem.Size = new Size(175, 24);
            categoryManagementToolStripMenuItem.Text = "Category Management";
            // 
            // memberManagementToolStripMenuItem
            // 
            memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            memberManagementToolStripMenuItem.Size = new Size(171, 24);
            memberManagementToolStripMenuItem.Text = "Member Management";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 247);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(1202, 492);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1202, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(731, 47);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(195, 28);
            cboCategory.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 51);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Category";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1084, 49);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(965, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(408, 49);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(195, 27);
            txtAuthor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(78, 48);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 0;
            // 
            // btnAddToLoan
            // 
            btnAddToLoan.Location = new Point(896, 201);
            btnAddToLoan.Name = "btnAddToLoan";
            btnAddToLoan.Size = new Size(134, 29);
            btnAddToLoan.TabIndex = 3;
            btnAddToLoan.Text = "Add To Loan";
            btnAddToLoan.UseVisualStyleBackColor = true;
            btnAddToLoan.Click += btnAddToLoan_Click;
            // 
            // btnBookLoan
            // 
            btnBookLoan.Location = new Point(1056, 201);
            btnBookLoan.Name = "btnBookLoan";
            btnBookLoan.Size = new Size(134, 29);
            btnBookLoan.TabIndex = 4;
            btnBookLoan.Text = "Book Loan";
            btnBookLoan.UseVisualStyleBackColor = true;
            btnBookLoan.Click += btnBookLoan_Click;
            // 
            // txtCurrentLibrarian
            // 
            txtCurrentLibrarian.Location = new Point(1008, 31);
            txtCurrentLibrarian.Name = "txtCurrentLibrarian";
            txtCurrentLibrarian.Size = new Size(195, 27);
            txtCurrentLibrarian.TabIndex = 5;
            // 
            // LibraryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 751);
            Controls.Add(txtCurrentLibrarian);
            Controls.Add(btnBookLoan);
            Controls.Add(btnAddToLoan);
            Controls.Add(groupBox1);
            Controls.Add(dgvBookList);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "LibraryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management";
            Load += LibraryManagementForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem bookManagementToolStripMenuItem;
        private ToolStripMenuItem categoryManagementToolStripMenuItem;
        private ToolStripMenuItem memberManagementToolStripMenuItem;
        private DataGridView dgvBookList;
        private ToolStripMenuItem mntrLogout;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnSearch;
        private Label label2;
        private TextBox txtAuthor;
        private Label label1;
        private TextBox txtTitle;
        private Label label3;
        private Button btnAddToLoan;
        private Button btnBookLoan;
        private ComboBox cboCategory;
        private TextBox txtCurrentLibrarian;
    }
}