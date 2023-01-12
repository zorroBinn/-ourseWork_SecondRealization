using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СourseWork_SecondRealization
{
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
        }

        private void checkBoxman_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxman.Checked == true)
                this.checkBoxwoman.Checked = false;
        }

        private void checkBoxwoman_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxwoman.Checked == true)
                this.checkBoxman.Checked = false;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (this.textBoxname.Text == "" || (this.checkBoxman.Checked == false && this.checkBoxwoman.Checked == false) || this.comboBoxage.Text == "" || this.numericUpDownheight.Text == "" || this.numericUpDownweight.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    StreamWriter f = new StreamWriter("save.save", false);
                    f.WriteLine(this.textBoxname.Text);
                    if (this.checkBoxman.Checked == true)
                    {
                        f.WriteLine("М");
                    }
                    else
                    {
                        f.WriteLine("Ж");
                    }
                    f.WriteLine(this.comboBoxage.Text);
                    f.WriteLine(100); //Balance
                    f.WriteLine(this.numericUpDownweight.Text);
                    f.WriteLine(this.numericUpDownheight.Text);
                    f.WriteLine(100); //HealthStatus
                    f.WriteLine(0); //InfinityHealth
                    f.WriteLine("Раздача листовок");
                    f.WriteLine(10); //Payment
                    f.WriteLine("Кофта");
                    f.WriteLine("Джинсы");
                    f.WriteLine("Кроссовки");
                    f.WriteLine(100); //ClothesStatus
                    f.WriteLine(0); //AutoSewUp
                    f.WriteLine("Гараж");
                    f.WriteLine("Велик");
                    f.WriteLine(0); //Level
                    f.WriteLine(100); //SatietyStatus
                    f.WriteLine(0); //AutoEating
                    f.WriteLine(1); //Day
                    f.Close();
                    MessageBox.Show("Персонаж создан!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка создания", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NewCharacter_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = (Char)e.KeyChar;
            if (Char.IsLetter(ch) || Char.IsControl(ch)) 
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
