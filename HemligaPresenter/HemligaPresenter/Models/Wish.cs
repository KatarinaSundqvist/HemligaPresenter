namespace HemligaPresenter.Models {
    public class Wish {
        public int Id { get; set; }
        public string ItemName { get; set; } = "Min önskning";
        public string? Link { get; set; }
        public string? Description { get; set; }
        public bool StillOpen { get; set; }
        public WishList WishList { get; set; }
        public int WishListId { get; set; }
    }
}