namespace Tutorial2;

public class StatisticsHelper
{
    public static double CalculateMax(int[] values)
    {
        int max = 0;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
                max = values[i];
        }
        return max;
    }
    public static double CalculateMin(int[] values)
    {
        int min = int.MaxValue;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < min)
                min = values[i];
        }
        return min;
    }
}