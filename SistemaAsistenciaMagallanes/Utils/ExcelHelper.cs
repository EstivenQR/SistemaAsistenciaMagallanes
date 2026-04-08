using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Utils
{
	public class ExcelHelper
	{
		public void ExportarExcel(DataGridView dgv, int presentes, int ausentes, int tardias, int justificadas)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Excel (*.xlsx)|*.xlsx";
			save.FileName = "Reporte_Asistencia.xlsx";

			if (save.ShowDialog() != DialogResult.OK)
				return;

			using (XLWorkbook wb = new XLWorkbook())
			{
				var ws = wb.Worksheets.Add("Reporte");

				int colIndex = 1;

				// ENCABEZADOS
				foreach (DataGridViewColumn col in dgv.Columns)
				{
					if (col.Name == "IdEstudiante" || !col.Visible)
						continue;

					ws.Cell(7, colIndex).Value = col.HeaderText;
					ws.Cell(7, colIndex).Style.Font.Bold = true;
					ws.Cell(7, colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

					colIndex++;
				}

				// TÍTULO 
				ws.Cell("A1").Value = "REPORTE DE ASISTENCIA";
				ws.Range("A1:E1").Merge();
				ws.Cell("A1").Style.Font.Bold = true;
				ws.Cell("A1").Style.Font.FontSize = 16;
				ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

				int rowIndex = 8;


				//Resumen
				var resumen = ws.Range("A3:B6");
				resumen.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
				resumen.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

				ws.Cell("A3").Value = "Presentes:";
				ws.Cell("B3").Value = presentes;

				ws.Cell("A4").Value = "Ausentes:";
				ws.Cell("B4").Value = ausentes;

				ws.Cell("A5").Value = "Tardías:";
				ws.Cell("B5").Value = tardias;

				ws.Cell("A6").Value = "Justificadas:";
				ws.Cell("B6").Value = justificadas;

				// DATOS
				foreach (DataGridViewRow row in dgv.Rows)
				{
					if (row.IsNewRow) continue;

					colIndex = 1;

					foreach (DataGridViewColumn col in dgv.Columns)
					{
						if (col.Name == "IdEstudiante" || !col.Visible)
							continue;

						ws.Cell(rowIndex, colIndex).Value = row.Cells[col.Name].Value?.ToString();
						ws.Cell(rowIndex, colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

						colIndex++;
					}

					rowIndex++;
				}

				// AUTO AJUSTE
				ws.Columns().AdjustToContents();

				// FECHA
				ws.Cell(rowIndex + 1, 1).Value = "Generado el:";
				ws.Cell(rowIndex + 1, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

				wb.SaveAs(save.FileName);
			}

			MessageBox.Show("Excel generado correctamente");
		}
	}
}
