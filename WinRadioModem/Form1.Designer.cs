
namespace WinRadioModem
{
    partial class MainForm
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
            this.TransmitButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainDisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.UserTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataRateBox = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataRateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TransmitButton
            // 
            this.TransmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmitButton.ForeColor = System.Drawing.Color.Black;
            this.TransmitButton.Location = new System.Drawing.Point(404, 283);
            this.TransmitButton.Name = "TransmitButton";
            this.TransmitButton.Size = new System.Drawing.Size(104, 47);
            this.TransmitButton.TabIndex = 0;
            this.TransmitButton.Text = "Transmit Message";
            this.TransmitButton.UseVisualStyleBackColor = true;
            this.TransmitButton.Click += new System.EventHandler(this.TransmitButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(514, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 95);
            this.listBox1.TabIndex = 1;
            // 
            // MainDisplayTextBox
            // 
            this.MainDisplayTextBox.BackColor = System.Drawing.Color.Black;
            this.MainDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDisplayTextBox.ForeColor = System.Drawing.Color.Lime;
            this.MainDisplayTextBox.Location = new System.Drawing.Point(12, 11);
            this.MainDisplayTextBox.Name = "MainDisplayTextBox";
            this.MainDisplayTextBox.Size = new System.Drawing.Size(496, 262);
            this.MainDisplayTextBox.TabIndex = 2;
            this.MainDisplayTextBox.Text = "";
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.Black;
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.ForeColor = System.Drawing.Color.Lime;
            this.UserTextBox.Location = new System.Drawing.Point(12, 283);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(386, 47);
            this.UserTextBox.TabIndex = 3;
            this.UserTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse Files..";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(514, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Transmit File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(514, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mode";
            // 
            // ModeSelectionBox
            // 
            this.ModeSelectionBox.BackColor = System.Drawing.Color.Black;
            this.ModeSelectionBox.ForeColor = System.Drawing.Color.Lime;
            this.ModeSelectionBox.FormattingEnabled = true;
            this.ModeSelectionBox.Location = new System.Drawing.Point(554, 171);
            this.ModeSelectionBox.Name = "ModeSelectionBox";
            this.ModeSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.ModeSelectionBox.TabIndex = 8;
            this.ModeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.ModeSelectionBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(514, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate";
            // 
            // DataRateBox
            // 
            this.DataRateBox.BackColor = System.Drawing.Color.Black;
            this.DataRateBox.ForeColor = System.Drawing.Color.Lime;
            this.DataRateBox.Location = new System.Drawing.Point(555, 196);
            this.DataRateBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.DataRateBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DataRateBox.Name = "DataRateBox";
            this.DataRateBox.Size = new System.Drawing.Size(120, 20);
            this.DataRateBox.TabIndex = 10;
            this.DataRateBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DataRateBox.ValueChanged += new System.EventHandler(this.DataRateBox_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(517, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "TestButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TestFunction);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(691, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DataRateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModeSelectionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.MainDisplayTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TransmitButton);
            this.Name = "MainForm";
            this.Text = "WinRadioModem";
            ((System.ComponentModel.ISupportInitialize)(this.DataRateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TransmitButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox MainDisplayTextBox;
        private System.Windows.Forms.RichTextBox UserTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModeSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DataRateBox;
        private System.Windows.Forms.Button button3;
    }
}

