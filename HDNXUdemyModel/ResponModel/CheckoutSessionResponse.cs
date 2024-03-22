using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.ResponModel
{
    public class CheckoutSessionResponse
    {
        private string? _publicKey;
        public string? SessionId { get; set; }

        public string? PublicKey { get => ProjectConfig.StripePublishableKey; set => _publicKey = value; }
    }
}