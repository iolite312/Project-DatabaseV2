using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DeleteSupervisorPopup : Form
    {
        public bool canceled = false;
        public DeleteSupervisorPopup()
        {
            InitializeComponent();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.canceled = true;
            this.Close();
        }
    }
}
