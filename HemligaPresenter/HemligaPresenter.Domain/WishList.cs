using System.Collections.Generic;

namespace HemligaPresenter.Models {
    public class WishList {
        public WishList() {
            Wishes = new List<Wish>();
        }
        public int Id { get; set; }
        public List<Wish> Wishes { get; set; }
    }
}