using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPhoneBook
{
    public partial class Form1 : Form
    {
        List<Person> list = new List<Person>();
        public Form1()
        {
            InitializeComponent();

            list.Add(new Person
            {
                FirstName = "Дут",
                LastName = "Університет",
                PhoneNumber = "0442492591"
            });
            list.Add(new Person
            {
                FirstName = "",
                LastName = "Поліція",
                PhoneNumber = "102"
            });
            list.Add(new Person
            {
                FirstName = "Олег",
                LastName = "Ляшко",
                PhoneNumber = "0442552748"
            });
            updateList(list);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResult.Text = txtResult.Text + strDebugText + Environment.NewLine;
                txtResult.SelectionStart = txtResult.TextLength;
                txtResult.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        
        private void updateList(List<Person> list) {
            listPhone.Items.Clear();
            foreach (var people in list)
            {
                debugOutput(people.info());
                listPhone.Items.Add(people.info());
            }
        }
        private bool is_valid()
        {
            foreach (var people in list)
            {
                if (textBox3.Text == people.PhoneNumber)
                {
                    error.Text = "Ви вже маэте такий контакт";
                    return false;
                }
            }
            bool flag = true;
            foreach (char c in textBox3.Text.ToCharArray())
            {
                if (c < '0' || c > '9')
                    flag = false;
            }
            if (flag == false){ 
                error.Text = "Номер повинен містити тільки цифри";
                return false;
            }

            if (textBox1.Text == "" && textBox2.Text == "") {
                error.Text = "Дайте назву контакту";
                return false;
            }
            return true;
                



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            error.Text = "";
            if (is_valid())
            {
                Person p = new Person
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    PhoneNumber = textBox3.Text,
                };
                list.Add(p);
                debugOutput("Added!");
                updateList(list);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            error.Text = "";
            string qery = searchText.Text;
            List<Person> listSearch = new List<Person>();

            foreach (var people in list)
            {
                if (people.FirstName.IndexOf(qery) != -1 || people.LastName.IndexOf(qery) != -1 || people.PhoneNumber.IndexOf(qery) != -1)
                {
                    debugOutput(people.info());
                    listSearch.Add(people);
                }
            }
            if (listSearch.Count > 0)
                updateList(listSearch);
            else {
                error.Text = "Такого контакту не знайдено";
                updateList(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.RemoveAt(listPhone.SelectedIndex);
            updateList(list);
            debugOutput("Person removed from list!");
        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            error.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtResult.Text = "";
            searchText.Text = "";
            updateList(list);
        }
    }
}
