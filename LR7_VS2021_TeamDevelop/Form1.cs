using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_VS2021_TeamDevelop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Анекдот Мельничука*", "Вніманіє анекдот!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            new FormKukharuk().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отак після 25 років шлюбу намагаєшся організувати романтику, запалиш свічки… Прийде Він і питає: – хто вмер?", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За законом геометрії якщо чоловік 4 рази піде ліворуч, то прийде додому.", "Увага анекдот", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хочешь жить умей вертеться", "Сообщение");
        }
    }
}
