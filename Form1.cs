using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Form1 : Form
    {
        public Question CurrentQuestion;
        Button button;
        public int Level { get; set; }
        List<Label> labels;
        int timerCounter;
        bool IsHelpFromCall;
        bool IsHelpFiftyPercent;
        bool IsHelpFromPeople;
        SoundPlayer player;
        public bool isRightAnswer = true;
        public event EventHandler<EventArgs> Answer;
        public event EventHandler<EventArgs> Win;
        public event EventHandler<EventArgs> Start;
        public event EventHandler<EventArgs> AddQuestion;
        public event EventHandler<EventArgs> EditQuesyion;
        public event EventHandler<EventArgs> RemoveQuestion;
        public event EventHandler<EventArgs> ShowQuestion;
        public event EventHandler<EventArgs> ShowWinners;
        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayer();
            DisebledButtons();
            labels = new List<Label> { label1, label2, label3,
                                       label4, label5, label6,
                                       label7, label8, label9,
                                       label10, label11, label12,
                                       label13, label14, label15 };
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPlayer("begin.wav");
            Start?.Invoke(this, EventArgs.Empty);
            if (CurrentQuestion != null)
                IsStart();
        }

        private void winnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            ShowWinners?.Invoke(this, EventArgs.Empty);
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            AddQuestion?.Invoke(this, EventArgs.Empty);
        }

        private void editQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            EditQuesyion?.Invoke(this, EventArgs.Empty);
        }

        private void removeQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            RemoveQuestion?.Invoke(this, EventArgs.Empty);
        }

        private void showQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            ShowQuestion?.Invoke(this, EventArgs.Empty);
        }

        private void button_Click(object sender, EventArgs e)
        {
            player.Stop();
            if (Level < 15)
            {
                button = sender as Button;
                if (button.Text == CurrentQuestion.rightAnswer)
                {
                    StartPlayer("true.wav");
                }
                else
                {
                    StartPlayer("false.wav");
                }
                AnswerProcessing();
                DisebledButtons();
                if (IsHelpFromPeople == false)
                    chart1.Visible = false;
                if (IsHelpFromCall == false)
                {
                    DruzFoto.Visible = false;
                    DruzAnswer.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StartPlayer("summa.wav");
            Thread.Sleep(2000);
            HelpFiftyPercentProcessing();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartPlayer("zvonok.wav");
            Thread.Sleep(2300);
            HelpFromCallProcessing();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!IsHelpFiftyPercent && (!button1.Enabled || !button2.Enabled ||
                                        !button4.Enabled || !button3.Enabled))
            {
                StartPlayer("zal.wav");
                HelpFromPeopleProcessingAfterHelpFiftyPercent();
            }
            else
            {
                StartPlayer("zal.wav");
                HelpFromPeopleProcessing();
            }
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствуем вас на игре «Кто хочет стать миллионером?»!!!\n" +
                            "Представляемая нами игра вот уже почти 14 лет пользуется широкой популярностью во всём мире.\n" +
                            "С одинаковым удовольствием в игру «Кто хочет стать миллионером?» играет, и молодёжь, и старшее поколение.\n" +
                            "Вы получите настоящее удовольствие и массу позитивных эмоций, попробовав себя в роли игрока.\n" +
                            "Чтобы присоединится к игре, достаточно собраться с мыслями и дать ответы на 15 предложенных вопросов.\n" +
                            "Вопросы подразделяются по уровням сложности, и правильные ответы увеличивают счёт игрока на соответствующую сумму рублей.\n" +
                            "Ответ на простой вопрос приносит от 100 до 1000, на вопрос средней сложности – от 2000 до 32000,\n" +
                            "на вопрос повышенной сложности – от 64000 до 1000000.Готовы ? Тогда вперед!Попробуйте заработать первый миллион рублей своим умом!\n" +
                            "И помните, Ваш интеллект - это первый шаг к реальному богатству. Имена «миллионеров» размещаются в меню «Winners» игры «Кто хочет стать миллионером ?\n" +
                            "Приятной и успешной игры!");
        }

        public void PrintQuestion()
        {
            Random random = new Random();
            string[] mas = new string[] { "", "", "", "" };
            for (int i = 0; i < 4;)
            {
                int j = random.Next(0, 4);
                if (i == 0 && mas[j] == "")
                {
                    mas[j] = CurrentQuestion.rightAnswer;
                    i++;
                }

                if (i == 1 && mas[j] == "")
                {
                    mas[j] = CurrentQuestion.Answer1;
                    i++;
                }
                if (i == 2 && mas[j] == "")
                {
                    mas[j] = CurrentQuestion.Answer2;
                    i++;
                }
                if (i == 3 && mas[j] == "")
                {
                    mas[j] = CurrentQuestion.Answer3;
                    i++;
                }
            }
            button1.Text = mas[0];
            button2.Text = mas[1];
            button3.Text = mas[2];
            button4.Text = mas[3];
            label16.Text = CurrentQuestion.Title;
        }

        private void AnswerProcessing()
        {
            if (timer1.Enabled == false)
                timer1.Start();

        }

        private void SetGreenButton()
        {
            if (button1.Text == CurrentQuestion.rightAnswer)
            {
                button1.FlatStyle = FlatStyle.Standard;
                button1.BackColor = Color.Green;
            }
            if (button2.Text == CurrentQuestion.rightAnswer)
            {
                button2.FlatStyle = FlatStyle.Standard;
                button2.BackColor = Color.Green;
            }
            if (button3.Text == CurrentQuestion.rightAnswer)
            {
                button3.FlatStyle = FlatStyle.Standard;
                button3.BackColor = Color.Green;
            }
            if (button4.Text == CurrentQuestion.rightAnswer)
            {
                button4.FlatStyle = FlatStyle.Standard;
                button4.BackColor = Color.Green;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button.Text == CurrentQuestion.rightAnswer)
            {
                button.FlatStyle = FlatStyle.Standard;
                if (timerCounter % 2 == 0)
                    button.BackColor = Color.Green;
                else
                    button.BackColor = Color.LimeGreen;
                timerCounter++;
                if (timerCounter == 11)
                {
                    timer1.Stop();
                    timerCounter = 0;
                    if (isRightAnswer)
                    {
                        ChangeLevel();
                        if (Level < 15)
                        {
                            Answer?.Invoke(this, EventArgs.Empty);
                            PrintQuestion();
                        }
                        else
                        {
                            StartPlayer("winner.wav");
                            AddWinner();
                        }
                    }
                }
                isRightAnswer = true;
            }
            else
            {
                button.FlatStyle = FlatStyle.Standard;
                if (timerCounter % 2 == 0)
                    button.BackColor = Color.Red;
                else
                    button.BackColor = Color.OrangeRed;
                timerCounter++;
                if (timerCounter == 11)
                {
                    timer1.Stop();
                    timerCounter = 0;
                    labels[Level].Text = "";
                    Level = 0;
                }
                SetGreenButton();
                isRightAnswer = false;
                IsEnd();
            }
        }

        private void SetDefaultConfiguration()
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.Text = "";
            button1.Enabled = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.Text = "";
            button2.Enabled = true;
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.Text = "";
            button3.Enabled = true;
            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.Text = "";
            button4.Enabled = true;
            if (IsHelpFromPeople)
            {
                button5.Enabled = true;
                button5.BackgroundImage = null;
            }
            if (IsHelpFromCall)
            {
                button6.Enabled = true;
                button6.BackgroundImage = null;
            }
            if (IsHelpFiftyPercent)
            {
                button7.Enabled = true;
                button7.BackgroundImage = null;
            }
        }

        private void ChangeLevel()
        {
            if (isRightAnswer)
            {
                labels[Level].Text = "";
                Level++;
                if (Level < 15)
                    labels[Level].Text = "===>";
                isRightAnswer = false;
                SetDefaultConfiguration();
            }
        }

        private void IsStart()
        {
            startToolStripMenuItem.Enabled = false;
            winnersToolStripMenuItem.Enabled = false;
            editQuestionToolStripMenuItem.Enabled = false;
            addQuestionToolStripMenuItem.Enabled = false;
            removeQuestionToolStripMenuItem.Enabled = false;
            showQuestionToolStripMenuItem.Enabled = false;
            aboutGameToolStripMenuItem.Enabled = false;
            Level = 0;
            timerCounter = 0;
            IsHelpFromCall = true;
            IsHelpFiftyPercent = true;
            IsHelpFromPeople = true;
            chart1.Series["Statistic"].Points.Clear();
            SetDefaultConfiguration();
            PrintQuestion();
            labels[Level].Text = "===>";
        }

        private void IsEnd()
        {
            startToolStripMenuItem.Enabled = true;
            winnersToolStripMenuItem.Enabled = true;
            editQuestionToolStripMenuItem.Enabled = true;
            addQuestionToolStripMenuItem.Enabled = true;
            removeQuestionToolStripMenuItem.Enabled = true;
            showQuestionToolStripMenuItem.Enabled = true;
            aboutGameToolStripMenuItem.Enabled = true;
        }

        private void DisebledButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void HelpFromPeopleProcessing()
        {
            chart1.BackColor = Color.LightYellow;
            Random random = new Random();
            int a, b, c, d;
            if (Level < 5)
            {
                b = random.Next(1, 25);
                c = random.Next(1, 26);
                d = random.Next(1, 25);
                a = 100 - d - b - c;
                if (button1.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(a, b, c, d);
                if (button2.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, a, c, d);
                if (button3.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, c, a, d);
                if (button4.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, c, d, a);
            }

            if (Level > 4 && Level < 10)
            {
                a = random.Next(30, 35);
                b = random.Next(1, (100 - a) / 3 + 3);
                c = random.Next(1, (100 - a - b) / 2);
                d = 100 - a - b - c;
                if (button1.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(a, b, c, d);
                if (button2.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, a, c, d);
                if (button3.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, c, a, d);
                if (button4.Text == CurrentQuestion.rightAnswer)
                    FillDiagram(b, c, d, a);
            }

            if (Level >= 10)
            {
                a = random.Next(1, 36);
                b = random.Next(1, (100 - a) / 3 + 3);
                c = random.Next(1, (100 - a - b) / 2);
                d = 100 - a - b - c;
                FillDiagram(a, b, c, d);
            }
        }

        private void HelpFromPeopleProcessingAfterHelpFiftyPercent()
        {
            chart1.BackColor = Color.LightYellow;
            Random random = new Random();
            string column1 = "";
            string column2 = "";
            bool firstA = false;
            int a, b;
            if (Level < 5)
            {
                b = random.Next(1, 25);
                a = 100 - b;
                GetNameEnableButton(ref column1, ref column2, ref firstA);
                if (firstA)
                    FillDiagramAfterHelpFiftyPercent(a, b, column1, column2);
                else
                    FillDiagramAfterHelpFiftyPercent(b, a, column1, column2);
            }

            if (Level > 4 && Level < 10)
            {
                a = random.Next(20, 80);
                b = 100 - a;
                GetNameEnableButton(ref column1, ref column2, ref firstA);
                if (firstA)
                    FillDiagramAfterHelpFiftyPercent(a, b, column1, column2);
                else
                    FillDiagramAfterHelpFiftyPercent(b, a, column1, column2);
            }

            if (Level >= 10)
            {
                a = random.Next(5, 85);
                b = 100 - a;
                GetNameEnableButton(ref column1, ref column2, ref firstA);
                if (firstA)
                    FillDiagramAfterHelpFiftyPercent(a, b, column1, column2);
                else
                    FillDiagramAfterHelpFiftyPercent(b, a, column1, column2);
            }
        }

        private void HelpFromCallProcessing()
        {
            if (Level < 5)
            {
                CallProcessing("druz1.jpg", "Даже мой кот это знает! Это же ", CurrentQuestion.rightAnswer);
            }

            else if (Level > 4 && Level < 10)
            {
                int happening;
                happening = GetRand(11);
                switch (happening)
                {
                    case 1:
                        CallProcessing("druz2.jpg", "Илья Бер сказал, что это ", CurrentQuestion.Answer1);
                        break;
                    case 2:
                        CallProcessing("druz2.jpg", "Илья Бер сказал, что это ", CurrentQuestion.Answer2);
                        break;
                    case 3:
                        CallProcessing("druz2.jpg", "Илья Бер сказал, что это ", CurrentQuestion.Answer3);
                        break;
                    default:
                        CallProcessing("druz2.jpg", "Илья Бер сказал, что это ", CurrentQuestion.rightAnswer);
                        break;
                }
            }

            else
            {
                int happening;
                happening = GetRand(6);
                switch (happening)
                {
                    case 1:
                        CallProcessing("druz3.jpg", "Да пес его знает! Думаю, что это ", CurrentQuestion.Answer1);
                        break;
                    case 2:
                        CallProcessing("druz3.jpg", "Да пес его знает! Думаю, что это ", CurrentQuestion.Answer2);
                        break;
                    case 3:
                        CallProcessing("druz3.jpg", "Да пес его знает! Думаю, что это ", CurrentQuestion.Answer3);
                        break;
                    default:
                        CallProcessing("druz3.jpg", "Да пес его знает! Думаю, что это ", CurrentQuestion.rightAnswer);
                        break;
                }
            }
        }

        private void HelpFiftyPercentProcessing()
        {
            button7.Enabled = false;
            button7.BackgroundImage = Image.FromFile(@"percent.jpg");
            IsHelpFiftyPercent = false;
            int hap = 0;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                bool AllIsGood = false;
                while (!AllIsGood)
                {
                    hap = random.Next(1, 4);
                    switch (hap)
                    {
                        case 1:
                            PercentProcessing(CurrentQuestion.Answer1, ref AllIsGood);
                            break;
                        case 2:
                            PercentProcessing(CurrentQuestion.Answer2, ref AllIsGood);
                            break;
                        case 3:
                            PercentProcessing(CurrentQuestion.Answer3, ref AllIsGood);
                            break;
                    }
                }
            }
        }

        private void FillDiagram(int a, int b, int c, int d)
        {
            button5.Enabled = false;
            chart1.Series["Statistic"].Points.AddXY("A", a);
            chart1.Series["Statistic"].Points.AddXY("B", b);
            chart1.Series["Statistic"].Points.AddXY("C", c);
            chart1.Series["Statistic"].Points.AddXY("D", d);
            chart1.Visible = true;
            button5.BackgroundImage = Image.FromFile(@"people.jpg");
            IsHelpFromPeople = false;
        }

        private void FillDiagramAfterHelpFiftyPercent(int a, int b, string column1, string column2)
        {
            button5.Enabled = false;
            chart1.Series["Statistic"].Points.AddXY(column1, a);
            chart1.Series["Statistic"].Points.AddXY(column2, b);
            chart1.Visible = true;
            button5.BackgroundImage = Image.FromFile(@"people.jpg");
            IsHelpFromPeople = false;
        }

        private void CallProcessing(string image, string text, string answer)
        {
            button6.Enabled = false;
            button6.BackgroundImage = Image.FromFile(@"phone.jpg");
            DruzFoto.Image = Image.FromFile(image);
            DruzFoto.Visible = true;
            DruzAnswer.Text = text + answer + "!!!";
            IsHelpFromCall = false;
        }

        private int GetRand(int val)
        {
            bool AllIsGood = false;
            int hap = 0;
            Random random = new Random();
            while (!AllIsGood)
            {
                hap = random.Next(val);
                switch (hap)
                {
                    case 1:
                        if (button1.Text == CurrentQuestion.Answer1 || button2.Text == CurrentQuestion.Answer1 ||
                            button3.Text == CurrentQuestion.Answer1 || button4.Text == CurrentQuestion.Answer1)
                            AllIsGood = true;
                        break;
                    case 2:
                        if (button1.Text == CurrentQuestion.Answer2 || button2.Text == CurrentQuestion.Answer2 ||
                            button3.Text == CurrentQuestion.Answer2 || button4.Text == CurrentQuestion.Answer2)
                            AllIsGood = true;
                        break;
                    case 3:
                        if (button1.Text == CurrentQuestion.Answer3 || button2.Text == CurrentQuestion.Answer3 ||
                            button3.Text == CurrentQuestion.Answer3 || button4.Text == CurrentQuestion.Answer3)
                            AllIsGood = true;
                        break;
                    default:
                        AllIsGood = true;
                        break;
                }
            }
            return hap;
        }

        private void PercentProcessing(string str, ref bool AllIsGood)
        {
            if (button1.Text == str)
            {
                button1.Text = "";
                button1.Enabled = false;
                AllIsGood = true;
            }
            if (button2.Text == str)
            {
                button2.Text = "";
                button2.Enabled = false;
                AllIsGood = true;
            }
            if (button3.Text == str)
            {
                button3.Text = "";
                button3.Enabled = false;
                AllIsGood = true;
            }
            if (button4.Text == str)
            {
                button4.Text = "";
                button4.Enabled = false;
                AllIsGood = true;
            }
        }

        private void GetNameEnableButton(ref string column1, ref string column2, ref bool firstA)
        {
            if (button1.Enabled)
            {
                column1 = "A";
                if (button1.Text == CurrentQuestion.rightAnswer)
                    firstA = true;
            }
            if (button2.Enabled)
            {
                if (column1 == "")
                {
                    column1 = "B";
                    if (button2.Text == CurrentQuestion.rightAnswer)
                        firstA = true;
                }
                else
                    column2 = "B";
            }
            if (button3.Enabled)
            {
                if (column1 == "")
                {
                    column1 = "C";
                    if (button3.Text == CurrentQuestion.rightAnswer)
                        firstA = true;
                }
                else
                    column2 = "C";
            }
            if (button4.Enabled)
                column2 = "D";
        }

        private void AddWinner()
        {
            Win?.Invoke(this, EventArgs.Empty);
            SetDefaultConfiguration();
            IsEnd();
            DisebledButtons();
        }

        private void StartPlayer(string pl)
        {
            player.Stop();
            player = new SoundPlayer(pl);
            player.Play();
        }
    }
}
