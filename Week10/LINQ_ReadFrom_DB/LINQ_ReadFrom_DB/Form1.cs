using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_ReadFrom_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PoorlyNamedDataContext db = new PoorlyNamedDataContext();

            var thing = db.tblStrikes.Average(li => li.strikeIntensity);

            listBox1.Items.Add(thing);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PoorlyNamedDataContext db = new PoorlyNamedDataContext();

            var topThree = (from i in db.tblFires
                           orderby i.fireArea descending
                           select i).Take(3);

            foreach(var num in topThree)
            {
                listBox1.Items.Add(num.fireArea);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PoorlyNamedDataContext db = new PoorlyNamedDataContext();

            var coordinatesAndFileName = from Fi in db.tblFires
                                         join Pi in db.tblPictures
                                         on Fi.fireID equals Pi.pictureID
                                         select new { Pi.strikeID, Pi.pictureDate, Pi.pictureFileName, Fi.fireLatitude, Fi.fireLongitude };

            foreach(var group in coordinatesAndFileName)
            {
                listBox1.Items.Add(group.strikeID + "\t" + group.pictureFileName + "\t" + group.fireLatitude + "\t" + group.fireLongitude);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PoorlyNamedDataContext db = new PoorlyNamedDataContext();

            var StrikeCauseFire = from Fi in db.tblFires
                                  join Li in db.tblStrikes
                                  on Fi.fireLatitude equals Li.strikeLatitude
                                  where string.Equals(Fi.fireLatitude, Li.strikeLatitude) && string.Equals(Fi.fireLongitude, Li.strikeLongitude) && string.Equals(Fi.fireDate, Li.strikeDate)
                                  select new { Fi.fireDate, Li.strikeTime, Li.strikeLatitude, Li.strikeLongitude, Li.strikeIntensity, Fi.fireArea };

            listBox1.Items.Add("FireDate" + "\t\t\t" + "StrikeTime" + "\t" + "StrikeLatitude" + "\t" + "StrikeLongitude" + "\t" + "StrikeIntensity" + "\t" + "FireArea");

            foreach (var record in StrikeCauseFire)
            {
                listBox1.Items.Add(record.fireDate + "\t" + record.strikeTime + "\t\t" + record.strikeLatitude + "\t\t" + record.strikeLongitude + "\t\t" + record.strikeIntensity + "\t\t" + record.fireArea);
            }
        }
    }
}
