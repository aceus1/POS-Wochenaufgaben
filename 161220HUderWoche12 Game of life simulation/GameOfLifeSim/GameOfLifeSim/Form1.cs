using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Panel[,] Panels;
        private Color tot = Color.Gray;
        private Color leben = Color.LightGreen;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Game Of Life Simulator";
            const int tileSize = 40;
            const int gridSize = 20;
            ticktimer.Enabled = false;
            timerzeitbox.Text = "10";

            // Setz das Array auf die Größe des spielfeldes
            Panels = new Panel[gridSize, gridSize];
            
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n + 10, tileSize * m + 10)
                    };
                    //Damit wird das im Forms angezeigt
                    Controls.Add(newPanel);
                    //neues panel hinzufügen
                    Panels[n, m] = newPanel;
                    //Alle Panels zum beginn auf Tot setzen
                    newPanel.BackColor = tot;
                }
            }
            
        }
        private void randomPlayground()
        {
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int tmp1 = rnd.Next(0,20), tmp2 = rnd.Next(0,20);
                if (Panels[tmp1, tmp2].BackColor == tot)
                {
                    Panels[tmp1, tmp2].BackColor = leben;
                }
                else
                {
                    i--;
                    count++;
                }
                if (count > 400)
                {
                    break;
                }
            }
        }
        private int anzLebenNachbar(int x, int y) //Gibt die Anzahl der lebenden Nachbarzellen zurück
        {
            int countLeben = 0;
            if (y + 1 < Panels.GetLength(1))
            {
                //Drüber
                if (Panels[x, y + 1].BackColor == leben)
                {
                    countLeben++;
                }

                if (x + 1 < Panels.GetLength(0))
                {
                    //Rechts Oben
                    if (Panels[x + 1, y + 1].BackColor == leben)
                    {
                        countLeben++;
                    }
                }
                if (x - 1 >= 0)
                {
                    //Links Oben
                    if (Panels[x - 1, y + 1].BackColor == leben)
                    {
                        countLeben++;
                    }
                    
                }
            }
            if (y - 1 >= 0)
            {
                //Darunter
                if (Panels[x, y - 1].BackColor == leben)
                {
                    countLeben++;
                }

                if (x + 1 < Panels.GetLength(0))
                {
                    //Rechts Darunter
                    if (Panels[x + 1, y - 1].BackColor == leben)
                    {
                        countLeben++;
                    }
                }
                if (x - 1 >= 0)
                {
                    //Links Darunter
                    if (Panels[x - 1, y - 1].BackColor == leben)
                    {
                        countLeben++;
                    }

                }
            }
            if (x - 1 >= 0)
            {
                //Links
                if (Panels[x - 1, y].BackColor == leben)
                {
                    countLeben++;
                }
            }
            if (x + 1 < Panels.GetLength(0))
            {
                //Rechts
                if (Panels[x + 1, y].BackColor == leben)
                {
                    countLeben++;
                }
            }
            return countLeben;
        }
        private List<Panel> checkpanels()
        {
            List<Panel> newChangingPanels = new List<Panel>();
            for (int x = 0; x < Panels.GetLength(0) ; x++)
            {
                for (int y = 0; y < Panels.GetLength(1); y++)
                {
                    #region eine tote Zelle, die 3 Nachbarn hat, wird lebendig
                    if (Panels[x,y].BackColor == tot && anzLebenNachbar(x,y) == 3)
                    {
                        newChangingPanels.Add(Panels[x, y]);
                    }
                    #endregion
                    #region jede lebende Zelle, die keinen oder nur einen Nachbarn hat, stirbt(einsam)
                    if (Panels[x, y].BackColor == leben && (anzLebenNachbar(x, y) >= 0 && anzLebenNachbar(x,y) <= 1))
                    {
                        newChangingPanels.Add(Panels[x, y]);
                    }
                    #endregion
                    #region jede lebende Zelle, die 4 oder mehr Nachbarn hat, stirbt (überbevölkert)
                    if (Panels[x,y].BackColor == leben && anzLebenNachbar(x,y) >= 4)
                    {
                        newChangingPanels.Add(Panels[x, y]);
                    }
                    #endregion

                }
            }
            return newChangingPanels;
        }
        public void tick()//Ein tick nach Delta(T)
        {
            List<Panel> tmp = checkpanels();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].BackColor == tot)
                {
                    tmp[i].BackColor = leben;
                }
                else
                {
                    tmp[i].BackColor = tot;
                }
            }
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            randomPlayground();
        }

        private void tickbutton_Click(object sender, EventArgs e)
        {
            tick();
        }

        private void ticktimer_Tick(object sender, EventArgs e)
        {
            tick();
        }

        private void timerzeitbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ticktimer.Interval = int.Parse(timerzeitbox.Text)*1000;
                timerzeitbox.BackColor = Color.White;
            }
            catch (Exception)
            {
                timerzeitbox.BackColor = Color.Red;
            }
        }

        private void startimerbutton_Click(object sender, EventArgs e)
        {
            ticktimer.Enabled = true;
            ticktimer.Start();
        }

        private void stoptimerbutton_Click(object sender, EventArgs e)
        {
            ticktimer.Stop();
            ticktimer.Enabled = false;   
        }
    }
}
