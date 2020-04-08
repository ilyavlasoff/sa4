using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sa4
{
    public partial class Form1 : Form
    {
        private int tops = 0, edges = 0;
        public Form1()
        {
            InitializeComponent();
            manual man = new manual();
            man.ShowDialog();
        }

        private void topsCount_ValueChanged(object sender, EventArgs e)
        {
            tops = Int32.Parse(topsCount.Value.ToString());
            if (tops > 0)
            {
                matrixView.RowCount = tops;
                matrixView.ColumnCount = tops;
            }
            else
            {
                MessageBox.Show("Значение должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topsCount.Value = 1;
                return;
            }
            for (int i = 0; i != tops; i++)
            {
                matrixView.Rows[i].HeaderCell.Value = $"{i}";
                matrixView.Columns[i].HeaderCell.Value = $"{i}";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<Dictionary<int, double>> inputValues = new List<Dictionary<int, double>>();
            try
            {
                for (int i = 0; i != tops; ++i)
                {
                    DataGridViewRow curRow = matrixView.Rows[i];
                    Dictionary<int, double> curList = new Dictionary<int, double>();
                    for (int j = 0; j != tops; ++j)
                    {
                        try
                        {
                            double val = Double.Parse(curRow.Cells[j].Value.ToString());
                            if (val != 0.0)
                                curList.Add(j, val);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex.Message}");
                            return;
                        }
                    }
                    inputValues.Add(curList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GraphOperator ge = new GraphOperator(inputValues, tops, edges);
                List<List<double>> res = ge.minimizePaths();
                showMatrix(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка во время расчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showMatrix(List<List<double>> matrix)
        {
            outputView.Rows.Clear();
            outputView.Columns.Clear();
            for (int i = 0; i != tops; i++)
                outputView.Columns.Add(new DataGridViewTextBoxColumn());
            for (int i = 0; i != matrix.Count; ++i)
            {
                DataGridViewRow curRow = new DataGridViewRow();
                for (int j = 0; j != matrix[i].Count; ++j)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = matrix[i][j];
                    curRow.Cells.Add(cell);
                }
                outputView.Rows.Add(curRow);
                outputView.Rows[i].HeaderCell.Value = i.ToString();
                outputView.Columns[i].HeaderCell.Value = i.ToString();
            }
        }

        private void edgesCount_ValueChanged(object sender, EventArgs e)
        {
            int edC = Int32.Parse(edgesCount.Value.ToString());
            if (tops > 0)
            {
                edges = edC;
            }
            else
            {
                MessageBox.Show("Значение должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
