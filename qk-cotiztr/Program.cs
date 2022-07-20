using qk_cotiztr.Controllers;
using qk_cotiztr.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qk_cotiztr
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ViewMain view = new ViewMain();
            CotizationsController controller = new CotizationsController(view);

            Application.Run(view);
        }
    }
}
