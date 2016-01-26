using UnityEngine;
using System.Collections;

public static class LanePatterns {

	public static bool[] Pattern()
    {
        bool[] pattern = new bool[12];
        switch (Random.Range(0, 9))
        {

            case 0:
            default:
                break;
            case 1:
            case 5:
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        pattern[i] = false;
                    }
                    else
                    {
                        pattern[i] = true;
                    }

                }
                break;
            case 2:
            case 6:
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (i % 3 == 0)
                    {
                        pattern[i] = false;
                    }
                    else
                    {
                        pattern[i] = true;
                    }

                }
                break;
            case 3:
            case 7:
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (i % 3 == 0)
                    {
                        pattern[i] = true;
                    }
                    else
                    {
                        pattern[i] = false;
                    }

                }
                break;
            case 4:
            case 8:
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (i % 4 != 0)
                    {
                        pattern[i] = false;
                    }
                    else
                    {
                        pattern[i] = true;
                    }

                }
                break;
        }

        return pattern;

    }

}
