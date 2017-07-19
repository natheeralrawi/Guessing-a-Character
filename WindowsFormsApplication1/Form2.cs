using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
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

        static string[,] pp = new string[10, p.GetLength(1)];




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
"Is The Character Called the King of POP and Classify The Most Successful and Important Music Star in History?",""};

        static string[] sport = { "Is The Character Playing in FCB and Have Receive a Five Golden Balls? ",
                                  "Is The Character Playing in Real Madrid and Have Receive a Four Golden Balls?",
                                  "Is The Character Called the Athlete of Century and have the most fast and Strong Punch in the World?",
                                   "Is The Character Called the King of Playgrounds?",
                                   "Is the Character Have Achieve the Wining for Iraq in Asian Nations Cup in 2007 and Called In Iraq Al Safah?",
                                    "Is the Character Have Receive a 23 Golden Medal in Swimming Sport?",""};
        static string[] pol = {"Is the Character one of USA President and the Unified of America?",
"Is the Character The Leader and Founder of Nazi?",
"Is the Character Name have used to Name the Highest Tower in the World and Considered as the Fourth Richer King in The World?",""};
       static string[] oi = new string[p.GetLength(1)];
        static int z=0, zzz=-1; static string r;
        static string[,] n = new string[p.GetLength(0), 18];                     


        static int init, init2, init3, i = 0,ooo=0, point = 0,con=-1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                r = "1";
            else if (radioButton2.Checked)
                r = "0";


            if (z == 0)
            {
                oi[point] = r;
                point++;


                if (init > 4 && r == "1")
                    z = i;
                else
                {
                    label1.Text = a[init];
                    init++;
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
                        label1.Text = c[init3]; init3++;
                        for (int tt = point; tt < 13; tt++)
                            oi[tt] = "0";
                        point = 13;
                    }
                    else if (zzz == 1)
                    {
                        label1.Text = d[init3]; init3++;
                        for (int tt = point; tt < 13; tt++)
                            oi[tt] = "0";
                        point = 13;
                    }
                    else if (zzz == 2)
                    {
                        label1.Text = ph[init3]; init3++;
                        for (int tt = point; tt < 13; tt++)
                            oi[tt] = "0";
                        point = 13;
                    }
                    else if (zzz == 3)
                    {
                        label1.Text = comp[init3]; init3++;
                        for (int tt = point; tt < 13; tt++)
                            oi[tt] = "0";
                        point = 13;
                    }
                    else if (zzz == 4)
                    {
                        label1.Text = math[init3]; init3++; for (int tt = point; tt < 13; tt++)
                            oi[tt] = "0";
                        point = 13;
                    }

                    else { label1.Text = b[init2]; init2++; }
                }
                else if (zzz == 0)
                {


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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = c[init3]; init3++; }

                }
                else if (zzz == 1)
                {

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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = d[init3]; init3++; }
                }
                else if (zzz == 2)
                {
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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = ph[init3]; init3++; }
                }

                else if (zzz == 3)
                {
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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = comp[init3]; init3++; }
                }
                else if (zzz == 4)
                {

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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = math[init3]; init3++; }
                }


            }
            else if (z == 5)
            {
                for(int ii=point;ii<oi.Length;ii++)
                oi[ii] = "0";
                oi[12]="1";
            }
            else if (z == 6)
            {for(int ii=point;ii<oi.Length;ii++)
                oi[ii] = "0";
                oi[15]="1";
                pol[3] = textBox1.Text;
                n[33, 0] = textBox2.Text;
                for (int uu = 1; uu < oi.Length; uu++)
                    n[33, uu] = oi[uu];
            }
            else if (z == 7)
            {
                for(int ii=point;ii<oi.Length;ii++)
                oi[ii] = "0";
                oi[12]="1";
                point = oi.Length;
                pol[3] = textBox1.Text;
                pp[ooo, 0] = textBox2.Text;
                for (int uu = 1; uu < oi.Length; uu++)
                    pp[ooo, uu] = oi[uu];
                ooo++;

            }
    
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            z = 0; zzz = -1; i = 0; point = 0;
            init = init2 = init3 = 0;
            label1.Text = a[init];
            init++;
            con = -1;
        }
       static string ggg;
        private void button3_Click(object sender, EventArgs e)
        {



            listBox1.Items.Add(pp[0, 0] + "&&" + pp[0, 1] + "&" + pp[0, 2] + "&&" + pp[0, 3] + "&" + pp[0, 4] + "&&" + pp[0, 5] + "&&" + pp[0, 6] + "&&" + pp[0, 7] + "&&" + pp[0, 8] + "&&" + pp[0, 9] + "&&" + pp[0, 10] + "&&" + pp[0, 11] + "&&" + pp[0, 12] + "&&" + pp[0, 13] + "&&" + pp[0, 14] + "&&" + pp[0, 15] + "&&" + pp[0, 16] + "&&" + pp[0, 17]);
       
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
                r = "1";
            else if (radioButton2.Checked)
                r = "0";
            else if (radioButton3.Checked)
                r = "2";
            else radioButton1.Name = "yes";

            if (r == "0" || r == "1")
            {
                if (z == 0)
                {
                    oi[point] = r;
                    point++;


                    if (init > 4 && r == "1")
                        z = i;
                    else
                    {
                        label1.Text = a[init];
                        init++;
                    }
                    if (z == 4)
                    {
                        label1.Text = b[init2]; init2++;
                        for (int tt = point; tt < 8; tt++)
                            oi[tt] = "0";
                        point = 8;
                    }
                    else if (z == 5)
                    {
                        label1.Text = act[init2]; init2++;
                        for (int tt = point; tt < 8; tt++)
                            oi[tt] = "0";
                        point = 8;
                    }
                    else if (z == 6)
                    {
                        label1.Text = sport[init2]; init2++;
                        for (int tt = point; tt < 8; tt++)
                            oi[tt] = "0";
                        point = 8;
                    }
                    else if (z == 7)
                    {
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
                            label1.Text = c[init3]; init3++;
                            for (int tt = point; tt < 13; tt++)
                                oi[tt] = "0";
                            point = 13;
                        }
                        else if (zzz == 1)
                        {
                            label1.Text = d[init3]; init3++;
                            for (int tt = point; tt < 13; tt++)
                                oi[tt] = "0";
                            point = 13;
                        }
                        else if (zzz == 2)
                        {
                            label1.Text = ph[init3]; init3++;
                            for (int tt = point; tt < 13; tt++)
                                oi[tt] = "0";
                            point = 13;
                        }
                        else if (zzz == 3)
                        {
                            label1.Text = comp[init3]; init3++;
                            for (int tt = point; tt < 13; tt++)
                                oi[tt] = "0";
                            point = 13;
                        }
                        else if (zzz == 4)
                        {
                            label1.Text = math[init3]; init3++; for (int tt = point; tt < 13; tt++)
                                oi[tt] = "0";
                            point = 13;
                        }

                        else { label1.Text = b[init2]; init2++; }
                    }
                    else if (zzz == 0)
                    {


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
                                    listBox1.Items.Add("you think in  " + p[ee, 0]);

                            }

                        }
                        else
                        { label1.Text = c[init3]; init3++; }

                    }
                    else if (zzz == 1)
                    {

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
                                    listBox1.Items.Add("you think in  " + p[ee, 0]);

                            }

                        }
                        else
                        { label1.Text = d[init3]; init3++; }
                    }
                    else if (zzz == 2)
                    {
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
                                    listBox1.Items.Add("you think in  " + p[ee, 0]);

                            }

                        }
                        else
                        { label1.Text = ph[init3]; init3++; }
                    }

                    else if (zzz == 3)
                    {
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
                                    listBox1.Items.Add("you think in  " + p[ee, 0]);

                            }

                        }
                        else
                        { label1.Text = comp[init3]; init3++; }
                    }
                    else if (zzz == 4)
                    {

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
                                    listBox1.Items.Add("you think in  " + p[ee, 0]);

                            }

                        }
                        else
                        { label1.Text = math[init3]; init3++; }
                    }


                }
                else if (z == 5)
                {
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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = act[init2]; init2++; }
                }
                else if (z == 6)
                {
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
                                listBox1.Items.Add("you think in  " + p[ee, 0]);

                        }

                    }
                    else
                    { label1.Text = sport[init2]; init2++; }
                }
                else if (z == 7)
                {
                    oi[point] = r;
                    point++;


                    if (r == "1")
                    {


                        for (int ee = 0; ee < p.GetLength(0); ee++)
                        {
                            int u2 = 1;
                            for (int bb = 1; bb <= point; bb++)
                            {
                                if (bb != con)
                                {
                                    if (p[ee, bb] != oi[bb - 1])
                                    { u2 = 0; break; }
                                }
                            }
                            if (u2 == 1)
                                listBox1.Items.Add("you think in  " + p[ee, 0]);
                        }
                            for (int ii = 0; ii < pp.GetLength(0); ii++)
                            {
                                int u5 = 1;
                                for (int jj = 1; jj <= point; jj++)
                                    if (pp[ii, jj] != oi[jj])
                                    { u5 = 0; break; }
                                if (u5 == 1)
                                    listBox1.Items.Add(pp[ii, 0]);
                            }

                            listBox1.Items.Add(oi[0] + "&&" + oi[1] + "&" + oi[2] + "&&" + oi[3] + "&" + oi[4] + "&&" + oi[5] + "&&" + oi[6] + "&&" + oi[7] + "&&" + oi[8] + "&&" + oi[9] + "&&" + oi[10] + "&&" + oi[11] + "&&" + oi[12] + "&&" + oi[13] + "&&" + oi[14] + "&&" + oi[15] + "&&" + oi[16] + "&&" + oi[17]);
       
                    }
                    else
                    { label1.Text = pol[init2]; init2++; }
                }
            }

            else
            {
                i++; con = point;
                oi[point] = r;
                point++;
                if (z == 0)
                {
                    label1.Text = a[init]; init++;
                }
                else if (z == 4)
                {

                    if (zzz == 0)
                    { label1.Text = c[init3]; init3++; }
                 else if (zzz == 1)
                    { label1.Text = d[init3]; init3++; }
                
                else if (zzz == 2)
                { label1.Text = ph[init3]; init3++; }
                else if (zzz == 3)
                { label1.Text = comp[init3]; init3++; }
                    else if (zzz == 0)
                    { label1.Text = math[init3]; init3++; }
                    else
                    { label1.Text = b[init2]; init2++; }
                }
                else if(z==5)
                {label1.Text = act[init2]; init2++;}
                 else if(z==6)
                {label1.Text = sport[init2]; init2++;}
                 else if(z==7)
                {label1.Text = pol[init2]; init2++;}
            }
        }
    }

        
    }

