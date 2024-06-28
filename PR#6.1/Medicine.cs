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
    public partial class Medicine : Form
    {
        Hospital hospital;
        public Medicine()
        {
            InitializeComponent();
            hospital = Hospital.GetInstance();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Medicinebutton1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы за лекарствами? У вас есть рецепт?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) hospital.AccidentallyMedicine();
            else
            {
                MessageBox.Show("Вам не к нам. До сведания!", "Опрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
