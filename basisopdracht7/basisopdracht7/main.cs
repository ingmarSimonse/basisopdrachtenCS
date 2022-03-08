namespace basisopdracht7
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void testButton_MouseEnter(object sender, EventArgs e)
        {
            var rand = new Random();
            int xPosition = rand.Next(0, ClientRectangle.Width);
            int yPosition = rand.Next(0, ClientRectangle.Height);
            testButton.Location = new Point(xPosition, yPosition);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLICK!");
        }
    }
}