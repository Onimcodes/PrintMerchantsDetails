namespace PrintMerchantsDetails.Models
{
    public class MerchantTransactionDetails
    {
        public string MerchantName { get; set; } = default!;
        public string Location { get; set; } = default!;
        public int TerminalId { get; set; } = default!;
        public int STAN { get; set; } = default!;  
        public DateTime DateTime { get; set; } = default!;
        public double Amount { get; set; } 
        public string DebitCard { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AuthorizationCode { get; set; }
        public int ResponseCode { get; set; }
        public string AID { get; set; }
        public int RRN { get; set; }
        public string PTAD { get; set; }


    }
}
