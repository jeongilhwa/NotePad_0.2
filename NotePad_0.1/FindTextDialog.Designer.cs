
namespace NotePad_0._1
{
    partial class SerachTextDialog 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchButton = new System.Windows.Forms.Button();
            this.FindCancelButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindTextLavel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnderRadioButton = new System.Windows.Forms.RadioButton();
            this.OverRadioButton = new System.Windows.Forms.RadioButton();
            this.UpperLowerCheckBox = new System.Windows.Forms.CheckBox();
            this.PlacedAroundCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(371, 18);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 30);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "다음 찾기(&F)";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FindCancelButton
            // 
            this.FindCancelButton.Location = new System.Drawing.Point(371, 55);
            this.FindCancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindCancelButton.Name = "FindCancelButton";
            this.FindCancelButton.Size = new System.Drawing.Size(98, 30);
            this.FindCancelButton.TabIndex = 1;
            this.FindCancelButton.Text = "취소";
            this.FindCancelButton.UseVisualStyleBackColor = true;
            this.FindCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(97, 19);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(260, 25);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FindTextLavel
            // 
            this.FindTextLavel.AutoSize = true;
            this.FindTextLavel.Location = new System.Drawing.Point(6, 25);
            this.FindTextLavel.Name = "FindTextLavel";
            this.FindTextLavel.Size = new System.Drawing.Size(98, 15);
            this.FindTextLavel.TabIndex = 3;
            this.FindTextLavel.Text = "찾을 내용(N):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnderRadioButton);
            this.groupBox1.Controls.Add(this.OverRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(176, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(182, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // UnderRadioButton
            // 
            this.UnderRadioButton.AutoSize = true;
            this.UnderRadioButton.Checked = true;
            this.UnderRadioButton.Location = new System.Drawing.Point(87, 40);
            this.UnderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnderRadioButton.Name = "UnderRadioButton";
            this.UnderRadioButton.Size = new System.Drawing.Size(95, 19);
            this.UnderRadioButton.TabIndex = 1;
            this.UnderRadioButton.TabStop = true;
            this.UnderRadioButton.Text = "아래로(&D)";
            this.UnderRadioButton.UseVisualStyleBackColor = true;
            // 
            // OverRadioButton
            // 
            this.OverRadioButton.AutoSize = true;
            this.OverRadioButton.Location = new System.Drawing.Point(6, 40);
            this.OverRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverRadioButton.Name = "OverRadioButton";
            this.OverRadioButton.Size = new System.Drawing.Size(80, 19);
            this.OverRadioButton.TabIndex = 0;
            this.OverRadioButton.Text = "위로(&U)";
            this.OverRadioButton.UseVisualStyleBackColor = true;
            // 
            // UperLowCheckBox
            // 
            this.UpperLowerCheckBox.AutoSize = true;
            this.UpperLowerCheckBox.Location = new System.Drawing.Point(6, 106);
            this.UpperLowerCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpperLowerCheckBox.Name = "UperLowCheckBox";
            this.UpperLowerCheckBox.Size = new System.Drawing.Size(152, 19);
            this.UpperLowerCheckBox.TabIndex = 5;
            this.UpperLowerCheckBox.Text = "대/소문자 구분(&C)";
            this.UpperLowerCheckBox.UseVisualStyleBackColor = true;
            this.UpperLowerCheckBox.CheckedChanged += new System.EventHandler(this.UperLowCheckBox_CheckedChanged);
            // 
            // PlacedAroundCheckBox
            // 
            this.PlacedAroundCheckBox.AutoSize = true;
            this.PlacedAroundCheckBox.Location = new System.Drawing.Point(6, 144);
            this.PlacedAroundCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlacedAroundCheckBox.Name = "PlacedAroundCheckBox";
            this.PlacedAroundCheckBox.Size = new System.Drawing.Size(131, 19);
            this.PlacedAroundCheckBox.TabIndex = 6;
            this.PlacedAroundCheckBox.Text = "주위에 배치(&R)";
            this.PlacedAroundCheckBox.UseVisualStyleBackColor = true;
            // 
            // SerachTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 176);
            this.Controls.Add(this.PlacedAroundCheckBox);
            this.Controls.Add(this.UpperLowerCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FindTextLavel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FindCancelButton);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerachTextDialog";
            this.Text = "찾기";
            this.Load += new System.EventHandler(this.SearchTextDialog_Load);
            this.Enter += new System.EventHandler(this.SearchButton_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button FindCancelButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label FindTextLavel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UnderRadioButton;
        private System.Windows.Forms.RadioButton OverRadioButton;
        private System.Windows.Forms.CheckBox UpperLowerCheckBox;
        private System.Windows.Forms.CheckBox PlacedAroundCheckBox;
    }
}