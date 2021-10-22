using System;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Applicant
{
  public class ApplicantDetails : IApplicantDetails
  {
    public ApplicantDetails(string faculty, string CourseCode, DateTime Startdate, string Title, string FirstName, string LastName, DateTime DateOfBirth, bool requiresVisa)
    {
      this.ApplicationId = new Guid();
      this.Faculty = faculty;
      this.CourseCode = CourseCode;
      this.StartDate = Startdate;
      this.Title = Title;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.RequiresVisa = RequiresVisa;
      this.DateOfBirth = DateOfBirth;
    }

    public Guid ApplicationId { get; private set; }
    public string Faculty { get; private set; }
    public string CourseCode { get; private set; }
    public DateTime StartDate { get; private set; }
    public string Title { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public bool RequiresVisa { get; private set; }

    public DegreeGradeEnum DegreeGrade { get; set; }
    public DegreeSubjectEnum DegreeSubject { get; set; }

  }
}
