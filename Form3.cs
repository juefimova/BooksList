using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _69003_Yuliya_Yafimava_T6
{
    public partial class Form3 : Form
    {
        private int indexOfBook;
        public Form3()
        {
            InitializeComponent();
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }


        private void TextBoxesEnabled(bool flag)
        {
            tbTitle.Enabled = flag;
            tbAuthor.Enabled = flag;
            tbParamentr1.Enabled = flag;
            tbParametr2.Enabled = flag;
            tbCategory.Enabled = flag;
            tbType.Enabled = flag;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           TextBoxesEnabled(false);
            GetBookInfo();
            NavigationEnabled();
          
        }

        private void GetBookInfo()
        {
            if (Library.books.Count > 0)
            {
                Book currentBook = Library.books[indexOfBook];
                tbTitle.Text = currentBook.Title;
                tbAuthor.Text = currentBook.Author;
                tbCategory.Text = currentBook.Category;

                if (currentBook is PaperBook)
                {
                    PaperBook paperBook = (PaperBook)currentBook;
                    tbType.Text = "Paper Book";
                    lbParametr1.Text = "ISBN:";
                    lbParametr2.Text = "Pages:";
                    tbParamentr1.Text = paperBook.Isbn;
                    tbParametr2.Text = paperBook.Pages.ToString();
                }

                else if (currentBook is EBook)
                {
                    EBook eBook = (EBook)currentBook;
                    tbType.Text = "E-Book";
                    lbParametr1.Text = "Format:";
                    lbParametr2.Text = "File Size:";
                    tbParamentr1.Text = eBook.Format;
                    tbParametr2.Text = eBook.Size.ToString();
                }
                else if (currentBook is AudioBook)
                {
                    AudioBook audioBook = (AudioBook)currentBook;
                    tbType.Text = "Audio Book";
                    lbParametr1.Text = "Narrator:";
                    lbParametr2.Text = "Duration:";
                    tbParamentr1.Text = audioBook.Narrator;
                    tbParametr2.Text = audioBook.Duration.ToString();
                }

                lbCurrentPage.Text = (indexOfBook + 1).ToString();
                lbPages.Text = Library.books.Count.ToString();


            }
            else
            {
                ClearTextBoxes();
                lbCurrentPage.Text = "0";
                lbPages.Text = "0";
            }
        }


        private void ClearTextBoxes()
        {
            tbTitle.Clear();
            tbAuthor.Clear();
            tbCategory.Clear();
            tbParamentr1.Clear();
            tbParametr2.Clear();
            tbType.Clear();
        }

        private void NavigationEnabled()
        {
            if (Library.books.Count == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnBack.Enabled = (indexOfBook != 0);
                btnNext.Enabled = (indexOfBook != Library.books.Count - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit")
            {
                TextBoxesEnabled(true);

                button1.Text = "Apply";
            }
            else
            {
                ApplyChanges();

                button1.Text = "Edit";
                TextBoxesEnabled(false);
                NavigationEnabled();
                MessageBox.Show("The book has been edited", "Information");
            }
            
        }
       

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indexOfBook > 0)
            {
                indexOfBook--;
                GetBookInfo();
                NavigationEnabled();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (indexOfBook < Library.books.Count - 1)
            {
                indexOfBook++;
                GetBookInfo();
                NavigationEnabled();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (Library.books.Count > 0)
            {

                Library.books.RemoveAt(indexOfBook);


                GetBookInfo();

                NavigationEnabled();

                Library.WriteBooksToFile();

                MessageBox.Show("The book has been deleted", "Information");
            }
        }

        private void ApplyChanges()
        {
            Book currentBook = Library.books[indexOfBook];


            currentBook.Title = tbTitle.Text;
            currentBook.Author = tbAuthor.Text;
            currentBook.Category = tbCategory.Text;


            if (currentBook is PaperBook)
            {
                PaperBook paperBook = (PaperBook)currentBook;
                paperBook.Isbn = tbParamentr1.Text;
                paperBook.Pages = Convert.ToInt32(tbParametr2.Text);
            }
            else if (currentBook is EBook)
            {
                EBook eBook = (EBook)currentBook;
                eBook.Format = tbParamentr1.Text;
                eBook.Size = int.Parse(tbParametr2.Text);
            }
            else if (currentBook is AudioBook)
            {
                AudioBook audioBook = (AudioBook)currentBook;
                audioBook.Narrator = tbParamentr1.Text;
                audioBook.Duration = double.Parse(tbParametr2.Text);
            }


            Library.books[indexOfBook] = currentBook;

            Library.WriteBooksToFile();


            GetBookInfo();
        }
    }

   
}
