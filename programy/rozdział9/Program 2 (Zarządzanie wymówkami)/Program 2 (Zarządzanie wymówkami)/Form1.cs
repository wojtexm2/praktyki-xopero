using System.Runtime.CompilerServices;

namespace Program_2__Zarządzanie_wymówkami_
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dateTimePicker1.Value;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Okreśł wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = description.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*|日本のファイル　（*.日本語）|*.日本語";
                openFileDialog1.FileName = description.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Bierząca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return false;
            }
            return true;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePicker1.Value;
            UpdateForm(true);
        }
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.dateTimePicker1.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Program do zarządzania wymówkami";
            }
            else this.Text = "Program do zarządzania wymówkami*";
            this.formChanged = changed;
        }
    }

}