using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMatrix_A.RowCount = (int)numericUpDownRows.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(
                "Неправильное количество строк!",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                numericUpDownRows.Value = 1;
            }
        }
        private void numericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewMatrix_A.ColumnCount = (int)numericUpDownColumns.Value;
        }
        private void numericUpDownRows_1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMatrix_B.RowCount = (int)numericUpDownRows_1.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(
                "Неправильное количество строк!",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                numericUpDownRows_1.Value = 1;
            }
        }

        private void numericUpDownColumns_1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewMatrix_B.ColumnCount = (int)numericUpDownColumns_1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_A.RowHeadersVisible = false;
            dataGridViewMatrix_A.ColumnHeadersVisible = false;
            dataGridViewMatrix_A.RowCount = (int)numericUpDownRows.Value;
            dataGridViewMatrix_A.ColumnCount = (int)numericUpDownColumns.Value;
            dataGridViewMatrix_A.AllowUserToAddRows = false;
            dataGridViewMatrix_B.RowHeadersVisible = false;
            dataGridViewMatrix_B.ColumnHeadersVisible = false;
            dataGridViewMatrix_B.RowCount = (int)numericUpDownRows_1.Value;
            dataGridViewMatrix_B.ColumnCount = (int)numericUpDownColumns_1.Value;
            dataGridViewMatrix_B.AllowUserToAddRows = false;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            double rows = dataGridViewMatrix_A.RowCount, column = dataGridViewMatrix_A.ColumnCount;
            object[,] matrixA = new object[(int)rows, (int)column];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = dataGridViewMatrix_A[i, j].Value;
                }
            }

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    dataGridViewMatrix_B[i, j].Value = dataGridViewMatrix_A[i, j].Value;
                }
            }

        }
    }
}
