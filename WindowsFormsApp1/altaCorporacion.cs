﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RN;
namespace WindowsFormsApp1
{
    public partial class altaCorporacion : Form
    {

        private Corporacion corporacion;

        public altaCorporacion()
        {
            InitializeComponent();
        }

        private void altaCorporacion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(inputNombre.Text) && !string.IsNullOrWhiteSpace(InputCuil.Text))
            {
                string nom = inputNombre.Text;
                string cuil = InputCuil.Text;
                corporacion = new Corporacion(nom, cuil);
                this.Close();
            } else {
                MessageBox.Show("Se deben completar todos los campos!!");
            }

        }

        public Corporacion darCorporacion()
        {
            return corporacion;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
