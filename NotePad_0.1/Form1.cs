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
using System.Diagnostics;
using System.Configuration;
using Microsoft.VisualBasic;
namespace NotePad_0._1
{
    //UserControl1 user = new UserControl1();
    public partial class Form1 : Form
    {
        NotePadSaveCheck SaveCheckForm = new NotePadSaveCheck();
        public static SerachTextDialog SearchForm = new SerachTextDialog();
        public static ReplaceForm ReplaceForm1 = new ReplaceForm();
        public MoveSelect MoveForm = new MoveSelect();
        public string FileName = "제목 없음";
        public string FileDescription = " - Windows 메모장";
        private int IndexLocation = 0;
        private int TextCount;
        private string FindTextSave;
        private bool Dirty = false;
        

        public Form1()
        {
            InitializeComponent();
            this.Text = string.Format("{0}{1}", FileName, FileDescription);
            LabelLineColumn.Text = string.Format("Ln {0}, Col {1}", 1, 1);
            
            FindToolStrip.Enabled = false;
            NextFindToolStrip.Enabled = false;
            PreviousToolStrip.Enabled = false;

            SearchForm.Owner = this;
            SearchForm.SearchText += EventSearchInForm1Text;
            ReplaceForm1.ReplaceTextToForm += EventSearchInForm1Text;
            MoveForm.MoveIndexLocation += EventMoveIndexLocation;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Dirty && TextBox1.Text != null)
            {
                if (SaveCheckForm.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                if (SaveCheckForm.DialogResult == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }

                    File.WriteAllText(saveFileDialog1.FileName, TextBox1.Text);
                }
            }



            TextBox1.Clear();
            IsDirty();
        }

