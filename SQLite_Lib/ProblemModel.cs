﻿using System;


namespace SQLiteLib
{
    public class ProblemModel
    {
        public string Tester { get; set; }

        public string Start { get; set; }

        public string Stop { get; set; }

        public string InterventionStart { get; set; }

        public string RootCause { get; set; }

        public string TypeOfIssue { get; set; }

        public string technicianID { get; set; }

        public string TesterIssue
        {
            get
            {
                return $"{ Tester } { RootCause }";
            }
        }

    }
}