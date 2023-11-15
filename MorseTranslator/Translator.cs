using System;
using System.Windows.Forms;

namespace MorseTranslator
{
    public partial class Translator : Form
    {
        private TextBox PolishTextBox;
        private Label MorseLabel;

        private readonly string[] morseAlphabet = {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
            "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public Translator()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PolishTextBox = new System.Windows.Forms.TextBox();
            this.MorseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PolishTextBox
            // 
            this.PolishTextBox.Location = new System.Drawing.Point(29, 128);
            this.PolishTextBox.Name = "PolishTextBox";
            this.PolishTextBox.Size = new System.Drawing.Size(200, 23);
            this.PolishTextBox.TabIndex = 0;
            this.PolishTextBox.TextChanged += new System.EventHandler(this.PolishTextBox_TextChanged);
            // 
            // MorseLabel
            // 
            this.MorseLabel.Location = new System.Drawing.Point(348, 128);
            this.MorseLabel.Name = "MorseLabel";
            this.MorseLabel.Size = new System.Drawing.Size(200, 50);
            this.MorseLabel.TabIndex = 2;
            this.MorseLabel.Text = "T³umaczenie";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.MorseLabel);
            this.Controls.Add(this.PolishTextBox);
            this.Name = "PolishToMorse'a";
            this.Text = "Morse Translator";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // Back
            //
            Button backButton = new Button();
            backButton.Text = "Wróæ";
            backButton.Click += BackButton_Click;

            backButton.Location = new Point(10, 10);
            backButton.Size = new Size(75, 25);
            Controls.Add(backButton);
        }

        private void PolishTextBox_TextChanged(object sender, EventArgs e)
        {
            string inputText = PolishTextBox.Text.ToLower();
            string morseResult = TranslateToMorse(inputText);
            MorseLabel.Text = morseResult;
        }

        private string TranslateToMorse(string input)
        {
            string morseCode = "";
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    int index = character - 'a';
                    if (index >= 0 && index < morseAlphabet.Length)
                    {
                        morseCode += morseAlphabet[index] + " ";
                    }
                }
                else if (character == ' ')
                {
                    morseCode += " ";
                }
            }
            return morseCode.Trim();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu secondForm = new Menu();
            this.Hide();
            secondForm.ShowDialog();
            this.Close();

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
