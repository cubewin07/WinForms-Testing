using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Learning_GUI
{
    public partial class Form1 : Form
    {
        public List<Expense> expenses = new List<Expense>();
        public string[] categories;
        public Form1()
        {
            InitializeComponent();
            categories = new string[] { "Food", "Entertain"};
            comboBox1.Items.AddRange(categories);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(expenseBox.Text))
            {
                MessageBox.Show("Please enter your expense");
                return;
            }

            if(comboBox1.SelectedItem == null && string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please enter your category");
                comboBox1.Focus();
                return;
            }

            if(quantity.Value == 0)
            {
                MessageBox.Show("Plese enter your quantity");
                return;
            }

            var category = comboBox1.Text;

            expenses.Add(new Expense(expenseBox.Text, quantity.Value, comboBox1.Text));

            expenseBox.Clear();
            quantity.ResetText();
            comboBox1.ResetText();


            RefreshListBox(listBox1, expenses);
            RefreshDgv(dataGridView1, expenses);

            expenseBox.Focus();
        }

        private void clearAll_btn(object source, EventArgs e)
        {
            expenses.Clear();
            dataGridView1.DataSource = null;
        }

        private void RefreshListBox<T>(ListBox listBox, List<T> list)
        {
            listBox.DataSource = null;
            listBox.DataSource = list;
        }

        private void RefreshDgv<T>(DataGridView view, List<T> list)
        {
            view.DataSource = null;
            view.DataSource = list;
        }
    }

    public class Expense
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }

        public string Category { get; set; }

        public Expense(string name, decimal quantity, string category)
        {
            Name = name;
            Quantity = quantity;
            Category = category;
        }
    }
}
