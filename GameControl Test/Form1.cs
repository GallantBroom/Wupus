namespace GameControl_Test
{
    public partial class FormgameControlTest : Form
    {
        public FormgameControlTest()
        {
            InitializeComponent();
        }

        private void buttonReturnCave_Click(object sender, EventArgs e)
        {
            GameControl.GameControl gamecontrol = new GameControl.GameControl();

            int[] cave = GameControl.GameControl.getConnectingRooms(1, 5);

            string displaycave = string.Empty;

            for( int i = 0; i < cave.Length; i++ )
            {

                displaycave += cave[i];


            }

            label1.Text = displaycave;

        }
    }
}
