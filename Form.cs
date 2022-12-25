using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        int count = 0;
        Random rnd = new Random();
        char[] specialsChars = new[] {'%', '*', '?', '#', '(', ')', '$', '^', '&', '!', '@'};
        Dictionary<string, double> metrica = new Dictionary<string, double>();
        public Form()
        {
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
            InitializeComponent();
        }

        private void Прога_Load(object sender, EventArgs e)
        {
            LoadNP();
            PassListBox.SetItemChecked(0, true);
            PassListBox.SetItemChecked(2, true);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("С уважением для Георгия Галактионовича и 16 практической", "Lotsmanov Fyodor ©");

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = count.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            count--;
            labelCount.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = rnd.Next(Convert.ToInt32(From.Value), Convert.ToInt32(Till.Value)+1);
            Numb.Text = num.ToString();

            if (cbWR.Checked == true)
            {
                int i = 0;

                while (textBoxRND.Text.IndexOf(num.ToString()) != -1)
                {
                    num = rnd.Next(Convert.ToInt32(From.Value), Convert.ToInt32(Till.Value) + 1); 
                    i++;
                    if (i > 1000) break;    
                }
                if (i <= 1000) textBoxRND.AppendText(num + "\r\n");
            }
            else textBoxRND.AppendText(num + "\r\n");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxRND.Clear();
        }

        private void Copy_Click(object sender, EventArgs e)
        {   //Исправил ошибку с вылето, когда ТБ пустой)))
            if (textBoxRND.Text != "")
            {
                Clipboard.SetText(textBoxRND.Text);
            }
            
        }
        private void InsertDate_Click(object sender, EventArgs e)
        {
            NoteP.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }
        private void InsertTime_Click(object sender, EventArgs e)
        {
            NoteP.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void saveTS_Click(object sender, EventArgs e)
        {
            try
            {
                NoteP.SaveFile ("Mynote.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении", "Error 1");
            }
            
        }
        void LoadNP()
        {
            try
            {
                NoteP.LoadFile("Mynote.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке", "Error 0");
            }
        }
        private void loadTS_Click(object sender, EventArgs e)
        {
            LoadNP();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (PassListBox.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int n = rnd.Next(0, PassListBox.CheckedItems.Count);
                string s = PassListBox.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 90));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += specialsChars[rnd.Next(specialsChars.Length) ];
                        break;
                }
                PasswordTB.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void ConvertBt_Click(object sender, EventArgs e)
        {
            double m1 = metrica[FromCB.Text];
            double m2 = metrica[ToCB.Text];
            double n = Convert.ToDouble(FromTB.Text);
            ToTB.Text = (n * m1 / m2).ToString();
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            string t = FromCB.Text;
            FromCB.Text = ToCB.Text;
            ToCB.Text = t;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    FromCB.Items.Clear();
                    FromCB.Items.Add("mm");
                    FromCB.Items.Add("cm");
                    FromCB.Items.Add("dm");
                    FromCB.Items.Add("m");
                    FromCB.Items.Add("km");
                    FromCB.Items.Add("mile");
                    ToCB.Items.Clear();
                    ToCB.Items.Add("mm");
                    ToCB.Items.Add("cm");
                    ToCB.Items.Add("dm");
                    ToCB.Items.Add("m");
                    ToCB.Items.Add("km");
                    ToCB.Items.Add("mile");
                    ToCB.Text = "mm";
                    FromCB.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 28.3);
                    FromCB.Items.Clear();
                    FromCB.Items.Add("g");
                    FromCB.Items.Add("kg");
                    FromCB.Items.Add("t");
                    FromCB.Items.Add("lb");
                    FromCB.Items.Add("oz");
                    ToCB.Items.Clear();
                    ToCB.Items.Add("g");
                    ToCB.Items.Add("kg");
                    ToCB.Items.Add("t");
                    ToCB.Items.Add("lb");
                    ToCB.Items.Add("oz");
                    ToCB.Text = "g";
                    FromCB.Text = "g";
                    break;
                default:
                    break;
            }
        }
    }
}