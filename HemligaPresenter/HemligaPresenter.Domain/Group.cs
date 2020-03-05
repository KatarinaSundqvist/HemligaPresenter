using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HemligaPresenter.Models {
    public class Group {
        public Group() {
            Members = new List<Member>();
        }
        public int Id { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public DateTime Celebration { get; set; }
        public decimal MaxSpend { get; set; }
        public List<Member> Members { get; set; }
        public string GroupToken { get; set; } // TODO: To be created automatically when group is created. See also Member
    }
}
