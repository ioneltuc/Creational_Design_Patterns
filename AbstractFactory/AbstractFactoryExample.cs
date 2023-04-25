using TMPS_lab1.AbstractFactory.Abstracts;
using TMPS_lab1.AbstractFactory.Factories;
using TMPS_lab1.AbstractFactory.Interfaces;

namespace TMPS_lab1.AbstractFactory
{
    public static class AbstractFactoryExample
    {
        public static void StartExample()
        {
            IDiplomaFactory endavaDiplomaFactory = new EndavaDiplomaFactory();
            DiplomaHeader endavaDiplomaHeader = endavaDiplomaFactory
                .GenerateHeader(new List<string>() { "UTM", "Amazon Web Services", "Microsoft", "Google Cloud" });
            DiplomaBody endavaDiplomaBody = endavaDiplomaFactory
                .GenerateBody(new DateOnly(2023, 9, 5), new DateOnly(2023, 12, 5), "John Smith");
            DiplomaFooter endavaDiplomaFooter = endavaDiplomaFactory
                .GenerateFooter("Veaceslav Panfil");
            //Console.WriteLine(endavaDiplomaFactory.GenerateDiplomaAsHTML(endavaDiplomaHeader, endavaDiplomaBody, endavaDiplomaFooter));

            IDiplomaFactory amdarisDiplomaFactory = new AmdarisDiplomaFactory();
            DiplomaHeader amdarisDiplomaHeader = amdarisDiplomaFactory
                .GenerateHeader(new List<string>() { "UTM", "Microsoft Partner" });
            DiplomaBody amdarisDiplomaBody = amdarisDiplomaFactory
                .GenerateBody(new DateOnly(2023, 5, 10), new DateOnly(2023, 8, 25), "John Smith");
            DiplomaFooter amdarisDiplomaFooter = amdarisDiplomaFactory
                .GenerateFooter("Vlad Nanu");
            Console.WriteLine(amdarisDiplomaFactory.GenerateDiplomaAsHTML(amdarisDiplomaHeader, amdarisDiplomaBody, amdarisDiplomaFooter));
        }
    }
}