using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Interfaces
{
  public interface IApplication
  {
    string Process(IApplicantDetails applicantDetails);
  }
}
