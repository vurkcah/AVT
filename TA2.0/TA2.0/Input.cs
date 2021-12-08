using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA2._0
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outtext.Clear();
            AVT.GenRandom(Convert.ToInt32(MaxLength.Value));
            outtext.Text = AVT.SourceText;
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            if (outtext.Text != "")
            {
                //inputOccurrences.Clear();
                AVT.SourceText = outtext.Text;
                AVT.SubString = inputsubstring.Text;

                List<int> indexes = AVT.AllIndexesOf();
                List<bool> UP = new List<bool>();
                for (int i = 0; i < AVT.SourceText.Length; i++)
                {
                    bool a = false;
                    UP.Add(a);
                    Application.DoEvents();

                }

                for (int i = 0; i < indexes.Count; i++)
                {
                    for (int j = 0; j < AVT.SubString.Length; j++)
                    {
                        UP[indexes[i] + j] = true;
                        Application.DoEvents();
                    }
                }

                outtext.Clear();
                for (int i = 0; i < AVT.SourceText.Length; i++)
                {
                    if (UP[i])
                    {
                        outtext.Text += Convert.ToString(AVT.SourceText[i]).ToUpper();
                        Application.DoEvents();

                    }
                    else
                    {
                        outtext.Text += AVT.SourceText[i];
                        Application.DoEvents();

                    }
                }

                //inputOccurrences.Text = string.Join("; ", indexes);

                if (AVT.notoryes == true)
                {
                    OverlappingOccurrences.Text = "Перекрывающиеся вхождения образца в тексте имеются";
                }
                else
                {
                    OverlappingOccurrences.Text = "Перекрывающихся вхождений образца в тексте нет";
                }

            }
            else
            {
                MessageBox.Show(
                    "Введите строку-образец!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outtext.Clear();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Текстовые файлы|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    outtext.Text = File.ReadAllText(dialog.FileName);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            outtext.Clear();
            OverlappingOccurrences.Clear();
            inputsubstring.Clear();
        }
    }
}
