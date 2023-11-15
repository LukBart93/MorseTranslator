using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    public partial class AboutMorse : Form
    {
        private TextBox aboutMorse;

        public AboutMorse()
        {
            InitializeMenu();
        }
        private void InitializeMenu()
        {
            Button backButton = new Button();
            backButton.Text = "Wróć";
            backButton.Click += BackButton_Click;

            backButton.Location = new Point(10, 10);
            backButton.Size = new Size(75, 25);
            Controls.Add(backButton);

            // nagłówek
            this.Text = "Informacje o kodzie Morse'a";


            // co w oknie
            InitializeControls();
            aboutMorse.Location = new Point(10, 50);
            aboutMorse.Size = new Size(760, 500);
            aboutMorse.Text = "Tutaj znajdą się informacje o kodzie Morse'a...";

            this.Size = new Size(800, 600);
        }


        private void InitializeControls()
        {
            aboutMorse = new TextBox
            {
                Multiline = true,
                ReadOnly = true
            };

            Controls.Add(aboutMorse);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu secondForm = new Menu();
            this.Hide();
            secondForm.ShowDialog();
            this.Close();

        }
    }
}

