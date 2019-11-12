using System;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Quatum.Controlador;


namespace Quatum.Vista.LibroMayorUI
{
    class LMController
    {
        ArrayList fechas = new ArrayList();
        ArrayList cuentas = new ArrayList();

        MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
        LMayor vista;

        public LMController() { }

        public LMController(LMayor view)
        {
            vista = view;
            vista.cmbCuenta.SelectedIndexChanged += new EventHandler(cmbCuenta);
            vista.cmbFecha.SelectedIndexChanged += new EventHandler(cmbFecha);
            vista.cmbHasta.SelectedIndexChanged += new EventHandler(cmbHasta);
            vista.btnExportar.Click += new EventHandler(ExportarExcel);
        }

        public void fechasCargadas()
        {
            int filas = vista.dataGridLibroMayor.RowCount;
            for (int i = 0; i < filas; i++)
            {
                fechas.Add(Convert.ToString(vista.dataGridLibroMayor.Rows[i].Cells["fechaLibroMayor"].Value));
            }
            for (int i = 0; i < fechas.Count; i++)
            {
                for (int j = i + 1; j < fechas.Count; j++)
                {
                    if (fechas[i].Equals(fechas[j]))
                    {
                        fechas.RemoveAt(j);
                        j--;
                    }
                }
            }
        }
        public void cuentasCargadas()
        {
            int filas = vista.dataGridLibroMayor.RowCount;
            for (int i = 0; i < filas; i++)
            {
                cuentas.Add(Convert.ToString(vista.dataGridLibroMayor.Rows[i].Cells["descripcionLibroMayor"].Value));
            }
            for (int i = 0; i < cuentas.Count; i++)
            {
                for (int j = i + 1; j < cuentas.Count; j++)
                {
                    if (cuentas[i].Equals(cuentas[j]))
                    {
                        cuentas.RemoveAt(j);
                        j--;
                    }
                }
            }

        }

        public void cargarCombo()
        {
            for (int i = 0; i < fechas.Count; i++)
            {
                vista.cmbFecha.Items.Add(fechas[i]);
                vista.cmbHasta.Items.Add(fechas[i]);
            }
            for (int i = 0; i < cuentas.Count; i++)
            {
                vista.cmbCuenta.Items.Add(cuentas[i]);
            }

            vista.cmbFecha.SelectedIndex = 0;
            vista.cmbHasta.SelectedIndex = fechas.Count - 1;
            vista.cmbCuenta.SelectedIndex = 0;
        }

