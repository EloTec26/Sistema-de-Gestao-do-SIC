using Capa_Apresentacao.Formularios.Modulos;
using Capa_Apresentacao.Formularios.Lista_Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios;
using Capa_Apresentacao.Formularios.Formulario_Dashboard;
using Capa_Apresentacao.Formularios.Formularios_Relatorios;

namespace Capa_Apresentacao
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
            //Application.Run(new Form_Relatorio_Evento_Casos());
        }
    }
}
