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
    private int remainingInterval;
    private System.Windows.Forms.Timer countdownTimer;

    public Action(int durata, int intervallo)
    {
        InitializeComponent();

        remainingSeconds = durata;
        interval = intervallo;
        remainingInterval = intervallo;

        lblIntervallo.Text = interval.ToString();

        countdownTimer = new System.Windows.Forms.Timer();
        countdownTimer.Interval = 1000; // 1 secondo
        countdownTimer.Tick += CountdownTimer_Tick;

        lblCountdown.Text = $"{remainingSeconds}"; // Imposta valore iniziale (assicurati che esista un Label chiamato lblCountdown)
        countdownTimer.Start();
    }

    private void CountdownTimer_Tick(object sender, EventArgs e)
    {
        remainingSeconds--;
        remainingInterval--;

        if (remainingInterval == 0) remainingInterval = interval;

        lblCountdown.Text = $"{remainingSeconds}";
        lblIntervallo.Text = $"{remainingInterval}";

        if (remainingSeconds <= 0)
        {
            countdownTimer.Stop();
            MessageBox.Show("Countdown terminato!");
            this.Close(); // opzionale: chiudi il form
        }
    }
}
