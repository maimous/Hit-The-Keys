using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hit_The_Keys
{
    public partial class hitTheKeys : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public hitTheKeys()
        {
            InitializeComponent();
            listBox1.Items.Add("Press Enter to start");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            // Add a random key to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over!");
                timer1.Stop();
            }
        }

        private void hitTheKeys_KeyDown(object sender, KeyEventArgs e)
        {
            // Start Timer ticking with pressing "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Clear();
                timer1.Start();
            }

            // If the user pressed a key that's in the ListBox, remove it
            // and then make the game a little faster
                if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 1000)
                    timer1.Interval -= 10;
                if (timer1.Interval > 600)
                    timer1.Interval -= 5;
                if (timer1.Interval > 400)
                    timer1.Interval -= 3;
                if (timer1.Interval > 250)
                    timer1.Interval -= 2;
                if (timer1.Interval > 100)
                    timer1.Interval -= 1;
                difficultyProgressBar.Value = 1200 - timer1.Interval;
                // The user pressed a correct key, so update the Stats object
                // by calling its Update() method with the argument true
                stats.Update(true);
            }
            else
            {
                // The user pressed an incorrect key, so update the Stats object
                // by calling its Update() method with the argument false
                stats.Update(false);
            }
            // Update the labels on the StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
                
    }
}
