using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florida_Bus_Reservation
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void sIGNINToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRM_SIGN_IN frmSignIn = new FRM_SIGN_IN(this);
            frmSignIn.ShowDialog(this);

        }

        private void mANAGECLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUS.FRM_MANAGE_CLASS frmManageClass = new BUS.FRM_MANAGE_CLASS();
            frmManageClass.ShowDialog();
        }

        private void mANAGEBUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUS.FRM_MANAGE_BUS frmManageBus = new BUS.FRM_MANAGE_BUS();
            frmManageBus.ShowDialog();
        }

        private void mANAGESCHEDULESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCHEDULES.FRM_BUS_SCHEDULES frmSchedules = new SCHEDULES.FRM_BUS_SCHEDULES();
            frmSchedules.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            if (Classes.Globals.user_control_id == 0)
            {
                FRM_SIGN_IN frmSignIn = new FRM_SIGN_IN(this);
                frmSignIn.ShowDialog(this);
            }
        }

        private void init_all()
        {
            this._init_action_security();
        }

        // use action security
        private void _init_action_security()
        {
            // disable all first
            this.sIGNINToolStripMenuItem.Visible = true;
            this.uSERSToolStripMenuItem.Visible = false;
            this.eXITToolStripMenuItem.Visible = true;
            this.toolStrip_bus_bus.Visible = false;
            this.toolStrip_dropdown_schedule.Visible = false;
            this.toolStrip_dropdown_reservation.Visible = false;

            // separators
            this.toolStripSeparator1.Visible = false;
            this.toolStripSeparator2.Visible = false;
            this.toolStripSeparator3.Visible = false;
            this.toolStripSeparator4.Visible = false;
            if (Classes.Globals.user_control_id != 0)
            {
                this.uSERSToolStripMenuItem.Visible = true;
                this.toolStrip_bus_bus.Visible = true;
                this.toolStrip_dropdown_schedule.Visible = true;
                this.toolStrip_dropdown_reservation.Visible = true;

                // separators
                this.toolStripSeparator1.Visible = true;
                this.toolStripSeparator2.Visible = true;
                this.toolStripSeparator3.Visible = true;
                this.toolStripSeparator4.Visible = true;
            }
            
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            this.init_all();
        }

        private void mANAGERESERVATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESERVATION.FRM_MANAGE_RESERVATION frmManageReservation = new RESERVATION.FRM_MANAGE_RESERVATION(this);
            frmManageReservation.ShowDialog(this);
        }

        private void mANAGEPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRANSACTIONS.FRM_PAYMENTS frmPayments = new TRANSACTIONS.FRM_PAYMENTS();
            frmPayments.ShowDialog(this);
        }

    }
}
