using System;

namespace ch14_ResponsibilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Purchase : pure chain of responsibility: just allow one of the participant process the request, not allow no one process
            {
                Purchase.Approver zwj = new Purchase.Director("Zhang Wu Ji");
                Purchase.Approver yg = new Purchase.VicePresident("Yang Guo");
                Purchase.Approver gj = new Purchase.President("Guo Jing");
                Purchase.Approver congress = new Purchase.Congress("all congress man");

                zwj.SetSuccessor(yg);
                yg.SetSuccessor(gj);
                gj.SetSuccessor(congress);

                Purchase.PurchaseRequest p1 = new Purchase.PurchaseRequest(45000,10001,"Buy Yitian sword");
                zwj.ProcessRequest(p1);
                Purchase.PurchaseRequest p2 = new Purchase.PurchaseRequest(60000,10002,"Buy Kuihuabaodian");
                zwj.ProcessRequest(p2);
                Purchase.PurchaseRequest p3 = new Purchase.PurchaseRequest(160000,10003,"Buy Jingangjing");
                zwj.ProcessRequest(p3);
                Purchase.PurchaseRequest p4 = new Purchase.PurchaseRequest(800000,10004,"Buy Taohua island");
                zwj.ProcessRequest(p4);
            }
            // Exercise 1. catch exception: filenotfoundexception, ioexception
            // Exercise 2. Soldior Report: Soldior report Mission->Banzhang(enemy<10)->Paizhang(10<=enemy<50)->Yingzhang(50<=enemy<200)->Meeting(200<=enemy)
            // Exercise 3. SearchOnline???
            // Exercise 4. applyLeave: leave<3 days->Leader; 3<=leave<10->ProjectManager; 10<=leave<30->DepartmentManager;leave>30->reject leave

            // xxx : not pure chain of responsibility: may each participant process part of the chain request, or no one process the request
            {
                //
            }

            Console.ReadKey();
        }
    }
}
