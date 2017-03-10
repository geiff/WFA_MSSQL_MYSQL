namespace ProblemDeliveryNote
{
    public class ItemModel
    {   
        private int codeАrticle;
        private string articleName;
        private string unit;
        private double quantity;
        private decimal singlePrice;

        public ItemModel(int codeАrticle, string articleName, string unit, double quantity,
            decimal singlePrice)
        {
           
            this.CodeАrticle = codeАrticle;
            this.ArticleName = articleName;
            this.Unit = unit;
            this.Quantity = quantity;
            this.SinglePrice = singlePrice;
        }

        public int CodeАrticle { get; set; }
        public string ArticleName { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public decimal SinglePrice { get; set; }
        public decimal TotalSum { get { return (decimal) this.Quantity*this.SinglePrice; } }
    } 
}