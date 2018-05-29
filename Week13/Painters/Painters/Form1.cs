using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painters
{
    public partial class Form1 : Form
    {
        Graphics mainCanvas;
        Painter redPainter;
        Painter bluePainter;
        Painter greenPainter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainCanvas = CreateGraphics();
            redPainter = new Painter(255, 0, 0, mainCanvas, new Point(0, 0));
            bluePainter = new Painter(0, 0, 255, mainCanvas, new Point(50, 50));
            greenPainter = new Painter(0, 255, 0, mainCanvas, new Point(100, 100));
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            Refresh();
            redPainter.FillCanvas();
            bluePainter.FillCanvas();
            greenPainter.FillCanvas();
            //This will produce the same output each time because its a single thread and iterates over the method calls.
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            Refresh();

            Thread redThread = new Thread(redPainter.FillCanvas);
            Thread blueThread = new Thread(bluePainter.FillCanvas);
            Thread greenThread = new Thread(greenPainter.FillCanvas);

            redThread.Start();
            blueThread.Start();
            greenThread.Start();
            //The multithreaded version is not going to display the same output because due to the painters runnning on diffrent threads one will finsh last each time. 
        }
    }
}
