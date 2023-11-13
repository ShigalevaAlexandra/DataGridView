using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form1 : Form
    {
        int row, columm, i = -1, j = -1;
        string[] objects = new string[10];
        string[] student = new string[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            comBox_objects.Sorted = true;
            comBox_objects.Items.AddRange(new string[] { "Информатика", 
                "Физика", "Логика", "Программирование" });
            comBox_objects.Text = comBox_objects.Items[0].ToString();
            dataGV_table.RowHeadersWidth = 100;
        }

        private void btnAdd_objects_Click(object sender, EventArgs e)
        {
            if (i < row)
            {
                i++;
                objects[i] = comBox_objects.Text;
                dataGV_table.Columns[i].HeaderCell.Value = objects[i];
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd_marks_Click(object sender, EventArgs e)
        {
            row = (int)(numUD_students.Value);
            columm = (int)(numUP_objects.Value);

            dataGV_table.RowCount = row;
            dataGV_table.ColumnCount = columm;
            dataGV_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAdd_fio_Click(object sender, EventArgs e)
        {
            if (j < columm)
            {
                j++;
                //student[j] = txtBox_students.Text;
                dataGV_table.Rows[j].HeaderCell.Value = txtBox_students.Text;
            }
        }

    }
}
