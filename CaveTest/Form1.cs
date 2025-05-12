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
            label1.Text = getConnectingRooms(1, 12); 
        }
        public static string getConnectingRooms(int caveNumber, int currentRoom)
        {
            Cave.Cave cave1 = new Cave.Cave();

            int[] cave = cave1.GiveCave(caveNumber, currentRoom);
            string s = string.Join(" ", cave);






            return s;
        }
    }
}