        public void cmbCuenta(Object sender, EventArgs e) {
            mostrarPorCuenta(vista.dataGridLibroMayor, vista.cmbCuenta.Text);
            if (vista.cmbCuenta.SelectedIndex != 0)
            {

                if (vista.dataGridLibroMayor.Rows != null)
                {
                    saldoFinal();
                }
            }
            else
            {
                saldoLibroMayor();
            }
        }
        public void cmbFecha(Object sender, EventArgs e)
        {
            mostrarPorFecha(vista.dataGridLibroMayor,vista.cmbCuenta.Text);
            if (vista.cmbCuenta.SelectedIndex != 0)
            {
                if (vista.dataGridLibroMayor.Rows != null)
                {
                saldoFinal();
                }
            }
            else
            {
                saldoLibroMayor();
            }
        }
        public void cmbHasta(Object sender, EventArgs e) {
            mostrarPorFecha(vista.dataGridLibroMayor,vista.cmbCuenta.Text);

            if (vista.cmbCuenta.SelectedIndex != 0)
            {

                if (vista.dataGridLibroMayor.Rows != null)
                {
                    saldoFinal();
                }
            }
            else
            {
                saldoLibroMayor();
            }
        }
        public void mostrarPorCuenta(DataGridView uno, String descripcion) {
            
            if (vista.cmbCuenta.SelectedIndex > 0)
            {
                mostrarPorFecha(uno, descripcion);
            }
            else
            {
                mostrarPorFecha(uno,descripcion);
            }
        }
        public void mostrarPorFecha(DataGridView uno, String descripcion)
        {

            DataTable dt = new DataTable();
            if (vista.cmbFecha.SelectedIndex > vista.cmbHasta.SelectedIndex) {
                if (vista.cmbCuenta.SelectedIndex > 0)
                {
                    for (int i = vista.cmbFecha.SelectedIndex; i >= vista.cmbHasta.SelectedIndex; i--)
                    {
                        MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT asientos.asiento_fecha, plan_cuentas.cuentas_descripcion, plan_cuentas.cuenta_tipo, asientos.asiento_valor, asientos.asiento_tipo FROM  asientos INNER JOIN plan_cuentas ON asientos.cuentas = plan_cuentas.cuentas_id WHERE (asientos.asiento_fecha = '" + vista.cmbFecha.Items[i] + "') AND (plan_cuentas.cuentas_descripcion = '" + descripcion + "')", conexion);

                        adaptador.Fill(dt);
                        uno.DataSource = dt;
                    }
                }
                       
            }
            else
            {   
                if(vista.cmbCuenta.SelectedIndex > 0){
                for (int i = vista.cmbFecha.SelectedIndex; i <= vista.cmbHasta.SelectedIndex; i++)
                {
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT asientos.asiento_fecha, plan_cuentas.cuentas_descripcion, plan_cuentas.cuenta_tipo, asientos.asiento_valor, asientos.asiento_tipo FROM  asientos INNER JOIN plan_cuentas ON asientos.cuentas = plan_cuentas.cuentas_id WHERE (asientos.asiento_fecha = '" + vista.cmbFecha.Items[i] + "') AND (plan_cuentas.cuentas_descripcion = '" + descripcion + "')", conexion);
                    
                    adaptador.Fill(dt);
                    uno.DataSource = dt;
                }
                }
                else
                {
                    for (int i = vista.cmbFecha.SelectedIndex; i <= vista.cmbHasta.SelectedIndex; i++)
                    {
                        MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT asientos.asiento_fecha, plan_cuentas.cuentas_descripcion, plan_cuentas.cuenta_tipo, asientos.asiento_valor, asientos.asiento_tipo FROM asientos INNER JOIN plan_cuentas ON asientos.cuentas = plan_cuentas.cuentas_id WHERE (asientos.asiento_fecha = '" + vista.cmbFecha.Items[i].ToString() + "')", conexion);
                        adaptador.Fill(dt);
                        
                        uno.DataSource = dt;
                    }
                   
                }
            }
        }
        public void saldoFinal() {
            int saldoTotalDebe = 0;
            int saldoTotalHaber = 0;
            String debe = "Debe";
            String haber = "Haber";
            string aux;
            if (vista.dataGridLibroMayor.RowCount >= 0)
            {
                try
                {
                    aux = vista.dataGridLibroMayor.Rows[0].Cells["tipoLibroMayor"].Value.ToString();
                }
                catch (Exception)
                {
                    aux = "+";
                }
                
                switch (aux)
                {
                    case "Activo":
                    case "Egreso":
                        vista.saldoLbl.Text = "SALDO TOTAL DEUDOR: ";
                        for (int i = 0; i < vista.dataGridLibroMayor.Rows.Count; i++)
                        {
                            if (vista.dataGridLibroMayor.Rows[i].Cells["debeHaberLibroMayor"].Value.ToString().Equals(debe))
                            {
                                saldoTotalDebe += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                            }
                            else
                            {
                                saldoTotalHaber += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                            }
                        }
                        vista.saldoTxt.Text = Convert.ToString(saldoTotalDebe - saldoTotalHaber);
                        break;
                    case "Pasivo":
                    case "Ingreso":
                    case "PN":
                        vista.saldoLbl.Text = "SALDO TOTAL ACREEDOR: ";

                        for (int i = 0; i < vista.dataGridLibroMayor.Rows.Count; i++)
                        {
                            if (vista.dataGridLibroMayor.Rows[i].Cells["debeHaberLibroMayor"].Value.ToString().Equals(haber))
                            {
                                saldoTotalHaber += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                            }
                            else
                            {
                                saldoTotalDebe += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                            }
                        }
                        vista.saldoTxt.Text = Convert.ToString(saldoTotalHaber - saldoTotalDebe);
                        break;
                    default:
                        Mensaje.Mostrar(1, "No existe la cuenta en la fecha seleccionada por favor eliga otra cuenta");
                        break;
                }
            }
     
            else
            {
                Mensaje.Mostrar(1,"La cuenta no existe.");
            }
            
            
            
        }
        public void saldoLibroMayor()
        {

            int saldoTotalDebe = 0;
            int saldoTotalHaber = 0;
            for (int i = 0; i < vista.dataGridLibroMayor.Rows.Count; i++)
            {
                if (vista.dataGridLibroMayor.Rows[i].Cells["debeHaberLibroMayor"].Value.ToString().Equals("Debe"))
                {
                    saldoTotalDebe += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                }
                else
                {
                    saldoTotalHaber += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                }
            }
            vista.saldoLbl.Text = "Saldo Total :";
            vista.saldoTxt.Text = Convert.ToString(saldoTotalDebe - saldoTotalHaber);
        }

        public void ExportarExcel(Object sender, EventArgs e) {
            ExportarDataGridViewExcel(vista.dataGridLibroMayor);
        
        }

        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Libro-Mayor";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}
