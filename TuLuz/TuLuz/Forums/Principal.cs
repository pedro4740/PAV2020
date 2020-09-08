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

namespace TuLuz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            Panel_Barrios.Visible = false;
            Panel_Clientes.Visible = false;
            Panel_Cotizaciones.Visible = false;
            Panel_Empleados.Visible = false;
            Panel_Pedidos.Visible = false;
            Panel_Proveedores.Visible = false;
            Panel_Productos.Visible = false;
            Panel_Localidades.Visible = false;
            Panel_Provincias.Visible = false;
            Panel_Tipo_Doc.Visible = false;
            Panel_Procesos.Visible = false;
            Panel_Listados.Visible = false;
            Panel_Estadisticas.Visible = false;
            panelUsuario.Visible = false;
        }

        private void OcultarMenu()
        {
            if (Panel_Barrios.Visible == true)
                Panel_Barrios.Visible = false;
            if (Panel_Clientes.Visible == true)
                Panel_Clientes.Visible = false;
            if (Panel_Cotizaciones.Visible == true)
                Panel_Cotizaciones.Visible = false;
            if (Panel_Empleados.Visible == true)
                Panel_Empleados.Visible = false;
            if (Panel_Pedidos.Visible == true)
                Panel_Pedidos.Visible = false;
            if (Panel_Proveedores.Visible == true)
                Panel_Proveedores.Visible = false;
            if (Panel_Productos.Visible == true)
                Panel_Productos.Visible = false;
            if (Panel_Localidades.Visible == true)
                Panel_Localidades.Visible = false;
            if (Panel_Provincias.Visible == true)
                Panel_Provincias.Visible = false;
            if (Panel_Tipo_Doc.Visible == true)
                Panel_Tipo_Doc.Visible = false;
            if (Panel_Procesos.Visible == true)
                Panel_Procesos.Visible = false;
            if (Panel_Listados.Visible == true)
                Panel_Listados.Visible = false;
            if (Panel_Estadisticas.Visible == true)
                Panel_Estadisticas.Visible = false;
            if (panelUsuario.Visible == true)
                panelUsuario.Visible = false;
        }

        private void MostrarMenu(Panel Paneles)     //MOSTRAR LOS SUB MENUS CONTENEDORES
        {
            if (Paneles.Visible == false)         //SI UN PANEL ESTA OCULTO, LO MOSTRAMOS. PERO ANTES INVOCAMOS AL METODO OCULTAR_MENU, PARA CERRAR ALGUN OTRO PANEL ABIERTO
            {
                OcultarMenu();
                Paneles.Visible = true;
            }
            else
            {
                Paneles.Visible = false;        //SI EL PANEL ESTA ABIERTO, LO CERRAMOS.
            }
        }


        //    - -   -   -   -   -   -   LOGIN   -   -   -   -   -   -   -   -   -   -   -   

        private void Principal_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.logOK == 0)
            {
                this.Close();
            }
            nomEmpleadoLog.Text = log.Usuario;
        }
        #region Botones_Principales_Paneles
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Clientes);
        }

        private void btn_Cotizaciones_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Cotizaciones);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Empleados);
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Pedidos);
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Proveedores);
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Productos);
        }

        private void btn_Localidades_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Localidades);
        }

        private void btn_Provincia_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Provincias);
        }

        private void btn_Barrio_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Barrios);
        }

        private void btn_Tipo_Doc_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Tipo_Doc);
        }

        private void btn_Procesos_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Procesos);
        }

        private void btn_Listados_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Listados);
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Estadisticas);
        }
        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormularioActivo = null;
        private void AbrirFormularioSubMenu(Form FormularioSubMenu)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();       //si existe un formulario abierto, lo cerramos 

            FormularioActivo = FormularioSubMenu;
            FormularioSubMenu.TopLevel = false;
            FormularioSubMenu.FormBorderStyle = FormBorderStyle.None;   //sin bordes
            FormularioSubMenu.Dock = DockStyle.Fill;    //para rellenar formulario en el centro
            Panel_Centro.Controls.Add(FormularioSubMenu); //agregar formulario al panel central 
            Panel_Centro.Tag = FormularioSubMenu; //asociamos el formulario con el panel
            FormularioSubMenu.BringToFront(); //traer el formulario por delante de la imagen de fondo
            FormularioSubMenu.Show(); //ejecutar formulario
        }
        //  -   -   -   -   -   -   -   -   -   -   CLICK A LOS BOTONES DE LOS SUB MENUS    -   -   -   -   -   -   -   -   -   
        private void btn_RegistrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaCliente());
        }

        private void btn_ModificarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarCliente());
        }
        private void btn_ConsultarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarCliente());
        }

        private void btn_EliminarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarCliente());
        }
        private void nomEmpleadoLog_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelUsuario);
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.ShowDialog();
            if (log.logOK == 0)
            {
                this.Close();
            }

            nomEmpleadoLog.Text = log.Usuario;
            panelUsuario.Visible = false;

        }

        private void btn_RegistrarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaBarrio());
        }

        private void btn_EliminarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarBarrio());
        }

        private void btn_ConsultarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarBarrio());
        }

        private void btn_ModificarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarBarrio());
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            
            AbrirFormularioSubMenu(new VerPerfil(nomEmpleadoLog.Text));

        }

        private void Panel_Centro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
