using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaptchaPluginsFramework;

namespace Rudin
{
    public partial class QuestionsForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private List<CaptchaTask> _captchaTasks;
        private int _current;
        private string _answer;
        private string _question;
        
        public QuestionsForm(List<CaptchaTask> captchaTasks)
        {
            _captchaTasks = captchaTasks;
            _current = 0;
            InitializeComponent();
            this.ControlBox = false;
            SetQuestion(_current);
        }

        public void SetQuestion(int questionIndex)
        {
            if(questionIndex >= _captchaTasks.Count)
            {
                MessageBox.Show("Done");
                this.Close();
                return;
            }
            CaptchaPluginBase captchaChallenge = _captchaTasks[questionIndex].captcha;
            int difficulty = _captchaTasks[questionIndex].difficulty;
            captchaChallenge.SetDifficulty(difficulty);
            CaptchaChallenge captcha = captchaChallenge.GetChallenge();
            _answer = captcha.ChallengeAnswer;
            _question = captcha.ChallengeQuestion;
            richTextBoxQuestion.Text = _question;
            textBoxAnswer.Text = "";
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            string userAnswer = textBoxAnswer.Text;
            textBoxAnswer.Text = "";
            if(userAnswer == _answer)
            {
                _current += 1;
                SetQuestion(_current);
            }
            else
            {
                MessageBox.Show("Invalid answer!");
            }

        }
        
        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
                buttonAnswer_Click(sender, e);
           }
        }
    }
}
