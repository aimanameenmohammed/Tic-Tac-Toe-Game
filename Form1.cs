using MyProjectGameH.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectGameH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color WhiteColor = Color.FromArgb(255, 255, 255, 250);


            Pen Pen = new Pen(WhiteColor);

            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(Pen, 400, 460, 1050, 460);



            e.Graphics.DrawLine(Pen, 610, 140, 610, 620);

            e.Graphics.DrawLine(Pen, 840, 140, 840, 620);

        }


        stGamestatus GameStatus;
        ePlayer playerTurn = ePlayer.Player1;

        enum ePlayer
        {
            Player1,Player2
        }
        
        enum eWinner
        {

            Player1, Player2,
            Draw,GameInProgress
        }
        struct stGamestatus
        {
            public eWinner Winner;
            public bool GameOver;
            public short Playcount;


        }

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (playerTurn)
                {

                    case ePlayer.Player1:

                        btn.Image = Resources.X;
                        GameStatus.Playcount++;
                        playerTurn = ePlayer.Player2;
                        lbPlayer.Text = "Player 2";
                        btn.Tag = "x";
                        CheckWinner();

                        break;



                    case ePlayer.Player2:

                        btn.Image = Resources.O;
                        GameStatus.Playcount++;
                        playerTurn = ePlayer.Player1;
                        lbPlayer.Text = "Player 1";
                        btn.Tag = "o";
                        CheckWinner();

                        break;


                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (GameStatus.Playcount == 9)
            {

                GameStatus.GameOver = true;
                GameStatus.Winner = eWinner.Draw;
                EndGame();

            }


        }

        void EndGame()
        {

           lbPlayer.Text = "Game Over";

            switch(GameStatus.Winner)
            {

                case eWinner.Player1:
                    lbinProgress.Text = "Player 1";
                    break;

                case eWinner.Player2:
                    lbinProgress.Text = "Player 2";
                    break;

                default:

                    lbinProgress.Text = "Draw";
                    break;


            }
                    MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        void ResetButton(Button btn)
        {

            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";

        }

        void ResetGame()
        {

            ResetButton(btnButton1);
            ResetButton(btnButton2);
            ResetButton(btnButton3);
            ResetButton(btnButton4);
            ResetButton(btnButton5);
            ResetButton(btnButton6);
            ResetButton(btnButton7);
            ResetButton(btnButton8);
            ResetButton(btnButton9);


            GameStatus.Playcount = 0;
            playerTurn = ePlayer.Player1;
            GameStatus.Winner= eWinner.GameInProgress;
            lbPlayer.Text = "Player 1";
            GameStatus.GameOver = false;
            lbinProgress.Text = "In Progress";


        }


        public bool CheckValues(Button btn1,Button btn2,Button btn3)
        {

            if (btn1.Tag.ToString()!="?"&&btn1.Tag.ToString() == btn2.Tag.ToString() && btn3.Tag.ToString() == btn1.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;



                if(btn1.Tag.ToString()=="x")
                {

                 
                    GameStatus.Winner = eWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;


                }
                else
                {
                    GameStatus.Winner = eWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;


                }
               



            }



            GameStatus.GameOver = false;
            return false;




        }
       public void CheckWinner()
        {

            if (CheckValues(btnButton1, btnButton2, btnButton3))
                return;


            if (CheckValues(btnButton4, btnButton5, btnButton6))
                return;

            if (CheckValues(btnButton7, btnButton8, btnButton9))
                return;




            if (CheckValues(btnButton1, btnButton4, btnButton7))
                return;

            if (CheckValues(btnButton2, btnButton5, btnButton8))
                return;


            if (CheckValues(btnButton3, btnButton6, btnButton9))
                return;




            if (CheckValues(btnButton1, btnButton5, btnButton9))
                return;


            if (CheckValues(btnButton3, btnButton5, btnButton7))
                return;


          

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
