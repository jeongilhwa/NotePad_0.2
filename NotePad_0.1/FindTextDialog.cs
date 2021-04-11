using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_0._1
{
    public partial class SerachTextDialog : Form
    {
        public SerachTextDialog()
        {
            InitializeComponent();
            //NextFindButton
            this.ActiveControl= SearchButton;
            SearchButton.Focus();



        }
        public delegate void FindTextToForm1(string Text);
        public event FindTextToForm1 SearchText;
        public bool OverOrUnderButton;
        public bool UpperLowerCheck;



        private void SearchTextDialog_Load(object sender, EventArgs e)
        {
            SearchButton.Focus();

            // Form1.TextBox1.Text = "하2";
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if(UpperLowerCheckBox.Checked)
            {
                UpperLowerCheck = true;
            }
            else
            {
                UpperLowerCheck = false;
            }
            if (OverRadioButton.Checked)
            {
                OverOrUnderButton = true;
            }
            else//(UnderRadioButton.Checked)
            {
                OverOrUnderButton = false;
            }
            string text = SearchTextBox.Text;
            SearchText(text);
            
        }

        private void UperLowCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
