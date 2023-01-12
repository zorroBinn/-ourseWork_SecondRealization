using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace СourseWork_SecondRealization
{
    public partial class Game : Form //Форма непосредственно игры
    {
        private Worker worker; //Персонаж (работник)
        private Int32 Day; //Игровой день
        public Game()
        {
            InitializeComponent();
            worker = new Worker();
            DataInitialization();
        }

        private void DataInitialization() //Считывание данных из файла сохранения, заполнение полей формы (при запуске формы)
        {
            if (File.Exists("save.save") == true)
            {
                try
                {
                    StreamReader f = File.OpenText("save.save");
                    //
                    //Построчное считывание данных из файла сохранения save.save
                    //
                    worker.SetName(f.ReadLine()); //Имя
                    worker.SetSex(f.ReadLine()); //Пол
                    worker.SetAge(Convert.ToInt32(f.ReadLine())); //Возраст
                    worker.SetMoneyBalance(Convert.ToInt32(f.ReadLine())); //Balance
                    worker.GetMedCard().SetWeight(Convert.ToInt32(f.ReadLine())); //Вес
                    worker.GetMedCard().SetHeight(Convert.ToInt32(f.ReadLine())); //Рост
                    worker.GetMedCard().SetHealthStatus(Convert.ToInt32(f.ReadLine())); //HealthStatus
                    //InfinityHealth
                    if (f.ReadLine() == "0")
                    {
                        worker.GetMedCard().SetInfinityHealth(false);
                    }
                    else
                    {
                        worker.GetMedCard().SetInfinityHealth(true);
                        this.autohealthbutton.BackColor = System.Drawing.Color.LimeGreen;
                    }
                    worker.SetNamework(f.ReadLine()); //Наименование работы
                    worker.SetPayment(Convert.ToInt32(f.ReadLine())); //Payment
                    worker.GetClothes().SetBody(f.ReadLine()); //Верх одежды
                    worker.GetClothes().SetPants(f.ReadLine()); //Штаны
                    worker.GetClothes().SetShoes(f.ReadLine()); //Обувь
                    worker.GetClothes().SetClothesStatus(Convert.ToInt32(f.ReadLine())); //ClothesStatus
                    //AutoSewUp
                    if (f.ReadLine() == "0")
                    {
                        worker.GetClothes().SetAutoSewUp(false);
                    }
                    else
                    {
                        worker.GetClothes().SetAutoSewUp(true);
                        this.autosewupbutton.BackColor = System.Drawing.Color.LimeGreen;
                    }
                    worker.GetRealty().SetHousing(f.ReadLine()); //Недвижимость
                    worker.GetRealty().SetVehicle(f.ReadLine()); //Транспортное средство
                    worker.SetLevel(Convert.ToInt32(f.ReadLine())); //Level
                    worker.GetFood().SetSatietyStatus(Convert.ToInt32(f.ReadLine())); //SatietyStatus
                    //AutoEating
                    if (f.ReadLine() == "0")
                    {
                        worker.GetFood().SetAutoEating(false);
                    }
                    else
                    {
                        worker.GetFood().SetAutoEating(true);
                        this.autoeatbutton.BackColor = System.Drawing.Color.LimeGreen;
                    }
                    Day = Convert.ToInt32(f.ReadLine()); //Day
                    f.Close();

                    SatietyUpdating();
                    MoneyBalanceUpdating();
                    HealthUpdating();
                    if (worker.GetClothes().GetPants() == "Брюки")
                    {
                        this.buttonsewup.Text = "Починить одежду(10$)";
                    }
                    this.infoname.Text = worker.GetName();
                    this.infoday.Text = Convert.ToString(Day);
                    this.dataGridViewclothes.Rows.Add();
                    this.dataGridViewclothes.Rows.Add();
                    this.dataGridViewclothes.Rows.Add();
                    this.dataGridViewclothes.Rows.Add();
                    this.dataGridViewclothes.Rows[0].Cells[0].Value = "Верх";
                    this.dataGridViewclothes.Rows[1].Cells[0].Value = "Штаны";
                    this.dataGridViewclothes.Rows[2].Cells[0].Value = "Обувь";
                    this.dataGridViewclothes.Rows[3].Cells[0].Value = "Состояние одежды";
                    this.dataGridViewclothes.Rows[0].Cells[1].Value = worker.GetClothes().GetBody();
                    this.dataGridViewclothes.Rows[1].Cells[1].Value = worker.GetClothes().GetPants();
                    this.dataGridViewclothes.Rows[2].Cells[1].Value = worker.GetClothes().GetShoes();
                    this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                    this.humanname.Text = worker.GetName();
                    this.humansex.Text = worker.GetSex();
                    this.humanage.Text = Convert.ToString(worker.GetAge());
                    if (worker.GetClothes().GetShoes() == "Туфли")
                    {
                        this.buysuitbutton.Visible = false;
                    }
                    this.mdname.Text = worker.GetName();
                    this.mdweight.Text = Convert.ToString(worker.GetMedCard().GetWeight());
                    this.mdheight.Text = Convert.ToString(worker.GetMedCard().GetHeight());
                    Double IMT = (worker.GetMedCard().GetWeight() + 0.0) / (worker.GetMedCard().GetHeight() * worker.GetMedCard().GetHeight() / 10000);
                    this.imt.Text = Convert.ToString(IMT);
                    if (IMT < 18.5)
                    {
                        this.imtcomment.Text = "Ниже нормы";
                    }
                    else if (IMT > 26.0)
                    {
                        this.imtcomment.Text = "Выше нормы";
                    }
                    else
                    {
                        this.imtcomment.Text = "Норма";
                    }
                    this.realtyhouse.Text = worker.GetRealty().GetHousing();
                    RealtyInitialization();
                    this.realtycar.Text = worker.GetRealty().GetVehicle();
                    this.workername.Text = worker.GetName();
                    this.Namework.Text = worker.GetNamework();
                    this.payment.Text = Convert.ToString(worker.GetPayment());
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалость загрузить сохранение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (File.Exists("save.save") == true)
                    {
                        File.Delete("save.save");
                    }
                    this.Owner.Show();
                    this.Close();
                }
            }
        }

        private void RealtyInitialization() //Возможность покупки нового имущества в зависимости от текущего
        {
            if (worker.GetRealty().GetHousing() == "Квартира")
            {
                this.comboBoxrealtyhouse.Items.Clear();
                this.comboBoxrealtyhouse.Items.AddRange(new object[] {
                "Коттедж (120 000$)",
                "Вилла (350 000$)"});
            }
            if (worker.GetRealty().GetHousing() == "Коттедж")
            {
                this.comboBoxrealtyhouse.Items.Clear();
                this.comboBoxrealtyhouse.Items.AddRange(new object[] {
                "Квартира (50 000$)",
                "Вилла (350 000$)"});
            }
            if (worker.GetRealty().GetHousing() == "Вилла")
            {
                this.comboBoxrealtyhouse.Items.Clear();
                this.comboBoxrealtyhouse.Items.AddRange(new object[] {
                "Квартира (50 000$)",
                "Коттедж (120 000$)"});
            }
            if (worker.GetRealty().GetVehicle() == "Мотоцикл")
            {
                this.comboBoxrealtycar.Items.Clear();
                this.comboBoxrealtycar.Items.AddRange(new object[] {
                "Автомобиль (10 000$)",
                "Спорткар (150 000$)"});
            }
            if (worker.GetRealty().GetVehicle() == "Автомобиль")
            {
                this.comboBoxrealtycar.Items.Clear();
                this.comboBoxrealtycar.Items.AddRange(new object[] {
                "Мотоцикл (3 500$)",
                "Спорткар (150 000$)"});
            }
            if (worker.GetRealty().GetVehicle() == "Спорткар")
            {
                this.comboBoxrealtycar.Items.Clear();
                this.comboBoxrealtycar.Items.AddRange(new object[] {
                "Мотоцикл (3 500$)",
                "Автомобиль (10 000$)"});
            }
        }

        private void DayUpdating() //Обновление дня, подарок в случае дня рождения
        {
            this.Day++;
            this.infoday.Text = Convert.ToString(Day);
            if (Day >= 365 && Day % 365 == 0)
            {
                if (worker.GetLevel() == 0)
                {
                    MessageBox.Show("Сегодня ваш день рождения!\nПримите в подарок эту скромную сумму:\n+1 000$", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    worker.ChangeMoney(1000);
                }
                else if (worker.GetLevel() == 1)
                {
                    MessageBox.Show("Сегодня ваш день рождения!\nПримите в подарок эту скромную сумму:\n+3 000$", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    worker.ChangeMoney(5000);
                }
                else if (worker.GetLevel() == 2)
                {
                    MessageBox.Show("Сегодня ваш день рождения!\nПримите в подарок эту скромную сумму:\n+7 000$", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    worker.ChangeMoney(10000);
                }
                else
                {
                    MessageBox.Show("Сегодня ваш день рождения!\nПримите в подарок эту скромную сумму:\n+20 000$", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    worker.ChangeMoney(25000);
                }
                MoneyBalanceUpdating();
                worker.SetAge(worker.GetAge() + 1);
                this.humanage.Text = Convert.ToString(worker.GetAge());
            }
        }

        private void MoneyBalanceUpdating() //Обновлнеие полей формы, отображающих игровой баланс
        {
            this.infomoneybalance.Text = Convert.ToString(worker.GetMoneybalance());
            this.humanbalance.Text = Convert.ToString(worker.GetMoneybalance());
        }

        private void SatietyUpdating() //Обновление полей формы, отображающих статус сытости
        {
            this.infosatietypercent.Text = Convert.ToString(worker.GetFood().GetSatietyStatus());
            this.satiety.Text = Convert.ToString(worker.GetFood().GetSatietyStatus());
        }

        void HealthUpdating() //Обновление полей формы, отображающих статус здоровья
        {
            this.infohealthpercent.Text = Convert.ToString(worker.GetMedCard().GetHealthStatus());
            this.health.Text = Convert.ToString(worker.GetMedCard().GetHealthStatus());
        }

        private void LevelUp() //Повышение уровня персонажа (определение нового рабочего места и оплаты)
        {
            if (worker.GetMoneybalance() > 1000000 && worker.GetLevel() < 7)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Магнат");
                worker.SetPayment(10000);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 500000 && worker.GetLevel() < 6)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Глава франшизы");
                worker.SetPayment(2400);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 100000 && worker.GetLevel() < 5)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Бизнесмен");
                worker.SetPayment(700);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 50000 && worker.GetLevel() < 4)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Директор магазина");
                worker.SetPayment(250);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 10000 && worker.GetLevel() < 3)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Заведующий");
                worker.SetPayment(150);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 5000 && worker.GetLevel() < 2)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Глава отдела");
                worker.SetPayment(60);
                UpdatingLevelUp();
            }
            if (worker.GetMoneybalance() > 1000 && worker.GetLevel() < 1)
            {
                MessageBox.Show("С повышением!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worker.SetNamework("Кассир");
                worker.SetPayment(25);
                UpdatingLevelUp();
            }
        }

        private void UpdatingLevelUp() //Полвышение уровня работника, обновление полей работы
        {
            worker.LevelUp();
            this.Namework.Text = worker.GetNamework();
            this.payment.Text = Convert.ToString(worker.GetPayment());
        }

        private void GameSave() //Сохранение игры
        {
            try
            {
                StreamWriter f = new StreamWriter("save.save", false);
                //
                //В файле sava.save построчно хранится информация от персонаже
                //
                f.WriteLine(worker.GetName());
                f.WriteLine(worker.GetSex());
                f.WriteLine(worker.GetAge());
                f.WriteLine(worker.GetMoneybalance());
                f.WriteLine(worker.GetMedCard().GetWeight());
                f.WriteLine(worker.GetMedCard().GetHeight());
                f.WriteLine(worker.GetMedCard().GetHealthStatus());
                if (worker.GetMedCard().GetInfinityHealth() == true)
                {
                    f.WriteLine(1);
                }
                else
                {
                    f.WriteLine(0);
                }
                f.WriteLine(worker.GetNamework());
                f.WriteLine(worker.GetPayment());
                f.WriteLine(worker.GetClothes().GetBody());
                f.WriteLine(worker.GetClothes().GetPants());
                f.WriteLine(worker.GetClothes().GetShoes());
                f.WriteLine(worker.GetClothes().GetClothesStatus());
                if (worker.GetClothes().GetAutoSewUp() == true)
                {
                    f.WriteLine(1);
                }
                else
                {
                    f.WriteLine(0);
                }
                f.WriteLine(worker.GetRealty().GetHousing());
                f.WriteLine(worker.GetRealty().GetVehicle());
                f.WriteLine(worker.GetLevel());
                f.WriteLine(worker.GetFood().GetSatietyStatus());
                if (worker.GetFood().GetAutoEating() == true)
                {
                    f.WriteLine(1);
                }
                else
                {
                    f.WriteLine(0);
                }
                f.WriteLine(Day);
                f.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось провести сохранение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean GameLoss() //Проверка условий проигрыша
        {
            bool lossrate = false;
            while (lossrate == false)
            {
                if (worker.GetClothes().GetClothesStatus() == 0 && worker.GetClothes().GetPants() == "Брюки" && worker.GetMoneybalance() < 10)
                {
                    MessageBox.Show("Ваш костюм износился и вам не хватает денег его починить!\nБыла возвращена старая одежда.", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    worker.GetClothes().SetRegularClothes();
                    this.dataGridViewclothes.Rows[0].Cells[1].Value = worker.GetClothes().GetBody();
                    this.dataGridViewclothes.Rows[1].Cells[1].Value = worker.GetClothes().GetPants();
                    this.dataGridViewclothes.Rows[2].Cells[1].Value = worker.GetClothes().GetShoes();
                    this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                    this.buysuitbutton.Visible = true;
                }
                if (worker.GetClothes().GetClothesStatus() == 0 && worker.GetClothes().GetPants() != "Брюки" && worker.GetMoneybalance() < 5)
                {
                    lossrate = true;
                    MessageBox.Show("Игра окончена!\nПричины проигрыша: невозможность починить одежду", "Очень жаль...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                if (worker.GetFood().GetSatietyStatus() == 0 && worker.GetMoneybalance() < 5)
                {
                    lossrate = true;
                    MessageBox.Show("Игра окончена!\nПричины проигрыша: невозможность утолить голод", "Очень жаль...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                if (worker.GetMedCard().GetHealthStatus() == 0 && worker.GetMoneybalance() < 10)
                {
                    lossrate = true;
                    MessageBox.Show("Игра окончена!\nПричины проигрыша: невозможность лечения", "Очень жаль...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                break;
            }
            if (lossrate == true)
            {
                MessageBox.Show("Результат:\nДостигнутый день: " + Day, "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void персонажToolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации о персонаже по кнопке
        {
            this.groupBoxworker.Visible = false;
            this.groupBoxfood.Visible = false;
            this.groupBoxclothes.Visible = false;
            this.groupBoxmd.Visible = false;
            this.groupBoxrealty.Visible = false;
            this.groupBoxhuman.Visible = true;
        }

        private void здоровьеToolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации о медицинской карте по кнопке
        {
            this.groupBoxhuman.Visible = false;
            this.groupBoxfood.Visible = false;
            this.groupBoxworker.Visible = false;
            this.groupBoxclothes.Visible = false;
            this.groupBoxrealty.Visible = false;
            this.groupBoxmd.Visible = true;
        }

        private void имуществоToolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации об имуществе по кнопке
        {
            this.groupBoxhuman.Visible = false;
            this.groupBoxfood.Visible = false;
            this.groupBoxworker.Visible = false;
            this.groupBoxmd.Visible = false;
            this.groupBoxclothes.Visible = false;
            this.groupBoxrealty.Visible = true;
        }

        private void работаToolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации о работе по кнопке
        {
            this.groupBoxhuman.Visible = false;
            this.groupBoxfood.Visible = false;
            this.groupBoxclothes.Visible = false;
            this.groupBoxmd.Visible = false;
            this.groupBoxrealty.Visible = false;
            this.groupBoxworker.Visible = true;
        }

        private void одеждаToolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации об одежде по кнопке
        {
            this.groupBoxhuman.Visible = false;
            this.groupBoxfood.Visible = false;
            this.groupBoxworker.Visible = false;
            this.groupBoxmd.Visible = false;
            this.groupBoxrealty.Visible = false;
            this.groupBoxclothes.Visible = true;
        }

        private void едаtoolStripMenuItem_Click(Object sender, EventArgs e) //Отображение информации о питании по кнопке
        {
            this.groupBoxfood.Visible = true;
            this.groupBoxrealty.Visible = false;
            this.groupBoxhuman.Visible = false;
            this.groupBoxworker.Visible = false;
            this.groupBoxmd.Visible = false;
            this.groupBoxclothes.Visible = false;
        }

        private void checkBoxhouse_CheckedChanged(Object sender, EventArgs e) //Выбор предложения недвижимости по флажку
        {
            if (this.checkBoxhouse.Checked == true)
            {
                this.comboBoxrealtyhouse.Visible = true;
                this.buybutton.Visible = true;
                this.checkBoxcar.Checked = false;
                this.comboBoxrealtycar.Visible = false;
            }
            else if (this.checkBoxhouse.Checked == false && this.checkBoxcar.Checked == true)
            {
                this.comboBoxrealtyhouse.Visible = false;
            }
            else
            {
                this.buybutton.Visible = false;
                this.comboBoxrealtycar.Visible = false;
            }
        }

        private void checkBoxcar_CheckedChanged(Object sender, EventArgs e) //Выбор предложения по транспортному средству по флажку
        {
            if (this.checkBoxcar.Checked == true)
            {
                this.buybutton.Visible = true;
                this.checkBoxhouse.Checked = false;
                this.comboBoxrealtyhouse.Visible = false;
                this.comboBoxrealtycar.Visible = true;
            }
            else if (this.checkBoxcar.Checked == false && this.checkBoxhouse.Checked == true)
            {
                this.comboBoxrealtycar.Visible = false;
            }
            else
            {
                this.buybutton.Visible = false;
                this.comboBoxrealtycar.Visible = false;
            }
        }

        private void Game_FormClosing(Object sender, FormClosingEventArgs e) //Действие при выходе из формы, возврат в форму главного меню
        {
            DialogResult result = MessageBox.Show("Вы уврены, что хотите выйти?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (worker.GetAge() != 0)
                {
                    GameSave();
                }
                this.Owner.Show();
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buysuitbutton_Click(Object sender, EventArgs e) //Покупка костюма по кнопке
        {
            if (worker.GetMoneybalance() >= 5000)
            {
                worker.GetClothes().BuySuit();
                this.dataGridViewclothes.Rows[0].Cells[1].Value = worker.GetClothes().GetBody();
                this.dataGridViewclothes.Rows[1].Cells[1].Value = worker.GetClothes().GetPants();
                this.dataGridViewclothes.Rows[2].Cells[1].Value = worker.GetClothes().GetShoes();
                this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                this.buysuitbutton.Visible = false;
                worker.ChangeMoney(-5000);
                MoneyBalanceUpdating();
                GameLoss();
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonsewup_Click(Object sender, EventArgs e) //Починка одежды по кнопке
        {
            if ((worker.GetMoneybalance() >= 5 && worker.GetClothes().GetPants() != "Брюки") || (worker.GetMoneybalance() >= 10 && worker.GetClothes().GetPants() == "Брюки"))
            {
                if (worker.GetClothes().GetClothesStatus() < 100)
                {
                    worker.GetClothes().SewUpClothes();
                    this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                    if (worker.GetClothes().GetPants() != "Брюки")
                    {
                        worker.ChangeMoney(-5);
                    }
                    else
                    {
                        worker.ChangeMoney(-10);
                    }
                    MoneyBalanceUpdating();
                    GameLoss();
                }
                else
                {
                    MessageBox.Show("Одежда как новенькая!", "Зачем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void workingbutton_Click(Object sender, EventArgs e) //Действие "Работать" по кнопке
        {
            if (GameLoss() == false)
            {
                Boolean WorkingCapacity = true;
                while (true)
                {
                    if (worker.GetMedCard().GetHealthStatus() == 0)
                    {
                        MessageBox.Show("Сейчас вы не можете работать!\nПроверьте состояние здоровья", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        WorkingCapacity = false;
                        break;
                    }
                    if (worker.GetClothes().GetClothesStatus() == 0)
                    {
                        MessageBox.Show("Сейчас вы не можете работать!\nПроверьте состояние одежды", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        WorkingCapacity = false;
                        break;
                    }
                    if (worker.GetFood().GetSatietyStatus() == 0)
                    {
                        MessageBox.Show("Сейчас вы не можете работать!\nПроверьте сытость", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        WorkingCapacity = false;
                        break;
                    }
                    break;
                }
                if (WorkingCapacity == true)
                {
                    worker.ChangeMoney(worker.GetPayment());
                    MoneyBalanceUpdating();
                    DayUpdating();
                    if (worker.GetClothes().GetAutoSewUp() != true)
                    {
                        worker.GetClothes().TearClothes();
                        this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                    }
                    if (worker.GetMedCard().GetInfinityHealth() != true)
                    {
                        worker.GetMedCard().DownStatus();
                        HealthUpdating();
                    }
                    if (worker.GetFood().GetAutoEating() != true)
                    {
                        worker.GetFood().DownSatietyStatus();
                        SatietyUpdating();
                    }
                    LevelUp();
                }
            }
        }

        private void healthbutton_Click(Object sender, EventArgs e) //Лечение по кнопке
        {
            if (worker.GetMoneybalance() >= 10)
            {
                if (worker.GetMedCard().GetHealthStatus() < 100)
                {
                    worker.GetMedCard().UpStatus();
                    worker.ChangeMoney(-10);
                    MoneyBalanceUpdating();
                    HealthUpdating();
                    GameLoss();
                }
                else
                {
                    MessageBox.Show("Вы как огурчик!", "Зачем ? ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buybutton_Click(Object sender, EventArgs e) //Покупка выбранного имущества по кнопке
        {
            if (this.checkBoxhouse.Checked == true)
            {
                if (this.comboBoxrealtyhouse.Text == "Квартира (50 000$)")
                {
                    if (worker.GetMoneybalance() >= 50000)
                    {
                        worker.GetRealty().SetHousing("Квартира");
                        worker.ChangeMoney(-50000);
                        RealtyInitialization();
                        this.realtyhouse.Text = worker.GetRealty().GetHousing();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (this.comboBoxrealtyhouse.Text == "Коттедж (120 000$)")
                {
                    if (worker.GetMoneybalance() >= 120000)
                    {
                        worker.GetRealty().SetHousing("Коттедж");
                        worker.ChangeMoney(-120000);
                        RealtyInitialization();
                        this.realtyhouse.Text = worker.GetRealty().GetHousing();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (this.comboBoxrealtyhouse.Text == "Вилла (350 000$)")
                {
                    if (worker.GetMoneybalance() >= 350000)
                    {
                        worker.GetRealty().SetHousing("Вилла");
                        worker.ChangeMoney(-350000);
                        RealtyInitialization();
                        this.realtyhouse.Text = worker.GetRealty().GetHousing();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (this.comboBoxrealtycar.Text == "Мотоцикл (3 500$)")
                {
                    if (worker.GetMoneybalance() >= 3500)
                    {
                        worker.GetRealty().SetVehicle("Мотоцикл");
                        worker.ChangeMoney(-3500);
                        RealtyInitialization();
                        this.realtycar.Text = worker.GetRealty().GetVehicle();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (this.comboBoxrealtycar.Text == "Автомобиль (10 000$)")
                {
                    if (worker.GetMoneybalance() >= 10000)
                    {
                        worker.GetRealty().SetVehicle("Автомобиль");
                        worker.ChangeMoney(-10000);
                        RealtyInitialization();
                        this.realtycar.Text = worker.GetRealty().GetVehicle();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (this.comboBoxrealtycar.Text == "Спорткар (150 000$)")
                {
                    if (worker.GetMoneybalance() >= 150000)
                    {
                        worker.GetRealty().SetVehicle("Спорткар");
                        worker.ChangeMoney(-150000);
                        RealtyInitialization();
                        this.realtycar.Text = worker.GetRealty().GetVehicle();
                        MoneyBalanceUpdating();
                        DayUpdating();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            GameLoss();
        }

        private void boostersbutton_Click(Object sender, EventArgs e) //Отображение меню бустеров по кнопке
        {
            if (this.groupBoxboosters.Visible == false)
            {
                this.groupBoxboosters.Visible = true;
            }
            else
            {
                this.groupBoxboosters.Visible = false;
            }
        }

        private void onefoodbutton_Click(System.Object sender, System.EventArgs e) //Первый вариант питания по кнопке (фастфуд)
        {
            if (worker.GetMoneybalance() >= 5)
            {
                if (worker.GetFood().GetSatietyStatus() < 100)
                {
                    worker.GetFood().UpSatietyStatus(20);
                    SatietyUpdating();
                    worker.ChangeMoney(-5);
                    MoneyBalanceUpdating();
                    GameLoss();
                }
                else
                {
                    MessageBox.Show("Вы абсолютно сытый!", "Зачем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void twofoodbutton_Click(System.Object sender, System.EventArgs e) //Второй вариант питания по кнопке (кафе)
        {
            if (worker.GetMoneybalance() >= 20)
            {
                if (worker.GetFood().GetSatietyStatus() < 100)
                {
                    worker.GetFood().UpSatietyStatus(40);
                    SatietyUpdating();
                    worker.ChangeMoney(-20);
                    MoneyBalanceUpdating();
                    GameLoss();
                }
                else
                {
                    MessageBox.Show("Вы абсолютно сытый!", "Зачем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void threebutton_Click(Object sender, EventArgs e) //Третий вариант питания по кнопке (ресторан)
        {
            if (worker.GetMoneybalance() >= 100)
            {
                if (worker.GetFood().GetSatietyStatus() < 100)
                {
                    worker.GetFood().UpSatietyStatus(100);
                    SatietyUpdating();
                    worker.ChangeMoney(-100);
                    MoneyBalanceUpdating();
                    GameLoss();
                }
                else
                {
                    MessageBox.Show("Вы абсолютно сытый!", "Зачем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void autoeatbutton_Click(Object sender, EventArgs e) //Активания бустера "автопитание" по кнопке
        {
            if (worker.GetFood().GetAutoEating() == false)
            {
                if (worker.GetMoneybalance() >= 50000)
                {
                    DialogResult result = MessageBox.Show("Автоматическое восполнение сытости позволяет вам больше не беспокоиться о кормлении своего персонажа. Это действие нельзя будет отменить!", "Хотите приобрести антиголод?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.autoeatbutton.BackColor = System.Drawing.Color.LimeGreen;
                        worker.GetFood().SetAutoEating(true);
                        worker.ChangeMoney(-50000);
                        SatietyUpdating();
                        MoneyBalanceUpdating();
                        GameLoss();
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void autosewupbutton_Click(Object sender, EventArgs e) //Активация бустера "автопочинка одежды" по кнопке
        {
            if (worker.GetClothes().GetAutoSewUp() == false)
            {
                if (worker.GetMoneybalance() >= 100000)
                {
                    DialogResult result = MessageBox.Show("Автоматическое починка одежды позволяет вам больше не беспокоиться о состоянии одежды своего персонажа. Это действие нельзя будет отменить!", "Хотите приобрести автопочинку одежды?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.autosewupbutton.BackColor = System.Drawing.Color.LimeGreen;
                        worker.GetClothes().SetAutoSewUp(true);
                        this.dataGridViewclothes.Rows[3].Cells[1].Value = worker.GetClothes().GetClothesStatus();
                        worker.ChangeMoney(-100000);
                        MoneyBalanceUpdating();
                        GameLoss();
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void autohealthbutton_Click(Object sender, EventArgs e) //Активация бустера "автолечение" по кнопке
        {
            if (worker.GetMedCard().GetInfinityHealth() == false)
            {
                if (worker.GetMoneybalance() >= 100000)
                {
                    DialogResult result = MessageBox.Show("Автоматическое лечение позволяет вам больше не беспокоиться о состоянии здоровья своего персонажа. Это действие нельзя будет отменить!", "Хотите приобрести автолечение?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.autohealthbutton.BackColor = System.Drawing.Color.LimeGreen;
                        worker.GetMedCard().SetInfinityHealth(true);
                        worker.ChangeMoney(-100000);
                        MoneyBalanceUpdating();
                        HealthUpdating();
                        GameLoss();
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточко денег!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ToolTipShow(Button buttonname, String text) //Определение(создание) новой всплывающей подсказки
        {
            ToolTip  t = new ToolTip();
            t.SetToolTip(buttonname, text);
            t.AutomaticDelay = 120;
        }

        private void onefoodbutton_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на первый вариант питания
        {
            ToolTipShow(onefoodbutton, "+20%");
        }

        private void twofoodbutton_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на второй вариант питания
        {
            ToolTipShow(twofoodbutton, "+40%");
        }

        private void threebutton_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на третий вариант питания
        {
            ToolTipShow(threebutton, "+100%");
        }

        private void healthbutton_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на лечение
        {
            ToolTipShow(healthbutton, "+35%");
        }

        private void buttonsewup_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на починку одежды
        {
            ToolTipShow(buttonsewup, "+20%");
        }

        private void buysuitbutton_MouseHover(Object sender, EventArgs e) //Всплывающая подсказка на покупку костюма
        {
            ToolTipShow(buysuitbutton, "Костюм меньше изнашивается");
        }
    }
}
