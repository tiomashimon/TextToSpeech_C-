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
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.IO;
using NAudio.Wave;
using Google.Cloud.TextToSpeech.V1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace textToSpeech
{
    internal class design
    {
        public static void SetButtonBorderRadius(Button button, int borderRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);

            button.Region = new Region(path);

            // Створення графічного контексту кнопки
            Graphics graphics = button.CreateGraphics();

            // Увімкнення згладжування
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Малюємо рамку кнопки, використовуючи графічний контекст
            using (Pen pen = new Pen(button.FlatAppearance.BorderColor, 1))
            {
                graphics.DrawPath(pen, path);
            }

            // Звільнення графічних контекстних ресурсів
            graphics.Dispose();
        }


        public static void DesignButtons(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                Color StopColor = Color.FromArgb(233, 90, 87);
                Color SynthesizeColor = Color.FromArgb(64, 190, 249);
                Color InstallColor = Color.FromArgb(129, 199, 133);

                button.FlatStyle = FlatStyle.Flat;

                // Змінення кольору фона
                if (button.Text == "Stop")
                {
                    button.BackColor = StopColor;
                }
                else if(button.Text == "Synthesize")
                {
                    button.BackColor = SynthesizeColor;
                }
                else
                {
                    button.BackColor = InstallColor;
                }

                // Змінення кольору шрифту на білий
                button.ForeColor = Color.White;

                // Змінення кольору межі на чорний
                button.FlatAppearance.BorderColor = Color.Black;

                button.Font = new Font("e-UkraineHead-Bold", 10);

                button.Font = new Font(button.Font, FontStyle.Bold);

                SetButtonBorderRadius(button, 10);
            }

            
            
        }
        public static void DesignRichTextBox(RichTextBox UserText)
        {
            UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            UserText.BackColor = Color.White;
            UserText.ForeColor = Color.Black;

        }

        public static void DesignForm(Form form, string iconPath)
        {
            Icon newIcon = new Icon(iconPath);
            form.Icon = newIcon;
        }



    }
}

