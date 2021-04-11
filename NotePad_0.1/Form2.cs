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
    public partial class NotePadSaveCheck : Form
    {
        public enum SaveFileCheckMessage : int
        {
            NoneSaveMessage,
            SaveMessage,
            Cancel,
            None,


        }
        //SaveFileCheckMessage FileSaveMessage;
        public NotePadSaveCheck()
        {
            InitializeComponent();
            //DataGridView BackColorView=new DataGridView();
            //BackColorView.SelectedRows.
            //BackColorView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            //int fileOder =(Button)sender.ToString();
            Button ButtonType = sender as Button;
            string checkSaveType = ButtonType.Tag.ToString();

            if (checkSaveType == "save")
            {
                //저장    
                this.DialogResult = DialogResult.OK;
            }
            else if (checkSaveType == "noneSave")
            {
                //저장안함
                this.DialogResult = DialogResult.No;
            }//yes no cancel
            else if(checkSaveType == "cancel")
            {
                this.DialogResult = DialogResult.Cancel;
            }


        }

        private void NotePadSaveCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
