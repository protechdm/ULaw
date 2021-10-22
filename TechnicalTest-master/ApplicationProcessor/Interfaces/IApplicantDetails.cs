using System;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Interfaces
{
  public interface IApplicantDetails
  {
    Guid ApplicationId { get; }
    string Faculty { get; }
    string CourseCode { get; }
    DateTime StartDate { get; }
    string Title { get; }
    string FirstName { get; }
    string LastName { get; }
    DateTime DateOfBirth { get; }
    bool RequiresVisa { get; }

    DegreeGradeEnum DegreeGrade { get; set; }
    DegreeSubjectEnum DegreeSubject { get; set; }

  }
}
