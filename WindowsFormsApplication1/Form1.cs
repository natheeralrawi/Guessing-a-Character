using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


      
        static string[,] p = {
                      { "Darwin      ", "1", "0", "0", "0", "1", "0", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0","0"},
                      { "pastor        ", "1", "0", "0", "0", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "1", "0","0" },
                      { "AbnAlnafss    ", "1", "1", "0", "0", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1","0" },
                      { "MaryQury      ", "0", "0", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "1", "0", "0","0" },
                      { "Jaber binHyan ", "1", "1", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "1", "0","0"},
                      { "AhmedZowel    ", "1", "1", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0", "1","0"},
                      { "AlfreadNobel  ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0","1"},
                      { "Enshtian      ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "1", "0", "0", "1", "0", "0","0"},
                      {"Niuten         ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "1", "0", "0", "0", "1", "0","0"},
                      {"StephnHwking   ", "1", "0", "1", "1", "1", "0", "0", "0", "0", "0", "1", "0", "0", "0", "0", "1","0"},
                      {"Galelo         ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0","1"},
                      {"Turing         ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1", "0", "1", "0", "0","0"},
                      {"Ada            ", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1", "0", "0", "1", "0","0"},
                      {"TemNet         ", "1", "0", "0", "1", "1", "0", "0", "0", "0", "0", "0", "1", "0", "0", "0", "1","0"},
                      {"JhonNewman     ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1", "0", "0", "0", "0","1"},
                      {"khwarzmi       ", "1", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "1", "1", "0", "0","0"},
                      {"Phethgors      ", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "0","0"},
                      {"Gaus           ", "1", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "1","0"},
                      {"AnglenaJolle   ", "0", "0", "1", "1", "0", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0","0"},
                      {"LeonardoDeCaper", "1", "0", "1", "1", "0", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0", "0","0"},
                      {"NasirAlKasbi   ", "1", "1", "1", "1", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0", "0","0"},
                      {"KadimAlSaher   ", "1", "1", "1", "1", "0", "1", "0", "0", "0", "0", "0", "1", "0", "0", "0", "0","0"},
                      {"IamKalthom     ", "0", "1", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1", "0", "0", "0","0"},
                      {"MichelJackson  ", "1", "0", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0","0"},
                      {"Messi          ", "1", "0", "1", "1", "0", "0", "1", "0", "1", "0", "0", "0", "0", "0", "0", "0","0"},
                      {"CRonaldo       ", "1", "0", "1", "1", "0", "0", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0","0"},
                      {"MohammedAliKlay", "1", "0", "1", "0", "0", "0", "1", "0", "0", "0", "1", "0", "0", "0", "0", "0","0"},
                      {"Nadal          ", "1", "0", "1", "1", "0", "0", "1", "0", "0", "0", "0", "1", "0", "0", "0", "0","0"},
                      {"YounisMahmod   ", "1", "1", "1", "1", "0", "0", "1", "0", "0", "0", "0", "0", "1", "0", "0", "0","0"},
                      {"MichelPhelps   ", "1", "0", "1", "1", "0", "0", "1", "0", "0", "0", "0", "0", "0", "1", "0", "0","0"},
                      {"IbrahimLincholn", "1", "0", "0", "0", "0", "0", "0", "1", "1", "0", "0", "0", "0", "0", "0", "0","0"},
                      {"Hitler         ", "1", "0", "0", "0", "0", "0", "0", "1", "0", "1", "0", "0", "0", "0", "0", "0","0"},
                      {"KhalefaBinZaaid", "1", "1", "1", "1", "0", "0", "0", "1", "0", "0", "1", "0", "0", "0", "0", "0","0"},
                      {"","","","","","","","","","","","","","","","","",""}};






        static string[] a = { "Is The Character a Male ?", "Is The Character Arabic ?", "Is The Character Appear on TV ?", "Is The Character Live now ?",
                         "Is The Character Specialized in Science ?", "Is The Character Specialized in Arts ?",
                         "Is The Character Specialized in Sports ?"," Is The Character Specialized in Policies ?" };
        static string[] b = { " Is The Character Specialized in Biology ?", " Is The Character Specialized in Chemistry ?",
                         "Is The Character Specialized in Physics ?",
                 " Is The Character Specialized in Computers ?", " Is The Character Specialized in Mathematics ?" };
        static string[] c = { "Is The Character Had put the Evolution Theory ?", "Is the Character the Inventor of pasteurization ?",
                         "Is The Character the discoverer of the Pulmonary Circulation ?" };
        static string[] d = { "Is the Character had Receives Two Nobel Prizes in Chemistry and physics and The Discoverer of the Radium and Polonium elements ? ",
                         "Is the Character was The Frist Person who uses the Chemistry in Practical ?",
                         "Is the Character was the First and Only arabic person who receive a Nobel prize in Chemistry ? ", "Is The Character the Inventor of Dynamite and Donated by His Wealth for Nobel prize ?" };
        static string[] ph = { "Is the Character had put the Relative Theory ?", "Is the Character had put the Gravity Laws ? ",
                         "Is the Character had put the Big bang Theory ?", "Is the Character that was the First person who said that the Earth is Spherical ?" };

        static string[] comp ={"Is The Character The Designer of Turing Machine that Consider as The Base of Modern Computer Sciences?",
                           "Is the Character the First Female programmer and honored By Name a Programming Language by Her Name?",
                          "Is The Character the inventor of World Wide Web?",
                           "Is The Character The Maker of the Main Parts of the Computer (I/O, CPU, and Memory)?"};
        static string[] math = { "Is The Character the Author of Al Moktasar Fe Hesab Al Jabur Wa Al Mokabala?",
                                   "Is The Character Had put the Pythagoras Theory?",
                               "Is The Character Called as the Prince of Math and Considered As The one of The Three Sciences in Math History?" };
        static string[] act ={"Is The Character Worked as the Goodwill Ambassador in United Nation and Have Receive an Oscar Prize and Three Golden Globe Prizes too?",
"Is The Character Act As the Starring in Titanic Movie and Have Receive the Oscar Prize for the Revenant Movie in 2016?",
"Is The Character Was One of The Judgment Member in Arab Got Talent and Actor in Selfie Series?",
"Is The Character Called the Caesar of Arabic Songs?",
"Is The Character Called the Kawkaba Al Sharq?",
"Is The Character Called the King of POP and Classify The Most Successful and Important Music Star in History?"};

        static string[] sport = { "Is The Character Playing in FCB and Have Receive a Five Golden Balls? ",
                                  "Is The Character Playing in Real Madrid and Have Receive a Four Golden Balls?",
                                  "Is The Character Called the Athlete of Century and have the most fast and Strong Punch in the World?",
                                   "Is The Character Called the King of Playgrounds?",
                                   "Is the Character Have Achieve the Wining for Iraq in Asian Nations Cup in 2007 and Called In Iraq Al Safah?",
                                    "Is the Character Have Receive a 23 Golden Medal in Swimming Sport?"};
        static string[] pol = {"Is the Character one of USA President and the Unified of America?",
"Is the Character The Leader and Founder of Nazi?",
"Is the Character Name have used to Name the Highest Tower in the World and Considered as the Fourth Richer King in The World?"};
       static string[] oi = new string[p.GetLength(1)];
        static int z=0, zzz=-1; static string r;
        static string[,] n = new string[p.GetLength(0), 18];
        static int init, init2, init3, i = 0, point = 0;
     
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
              string[] lll = Directory.GetFiles(@"pictures1", "*jpg");
        Image[] aaaaa = new Image[3];
            z = 0; zzz = -1; i = 0; point = 0;
            init = init2 = init3 = 0;
            label1.Text = a[init];
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true; 
            init++; label2.Text = lll.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              string[] list = Directory.GetFiles(@"pictures", "*jpg");
        Image[] im = new Image[35];
       string[]lista = Directory.GetFiles(@"pictures1", "*jpg");
            if (radioButton1.Checked)
                r = "1";
            else if (radioButton2.Checked)
                r = "0";

            
            if (z == 0)
       {
                        oi[point] = r;
                        point++;


                        if (init >4 && r == "1")
                            z = i;
                        else { label1.Text = a[init];
                        init++;}
                if (z == 4)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    label1.Text = b[init2]; init2++;
                for (int tt = point; tt < 8; tt++)
                oi[tt] = "0";
                point = 8;
                    }
                else if (z == 5)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    label1.Text = act[init2]; init2++;
                for (int tt = point; tt < 8; tt++)
                    oi[tt] = "0";
                point = 8;
                }
                else if (z == 6)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false; 

                    label1.Text = sport[init2]; init2++;
                    for (int tt = point; tt < 8; tt++)
                        oi[tt] = "0";
                    point = 8;
                }
                else if (z == 7)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    label1.Text = pol[init2]; init2++;
                for (int tt = point; tt < 8; tt++)
                    oi[tt] = "0";
                point = 8;
                }
                i++;
            
     }//end if
else if (z == 4)
{
         if (zzz == -1)
         {


             oi[point] = r;
             point++;

             if (r == "1")
             { zzz = init2 - 1; }
             if (zzz == 0)
             {
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = true;
                 pictureBox4.Visible = false;
                 label1.Text = c[init3]; init3++;
             for (int tt = point; tt < 13; tt++)
                 oi[tt] = "0";
             point = 13;
             }
             else if (zzz == 1)
             {
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = true;
                 pictureBox4.Visible = false;
                 label1.Text = d[init3]; init3++;
             for (int tt = point; tt < 13; tt++)
                 oi[tt] = "0";
             point = 13;
             }
             else if (zzz == 2)
             {
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = true;
                 pictureBox4.Visible = false; 

                 label1.Text = ph[init3]; init3++;
             for (int tt = point; tt < 13; tt++)
                 oi[tt] = "0";
             point = 13;
             }
             else if (zzz == 3)
             {
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = true;
                 pictureBox4.Visible = false;
                 label1.Text = comp[init3]; init3++;
             for (int tt = point; tt < 13; tt++)
                 oi[tt] = "0";
             point = 13;
             }
             else if (zzz == 4)
             {
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = true;
                 pictureBox4.Visible = false; 

                 label1.Text = math[init3]; init3++; for (int tt = point; tt < 13; tt++)
                     oi[tt] = "0";
                 point = 13;
             }

             else { label1.Text = b[init2]; init2++; }
         }
         else if (zzz == 0)
         {
             pictureBox2.Visible = false;
             pictureBox3.Visible = true;
             pictureBox4.Visible = false; 

             oi[point] = r;
             point++;


             if (r == "1")
             {

                 for (int ee = 0; ee < p.GetLength(0); ee++)
                 {
                     int u2 = 1;
                     for (int bb = 1; bb <= point; bb++)
                         if (p[ee, bb] != oi[bb - 1])
                         { u2 = 0; break; }
                     if (u2 == 1)
                     {
                         pictureBox1.Visible = true;
                         pictureBox2.Visible = true; ;
                         pictureBox3.Visible = false;
                         pictureBox4.Visible = false;
                         label2.Visible = true;
                         label2.Text ="You Think In "+ p[ee, 0];
                         listBox1.Items.Add("you think in  " + p[ee, 0]);
                         pictureBox1.Image = Image.FromFile(list[ee]);
                         
                     }
                 }

             }
             else
             { label1.Text = c[init3]; init3++; }

         }
         else if (zzz == 1)
         {
             pictureBox2.Visible = false;
             pictureBox3.Visible = true;
             pictureBox4.Visible = false; 

             oi[point] = r;
             point++;


             if (r == "1")
             {

                 for (int ee = 0; ee < p.GetLength(0); ee++)
                 {
                     int u2 = 1;
                     for (int bb = 1; bb <= point; bb++)
                         if (p[ee, bb] != oi[bb - 1])
                         { u2 = 0; break; }
                     if (u2 == 1)
                     {
                         pictureBox2.Visible = true; ;
                         pictureBox3.Visible = false; ;
                         pictureBox4.Visible = false;
                         label2.Visible = true;
                         label2.Text = "You Think In " + p[ee, 0];
                         listBox1.Items.Add("you think in  " + p[ee, 0]);
                         pictureBox1.Visible = true;
                         pictureBox1.Image = Image.FromFile(lista[ee-3]);
                     }
                 }

             }
             else
             { label1.Text = d[init3]; init3++; }
         }
         else if (zzz == 2)
         {
             pictureBox2.Visible = false;
             pictureBox3.Visible = true;
             pictureBox4.Visible = false; 

             oi[point] = r;
             point++;


             if (r == "1")
             {

                 for (int ee = 0; ee < p.GetLength(0); ee++)
                 {
                     int u2 = 1;
                     for (int bb = 1; bb <= point; bb++)
                         if (p[ee, bb] != oi[bb - 1])
                         { u2 = 0; break; }
                     if (u2 == 1)
                     {
                         string[] l2 = Directory.GetFiles(@"pictures2", "*jpg");
                         pictureBox2.Visible = true; ;
                         pictureBox3.Visible = false; ;
                         pictureBox4.Visible = false;
                         pictureBox1.Visible = true;
                         listBox1.Items.Add("you think in  " + p[ee, 0]);
                         if(ee-7==0)
                         pictureBox1.Image = Image.FromFile(l2[2]);
                         else if(ee-7==1)
                               pictureBox1.Image = Image.FromFile(l2[3]);
                         else if(ee-7==2)  
                             pictureBox1.Image = Image.FromFile(l2[0]);
                         else if(ee-7==3)
                               pictureBox1.Image = Image.FromFile(l2[1]);
                         
                     }
                 }

             }
             else
             { label1.Text = ph[init3]; init3++; }
         }

         else if (zzz == 3)
         {
             pictureBox2.Visible = false;
             pictureBox3.Visible = true;
             pictureBox4.Visible = false; 

             oi[point] = r;
             point++;


             if (r == "1")
             {

                 for (int ee = 0; ee < p.GetLength(0); ee++)
                 {
                     int u2 = 1;
                     for (int bb = 1; bb <= point; bb++)
                         if (p[ee, bb] != oi[bb - 1])
                         { u2 = 0; break; }
                     if (u2 == 1)
                     {
                        string[]l3= Directory.GetFiles(@"pictures3", "*jpg");
                         pictureBox2.Visible = true; ;
                         pictureBox3.Visible = false;
                         pictureBox4.Visible = false;

                         label2.Visible = true;
                         label2.Text = "You Think In " + p[ee, 0];
                         pictureBox1.Visible = true;
                         listBox1.Items.Add("you think in  " + p[ee, 0]);
                         pictureBox1.Image = Image.FromFile(l3[ee-11]);
                     }
                 }

             }
             else
             { label1.Text = comp[init3]; init3++; }
         }
         else if (zzz == 4)
         {
             pictureBox2.Visible = false;
             pictureBox3.Visible = true;
             pictureBox4.Visible = false; 

             oi[point] = r;
             point++;


             if (r == "1")
             {

                 for (int ee = 0; ee < p.GetLength(0); ee++)
                 {
                     int u2 = 1;
                     for (int bb = 1; bb <= point; bb++)
                         if (p[ee, bb] != oi[bb - 1])
                         { u2 = 0; break; }
                     if (u2 == 1)
                     {
                         string[] l4 = Directory.GetFiles(@"pictures4", "*jpg");
                         pictureBox2.Visible = true;
                         pictureBox3.Visible = false;
                         pictureBox4.Visible = false;

                         pictureBox1.Visible = true;
                         label2.Visible = true;
                         label2.Text = "You Think In " + p[ee, 0];
                         listBox1.Items.Add("you think in  " + p[ee, 0]);
                         pictureBox1.Image = Image.FromFile(l4[ee-15]);
                     }
                 }

             }
             else
             { label1.Text = math[init3]; init3++; }
         }


}
else if (z == 5)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false; 

                oi[point] = r;
                point++;


                if (r == "1")
                {

                    for (int ee = 0; ee < p.GetLength(0); ee++)
                    {
                        int u2 = 1;
                        for (int bb = 1; bb <= point; bb++)
                            if (p[ee, bb] != oi[bb - 1])
                            { u2 = 0; break; }
                        if (u2 == 1)
                        {
                            string[] l5 = Directory.GetFiles(@"pictures5", "*jpg");
                            pictureBox2.Visible = true; ;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            label2.Visible = true;
                            pictureBox1.Visible = true;
                            label2.Text = "You Think In " + p[ee, 0];
                            listBox1.Items.Add("you think in  " + p[ee, 0]);
                            pictureBox1.Image = Image.FromFile(l5[ee-18]);
                        }
                    }

                }
                else
                { label1.Text = act[init2]; init2++; }
}
else if(z==6)
{
    pictureBox2.Visible = false;
    pictureBox3.Visible = true;
    pictureBox4.Visible = false; 

                oi[point] = r;
                point++;


                if (r == "1")
                {

                    for (int ee = 0; ee < p.GetLength(0); ee++)
                    {
                        int u2 = 1;
                        for (int bb = 1; bb <= point; bb++)
                            if (p[ee, bb] != oi[bb - 1])
                            { u2 = 0; break; }
                        if (u2 == 1)
                        {
                            string[] l6 = Directory.GetFiles(@"pictures6", "*jpg");
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox1.Visible = true;
                            label2.Visible = true;
                            label2.Text = "You Think In " + p[ee, 0];

                            listBox1.Items.Add("you think in  " + p[ee, 0]);
                            pictureBox1.Image = Image.FromFile(l6[ee-24]);
                        }
                    }

                }
                else
                { label1.Text = sport[init2]; init2++; }
}
else if (z == 7)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false; 

                oi[point] = r;
                point++;


                if (r == "1")
                {
                  

                    for (int ee = 0; ee < p.GetLength(0); ee++)
                    {
                        int u2 = 1;
                        for (int bb = 1; bb <= point; bb++)
                            if (p[ee, bb] != oi[bb - 1])
                            { u2 = 0; break; }
                        if (u2 == 1)
                        {
                          string[]l7=  Directory.GetFiles(@"pictures7", "*jpg");
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox1.Visible = true;
                            label2.Visible = true;
                            label2.Text = "You Think In " + p[ee, 0];

                        label2.Text="you think in  " + p[ee, 0];
                        pictureBox1.Image = Image.FromFile(l7[ee-30]);
                           
                        }
                    }

                }
                else
                { label1.Text = pol[init2]; init2++; }
}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 mm = new Form2();
            mm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

    

       

        
    }
}
