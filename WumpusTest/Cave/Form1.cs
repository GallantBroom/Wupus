namespace WumpusTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GameControl gameControl;

        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            gameControl = new GameControl();
        }
    }
}
