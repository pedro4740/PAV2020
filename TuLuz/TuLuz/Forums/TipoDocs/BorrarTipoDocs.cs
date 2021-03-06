﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Forums;
using TuLuz.Forums.Clientes;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;




namespace TuLuz.Forums.Clientes
{
    public partial class BorrarTipoDoc : Form
    {
        Ng_Tipo_Documentos Documentos = new Ng_Tipo_Documentos();
        public string Id { get; set; }

        public BorrarTipoDoc()
        {
            InitializeComponent();
            CerrarPanel();


        }
        private void CerrarPanel()
        {
            Panel_BorrarTipoDoc.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (this.grid01.Rows.Count == 0)
            {
                MessageBox.Show("No selecciono ningun registro de la grilla", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                this.Id = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable Verificacion = new DataTable();
                Verificacion = Documentos.Buscar_TiposDoc_Codigo(this.Id);
                if (Verificacion.Rows.Count > 0)
                {
                    Panel_BorrarTipoDoc.Visible = true;
                    DataTable tabla = new DataTable();
                    tabla = Documentos.Buscar_TiposDoc_Codigo(Id);
                    txt_idTipoDoc.Text = tabla.Rows[0]["idTipoDoc"].ToString();
                    txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
                    txt_siglas.Text = tabla.Rows[0]["siglas"].ToString();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarPanel();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_Todos.Checked == true)
            {
                Cargar_grilla(Documentos.Todos_las_Tipos_Doc());
            }
            else
            {
                if (txt_BuscarId.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Documentos.Buscar_TiposDoc_Codigo(txt_BuscarId.Text));
                }
            }
        }
        private void Cargar_grilla(DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["idTipoDoc"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["siglas"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarId.Text = "";
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Documentos.Borrar(this.Id);
            Panel_BorrarTipoDoc.Visible = false;
        }

        private void BorrarBarrio_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_BuscarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
