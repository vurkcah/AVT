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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outtext.Clear();
            Alphabet.max = Convert.ToInt32(MaxLength.Value);
            Random rnd = new Random();
            for (int i = 0; i < Alphabet.max; i++)
            {
                outtext.Text += Alphabet.alphabet[rnd.Next(0, Alphabet.alphabet.Count)];
            }
           
        }


        public static bool CheckAlphabet()
        {
            for (int i = 0; i < AVT.SourceText.Length; i++)
                if (!Alphabet.alphabet.Contains(Convert.ToString(AVT.SourceText[i])))
{
                    return false;
                }

            for (int i = 0; i < AVT.SubString.Length; i++)
                if (!Alphabet.alphabet.Contains(Convert.ToString(AVT.SubString[i])))
                    return false;

            return true;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (outtext.Text != "")
            {

              
                inputOccurrences.Clear();
                AVT.SourceText = outtext.Text;
                AVT.SubString = inputsubstring.Text;

                List<int> indexes = AVT.AllIndexesOf();

                for (int i = 0; i < indexes.Count; i++)
                {
                    inputOccurrences.Text += Convert.ToString(indexes[i]);

                }


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
    }
}
