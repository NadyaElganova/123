using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneBook phoneBook;
        public Form1()
        {
            InitializeComponent();
            phoneBook = new PhoneBook();
            Search_ComboBox.SelectedIndex = 0;
        }

        private void AddPhoneBook_Button_Click(object sender, EventArgs e)
        {
            long phone;
            if (long.TryParse(PhoneNumber_TextBox.Text, out phone) == true)
            {
                phoneBook.AddHuman(FirstName_TextBox.Text, LastName_TextBox.Text, phone);
                Human_ListBox.Items.Add(phoneBook.Humans.Last().Show());
                PhoneNumber_TextBox.BackColor = Color.White;
                FirstName_TextBox.Text = "";
                LastName_TextBox.Text = "";
                PhoneNumber_TextBox.Text = "";
            }
            else
            {
                PhoneNumber_TextBox.Text = "";
                PhoneNumber_TextBox.BackColor = Color.Red;
                MessageBox.Show("Номер телефона введен некорректно! Номер должен состоять из цифр!");
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Human_ListBox.Items.Clear();
            foreach (Human item in phoneBook.Search(Search_TextBox.Text, Search_ComboBox.SelectedItem.ToString()))
            {
                Human_ListBox.Items.Add(item.Show());
            }
            Search_TextBox.Text = "";
        }

        private void DeleteHuman_Button_Click(object sender, EventArgs e)
        {
            string[] strings = Human_ListBox.SelectedItem.ToString().Split(' ');
            long phone;
            long.TryParse(strings[2], out phone);
            phoneBook.DeleteHuman(phone);
            Human_ListBox.Items.Remove(Human_ListBox.SelectedItem);
        }

        private void FirstName_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstName_RadioButton.Checked == true)
            {
                Human.LastNameSort = false;
                phoneBook.Humans.Sort();
                UpdateListBox();
            }
        }
        private void UpdateListBox()
        {
            Human_ListBox.Items.Clear();
            foreach (Human item in phoneBook.Humans)
            {
                Human_ListBox.Items.Add(item.Show());
            }
        }

        private void LastName_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (LastName_RadioButton2.Checked == true)
            {
                //Human.LastNameSort = true;
                //phoneBook.Humans.Sort();
                foreach (Human item in phoneBook.Humans)
                {
                    phoneBook.Humans.Sort(item.Compare);
                }
                UpdateListBox();
            }
        }
    }
}
