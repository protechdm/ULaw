using Ulaw.ApplicationProcessor.Applications;
using ULaw.ApplicationProcessor;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor
{
  public static class FactoryMethods
  {
    public static ApplicationBase GetApplicationFactory(DegreeGradeEnum degreeGrade, DegreeSubjectEnum degreeSubject)
    {
      if (degreeGrade == DegreeGradeEnum.twoTwo)
      {
        return new DegreeGradeTwoTwo();
      }
      else
      {
        if (degreeGrade == DegreeGradeEnum.third)
        {
          return new DegreeGradeThird();
        }
        else
        {
          if (degreeSubject == DegreeSubjectEnum.law || degreeSubject == DegreeSubjectEnum.lawAndBusiness)
          {
            return new DegreeGradeFirst();
          }
          else
          {
            return new ApplicationBase();
          }
        }
      }

    }
  }
}
