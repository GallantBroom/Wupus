namespace GameLocationTest2
{
    public partial class Form1 : Form
    {
        GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int[] locations = gameLocation.Spawn();
            textBox1.Text = locations[0].ToString();
            textBox3.Text = locations[1].ToString();
            textBox2.Text = locations[2].ToString();
            textBox4.Text = locations[3].ToString();
            textBox5.Text = locations[4].ToString();
            textBox6.Text = locations[5].ToString();
            textBox7.Text = locations[6].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int[] near = gameLocation.GetCave(6,30,2);
            
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            
            if (near[0] == 1)
            {
                label4.Text = "There's a Skeleton in this room, there must be a trap nearby.";
            }
            if (near[1] ==1)
            {
                label5.Text = "You smell a Wumpus nearby.";
            }
            if (near[2] == 1)
            {
                label6.Text = "You feel a Breeze.";
            }

        }
    }
}
