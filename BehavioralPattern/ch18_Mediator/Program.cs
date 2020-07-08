using System.Collections.Generic;
using System;
using ch18_Mediator.CRM;

namespace ch18_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. MediatorSample
            {
                /*
                ConcreteMediator mediator = new ConcreteMediator();
                Button btn = new Button();
                List list = new List();
                ComboBox comboBox=new ComboBox();
                TextBox tb = new TextBox();

                btn.SetMediator(mediator);
                list.SetMediator(mediator);
                comboBox.SetMediator(mediator);
                tb.SetMediator(mediator);

                mediator.btn=btn;
                mediator.list = list;
                mediator.comboBox = comboBox;
                mediator.textBox=tb;

                btn.Changed();
                System.Console.WriteLine("----------------------------------");
                list.Changed();
                */
            }

            // 2.
            {
                SubConcreteMediator submediator = new SubConcreteMediator();
                Button btn = new Button();
                List list = new List();
                ComboBox comboBox=new ComboBox();
                TextBox tb = new TextBox();
                Label label = new Label();

                btn.SetMediator(submediator);
                list.SetMediator(submediator);
                comboBox.SetMediator(submediator);
                tb.SetMediator(submediator);
                label.SetMediator(submediator);

                submediator.btn=btn;
                submediator.list = list;
                submediator.comboBox = comboBox;
                submediator.textBox=tb;
                submediator.label=label;

                btn.Changed();
                System.Console.WriteLine("----------------------------------");
                list.Changed();
            }

            // 3. UnitedNations
            // Mediator => MediatorUN
            // ConcreteMediator => WTO, WHO
            // Colleague => Country
            // ConcreteColleague => China, USA, Russia

            // 4. Windows UI
            // Mediator/ConcreteMediator => WindowsForm
            // Colleague => Panel
            // ConcreteColleague => TextPanel, ListPanel, GraphicPanel

            // 5. Temperature
            // Mediator => Control
            // ConcreteMediator => CtrlButtonUp, CtrlButtonDown, CtrlBar
            // Colleague => TemperatureDashboard
            // ConcreteColleague => TemperatureFahrenheit, TemperatureDashboardCelsius

            Console.ReadLine();
        }
    }
}
