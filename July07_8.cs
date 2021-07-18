using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    //defining an encrypt class
    public class Encrypter
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textencrypter = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;//converting the alphabel to ASCIIint and adding 1(Encryption)
                letter = (char)letterInt; //converting the ASCII value to char alphabet again( Decryption)
                textencrypter += letter.ToString(); //joining 
            }
            return textencrypter;

        }
        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textdecrypter = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textdecrypter += letter.ToString();
            }
            return textdecrypter;
        }
    }
    public class TextEncrypterDecrypter
    {
        public static void Main()
        {
            bool debug = true;
            Console.WriteLine("Enter the word/sentence to Encrypt and Decrypt Again");
            string TextEncrypted = Console.ReadLine();
            string newtext = Encrypter.Encrypt(TextEncrypted);
            Console.WriteLine("\nTextEncrypted:" + newtext);
            string TextDecrypted = Encrypter.Decrypt(newtext);
            Console.WriteLine("\nTextDecrypted: " + TextDecrypted);
            if (debug)
                Console.ReadLine();
        }
    }
}
/*
 *Enter the word/sentence to Encrypt and Decrypt Again
Hello My Name Is Deepthi

TextEncrypted:Ifmmp!Nz!Obnf!Jt!Effquij

TextDecrypted: Hello My Name Is Deepthi


 */ 