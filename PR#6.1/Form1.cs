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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doneButton(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(surnameTextBox.Text) & !String.IsNullOrEmpty(nametextBox.Text) & !String.IsNullOrEmpty(patronymicTextBox.Text) & !String.IsNullOrEmpty(ageTextBox.Text))
            {
                try
                {
                    int age = Convert.ToInt32(ageTextBox.Text);
                    if (age > 0)
                    {
                        string name = nametextBox.Text;
                        string surname = surnameTextBox.Text;
                        string patronymic = patronymicTextBox.Text;
                        if (name.All(c => !Char.IsDigit(c)) & surname.All(c => !Char.IsDigit(c)) & patronymic.All(c => !Char.IsDigit(c)))
                        {
                            if (ambulanceRadioButton.Checked == true)
                            {
                                Ambulance ambulance = new Ambulance();
                                ambulance.ShowDialog();
                            }
                            else if (medicineRadioButton.Checked == true)
                            {
                                Medicine medicine = new Medicine();
                                medicine.ShowDialog();
                            }
                            else if (medicalExaminationRadioButton.Checked == true)
                            {
                                MedicalExamination medical = new MedicalExamination();
                                medical.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ФИО не может содержать цифры!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Возврас не может быть отрицательным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Проверьте не пустые ли у вас поля для ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doneButton2(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(surnameTextBox.Text) & !String.IsNullOrEmpty(nametextBox.Text) & !String.IsNullOrEmpty(patronymicTextBox.Text) & !String.IsNullOrEmpty(ageTextBox.Text))
            {
                try
                {
                    int age = Convert.ToInt32(ageTextBox.Text);
                    if (age > 0)
                    {
                        string name = nametextBox.Text;
                        string surname = surnameTextBox.Text;
                        string patronymic = patronymicTextBox.Text;
                        if (name.All(c => !Char.IsDigit(c)) & surname.All(c => !Char.IsDigit(c)) & patronymic.All(c => !Char.IsDigit(c)))
                        {
                            if (ambulanceRadioButton.Checked == true)
                            {
                                Ambulance ambulance = new Ambulance();
                                ambulance.ShowDialog();
                            }
                            else if (medicineRadioButton.Checked == true)
                            {
                                Medicine medicine = new Medicine();
                                medicine.ShowDialog();
                            }
                            else if (medicalExaminationRadioButton.Checked == true)
                            {
                                MedicalExamination medical = new MedicalExamination();
                                medical.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ФИО не может содержать цифры!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nametextBox.Clear();
                            surnameTextBox.Clear();
                            patronymicTextBox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Возврас не может быть отрицательным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Проверьте не пустые ли у вас поля для ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nametextBox.Clear();
            surnameTextBox.Clear();
            patronymicTextBox.Clear();
            ageTextBox.Clear();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
