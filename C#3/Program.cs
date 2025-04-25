class Program
{
    static void Main()
    {
        //for
        //for (int i = 0; 0 < 10; i++) { }

        //while
        //while (true) { }

        //do...while
        //do { }
        //while (true);

        //break, continue

        //foreach
        int[] nums6 = [1, 2, 3];
        foreach (var num in nums6)
        {
            Console.WriteLine(num);
        }


        //массивы
        int[] nums1 = new int[4];
        int[] nums2 = new int[4] { 1, 2, 3, 4 };
        int[] nums3 = new int[] { 1, 2, 3 };
        int[] nums4 = { 1, 2, 3 };
        int[] nums5 = [1, 2, 3];

        int a = nums1[0]; //первый эл массива
        int b = nums2[^1]; // последний элемент массива

        for (int i = 0; i < nums4.Length; i++) { }

        //двумерные массивы [,]
        int[,] matrix =
        {
            {1, 2 },
            {3, 4 }
        };

        //Зубчатый массив
        int[][] jagged =
        {
            new int[] {1, 2},
            new int[] {1, 2, 3, 4},
            new int[] {1, 2},
            new int[] {1, 2, 3}
        };
    }
}