namespace CaveTest
{
    public partial class FormCave : Form
    {
        public FormCave()
        {
            InitializeComponent();
        }

        private void FormCave_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] cave = getConnectingRooms(int.Parse(textBoxCave.Text), int.Parse(textBoxRoomNumber.Text));
            string s = string.Join(" ", cave);
            textBoxConnectingRooms.Text = s;
        }
        public static int[] getConnectingRooms(int caveNumber, int currentRoom)
        {
            Cave.Cave cave1 = new Cave.Cave();

            int[] cave = cave1.GiveCave(caveNumber - 1, currentRoom - 1);






            return cave;
        }
    }
}
