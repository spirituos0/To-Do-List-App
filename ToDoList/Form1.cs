using System;
using System.Windows.Forms;

namespace ToDoList

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                listTasks.Items.Add(task);
                txtTask.Clear();
                txtTask.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a task before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                listTasks.Items.Remove(listTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearTasks_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear all tasks?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                listTasks.Items.Clear();
            }
        }
    }
}
