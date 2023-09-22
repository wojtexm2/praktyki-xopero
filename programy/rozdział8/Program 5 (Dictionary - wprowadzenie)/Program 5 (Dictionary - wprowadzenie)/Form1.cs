namespace Program_5__Dictionary___wprowadzenie_
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumers = new Dictionary<int, JerseyNumber>()
            {
                { 3, new JerseyNumber("Babe Ruth", 1948) },
                { 4, new JerseyNumber("Lou Gehrig", 1939) },
                { 5, new JerseyNumber("Joe DiMaggio", 1952) },
                { 7, new JerseyNumber("Mickey Mantle", 1969) },
                { 8, new JerseyNumber("Yogi Berra", 1972) },
                { 10, new JerseyNumber("Phil Rizutto", 1985) },
                { 23, new JerseyNumber("Don Mattingly", 1997) },
                { 42, new JerseyNumber("Jackie Robinson", 1993) },
                { 44, new JerseyNumber("Reggie Jackson", 1993) },
            };
        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNumers.Keys)
            {
                number.Items.Add(key);
            }
        }

        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumers[(int)number.SelectedItem];
            labelPlayer.Text = jerseyNumber.Player;
            labelYear.Text = jerseyNumber.YearRetired.ToString();
        }
    }
}