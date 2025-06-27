namespace ReactionTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInizio_Click(object sender, EventArgs e)
        {
            int durata;
            int intervallo;
            if ((int.TryParse(txtDurata.Text, out durata) && durata > 0) &&
                (int.TryParse(txtIntervallo.Text, out intervallo) && intervallo > 0))
            {
                Action actionForm = new Action(durata, intervallo); // passa il valore
                actionForm.Show();
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido per la durata.");
            }
        }
    }
}
