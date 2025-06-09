using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public enum MemberTypeLookup
    {
        Instructor,               // INSERT INTO MemberTypeLookup: 'Istructor' :contentReference[oaicite:0]{index=0}
        InstructorCoordinator,    // 'Istructor Coordinator' :contentReference[oaicite:1]{index=1}
        TechnicalMember,         // 'Technical Member' :contentReference[oaicite:2]{index=2}
        TechnicalCoordinator,    // 'Technical Coordinator' :contentReference[oaicite:3]{index=3}
        BranchCoordinator        // 'Branch Coordinator' :contentReference[oaicite:4]{index=4}
    }
    public enum GenderLookup
    {
        Male,   // 'Male' :contentReference[oaicite:5]{index=5}
        Female, // 'Female' :contentReference[oaicite:6]{index=6}
        Other   // 'Other' :contentReference[oaicite:7]{index=7}
    }
    public enum TrainingStatusLookup
    {
        
        FirstInterview,
        SecondInterview,
        ExperimentalActivity,
        PlacementProcess,
        Rejected,
        Excepted,
        Completed
    }
    internal class Enums
    {
    }
}