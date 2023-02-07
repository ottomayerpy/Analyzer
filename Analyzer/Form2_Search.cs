using System;
using System.Drawing;
using System.Windows.Forms;

namespace Analyzer
{
    public partial class Form2_Search : Form
    {
        public Form2_Search()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Form1_Main form = Owner as Form1_Main;
            string search = null;
            byte txt = 0;

            Select(ref search, ref txt, form);
            bool en = true;
            int a1 = 0, b1 = 0, a = 0, b = 0;
            while (en)
            {
                if (search.Contains(TextBox.Text))
                {
                    a = a + a1; b = b + b1;
                    a = search.IndexOf(TextBox.Text);
                    b = TextBox.Text.Length;
                    a1 = a; b1 = b;
                    Select(a, b, txt, form);
                }
                else
                {
                    en = false;
                    MessageBox.Show("Совпадений не найдено");
                }
            }
        }

        private void Select(int a, int b, byte txt, Form1_Main form)
        {
            int i = 0;
            switch(txt)
            {
                case 1:
                    form.TxtCPU.SelectionStart = a;
                    form.TxtCPU.SelectionLength = b;
                    form.TxtCPU.SelectionColor = Color.Red;
                    form.TxtCPU.Focus();

                    while (i <= richTextBox1.Text.Length - str.Length)
                    {
                        i = richTextBox1.Text.IndexOf(str, i);
                        if (i < 0) break;
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = str.Length;
                        richTextBox1.SelectionColor = Color.Blue;
                        i += str.Length;
                    }
                    break;
                case 2:
                    form.TxtRAM.SelectionStart = a;
                    form.TxtRAM.SelectionLength = b;
                    form.TxtGPU.SelectionColor = Color.Red;
                    form.TxtRAM.Focus();
                    break;
                case 3:
                    form.TxtGPU.SelectionStart = a;
                    form.TxtGPU.SelectionLength = b;
                    form.TxtGPU.SelectionColor = Color.Red;
                    form.TxtGPU.Focus();
                    break;
                case 4:
                    form.TxtInterfaces.SelectionStart = a;
                    form.TxtInterfaces.SelectionLength = b;
                    form.TxtInterfaces.SelectionColor = Color.Red;
                    form.TxtInterfaces.Focus();
                    break;
                case 5:
                    form.TxtHDD.SelectionStart = a;
                    form.TxtHDD.SelectionLength = b;
                    form.TxtHDD.SelectionColor = Color.Red;
                    form.TxtHDD.Focus();
                    break;
                case 6:
                    form.TxtSystem.SelectionStart = a;
                    form.TxtSystem.SelectionLength = b;
                    form.TxtSystem.SelectionColor = Color.Red;
                    form.TxtSystem.Focus();
                    break;
                case 7:
                    form.TxtServices.SelectionStart = a;
                    form.TxtServices.SelectionLength = b;
                    form.TxtServices.SelectionColor = Color.Red;
                    form.TxtServices.Focus();
                    break;
                case 8:
                    form.TxtSoft.SelectionStart = a;
                    form.TxtSoft.SelectionLength = b;
                    form.TxtSoft.SelectionColor = Color.Red;
                    form.TxtSoft.Focus();
                    break;
                case 9:
                    form.TxtProcesses.SelectionStart = a;
                    form.TxtProcesses.SelectionLength = b;
                    form.TxtProcesses.SelectionColor = Color.Red;
                    form.TxtProcesses.Focus();
                    break;
                case 10:
                    form.TxtNetwork.SelectionStart = a;
                    form.TxtNetwork.SelectionLength = b;
                    form.TxtNetwork.SelectionColor = Color.Red;
                    form.TxtNetwork.Focus();
                    break;
                case 11:
                    form.TxtOther.SelectionStart = a;
                    form.TxtOther.SelectionLength = b;
                    form.TxtOther.SelectionColor = Color.Red;
                    form.TxtOther.Focus();
                    break;
                default:
                    break;
            }
        }

        private void Select(ref string search, ref byte txt, Form1_Main form)
        {
            switch (Program.TabSelect)
            {
                case "TabCPU":
                    search = form.TxtCPU.Text;
                    txt = 1;
                    break;
                case "TabRAM":
                    search = form.TxtRAM.Text;
                    txt = 2;
                    break;
                case "TabGPU":
                    search = form.TxtGPU.Text;
                    txt = 3;
                    break;
                case "TabInterfaces":
                    search = form.TxtInterfaces.Text;
                    txt = 4;
                    break;
                case "TabHDD":
                    search = form.TxtHDD.Text;
                    txt = 5;
                    break;
                case "TabSystem":
                    search = form.TxtSystem.Text;
                    txt = 6;
                    break;
                case "TabServices":
                    search = form.TxtServices.Text;
                    txt = 7;
                    break;
                case "TabSoft":
                    search = form.TxtSoft.Text;
                    txt = 8;
                    break;
                case "TabProcesses":
                    search = form.TxtProcesses.Text;
                    txt = 9;
                    break;
                case "TabNetwork":
                    search = form.TxtNetwork.Text;
                    txt = 10;
                    break;
                case "TabOther":
                    search = form.TxtOther.Text;
                    txt = 11;
                    break;
                default:
                    break;
            }
        }
    }
}