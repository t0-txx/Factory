using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ผผลตToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manufacturer form = new Manufacturer();
            form.Show();
        }

        private void ประเภทอปกรณToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentType form = new EquipmentType();
            form.Show();
        }

        private void อะไหลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sparepart form = new Sparepart();
            form.Show();
        }

        private void ชางToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Technician form = new Technician();
            form.Show();
        }

        private void บรษทToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company form = new Company();
            form.Show();
        }

        private void ใบนำเขาอปกรณToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentOrder form = new EquipmentOrder();
            form.Show();
        }

        private void ผผลตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment form = new Equipment();
            form.Show();
        }

        private void ใบนำเขาอปกรณToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SparepartOrder form = new SparepartOrder();
            form.Show();
        }

        private void แจงซอมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repair form = new Repair();
            form.Show();
        }

        private void ใบเบกอะไหลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceSchedule form = new MaintenanceSchedule();
            form.Show();
        }

        private void ใบสงซอมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SparepartRequisition form = new SparepartRequisition();
            form.Show();
        }

        private void ใบสงซอมToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RepairDispatch form = new RepairDispatch();
            form.Show();
        }
    }
}
