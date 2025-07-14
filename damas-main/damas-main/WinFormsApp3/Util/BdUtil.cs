using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class BdUtil
    {
        // Pode ser expandida para múltiplas configurações no futuro
        public static string ConnectionString { get; } ="server=localhost;database=xadrez_MGA;uid=root;pwd=;";
    }
}
