using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            bool doLoop = true;
            int counter = 0;
            string eMessage = "This is an invalid input.";

            while (doLoop) 
            {
                bool doSwitch = true;
                Console.WriteLine("Please input a letter.");
                string input = Console.ReadLine();
                input = input.ToLower();
                int inputL = input.Length;
                int inputNum;

                if (inputL > 1) 
                {
                    Console.WriteLine("The input should only have one character.");
                    doSwitch = false;
                }

                if (int.TryParse(input, out inputNum))
                {
                    Console.WriteLine("The input should not be a number.");
                    doSwitch = false;
                }

                if (doSwitch)
                {
                    counter++;

                    if (counter == 1)
                    {
                        switch (input)
                        {
                            case "a":
                                output += "b";
                                Console.WriteLine(output);
                                break;

                            case "b":
                                output += "c";
                                Console.WriteLine(output);
                                break;

                            case "c":
                                output += "d";
                                Console.WriteLine(output);
                                break;

                            case "d":
                                output += "e";
                                Console.WriteLine(output);
                                break;

                            case "e":
                                output += "f";
                                Console.WriteLine(output);
                                break;

                            case "f":
                                output += "g";
                                Console.WriteLine(output);
                                break;

                            case "g":
                                output += "h";
                                Console.WriteLine(output);
                                break;

                            case "h":
                                output += "i";
                                Console.WriteLine(output);
                                break;

                            case "i":
                                output += "j";
                                Console.WriteLine(output);
                                break;

                            case "j":
                                output += "k";
                                Console.WriteLine(output);
                                break;

                            case "k":
                                output += "l";
                                Console.WriteLine(output);
                                break;


                            case "l":
                                output += "m";
                                Console.WriteLine(output);
                                break;

                            case "m":
                                output += "n";
                                Console.WriteLine(output);
                                break;

                            case "n":
                                output += "o";
                                Console.WriteLine(output);
                                break;

                            case "o":
                                output += "p";
                                Console.WriteLine(output);
                                break;

                            case "p":
                                output += "q";
                                Console.WriteLine(output);
                                break;

                            case "q":
                                output += "r";
                                Console.WriteLine(output);
                                break;

                            case "r":
                                output += "s";
                                Console.WriteLine(output);
                                break;

                            case "s":
                                output += "t";
                                Console.WriteLine(output);
                                break;

                            case "t":
                                output += "u";
                                Console.WriteLine(output);
                                break;

                            case "u":
                                output += "v";
                                Console.WriteLine(output);
                                break;

                            case "v":
                                output += "w";
                                Console.WriteLine(output);
                                break;

                            case "w":
                                output += "x";
                                Console.WriteLine(output);
                                break;

                            case "x":
                                output += "y";
                                Console.WriteLine(output);
                                break;

                            case "y":
                                output += "z";
                                Console.WriteLine(output);
                                break;

                            case "z":
                                output += "a";
                                Console.WriteLine(output);
                                break;

                            case " ":
                                output += "_";
                                Console.WriteLine(output);
                                break;

                            case "!":
                                doLoop = false;
                                break;

                            default:
                                Console.WriteLine(eMessage);
                                break;
                        }
                    }

                    else
                    {
                        switch (input)
                        {
                            case "a":
                                output = "b" + output + "b";
                                Console.WriteLine(output);
                                break;

                            case "b":
                                output = "c" + output + "c";
                                Console.WriteLine(output);
                                break;

                            case "c":
                                output = "d" + output + "d";
                                Console.WriteLine(output);
                                break;


                            case "d":
                                output = "e" + output + "e";
                                Console.WriteLine(output);
                                break;

                            case "e":
                                output = "f" + output + "f";
                                Console.WriteLine(output);
                                break;

                            case "f":
                                output = "g" + output + "g";
                                Console.WriteLine(output);
                                break;

                            case "g":
                                output = "h" + output + "h";
                                Console.WriteLine(output);
                                break;


                            case "h":
                                output = "i" + output + "i";
                                Console.WriteLine(output);
                                break;

                            case "i":
                                output = "j" + output + "j";
                                Console.WriteLine(output);
                                break;

                            case "j":
                                output = "k" + output + "k";
                                Console.WriteLine(output);
                                break;

                            case "k":
                                output = "l" + output + "l";
                                Console.WriteLine(output);
                                break;


                            case "l":
                                output = "m" + output + "m";
                                Console.WriteLine(output);
                                break;

                            case "m":
                                output = "n" + output + "n";
                                Console.WriteLine(output);
                                break;

                            case "n":
                                output = "o" + output + "o";
                                Console.WriteLine(output);
                                break;

                            case "o":
                                output = "p" + output + "p";
                                Console.WriteLine(output);
                                break;

                            case "p":
                                output = "q" + output + "q";
                                Console.WriteLine(output);
                                break;

                            case "q":
                                output = "r" + output + "r";
                                Console.WriteLine(output);
                                break;

                            case "r":
                                output = "s" + output + "s";
                                Console.WriteLine(output);
                                break;

                            case "s":
                                output = "t" + output + "t";
                                Console.WriteLine(output);
                                break;

                            case "t":
                                output = "u" + output + "u";
                                Console.WriteLine(output);
                                break;

                            case "u":
                                output = "v" + output + "v";
                                Console.WriteLine(output);
                                break;

                            case "v":
                                output = "w" + output + "w";
                                Console.WriteLine(output);
                                break;

                            case "w":
                                output = "x" + output + "x";
                                Console.WriteLine(output);
                                break;

                            case "x":
                                output = "y" + output + "y";
                                Console.WriteLine(output);
                                break;

                            case "y":
                                output = "z" + output + "z";
                                Console.WriteLine(output);
                                break;

                            case "z":
                                output = "a" + output + "a";
                                Console.WriteLine(output);
                                break;

                            case " ":
                                output = "_" + output + "_";
                                Console.WriteLine(output);
                                break;

                            case "!":
                                doLoop = false;
                                break;

                            default:
                                Console.WriteLine(eMessage);
                                break;
                        }
                    }
                }
            }
        }
    }
}
