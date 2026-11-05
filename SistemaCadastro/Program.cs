using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    class Banda
    {
        string nome;
        int integrantes;
        int ranking;
        int genero;

        public string Nome { get => nome; set => nome = value; }
        public int Integrantes { get => integrantes; set => integrantes = value; }
        public int Ranking { get => ranking; set => ranking = value; }
        public int Genero { get => genero; set => genero = value; }
    }
    
    
    
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sistema());
        }
    }
}
