using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace YouthActionDotNet.Models
{
    public class Request
    {
        public Request()
        {
            this.RequestId = Guid.NewGuid().ToString();
        }
        public string RequestId { get; set; }
        public string RequestResourceType { get; set; }        

        // used to be RequestReason
        public string RequestDesc { get; set; }
        public string Status { get; set; }
        // used to be RequestRequestedBy
        public string RequesterId { get; set; }
        public string ProjectId { get; set; }

        // used to be RequestDateTime
        public DateTime DateOfRequest { get; set; }

        // added later, for the date of agreeing to the request
        public DateTime DateOfApproval { get; set; }
        // added later, for the date of enacting the request requirements
        // couldn't come up with a better name, is Reimbursement okay in this context?
        public DateTime DateOfReimbursement { get; set; }

        [JsonIgnore]
        public virtual User user { get; set; }
        [JsonIgnore]
        public virtual Project project { get; set; }
        // [JsonIgnore]
        // public virtual File RequestFile { get; set; }


    }

}