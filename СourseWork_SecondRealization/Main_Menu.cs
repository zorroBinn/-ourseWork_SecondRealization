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
    public partial class Main_Menu : Form //Форма главного меню (начальная форма)
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void TextStartButtonSet() //Метод определения текста кнопки "Играть" в зависимости от наличия файла сохранения
        {
            try
            {
                StreamReader f = File.OpenText("save.save");
                for (int i = 0; i < 20; i++)
                {
                    f.ReadLine();
                }
                this.GameStartButton.Text = "Играть (День " + f.ReadLine() + ")";
                f.Close();
            }
            catch (Exception) 
            {
                MessageBox.Show("Файл сохранения повреждён или отсутствует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(File.Exists("save.save") == true)
                {
                    File.Delete("save.save");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) //Закрытие формы, завершение работы приложения по нажатию кнопки
        {
            this.Close();
        }

        private void AboutGameButton_Click(object sender, EventArgs e) //Отображение краткой справки об игре по нажатию кнопки
        {
            MessageBox.Show("Добро пожаловать в игру <<Life simulator>>(Симулятор жизни)!\nЗдесь вам предстоит пройти путь от безработного до мультимиллиардера!\nПокупка одежды, недвижимости и машин.\nВсегда следите за своим здоровьем и другими показателями!\nУдачи!", "Об игре", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveDeleteButton_Click(object sender, EventArgs e) //Удаление сохранения (при его наличии) по нажатию кнопки
        {
            if (File.Exists("save.save") == true)
            {
                DialogResult resuilt = MessageBox.Show("Вы уврены, что хотите удалить файл сохранения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resuilt== DialogResult.Yes)
                {
                    File.Delete("save.save");
                    MessageBox.Show("Сохранение удалено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GameStartButton.Text = "Начать игру";
                }
            }
        }

        private void GameStartButton_Click(object sender, EventArgs e) //Запуск формы игры или создания персонажа по нажатию кнопки
        {
            if (this.GameStartButton.Text == "Начать игру")
            {
                NewCharacter newcharacter = new NewCharacter();
                newcharacter.Owner = this;
                newcharacter.Show();
                this.Hide();
            }
            else
            {
                Game game = new Game();
                game.Owner = this;
                game.Show();
                this.Hide();
            }
        }

        private void Main_Menu_Activated(object sender, EventArgs e) //Действие при отображении формы
        {
            if (File.Exists("save.save") == true)
            {
                TextStartButtonSet();
            }
        }
    }
}
