using System;

namespace HemligaPresenter.Models {
    public class Member {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Token { get; set; } // TODO: This needs to be created automatically when the user is created
        public string Email { get; set; }
        public Boolean HasConfirmed { get; set; }
        public Group Group { get; set; }
        public Boolean GroupOwner { get; set; }
        public WishList WishList { get; set; }
    }
}
