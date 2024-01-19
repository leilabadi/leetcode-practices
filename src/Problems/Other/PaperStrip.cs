namespace LeetcodePractices.Problems.Other;

public class PaperStrip
{
    public static void Main()
    {
        // Two paper strips with numbers written on them in different random orders are given.
        // The objective is to determine the minimum number of cuts needed on one strip to rearrange it and perfectly match the sequence of the other strip.

        int[] original = [1, 4, 3, 2];
        int[] desired = [1, 2, 4, 3];
        Console.WriteLine(PaperStrip.MinPieces(original, desired));
    }

    public static int MinPieces(int[] original, int[] desired)
    {
        int counter = 0;
        Status status = Status.NotMatched;
        Queue<int> originalQueue = new Queue<int>(original);
        Queue<int> desiredQueue = null;
        while (originalQueue.Any())
        {
            switch (status)
            {
                case Status.Matched:
                    while (originalQueue.Any() && desiredQueue.Any() && originalQueue.Peek() == desiredQueue.Peek())
                    {
                        originalQueue.Dequeue();
                        desiredQueue.Dequeue();
                    }
                    status = Status.NotMatched;
                    break;
                case Status.NotMatched:
                    desiredQueue = new Queue<int>(desired);
                    while (desiredQueue.Any() && originalQueue.Peek() != desiredQueue.Peek())
                    {
                        desiredQueue.Dequeue();
                    }
                    if (desiredQueue.Any())
                    {
                        status = Status.Matched;
                        counter++;
                    }
                    break;
            }
        }

        return counter;
    }

    public enum Status { NotMatched, Matched }
}