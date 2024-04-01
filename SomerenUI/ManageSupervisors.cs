using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class ManageSupervisors : Form
    {
        ManageSupervisorsService service;
        List<Teacher> newAddedTeachers = new List<Teacher>();
        List<Teacher> newRemovedTeachers = new List<Teacher>();
        Activiteiten activiteit;

        public ManageSupervisors(Activiteiten activiteiten)
        {
            service = new ManageSupervisorsService();
            this.activiteit = activiteiten;
            InitializeComponent();
            List<Teacher> nonSupervising = service.GetAllNonSupervisingTeachers(activiteiten.Soort_Activiteit);
            List<Teacher> Supervising = service.GetAllSupervisingTeachers(activiteiten.Soort_Activiteit);
            foreach (Teacher teacher in nonSupervising)
            {
                ListViewItem li = new ListViewItem(teacher.Number.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.SurName);
                li.Tag = teacher;
                listViewNonSupervising.Items.Add(li);
            }
            foreach (Teacher teacher in Supervising)
            {
                ListViewItem li = new ListViewItem(teacher.Number.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.SurName);
                li.Tag = teacher;
                listViewSupervising.Items.Add(li);
            }
        }

        private void AddSupervisors_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in listViewNonSupervising.SelectedItems)
            {
                li.Remove();
                listViewSupervising.Items.Add(li);
                if (newRemovedTeachers.Contains((Teacher)li.Tag))
                {
                    newRemovedTeachers.Remove((Teacher)li.Tag);
                    newAddedTeachers.Add((Teacher)li.Tag);
                } else
                {
                    newAddedTeachers.Add((Teacher)li.Tag);
                }
            }
        }

        private void RemoveSupervisorsBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in listViewSupervising.SelectedItems)
            {
                li.Remove();
                listViewNonSupervising.Items.Add(li);
                if (newAddedTeachers.Contains((Teacher)li.Tag))
                {
                    newAddedTeachers.Remove((Teacher)li.Tag);
                    newRemovedTeachers.Add((Teacher)li.Tag);
                }
                else
                {
                    newRemovedTeachers.Add((Teacher)li.Tag);
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            { 
                if (newAddedTeachers.Count == 0 && newRemovedTeachers.Count == 0)
                {
                    MessageBox.Show("Niks aangepast");
                    this.Close();
                } else
                {
                    ConfirmManageSupervisors confirmManageSupervisors = new ConfirmManageSupervisors(newAddedTeachers, newRemovedTeachers, this.activiteit);
                    confirmManageSupervisors.ShowDialog();
                    if (!confirmManageSupervisors.canceled)
                    {
                        this.Close();   
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
