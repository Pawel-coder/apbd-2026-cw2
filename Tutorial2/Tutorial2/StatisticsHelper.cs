namespace Tutorial2;

public class StatisticsHelper
{
    public static int CalculateMax(int[] values)
    {
        if(values==null|| values.Length==0) throw new ArgumentException("Values array is empty");
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
                max = values[i];
        }
        return max;
    }
    public static int CalculateMin(int[] values)
    {
        if(values==null|| values.Length==0) throw new ArgumentException("Values array is empty");
        int min = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < min)
                min = values[i];
        }
        return min;
    }
}