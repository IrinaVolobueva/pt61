using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    internal class Hospital
    {
        private static Hospital instance;
        private Hospital() { }
        public static Hospital GetInstance()
        { 
            if (instance == null)
            {
                instance = new Hospital();
            }
            return instance; 
        }
        public void AccidentallyMedicalExamination()
        {
            Random random = new Random();
            int rand = random.Next(-1, 2);
            switch (rand)
            { 
                case 0:
                    MessageBox.Show("Ой.. У вас вместо ног палки!!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Ой.. Ваши зубы все отпали!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    MessageBox.Show("У вас вместо глаз стекло цветное!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
        public void AccidentallyAmbulance()
        {
            Random random = new Random();
            int rand = random.Next(-1, 4);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Ой.. Вы робот!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Ой.. Вы не один человек, а кучка гномов!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    MessageBox.Show("МАМОЧКИ! У вас в сердце кто-то живет и бегает в колесе!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 3:
                    MessageBox.Show("Вы случайно умерли! Вас напугала лампа.", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 4:
                    MessageBox.Show("Кто-то вас приследует или вам это показалось?", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
        public void AccidentallyMedicine()
        {
            Random random = new Random();
            int rand = random.Next(-1, 1);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("У нас нет АНТИГРУСТИНА, вам в соседнее здание!", "Случайное сообщение!",MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Ой.. Ваши руки отпали от большого кол-ва лекарств.", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
    }
}
