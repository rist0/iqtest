namespace IQTest.Api.Helpers
{
    public class JwtSettingsOptions
    {
        public const string JwtSettings = "JwtSettings";

        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public double ExpirationTimeInMinutes { get; set; }
    }
}
