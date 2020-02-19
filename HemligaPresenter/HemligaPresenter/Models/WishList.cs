using System.Collections.Generic;

namespace HemligaPresenter.Models {
    public class WishList {
        public int ListId { get; set; }
        public List<Wish> Wishes { get; set; }
    }
}