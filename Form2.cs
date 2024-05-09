using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69003_Yuliya_Yafimava_T6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.SelectedItem == "Paper Book")
            {
                gbPaperBook.Enabled = true;
                gbAudioBook.Enabled = false;
                gbEBook.Enabled = false;
            }
            else if(cbType.SelectedItem == "Audio Book")
            {
                gbAudioBook.Enabled = true;
                gbEBook.Enabled = false;
                gbPaperBook.Enabled = false;
            }

            else if(cbType.SelectedItem ==  "E-Book")
            {
                gbEBook.Enabled = true;
                gbAudioBook.Enabled = false;
                gbPaperBook.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string category = tbCategory.Text;
            string type = cbType.Text;

            string isbn = tbISBN.Text;
            int pages = Convert.ToInt32(tbPages.Text);

            Library.WriteBook(title, author, category, type, isbn, pages);

            
            MessageBox.Show("The new Paper Book has been added to the database", "Information");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string category = tbCategory.Text;
            string type = cbType.Text;
            string format = tbFormat.Text;
            int size = Convert.ToInt32(tbSize.Text);

            Library.WriteBook(title, author, category, type, format, size);

            MessageBox.Show("The new E-Book has been added to the database", "Information");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string category = tbCategory.Text;
            string type = cbType.Text;
            string narrator = tbNarrator.Text;
            int duration = Convert.ToInt32(tbDuration.Text);

            Library.WriteBook(title, author, category, type, narrator, duration);

            MessageBox.Show("The new Audio Book has been added to the database", "Information");


        }
       
        
    }
}
