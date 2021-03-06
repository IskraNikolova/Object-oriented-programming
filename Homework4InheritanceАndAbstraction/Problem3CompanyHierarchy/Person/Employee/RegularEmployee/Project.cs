﻿namespace Problem3CompanyHierarchy.Person.Employee.RegularEmployee
{
    using System;
    using Problem3CompanyHierarchy.Interfaces;

    public class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;

        public Project(string projectName, DateTime projectStartDate, string state, string details = "more details")
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Project name cannot be empty!");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Details cannot be empty!");
                }

                this.details = value;
            }
        }

        public string State{
            get
            {
                return this.state;
            }

            set
            {
                if (value != "open" && value != "closed")
                {
                    throw new FormatException("State must be open or closed!");
                }

                this.state = value;
            }
        }

        public void CloseProject()
        {
             this.State = "closed";          
        }

        public override string ToString()
        {
            return $"\nProject Name: {this.ProjectName}\nProject Start Date: {this.ProjectStartDate}" +
                   $"\nDetails: {this.Details}\nState: {this.State}";
        }
    }
}