using TMPS_lab1.AbstractFactory.Abstracts;

namespace TMPS_lab1.AbstractFactory.Interfaces
{
    public interface IDiplomaFactory
    {
        DiplomaHeader GenerateHeader(List<string> partnerships);

        DiplomaBody GenerateBody(DateOnly startDate, DateOnly endDate, string awardedName);

        DiplomaFooter GenerateFooter(string directorName);

        string GenerateDiplomaAsHTML(DiplomaHeader diplomaHeader, DiplomaBody diplomaBody, DiplomaFooter diplomaFooter);
    }
}