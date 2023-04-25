using TMPS_lab1.AbstractFactory.Abstracts;
using TMPS_lab1.AbstractFactory.ConcreteProducts;
using TMPS_lab1.AbstractFactory.Interfaces;

namespace TMPS_lab1.AbstractFactory.Factories
{
    public class EndavaDiplomaFactory : IDiplomaFactory
    {
        public DiplomaHeader GenerateHeader(List<string> partnerships)
        {
            var diplomaHeader = new EndavaDiplomaHeader();
            diplomaHeader.Partnerships = partnerships;
            string partnershipsAsHTML = String.Empty;

            foreach (var partner in partnerships)
            {
                partnershipsAsHTML += $"<p>{partner}</p>";
            }

            diplomaHeader.HTMLHeaderText = $"<div><b>ENDAVA</b></div>\n" +
                $"<div>{partnershipsAsHTML}</div>\n" +
                $"<h1><b>CERTIFICATE</b></h1>\n" +
                $"<h3><b>OF COMPLETION</b></h3>";

            return diplomaHeader;
        }

        public DiplomaBody GenerateBody(DateOnly startDate, DateOnly endDate, string awardedName)
        {
            var diplomaBody = new EndavaDiplomaBody();
            diplomaBody.StartInternshipDate = startDate;
            diplomaBody.EndInternshipDate = endDate;
            diplomaBody.AwardedName = awardedName;

            diplomaBody.HTMLBodyText = $"<p>is hereby granted to</p>\n" +
                $"<div><b>{diplomaBody.AwardedName}</b></div>\n" +
                $"..........................................................\n" +
                $"<p>{diplomaBody.EndInternshipDate.Month} {diplomaBody.EndInternshipDate.Year}</p>";

            return diplomaBody;
        }

        public DiplomaFooter GenerateFooter(string directorName)
        {
            var diplomaFooter = new EndavaDiplomaFooter();
            diplomaFooter.DirectorName = directorName;
            diplomaFooter.HTMLFooterText = $"<div><b>{diplomaFooter.DirectorName}</b><div>\n" +
                $"<p>Delivery Unit Manager</p>";

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