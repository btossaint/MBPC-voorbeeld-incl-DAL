using MBPC001.Models;
using System;
using System.Windows.Forms;

namespace MBPC001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            ShowMembersInComboBox();
            // onderstaand uitzondering. Is om type SQL Server op te vragen voor de frontend!
            tsl_DB.Text = $"Database: {DAL.DALSingleton.Instance.GetType().Name.ToString()}";
        }

        private void b_GetLotForMember_Click(object sender, EventArgs e)
        {
            Lot lot = new Lot();
            lb_LotsForMember.DataSource = lot.GetLotMembers(cb_ListMembers.SelectedValue.ToString());
            lb_LotsForMember.DisplayMember = "description";
        }

        private void ShowMembersInComboBox()
        {
            Member member = new Member();
            cb_ListMembers.Items.Clear();
            cb_ListMembers.DataSource = member.GetMembersWithLot();
            cb_ListMembers.DisplayMember = "Lastname";
            cb_ListMembers.ValueMember = "id";
        }
    }
}
