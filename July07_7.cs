using System;

namespace July07_7
{
    //1. created a class called PhotoBook
    public class PhotoBook
    {
        protected int numPages; //used protected so that main methed have access for numPages
         public int GetNumberPages()
        {
            return numPages;
        }

        public PhotoBook() // defined default constructor
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)// specifying no of pages using additional constructor
        {
            this.numPages = numPages;
        }

    }

    public class BigPhotoBook : PhotoBook //used inheritance concept for bigphotobook and defined constructor
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    public class PhotoBookTest
    {
        public static void Main() //main method intracting with class PhotoBook
        {
            PhotoBook FirstBook = new PhotoBook();
            Console.WriteLine("  Number of pages in FirstBook :" + Book1.GetNumberPages());

            PhotoBook SecondBook = new PhotoBook(24);
            Console.WriteLine("  Number of pages in SecondBook :" + Book2.GetNumberPages());

            BigPhotoBook ThirdBook = new BigPhotoBook();
            Console.WriteLine(" ThirdBook number of pages :" + Book3.GetNumberPages());
        }
    }
}

/*
 * 
 *  Number of pages in FirstBook :16
    Number of pages in SecondBook :24
    Number of pages in ThirdBook :64
 * 
 * 
 */