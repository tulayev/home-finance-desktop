using PersonalFinanceApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class MainForm : Form
    {
        private readonly Filter _filter = new Filter();
        
        private readonly DataAccess _data = new DataAccess();

        private List<History> _history;
        
        public MainForm()
        {
            InitializeComponent();
            InitialInit();
            InitializeDataGridView();
        }

        private void InitialInit()
        {
            _history = _data.GetData();

            if (_history.Count == 0)
            {
                historyTable.Visible = false;
                balanceLabel.Text += "0";
            }
            else
            {
                balanceLabel.Text += _history.LastOrDefault().Total;
            }

            catComboBox.Items.Add("Все");
            catComboBox.Items.AddRange(_history.Select(c => c.Category).Distinct().ToArray());
            UpdateBinding();
        }

        private void InitializeDataGridView()
        {
            historyTable.Columns[1].DisplayIndex = 3;
            historyTable.Columns[0].Visible = false;
        }

        private void UpdateBinding()
        {
            _history = _data.GetData();
            historyTable.DataSource = _history;
            historyTable.Columns[5].Visible = true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Hide();
            new InsertData().Show();
        }

        private void incomeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (incomeCheck.Checked)
            {
                expenseCheck.Checked = false;
                historyTable.DataSource = _filter.GetSortedListByIncome(incomeCheck.Text);
                historyTable.Columns[5].Visible = false;
            }
            else
            {
                UpdateBinding();
            }
        }

        private void expenseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (expenseCheck.Checked)
            {
                incomeCheck.Checked = false;
                historyTable.DataSource = _filter.GetSortedListByExpense(expenseCheck.Text);
                historyTable.Columns[5].Visible = false;
            }
            else
            {
                UpdateBinding();
            }
        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (incomeCheck.Checked || expenseCheck.Checked)
            {
                incomeCheck.Checked = false;
                expenseCheck.Checked = false;
            }

            historyTable.DataSource = _filter.GetSortedList(catComboBox.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
