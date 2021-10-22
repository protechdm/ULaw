using ULaw.ApplicationProcessor;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Applications
{
  public class DegreeGradeFirst : ApplicationBase
  {
    protected override void InsertBody()
    {
      if (_applicantDetails.DegreeSubject == DegreeSubjectEnum.law || _applicantDetails.DegreeSubject == DegreeSubjectEnum.lawAndBusiness)
      {
        decimal depositAmount = 350.00M;

        result.Append(string.Format("<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {0} starting on {1}.", _applicantDetails.CourseCode, _applicantDetails.StartDate.ToLongDateString()));
        result.Append(string.Format("<br/> This offer will be subject to evidence of your qualifying {0} degree at grade: {1}.", _applicantDetails.DegreeSubject.ToDescription(), _applicantDetails.DegreeGrade.ToDescription()));
        result.Append(string.Format("<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{0} deposit fee to secure your place.", depositAmount.ToString()));
        result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));
      }
      else
      {
        result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", _applicantDetails.CourseCode, _applicantDetails.StartDate.ToLongDateString()));
        result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
      }
    }
  }

  public class DegreeGradeTwoTwo : ApplicationBase
  {
    protected override void InsertBody()
    {
      result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", _applicantDetails.CourseCode, _applicantDetails.StartDate.ToLongDateString()));
      result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
    }
  }

  public class DegreeGradeThird : ApplicationBase
  {
    protected override void InsertBody()
    {
      result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
      result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
    }
  }
}
