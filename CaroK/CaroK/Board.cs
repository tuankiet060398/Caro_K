using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroK
{
    public class Board
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }


        public List<Player> Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public int CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }

            set
            {
                currentPlayer = value;
            }
        }

        public TextBox Playername
        {
            get
            {
                return playername;
            }

            set
            {
                playername = value;
            }
        }

        public PictureBox Playmark
        {
            get
            {
                return playmark;
            }

            set
            {
                playmark = value;
            }
        }

        private List<Player> player;
        private int currentPlayer;

        private TextBox playername;
        private PictureBox playmark;
        #endregion

        #region Initialize 
        public Board(Panel chessBoard,TextBox playername,PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.Playername = playername;
            this.Playmark = mark;
            this.player = new List<Player>()
            {
                new Player("Người chơi",Image.FromFile("F:\\codecocaro\\CaroK\\CaroK\\Resources\\tronxanh.PNG")),
                new Player("AI K",Image.FromFile("F:\\codecocaro\\CaroK\\CaroK\\Resources\\xdo.PNG")),
            }
            ;
            currentPlayer = 0;
        }

        #endregion
        #region Methods
        public void DrawCheckBoard()
        {

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Conten.Banco_rong; i++)
            {
                for (int j = 0; j < Conten.Banco_cao; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Conten.Rong,
                        Height = Conten.Cao,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += btn_click;

                    ChessBoard.Controls.Add(btn);

                    oldButton = btn;

                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Conten.Cao);
                oldButton.Width = 0;
                oldButton.Height = 0;

            }
        }
        void btn_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            btn.BackgroundImage = player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            Playername.Text = Player[CurrentPlayer].Name;
            Playmark.Image = Player[CurrentPlayer].Mark;



        }

        #endregion


    }
}
