using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa4
{
    class GraphOperator
    {
        private  List<List<double>> graphMatrix = new List<List<double>>();
        int topsCount, edgesCount;
        public GraphOperator(List<Dictionary<int, double>> _params, int _topsCount, int _edgesCount)
        {
            int rowCount = 0;
            topsCount = _topsCount;
            edgesCount = _edgesCount;
            for(int i=0; i!=_params.Count; ++i)
            {
                foreach(KeyValuePair<int, double> item in _params[i])
                {
                    List<double> row = new List<double>(topsCount + edgesCount + 1);
                    for (int j = 0; j != topsCount + edgesCount + 1; ++j) row.Add(0);
                    row[0] = item.Value;
                    row[item.Key + 1] = 1;
                    row[i + 1] = -1;
                    row[topsCount + rowCount + 1] = 1;
                    graphMatrix.Add(row);
                    rowCount++;
                }
            }
        }

        public List<List<double>> minimizePaths()
        {
            List<List<double>> pathMatrix = new List<List<double>>();
            for (int i=0; i!= topsCount; ++i)
            {
                List<double> row = new List<double>();
                for (int j=0; j!= topsCount; ++j)
                {
                    if (i == j)
                        row.Add(0);
                    else
                    {
                        try
                        {
                            row.Add(simplexMethod(i, j));
                        }
                        catch(Exception ex)
                        { 
                            row.Add(-1);
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                pathMatrix.Add(row);
            }
            return pathMatrix;
        }

        private double simplexMethod(int from, int to)
        {
            List<List<double>> simplexMatrix = new List<List<double>>();
            for(int i=0; i!= graphMatrix.Count; ++i)
            {
                simplexMatrix.Add(new List<double>(graphMatrix[i]));
            }
            List<double> funcRow = new List<double>();
            for (int i = 0; i != topsCount + edgesCount + 1; ++i) funcRow.Add(0);
            funcRow[to + 1] = -1;
            funcRow[from + 1] = 1;
            simplexMatrix.Add(funcRow); 
            while (simplexMatrix[simplexMatrix.Count-1].Any((item) => item < 0))
            {
                int leadCol = simplexMatrix[simplexMatrix.Count - 1].IndexOf(simplexMatrix[simplexMatrix.Count - 1].Min());
                List<double> dividedList = new List<double>();
                for(int i=0; i!= edgesCount; ++i)
                {
                    if (simplexMatrix[i][0] < 0 || simplexMatrix[i][leadCol] <= 0)
                        dividedList.Add(double.MaxValue);
                    else
                        dividedList.Add(simplexMatrix[i][0] / simplexMatrix[i][leadCol]);
                }
                if (dividedList.All((val) => val == Double.MaxValue)) return 0;
                int leadRow = dividedList.IndexOf(dividedList.Min());
                recalculateMatrix(simplexMatrix, leadCol, leadRow);
            }
            return simplexMatrix[simplexMatrix.Count - 1][0];
        }

        private List<List<double>> recalculateMatrix(List<List<double>> simplexMatrix, int col, int row)
        {
            List<double> leadRow = simplexMatrix[row];
            double leadElement = leadRow[col];
            for (int i=0; i!= leadRow.Count; ++i)
            {
                leadRow[i] /= leadElement;
            }
            for (int i=0; i!= simplexMatrix.Count; ++i)
            {
                if (i == row) continue;
                double mpl = simplexMatrix[i][col];
                for (int j=0; j!= simplexMatrix[i].Count; ++j)
                {
                    simplexMatrix[i][j] -= mpl * leadRow[j];
                }
            }
            return simplexMatrix;
        }
    }
}
