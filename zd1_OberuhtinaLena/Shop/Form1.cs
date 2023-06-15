using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shop
{
    public partial class Form1 :Form
    {
        Product cola = new Product("Кола", 85);
        Product juice = new Product("Сок \"Добрый\"", 100);
        Shop pyaterochka = new Shop();
        List<string> pr = new List<string>();
        
        Product product;
        Playlist playlist;

        public Form1 ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Кола");
            comboBox1.Items.Add("Сок \"Добрый\"");
            playlist = new Playlist();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            listBox1.Items.Add(cola.GetInfo());
            listBox1.Items.Add(juice.GetInfo());
            pyaterochka.AddProduct(cola, 9000);
            pyaterochka.AddProduct(juice, 9000);
            pyaterochka.WriteAllProducts(listBox1);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            string name = comboBox1.Text;
           if(comboBox1==null) MessageBox.Show("Выберите товар");
            else
            {
            Product product = pyaterochka.FindByName(name);
            
            
                pyaterochka.Sell(product);
                pyaterochka.WriteAllProducts(listBox1);
                MessageBox.Show("Товар продан!");
                
            
            }
           
           

            
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("Введите названеи продукта");
            else
            {
            Product product = new Product(textBox3.Text,numericUpDown2.Value);
            pr.Add(textBox3.Text);
            comboBox1.Items.Add(textBox3.Text);
            pyaterochka.AddProduct(product, (int) numericUpDown3.Value);
            pyaterochka.WriteAllProducts(listBox1);
            }
           
        }
        private void Zagruz()
        {
            try
            {
                Song song = playlist.CurrentSong();
                textBox1.Text = song.Author;
                textBox2.Text = song.Title;
                textBox4.Text = song.Filename;
            }
            catch (IndexOutOfRangeException)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox4.Text = string.Empty;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            playlist.Vpered();
            Zagruz();
           
        }
      

        private void button3_Click(object sender, EventArgs e)
        {   if (textBox1.Text==""|| textBox2.Text == "" || textBox4.Text == "" )
            { 
                MessageBox.Show("Заполните все поля");
                return;
            }
        else
            { 
            string author = textBox1.Text;
            string title = textBox2.Text;
            string filename = textBox4.Text;
            playlist.Dobav(author, title, filename);
            MessageBox.Show("Песня  добавлена");
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

            }         
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playlist.Nazad();
            Zagruz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playlist.Nachalo();
            Zagruz();
        }

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    if (int.TryParse(textBox5.Text, out int index))
        //    {
        //        try
        //        {
        //            playlist.Delet(index);
        //            Zagruz();
        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Неправильный индекс");
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            Zagruz();

        }

      
    }
}
