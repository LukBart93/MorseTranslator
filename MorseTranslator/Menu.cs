using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseTranslator
{
    public partial class Menu : Form
    {
        private Button PolskiMorsea;
        public Menu()
        {
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            this.SuspendLayout();

            // Dodaj kod inicjalizacji elementów interfejsu użytkownika tutaj

            Button PolskiMorseaButton = new Button
            {
                Text = "Polski - Morse'a",
                Location = new System.Drawing.Point(250, 200),
                Size = new System.Drawing.Size(200, 50),
                Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic)
            };

            PolskiMorseaButton.Click += PolskiMorsea_Click;
            this.Controls.Add(PolskiMorseaButton);
            

            Button MorseaPolskiButton = new Button
            {
                Text = "Morse'a - Polski",
                Location = new System.Drawing.Point(250, 260),
                Size = new System.Drawing.Size(200, 50),
                Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic)
            };

            MorseaPolskiButton.Click += MorseaPolski_Click;
            this.Controls.Add(MorseaPolskiButton);

            Button HistoryButton = new Button();
            HistoryButton.Text = "Historia";
            HistoryButton.Click += History_Click;

            Button AboutAppButton = new Button();
            AboutAppButton.Text = "O programie";
            AboutAppButton.Click += AboutApp_Click;

            Button AboutMorseButton = new Button();
            AboutMorseButton.Text = "O Morse'a";
            AboutMorseButton.Click += AboutMorse_Click;

            Button SettingsButton = new Button();
            SettingsButton.Text = "Ustawienia";
            SettingsButton.Click += Settings_Click;


            // Dodaj przycisk do formularza

            this.Controls.Add(HistoryButton);
            HistoryButton.Location = new System.Drawing.Point(250, 10);
            HistoryButton.Size = new System.Drawing.Size(100, 30);

            this.Controls.Add(AboutAppButton);
            AboutAppButton.Location = new System.Drawing.Point(360, 10);
            AboutAppButton.Size = new System.Drawing.Size(100, 30);

            this.Controls.Add(AboutMorseButton);
            AboutMorseButton.Location = new System.Drawing.Point(470, 10);
            AboutMorseButton.Size = new System.Drawing.Size(100, 30);

            SettingsButton.Location = new System.Drawing.Point(580, 10);
            SettingsButton.Size = new System.Drawing.Size(100, 30);
            this.Controls.Add(SettingsButton);

            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.PolskiMorsea);
            this.Text = "Morse Translator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void PolskiMorsea_Click(object sender, EventArgs e)
        {
            Translator secondForm = new Translator();
            this.Hide();
            secondForm.ShowDialog();
            this.Close();
            
        }
        private void MorseaPolski_Click(object sender, EventArgs e)
        {
            Translator secondForm = new Translator();
            this.Hide();
            secondForm.ShowDialog();
            this.Close();
        }

        private void AboutMorse_Click(object sender, EventArgs e)
        {
            AboutMorse aboutMorse = new AboutMorse();
            this.Hide();
            aboutMorse.ShowDialog();
            this.Close();
            
        }

        private void AboutApp_Click(object sender, EventArgs e)
        {
            AboutApp aboutApp = new AboutApp();
            this.Hide();
            aboutApp.ShowDialog();
            this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {
            //History history = new History();
            //this.Hide();
            //history.ShowDialog();
            //this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

    }
}
