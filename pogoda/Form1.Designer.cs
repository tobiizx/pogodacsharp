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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            generatedTime = new Label();
            lastUpdatedLabel = new Label();
            precipitationLabel = new Label();
            humidityLabel = new Label();
            temperatureLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(generatedTime);
            groupBox1.Controls.Add(lastUpdatedLabel);
            groupBox1.Controls.Add(precipitationLabel);
            groupBox1.Controls.Add(humidityLabel);
            groupBox1.Controls.Add(temperatureLabel);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pogodowe";
            // 
            // generatedTime
            // 
            generatedTime.AutoSize = true;
            generatedTime.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            generatedTime.Location = new Point(4, 19);
            generatedTime.Name = "generatedTime";
            generatedTime.Size = new Size(101, 15);
            generatedTime.TabIndex = 4;
            generatedTime.Text = "Wygenerowano w";
            // 
            // lastUpdatedLabel
            // 
            lastUpdatedLabel.AutoSize = true;
            lastUpdatedLabel.Location = new Point(1, 145);
            lastUpdatedLabel.Name = "lastUpdatedLabel";
            lastUpdatedLabel.Size = new Size(73, 15);
            lastUpdatedLabel.TabIndex = 3;
            lastUpdatedLabel.Text = "Aktualizacja:";
            // 
            // precipitationLabel
            // 
            precipitationLabel.AutoSize = true;
            precipitationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            precipitationLabel.Location = new Point(6, 108);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new Size(132, 21);
            precipitationLabel.TabIndex = 2;
            precipitationLabel.Text = "Szansa opadów:";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            humidityLabel.Location = new Point(6, 78);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new Size(101, 21);
            humidityLabel.TabIndex = 1;
            humidityLabel.Text = "Wilgotność:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            temperatureLabel.Location = new Point(6, 47);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(111, 21);
            temperatureLabel.TabIndex = 0;
            temperatureLabel.Text = "Temperatura:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 186);
            Controls.Add(groupBox1);
            MaximumSize = new Size(280, 225);
            MinimumSize = new Size(280, 225);
            Name = "Form1";
            Text = "Pogoda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.Timer Timer;
        private Label lastUpdatedLabel;
        private Label precipitationLabel;
        private Label humidityLabel;
        private Label temperatureLabel;
        private Label generatedTime;
    }
}
