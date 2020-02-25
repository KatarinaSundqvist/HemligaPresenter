using System;
using System.Collections.Generic;

namespace HemligaPresenter.Models {
    public class Group {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public DateTime Celebration { get; set; }
        public decimal MaxSpend { get; set; }
        public List<Member> Members { get; set; }
        public string GroupToken { get; set; } // TODO: To be created automatically when group is created. See also Member
    }
}
