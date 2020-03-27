namespace ch08_Bridge.Report
{
    public abstract class AChart
    {
        protected IDataFile data;

        public void SetData(IDataFile dt){
            this.data = dt;
        }
         public abstract void Show();
    }
}