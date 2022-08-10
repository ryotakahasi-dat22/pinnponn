using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pinnponn
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 19;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        //Label[] chrs = new Label[ChrMax];
        //int[] vx = new int[ChrMax];
        //int[] vy = new int[ChrMax];
        int vx = 10;
        int vvx = 10;
        int vvy = 10;
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax + PlayerMax;
        const int ItemIndex = EnemyMax + EnemyMax;
        const int StartTime = 1000;

        static Random rand = new Random();

        int itemCount = 0;
        int time = 0;
        int hiscore = 0;
        int tekiCount = 0;

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            time--;
            timeLabel.Text = "Time" + time;

            Point mp = PointToClient(MousePosition);

            PR.Top = mp.Y - PR.Height / 2;

            EN.Top += vx;

            if(EN.Top < 0)
            {
                vx = Math.Abs(vx);
            }
            if (EN.Bottom > ClientSize.Height)
            {
                vx = -Math.Abs(vx);
            }

            Tama.Left += vvx;
            Tama.Top += vvy;


            /*for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                if ((mp.X >= chrs[i].Left)
                    && (mp.X < chrs[i].Right)
                    && (mp.Y >= chrs[i].Top)
                    && (mp.Y < chrs[i].Bottom)
                    )
                {
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //chrs[i].Visible = false;
                        itemCount--;
                        if (itemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                        leftLabel.Text = $"š:{itemCount:00}";
                        vx[i] = 0;
                        vy[i] = 0;
                        chrs[i].Left = 10000;
                    }
                }
            }*/

            if ((time <= 0)
                && (nextState == State.None))
            {
                nextState = State.Gameover;
            }
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    clearLabel.Visible = false;
                    titleButton.Visible = false;
                    timeLabel.Text = "Time 1000";
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    copyrightLabel.Visible = false;
                    startButton.Visible = false;

                    vvx = rand.Next(-SpeedMax, SpeedMax + 1);
                    vvy = rand.Next(-SpeedMax, SpeedMax + 1);
                    Tama.Visible = true;

                    itemCount = ItemMax - 9;
                    time = StartTime + 1;
                    leftLabel.Text = $"{itemCount:00}";
                    rightLabel.Text = $"{tekiCount:00}";

                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleButton.Visible = true;
                    /*hiLabel.Visible = true;
                    if (time > hiscore)
                    {
                        hiscore = time;
                        hiLabel.Text = "HighScore" + hiscore;
                    }*/
                    break;

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}