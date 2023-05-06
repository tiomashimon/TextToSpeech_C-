using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Diagnostics;
using Google.Cloud.TextToSpeech.V1;
using Google.Api;

namespace textToSpeech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functions.createFolder();
            voice.DropDownStyle = ComboBoxStyle.DropDownList;
            rate.DropDownStyle = ComboBoxStyle.DropDownList;
            functions.fieldComboBox(voice);
            voice.SelectedIndex = 1;
            rate.SelectedIndex = 2;
            design.DesignButtons(stop, synthesis, download);
            design.DesignRichTextBox(inputText);
            
        }
        private void download_Click(object sender, EventArgs e)
        {
            functions.synthesisAndDownload(voice, inputText, volume, fileName, rate, stop);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            functions.stopPlaySpeech(stop);
        }

        private void synthesis_Click(object sender, EventArgs e)
        {
            functions.synthesis(voice, inputText, volume, fileName, rate,stop);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void synthesis_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void volume_Scroll(object sender, EventArgs e)
        {

        }
    }
}
