namespace TextingSystem.Services.Messaging.Common.Client
{
    public class CreateClientResponse : BaseResponse
    {
        public string DiscountCode { get; set; }
        public int CustomerId { get; set; }
    }
}
