using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bots
{
    public partial class Form1 : Form
    {
        Ship ship;
        List<Ship> ships;
        List<PetrolBot> bots;
        PetrolBot bot;
        Random ran;
        Rectangle Dimensions;
        Graphics Canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ships = new List<Ship>();
            bots = new List<PetrolBot>();
            List<Color> colors = new List<Color>();
            Color pink = Color.Pink;
            Color orange = Color.Orange;
            Color aqua = Color.Aqua;
            Color green = Color.Green;
            Color purple = Color.Purple;
            colors.Add(pink);
            colors.Add(orange);
            colors.Add(aqua);
            colors.Add(green);
            colors.Add(purple);

            ran = new Random();
            Dimensions = new Rectangle(0, 0, panel1.Width, panel1.Height);

            Dimensions.Height -= 100;
            Canvas = panel1.CreateGraphics();
            int homeY = Dimensions.Height + 10;
            int homeX = 10;

            for(int i = 0; i < 5; i++)
            {
                ship = new Ship(Canvas, ran, Dimensions);
                bot = new PetrolBot(ship, Canvas, homeX, homeY, colors[i]);
                homeX += bot.Height + 10;
                ships.Add(ship);
                bots.Add(bot);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Ship sh in ships)
            {
                sh.RunCycle();
            }
            foreach(PetrolBot pb in bots)
            {
                pb.Erase();
                pb.Draw();
            }
        }
    }
}
