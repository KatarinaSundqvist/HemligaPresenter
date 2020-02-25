namespace HemligaPresenter.Models {
    public class Wish {
        public int WishId { get; set; }
        public string ItemName { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool StillOpen { get; set; }
    }
}