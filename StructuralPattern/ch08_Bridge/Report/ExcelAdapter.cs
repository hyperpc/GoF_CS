namespace ch08_Bridge.Report
{
    public class ExcelAdapter: IDataFile
    {
        private ExcelAPI apiObj;
        private IDataFile data;

        public ExcelAdapter(ExcelAPI api, IDataFile dt){
            apiObj = api;
            data =dt;
        }

        public void Save(){
            apiObj.GenerateExcel();
        }
    }
}