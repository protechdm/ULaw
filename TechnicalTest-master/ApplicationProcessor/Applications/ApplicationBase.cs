using System.Text;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Applications
{
  public class ApplicationBase : IApplication
  {
    protected readonly StringBuilder result;
    protected IApplicantDetails _applicantDetails;
    public ApplicationBase()
    {
      result = new StringBuilder();
    }

    protected void InsertHeader()
    {
      result.Append("<html><body><h1>Your Recent Application from the University of Law</h1>");
      result.Append(string.Format("<p> Dear {0}, </p>", _applicantDetails.FirstName));
    }

    protected virtual void InsertBody()
    {
      result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", _applicantDetails.CourseCode, _applicantDetails.StartDate.ToLongDateString()));
      result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
    }
    protected void InsertFooter()
    {
      result.Append("<br/> Yours sincerely,");
      result.Append("<p/> The Admissions Team,");
      result.Append(string.Format("</body></html>"));
    }
    public virtual string Process(IApplicantDetails applicantDetails)
    {
      _applicantDetails = applicantDetails;
      InsertHeader();
      InsertBody();
      InsertFooter();
      return result.ToString();
    }
  }
}
