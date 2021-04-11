
namespace NotePad_0._1
{
    partial class MoveSelect
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
            this.MoveButton = new System.Windows.Forms.Button();
            this.MoveFormCancelButton = new System.Windows.Forms.Button();
            this.MoveTextBox = new System.Windows.Forms.TextBox();
            this.LowNumberLavel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(119, 101);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(86, 42);
            this.MoveButton.TabIndex = 0;
            this.MoveButton.Text = "이동";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveFormCancelButton
            // 
            this.MoveFormCancelButton.Location = new System.Drawing.Point(221, 101);
            this.MoveFormCancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveFormCancelButton.Name = "MoveFormCancelButton";
            this.MoveFormCancelButton.Size = new System.Drawing.Size(86, 42);
            this.MoveFormCancelButton.TabIndex = 1;
            this.MoveFormCancelButton.Text = "취소";
            this.MoveFormCancelButton.UseVisualStyleBackColor = true;
            this.MoveFormCancelButton.Click += new System.EventHandler(this.MoveFormCancelButton_Click);
            // 
            // MoveTextBox
            // 
            this.MoveTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.MoveTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MoveTextBox.Location = new System.Drawing.Point(14, 49);
            this.MoveTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveTextBox.Name = "MoveTextBox";
            this.MoveTextBox.Size = new System.Drawing.Size(292, 30);
            this.MoveTextBox.TabIndex = 2;
            this.MoveTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LowNumberLavel
            // 
            this.LowNumberLavel.AutoSize = true;
            this.LowNumberLavel.Location = new System.Drawing.Point(14, 11);
            this.LowNumberLavel.Name = "LowNumberLavel";
            this.LowNumberLavel.Size = new System.Drawing.Size(82, 15);
            this.LowNumberLavel.TabIndex = 3;
            this.LowNumberLavel.Text = "줄 번호(&L):";
            // 
            // MoveSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 159);
            this.Controls.Add(this.LowNumberLavel);
            this.Controls.Add(this.MoveTextBox);
            this.Controls.Add(this.MoveFormCancelButton);
            this.Controls.Add(this.MoveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveSelect";
            this.Text = "줄이동";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button MoveFormCancelButton;
        private System.Windows.Forms.TextBox MoveTextBox;
        private System.Windows.Forms.Label LowNumberLavel;
    }
}