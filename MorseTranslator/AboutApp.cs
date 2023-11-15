using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    public partial class AboutApp : Form
    {
        private TextBox aboutApp;
        public AboutApp()
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
            aboutApp.Location = new Point(10, 50);
            aboutApp.Size = new Size(760, 500);
            aboutApp.Text = "Tutaj znajdą się informacje o kodzie Morse'a...";

            this.Size = new Size(800, 600);
        }

        private void InitializeControls()
        {
            aboutApp = new TextBox
            {
                Multiline = true,
                ReadOnly = true
            };

            Controls.Add(aboutApp);
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
