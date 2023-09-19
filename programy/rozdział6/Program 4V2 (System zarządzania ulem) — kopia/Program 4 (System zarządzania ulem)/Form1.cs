namespace Program_4__System_zarządzania_ulem_
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, 175);
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z żądłami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Patrol z żądłami",
                                                    "Utrzymanie ula", "Nauczanie pszczółek" }, 155);


            queen = new Queen(workers, 275);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczół mówi...");
            }
            else MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' będzoe ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}