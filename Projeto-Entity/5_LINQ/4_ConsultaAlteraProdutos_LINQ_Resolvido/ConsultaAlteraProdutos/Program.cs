﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsultaAlteraProdutos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (new FormLogin().ShowDialog() == DialogResult.OK)
                Application.Run(new FormPrincipal());
            else
                MessageBox.Show("Usuário não autorizado...");

            
        }
    }
}
