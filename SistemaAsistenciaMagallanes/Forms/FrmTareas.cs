using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Models;
using SistemaAsistenciaMagallanes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmTareas : Form
	{

		int idTareaSeleccionada = 0;
		public FrmTareas()
		{
			InitializeComponent();
		}

		private void FrmTareas_Load(object sender, EventArgs e)
		{
			ConfigurarTablaTareas();
			CargarSecciones();
			RedondearBoton(btnCrearTarea, 20);


		}

		private void CargarSecciones()
		{
			TareasService service = new TareasService();

			DataTable dt = service.ObtenerSecciones(Sesion.IdUsuario);

			// agregar opción
			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Seleccione una Sección --";
			dt.Rows.InsertAt(fila, 0);

			cmbSeccion.DataSource = dt;
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";
			cmbSeccion.SelectedIndex = 0;

			// FORZAR CARGA
			if (cmbSeccion.Items.Count > 0)
			{
				cmbSeccion.SelectedIndex = 0;

				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
				CargarMaterias(idSeccion);
			}

		}

		private void RedondearBoton(Button btn, int radio)
		{
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();

			path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
			path.AddArc(new Rectangle(btn.Width - radio, 0, radio, radio), 270, 90);
			path.AddArc(new Rectangle(btn.Width - radio, btn.Height - radio, radio, radio), 0, 90);
			path.AddArc(new Rectangle(0, btn.Height - radio, radio, radio), 90, 90);

			path.CloseFigure();

			btn.Region = new Region(path);
		}

		private void CargarMaterias(int idSeccion)
		{

			TareasService service = new TareasService();

			DataTable dt = service.ObtenerMaterias(Sesion.IdUsuario, idSeccion);

			// agregar opción
			DataRow fila = dt.NewRow();
			fila["IdMateria"] = 0;
			fila["NombreMateria"] = "-- Seleccione una Materia --";
			dt.Rows.InsertAt(fila, 0);

			cmbMateria.DataSource = dt;
			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdMateria";
			cmbMateria.SelectedIndex = 0;

			// FORZAR
			if (cmbMateria.Items.Count > 0)
			{
				cmbMateria.SelectedIndex = 0;

				int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);
				CargarTareas(idSeccion, idMateria);
			}
		}

		private void CargarTareas(int idSeccion, int idMateria, bool mostrarMensaje = false)
		{
			TareasService service = new TareasService();

			DataTable dt = service.ObtenerTareas(
				Sesion.IdUsuario,
				idSeccion,
				idMateria
			);

			bool sinDatos = dt.Rows.Count == 0;

			
			DataRow fila = dt.NewRow();
			fila["IdTarea"] = 0;
			fila["Titulo"] = "-- Seleccione una tarea --";
			dt.Rows.InsertAt(fila, 0);

			cmbTarea.DataSource = dt;
			cmbTarea.DisplayMember = "Titulo";
			cmbTarea.ValueMember = "IdTarea";
			cmbTarea.SelectedIndex = 0;

		
			if (sinDatos && mostrarMensaje)
			{
				MessageBox.Show("No hay tareas para esta materia");
			}
		}


		private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvTareas_SelectionChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			if (idSeccion == 0) return;

			TareasService service = new TareasService();

			// Cargar estudiantes 
			dgvTareas.DataSource = service.ObtenerEstudiantes(idSeccion);

			// Limpiar tareas
			cmbTarea.DataSource = null;

			// Cargar materias
			CargarMaterias(idSeccion);
		}

		private void ConfigurarTablaTareas()
		{
			dgvTareas.AutoGenerateColumns = false;
			dgvTareas.Columns.Clear();

			// ID oculto
			var id = new DataGridViewTextBoxColumn();
			id.Name = "IdEstudiante";
			id.DataPropertyName = "IdEstudiante";
			id.Visible = false;
			dgvTareas.Columns.Add(id);

			// Nombre
			var nombre = new DataGridViewTextBoxColumn();
			nombre.Name = "Estudiante";
			nombre.HeaderText = "Estudiante";
			nombre.DataPropertyName = "Estudiante";
			dgvTareas.Columns.Add(nombre);

			// Checkbox
			var chk = new DataGridViewCheckBoxColumn();
			chk.Name = "Entregado";
			chk.HeaderText = "Entregó";
			dgvTareas.Columns.Add(chk);

			// Porcentaje
			var txt = new DataGridViewTextBoxColumn();
			txt.Name = "Porcentaje";
			txt.HeaderText = "%";
			dgvTareas.Columns.Add(txt);
		}

		private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbMateria_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
			int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

			TareasService service = new TareasService();

			dgvTareas.DataSource = service.ObtenerEstudiantes(idSeccion);
		
			CargarTareas(idSeccion, idMateria);
		}

		private void cmbTarea_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cmbTarea.SelectedValue == null) return;

			int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);

			if (idTarea == 0) return;

			try
			{
				TareasService service = new TareasService();
				DataRow tarea = service.ObtenerTareaPorId(idTarea);

				if (tarea != null)
				{
					txtTitulo.Text = tarea["Titulo"].ToString();
					txtDescripcion.Text = tarea["Descripcion"].ToString();
					dtpFechaEntrega.Value = Convert.ToDateTime(tarea["FechaEntrega"]);

					cmbSeccion.SelectedValue = tarea["IdSeccion"];
					cmbMateria.SelectedValue = tarea["IdMateria"];
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dgvTareas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			if (dgvTareas.Columns[e.ColumnIndex].Name == "Entregado")
			{
				bool entregado = Convert.ToBoolean(
					dgvTareas.Rows[e.RowIndex].Cells["Entregado"].Value ?? false
				);

				var fila = dgvTareas.Rows[e.RowIndex];

				if (entregado)
				{
					fila.Cells["Porcentaje"].Value = 5;
					fila.DefaultCellStyle.BackColor = Color.LightGreen;
				}
				else
				{
					fila.Cells["Porcentaje"].Value = 0;
					fila.DefaultCellStyle.BackColor = Color.LightCoral;
				}
			}
		}

		private void btnCrearTarea_Click(object sender, EventArgs e)
		{
			try
			{
				int idDocente = Sesion.IdUsuario;
				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
				int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

				string titulo = txtTitulo.Text.Trim();
				string descripcion = txtDescripcion.Text.Trim();
				DateTime fechaEntrega = dtpFechaEntrega.Value;

				//Validaciones
				if (idSeccion == 0 || idMateria == 0 || string.IsNullOrWhiteSpace(titulo))
				{
					MessageBox.Show("Complete todos los campos obligatorios");
					return;
				}

				// Validar fecha 
				if (fechaEntrega < DateTime.Now.Date)
				{
					MessageBox.Show("La fecha de entrega no puede ser pasada");
					return;
				}

				TareasService service = new TareasService();
				service.CrearTarea(idDocente, idSeccion, idMateria, titulo, descripcion, fechaEntrega);

				MessageBox.Show("Tarea creada correctamente");

				LimpiarFormulario();
			}
			catch (FormatException)
			{
				MessageBox.Show("Error en los datos seleccionados (sección o materia)");
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error de base de datos: " + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error inesperado: " + ex.Message);
			}
		}

		private void LimpiarFormulario()
		{
			txtTitulo.Clear();
			txtDescripcion.Clear();
			dtpFechaEntrega.Value = DateTime.Now;
			cmbSeccion.SelectedIndex = 0;
		}

		private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			try
			{
				int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);

				if (idTarea == 0)
				{
					MessageBox.Show("Seleccione una tarea");
					return;
				}

				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
				int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

				string titulo = txtTitulo.Text.Trim();
				string descripcion = txtDescripcion.Text.Trim();
				DateTime fechaEntrega = dtpFechaEntrega.Value;

				TareasService service = new TareasService();
				service.ActualizarTarea(idTarea, idSeccion, idMateria, titulo, descripcion, fechaEntrega);

				MessageBox.Show("Tarea actualizada");

				CargarTareas(idSeccion, idMateria);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);

			if (idTarea == 0)
			{
				MessageBox.Show("Seleccione una tarea");
				return;
			}

			var confirm = MessageBox.Show("¿Eliminar esta tarea?", "Confirmar", MessageBoxButtons.YesNo);

			if (confirm == DialogResult.Yes)
			{
				try
				{
					TareasService service = new TareasService();
					service.EliminarTarea(idTarea);

					MessageBox.Show("Tarea eliminada");

					int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
					int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

					CargarTareas(idSeccion, idMateria); // refresca combo
					LimpiarFormulario();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

		private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);

				if (idTarea == 0)
				{
					MessageBox.Show("Seleccione una tarea");
					return;
				}

				TareasService service = new TareasService();

				bool todosCalificados = true; // bandera

				foreach (DataGridViewRow fila in dgvTareas.Rows)
				{
					if (fila.IsNewRow) continue;

					int idEstudiante = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);

					bool entregado = Convert.ToBoolean(
						fila.Cells["Entregado"].Value ?? false
					);

					decimal porcentaje = Convert.ToDecimal(
						fila.Cells["Porcentaje"].Value ?? 0
					);

					//validar si falta calificar
					if (porcentaje == 0)
					{
						todosCalificados = false;
					}

					service.GuardarEntrega(
						idTarea,
						idEstudiante,
						entregado,
						porcentaje,
						Sesion.IdUsuario
					);
				}

				// FINALIZAR TAREA SI TODOS TIENEN NOTA
				if (todosCalificados)
				{
					service.FinalizarTarea(idTarea);
					MessageBox.Show("Tarea finalizada correctamente ");
				}
				else
				{
					MessageBox.Show("Entregas guardadas correctamente (tarea aún pendiente)");
				}

				// recargar combo para que desaparezca si se finalizó
				CargarTareas(
					Convert.ToInt32(cmbSeccion.SelectedValue),
					Convert.ToInt32(cmbMateria.SelectedValue)
				);
				dgvTareas.DataSource = null;
				dgvTareas.Rows.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
