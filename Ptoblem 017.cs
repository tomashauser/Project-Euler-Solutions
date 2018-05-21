using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42 {
    class Program {
        static string Up_To_Nine(char Char_Input) {
            string Output;
            Output = "";
            switch (Char_Input) {
                case '1': Output = "One"; break;
                case '2': Output = "Two"; break;
                case '3': Output = "Three"; break;
                case '4': Output = "Four"; break;
                case '5': Output = "Five"; break;
                case '6': Output = "Six"; break;
                case '7': Output = "Seven"; break;
                case '8': Output = "Eight"; break;
                case '9': Output = "Nine"; break;
            }
            return Output;
        }
        static string Up_To_Ninety_Nine(string String_Input) {
            string Output;
            int Int_Input;
            Int_Input = Convert.ToInt32(String_Input);
            Output = "";
            if (Int_Input >= 1 && Int_Input <= 9) {
                Output += Up_To_Nine(String_Input[0]);
            }
            if (Int_Input >= 10 && Int_Input <= 19) {
                switch (String_Input) {
                    case "10": Output += "Ten"; break;
                    case "11": Output += "Eleven"; break;
                    case "12": Output += "Twelve"; break;
                    case "13": Output += "Thirteen"; break;
                    case "14": Output += "Fourteen"; break;
                    case "15": Output += "Fifteen"; break;
                    case "16": Output += "Sixteen"; break;
                    case "17": Output += "Seventeen"; break;
                    case "18": Output += "Eighteen"; break;
                    case "19": Output += "Nineteen"; break;
                }
            }
            if (Int_Input >= 20) {
                switch (String_Input[0]) {
                    case '1': Output += "Ten"; break;
                    case '2': Output += "Twenty"; break;
                    case '3': Output += "Thirty"; break;
                    case '4': Output += "Forty"; break;
                    case '5': Output += "Fifty"; break;
                    case '6': Output += "Sixty"; break;
                    case '7': Output += "Seventy"; break;
                    case '8': Output += "Eighty"; break;
                    case '9': Output += "Ninety"; break;
                }
                if (String_Input[1] != '0') {
                    Output += Up_To_Nine(String_Input[1]);
                }
            }
            return Output;
        }
        static string Number_To_Words (int Int_Input) {
            string String_Input, Output;
            String_Input = Convert.ToString(Int_Input);
            Output = "";
            if (String_Input.Length <= 2) {
                Output = Up_To_Ninety_Nine(String_Input);
            }
            if (String_Input.Length == 3) {
                if (Int_Input >= 100) {
                    Output += Up_To_Nine(String_Input[0]);
                    if (Int_Input % 100 != 0)
                        Output += "HundredAnd";
                    else
                        Output += "Hundred";
                }
                Output += Up_To_Ninety_Nine(Convert.ToString(Int_Input - ((Int_Input / 100) * 100)));
            }
            if (String_Input.Length == 4)
                Output = "OneThousand";
            return Output;
        }
        static void Main(string[] args) {
            string Number;
            int Sum_Of_Letters;
            Sum_Of_Letters = 0;
            for (int i = 1; i <= 1000; i++) {
                Number = Number_To_Words(i);
                Console.WriteLine(Number);
                Sum_Of_Letters += Number.Length;
                }
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            Console.WriteLine(Sum_Of_Letters);
            }
        }
    }
