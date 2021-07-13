using System;

namespace July07_10
{
     class Table
    {
        private int width = 0;
        private int height = 0;

        //parameterised constructor
        public Table(int width, int height)
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }

        // Method to show the height and width on the screen
        public void ShowData()
        {
            Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
        }
        public static void Main(string[] args)
        {
            Table[] arr = new Table[10];

            // Generating random values 
            Random value = new Random();
            for (int i = 0; i < 5; i++)
                arr[i] = new Table(value.Next(0, 100), value.Next(100, 200));
            foreach (var i in arr)
                i.ShowData();
        }
    }
}

/* Output
Height - 100 cm, width - 37 cm
Height - 184 cm, width - 13 cm
Height - 176 cm, width - 48 cm
Height - 129 cm, width - 84 cm
Height - 156 cm, width - 12 cm
*/

