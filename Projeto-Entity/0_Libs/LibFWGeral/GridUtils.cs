using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFWGeral
{
    public class GridUtils
    {
        public static void ConfigCols(string[] titulos,
            string[] formatos, string[] align, DataGridView grd)
        {
            // percorrer as colunas do grid
            for (int c = 0; c < grd.Columns.Count; c++)
            {
                grd.Columns[c].HeaderText = titulos[c];
                grd.Columns[c].DefaultCellStyle.Format = formatos[c];

                if (align[c] == "^")
                {
                    // alinha os dados
                    grd.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleCenter;
                    // alinha o título da coluna
                    grd.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleCenter;
                }
                else if (align[c] == "<")
                {
                    // alinha os dados
                    grd.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleLeft;
                    // alinha o título da coluna
                    grd.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleLeft;
                }
                else if (align[c] == ">")
                {
                    // alinha os dados
                    grd.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleRight;
                    // alinha o título da coluna
                    grd.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleRight;
                }

            }
        }
    }
}
