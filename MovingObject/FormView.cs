using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingObject
{
    public partial class FormView : Form
    {
        enum Position //enumeration contains its own values and cannot inherit or cannot pass inheritance.
        {

            Left, Right, Up, Down
        }

        private int x;
        private int y;
        private Position ObjPosition;
       
        public FormView()
        {
            InitializeComponent();
            x = 50; //Assigning value to the variable
            y = 50;
            ObjPosition = Position.Down; //This by default makes the thing to go down
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Black, x, y, 30,30); //Create a rectangle with black
            e.Graphics.DrawImage(new Bitmap("12048957873_ab44dde9af.jpg"),x,y,40,40); //Attached a imgae 

        }

        private void TimerMoving_Tick(object sender, EventArgs e) //The timer function makes the box to move from one pace to the other
        {
            if (ObjPosition == Position.Right)
            {
                x += 10;

            }
            else if (ObjPosition == Position.Left)
            {
                x -= 10;
            }
            else if (ObjPosition == Position.Up)
            {
                y -= 10;
            }
            else if (ObjPosition == Position.Down)
            {
                y += 10;
            }
            Invalidate(); //This is the reason why the object is moving from left to the right.
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ObjPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                ObjPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {

                ObjPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                ObjPosition = Position.Down;
            }
           
           
        }

        private void FormView_RightToLeftChanged(object sender, EventArgs e)
        {


        }
    }
}
