using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        bool isItXsTurn = true;
        int counter = 0;
        List<int> listOfX = new List<int>();
        List<int> listOfO = new List<int>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHover(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            //b.BackColor = Color.Red;
        }

        private void btnClick(object sender, EventArgs e)
        {

            counter++; // total count of button press

            Button b = (Button)sender;//taking the button input
            // extracting the button number from the btton text
            int i = (Convert.ToInt16(Regex.Match(b.Name, @"\d+").Value));


            if (isItXsTurn)
            {
                b.Text = "X";
                listOfX.Add(i);
            }              
            else
            {
                b.Text = "O";
                listOfO.Add(i);
            }
              

            b.Enabled = false;
            isItXsTurn = !isItXsTurn;

            if(counter>=3)
            {
                FindWinner();
            }
            
        }

        private void FindWinner()
        {
            if(listOfX.Contains(1) && listOfX.Contains(2) && listOfX.Contains(3))
            {
                MessageBox.Show("Winner is X !");
            }


        }//End of FindWInner Method !!
    }
}
