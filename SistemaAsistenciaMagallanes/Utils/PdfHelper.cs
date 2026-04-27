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
using iText.Layout.Borders;
using iText.Layout.Properties;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;

namespace SistemaAsistenciaMagallanes.Reportes
{
	public class PdfHelper
	{
		public void GenerarPDF(DataGridView dgv,
								DataTable dtTareas,
								string presentes,
								string ausencias,
								string tardias,
								string justificadas,
								string estudiante = null,
								string seccion = null)
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


			doc.Add(new Paragraph("\nGenerado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
				.SetTextAlignment(TextAlignment.RIGHT)
				.SetFontSize(9));


			// Título
			PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			doc.Add(new Paragraph("REPORTE DE ASISTENCIA")
				.SetFont(fontBold)
				.SetFontSize(18)
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

			doc.Add(new Paragraph(" "));

			// SOLO SI HAY FILTRO
			if (!string.IsNullOrEmpty(estudiante) || !string.IsNullOrEmpty(seccion))
			{
				Paragraph info = new Paragraph()
					.SetTextAlignment(TextAlignment.CENTER)
					.SetFontSize(18)
					.SetFont(fontBold);

				if (!string.IsNullOrEmpty(estudiante))
					info.Add(estudiante + "\n");

				if (!string.IsNullOrEmpty(seccion) || seccion == "-- Seleccione una sección --")
					info.Add(seccion + "\n");

				doc.Add(info);
				doc.Add(new Paragraph("\n"));
			}

			// Resumen
			Table resumen = new Table(4);
			resumen.SetWidth(UnitValue.CreatePercentValue(100));

			// Presentes
			resumen.AddCell(new Cell()
				.Add(new Paragraph("Presentes\n" + presentes))
				.SetTextAlignment(TextAlignment.CENTER)
				.SetBackgroundColor(new DeviceRgb(76, 175, 80))
				.SetFontColor(ColorConstants.WHITE)
				.SetBorder(new SolidBorder(ColorConstants.WHITE, 5))
				.SetPadding(10));

			// Tardías
			resumen.AddCell(new Cell()
				.Add(new Paragraph("Tardías\n" + tardias))
				.SetTextAlignment(TextAlignment.CENTER)
				.SetBackgroundColor(ColorConstants.ORANGE)
				.SetFontColor(ColorConstants.WHITE)
				.SetBorder(new SolidBorder(ColorConstants.WHITE, 5))
				.SetPadding(10));

			// Ausencias
			resumen.AddCell(new Cell()
				.Add(new Paragraph("Ausentes\n" + ausencias))
				.SetTextAlignment(TextAlignment.CENTER)
				.SetBackgroundColor(ColorConstants.RED)
				.SetFontColor(ColorConstants.WHITE)
				.SetBorder(new SolidBorder(ColorConstants.WHITE, 5))
				.SetPadding(10));

			// Justificadas
			resumen.AddCell(new Cell()
				.Add(new Paragraph("Justificadas\n" + justificadas))
				.SetTextAlignment(TextAlignment.CENTER)
				.SetBackgroundColor(ColorConstants.BLUE)
				.SetFontColor(ColorConstants.WHITE)
				.SetBorder(new SolidBorder(ColorConstants.WHITE, 5))
				.SetPadding(10));

			doc.Add(new Paragraph("\n"));
			doc.Add(resumen);
			doc.Add(new Paragraph("\n"));

			// CONTAR COLUMNAS VISIBLES (CORREGIDO)
			int columnasVisibles = dgv.Columns
					.Cast<DataGridViewColumn>()
					.Count(c => c.Visible && c.Name != "IdEstudiante");

			Table tabla = new Table(columnasVisibles);
			tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

			// HEADERS 
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				if (col.Name == "IdEstudiante")
					continue;

				if (!col.Visible)
					continue;

				Cell headerCell = new Cell()
					.Add(new Paragraph(col.HeaderText))
					.SetBackgroundColor(ColorConstants.LIGHT_GRAY)
					.SetTextAlignment(TextAlignment.CENTER);

				tabla.AddCell(headerCell);
			}

			// FILAS 
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

						string valor = row.Cells[col.Name].Value?.ToString() ?? "";

						Color color = ColorConstants.BLACK;



						if (col.Name == "Estado")
						{
							if (valor == "Ausente")
								color = ColorConstants.RED;
							else if (valor == "Tardía")
								color = ColorConstants.ORANGE;
							else if (valor == "Presente")
								color = ColorConstants.GREEN;
						}

						tabla.AddCell(new Cell()
							.Add(new Paragraph(valor))
							.SetTextAlignment(TextAlignment.CENTER)
							.SetFontColor(color));


					}
				}
			}

			doc.Add(tabla);
			doc.Add(new Paragraph("\n\n")); // espacio

			// TÍTULO
			doc.Add(new Paragraph("REPORTE DE TAREAS")
				.SetFont(fontBold)
				.SetFontSize(16)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(new Paragraph("\n"));

			// TABLA
			Table tablaTareas = new Table(dtTareas.Columns.Count);
			tablaTareas.SetWidth(UnitValue.CreatePercentValue(100));

			// HEADERS
			foreach (DataColumn col in dtTareas.Columns)
			{
				tablaTareas.AddCell(new Cell()
					.Add(new Paragraph(col.ColumnName))
					.SetBackgroundColor(ColorConstants.LIGHT_GRAY)
					.SetTextAlignment(TextAlignment.CENTER));
			}

			foreach (DataRow row in dtTareas.Rows)
			{
				foreach (DataColumn col in dtTareas.Columns)
				{
					string nombreCol = col.ColumnName.Trim().ToLower();
					string valor = "";
					Color color = ColorConstants.BLACK;


					if (nombreCol == "nota")
					{
						if (row[col] != DBNull.Value)
						{
							decimal nota = Convert.ToDecimal(row[col]);
							valor = nota.ToString("0") + "%";


							if (nota >= 3)
								color = ColorConstants.GREEN;
							else
								color = ColorConstants.RED;
						}
					}
					else
					{
						valor = row[col]?.ToString() ?? "";
					}

					tablaTareas.AddCell(new Cell()
						.Add(new Paragraph(valor))
						.SetTextAlignment(TextAlignment.CENTER)
						.SetFontColor(color));
				}
			}

			doc.Add(tablaTareas);
			doc.Add(new Paragraph("\n"));

			Table firmas = new Table(2);
			firmas.SetWidth(UnitValue.CreatePercentValue(100));

			firmas.AddCell(new Cell()
				.Add(new Paragraph("\n\n________________________\nDocente"))
				.SetBorder(Border.NO_BORDER)
				.SetTextAlignment(TextAlignment.CENTER));

			firmas.AddCell(new Cell()
				.Add(new Paragraph("\n\n________________________\nDirector"))
				.SetBorder(Border.NO_BORDER)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(firmas);
			doc.Close();

			MessageBox.Show("PDF generado correctamente");
		}

		public void GenerarReporteBoletas(DataTable dt)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "PDF (*.pdf)|*.pdf";
			save.FileName = "Reporte_Boletas.pdf";

			if (save.ShowDialog() != DialogResult.OK)
				return;

			string ruta = save.FileName;

			PdfWriter writer = new PdfWriter(ruta);
			PdfDocument pdf = new PdfDocument(writer);
			Document doc = new Document(pdf);

			PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			// TÍTULO
			doc.Add(new Paragraph("REPORTE DE AMONESTACIONES")
				.SetFont(fontBold)
				.SetFontSize(18)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(new Paragraph("\n"));

			// TABLA
			List<string> columnasExcluir = new List<string>
				{
					"IdBoleta",
					"IdEstudiante",
					"IdSeccion"
				};

			var columnasVisibles = dt.Columns
				.Cast<DataColumn>()
				.Where(c => !columnasExcluir.Contains(c.ColumnName))
				.ToList();

			Table tabla = new Table(columnasVisibles.Count);
			tabla.SetWidth(UnitValue.CreatePercentValue(100));

			// HEADERS
			foreach (DataColumn col in columnasVisibles)
			{
				tabla.AddCell(new Cell()
					.Add(new Paragraph(col.ColumnName))
					.SetBackgroundColor(ColorConstants.LIGHT_GRAY)
					.SetTextAlignment(TextAlignment.CENTER));
			}

			// FILAS
			foreach (DataRow row in dt.Rows)
			{
				foreach (DataColumn col in columnasVisibles)
				{

					string valor = "";

					if (col.ColumnName == "Fecha" && row[col] != DBNull.Value)
					{
						valor = Convert.ToDateTime(row[col]).ToString("dd/MM/yyyy");
					}
					else
					{
						valor = row[col]?.ToString() ?? "";
					}
					tabla.AddCell(new Cell()
						.Add(new Paragraph(row[col]?.ToString() ?? ""))
						.SetTextAlignment(TextAlignment.CENTER));
				}
			}

			doc.Add(tabla);
			doc.Close();

			MessageBox.Show("Reporte generado correctamente");
		}

		public void GenerarBoletaPDF(DataRow boleta)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "PDF (*.pdf)|*.pdf";
			save.FileName = "Boleta.pdf";

			if (save.ShowDialog() != DialogResult.OK)
				return;

			string ruta = save.FileName;

			PdfWriter writer = new PdfWriter(ruta);
			PdfDocument pdf = new PdfDocument(writer);
			Document doc = new Document(pdf);

			// ENCABEZADO 
			byte[] imagenBytes;
			using (MemoryStream ms = new MemoryStream())
			{
				Properties.Resources.Encabezado.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				imagenBytes = ms.ToArray();
			}

			float ancho = pdf.GetDefaultPageSize().GetWidth();
			float alto = pdf.GetDefaultPageSize().GetHeight();

			Image img = new Image(ImageDataFactory.Create(imagenBytes));
			img.ScaleToFit(ancho, 100);
			img.SetFixedPosition(2, alto - 100);

			doc.Add(img);
			doc.Add(new Paragraph("\n\n\n\n"));

			// FUENTE
			PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			// TÍTULO
			doc.Add(new Paragraph("BOLETA DE AMONESTACIÓN")
				.SetFont(bold)
				.SetFontSize(18)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(new Paragraph("\n"));

			// DATOS
			doc.Add(new Paragraph($"Estudiante: {boleta["Estudiante"]}").SetFontSize(12));
			doc.Add(new Paragraph($"Sección: {boleta["Seccion"]}").SetFontSize(12));
			doc.Add(new Paragraph($"Fecha: {Convert.ToDateTime(boleta["Fecha"]).ToShortDateString()}").SetFontSize(12));

			doc.Add(new Paragraph("\n"));

			// MOTIVO
			doc.Add(new Paragraph("Motivo:")
				.SetFont(bold)
				.SetFontSize(12));

			doc.Add(new Paragraph(boleta["Motivo"].ToString())
				.SetFontSize(11)
				.SetMarginBottom(10));

			// PORCENTAJE
			doc.Add(new Paragraph($"Porcentaje de afectación: {boleta["Puntos"]}%")
				.SetFont(bold));

			doc.Add(new Paragraph("\n\n"));

			// FIRMAS
			Table firmas = new Table(2);
			firmas.SetWidth(UnitValue.CreatePercentValue(100));

			firmas.AddCell(new Cell()
				.Add(new Paragraph("\n\n________________________\nDocente"))
				.SetBorder(Border.NO_BORDER)
				.SetTextAlignment(TextAlignment.CENTER));

			firmas.AddCell(new Cell()
				.Add(new Paragraph("\n\n________________________\nDirector"))
				.SetBorder(Border.NO_BORDER)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(firmas);

			doc.Close();

			MessageBox.Show("Boleta generada correctamente");
		}

		public void GenerarReporteBoletasFiltros(DataTable dt, string seccion = "", string estudiante = "")
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "PDF (*.pdf)|*.pdf";
			save.FileName = "Reporte_Boletas.pdf";

			if (save.ShowDialog() != DialogResult.OK)
				return;

			PdfWriter writer = new PdfWriter(save.FileName);
			PdfDocument pdf = new PdfDocument(writer);
			Document doc = new Document(pdf);

			// ENCABEZADO 
			byte[] imagenBytes;
			using (MemoryStream ms = new MemoryStream())
			{
				Properties.Resources.Encabezado.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				imagenBytes = ms.ToArray();
			}

			float ancho = pdf.GetDefaultPageSize().GetWidth();
			float alto = pdf.GetDefaultPageSize().GetHeight();

			Image img = new Image(ImageDataFactory.Create(imagenBytes));
			img.ScaleToFit(ancho, 100);
			img.SetFixedPosition(2, alto - 100);

			doc.Add(img);
			doc.Add(new Paragraph("\n\n\n\n"));

			// FUENTE
			PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			// TÍTULO
			doc.Add(new Paragraph("REPORTE DE AMONESTACIONES")
				.SetFont(bold)
				.SetFontSize(18)
				.SetTextAlignment(TextAlignment.CENTER));

			doc.Add(new Paragraph("\n"));

			// FILTROS VISUALES
			if (!string.IsNullOrEmpty(estudiante) || !string.IsNullOrEmpty(seccion))
			{
				doc.Add(new Paragraph($"Estudiante: {estudiante}\nSección: {seccion}")
					.SetTextAlignment(TextAlignment.CENTER));
				doc.Add(new Paragraph("\n"));
			}

			// RESUMEN
			int total = dt.Rows.Count;
			double promedio = dt.AsEnumerable().Any()
				? dt.AsEnumerable().Average(r => Convert.ToDouble(r["Puntos"]))
				: 0;

			doc.Add(new Paragraph($"Total boletas: {total}"));
			doc.Add(new Paragraph($"Promedio afectación: {promedio:F2}%"));

			doc.Add(new Paragraph("\n"));

			// TABLA
			List<string> columnasExcluir = new List<string>
			{
				"IdBoleta",
				"IdEstudiante",
				"IdSeccion"
			};

			var columnasVisibles = dt.Columns
				.Cast<DataColumn>()
				.Where(c => !columnasExcluir.Contains(c.ColumnName))
				.ToList();

			Table tabla = new Table(columnasVisibles.Count);
			tabla.SetWidth(UnitValue.CreatePercentValue(100));

			// HEADERS
			foreach (DataColumn col in columnasVisibles)
			{
				tabla.AddCell(new Cell()
					.Add(new Paragraph(col.ColumnName))
					.SetBackgroundColor(ColorConstants.LIGHT_GRAY)
					.SetTextAlignment(TextAlignment.CENTER));
			}

			// FILAS
			foreach (DataRow row in dt.Rows)
			{
				foreach (DataColumn col in columnasVisibles)
				{
					string valor = "";

					if (col.ColumnName == "Fecha" && row[col] != DBNull.Value)
					{
						valor = Convert.ToDateTime(row[col]).ToString("dd/MM/yyyy");
					}
					else
					{
						valor = row[col]?.ToString() ?? "";
					}
					
					Color color = ColorConstants.BLACK;

					//  COLOR POR PORCENTAJE
					if (col.ColumnName == "Puntos")
					{
						int p = Convert.ToInt32(row[col]);
						color = ColorConstants.BLACK;
					}

					tabla.AddCell(new Cell()
						.Add(new Paragraph(valor))
						.SetFontColor(color)
						.SetTextAlignment(TextAlignment.CENTER));
				}
			}

			doc.Add(tabla);

			doc.Close();

			MessageBox.Show("Reporte generado correctamente");
		}

	}

	
}

