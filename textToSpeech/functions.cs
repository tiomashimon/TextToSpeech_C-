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

namespace textToSpeech
{
    internal class functions
    {
        // Створення нового об'єкта SpeechSynthesizer
        public static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Створення MemoryStream для зберігання згенерованого аудіо
        public static MemoryStream outputStream = new MemoryStream();

        // Налаштування WaveFileWriter для запису згенерованого аудіо у файл
        public static WaveFileWriter writer = new WaveFileWriter(outputStream, new WaveFormat(16000, 16, 1));


        public static void synthesis(ComboBox userVoice, RichTextBox userText, TrackBar userVolume, TextBox userFileName, ComboBox userRate, Button stop)
            {
            object selectedItem = userVoice.SelectedItem;

            string selectedVoice = userVoice.SelectedText;
            string voiceText = "If this message talking, its mean thats u made mistake!";

            selectedVoice = selectedItem.ToString();


            synthesizer.Volume = userVolume.Value * 10;


            string selectedRate = userRate.SelectedItem?.ToString(); // Отримуємо вибраний елемент як рядок
            if (!string.IsNullOrEmpty(selectedRate))
            {
                if (selectedRate == "Extra Low")
                {
                    synthesizer.Rate = -10;
                }
                else if (selectedRate == "Low")
                {
                    synthesizer.Rate = -5;
                }
                else if (selectedRate == "Normal")
                {
                    synthesizer.Rate = 0;
                }
                else if (selectedRate == "Medium")
                {
                    synthesizer.Rate = 3;
                }
                else if (selectedRate == "Fast")
                {
                    synthesizer.Rate = 6;
                }

                else if (selectedRate == "Extra Fast")
                {
                    synthesizer.Rate = 10;
                }
                else
                {
                    MessageBox.Show("Please enter correct speed");
                }
            }



            // Налаштовуємо голос на використання
            if (synthesizer.GetInstalledVoices().Any(v => v.VoiceInfo.Name == selectedVoice))
            {
                synthesizer.SelectVoice(selectedVoice);

                // Проговорюємо a string
                if (!string.IsNullOrEmpty(userText.Text))
                {
                    voiceText = userText.Text;
                }
                else
                {
                    synthesizer.SelectVoice("Microsoft Zira Desktop");
                    MessageBox.Show("You forgot input the text!");
                    synthesizer.SpeakAsyncCancelAll();
                }
            }
            else
            {
                synthesizer.SelectVoice("Microsoft Zira Desktop");
            }
            // Запускоємо ще один поток, щоб не блокувати застосунок
            Task.Run(() =>
            {
                try
                {
                    synthesizer.Speak(voiceText);

                }
                catch ( Exception ex)
                {
                    Console.WriteLine("Error");
                }

            });


        }
        public static void synthesisAndDownload(ComboBox userVoice, RichTextBox userText, TrackBar userVolume, TextBox userFileName, ComboBox userRate, Button stop)
        {
            object selectedItem = userVoice.SelectedItem;

            string selectedVoice = userVoice.SelectedText;
            if (!string.IsNullOrEmpty(selectedVoice))
            {
                selectedVoice = selectedItem.ToString();
            }
            else
            {
                selectedVoice = "Microsoft Zira Desktop";
            }

            synthesizer.Volume = userVolume.Value * 10;


            string selectedRate = userRate.SelectedItem?.ToString(); 
            if (!string.IsNullOrEmpty(selectedRate)) 
            {
                if (selectedRate == "Extra Low")
                {
                    synthesizer.Rate = -10;
                }
                else if (selectedRate == "Low")
                {
                    synthesizer.Rate = -5;
                }
                else if (selectedRate == "Normal")
                {
                    synthesizer.Rate = 0;
                }
                else if (selectedRate == "Medium")
                {
                    synthesizer.Rate = 3;
                }
                else if (selectedRate == "Fast")
                {
                    synthesizer.Rate = 6;
                }

                else if (selectedRate == "Extra Fast")
                {
                    synthesizer.Rate = 10;
                }
                else
                {
                    MessageBox.Show("Please enter correct speed");
                }
            }


            // Налаштуйте WaveInEvent для захоплення згенерованого звуку
            WaveInEvent waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(16000, 16, 1);
            waveIn.DataAvailable += (s, e) =>
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            };

            string voiceText = "hey!";

            // Налаштовуємо голос на використання
            if (synthesizer.GetInstalledVoices().Any(v => v.VoiceInfo.Name == selectedVoice))
            {
                synthesizer.SelectVoice(selectedVoice);

                // Проговорюємо a string
                if (!string.IsNullOrEmpty(userText.Text))
                {
                    voiceText = userText.Text;
                }
                else
                {
                    voiceText = "You forgot input the text!";
                }
            }
            else
            {
                voiceText = "Pls choose correct Voice";
                synthesizer.SelectVoice("Microsoft Zira Desktop");
                
            }

           
            // Запускоємо ще один поток, щоб не блокувати застосунок
            Task.Run(() =>
            {
                try
                {

                    synthesizer.Speak(voiceText);
                    // Припинення записування звуку та очищення
                    waveIn.StopRecording();
                    writer.Close();

                    string username = Environment.UserName;

                    string outputFilename = $"C:\\Users\\{username}\\Desktop\\Audio\\{userFileName.Text}.wav";

                    // Запис згенерованого аудіо в файл
                    using (FileStream fileStream = new FileStream(outputFilename, FileMode.Create, FileAccess.Write))
                    {
                        // Перемотуємо трансляцію на початок
                        outputStream.Seek(0, SeekOrigin.Begin);
                        byte[] bytes = outputStream.ToArray();
                        fileStream.Write(bytes, 0, bytes.Length);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }

            });


        }
        public static void fieldComboBox(ComboBox voice)
        {
            // Створення нового екземпляра SpeechSynthesizer
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Отримуємо список всіх встановлених голосів
                foreach (InstalledVoice userVoice in synth.GetInstalledVoices())
                {
                    // Додаємо всі голоси в СomobBox
                    VoiceInfo info = userVoice.VoiceInfo;
                    voice.Items.Add(info.Name);
                }
            }
        }

        public static string[] AllVoices()
        {
            string[] voices = new string[0];
            // Створення нового екземпляра SpeechSynthesizer
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Отримуємо список всіх встановлених голосів
                foreach (InstalledVoice userVoice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = userVoice.VoiceInfo;
                    voices.Append(info.Name);
                }
            }
            return voices;
        }

        public static void stopPlaySpeech(Button stop)
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        public static void downloadAudio()
        {

        }
        public static void  createFolder()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string audioFolderPath = Path.Combine(desktopPath, "Audio");

            if (!Directory.Exists(audioFolderPath))
            {
                Directory.CreateDirectory(audioFolderPath);
            }
        }
    }
}

