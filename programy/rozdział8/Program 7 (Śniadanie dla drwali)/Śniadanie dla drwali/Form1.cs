namespace Śniadanie_dla_drwali
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked) food = Flapjack.Chrupkiego;
            else if (soggy.Checked) food = Flapjack.Wilgotnego;
            else if (browned.Checked) food = Flapjack.Rumianego;
            else food = Flapjack.Bananowego;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)numericUpDown1.Value);
            RedrawList();
        }
    }
}