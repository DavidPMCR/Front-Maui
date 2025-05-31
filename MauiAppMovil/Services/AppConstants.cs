namespace MauiAppMovil.Services
{
    public static class AppConstants
    {
        private static string? _apiBaseUrl;
        private static string? _baseUrl;

        public static string ApiBaseUrl
        {
            get => _apiBaseUrl ?? "http://10.0.2.2:5275/api";
            set => _apiBaseUrl = value; // <- For Testing purposes, you can set this to a different URL
        }

        public static string BaseUrl
        {
            get => _baseUrl ?? "http://10.0.2.2:5275";
            set => _baseUrl = value; // <- For Testing purposes, you can set this to a different URL
        }
    }
}