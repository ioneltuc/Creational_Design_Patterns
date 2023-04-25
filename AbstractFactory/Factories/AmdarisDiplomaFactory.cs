using TMPS_lab1.AbstractFactory.Abstracts;
using TMPS_lab1.AbstractFactory.ConcreteProducts;
using TMPS_lab1.AbstractFactory.Interfaces;

namespace TMPS_lab1.AbstractFactory.Factories
{
    public class AmdarisDiplomaFactory : IDiplomaFactory
    {
        public DiplomaHeader GenerateHeader(List<string> partnerships)
        {
            var diplomaHeader = new AmdarisDiplomaHeader();
            diplomaHeader.Partnerships = partnerships;
            string partnershipsAsHTML = String.Empty;

            foreach (var partner in partnerships)
            {
                partnershipsAsHTML += $"<p><b>{partner}</b></p>";
            }

            diplomaHeader.HTMLHeaderText = $"<div><b>AMDARIS</b></div>\n" +
                $"<h1><b>CERTIFICATE OF INTERNSHIP</b></h1>\n" +
                $"<div><p>Basics of Building Web</p>\n" +
                $"<p>Applications Course</p></div>" +
                $"<div>{partnershipsAsHTML}<div>";

            return diplomaHeader;
        }

        public DiplomaBody GenerateBody(DateOnly startDate, DateOnly endDate, string awardedName)
        {
            var diplomaBody = new AmdarisDiplomaBody();
            diplomaBody.StartInternshipDate = startDate;
            diplomaBody.EndInternshipDate = endDate;
            diplomaBody.AwardedName = awardedName;

            diplomaBody.HTMLBodyText = $"<p>THIS CERTIFICATE IS PRESENTED TO\n" +
                $"<div><h3>{awardedName}</h3></div>\n" +
                $"<div><p>{startDate.Month} - {endDate.Month} {endDate.Year}</p></div>\n" +
                $"----------------------------------------\n" +
                $"<p>COURSE DURATION</p>";

            return diplomaBody;
        }

        public DiplomaFooter GenerateFooter(string directorName)
        {
            var diplomaFooter = new AmdarisDiplomaFooter();
            diplomaFooter.DirectorName = directorName;
            diplomaFooter.HTMLFooterText = $"----------------------------------------\n" +
                $"<p>AUTHORISED BY</p> <div>{directorName}<div>";

            return diplomaFooter;
        }

        public string GenerateDiplomaAsHTML(DiplomaHeader diplomaHeader, DiplomaBody diplomaBody, DiplomaFooter diplomaFooter)
        {
            string diplomaHTML = $"<div>\n{diplomaHeader.HTMLHeaderText}\n</div>\n" +
                $"<div>\n{diplomaBody.HTMLBodyText}\n</div>\n" +
                $"<div>\n{diplomaFooter.HTMLFooterText}\n</div>";

            return diplomaHTML;
        }
    }
}