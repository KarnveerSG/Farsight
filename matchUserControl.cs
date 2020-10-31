using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class matchUserControl : UserControl
    {
        public matchUserControl()
        {
            InitializeComponent();
        }

        private void matchUserControl_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("User clicked on a match");
        }
    }
}
