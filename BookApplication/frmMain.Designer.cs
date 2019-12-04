namespace BookApplication
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitlebox = new System.Windows.Forms.TextBox();
            this.txtAuthorbox = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtGenrebox = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtCopiesbox = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtISBNbox = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtLengthbox = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.BookList = new System.Windows.Forms.ListBox();
            this.pbBookCover = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(409, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitlebox
            // 
            this.txtTitlebox.Location = new System.Drawing.Point(412, 46);
            this.txtTitlebox.Name = "txtTitlebox";
            this.txtTitlebox.Size = new System.Drawing.Size(181, 28);
            this.txtTitlebox.TabIndex = 1;
            // 
            // txtAuthorbox
            // 
            this.txtAuthorbox.Location = new System.Drawing.Point(412, 101);
            this.txtAuthorbox.Name = "txtAuthorbox";
            this.txtAuthorbox.Size = new System.Drawing.Size(181, 28);
            this.txtAuthorbox.TabIndex = 3;
            this.txtAuthorbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(409, 81);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(59, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtGenrebox
            // 
            this.txtGenrebox.Location = new System.Drawing.Point(412, 157);
            this.txtGenrebox.Name = "txtGenrebox";
            this.txtGenrebox.Size = new System.Drawing.Size(181, 28);
            this.txtGenrebox.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(409, 137);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 17);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtCopiesbox
            // 
            this.txtCopiesbox.Location = new System.Drawing.Point(412, 212);
            this.txtCopiesbox.Name = "txtCopiesbox";
            this.txtCopiesbox.Size = new System.Drawing.Size(181, 28);
            this.txtCopiesbox.TabIndex = 7;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(409, 192);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(133, 17);
            this.lblCopies.TabIndex = 6;
            this.lblCopies.Text = "Copies Available";
            // 
            // txtISBNbox
            // 
            this.txtISBNbox.Location = new System.Drawing.Point(412, 266);
            this.txtISBNbox.Name = "txtISBNbox";
            this.txtISBNbox.Size = new System.Drawing.Size(181, 28);
            this.txtISBNbox.TabIndex = 9;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(409, 246);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(49, 17);
            this.lblISBN.TabIndex = 8;
            this.lblISBN.Text = "ISBN";
            // 
            // txtLengthbox
            // 
            this.txtLengthbox.Location = new System.Drawing.Point(412, 324);
            this.txtLengthbox.Name = "txtLengthbox";
            this.txtLengthbox.Size = new System.Drawing.Size(181, 28);
            this.txtLengthbox.TabIndex = 11;
            this.txtLengthbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(409, 304);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(59, 17);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            this.lblLength.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 17;
            this.BookList.Location = new System.Drawing.Point(24, 27);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(368, 412);
            this.BookList.TabIndex = 12;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // pbBookCover
            // 
            this.pbBookCover.Location = new System.Drawing.Point(647, 27);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.Size = new System.Drawing.Size(224, 320);
            this.pbBookCover.TabIndex = 13;
            this.pbBookCover.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(647, 366);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(102, 48);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(769, 366);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 48);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(442, 426);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(586, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(718, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(860, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.txtLengthbox);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtISBNbox);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtCopiesbox);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.txtGenrebox);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthorbox);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitlebox);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Book Rental";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitlebox;
        private System.Windows.Forms.TextBox txtAuthorbox;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtGenrebox;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtCopiesbox;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtISBNbox;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtLengthbox;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.PictureBox pbBookCover;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}