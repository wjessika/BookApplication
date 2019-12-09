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
    // Book application 
    public partial class frmMain : Form
    {
        string cwid;
        List<Book> myBooks;
        public frmMain(string tempCWID)
        {
            this.cwid = tempCWID;
            InitializeComponent();
            pbBookCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            BookList.DataSource = myBooks;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)BookList.SelectedItem;
            myBook.copies++;
            BookFile.SaveBook(myBook, cwid, "Edit");
            LoadList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)BookList.SelectedItem;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BookFile.DeleteBook(myBook, cwid);
                LoadList();
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)BookList.SelectedItem;
            frmEdit myForm = new frmEdit(myBook, "edit", cwid);
            if(myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Book myBook = new Book();
            frmEdit myForm = new frmEdit(myBook, "new", cwid);
            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)BookList.SelectedItem;
            myBook.copies--;
            BookFile.SaveBook(myBook,cwid, "Edit");
            LoadList();

        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)BookList.SelectedItem;

            txtTitlebox.Text = myBook.title;
            txtAuthorbox.Text = myBook.author;
            txtGenrebox.Text = myBook.genre;
            txtCopiesbox.Text = myBook.copies.ToString();
            txtLengthbox.Text = myBook.length.ToString();

            try
            {
                pbBookCover.Load(myBook.cover);
            }
            catch
            {

            }
        }    


    }
}
