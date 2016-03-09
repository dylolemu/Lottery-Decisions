﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int answer;
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            label1.Text = "Choose a Ticket";
            pictureBox1.Hide();
            pictureBox3.Hide();
            Ticket1.Hide();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox3.Show();
            Ticket1.Show();
            label1.Text = "";
        }

        //Win Ticket
        private void v_Click(object sender, EventArgs e)
        {

            label1.Location = new Point(70, 37);
            label1.Text = "";
            pictureBox3.Hide();
            pictureBox1.Hide();
            Thread.Sleep(400);

            Ticket1.Size = new Size(272, 335);
            Ticket1.Location = new Point(102, 117);
            Refresh();  

            //Text Type
            Thread.Sleep(700);
            label1.Text = "You";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " go";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " home,";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " turn";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " on";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " the";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " television";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " and";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " watch.";
            Refresh();
            Thread.Sleep(400);
            tv.Size = new Size(300, 390);
            tv.Location = new Point(75, 90);
            tv.BackgroundImage = new Bitmap(@"C:\Users\student\Desktop\Dylon\Lottery Decisions\Lottery Decisions\Resources\tv.png");
            tv.BackgroundImageLayout = ImageLayout.Zoom;

            label1.Text = "";

            Refresh();
            Thread.Sleep(500);


            label1.Text = "The winning lottery ticket is...";
            Ticket1.Hide();
            Refresh();
            Thread.Sleep(500);
            label2.Location = new Point(133, 317);
            label2.Text = "12   17   34   24 \n  33   41   21";

            Refresh();
            Thread.Sleep(1200);
            label2.Location = new Point(133, 308);
            tv.Hide();

            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 290);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 260);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 220);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 190);
            Thread.Sleep(50);
            label2.Location = new Point(133,160);
            Thread.Sleep(50);
            label2.Location = new Point(133, 110);
            Thread.Sleep(50);
            label2.Location = new Point(133, 65);
            Refresh();
            Thread.Sleep(50);
            Ticket1.Show();

            Refresh();
            Thread.Sleep(3000);
            Ticket1.Hide();
            label2.Text = "";
            label1.Text = "YOU HAVE A $3.2 MILLION \n WINNING LOTTERY TICKET!!!";

            Refresh();
            label1.ForeColor = Color.White;
            Thread.Sleep(500);
            this.BackColor = Color.Maroon;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.White;
            this.BackColor = Color.Maroon;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.White;
            this.BackColor = Color.Maroon;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            label1.Location = new Point(38, 37);

            label1.Text = "What do you do next?";
            label1.Text += "\n \n 1.You yell out to your friend in the next room \n and tell him the great news.";
            label1.Text += "\n\n 2. You grab your keys and immediately drive back \n to the corner store where you bought your ticket.";
            label1.Text += "\n\n 3. You call the number on the screen to find out \n how to cash in your winning ticket.";
            
                
            textBox1.Show();

            button1.Location = new Point(195, 400);
            button1.BackColor = Color.Gainsboro;
            button1.Size = new Size(75, 23);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Refresh();
            Thread.Sleep(1000);
            label1.Text += "\n\n\n\n\n\n\n (write the number of your decision below)";
            
        }
  
        //Win Ticket
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Ticket1.Hide();
            pictureBox1.Hide();
            Thread.Sleep(400);

            pictureBox3.Size = new Size(272, 335);
            pictureBox3.Location = new Point(102, 117);
            Refresh();

            label1.Location = new Point(70, 37);

            //Text Type
            Thread.Sleep(700);
            label1.Text = "You";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " go";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " home,";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " turn";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " on";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " the";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " television";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " and";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " watch.";
            Refresh();
            Thread.Sleep(400);
            tv.Size = new Size(300, 390);
            tv.Location = new Point(75, 90);
            tv.BackgroundImage = new Bitmap(@"C:\Users\student\Desktop\Dylon\Lottery Decisions\Lottery Decisions\Resources\tv.png");
            tv.BackgroundImageLayout = ImageLayout.Zoom;

            label1.Text = "";

            Refresh();
            Thread.Sleep(500);


            label1.Text = "The winning lottery ticket is...";
            pictureBox3.Hide();
            Refresh();
            Thread.Sleep(500);
            label2.Location = new Point(133, 317);
            label2.Text = "11   13   24   24  \n  32   40   41";

            Refresh();
            Thread.Sleep(1200);
            label2.Location = new Point(133, 308);
            tv.Hide();

            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 290);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 260);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 220);
            Refresh();
            Thread.Sleep(50);
            label2.Location = new Point(133, 190);
            Thread.Sleep(50);
            label2.Location = new Point(133, 160);
            Thread.Sleep(50);
            label2.Location = new Point(133, 110);
            Thread.Sleep(50);
            label2.Location = new Point(133, 65);
            Refresh();
            Thread.Sleep(50);
            pictureBox3.Show();

            Refresh();
            Thread.Sleep(3000);
            pictureBox3.Hide();
            label2.Text = "";
            label1.Text = "YOU HAVE A $3.2 MILLION \n WINNING LOTTERY TICKET!!!";

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.White;
            this.BackColor = Color.Maroon;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.White;
            this.BackColor = Color.Maroon;

            Refresh();
            Thread.Sleep(500);
            label1.ForeColor = Color.Black;
            this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(500);


            label1.Location = new Point(38, 37);

            label1.Text = "What do you do next?";
            label1.Text += "\n \n 1.You yell out to your friend in the next room \n and tell him the great news.";
            label1.Text += "\n\n 2. You grab your keys and immediately drive back \n to the corner store where you bought your ticket.";
            label1.Text += "\n\n 3. You call the number on the screen to find out \n how to cash in your winning ticket.";


            textBox1.Show();

            button1.Location = new Point(195, 400);
            button1.BackColor = Color.Gainsboro;
            button1.Size = new Size(75, 23);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Refresh();
            Thread.Sleep(1000);
            label1.Text += "\n\n\n\n\n\n\n (write the number of your decision below)";
        }
        //Lose Ticket
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureBox3.Hide();
            Ticket1.Hide();
            Thread.Sleep(400);

            pictureBox1.Size = new Size(272, 335);
            pictureBox1.Location = new Point(102, 117);
            Refresh();

            label1.Location = new Point(70, 37);
            Thread.Sleep(700);
            label1.Text = "You";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " go";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " in";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " your";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " car,";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " turn";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " on";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " the";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " radio,";
            Refresh();
            Thread.Sleep(400);
            label1.Text += " and";
            Refresh();
            Thread.Sleep(250);
            label1.Text += " listen...";
            Refresh();
            Thread.Sleep(1500);
            label1.Text = "The winning lottery ticket is...";
            Refresh();
            Thread.Sleep(1200);
            label1.Text += "\n \n 11   13   24   24  32   40   41";
            Refresh();
            Thread.Sleep(3200);

            label1.Text = "YOU LOSE!";
        }

        //button


        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button1);
            button1.Dispose();
            textBox1.Hide();
            label1.Location = new Point(38, 37);

            try
            {
                answer = Convert.ToInt16(textBox1.Text);

            }
            catch
            {

            }

            if (answer == 1)
            {

                label1.Text = "You yell out to your friend who is in the next room \n and tell him the good news.";
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n Your friend is excited for you...";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += " \n at first.";
                Refresh();
                Thread.Sleep(1500);
                label1.Text = "As you stare at your lottery ticket in excitement \n he stabs you with a knife and steals your lottery ticket.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n\n\n\n You are dead";
            }
            else if (answer == 2)
            {

                label1.Text = "You immediately drive down to the corner store where \n you bought the lottery ticket to get your money.";
                Refresh();
                Thread.Sleep(3000);
                label1.Location = new Point(23, 37);
                label1.Text = "    On the way, you come across a very busy intersection   ";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n The traffic seems endless and you become very frustrated";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n \n Do you...";
                label1.Text += "\n 1. take a shortcut?";
                label1.Text += "\n \n            or           ";
                label1.Text += "\n \n 2. stay in traffic and wait it out?";

                textBox1.Clear();
                textBox1.Show();

                button2.Location = new Point(195, 400);
                button2.BackColor = Color.Gainsboro;
                button2.Size = new Size(75, 23);
                button2.Click += new EventHandler(button2_Click);
                this.Controls.Add(button2);
            }
            else if (answer == 3)
            {
                label1.Text = "      You pick up the phone and call the number      \n on the screen for more info about \n your winning lottery ticket.";
                Refresh();
                Thread.Sleep(4500);
                label1.Text += "\n\n Once they pick up, you tell them \n you have a winning lottery ticket.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "CONGRATULATIONS sir, come down to the corner \n store where you bought your ticket. A camera \n crew will be waiting for you with your money";
                Refresh();
                Thread.Sleep(5000);
                label1.Text += "\n \n Do you...";
                label1.Text += "\n \n 1. Ride your bike?";
                label1.Text += " \n or ";
                label1.Text += "\n 2. Walk?";
                textBox1.Clear();
                textBox1.Show();
                

                button3.Location = new Point(195, 400);
                button3.BackColor = Color.Gainsboro;
                button3.Size = new Size(75, 23);
                button3.Click += new EventHandler(button3_Click);
                this.Controls.Add(button3);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button2);
            button2.Dispose();
            textBox1.Hide();
            label1.Location = new Point(38, 37);

            try
            {
                answer = Convert.ToInt16(textBox1.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "You take a shortcut by turning right into a tiny street.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n \n  Your shortcut pays off and before you know it \n your just around the corner from the store.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "\n\n As you are turning around the corner you get \n violently hit by a car.";
                Thread.Sleep(4000);
                label1.Text += "\n\n You go into a comma";
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n No one ever cashes in the lottery ticket";
            }
            if (answer == 2)
            {
                label1.Text = "You decide to wait out the traffic";
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n After half an hour the traffic finally ends.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n The traffic made you frustrated so you begin to speed.";

                Refresh();
                Thread.Sleep(2500);
                label1.Text = "As you speed past cars, you hear a siren.";
                //50% chance of being pulled over
                Refresh();
                Thread.Sleep(2000);
                label1.Text += " A cop drives up behind you and pulls you over.";
            }
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button3);
            button3.Dispose();
            textBox1.Hide();
            label1.Location = new Point(38, 37);

            try
            {
                answer = Convert.ToInt16(textBox1.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "You grab your bike from the garage and begin \n to ride it to the corner store.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text = " As you ride your bike, you come across a sad \n looking homeless man with a child laying down \n on the street.";
                Refresh();
                Thread.Sleep(4500);
                label1.Text += "\n\n Do you...\n\n 1.Stop to speak to him. \n\n 2.Keep riding your bike and ignore him.";
                button4.Location = new Point(195, 400);
                button4.BackColor = Color.Gainsboro;
                button4.Size = new Size(75, 23);
                button4.Click += new EventHandler(button4_Click);
                this.Controls.Add(button4);
                textBox1.Clear();
                textBox1.Show();
            }
            if (answer == 2)
            {
                label1.Text = "You step out of your house and begin to walk \n to the corner store.";
                Refresh();
                Thread.Sleep(3500);
                label1.Text = "As you walk through a small, dark alley, \n a mysterious looking man with a hoodie approaches you.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text += "\n\n What do you do? \n \n  1.You instantly begin to run at full \n speed away from the man.";
                label1.Text += "\n \n 2.You ignore the man and continue walking \n at your normal speed.";
                button5.Location = new Point(195, 400);
                button5.BackColor = Color.Gainsboro;
                button5.Size = new Size(75, 23);
                button5.Click += new EventHandler(button5_Click);
                this.Controls.Add(button5);
                textBox1.Clear();
                textBox1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button4);
            button4.Dispose();
            textBox1.Hide();

            try
            {
                answer = Convert.ToInt16(textBox1.Text);

            }
            catch
            {

            }
            if (answer == 1) 
            {
                label1.Text = "Feeling sorry for the homeless man, you stop to speak to him.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "The man tells you his sad, unfortunate situation.";
            }
            if (answer==2)
            {
                label1.Text = "You completely ignore the sad looking man and \n you continue your way to the store.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "You finally arrive at the store!";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "As you walk in to the store, a camera crew meets you.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "A man hands you a huge check with the amount of $3.4 million.";

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button5);
            button5.Dispose();
            textBox1.Hide();

            try
            {
                answer = Convert.ToInt16(textBox1.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "You run at full speed away from the strange man.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n\n You are out of breath but you arrive \n safely to the store.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text ="As you walk in to the store, a camera \n crew is eagerly waiting for you.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n A man holding your huge check asks \n you to see your winning ticket.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text = "You reach into your pocket to grab the ticket...";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n It's not there.";
                label1.Text += "\n You realize the ticket must've fallen out as \n you ran away from the man";
                Refresh();
                Thread.Sleep(4000);
                label1.Text = "The ticket is never found. \n You never get your money.";
            }
            if (answer == 2)
            {
                label1.Text = "You ignore the man and continue walking normally.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n The man comes even closer and steps infront of you.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "The man pulls a knife out of his pocket...";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "He tells you to give him all your money";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "You hand him your entire wallet sadly \n realizing your ticket is in there.";
            }

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Black;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Ticket1_MouseHover(object sender, EventArgs e)
        {

            Ticket1.BackColor = Color.Black;
        } 
            
        private void Ticket1_MouseLeave(object sender, EventArgs e)
        {
            Ticket1.BackColor = Color.Transparent;

        }

       
    }
}
