namespace NotePad_0._1
{
    partial class ReplaceForm
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
            this.NextSeachButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.AllTextReplaceButton = new System.Windows.Forms.Button();
            this.RepaceFormCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NextSeachButton
            // 
            this.NextSeachButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NextSeachButton.Location = new System.Drawing.Point(306, 10);
            this.NextSeachButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextSeachButton.Name = "NextSeachButton";
            this.NextSeachButton.Size = new System.Drawing.Size(101, 28);
            this.NextSeachButton.TabIndex = 0;
            this.NextSeachButton.Text = "다음 찾기(&F)";
            this.NextSeachButton.UseVisualStyleBackColor = true;
            this.NextSeachButton.Click += new System.EventHandler(this.NextSeachButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReplaceButton.Location = new System.Drawing.Point(306, 42);
            this.ReplaceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(101, 28);
            this.ReplaceButton.TabIndex = 1;
            this.ReplaceButton.Tag = "TextChange";
            this.ReplaceButton.Text = "바꾸기(&R)";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.Replace_Click);
            // 
            // AllTextReplaceButton
            // 
            this.AllTextReplaceButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllTextReplaceButton.Location = new System.Drawing.Point(306, 75);
            this.AllTextReplaceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllTextReplaceButton.Name = "AllTextReplaceButton";
            this.AllTextReplaceButton.Size = new System.Drawing.Size(101, 28);
            this.AllTextReplaceButton.TabIndex = 2;
            this.AllTextReplaceButton.Tag = "AllTextChange";
            this.AllTextReplaceButton.Text = "모두 바꾸기(&A)";
            this.AllTextReplaceButton.UseVisualStyleBackColor = true;
            this.AllTextReplaceButton.Click += new System.EventHandler(this.Replace_Click);
            // 
            // RepaceFormCancelButton
            // 
            this.RepaceFormCancelButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RepaceFormCancelButton.Location = new System.Drawing.Point(306, 108);
            this.RepaceFormCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepaceFormCancelButton.Name = "RepaceFormCancelButton";
            this.RepaceFormCancelButton.Size = new System.Drawing.Size(101, 28);
            this.RepaceFormCancelButton.TabIndex = 3;
            this.RepaceFormCancelButton.Text = "취소";
            this.RepaceFormCancelButton.UseVisualStyleBackColor = true;
            this.RepaceFormCancelButton.Click += new System.EventHandler(this.RepaceFormCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "찾을 내용(&N):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "바꿀 내용(&P):";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(104, 18);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(197, 21);
            this.SearchTextBox.TabIndex = 6;
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(104, 48);
            this.ReplaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(197, 21);
            this.ReplaceTextBox.TabIndex = 7;
            this.ReplaceTextBox.TextChanged += new System.EventHandler(this.ReplaceTextBox_TextChanged);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 189);
            this.Controls.Add(this.ReplaceTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepaceFormCancelButton);
            this.Controls.Add(this.AllTextReplaceButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.NextSeachButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.Text = "바꾸기";
            this.Load += new System.EventHandler(this.RePlaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextSeachButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button AllTextReplaceButton;
        private System.Windows.Forms.Button RepaceFormCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox ReplaceTextBox;
    }
}