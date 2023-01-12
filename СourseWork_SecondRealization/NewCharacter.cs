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
    public partial class NewCharacter : Form //Форма создания персонажа
    {
        public NewCharacter()
        {
            InitializeComponent();
        }

        private void checkBoxman_CheckedChanged(object sender, EventArgs e) //Выбор пола (М) по флажку
        {
            if (this.checkBoxman.Checked == true)
                this.checkBoxwoman.Checked = false;
        }

        private void checkBoxwoman_CheckedChanged(object sender, EventArgs e) //Выбор пола (Ж) по флажку
        {
            if (this.checkBoxwoman.Checked == true)
                this.checkBoxman.Checked = false;
        }

        private void createbutton_Click(object sender, EventArgs e) //Формирование файла сохранения по кнопке
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
                    //
                    //В файле sava.save построчно хранится информация от персонаже
                    //
                    f.WriteLine(this.textBoxname.Text); //Имя
                    //Пол
                    if (this.checkBoxman.Checked == true)
                    {
                        f.WriteLine("М");
                    }
                    else
                    {
                        f.WriteLine("Ж");
                    }
                    f.WriteLine(this.comboBoxage.Text); //Возраст
                    f.WriteLine(100); //Balance
                    f.WriteLine(this.numericUpDownweight.Text); //Вес
                    f.WriteLine(this.numericUpDownheight.Text); //Рост
                    f.WriteLine(100); //HealthStatus
                    f.WriteLine(0); //InfinityHealth
                    f.WriteLine("Раздача листовок"); //Наименование работы
                    f.WriteLine(10); //Payment
                    f.WriteLine("Кофта"); //Верх одежды
                    f.WriteLine("Джинсы"); //Штаны
                    f.WriteLine("Кроссовки"); //Джинсы
                    f.WriteLine(100); //ClothesStatus
                    f.WriteLine(0); //AutoSewUp
                    f.WriteLine("Гараж"); //Недвижимость
                    f.WriteLine("Велик"); //Транспортное средство
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

        private void NewCharacter_FormClosed(object sender, FormClosedEventArgs e) //Возврат в форму главного меню при закрытии данной формы
        {
            this.Owner.Show();
        }

        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e) //Защита на ввод в текстовом поле имени персонажа
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
