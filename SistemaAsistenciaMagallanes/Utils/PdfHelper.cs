using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Properties;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace SistemaAsistenciaMagallanes.Reportes
{
	public class PdfHelper
	{
			public void GenerarPDF(DataGridView dgv, string porcentaje, string total, string ausencias)
			{
				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "PDF (*.pdf)|*.pdf";
				save.FileName = "Reporte_Asistencia.pdf";

				if (save.ShowDialog() != DialogResult.OK)
					return;

				string ruta = save.FileName;

				PdfWriter writer = new PdfWriter(ruta);
				PdfDocument pdf = new PdfDocument(writer);
				Document doc = new Document(pdf);

			// Título
			PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			doc.Add(new Paragraph("REPORTE DE ASISTENCIA")
				.SetFont(fontBold)
				.SetFontSize(18)
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

			doc.Add(new Paragraph(" "));

				// 📊 Resumen
				doc.Add(new Paragraph($"Porcentaje: {porcentaje}"));
				doc.Add(new Paragraph($"Total Clases: {total}"));
				doc.Add(new Paragraph($"Ausencias: {ausencias}"));

				doc.Add(new Paragraph(" "));

				// 📋 Tabla
				Table tabla = new Table(dgv.Columns.Count);

				foreach (DataGridViewColumn col in dgv.Columns)
				{
					tabla.AddHeaderCell(col.HeaderText);
				}

				foreach (DataGridViewRow row in dgv.Rows)
				{
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							tabla.AddCell(cell.Value?.ToString() ?? "");
						}
					}
				}

				doc.Add(tabla);
				doc.Close();

				MessageBox.Show("PDF generado correctamente");
			}
		}
	}
