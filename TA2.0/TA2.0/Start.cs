using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA2._0
{
    public partial class Start : Form
    {
        
        public Start()
        {
            InitializeComponent();
            
        }

        private void startprogramm_Click(object sender, EventArgs e)
        {
            Input form = new Input();
            form.Show();
        }

        private void exitprogramm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoprogramm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Программа выполняет проверку есть ли перекрывающиеся вхождения образца в тексте. \n \n \n Если вы поняли принцип работы программы нажмите, да",  
            "Инструкция", 
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.No)
            {
                Close();
            }
            else
            {
                this.TopMost = true;
            }
        }
    }
}
