using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FK_Book_Name
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Book = txt_Book_Name.Text;
            //txt_Book_Name.Text = Book.Trim();
            //txt_Book_Name.Text = lbl_Book_Result.ToString();
            string modifiedString = Book.Replace(" ", ".");
            string step2 = modifiedString + "_";
            //MessageBox.Show(step2);
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                sb.Append(random.Next(10));
            }
            string random16DigitNumber = sb.ToString();
            //MessageBox.Show(random16DigitNumber);
            //Console.WriteLine(random16DigitNumber);

            string step3 = step2 + sb;
            //lbl_Book_Result.Text = step3.ToString();
            //MessageBox.Show(step3);

            string step4 = step3 + "_faghatketab.ir";
            lbl_Book_Result.Text = step4.ToString();
            System.Windows.Forms.Clipboard.SetText(step4);
            //Random random = new Random();
            //long randomNumber = random.Next(1000000000000000, (int)9999999999999999);
            //Console.WriteLine(random.Next(1, 1000000000));
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_Book_Result.Text);
        }
    }
}
