using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_N_Match
{
    public class Manager
    {
        ComboBox comboHead;
        ComboBox comboBody;
        ComboBox comboLegs;
        Graphics canvas;
        MonsterFactory monsters;
        


        public Manager(ComboBox comboHead, ComboBox comboBody, ComboBox comboLegs, Graphics canvas)
        {
            this.comboHead = comboHead;
            this.comboBody = comboBody;
            this.comboLegs = comboLegs;
            this.canvas = canvas;
            monsters = new MonsterFactory();
        }

        public void MakeMonster()
        {
            
            Monster monsterHead = monsters.CreateMonster(comboHead.SelectedItem.ToString());
            Monster monsterBody = monsters.CreateMonster(comboBody.SelectedItem.ToString());
            Monster monsterLegs = monsters.CreateMonster(comboLegs.SelectedItem.ToString());

            Bitmap bitHead = monsterHead.getHead();
            Bitmap bitBody = monsterBody.getBody();
            Bitmap bitLegs = monsterLegs.getLegs();

            Rectangle im1 = new Rectangle(0, 0, bitHead.Width, bitHead.Height);
            Rectangle im2 = new Rectangle(0, bitHead.Height, bitBody.Width, bitBody.Height);
            Rectangle im3 = new Rectangle(0, bitHead.Height + bitBody.Height, bitLegs.Width, bitLegs.Height);

            canvas.DrawImage(monsterHead.getHead(), im1);    
            canvas.DrawImage(monsterBody.getBody(), im2);
            canvas.DrawImage(monsterLegs.getLegs(), im3);
        }
    }
}
