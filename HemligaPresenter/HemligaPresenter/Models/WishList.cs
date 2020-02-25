using System.Collections.Generic;

namespace HemligaPresenter.Models {
    public class WishList {
        public int Id { get; set; }
        public List<Wish> Wishes { get; set; }
    }
}