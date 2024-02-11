using System.Diagnostics;


Stopwatch sw = new Stopwatch();

void Test()
{

    sw.Start();
    {
        int[] numberArray = {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20,
                21,
                22,
                23,
                24,
                25,
                26,
                27,
                28,
                29,
                30,
                31,
                32,
                33,
                34,
                35,
                36,
                37,
                38,
                39 };

        int output = 0;
        int len = numberArray.Length;
        int i = 0;

        while (i < len)
        {
            output += numberArray[i];
            i++;
        }

        //   foreach (const item in numberArray) {
        //     output += item;
        //   }

        // for (int i = 0; i < len; i++) {
        //   output += numberArray[i];
        // }
    }
    sw.Stop();

    Console.WriteLine($"Ellapsed Time:{sw.Elapsed}");
}
for (int i = 0; i < 10; i++)
{
    Test();
}
