using System;

namespace ch09_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // classic composite
            {
                /*
                var rootFolder = new Classic.Folder("MyFiles");
                var imgFolder = new Classic.Folder("Images");
                var txtFolder = new Classic.Folder("Text");
                var mvFolder = new Classic.Folder("Mv");

                var girlImg = new Classic.ImageFile("girl.jpg");
                var boyImg = new Classic.ImageFile("boy.gif");
                var englishBook = new Classic.TextFile("english.txt");
                var mathBook = new Classic.TextFile("mathematics.txt");
                var lessonVideo = new Classic.VideoFile("lesson01.mp4");

                imgFolder.Add(girlImg);
                imgFolder.Add(boyImg);
                txtFolder.Add(englishBook);
                txtFolder.Add(mathBook);
                mvFolder.Add(lessonVideo);

                rootFolder.Add(imgFolder);
                rootFolder.Add(txtFolder);
                rootFolder.Add(mvFolder);

                rootFolder.KillVirus();
                */
            }
            // safe composite
            {
                /*
                var rootFolder = new Safe.Folder("MyFiles");
                var imgFolder = new Safe.Folder("Images");
                var txtFolder = new Safe.Folder("Text");
                var mvFolder = new Safe.Folder("Mv");

                var girlImg = new Safe.ImageFile("girl.jpg");
                var boyImg = new Safe.ImageFile("boy.gif");
                var englishBook = new Safe.TextFile("english.txt");
                var mathBook = new Safe.TextFile("mathematics.txt");
                var lessonVideo = new Safe.VideoFile("lesson01.mp4");

                imgFolder.Add(girlImg);
                imgFolder.Add(boyImg);
                txtFolder.Add(englishBook);
                txtFolder.Add(mathBook);
                mvFolder.Add(lessonVideo);

                rootFolder.Add(imgFolder);
                rootFolder.Add(txtFolder);
                rootFolder.Add(mvFolder);

                rootFolder.KillVirus();
                */
            }

            // Exercise 1. Classic
            //  OfficeStructure: OAOffice(-EduOffice, -AdminOffice, -List<OAOffice>, abstract void +PrintOrgOffice())
            //   Headquarters - BeijingHQ (SichuanBranch, override +PrintOrgOffice())
            //   SichuanBranch (ChengduBranch, MianyangBranch, override +PrintOrgOffice())
            //   ChengduBranch(override +PrintOrgOffice())
            //   MianyangBranch(override +PrintOrgOffice())

            // Exercise 2. Safe
            // UIControll: UICtrl(abstract void +Display())
            //  UnitCtrl: Button, Textbox(override +Display())
            //  ContCtrl: Form, Panel(-List<UICtrl>, void Add(UICtrl), void Remove(UICtrl), UICtrl GetChild(i), override void +Display())
            
            Console.ReadKey();
        }
    }
}
