namespace RandomMapGenerator
{
    partial class UserOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.FolderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputTypePicker = new System.Windows.Forms.ComboBox();
            this.ZAxisTextBox = new System.Windows.Forms.TextBox();
            this.YAxisTextBox = new System.Windows.Forms.TextBox();
            this.XAxisTextBox = new System.Windows.Forms.TextBox();
            this.StatusOfGeneration = new System.Windows.Forms.StatusStrip();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ErrorXAxis = new System.Windows.Forms.Label();
            this.ErrorYAxis = new System.Windows.Forms.Label();
            this.ErrorZAxis = new System.Windows.Forms.Label();
            this.ErrorOutputType = new System.Windows.Forms.Label();
            this.ErrorOutputPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Axis Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X Axis Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z Axis Size:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(274, 126);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Generate";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(94, 45);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(178, 20);
            this.OutputPath.TabIndex = 6;
            // 
            // OutputTypePicker
            // 
            this.OutputTypePicker.FormattingEnabled = true;
            this.OutputTypePicker.Location = new System.Drawing.Point(95, 12);
            this.OutputTypePicker.Name = "OutputTypePicker";
            this.OutputTypePicker.Size = new System.Drawing.Size(121, 21);
            this.OutputTypePicker.TabIndex = 7;
            // 
            // ZAxisTextBox
            // 
            this.ZAxisTextBox.Location = new System.Drawing.Point(94, 133);
            this.ZAxisTextBox.Name = "ZAxisTextBox";
            this.ZAxisTextBox.Size = new System.Drawing.Size(50, 20);
            this.ZAxisTextBox.TabIndex = 8;
            // 
            // YAxisTextBox
            // 
            this.YAxisTextBox.Location = new System.Drawing.Point(95, 102);
            this.YAxisTextBox.Name = "YAxisTextBox";
            this.YAxisTextBox.Size = new System.Drawing.Size(50, 20);
            this.YAxisTextBox.TabIndex = 9;
            // 
            // XAxisTextBox
            // 
            this.XAxisTextBox.Location = new System.Drawing.Point(95, 71);
            this.XAxisTextBox.Name = "XAxisTextBox";
            this.XAxisTextBox.Size = new System.Drawing.Size(50, 20);
            this.XAxisTextBox.TabIndex = 10;
            // 
            // StatusOfGeneration
            // 
            this.StatusOfGeneration.Location = new System.Drawing.Point(0, 157);
            this.StatusOfGeneration.Name = "StatusOfGeneration";
            this.StatusOfGeneration.Size = new System.Drawing.Size(361, 22);
            this.StatusOfGeneration.TabIndex = 11;
            this.StatusOfGeneration.Text = "statusStrip1";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(278, 42);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 12;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ErrorXAxis
            // 
            this.ErrorXAxis.AutoSize = true;
            this.ErrorXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorXAxis.ForeColor = System.Drawing.Color.Red;
            this.ErrorXAxis.Location = new System.Drawing.Point(5, 73);
            this.ErrorXAxis.Name = "ErrorXAxis";
            this.ErrorXAxis.Size = new System.Drawing.Size(17, 24);
            this.ErrorXAxis.TabIndex = 13;
            this.ErrorXAxis.Text = "*";
            this.ErrorXAxis.Visible = false;
            // 
            // ErrorYAxis
            // 
            this.ErrorYAxis.AutoSize = true;
            this.ErrorYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorYAxis.ForeColor = System.Drawing.Color.Red;
            this.ErrorYAxis.Location = new System.Drawing.Point(5, 103);
            this.ErrorYAxis.Name = "ErrorYAxis";
            this.ErrorYAxis.Size = new System.Drawing.Size(17, 24);
            this.ErrorYAxis.TabIndex = 14;
            this.ErrorYAxis.Text = "*";
            this.ErrorYAxis.Visible = false;
            // 
            // ErrorZAxis
            // 
            this.ErrorZAxis.AutoSize = true;
            this.ErrorZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorZAxis.ForeColor = System.Drawing.Color.Red;
            this.ErrorZAxis.Location = new System.Drawing.Point(5, 133);
            this.ErrorZAxis.Name = "ErrorZAxis";
            this.ErrorZAxis.Size = new System.Drawing.Size(17, 24);
            this.ErrorZAxis.TabIndex = 15;
            this.ErrorZAxis.Text = "*";
            this.ErrorZAxis.Visible = false;
            // 
            // ErrorOutputType
            // 
            this.ErrorOutputType.AutoSize = true;
            this.ErrorOutputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorOutputType.ForeColor = System.Drawing.Color.Red;
            this.ErrorOutputType.Location = new System.Drawing.Point(5, 13);
            this.ErrorOutputType.Name = "ErrorOutputType";
            this.ErrorOutputType.Size = new System.Drawing.Size(17, 24);
            this.ErrorOutputType.TabIndex = 16;
            this.ErrorOutputType.Text = "*";
            this.ErrorOutputType.Visible = false;
            // 
            // ErrorOutputPath
            // 
            this.ErrorOutputPath.AutoSize = true;
            this.ErrorOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorOutputPath.ForeColor = System.Drawing.Color.Red;
            this.ErrorOutputPath.Location = new System.Drawing.Point(5, 43);
            this.ErrorOutputPath.Name = "ErrorOutputPath";
            this.ErrorOutputPath.Size = new System.Drawing.Size(17, 24);
            this.ErrorOutputPath.TabIndex = 17;
            this.ErrorOutputPath.Text = "*";
            this.ErrorOutputPath.Visible = false;
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 179);
            this.Controls.Add(this.ErrorOutputPath);
            this.Controls.Add(this.ErrorOutputType);
            this.Controls.Add(this.ErrorZAxis);
            this.Controls.Add(this.ErrorYAxis);
            this.Controls.Add(this.ErrorXAxis);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.StatusOfGeneration);
            this.Controls.Add(this.XAxisTextBox);
            this.Controls.Add(this.YAxisTextBox);
            this.Controls.Add(this.ZAxisTextBox);
            this.Controls.Add(this.OutputTypePicker);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.FolderBrowserDialog FolderPicker;
        private System.Windows.Forms.ComboBox OutputTypePicker;
        private System.Windows.Forms.TextBox ZAxisTextBox;
        private System.Windows.Forms.TextBox YAxisTextBox;
        private System.Windows.Forms.TextBox XAxisTextBox;
        private System.Windows.Forms.StatusStrip StatusOfGeneration;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label ErrorXAxis;
        private System.Windows.Forms.Label ErrorYAxis;
        private System.Windows.Forms.Label ErrorZAxis;
        private System.Windows.Forms.Label ErrorOutputType;
        private System.Windows.Forms.Label ErrorOutputPath;
    }
}

