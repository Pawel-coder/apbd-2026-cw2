using System.Diagnostics.CodeAnalysis;

namespace Tutorial2;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if(values==null|| values.Length==0) throw new ArgumentException("Values array is empty");
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum=sum+values[i];
        }
        double result = (double)sum/values.Length;
        return result;
    }
}