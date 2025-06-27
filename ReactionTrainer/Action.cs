using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTrainer;

public partial class Action: Form
{
    private int remainingSeconds;
    private int interval;
    private int firstInterval;
    private int remainingInterval;
    private string[] options = { "UP", "DOWN", "LEFT", "RIGHT" };
    private bool isFirst = true;
    private System.Windows.Forms.Timer countdownTimer;

    public Action(int durata, int intervallo)
    {
        InitializeComponent();

        this.KeyPreview = true;
        this.KeyDown += Action_KeyDown;

        // Imposta lo sfondo nero
        this.BackColor = Color.Black;

        // Imposta il form a schermo intero
        this.FormBorderStyle = FormBorderStyle.None; // Rimuove i bordi
        this.WindowState = FormWindowState.Maximized; // Massimizza

        lblCountdownLabel.ForeColor = Color.White;
        lblIntervalloLabel.ForeColor = Color.White;
        lblAzione.ForeColor = Color.White;

        remainingSeconds = durata+3;
        interval = intervallo;
        remainingInterval = 3;

        lblIntervallo.Text = remainingInterval.ToString();

        countdownTimer = new System.Windows.Forms.Timer();
        countdownTimer.Interval = 1000; // 1 secondo
        countdownTimer.Tick += CountdownTimer_Tick;

        lblCountdown.Text = $"{remainingSeconds}"; // Imposta valore iniziale (assicurati che esista un Label chiamato lblCountdown)
        countdownTimer.Start();
    }

    private void CountdownTimer_Tick(object sender, EventArgs e)
    {
        if (isFirst) lblAzione.Text = "READY";

        remainingSeconds--;
        remainingInterval--;

        if (remainingInterval == 0)
        {
            remainingInterval = interval;
            isFirst = false;
        }

        if (remainingInterval == interval && !isFirst)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(options.Length);
            string action = options[randomIndex];
            lblAzione.Text = action;
        }

        lblCountdown.Text = $"{remainingSeconds}";
        lblIntervallo.Text = $"{remainingInterval}";    

        if (remainingSeconds <= 0)
        {
            countdownTimer.Stop();
            MessageBox.Show("Countdown terminato!");
            this.Close(); // opzionale: chiudi il form
        }
    }

    private void Action_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            this.Close();
        }
    }
}
