using ShowMyIP.Control;
using System.Net;
using System.Net.NetworkInformation;

namespace ShowMyIP
{
    public partial class formShowMyIP : Form
    {
        public formShowMyIP()
        {
            InitializeComponent();
        }

        NetworkControl netCtrl = new NetworkControl();

        private void btnShowIP_Click(object sender, EventArgs e)
        {
            if(!netCtrl.getNetworkIpAddress())
            {
                MessageBox.Show("Você não está conectado em nenhuma rede.", "Seu IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
