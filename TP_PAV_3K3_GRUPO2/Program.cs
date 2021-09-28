﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Formularios.Cargo;
using TP_PAV_3K3_GRUPO2.Formularios.Rubro;

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
            //Application.Run(new Frm_ModificarArticulos());
            //Application.Run(new Frm_ConsultaArticulos());
            //Application.Run(new Frm_RegCargo());
            //Application.Run(new Frm_BajaCargo());
            //Application.Run(new Frm_BajaRubro());
            //Application.Run(new Frm_ModificarCargo());
            //Application.Run(new Frm_ModificarRubro());
            //Application.Run(new Frm_ConsultarCargo());
            //Application.Run(new Frm_ConsultarRubro());
        }

        
    }
}
