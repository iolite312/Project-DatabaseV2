using SomerenModel;
using SomerenService;
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
    public partial class ConfirmManageSupervisors : Form
    {
        Activiteiten activiteit;
        List<Teacher> teachersToBeRemoved;
        List<Teacher> teachersToBeAdded;
        public bool canceled = false;
        public ConfirmManageSupervisors(List<Teacher> teachersToBeAdded, List<Teacher> teachersToBeRemoved, Activiteiten activiteit)
        {
            this.activiteit = activiteit;
            this.teachersToBeAdded = teachersToBeAdded;
            this.teachersToBeRemoved = teachersToBeRemoved;
            InitializeComponent();
            foreach (Teacher teacher in this.teachersToBeRemoved)
            {
                ListViewItem li = new ListViewItem(teacher.Number.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.SurName);
                li.Tag = teacher;
                listViewNonSupervising.Items.Add(li);
            }
            foreach (Teacher teacher in this.teachersToBeAdded)
            {
                ListViewItem li = new ListViewItem(teacher.Number.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.SurName);
                li.Tag = teacher;
                listViewSupervising.Items.Add(li);
            }

            this.activiteit = activiteit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (teachersToBeRemoved.Count !> 0)
                {
                    DeleteSupervisorPopup deleteSupervisorPopup = new DeleteSupervisorPopup();
                    deleteSupervisorPopup.ShowDialog();
                    if (!deleteSupervisorPopup.canceled)
                    {
                        ActivateService();
                    } else
                    {
                        canceled = true;
                        this.Close();
                    }
                } else
                {
                    ActivateService();
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ActivateService()
        {
            ManageSupervisorsService manageSupervisorsService = new ManageSupervisorsService();
            manageSupervisorsService.AddSupervisorsToActivity(teachersToBeAdded, activiteit);
            manageSupervisorsService.RemoveSupervisorsToActivity(teachersToBeRemoved, activiteit);
            MessageBox.Show("Update Succesful");
            this.Close();
        }
    }
}
