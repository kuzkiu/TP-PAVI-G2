﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_MenuPrincipal());
            //Application.Run(new Frm_AltaArticulos());
            //Application.Run(new Frm_ConsultaArticulos());
            //Application.Run(new Frm_ModificarArticulos());
        }
    }
}
