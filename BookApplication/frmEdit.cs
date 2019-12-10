using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication
{
    public partial class frmEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;

        //Constructor 
        public frmEdit(Object tempBook, string tempMode, string tempCwid)
        {
            myBook = (Book)tempBook;
            cwid = tempCwid;
            mode = tempMode;

            InitializeComponent();
            pbBookCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                txtTitlebox.Text = myBook.title;
                txtAuthorbox.Text = myBook.author;
                txtGenrebox.Text = myBook.genre;
                txtCopiesbox.Text = myBook.copies.ToString();
                txtISBNbox.Text = myBook.isbn;
                txtCoverData.Text = myBook.cover;
                txtLengthbox.Text = myBook.length.ToString();

                pbBookCover.Load(myBook.cover);

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            myBook.title = txtTitlebox.Text;
            myBook.author = txtAuthorbox.Text;
            myBook.genre = txtGenrebox.Text;
            myBook.copies = int.Parse(txtCopiesbox.Text);
            myBook.isbn = txtISBNbox.Text;
            myBook.cover = txtCoverData.Text;
            myBook.length = int.Parse(txtLengthbox.Text);
            myBook.cwid = cwid;

            BookFile.SaveBook(myBook, cwid, mode);
            MessageBox.Show("Content was saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void TxtISBNbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
