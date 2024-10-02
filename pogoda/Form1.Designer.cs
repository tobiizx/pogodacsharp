namespace pogoda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pogoda = new Label();
            searchButton = new Button();
            cityCombobox = new ComboBox();
            cityLabel = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(pogoda);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pogodowe";
            // 
            // pogoda
            // 
            pogoda.AutoSize = true;
            pogoda.Location = new Point(62, 37);
            pogoda.Name = "pogoda";
            pogoda.Size = new Size(48, 15);
            pogoda.TabIndex = 0;
            pogoda.Text = "pogoda";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(12, 57);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(241, 46);
            searchButton.TabIndex = 1;
            searchButton.Text = "Sprawdź pogodę";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // cityCombobox
            // 
            cityCombobox.FormattingEnabled = true;
            cityCombobox.Items.AddRange(new object[] { "Gdańsk" });
            cityCombobox.Location = new Point(12, 26);
            cityCombobox.Name = "cityCombobox";
            cityCombobox.Size = new Size(241, 23);
            cityCombobox.TabIndex = 2;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(12, 8);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(46, 15);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "Miasto:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(51, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 281);
            Controls.Add(cityLabel);
            Controls.Add(cityCombobox);
            Controls.Add(searchButton);
            Controls.Add(groupBox1);
            MaximumSize = new Size(280, 320);
            MinimumSize = new Size(280, 320);
            Name = "Form1";
            Text = "Pogoda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button searchButton;
        private ComboBox cityCombobox;
        private Label cityLabel;
        private Label pogoda;
        private ListBox listBox1;
    }
}
