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
            //TODO: Spread 200 living cells around the map randomly
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
