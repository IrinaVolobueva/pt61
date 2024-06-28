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
    public partial class MedicalExamination : Form
    {
        Hospital hospital;
        public MedicalExamination()
        {
            InitializeComponent();
            hospital = Hospital.GetInstance();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void MedicalExaminationbutton1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("У вас сегодня первый день медосмотра?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) hospital.AccidentallyMedicalExamination();
            else
            {
                DialogResult result2 = MessageBox.Show("Вы полность прошли мелосмотр? Вам нужна печать?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result2 == DialogResult.Yes) hospital.AccidentallyMedicalExamination();
                else
                {
                    MessageBox.Show("Вам не к нам. До сведания!", "Опрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
    }
}
