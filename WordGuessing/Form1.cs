using System.Text;

namespace WordGuessing
{
    public partial class Form1 : Form
    {

        private string wordToGuess;
        private List<string> wrongGuesses = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            string[] words = { "serenity", "sunshine", "harmony", "wonder", "bliss" };
            Random random = new Random();
            int index = random.Next(words.Length);
            wordToGuess = words[index];
            StringBuilder sb = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (i == 0 || i == wordToGuess.Length - 1)
                {
                    sb.Append(wordToGuess[i]);
                }
                else
                {
                    sb.Append('?');
                }
            }
            DisplayWordlbl.Text = sb.ToString();
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            string guess = TypetxtBox.Text.ToLower();
            bool correctGuess = false;
            if (guess == wordToGuess)
            {
                MessageBox.Show("Correct guess!");
                DisplayWordlbl.Text = wordToGuess;
            }
            else
            {
                StringBuilder sb = new StringBuilder(DisplayWordlbl.Text);
                if (guess == wordToGuess)
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        sb[i] = guess[i];
                    }
                    correctGuess = true;
                }
                DisplayWordlbl.Text = sb.ToString();
                TypetxtBox.Clear();
                if (correctGuess)
                {
                    MessageBox.Show("Correct guess!");
                }
                else
                {
                    wrongGuesses.Add(guess);
                    listBox1.DataSource = null;
                    listBox1.DataSource = wrongGuesses;
                    MessageBox.Show("Wrong guess.");
                }
            }
        }
    }
}