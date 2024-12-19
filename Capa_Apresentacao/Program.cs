using Capa_Apresentacao.Formularios.Modulos;
using Capa_Apresentacao.Formularios.Lista_Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios;
using Capa_Apresentacao.Formularios.Formulario_Dashboard;

namespace Capa_Apresentacao
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        #region Método que nos vai ajudar a inserir e a atualizar um registro
        public static int AJUDA;
        #endregion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Principal());
        }
    }
}
