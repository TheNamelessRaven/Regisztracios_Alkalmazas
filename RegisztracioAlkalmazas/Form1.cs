using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newhobby.Text.Trim()))
            {
                MessageBox.Show("A mező üres nincs mit hozzáadni a listához", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newhobby.Focus();
                return;
            }
            int sor = 0;
            foreach (string item in hobby_list.Items)
            {
                if (newhobby.Text == item)
                {
                    MessageBox.Show("Ez a hobbi már szerepel a listában!");
                    return;
                }
            }
            hobby_list.Items.Add(newhobby.Text);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (hobby_list.SelectedIndex == -1)
            {
                MessageBox.Show("Nem választottál hobbit!");
                return;
            }
            if (String.IsNullOrEmpty(name.Text.Trim()))
            {
                MessageBox.Show("Név kitöltése kötelező!","Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name.Focus();
                return; 
            }
            string nev = name.Text;
            string nem;
            if(male.Checked==false&&female.Checked==false)
            {
                MessageBox.Show("Nem töltötted ki a nemét az adott személynek!","Hiányző adat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (male.Checked==true){
                nem = "Férfi"; 
            }
            else
            {
                nem = "Nő";
            }
            
            string szul = birth__date.Text;
            string hobby = hobby_list.GetItemText(hobby_list.SelectedItem);
            saveFileDialog1.ShowDialog();
            using(StreamWriter sw=new StreamWriter(saveFileDialog1.FileName))
            {
                sw.WriteLine(String.Format("{0};{1};{2};{3};",nev,szul,nem,hobby));
            }

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Nem választottál ki semmit így nem történt meg a beolvasás!");
                return;
            }
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                hobby_list.ClearSelected();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    string nev = sor[0];
                    string szul=sor[1];
                    string nem = sor[2];
                    string hobby = sor[3];
                    name.Text = nev;
                    birth__date.Value =Convert.ToDateTime(szul);
                    if (nem=="Férfi")
                    {
                        male.Checked=true;
                    }
                    else if(nem=="Nő")
                    {
                        female.Checked = true;
                    }
                    bool talal = false;
                    foreach(string items in hobby_list.Items)
                    {
                        if(hobby==items)
                        {
                            talal = true;
                            
                        }
                       
                    }
                    if (talal)
                    {
                        hobby_list.SelectedIndex = hobby_list.Items.IndexOf(hobby);
                    }                    
                    else
                    {
                        //hozzáadás
                        hobby_list.Items.Add(hobby);
                        hobby_list.SelectedIndex=hobby_list.Items.IndexOf(hobby);
                    }
                }
            }
        }

        private void birth__date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
