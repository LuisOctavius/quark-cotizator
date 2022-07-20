using qk_cotiztr.Models;
using qk_cotiztr.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qk_cotiztr.Views
{
    public partial class ViewCotizationHistory : Form
    {
        private readonly IEnumerable<CotizationHistoryItem> _cotizations;
        public ViewCotizationHistory(IEnumerable<CotizationHistoryItem> cotizations)
        {
            _cotizations = cotizations;

            InitializeComponent();
        }

        private void ViewCotizationHistory_Load(object sender, EventArgs e)
        {
            dataGridView_CotizationHistory.DataSource = _cotizations;
        }
    }
}
