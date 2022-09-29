using PersonalFinanceApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class InsertData : Form
    {
        private readonly DataAccess _data = new DataAccess();
        
        private List<History> _history;

        public InsertData()
        {
            InitializeComponent();
            dateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            string date;

            if (!String.IsNullOrEmpty(categoryTextBox.Text) && !String.IsNullOrEmpty(amountTextBox.Text))
            {
                try
                {
                    if (typeDropdown.SelectedIndex != -1)
                    {
                        _history = _data.GetData();
                        
                        date = dateTextBox.Text;
                        string type = typeDropdown.Text;
                        string category = categoryTextBox.Text;
                        string comment = commentTextBox.Text;
                        string amount;
                        string total;

                        if (_history.Count == 0)
                        {
                            amount = RemoveWhiteSpaces(amountTextBox.Text);
                            total = amount;
                        }
                        else
                        {
                            amount = RemoveWhiteSpaces(amountTextBox.Text);
                            total = GetTotal().ToString();
                        }

                        _data.InsertData(
                            date, 
                            type, 
                            category, 
                            String.Format("{0:#,##0.00}", 
                            Int32.Parse(amount)),
                            String.Format("{0:#,##0.00}", 
                            Int32.Parse(total)), 
                            comment
                        );
                        
                        ClearTextBoxes();
                        MessageBox.Show("Данные успешны записаны", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Hide();
                    new MainForm().Show();
                }
            }
        }

        private int GetTotal()
        {
            int total;
            int lastTotal = ChangeFormat(_history.LastOrDefault().Total); 
            int amount = int.Parse(RemoveWhiteSpaces(amountTextBox.Text));

            if(typeDropdown.SelectedIndex == 0)
                total = lastTotal + amount;
            else
                total = lastTotal - amount;

            return total;
        }

        private void ClearTextBoxes()
        {
            categoryTextBox.Text = commentTextBox.Text = amountTextBox.Text = String.Empty;
            dateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            typeDropdown.SelectedIndex = -1;
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true; 
        }

        private string RemoveWhiteSpaces(string str) => Regex.Replace(str, @"\s", "");

        private int ChangeFormat(string s) => (int)Double.Parse(RemoveWhiteSpaces(s).Substring(0, s.Length - 3));

        private void InsertData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
