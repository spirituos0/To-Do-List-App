namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            listTasks = new ListBox();
            btnClearTasks = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(103, 90);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(100, 23);
            txtTask.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(12, 263);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(98, 23);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(116, 263);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(110, 23);
            btnRemoveTask.TabIndex = 2;
            btnRemoveTask.Text = "Remove Task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // listTasks
            // 
            listTasks.FormattingEnabled = true;
            listTasks.ItemHeight = 15;
            listTasks.Location = new Point(103, 141);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(120, 94);
            listTasks.TabIndex = 3;
            // 
            // btnClearTasks
            // 
            btnClearTasks.Location = new Point(232, 263);
            btnClearTasks.Name = "btnClearTasks";
            btnClearTasks.Size = new Size(120, 23);
            btnClearTasks.TabIndex = 4;
            btnClearTasks.Text = "Clear All Tasks";
            btnClearTasks.UseVisualStyleBackColor = true;
            btnClearTasks.Click += btnClearTasks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 366);
            Controls.Add(btnClearTasks);
            Controls.Add(listTasks);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "To-Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private ListBox listTasks;
        private Button btnClearTasks;
    }
}
