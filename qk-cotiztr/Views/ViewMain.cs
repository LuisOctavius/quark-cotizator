using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace qk_cotiztr.Views
{
    public partial class ViewMain : Form
    {
        public ViewMain()
        {
            InitializeComponent();
        }

        private void Btn_CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void Panel_FixedTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {
            SetGarmentTypesOptions();
        }

        private void SetGarmentTypesOptions()
        {
            comboBox_Garments.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Garments.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}
