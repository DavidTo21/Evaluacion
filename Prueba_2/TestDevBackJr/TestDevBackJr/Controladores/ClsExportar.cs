using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestDevBackJr.Controladores
{
    public class ClsExportar
    {
        public bool Export(DataGridView dgv)
        {
            bool exported = false;

            List<string> lines = new List<string>();
            //header
            DataGridViewColumnCollection header = dgv.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();
            foreach(DataGridViewColumn col in header)
            {
                if (!firstDone)
                {
                    headerLine.Append(col.DataPropertyName);
                    firstDone = true;
                }
                else{
                    headerLine.Append("," + col.DataPropertyName);
                }
            }
            lines.Add(headerLine.ToString());
            foreach(DataGridViewRow row in dgv.Rows)
            {
                StringBuilder dataline = new StringBuilder();
                firstDone = false;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataline.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataline.Append("," + cell.Value);
                    }
                }
                lines.Add(dataline.ToString());
            }

            string file = @"C:\\Users\\Programación\\Desktop\\listadoUsuarios.csv";
            System.IO.File.WriteAllLines(file, lines);
            System.Diagnostics.Process.Start(file);

            return exported;
        }
    }
}
