using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Properties;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;

namespace SistemaAsistenciaMagallanes.Reportes
{
	public class PdfHelper
	{
		public void GenerarPDF(DataGridView dgv, string presentes, string ausencias,string tardias, string justificadas)
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

			byte[] imagenBytes;

			using (MemoryStream ms = new MemoryStream())
			{
				Properties.Resources.Encabezado.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				imagenBytes = ms.ToArray();
			}

			float anchoPagina = pdf.GetDefaultPageSize().GetWidth();
			float altoPagina = pdf.GetDefaultPageSize().GetHeight();

			Image encabezado = new Image(ImageDataFactory.Create(imagenBytes));

			encabezado.ScaleToFit(anchoPagina, 100);

			// posición absoluta (x, y)
			encabezado.SetFixedPosition(2, altoPagina - 100);

			doc.Add(encabezado);
			doc.Add(new Paragraph("\n\n\n\n"));


			doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"))
			.SetTextAlignment(TextAlignment.RIGHT)
			.SetFontSize(9));


			// Título
			PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

				doc.Add(new Paragraph("REPORTE DE ASISTENCIA")
					.SetFont(fontBold)
					.SetFontSize(18)
					.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

				doc.Add(new Paragraph(" "));

				// Resumen
				doc.Add(new Paragraph($"Total Presentes: {presentes}").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
			doc.Add(new Paragraph($"Tardias: {tardias}").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
			doc.Add(new Paragraph($"Ausencias: {ausencias}").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
				doc.Add(new Paragraph($"Justificadas: {justificadas}").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

				doc.Add(new Paragraph(" "));

				// CONTAR COLUMNAS VISIBLES (CORREGIDO)
				int columnasVisibles = dgv.Columns
					.Cast<DataGridViewColumn>()
					.Count(c => c.Visible && c.Name != "IdEstudiante");

				Table tabla = new Table(columnasVisibles);

				// HEADERS 
				foreach (DataGridViewColumn col in dgv.Columns)
				{
					if (col.Name == "IdEstudiante")
						continue;

					if (!col.Visible)
						continue;
					
				Cell cell = new Cell()
				.Add(new Paragraph(col.HeaderText))
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

				tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
				tabla.AddCell(cell);
			}

				// FILAS (CORREGIDO)
				foreach (DataGridViewRow row in dgv.Rows)
				{
					if (!row.IsNewRow)
					{
						foreach (DataGridViewColumn col in dgv.Columns)
						{
							if (col.Name == "IdEstudiante")
								continue;

							if (!col.Visible)
								continue;

							tabla.AddCell(row.Cells[col.Name].Value?.ToString() ?? "");
						}
					}
				}

				doc.Add(tabla);
			doc.Add(new Paragraph("\n\n")); // espacio

			doc.Add(new Paragraph("______________________________")
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(new Paragraph("Firma del docente")
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(10));
			doc.Close();

				MessageBox.Show("PDF generado correctamente");
			}

		}
	}
