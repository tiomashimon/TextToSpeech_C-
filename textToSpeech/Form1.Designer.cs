namespace textToSpeech
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.voice = new System.Windows.Forms.ComboBox();
            this.rate = new System.Windows.Forms.ComboBox();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.synthesis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.stop = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // voice
            // 
            this.voice.FormattingEnabled = true;
            this.voice.Location = new System.Drawing.Point(75, 27);
            this.voice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(181, 21);
            this.voice.TabIndex = 0;
            // 
            // rate
            // 
            this.rate.FormattingEnabled = true;
            this.rate.Items.AddRange(new object[] {
            "Extra Low",
            "Low",
            "Normal",
            "Medium",
            "Fast",
            "Extra Fast"});
            this.rate.Location = new System.Drawing.Point(276, 27);
            this.rate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(92, 21);
            this.rate.TabIndex = 2;
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputText.Location = new System.Drawing.Point(22, 127);
            this.inputText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputText.MaximumSize = new System.Drawing.Size(578, 227);
            this.inputText.MinimumSize = new System.Drawing.Size(578, 227);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(578, 227);
            this.inputText.TabIndex = 4;
            this.inputText.Text = "The program synthesizes text into spoken words, providing a convenient way to cre" +
    "ate audio content from written materials. Please input text here.";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // synthesis
            // 
            this.synthesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.synthesis.FlatAppearance.BorderSize = 0;
            this.synthesis.Location = new System.Drawing.Point(36, 371);
            this.synthesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.synthesis.Name = "synthesis";
            this.synthesis.Size = new System.Drawing.Size(171, 44);
            this.synthesis.TabIndex = 5;
            this.synthesis.Text = "Synthesize";
            this.synthesis.UseVisualStyleBackColor = true;
            this.synthesis.Click += new System.EventHandler(this.synthesis_Click);
            this.synthesis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.synthesis_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(213, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(444, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(319, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volume";
            // 
            // download
            // 
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.Location = new System.Drawing.Point(225, 371);
            this.download.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(171, 44);
            this.download.TabIndex = 10;
            this.download.Text = "Install";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(86, 78);
            this.volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(508, 45);
            this.volume.TabIndex = 11;
            this.volume.Value = 5;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.Location = new System.Drawing.Point(411, 371);
            this.stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(171, 44);
            this.stop.TabIndex = 12;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(402, 28);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(111, 20);
            this.fileName.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 436);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.download);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.synthesis);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.voice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "TextToSpeech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox voice;
        private System.Windows.Forms.ComboBox rate;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Button synthesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox fileName;
    }
}

