﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormInstrucoes : Form
    {
        public FormInstrucoes()
        {
            InitializeComponent();
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
