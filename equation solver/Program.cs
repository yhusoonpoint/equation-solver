using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slove_for_x_V2
{
    class Program
    {
        static decimal x, y, z, xx, firststep, secondstep, thirdstep, output;
        static int n1;
        static void Main()
        {
            Console.Title = "MATHS EQUATIONS SOLVER";         
            Console.CancelKeyPress+=new ConsoleCancelEventHandler(NoCtrlC);
            try
            {
                while (1 == 1)
                {

                    Console.Clear();
                    colourgreen("\n  Welcome to simeon's & Allinson's Maths, Physics and Electronics Equations!!\n                Here is a list of the equations we support. ");
                    colourred("\n1 Quadratic Formular\n2 Potential Divider\n3 Sine Rule\n4 Cosine Rule\n5 Sum to infinity(SERIES)\n6 Sum of nth term(geometric series)\n7 Nth term of geometric sequence\n8 Degree to Radiant\n9 Radiant to Degree\n10 Nth Term for Aritmetric Series\n11 Sum of Nth Term of Aritmetric sequence\n12 Pathagoras\n13 Trapezium Rule");
                    callme();
                    try
                    {
                        string number = Console.ReadLine();
                        
                        n1 = Convert.ToInt16(number);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("I'm sorry, I don't understand that! are you sure we support this equation?");
                        System.Threading.Thread.Sleep(1500);
                        Main();
                    }
                    Console.Clear();
                    switch (n1)
                    {

                        case 1:
                            quadraticformular();
                            break;
                        case 2:
                            potentialodivider();
                            break;
                        case 3:
                            sine();
                            break;
                        case 4:
                            COSINE();
                            break;
                        case 5:
                            sumofinfinity();
                            break;
                        case 6:
                            sumofnthterm();
                            break;
                        case 7:
                            nthtermofgeometricsequence();
                            break;
                        case 8:
                            radiant();
                            break;
                        case 9:
                            radiantin();
                            break;
                        case 10:
                            nthtermforaritmetricseries();
                            break;
                        case 11:
                            sumofnthtermforaritmetricseries();
                            break;
                        case 12:
                            pathagoras();
                            break;
                        case 13:
                            trapeziumrule();
                            break;
                        default:
                            Console.WriteLine("I'm sorry, I don't understand that! are you sure we support this equation?");
                            Console.WriteLine("HIT ENTER TO CONTINUE");
                            Console.ReadLine();
                            Main();
                            break;
                    }


                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message + "  ERROR");
                Console.WriteLine("HIT ENTER");
                Console.ReadLine();
                Console.Clear();
                Main();
            }


        }
        static void colourred(string words)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(words);
            Console.ResetColor();
        }
        static void colourgreen(string words)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(words);
            Console.ResetColor();
        }
        static void callme()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n> ");

        }
        static void colouryellow(string words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(words);
            Console.ResetColor();
        }
        static void colourwhite(string words)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(words);
            Console.ResetColor();
        }
        static void quadraticformular()
        {

            Console.Clear();
            // decimal four = 4;
            colourgreen("\n                             y = Ax^2 + Bx + C");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN A VALUE");
            callme();
            string first = Console.ReadLine();
            decimal a = Convert.ToInt16(first);
            colouryellow("\nTYPE IN B VALUE");
            callme();
            string second = Console.ReadLine();
            decimal b = Convert.ToInt16(second);
            colouryellow("\nTYPE IN C VALUE");
            callme();
            string third = Console.ReadLine();
            decimal c = Convert.ToInt16(third);

            decimal yolo2 = b * b;
            decimal yolo3 = a * c * 4;
            decimal almostans = yolo2 - yolo3;
            try
            {
                decimal notquitethere = (decimal)Math.Sqrt((double)almostans);
           
            decimal divideby = 2 * a;
            decimal ans = -b + notquitethere;
            decimal xxx = ans / divideby;

            decimal ans2 = -b - notquitethere;
            decimal zzz = ans2 / divideby;

            colourwhite("\nX= " + xxx + " or X= " + zzz);

            Console.WriteLine("\nHIT ENTER TO CONTINUE");
             }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("\n"+e.Message);
                Console.WriteLine("\n\nSOMETHING WENT WRONG");
                Console.WriteLine("\nHIT ENTER TO CONTINUE");
                
            }
        }
        static void potentialodivider()
        {
            Console.Clear();
            colourgreen("\n                             POTENTIAL DIVIDER");
            colourred("\nWHAT ARE YOU FINDING\n- Vin(vi)\n- Vout(vo)\n- R1(r1)\n- R2(r2)");
            callme();
            string find = Console.ReadLine();
            Console.Clear();
            switch(find.ToLower())
            {
                case "vi":
                    colourgreen("\n                             POTENTIAL DIVIDER");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN R1");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN R2");
            callme();
            y = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN Vout");
            callme();
            z = decimal.Parse(Console.ReadLine());
            firststep = x + y;
            secondstep = firststep * z;
            thirdstep = secondstep / y;
            colourwhite("\nVin = " + thirdstep + " VOLTS");
                    break;
                case "vo":
                    colourgreen("\n                             POTENTIAL DIVIDER");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN R1");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN R2");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN Vin");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = x + y;
                    secondstep = y / firststep;
                    thirdstep = secondstep * z;
                    colourwhite("\nVout = " + thirdstep + " VOLTS");
                    break;
                case "r1":
                    colourgreen("\n                             POTENTIAL DIVIDER");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN R2");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN Vout");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN Vin");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = x * z;
                    secondstep = x*y;
                    thirdstep = firststep-secondstep;
                    output = thirdstep / y;
                    colourwhite("\nR1 = " + output + " OHMS");
                    break;
                case "r2":
                    colourgreen("\n                             POTENTIAL DIVIDER");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN R1");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN Vout");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN Vin");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = x*y;
                    secondstep = z-y;
                    thirdstep = firststep/secondstep;
                    colourwhite("\nR1 = " + thirdstep +" OHMS");
                    break;
                default:
                    potentialodivider();
                    break;
            }
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void sine()
        {
            Console.Clear();
            colourgreen("\n                                  SINE RULE");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colourred("\nWHAT ARE YOU FINDING - \n side(a) or side(b) or angle(A) or angle (B)");
            callme();
            string input = Console.ReadLine();
            Console.Clear();


            switch (input)
            {
                case "a":
                    colourgreen("\n                                  SINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN ANGLE A");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN ANGLE B");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE b");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = z * (decimal)Math.Sin((double)x * (Math.PI / 180.0));
                    secondstep = (decimal)Math.Sin((double)y * (Math.PI / 180.0));
                    thirdstep = firststep / secondstep;
                    colourwhite("\nSIDE a =" + thirdstep);
                    break;
                case "b":
                    colourgreen("\n                                  SINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN ANGLE A");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN ANGLE B");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE a");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    firststep = xx * (decimal)Math.Sin((double)x * (Math.PI / 180.0));
                    secondstep = (decimal)Math.Sin((double)y * (Math.PI / 180.0));
                    thirdstep = firststep / secondstep;
                    colourwhite("\nSIDE b =" + thirdstep);
                    break;
                case "A":
                    colourgreen("\n                                  SINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN ANGLE B");
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE a");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE b");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = xx * (decimal)Math.Sin((double)y * (Math.PI / 180.0));
                    secondstep = firststep / z;
                    thirdstep = (Decimal)Math.Acos((double)secondstep) * (decimal)(180.0 / Math.PI);
                    colourwhite("\n ANGLE A =" + thirdstep);
                    break;
                case "B":
                    colourgreen("\n                                  SINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN ANGLE A");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE a");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN SIDE b");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = xx * (decimal)Math.Sin((double)x * (Math.PI / 180.0));
                    secondstep = firststep / z;
                    thirdstep = (Decimal)Math.Acos((double)secondstep) * (decimal)(180.0 / Math.PI);
                    colourwhite("\n ANGLE A =" + thirdstep);
                    break;
                default:
                    Console.Clear();
                    sine();
                    break;
            }
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void COSINE()
        {
            Console.Clear();
            colourgreen("\n                                  COSINE RULE");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colourred("\nWHAT ARE YOU FINDING - a2 = b2 + c2 - 2bcCosA \nside(a) or side(b) or side(c) or angle(A) or angle (B) or angle(C)\nITS CASE SENTITIVE\nFOR angle(A) type in A\nFOR side(a) type in a");
            callme();
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                #region sidea
                case "a":
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\na2 = b2 + c2 - 2bcCosA ");
                    colouryellow("\ntype in b");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in c");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in angle A");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    firststep = (decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2);
                    secondstep = 2 * y * z * (decimal)Math.Cos((double)xx * (Math.PI / 180.0));
                    thirdstep = firststep - secondstep;
                    output = (Decimal)Math.Sqrt((double)thirdstep);
                    colourwhite("\nSIDE A =" + output);
                    break;
                #endregion
                #region sideb
                case "b":
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\nb2 = a2 + c2 - 2acCosB ");
                    colouryellow("\ntype in a");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in c");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in angle B");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    firststep = (decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2);
                    secondstep = 2 * y * z * (decimal)Math.Cos((double)xx * (Math.PI / 180.0));
                    thirdstep = firststep - secondstep;
                    output = (Decimal)Math.Sqrt((double)thirdstep);
                    colourwhite("\nSIDE B =" + output);
                    break;
                #endregion
                #region sidec
                case "c":
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\nc2 = a2 + b2 - 2abCosC ");
                    colouryellow("\ntype in a");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in b");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in angle c");
                    callme();
                    xx = decimal.Parse(Console.ReadLine());
                    firststep = (decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2);
                    secondstep = 2 * y * z * (decimal)Math.Cos((double)xx * (Math.PI / 180.0));
                    thirdstep = firststep - secondstep;
                    output = (Decimal)Math.Sqrt((double)thirdstep);
                    colourwhite("\nSIDE C =" + output);
                    break;
                #endregion
                #region anglea
                case "A":
                    
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\na2 = b2 + c2 - 2bcCosA ");
                    colouryellow("\ntype in a");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in b");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in c");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = ((decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2)) - (decimal)Math.Pow((double)x, 2);
                    secondstep = 2 * y * z;
                    thirdstep = firststep / secondstep;
                    output = (Decimal)Math.Acos((double)thirdstep) * (decimal)(180.0 / Math.PI);
                    colourwhite("\nANGLE A =" + output);
                    break;
                #endregion
                #region angleb
                case "B":
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\nb2 = a2 + c2 - 2bcCosB ");
                    colouryellow("\ntype in a");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in b");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in c");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = ((decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2)) - (decimal)Math.Pow((double)x, 2);
                    secondstep = 2 * y * z;
                    thirdstep = firststep / secondstep;
                    output = (Decimal)Math.Acos((double)thirdstep) * (decimal)(180.0 / Math.PI);
                    colourwhite("\nANGLE B =" + output);
                    break;
                #endregion
                #region anglec
                case "C":
                    colourgreen("\n                                  COSINE RULE");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colourgreen("\nc2 = b2 + a2 - 2bcCosC ");
                    colouryellow("\ntype in a");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\ntype in b");
                    callme();
                    y = decimal.Parse(Console.ReadLine()); ;
                    colouryellow("\ntype in c");
                    callme();
                    z = decimal.Parse(Console.ReadLine());
                    firststep = ((decimal)Math.Pow((double)y, 2) + (decimal)Math.Pow((double)z, 2)) - (decimal)Math.Pow((double)x, 2);
                    secondstep = 2 * y * z;
                    thirdstep = firststep / secondstep;
                    output = (Decimal)Math.Acos((double)thirdstep) * (decimal)(180.0 / Math.PI);
                    colourwhite("\nANGLE C =" + output);
                    break;
                default:
                    Console.Clear();
                    COSINE();
                    break;
                #endregion
            }
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void sumofinfinity()
        {
            Console.Clear();
            colourgreen("\n                     GEOMETRIC SERIES - SUM TO INFINITY");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\n TYPE IN THE VALUE OF THE COMMON RATIO r");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALVE OF THE FIRST TERM a");
            callme();
            y = decimal.Parse(Console.ReadLine());
            if (x > 1)
            {
                Console.Clear();
            colourgreen("\n                     GEOMETRIC SERIES - SUM TO INFINITY");
                Console.WriteLine("\nR CANNOT BE GREATER THAN 1");
                Console.WriteLine("\nHIT ENTER TO CONTINUE");
                Console.ReadLine();
                sumofinfinity();
            }
            else
            {
                firststep = 1 - x;
                secondstep = y / firststep;
                colourwhite("\nSUM TO INFINITY = " + secondstep);
                Console.WriteLine("\nHIT ENTER TO CONTINUE");
            }
        }
        static void sumofnthterm()
        {
            Console.Clear();
            colourgreen("\n                 SUM OF nth TERM FOR GEOMNETRICS SERIES");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN THE VALUE OF FIRST TERM a");
            callme();
            y = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF COMMON RATIO r");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF nth TERM n");
            callme();
            z = decimal.Parse(Console.ReadLine());
            if (x < 1)
            {
                firststep = 1 - (decimal)Math.Pow((double)x, (double)z);
                secondstep = y * firststep;
                thirdstep = 1 - x;
                output = secondstep / thirdstep;
                colourwhite("\nSUM OF NTH TERM = " + output);
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
            }
            else if (x > 1)
            {
                firststep = (decimal)Math.Pow((double)x, (double)z) - 1;
                secondstep = y * firststep;
                thirdstep = x - 1;
                output = secondstep / thirdstep;
                colourwhite("\nSUM OF NTH TERM = " + output);
                Console.WriteLine("\nHIT ENTER TO CONTINUE");
            }
            else
            {
                Console.WriteLine("\nr can never be 1 by the way");
                Console.WriteLine("\nHIT ENTER TO CONTINUE");
                Console.ReadLine();
                sumofnthterm();
            }
        }
        static void nthtermofgeometricsequence()
        {
            Console.Clear();
            colourgreen("\n                        NTH TERM OF A GEOMETRIC SAEQUENCE");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN THE VALUE OF FIRST TERM a");
            callme();
            y = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF COMMON RATIO r");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF NTH TERM n");
            callme();
            z = decimal.Parse(Console.ReadLine());
            firststep = z - 1;
            secondstep = y * (decimal)Math.Pow((double)x, (double)firststep);
            colourwhite("\nnTH TERM = " + secondstep);
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void radiant()
        {
            Console.Clear();
            colourgreen("\n                           DEGREES TO RADIANT CONVETER");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                colouryellow("\nEnter the degrees");
                callme();
                string first = Console.ReadLine();
               decimal a = Convert.ToInt16(first);
                a = a / 180;
           
            colourwhite("\nRadiant = " + a + "PI");
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void radiantin()
        {
            Console.Clear();
            decimal a;
            colourgreen("\n                           RADIANT TO DEGREES CONVETER");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colourred("\nIS PIE BESIDE THE RADIANT OR NOT (example: 4/3'pi')? Y/N");
            callme();
            string yes = Console.ReadLine().ToLower();
            if (yes == "y" || yes == "yes")
            {
            Console.Clear();
            colourgreen("\n                           RADIANT TO DEGREES CONVETER");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nEnter the radiant without pie");
            callme();
            a = decimal.Parse(Console.ReadLine());
            a = a * 180; 
            colourwhite("\nDegrees = " + a +" DEGREES");
            }
            else
            {
            Console.Clear();
            colourgreen("\n                           RADIANT TO DEGREES CONVETER");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nEnter the radiant");
            callme();
            a = decimal.Parse(Console.ReadLine());
            a = (a * 180)/ (decimal)Math.PI; 
            colourwhite("\nDegrees = " + a +" DEGREES");                    
            }
           
            Console.WriteLine("\nHIT ENTER TO CONTINUE");


        }
        static void nthtermforaritmetricseries()
        {
            Console.Clear();
            colourgreen("\n                       THE NTH TERM FOR ARITMETRIC SERIES");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN THE VALUE OF FIRST TERM a");
            callme();
            y = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF COMMON difference d");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF NTH TERM n");
            callme();
            z = decimal.Parse(Console.ReadLine());
            firststep = z - 1;
            secondstep = firststep * x;
            thirdstep = y + secondstep;

            colourwhite("\nnth term = "+thirdstep);
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void sumofnthtermforaritmetricseries()
        {
            Console.Clear();
            colourgreen("\n                    SUM OF NTH TERM FOR ARITMETRIC SERIES");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colourred("\nIS THERE A LAST TERM? Y/N");
            callme();
            string YES = Console.ReadLine().ToLower();
            if (YES == "y" || YES == "yes")
            {
                Console.Clear();
                colourgreen("\n                    SUM OF NTH TERM FOR ARITMETRIC SERIES");
                colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                colouryellow("\nTYPE IN THE VALUE OF FIRST TERM a");
                callme();
                y = decimal.Parse(Console.ReadLine());
                colouryellow("\nTYPE IN THE VALUE OF LAST TERM l");
                callme();
                x = decimal.Parse(Console.ReadLine());
                colouryellow("\nTYPE IN THE VALUE OF NTH TERM n");
                callme();
                z = decimal.Parse(Console.ReadLine());
                firststep = y + x;
                output = firststep * ((decimal)0.5 * z);
            }
            else
            {
                Console.Clear();
                colourgreen("\n                    SUM OF NTH TERM FOR ARITMETRIC SERIES");
                colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                colouryellow("\nTYPE IN THE VALUE OF FIRST TERM a");
                callme();
                y = decimal.Parse(Console.ReadLine());
                colouryellow("\nTYPE IN THE VALUE OF COMMON difference d");
                callme();
                x = decimal.Parse(Console.ReadLine());
                colouryellow("\nTYPE IN THE VALUE OF NTH TERM n");
                callme();
                z = decimal.Parse(Console.ReadLine());
                firststep = z - 1;
                secondstep = firststep * x;
                thirdstep = (2 * y) + secondstep;
                output = ((decimal)0.5 * z) * thirdstep;
            }
            colourwhite("\nSn = " + output);
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void pathagoras()
        {
            Console.Clear();
            colourgreen("\n                                  PATHAGORAS");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colourred("\nWHAT ARE YOU FINDING \n- HYPOTHENOUS(h)\n- OPPOSITE(o)\n- ADJACENT(a)");
            callme();
            string answer = Console.ReadLine();
            switch(answer.ToLower())
            {
                case"h":
                    Console.Clear();
            colourgreen("\n                                  PATHAGORAS");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN THE VALUE OF OPPOSITE SIDE");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF ADJACENT SIDE");
            callme();
            y = decimal.Parse(Console.ReadLine());
            firststep = (decimal)Math.Pow((double)x, 2);
            secondstep = (decimal)Math.Pow((double)y, 2);
            thirdstep = firststep + secondstep;
            output = (decimal)Math.Sqrt((double)thirdstep);
            colourwhite("\nHYPOTHENOUS = " + output);
            break;
                case "o":
            Console.Clear();
            colourgreen("\n                                  PATHAGORAS");
            colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
            colouryellow("\nTYPE IN THE VALUE OF HYPOTHENOUS SIDE");
            callme();
            x = decimal.Parse(Console.ReadLine());
            colouryellow("\nTYPE IN THE VALUE OF ADJACENT SIDE");
            callme();
            y = decimal.Parse(Console.ReadLine());
            firststep = (decimal)Math.Pow((double)x, 2);
            secondstep = (decimal)Math.Pow((double)y, 2);
            thirdstep = firststep - secondstep;
            output = (decimal)Math.Sqrt((double)thirdstep);
            colourwhite("\nOPPOSITE = " + output);
                    break;
                case "a":
                    Console.Clear();
                    colourgreen("\n                                  PATHAGORAS");
                    colourred("\nIF ITS IN FRACTION, CONVERT TO DECIMAL");
                    colouryellow("\nTYPE IN THE VALUE OF HYPOTHENOUS SIDE");
                    callme();
                    x = decimal.Parse(Console.ReadLine());
                    colouryellow("\nTYPE IN THE VALUE OF OPPOSITE SIDE");                   
                    callme();
                    y = decimal.Parse(Console.ReadLine());
                    firststep = (decimal)Math.Pow((double)x, 2);
                    secondstep = (decimal)Math.Pow((double)y, 2);
                    thirdstep = firststep - secondstep;
                    output = (decimal)Math.Sqrt((double)thirdstep);
                    colourwhite("\nADJACENT = " + output);
                    break;
                default:
                    pathagoras();
                    break;
            }
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        static void trapeziumrule() 
        {
            colourgreen("\n                               TRAPEZIUM RULE");
            colourred("\nTYPE IN THE NUMBERS OF Y'S YOU HAVE");
            callme();
            int arraynumber = int.Parse(Console.ReadLine());
            decimal[] yvalues = new decimal[arraynumber];
            colouryellow("\nTYPE IN THE THE VALUE OF h");
            callme();
            x = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < yvalues.Length; i++)
            {
                colouryellow("\nTYPE IN Y"+i);
                callme();
                yvalues[i] = decimal.Parse(Console.ReadLine());
            }
            decimal summiddlevalue = 0;
            for (int i = 1; i < yvalues.Length-1; i++)
            {
                summiddlevalue += yvalues[i];              
            }
            firststep = 2 * summiddlevalue;
            secondstep = yvalues.First() + yvalues.Last();
            thirdstep = firststep + secondstep;
            output = (x / 2) * thirdstep;
            colourwhite("\nESTIMATED AREA UNDER THE CURVE IS " + output);
            Console.WriteLine("\nHIT ENTER TO CONTINUE");
        }
        protected static void NoCtrlC(object sender, ConsoleCancelEventArgs c) 
        {
            c.Cancel = true;
        }
    
    }
}
