using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class Ambulance : Form
    {
        Hospital hospital;
        public Ambulance()
        {
            InitializeComponent();
            hospital = Hospital.GetInstance();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Ambulancebutton2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы заболели? У вас температура?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) hospital.AccidentallyAmbulance();
            else
            {
                DialogResult result2 = MessageBox.Show("Вы что-то сломали?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result2 == DialogResult.Yes) hospital.AccidentallyAmbulance();
                else
                {
                    MessageBox.Show("Вам не к нам. До сведания!", "Опрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }

        }
    }
}
