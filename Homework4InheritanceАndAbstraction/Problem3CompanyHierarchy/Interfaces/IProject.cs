using System;

namespace Problem3CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        string State { get; set; }

        void CloseProject();
    }
}