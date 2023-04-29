using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int startColors = 0; // Colors (0 - red, 1 - green, 2 - blue)
        int[] hedgehogs = new int[] { 8, 1, 9 }; // Start with hedgehogs

        int Meetings = 0; // Meetings
        bool ChangeColor = true; // We need to change the colors until all the hedgehogs are the same color

        while (ChangeColor)
        {
            int ColorToChange = -1; // Which color we need to change
            int[] ColorCount = new int[] { 0, 0, 0 }; // How many hedgehogs have same color

            // All hadgehogs have same color or not
            for (int i = 0; i < 3; i++)
            {
                if (i != startColors && hedgehogs[i] > 0)
                {
                    ChangeColor = true;
                    break;
                }
                else
                {
                    ChangeColor = false;
                }
            }

            // Serch color which need to change
            if (ChangeColor)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i != startColors && hedgehogs[i] > 0)
                    {
                        if (ColorToChange == -1)
                        {
                            ColorToChange = i;
                        }
                        else
                        {
                            // Search third color
                            for (int j = 0; j < 3; j++)
                            {
                                if (j != i && j != startColors)
                                {
                                    ColorToChange = j;
                                    break;
                                }
                            }
                        }
                    }
                    ColorCount[i] = hedgehogs[i];
                }

                // Change color
                int newColorCount = Math.Min(ColorCount[ColorToChange], ColorCount[startColors]);
                hedgehogs[ColorToChange] -= newColorCount;
                hedgehogs[startColors] += newColorCount;
                Meetings += newColorCount;
            }
        }

        // Write result for task
        if (hedgehogs[startColors] == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(Meetings);
        }
    }
}
