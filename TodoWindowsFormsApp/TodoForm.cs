using FileManager;
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

namespace TodoWindowsFormsApp
{
    public partial class TodoForm : Form
    {
        List<Todo> _todos;
        private string path = Environment.CurrentDirectory;
        private ExcelFileManager<Todo> excelFileManager;

        public TodoForm()
        {
            InitializeComponent();
        }

        private void TodoForm_Load(object sender, EventArgs e)
        {
            excelFileManager = new ExcelFileManager<Todo>(path, "Todos", "Todos");

            _todos = excelFileManager.ReadDataFromExcel();

            InitTextBox();
            UpdateListBox();
        }

        private void TodoForm_Closing(object sender, FormClosingEventArgs e)
        {
            excelFileManager.DeleteExcelFile();
            excelFileManager.WriteDataToExcel(_todos);
        }

        private void OnClickClearTitleTextBox(object sender, EventArgs e)
        {
            titleNewTodoTextBox.Text = string.Empty;
        }

        private void OnClickClearDescriptionTextBox(object sender, EventArgs e)
        {
            descriptionNewTodoTextBox.Text = string.Empty;
        }

        private void OnClickCreateButton(object sender, EventArgs e)
        {
            Todo todo = new Todo();

            string title = titleNewTodoTextBox.Text;
            string description = descriptionNewTodoTextBox.Text;

            todo.Title = title;
            todo.Description = description;

            if (_todos.Any(t => t.Title == todo.Title))
            {
                MessageBox.Show($"{todo.Title} already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _todos.Add(todo);

            InitTextBox();

            MessageBox.Show($"{todo.Title} Created.", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateListBox();
        }

        private void InitTextBox()
        {
            titleNewTodoTextBox.Text = "Write a Title...";
            descriptionNewTodoTextBox.Text = "Write a Title...";
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Todo todo = _todos.FirstOrDefault(t => t.Title == listBox.SelectedItem.ToString());

            if (todo == null)
                return;

            titleTodoListTextBox.Text = todo.Title;
            descriptionTodoListTextBox.Text = todo.Description;
        }

        private void OnClickCheckButton(object sender, EventArgs e)
        {
            Todo todo = _todos.FirstOrDefault(t => t.Title == listBox.SelectedItem.ToString());
            _todos.Remove(todo);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox.Items.Clear();

            foreach (Todo todo in _todos)
            {
                listBox.Items.Add(todo.Title);
            }
        }
    }
}
