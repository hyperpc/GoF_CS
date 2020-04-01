using System;

namespace ch12_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intrinsic State
            {
                /*
                var factory = Intrinsic.IgoChessmanFactory.GetInstance();
                Intrinsic.IgoChessmanAbs b1 = factory.GetByColor("Black");
                Intrinsic.IgoChessmanAbs b2 = factory.GetByColor("Black");
                System.Console.WriteLine("Two black are same? {0}", b1==b2);
                Intrinsic.IgoChessmanAbs w1 = factory.GetByColor("White");
                Intrinsic.IgoChessmanAbs w2 = factory.GetByColor("White");
                System.Console.WriteLine("Two white are same? {0}", w1==w2);
                b1.Display();
                b2.Display();
                w1.Display();
                w2.Display();
                */
            }

            // Extrinsic State
            {
                var factory = Extrinsic.IgoChessmanFactory.GetInstance();
                Extrinsic.IgoChessmanAbs b1 = factory.GetByColor("Black");
                Extrinsic.IgoChessmanAbs b2 = factory.GetByColor("Black");
                System.Console.WriteLine("Two black are same? {0}", b1==b2);
                Extrinsic.IgoChessmanAbs w1 = factory.GetByColor("White");
                Extrinsic.IgoChessmanAbs w2 = factory.GetByColor("White");
                System.Console.WriteLine("Two white are same? {0}", w1==w2);
                b1.Display(new Extrinsic.Coordinates(1,2));
                b2.Display(new Extrinsic.Coordinates(3,4));
                w1.Display(new Extrinsic.Coordinates(1,3));
                w2.Display(new Extrinsic.Coordinates(2,5));
            }

            // Exercise 1. Router
            //  Define: RouterFactory(-list<AbsComputer>, Getinstance())
            //          AbsComputer(_ctor(){add instance list;},+abstract string GetName(int Port))
            //          Laptop(override string GetName(int Port))
            //          PC(override string GetName(int Port))

            // Exercise 2. Document
            //  Define: DocumentFacatory(-list<AbsContent>, GetInstance())
            //          AbsContent(_ctor(add instance list;), + abstract string Display())
            //          Font(+int Size; +string Color)
            //          BigScreenContent(override string Display(font1))
            //          MiddleScreenContent(override string Display(font2))
            //          SmallScreenContent(override string Display(font3))
            
            // Exercise 3. Editor
            //  Define: EditorFacatory(-list<AbsMedia>, GetInstance())
            //          AbsMedia(_ctor(add instance list;), + abstract string GetByName())
            //          Setting(+int Size; +string position//like header/body/footer)
            //          Image(_name, _ctor(name), +override string GetByName(setting))
            //          video(_name, _ctor(name), +override string GetByName(setting))
            //          flash(_name, _ctor(name), +override string GetByName(setting))
        }
    }
}
