using System;
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
        Button button6 = new Button();
        Button button7 = new Button();
        Button button8 = new Button();
        Button button9 = new Button();

        bool restarted = false;
        bool canClick = false;
        //form loads up
        private void Form1_Load(object sender, EventArgs e)
        {
                answerBox.Hide();
                label1.Text = "Choose a Ticket";
                ticket3.Hide();
                ticket2.Hide();
                ticket1.Hide();
            canClick = true;
            
        }
        
        //click screen to start
        private void Form1_Click(object sender, EventArgs e)
        {
            if (canClick == true)
            {
                ticket3.Show();
                ticket2.Show();
                ticket1.Show();
                label1.Text = "";
            }
        }

        //Win Ticket
        private void v_Click(object sender, EventArgs e)
        {
            canClick = false;
            label1.Location = new Point(70, 37);
            label1.Text = "";
            ticket2.Hide();
            ticket3.Hide();
            Thread.Sleep(400);

            ticket1.Size = new Size(272, 335);
            ticket1.Location = new Point(102, 117);
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
            tv.Show();

            label1.Text = "";

            Refresh();
            Thread.Sleep(500);


            label1.Text = "The winning lottery ticket is...";
            ticket1.Hide();
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
            ticket1.Show();

            Refresh();
            Thread.Sleep(3000);
            ticket1.Hide();
            label2.Text = "";
            label1.Font = new Font("Microsoft Sans Serif",20,FontStyle.Bold);
            label1.Location = new Point(35, 37);
            label1.Text = "\n\n\n\nYOU HAVE A $3.2 MILLION \n WINNING LOTTERY TICKET!!!";

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
            label1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

            label1.Text = "What do you do next?";
            label1.Text += "\n \n 1.You yell out to your friend in the next room \n and tell him the great news.";
            label1.Text += "\n\n 2. You grab your keys and immediately drive back \n to the corner store where you bought your ticket.";
            label1.Text += "\n\n 3. You call the number on the screen to find out \n how to cash in your winning ticket.";
            
                
            answerBox.Show();
            if (restarted == false)
            {
                button1.Location = new Point(195, 400);
                button1.BackColor = Color.Gainsboro;
                button1.Size = new Size(75, 23);
                button1.Click += new EventHandler(button1_Click);
                button1.Text = "ENTER";
                this.Controls.Add(button1);
            }
            else
            {
                answerBox.Clear();
                button1.Show();
            }

            Refresh();
            Thread.Sleep(1000);
            label1.Text += "\n\n\n\n\n\n\n (write the number of your decision below)";
            
        }
  
        //Win Ticket
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            canClick = false;
            label1.Text = "";
            ticket1.Hide();
            ticket3.Hide();
            Thread.Sleep(400);

            ticket2.Size = new Size(272, 335);
            ticket2.Location = new Point(102, 117);
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
            ticket2.Hide();
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
            ticket2.Show();

            Refresh();
            Thread.Sleep(3000);
            ticket2.Hide();
            label2.Hide();
            label1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            label1.Location = new Point(35, 37);
            label1.Text = "\n\n\n\nYOU HAVE A $3.2 MILLION \n WINNING LOTTERY TICKET!!!";

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
            label1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

            label1.Text = "What do you do next?";
            label1.Text += "\n \n 1.You yell out to your friend in the next room \n and tell him the great news.";
            label1.Text += "\n\n 2. You grab your keys and immediately drive back \n to the corner store where you bought your ticket.";
            label1.Text += "\n\n 3. You call the number on the screen to find out \n how to cash in your winning ticket.";


            answerBox.Show();
            if (restarted == false)
            {
                button1.Location = new Point(195, 400);
                button1.BackColor = Color.Gainsboro;
                button1.Size = new Size(75, 23);
                button1.Click += new EventHandler(button1_Click);
                button1.Text = "ENTER";
                this.Controls.Add(button1);
            }
            else
            {
                answerBox.Clear();
                button1.Show();
            }

            Refresh();
            Thread.Sleep(1000);
            label1.Text += "\n\n\n\n\n\n\n (write the number of your decision below)";
        }
        //Lose Ticket
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            canClick = false;
            label1.Text = "";
            ticket2.Hide();
            ticket1.Hide();
            Thread.Sleep(400);

            ticket3.Size = new Size(272, 335);
            ticket3.Location = new Point(102, 117);
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
            ticket3.Hide();
            Refresh();
            Thread.Sleep(2000);

            label1.Text = "\n\n\n\n        YOU LOSE!        ";

            Refresh();
            Thread.Sleep(1000);

            //play again or restart
            Refresh();
            Thread.Sleep(2000);
            label1.Text += "\n\n\n\n\n\n               Play Again?              ";
            //Play Again button
            button6.Location = new Point(155, 400);
            button6.BackColor = Color.Gainsboro;
            button6.Size = new Size(75, 23);
            button6.Text = "YES";
            button6.Click += new EventHandler(button6_Click);
            this.Controls.Add(button6);
            //Close form 
            button7.Location = new Point(255, 400);
            button7.BackColor = Color.Gainsboro;
            button7.Size = new Size(75, 23);
            button7.Text = "NO";
            button7.Click += new EventHandler(button7_Click);
            this.Controls.Add(button7);
        }

        

        //first decision button
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Controls.Remove(button1);
            button1.Hide();
            answerBox.Hide();
            label1.Location = new Point(38, 37);

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

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
                //play again or restart
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n\n\n\n\n               Play Again?              ";
                //Play Again button
                button6.Location = new Point(155, 400);
                button6.BackColor = Color.Gainsboro;
                button6.Size = new Size(75, 23);
                button6.Text = "YES";
                button6.Click += new EventHandler(button6_Click);
                this.Controls.Add(button6);
                //Close form 
                button7.Location = new Point(255, 400);
                button7.BackColor = Color.Gainsboro;
                button7.Size = new Size(75, 23);
                button7.Text = "NO";
                button7.Click += new EventHandler(button7_Click);
                this.Controls.Add(button7);
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
                label1.Text += "\n \n What do you do?.";
                label1.Text += "\n \n 1. Take a shortcut?";
                label1.Text += "\n \n 2. Stay in traffic and wait it out?";

                answerBox.Clear();
                answerBox.Show();

                if (restarted == false)
                {
                    button2.Location = new Point(195, 400);
                    button2.BackColor = Color.Gainsboro;
                    button2.Size = new Size(75, 23);
                    button2.Click += new EventHandler(button2_Click);
                    button2.Text = "ENTER";
                    this.Controls.Add(button2);
                }
                else
                {
                    answerBox.Clear();
                    button2.Show();
                }
                
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
                answerBox.Clear();
                answerBox.Show();
                

                button3.Location = new Point(195, 400);
                button3.BackColor = Color.Gainsboro;
                button3.Size = new Size(75, 23);
                button3.Click += new EventHandler(button3_Click);
                button3.Text = "ENTER";
                this.Controls.Add(button3);

            }
            else
            {
                button1.Show();
                answerBox.Show();
            }
        }

        //second decision button
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            answerBox.Hide();

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "     You take a shortcut by turning right into a tiny street.     ";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n \n  Your shortcut pays off and before you know it \n your just around the corner from the store.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "\n\n      As you are turning around the corner you get      \n violently hit by a car.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text += "\n\n You go into a comma.";
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n No one ever cashes in the lottery ticket.";
                //Play again or restart
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n\n\n\n\n               Play Again?              ";
                //Play Again button
                button6.Location = new Point(155, 400);
                button6.BackColor = Color.Gainsboro;
                button6.Size = new Size(75, 23);
                button6.Text = "YES";
                button6.Click += new EventHandler(button6_Click);
                this.Controls.Add(button6);
                //Close form 
                button7.Location = new Point(255, 400);
                button7.BackColor = Color.Gainsboro;
                button7.Size = new Size(75, 23);
                button7.Text = "NO";
                button7.Click += new EventHandler(button7_Click);
                this.Controls.Add(button7);
            }
            if (answer == 2)
            {
                int chanceValue;
                Random randNum = new Random();                chanceValue = randNum.Next(1, 11);
                label1.Text = "              You decide to wait out the traffic              ";
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n After half an hour the traffic finally ends.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text = "\n\n The traffic made you frustrated so you begin to speed.";

                Refresh();
                Thread.Sleep(2500);
                label1.Text += "\n\n\n\n\n\n     As you speed past cars, you hear a siren.     ";
                //picture of siren
                Refresh();
                Thread.Sleep(2000);
                //50% chance of being pulled over
                if (chanceValue >= 5)
                {
                    label1.Text = " \n         A cop drives up behind you and pulls you over.        ";
                    Refresh();
                    Thread.Sleep(2000);
                    label1.Text += "\n \n The cop tells you, you were driving 50 km above \n  the speed limit.";
                    Refresh();
                    Thread.Sleep(4000);
                    label1.Text += "\n He begins to write you a ticket.";
                    Refresh();
                    Thread.Sleep(2000);
                    label1.Text = "\n        Before he finishes writing it, you consider bribing him.";
                    Refresh();
                    Thread.Sleep(3000);
                    label1.Text += "\n Do you go through with it?";
                    label1.Text += "\n\n 1.Yes";
                    label1.Text += "\n\n 2.No";

                    answerBox.Clear();
                    answerBox.Show();

                    if (restarted == false)
                    {
                        button9.Location = new Point(195, 400);
                        button9.BackColor = Color.Gainsboro;
                        button9.Size = new Size(75, 23);
                        button9.Click += new EventHandler(button9_Click);
                        button9.Text = "ENTER";
                        this.Controls.Add(button9);
                    }
                    else
                    {
                        answerBox.Clear();
                        button2.Show();
                    }

                }
                if (chanceValue < 5)
                {
                    label1.Text += " \n A cop drives past you in a hurry and \n luckily ignores the fact you were speeding.";
                    Refresh();
                    Thread.Sleep(5000);
                    label1.Text = "You continue driving to the corner store.";
                }
                
            }
            else
            {
                button2.Show();
                answerBox.Show();
            }
        
        }
        //third decision button
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            answerBox.Hide();
            label1.Location = new Point(38, 37);

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "You grab your bike from the garage and begin \n to ride it to the corner store.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text = " As you ride your bike, you come across a sad \n looking homeless man with a dog laying down \n on the street.";
                Refresh();
                Thread.Sleep(4500);
                label1.Text += "\n\n Do you...\n\n 1.Stop to speak to him. \n\n 2.Keep riding your bike and ignore him.";
                button4.Location = new Point(195, 400);
                button4.BackColor = Color.Gainsboro;
                button4.Size = new Size(75, 23);
                button4.Click += new EventHandler(button4_Click);
                button4.Text = "ENTER";
                this.Controls.Add(button4);
                answerBox.Clear();
                answerBox.Show();
            }
            if (answer == 2)
            {
                label1.Text = "You step out of your house and begin to walk \n to the corner store.";
                Refresh();
                Thread.Sleep(3500);
                label1.Text = "As you walk through a small, dark alley, \n a mysterious looking man with a hoodie approaches you.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text += "\n\n            What do you do?           \n \n  1.You instantly begin to run at full \n speed away from the man.";
                label1.Text += "\n \n 2.You ignore the man and continue walking \n at your normal speed.";
                button5.Location = new Point(195, 400);
                button5.BackColor = Color.Gainsboro;
                button5.Size = new Size(75, 23);
                button5.Click += new EventHandler(button5_Click);
                button5.Text = "ENTER";
                this.Controls.Add(button5);
                answerBox.Clear();
                answerBox.Show();
            }
            else { }
        }
        //fourth decision
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            answerBox.Hide();

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

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
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "    Knowing you just won the lottery, you decide    \n to help him out.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "You ask the man to go with you to the corner store";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "...Moments later you both arrive at the store";
                Refresh();
                Thread.Sleep(2500);
                label1.Text = "   As you both walk in to the store, a camera crew meets you  .";
                Thread.Sleep(3000);
                label1.Text += "A man hands you a huge check with the amount of $3.4 million.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "You tell them you are going to give the homeless man \n a portion of your money.";
                Refresh();
                label1.Text += "Everyone is amazed by your generosity.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text = "Days later...\n The homeless man cleans up his life and you \n spend the rest of your life travelling and having fun.";
                Thread.Sleep(5000);
                //play again or restart
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n\n\n\n\n               Play Again?              ";
                //Play Again button
                button6.Location = new Point(155, 400);
                button6.BackColor = Color.Gainsboro;
                button6.Size = new Size(75, 23);
                button6.Text = "YES";
                button6.Click += new EventHandler(button6_Click);
                this.Controls.Add(button6);
                //Close form 
                button7.Location = new Point(255, 400);
                button7.BackColor = Color.Gainsboro;
                button7.Size = new Size(75, 23);
                button7.Text = "NO";
                button7.Click += new EventHandler(button7_Click);
                this.Controls.Add(button7);
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
                Refresh();
                Thread.Sleep(3500);
                label1.Text = "As you walk home to enjoy the rest of your life as \n a rich man, you come across the homeless \n man again.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "\n         The homeless man's dog attacks you.         ";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n You try to defend yourself but you are unsuccesful.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "The violent dog, viciously bites your neck.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\nYou begin to bleed out and before you know it...";
                Refresh();
                Thread.Sleep(2500);
                label1.Text += "\n You are dead";
                //play again or restart
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n\n\n\n\n               Play Again?              ";
                //Play Again button
                button6.Location = new Point(155, 400);
                button6.BackColor = Color.Gainsboro;
                button6.Size = new Size(75, 23);
                button6.Text = "YES";
                button6.Click += new EventHandler(button6_Click);
                this.Controls.Add(button6);
                //Close form 
                button7.Location = new Point(255, 400);
                button7.BackColor = Color.Gainsboro;
                button7.Size = new Size(75, 23);
                button7.Text = "NO";
                button7.Click += new EventHandler(button7_Click);
                this.Controls.Add(button7);

            }
        }
        //fifth decision
        private void button5_Click(object sender, EventArgs e)
        {

            button5.Hide();
            answerBox.Hide();

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

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
                label1.Text = "As you walk in to the store, a camera \n crew is eagerly waiting for you.";
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
                label1.Text += "\n He tells you to give him all your money.";
                Refresh();
                Thread.Sleep(2000);
                label1.Text += "\n\n What do you do?";
                label1.Text += "\n\n 1.Do exactly as the man says.";
                label1.Text += "\n\n 2.Try to take the knife from the man.";
                label1.Text += "\n\n 3.Run away.";
                answerBox.Clear();
                answerBox.Show();
                button8.Location = new Point(195, 400);
                button8.BackColor = Color.Gainsboro;
                button8.Size = new Size(75, 23);
                button8.Click += new EventHandler(button8_Click);
                button8.Text = "ENTER";
                this.Controls.Add(button8);
                //play again or restart
                Refresh();
                Thread.Sleep(1000);
                label1.Text += "\n\n\n\n\n\n                    Play Again?                   ";
                //Play Again button
                button6.Location = new Point(155, 400);
                button6.BackColor = Color.Gainsboro;
                button6.Size = new Size(75, 23);
                button6.Text = "YES";
                button6.Click += new EventHandler(button6_Click);
                this.Controls.Add(button6);
                //Close form 
                button7.Location = new Point(255, 400);
                button7.BackColor = Color.Gainsboro;
                button7.Size = new Size(75, 23);
                button7.Text = "NO";
                button7.Click += new EventHandler(button7_Click);
                this.Controls.Add(button7);
            }
            else
            {
                button5.Show();
                answerBox.Show();
            }


        }
        //sixth decision
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
            answerBox.Hide();

            try
            {
                answer = Convert.ToInt16(answerBox.Text);
            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "\n You hand him your entire wallet sadly \n realizing your ticket is in there.";
                Refresh();
                Thread.Sleep(3000);
                label1.Text = "The man leaves you unharmed but you no \n longer have your winning ticket.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text += "\n YOU LOSE!";
            }
            if (answer == 2)
            {
                label1.Text = "      You successfully pull the knife away from the man     ";
                Refresh();
                Thread.Sleep(3000);
                label1.Text += "You point the knife at the man and threaten to kill him.";
                Refresh();
                Thread.Sleep(4000);
                label1.Text += "The man backs down and runs away.";
                Refresh();
                Thread.Sleep(2000);
            }
            else
            {
                button8.Show();
                answerBox.Show();
            }
        }
        //7th decision
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            answerBox.Hide();

            try
            {
                answer = Convert.ToInt16(answerBox.Text);

            }
            catch
            {

            }
            if (answer == 1)
            {
                label1.Text = "You decide to bribe the officer.";
            }
        }

        //Play Again button
        private void button6_Click(object sender, EventArgs e)
        {
            canClick = true;
            this.Controls.Remove(button6);
            button6.Dispose();
            this.Controls.Remove(button7);
            button7.Dispose();

            answerBox.Hide();
            label1.Location = new Point(163, 138);
            label1.Text = "Choose a Ticket";
            ticket3.Location = new Point(143, 234);
            ticket2.Location = new Point(244, 10);
            ticket1.Location = new Point(61, 12);
            ticket1.Size = new Size(177, 218);
            ticket2.Size = new Size(177, 218);
            ticket3.Size = new Size(177, 218);
            ticket3.Hide();
            ticket2.Hide();
            ticket1.Hide();
            restarted = true;
        }
        
        //Close Form button
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ticket2.BackColor = Color.Black;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ticket2.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ticket3.BackColor = Color.Black;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ticket3.BackColor = Color.Transparent;
        }

        private void Ticket1_MouseHover(object sender, EventArgs e)
        {

            ticket1.BackColor = Color.Black;
        } 
            
        private void Ticket1_MouseLeave(object sender, EventArgs e)
        {
            ticket1.BackColor = Color.Transparent;

        }

       
    }
}
