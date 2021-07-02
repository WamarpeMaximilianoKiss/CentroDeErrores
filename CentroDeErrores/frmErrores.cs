using Backtrace;
using Backtrace.Model;
using Backtrace.Model.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeErrores
{
    public partial class frmErrores : Form
    {
        public frmErrores()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var backtraceCredentials = new BacktraceCredentials(@"https://submit.backtrace.io/maxikiss/6129ff0beb278ab46ac23023cff9fdd9e1024e9ade9d7968b702c4dd16885b47/json", "6129ff0beb278ab46ac23023cff9fdd9e1024e9ade9d7968b702c4dd16885b47");
            var backtraceClient = new BacktraceClient(backtraceCredentials);

            try
            {
                //throw exception here
                decimal a = 19;
                decimal v = 0;
                v = a / 0;
            }
            catch (Exception exception)
            {
                await backtraceClient.SendAsync(new BacktraceReport(exception));
            }
        }
    }
}
