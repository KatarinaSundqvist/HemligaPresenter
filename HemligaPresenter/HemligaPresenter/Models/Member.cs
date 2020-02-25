using System;
using System.ComponentModel.DataAnnotations;

namespace HemligaPresenter.Models {
    public class Member {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; } // TODO: This needs to be created automatically when the user is created
        
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public bool HasConfirmed { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public bool GroupOwner { get; set; }
        public WishList WishList { get; set; }
        public int WishListId { get; set; }
    }
}
