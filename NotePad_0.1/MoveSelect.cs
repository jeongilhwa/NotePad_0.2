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
    public partial class MoveSelect : Form
    {
        public MoveSelect()
        {
            InitializeComponent();
        }
        public delegate void MoveSelectlocation(int Index);
        public event MoveSelectlocation MoveIndexLocation;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            int IndexLocation = int.Parse(MoveTextBox.Text);
            MoveIndexLocation(IndexLocation);
        }

        private void MoveFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
