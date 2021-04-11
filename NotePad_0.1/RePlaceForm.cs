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
    public partial class ReplaceForm : Form
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }
        public enum ReplaceMode
        {
            Normal,
            TextChange,
            AllTextChange

        }
        public ReplaceMode TextChangMode = ReplaceMode.Normal;
        public delegate void ReplaceTestToFrom(string text);
        public event ReplaceTestToFrom ReplaceTextToForm;
        public string ReplaceText = string.Empty;
        public bool ReplaceCheck = false;

        private void RePlaceForm_Load(object sender, EventArgs e)
        {

        }

        private void RepaceFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void NextSeachButton_Click(object sender, EventArgs e)
        {

            string SearchText = SearchTextBox.Text;
            ReplaceTextToForm(SearchText);
        }

        private void ReplaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Replace_Click(object sender, EventArgs e)
        {
            Button ReplaceModeeButton = sender as Button;
            string replace = ReplaceModeeButton.Tag.ToString();
            ReplaceCheck = true;


            switch (replace)
            {
                case "TextChange":
                    {
                        TextChangMode = ReplaceMode.TextChange;
                        ReplaceText = ReplaceTextBox.Text;
                        ReplaceTextToForm(SearchTextBox.Text);
                        break;
                    }
                case "AllTextChange":
                    {
                        TextChangMode = ReplaceMode.AllTextChange;
                        ReplaceText = ReplaceTextBox.Text;
                        ReplaceTextToForm(SearchTextBox.Text);
                        break;
                    }

            }

        }

    
    }
}
