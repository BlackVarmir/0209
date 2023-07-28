namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            string[] values = text.Split(';');

            if (values.Length > 3)
            {
                string authorId = values[3].Trim();

                if (!string.IsNullOrEmpty(authorId))
                {
                    MessageBox.Show($"Ідентифікатор автора: {authorId}", "ID Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ідентифікатор автора відсутній.", "ID Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ідентифікатор автора не знайдено або введений рядок має невірний формат.", "ID Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}