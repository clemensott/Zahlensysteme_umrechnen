using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlensysteme_umrechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void dud_von_TextChanged(object sender, EventArgs e)
        {
            int zahl = 0;

            try
            {
                zahl = Convert.ToInt32(dud_von.Text);

                dud_von.Text = Convert.ToString(zahl);
            }
            catch
            {
                lbl_fehler.Text = "Eingangszahlensystem nicht möglich";
                lbl_fehler.Visible = true;

                txb_zu.Text = "Problem";
            }

            if (zahl > 16 || zahl < 2)
            {
                lbl_fehler.Text = "Eingangszahlensystem nicht möglich";
                lbl_fehler.Visible = true;

                txb_zu.Text = "Problem";
            }
            else
            {
                berechnen();
            }
        }

        private void dud_zu_TextChanged(object sender, EventArgs e)
        {
            int zahl = 0;

            try
            {
                zahl = Convert.ToInt32(dud_zu.Text);

                dud_zu.Text = Convert.ToString(zahl);
            }
            catch
            {
                lbl_fehler.Text = "Ausgangszahlensystem nicht möglich";
                lbl_fehler.Visible = true;

                txb_zu.Text = "Problem";
            }

            if (zahl > 16 || zahl < 2)
            {
                lbl_fehler.Text = "Ausgangszahlensystem nicht möglich";
                lbl_fehler.Visible = true;

                txb_zu.Text = "Problem";
            }
            else
            {
                berechnen();
            }
        }

        private void berechnen()
        {
            if (dud_von.Text != "" && dud_zu.Text != "")
            {
                int von_sys, zu_sys, zwisch = 0, i, j, x = 0, y, zusatz_1 = 0, zusatz_2 = 0;
                int[] von_zahl = new int[20];
                int[] wert = new int[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                double größe;
                bool fehler = false, schalt = true, groß = false, groß_von = false;
                string test, ein, ein_o, aus = "";
                string[] zeichen = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
                string[] geschrieben = new string[15] { "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun", "zehn", "elf", "zwölf", "dreizehn", "vierzehn", "fünfzehn", "sechzehn" };
                string[] zu_zahl = new string[20];
                char[] sechszehn = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

                von_sys = Convert.ToInt32(dud_von.Text);
                zu_sys = Convert.ToInt32(dud_zu.Text);
                ein_o = txb_von.Text;
                ein = ein_o;
                test = ein_o;

                for (i = 0; schalt; i++)
                {
                    for (j = 0; j < von_sys; j++)
                    {
                        test = test.TrimStart(sechszehn[j]);
                    }

                    if (test == ein)
                    {
                        schalt = false;
                        fehler = true;
                    }
                    else
                    {
                        ein = test;
                    }

                    if (test == "")
                    {
                        schalt = false;
                    }
                }
                
                ein = ein_o;

                if (ein != "")
                {
                    test = ein;

                    i = 0;

                    do
                    {
                        i++;

                        test = test.Remove(0, 1);

                    } while (test != "");
                }
                else
                {
                    fehler = true;
                }

                if (!fehler && i <= 20)
                {
                    lbl_fehler.Visible = false;

                    test = ein;

                    i = -1;

                    do
                    {
                        i++;

                        test = test.Remove(0, 1);

                    } while (test != "");
                                                                 
                    if (i != 0)
                    {
                        for (y = 0; y <= i; y++)
                        {
                            test = ein.Remove(0, (i - y));
                            test = test.Remove(1, y);

                            for (j = 0; j < von_sys; j++)
                            {
                                if (test == zeichen[j])
                                {
                                    von_zahl[y] = j;
                                }
                            }
                        }
                    }                        
                    else
                    {
                        for (j = 0; j < von_sys; j++)
                        {
                            if (ein == zeichen[j])
                            {
                                von_zahl[0] = j;
                            }
                        }
                    }

                if(!groß_von)
                {
                    for (y = 0; y <= i; y++)
                    {
                        zusatz_1 = x;
                        
                        if (y == 0)
                        {
                            x = 1;
                        }
                        else
                        {
                            x = x * von_sys;

                            zusatz_2 = x;
                            zusatz_1 = zusatz_2 / zusatz_1;

                            if (zusatz_1 != von_sys)
                            {
                                groß = true;
                            }
                        }

                        größe = zwisch + von_zahl[y] * x;

                        if (größe >= 0 && größe < 2147483647 && x > 0)
                        {
                            zusatz_1 = von_zahl[y] * x;
                            zusatz_2 = zusatz_1 / x;

                            if (zusatz_2 == von_zahl[y])
                            {
                                zwisch = zwisch + zusatz_1;
                            }
                            else
                            {
                                groß = true;
                            }
                            
                        }
                        else
                        {
                            groß = true;
                        }
                    }
                }
                else
                {
                    größe = Convert.ToDouble(ein);
                    
                    if (größe <= 2147483647)
                    {
                        zwisch = Convert.ToInt32(ein);
                    }
                    else 
                    {
                        groß = true;
                    }
                }

                if (!groß && !groß_von)
                {
                    if (zwisch != 0)
                    {
                        try
                        {                            
                            for (i = 0; zwisch != 0; i++)
                            {
                                zu_zahl[i] = Convert.ToString(zwisch % zu_sys);
                                
                                if (Convert.ToInt32(zu_zahl[i]) >= 10)
                                {
                                    schalt = true;
                                    
                                    for (j = 10; schalt; j++)
                                    {
                                        if (Convert.ToInt32(zu_zahl[i]) == j)
                                        {
                                           zu_zahl[i] = zeichen[j];
                                            
                                            schalt = false;
                                        }
                                    }
                                }

                                zwisch = zwisch / zu_sys;
                            }
                        }
                        catch
                        {
                            aus = "Problem";
                            
                            lbl_fehler.Text = "Ausgangszahlensystem zu klein";
                            lbl_fehler.Visible = true;

                            i = 0;
                        }
                    }
                    else
                    {
                        zu_zahl[0] = "0";

                        i = 1;
                    }
                                               
                    for (j = 0; j != i; j++)
                    {
                        aus = zu_zahl[j] + aus;
                    }
                       
                }
                else
                {
                    if (!groß)
                    {
                        aus = Convert.ToString(zwisch);
                    }
                    else
                    {
                        aus = "Problem";
                        
                        lbl_fehler.Text = "Zahl zu groß";
                        lbl_fehler.Visible = true;                          
                    }
                }

                txb_zu.Text = aus;
                    
                }
                else
                {
                    txb_zu.Text = "Problem";

                    if (fehler)
                    {
                        lbl_fehler.Text = "Zahl kann nicht umgerechnet werden";
                    }
                    else
                    {
                        lbl_fehler.Text = "Zahl zu lang";
                    } 
                    
                    lbl_fehler.Visible = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dud_von.Text = "10";
            dud_zu.Text = "10";
        }

        private void txb_von_TextChanged(object sender, EventArgs e)
        {
            berechnen();

        }
    }
}
