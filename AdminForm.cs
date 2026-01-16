using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skvortsova_PR07_Git
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скворцова А.О.", "ФИО администратора",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем текущую дату и время при загрузке формы
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timer1.Start(); // Запускаем таймер
        }

        // Таймер обновляет дату и время каждую секунду
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auth Auth = new Auth();
            this.Visible = false;
            Auth.ShowDialog();
            this.Visible = true;
        }
    }
}
