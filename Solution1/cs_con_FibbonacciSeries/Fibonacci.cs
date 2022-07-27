using System;
using System.Collections;

public class Fibbonacci : IEnumerable
{
    private readonly int sequenceSize;

    public Fibbonacci(int sequenceSize)
    {
        this.sequenceSize = sequenceSize;
    }

    public IEnumerator GetEnumerator()
    {
        int n1 = 0;
        int n2 = 1;
        int count = 0;

        for (count = 0;  count <= sequenceSize; count++)
        {
            var n1Temp = n1;
            n1 = n2;
            n2 = n1Temp + n2;

            yield return n2 - n1;
        }
    }
}
