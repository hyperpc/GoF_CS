namespace ch07_Adapter.Score
{
    public interface ScoreOperation
    {
         int[] Sort(int[] array); // sort scores
         int Search(int[] array, int key); // search score
    }
}