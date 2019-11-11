using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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
                saldoFinal();
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
                saldoFinal();
            }
            else
            {
                saldoLibroMayor();
            }
        }
        public void cmbHasta(Object sender, EventArgs e) {
            mostrarPorFecha(vista.dataGridLibroMayor,vista.cmbCuenta.Text);
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
            int contador = 0;
            if (vista.cmbFecha.SelectedIndex > vista.cmbHasta.SelectedIndex) {
                contador++;
                if(contador > 1){
                    MessageBox.Show("Error no puede elegir una fecha menor a la seleccionada, eliga la misma o una mayor");
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
            switch (vista.dataGridLibroMayor.Rows[0].Cells["tipoLibroMayor"].Value.ToString())
            {
                case "Activo":
                case "Egreso":
                    vista.saldoLbl.Text = "SALDO TOTAL DEUDOR: ";
                    for (int i = 0; i < vista.dataGridLibroMayor.Rows.Count; i++)
                    {
                        if (vista.dataGridLibroMayor.Rows[i].Cells["debeHaberLibroMayor"].Value.ToString().Equals(debe)) {
                            saldoTotalDebe += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                        }
                        else
                        {
                            saldoTotalHaber += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                        }
                    }
                    vista.saldoTxt.Text = Convert.ToString(saldoTotalDebe-saldoTotalHaber);
                    break;
                case  "Pasivo":
                case  "Ingreso":
                case  "PN":
                    vista.saldoLbl.Text = "SALDO TOTAL ACREEDOR: ";
                    
                    for (int i = 0; i < vista.dataGridLibroMayor.Rows.Count; i++)
                    {
                        if (vista.dataGridLibroMayor.Rows[i].Cells["debeHaberLibroMayor"].Value.ToString().Equals(haber)) {
                            saldoTotalHaber += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                        }
                        else
                        {
                            saldoTotalDebe += Convert.ToInt32(vista.dataGridLibroMayor.Rows[i].Cells["saldoLibroMayor"].Value);
                        }
                    }
                    vista.saldoTxt.Text = Convert.ToString(saldoTotalHaber-saldoTotalDebe);
                    break;
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
    }
}