        private void 새창WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad_0.1.exe");
        }
        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Dirty)
            {
                OpenFile();
            }
            else
            {
                Open();
            }
            
        }
        private void OpenFile()
        {

            if (SaveCheckForm.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (SaveCheckForm.DialogResult == DialogResult.OK)
            {
                Save();
            }

            Open();
        }
        private void Open()
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox1.Clear();
                TextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName);
                FileName = string.Format("{0} -Windows 메모장", Path.GetFileName(OpenFileDialog1.FileName));
                this.Text = FileName;
            }
        }


        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveFileDialog1.FileName))
            {
                File.WriteAllText(saveFileDialog1.FileName, TextBox1.Text);
            }
            else
            {
                Save();
            }
        }
        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            File.WriteAllText(saveFileDialog1.FileName, TextBox1.Text);
            FileName = string.Format("{0} -Windows 메모장", Path.GetFileName(saveFileDialog1.FileName));
            this.Text = FileName;
        }


        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EditMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem EditButton = sender as ToolStripMenuItem;

            Edit(EditButton.Tag.ToString());
        }
        private void Edit(string editMenu)
        {
            switch (editMenu)
            {
                case "Undo":
                    if (TextBox1.CanUndo == true)
                    {
                        TextBox1.Undo();
                    }
                    break;
                case "Cut":
                    if (TextBox1.SelectedText != "")
                    {
                        TextBox1.Cut();
                    }
                    break;
                case "Copy":
                    Clipboard.SetDataObject(TextBox1.SelectedText, true);
                    break;
                case "Paste":
                    TextBox1.Paste();
                    break;
                case "Delete":
                    TextBox1.SelectedText = "";
                    break;
                case "BingSearch":
                    string bingSearch = TextBox1.SelectedText;
                    System.Diagnostics.Process.Start(string.Format("https://www.bing.com/search?q={0}", bingSearch));
                    break;

            }


        }
        private void Format_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem FormatButton = sender as ToolStripMenuItem;
            Format(FormatButton.Tag.ToString());

        }
        private void Format(string formatMenu)
        {
            switch (formatMenu)
            {
                case "WordWrap":
                    {
                        if (WordWrapToolMenu.Checked)
                        {
                            TextBox1.WordWrap = true;
                        }
                        else
                        {
                            TextBox1.WordWrap = false;

                        }
                        break;
                    }
                case "Font":
                    {
                        FormatFontDialog.ShowDialog();
                        TextBox1.Font = FormatFontDialog.Font;
                        break;
                    }

            }

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayCurrentLineAndColumnIndex();
            IsDirty();
            NotePadTextCheck();
            TextSelectCheck();

        }
        private void TextSelectCheck()
        {
            if(TextBox1.SelectionLength == 0)
            {
                CopyToolStrip.Enabled = false;
                CutToolStrip.Enabled = false;
                DeleteToolStrip.Enabled = false;
                BingSearchToolStrip.Enabled = false;

            }
            else
            {
                CopyToolStrip.Enabled = true;
                CutToolStrip.Enabled = true;
                DeleteToolStrip.Enabled = true;
                BingSearchToolStrip.Enabled = true;
            }
        }
        private void NotePadTextCheck()
        {
            if(TextBox1.Text.Length == 0)
            {
                FindToolStrip.Enabled = false;
                NextFindToolStrip.Enabled = false;
                PreviousToolStrip.Enabled = false;
            }
            else
            {
                FindToolStrip.Enabled = true;
                NextFindToolStrip.Enabled = true;
                PreviousToolStrip.Enabled = true;
            }
        }

        private void TextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            DisplayCurrentLineAndColumnIndex();
        }

        private void DisplayCurrentLineAndColumnIndex()
        {

            int line = TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart);

            int column = TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(line);




            //int currentLineIndex = TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart);
            //int lengthOfpreviousLines = 0;
            //if (currentLineIndex > TextBox1.Lines.Length)
            //{
            //    currentLineIndex = TextBox1.Lines.Length;
            //}
            //for (int i = 0; i < currentLineIndex; i++)
            //{
            //    lengthOfpreviousLines += TextBox1.Lines[i].Length;
            //    lengthOfpreviousLines += "\r\n".Length;
            //}
            //int currentColiumnIndex = TextBox1.SelectionStart - lengthOfpreviousLines;

            //LabelLineColumn.Text = string.Format("Ln {0}, Col {1}", currentLineIndex + 1, currentColiumnIndex + 1);
            LabelLineColumn.Text = string.Format("Ln {0}, Col {1}", line + 1, column + 1);
        }





        private void 상태표시줄SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ViewSatusBar.Checked)
            {

                statusStrip2.Visible = true;

            }
            else
            {
                statusStrip2.Visible = false;
               // tableLayoutPanel1.RowCount = 2;
                TextBox1.Dock = DockStyle.Fill;
            }
        }

        private void IsDirty()
        {

            if (TextBox1.Text != string.Empty && this.Text == string.Format("{0}{1}", FileName, FileDescription))
            {
                this.Text = string.Format("{0}{1}{2}", "*", FileName, FileDescription);
                Dirty = true;

            }

            if (TextBox1.Text == string.Empty)
            {
                this.Text = string.Format("{0}{1}", FileName, FileDescription);
                Dirty = false;
            }


        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //FormFind


        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Text += DateTime.Now;
            TextBox1.Text = TextBox1.Text.Insert(TextBox1.SelectionStart, DateTime.Now.ToString());
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SearchForm.Show();
        }



        public void EventSearchInForm1Text(string text)
        {
            FindTextSave = text;

            if (ReplaceForm1.ReplaceCheck)
            {
                ReplaceText();
                ReplaceForm1.ReplaceCheck = false;
            }
            else
            {
                SearchText();

            }


        }
        private void ReplaceText()
        {
            //string replaceText = TextBox1.SelectedText;
            if (ReplaceForm1.TextChangMode == ReplaceForm.ReplaceMode.TextChange && TextBox1.SelectionLength != 0)
            {

                TextBox1.SelectedText = TextBox1.SelectedText.Replace(TextBox1.SelectedText, ReplaceForm1.ReplaceText);
                ReplaceForm1.TextChangMode = ReplaceForm.ReplaceMode.Normal;
                FindTextDown();

            }
            if (ReplaceForm1.TextChangMode == ReplaceForm.ReplaceMode.AllTextChange && TextBox1.SelectionLength != 0)
            {

                while (true)
                {
                    TextBox1.SelectedText = TextBox1.SelectedText.Replace(TextBox1.SelectedText, ReplaceForm1.ReplaceText);
                    ReplaceForm1.TextChangMode = ReplaceForm.ReplaceMode.Normal;
                    FindTextDown();
                    if (IndexLocation == -1)
                        break;
                    FindTextDefault();

                }

            }
            FindTextDefault();
        }
        private void SearchText()
        {

            TextBox1.Select(TextBox1.SelectionStart, 0);

            if (SearchForm.OverOrUnderButton)
            {
                TextBox1.SelectionStart -= TextCount;
                TextCount = FindTextSave.Length;
                int selectCount = TextBox1.SelectionStart;
                FindTextUp();
            }
            else
            {
                TextBox1.SelectionStart += TextCount;
                TextCount = FindTextSave.Length;
                int selectCount = TextBox1.SelectionStart;
                FindTextDown();
                FindTextDefault();
            }
            FindTextDefault();
        }
        private void FindTextDefault()
        {
            if (IndexLocation == -1)
            {
                MessageBox.Show(string.Format("\"{0}\"을(를) 찾을 수 없습니다.", FindTextSave), "메모장");
            }
            else
            {
                TextBox1.Select(IndexLocation, FindTextSave.Length);
                TextBox1.ScrollToCaret();
            }
        }
        private void FindTextUp()
        {
            if (SearchForm.UpperLowerCheck)
            {
                IndexLocation = TextBox1.Text.LastIndexOf(FindTextSave, TextBox1.SelectionStart, StringComparison.CurrentCulture);
            }
            else
            {
                IndexLocation = TextBox1.Text.LastIndexOf(FindTextSave, TextBox1.SelectionStart, StringComparison.CurrentCultureIgnoreCase);
            }

        }
        private void FindTextDown()
        {
            if (SearchForm.UpperLowerCheck)
            {
                IndexLocation = TextBox1.Text.IndexOf(FindTextSave, TextBox1.SelectionStart, StringComparison.CurrentCulture);
            }
            else
            {
                IndexLocation = TextBox1.Text.IndexOf(FindTextSave, TextBox1.SelectionStart, StringComparison.CurrentCultureIgnoreCase);
            }
        }





        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SearchForm.OverOrUnderButton = false;
            SearchText();
        }

        private void 이전찾기VToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SearchForm.OverOrUnderButton = true;
            SearchText();
        }

        private void 바꾸기RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm.OverOrUnderButton = false;
            SearchForm.UpperLowerCheck = false;

            ReplaceForm1.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void EventMoveIndexLocation(int number)
        {
            //TextBox1.SelectionStart=TextBox1.GetLineFromCharIndex(number);
            int caratIndex = TextBox1.GetFirstCharIndexFromLine(number);

            TextBox1.Select(caratIndex , 0);
            TextBox1.ScrollToCaret();
        }

        private void 이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveForm.Show();
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IsDirty();
        }
    }
}
