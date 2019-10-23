using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroK
{
    public partial class Form1 : Form
    {
        #region Properties
        Board ChessBoard;
        #endregion

        public Form1()
        {
            InitializeComponent();

            ChessBoard = new Board(pnlCaro,txtName,picBoxMark);
            ChessBoard.DrawCheckBoard();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxHinh_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
