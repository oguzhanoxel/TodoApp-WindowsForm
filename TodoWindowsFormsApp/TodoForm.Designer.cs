namespace TodoWindowsFormsApp
{
    partial class TodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.newTodo = new System.Windows.Forms.TabPage();
            this.create = new System.Windows.Forms.Button();
            this.descriptionNewTodoTextBox = new System.Windows.Forms.TextBox();
            this.titleNewTodoTextBox = new System.Windows.Forms.TextBox();
            this.todoList = new System.Windows.Forms.TabPage();
            this.checkButton = new System.Windows.Forms.Button();
            this.descriptionTodoListTextBox = new System.Windows.Forms.TextBox();
            this.titleTodoListTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.newTodo.SuspendLayout();
            this.todoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.newTodo);
            this.tabControl.Controls.Add(this.todoList);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 473);
            this.tabControl.TabIndex = 0;
            // 
            // newTodo
            // 
            this.newTodo.Controls.Add(this.create);
            this.newTodo.Controls.Add(this.descriptionNewTodoTextBox);
            this.newTodo.Controls.Add(this.titleNewTodoTextBox);
            this.newTodo.Location = new System.Drawing.Point(4, 22);
            this.newTodo.Name = "newTodo";
            this.newTodo.Padding = new System.Windows.Forms.Padding(3);
            this.newTodo.Size = new System.Drawing.Size(488, 447);
            this.newTodo.TabIndex = 0;
            this.newTodo.Text = "New Todo";
            this.newTodo.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Location = new System.Drawing.Point(405, 375);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.OnClickCreateButton);
            // 
            // descriptionNewTodoTextBox
            // 
            this.descriptionNewTodoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionNewTodoTextBox.Location = new System.Drawing.Point(3, 23);
            this.descriptionNewTodoTextBox.Multiline = true;
            this.descriptionNewTodoTextBox.Name = "descriptionNewTodoTextBox";
            this.descriptionNewTodoTextBox.Size = new System.Drawing.Size(482, 346);
            this.descriptionNewTodoTextBox.TabIndex = 1;
            this.descriptionNewTodoTextBox.Text = "Description...";
            this.descriptionNewTodoTextBox.Click += new System.EventHandler(this.OnClickClearDescriptionTextBox);
            // 
            // titleNewTodoTextBox
            // 
            this.titleNewTodoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleNewTodoTextBox.Location = new System.Drawing.Point(3, 3);
            this.titleNewTodoTextBox.Name = "titleNewTodoTextBox";
            this.titleNewTodoTextBox.Size = new System.Drawing.Size(482, 20);
            this.titleNewTodoTextBox.TabIndex = 0;
            this.titleNewTodoTextBox.Text = "Write a Title...";
            this.titleNewTodoTextBox.Click += new System.EventHandler(this.OnClickClearTitleTextBox);
            // 
            // todoList
            // 
            this.todoList.Controls.Add(this.listBox);
            this.todoList.Controls.Add(this.checkButton);
            this.todoList.Controls.Add(this.descriptionTodoListTextBox);
            this.todoList.Controls.Add(this.titleTodoListTextBox);
            this.todoList.Location = new System.Drawing.Point(4, 22);
            this.todoList.Name = "todoList";
            this.todoList.Padding = new System.Windows.Forms.Padding(3);
            this.todoList.Size = new System.Drawing.Size(488, 447);
            this.todoList.TabIndex = 1;
            this.todoList.Text = "Todo List";
            this.todoList.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.BackColor = System.Drawing.Color.Lime;
            this.checkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkButton.Location = new System.Drawing.Point(132, 421);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(353, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.OnClickCheckButton);
            // 
            // descriptionTodoListTextBox
            // 
            this.descriptionTodoListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTodoListTextBox.Location = new System.Drawing.Point(132, 32);
            this.descriptionTodoListTextBox.Multiline = true;
            this.descriptionTodoListTextBox.Name = "descriptionTodoListTextBox";
            this.descriptionTodoListTextBox.ReadOnly = true;
            this.descriptionTodoListTextBox.Size = new System.Drawing.Size(348, 383);
            this.descriptionTodoListTextBox.TabIndex = 2;
            // 
            // titleTodoListTextBox
            // 
            this.titleTodoListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTodoListTextBox.Location = new System.Drawing.Point(132, 6);
            this.titleTodoListTextBox.Name = "titleTodoListTextBox";
            this.titleTodoListTextBox.ReadOnly = true;
            this.titleTodoListTextBox.Size = new System.Drawing.Size(348, 20);
            this.titleTodoListTextBox.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(3, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 441);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "TodoForm";
            this.Text = "ToDo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodoForm_Closing);
            this.Load += new System.EventHandler(this.TodoForm_Load);
            this.tabControl.ResumeLayout(false);
            this.newTodo.ResumeLayout(false);
            this.newTodo.PerformLayout();
            this.todoList.ResumeLayout(false);
            this.todoList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage todoList;
        private System.Windows.Forms.TabPage newTodo;
        private System.Windows.Forms.TextBox titleNewTodoTextBox;
        private System.Windows.Forms.TextBox descriptionNewTodoTextBox;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox titleTodoListTextBox;
        private System.Windows.Forms.TextBox descriptionTodoListTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.ListBox listBox;
    }
}