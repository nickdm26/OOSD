using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject subjectWithEvent;
        BeepObserver beep;
        InstructionsObserver instruction;
        EFireCategory fireType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subjectWithEvent = new FireAlarmSubject();
            beep = new BeepObserver(subjectWithEvent);
            instruction = new InstructionsObserver(subjectWithEvent);
        }

        private void btnFireAlarm_Click(object sender, EventArgs e)
        {
            if (rbtnMinor.Checked)
            {
                fireType = EFireCategory.MINOR;
            }
            else if (rbtnSerious.Checked)
            {
                fireType = EFireCategory.SERIOUS;
            }
            else
            {
                fireType = EFireCategory.INFERNO;
            }

            subjectWithEvent.onFireEvent(fireType);
        }
    }
}
