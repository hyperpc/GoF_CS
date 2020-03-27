namespace ch07_Adapter.Score
{
    public class OperationAdapter : ScoreOperation
    {
        private QuickSort sortObj; //adaptee: sort
        private BinarySearch searchObj; // adaptee: search
        public OperationAdapter(){
            sortObj = new QuickSort();
            searchObj = new BinarySearch();
        }
        public int[] Sort(int[] array){
            // adapter adaptee's api
            return sortObj.Sort(array);
        }
        public int Search(int[] array, int key){
            // adapter adaptee's api
            return searchObj.Search(array, key);
        }
    }
}