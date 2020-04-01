using System.Linq;
using System.Collections.Generic;
namespace ch12_Flyweight.Intrinsic
{
    public class IgoChessmanFactory
    {
        private static IgoChessmanFactory factory = new IgoChessmanFactory();
        private List<IgoChessmanAbs> list;
        private IgoChessmanFactory(){
            list = new List<IgoChessmanAbs>();
            IgoChessmanAbs black=new IgoChessmanBlack();
            list.Add(black);
            IgoChessmanAbs white = new IgoChessmanWhite();
            list.Add(white);
        }

        public static IgoChessmanFactory GetInstance(){
            return factory;
        }
        public IgoChessmanAbs GetByColor(string color){
            return list.Where(i=>i.GetColor()==color).FirstOrDefault();
        }
        
    }
}