using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1lift
{
    public partial class LiftF : Form
    {
        private readonly ElevatorService service = new ElevatorService();
        public LiftF()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                cmbFloor.Items.Add(i);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (cmbFloor.SelectedItem == null)
                return;

            int selectedFloor = Convert.ToInt32(cmbFloor.SelectedItem);

            string message = service.CallElevator(selectedFloor);

            lblLog.Text = DateTime.Now.ToString("HH:mm:ss")+ " — " + message;

            UpdateElevatorStatus();
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            if (cmbFloor.SelectedItem == null)
                return;

            int selectedFloor = Convert.ToInt32(cmbFloor.SelectedItem);

            lstRooms.Items.Clear();

            string info = service.GetFloorInfo(selectedFloor);

            foreach (string line in info.Split(new[] { '\n' },StringSplitOptions.RemoveEmptyEntries))
            {
                lstRooms.Items.Add(line.TrimEnd('\r'));
            }
        }
        private void UpdateElevatorStatus()
        {
            lblElevator.Text = "Текущее положение лифта: этаж " + service.GetCurrentFloor();
        }
    }
}
