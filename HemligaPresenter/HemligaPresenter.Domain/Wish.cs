using System.ComponentModel.DataAnnotations;

namespace HemligaPresenter.Models {
    public class Wish {
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool StillOpen { get; set; } = true;
        public WishList WishList { get; set; }
        public int WishListId { get; set; }
    }
}