using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;

namespace Millionaire
{
    public class Presenter
    {
        Form1 form;
        Admin_menu AddingQuest;
        Edit_Remove_Question EditRemoveForm;
        Add_Winner addWinnerForm;
        Random random;
        public int CurrentLevel { get; set; }
        public Question AdminQuestion;
        List<Question> level1;
        List<Question> level2;
        List<Question> level3;
        Model model;
        public Presenter(Form1 f)
        {
            form = f;
            random = new Random();
            CurrentLevel = 0;
            level1 = new List<Question>();
            level2 = new List<Question>();
            level3 = new List<Question>();
            form.Answer += new EventHandler<EventArgs>(Answer);
            form.Start += new EventHandler<EventArgs>(Start);
            form.Win += new EventHandler<EventArgs>(Win);
            form.AddQuestion += new EventHandler<EventArgs>(AddQuestion);
            form.EditQuesyion += new EventHandler<EventArgs>(EditRemoveQuestion);
            form.RemoveQuestion += new EventHandler<EventArgs>(EditRemoveQuestion);
            form.ShowQuestion += new EventHandler<EventArgs>(EditRemoveQuestion);
            form.ShowWinners += new EventHandler<EventArgs>(ShowWinners);
        }

        private void Answer(object sender, EventArgs e)
        {
            form.CurrentQuestion = GetQuestion();
        }

        private void ShowWinners(object sender, EventArgs e)
        {
            Show_winners showWinnersForms = new Show_winners();
            try
            {
                using (Model mod = new Model())
                {
                    mod.winners.Load();
                    showWinnersForms.dataGridView1.DataSource = mod.winners.Local.ToBindingList();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            showWinnersForms.Show();
        }

        private void Start(object sender, EventArgs e)
        {
            if (CurrentLevel > 0)
            {
                CurrentLevel = 0;
                level1.Clear();
                level2.Clear();
                level3.Clear();
            }
            LoadQuestions();
            form.CurrentQuestion = GetQuestion();
        }

        private void Win(object sender, EventArgs e)
        {
            Add_Or_No_Winner winnerForm = new Add_Or_No_Winner();
            winnerForm.SaveWinner += new EventHandler<EventArgs>(AddWinnerProc);
            winnerForm.Show();
        }

        private void AddWinnerProc(object sender, EventArgs e)
        {
            addWinnerForm = new Add_Winner();
            addWinnerForm.SaveClick += new EventHandler<EventArgs>(AddWinner);
            addWinnerForm.Show();
        }

        private void AddWinner(object sender, EventArgs e)
        {
            try
            {
                using (Model mod = new Model())
                {
                    Winners winner = new Winners();
                    winner.FirstName = addWinnerForm.WinnerName;
                    winner.LatName = addWinnerForm.WinnerLastName;
                    winner.Date = DateTime.Now;
                    mod.winners.Add(winner);
                    mod.SaveChanges();
                    addWinnerForm.IsSave = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            AddingQuest = new Admin_menu();
            AddingQuest.Add += new EventHandler<EventArgs>(AddQuestionToDB);
            AddingQuest.Show();
        }

        private void AddQuestionToDB(object sender, EventArgs e)
        {
            try
            {
                using (Model mod = new Model())
                {
                    AdminQuestion = new Question();
                    AdminQuestion.Title = AddingQuest.Title;
                    AdminQuestion.rightAnswer = AddingQuest.RightAnsw;
                    AdminQuestion.Answer1 = AddingQuest.AnswB;
                    AdminQuestion.Answer2 = AddingQuest.AnswC;
                    AdminQuestion.Answer3 = AddingQuest.AnswD;
                    AdminQuestion.Level = AddingQuest.Level;
                    mod.questions.Add(AdminQuestion);
                    mod.SaveChanges();
                    MessageBox.Show("Question added successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EditRemoveQuestion(object sender, EventArgs e)
        {
            try
            {
                using (model = new Model())
                {
                    EditRemoveForm = new Edit_Remove_Question();
                    EditRemoveForm.LoadListOfQuestion(model.questions.ToList<Question>());
                    EditRemoveForm.Show();
                    EditRemoveForm.Click_Change += new EventHandler<EventArgs>(EditQuestion);
                    EditRemoveForm.Click_Remove += new EventHandler<EventArgs>(RemoveQuestion);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RemoveQuestion(object sender, EventArgs e)
        {
            try
            {
                using (model = new Model())
                {
                    Question q = model.questions.Where(x => x.Id == EditRemoveForm.ProcessingQuestion.Id).Single();
                    model.questions.Remove(q);                    
                    model.SaveChanges();
                    MessageBox.Show("Question removed successfully!");
                    EditRemoveForm.LoadListOfQuestion(model.questions.ToList<Question>());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EditQuestion(object sender, EventArgs e)
        {
            try
            {
                using (model = new Model())
                {
                    Question q = model.questions.Where(x => x.Id == EditRemoveForm.ProcessingQuestion.Id).Single();
                    q.Title = EditRemoveForm.ProcessingQuestion.Title;
                    q.rightAnswer = EditRemoveForm.ProcessingQuestion.rightAnswer;
                    q.Answer1 = EditRemoveForm.ProcessingQuestion.Answer1;
                    q.Answer2 = EditRemoveForm.ProcessingQuestion.Answer2;
                    q.Answer3 = EditRemoveForm.ProcessingQuestion.Answer3;
                    q.Level = EditRemoveForm.ProcessingQuestion.Level;                    
                    model.SaveChanges();
                    MessageBox.Show("Question edited successfully!");
                    EditRemoveForm.LoadListOfQuestion(model.questions.ToList<Question>());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public Question GetQuestion()
        {
            if (level1.Count > 4 && level2.Count > 4 && level3.Count > 4)
            {
                int i;
                Question question = new Question();
                if (CurrentLevel < 5)
                {
                    i = random.Next(0, level1.Count);
                    question = level1[i];
                    level1.RemoveAt(i);
                    CurrentLevel++;
                    return question;
                }
                else if (CurrentLevel >= 5 && CurrentLevel < 10)
                {
                    i = random.Next(0, level2.Count);
                    question = level2[i];
                    level2.RemoveAt(i);
                    CurrentLevel++;
                    return question;
                }
                else
                {
                    i = random.Next(0, level3.Count);
                    question = level3[i];
                    level3.RemoveAt(i);
                    CurrentLevel++;
                    return question;
                }
            }
            else
            {
                MessageBox.Show("Not enough questions in the database!");
                return null;
            }
        }

        void LoadQuestions()
        {
            try
            {
                using (model = new Model())
                {
                    foreach (var q in model.questions)
                    {
                        if (q.Level == 1)
                            level1.Add(q);
                        else if (q.Level == 2)
                            level2.Add(q);
                        else
                            level3.Add(q);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
