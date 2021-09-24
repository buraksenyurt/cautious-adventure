namespace SmoothValidation.Models
{
    public class Player
    {
        public string Nickname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string MobilePhone { get; set; }
        public int Level { get; set; }
        public Game FavoriteGame { get; set; } // Game model nesnesinin doğrulama işlerini GameValidator üstlenmekte. Sembolik olarak eklendi, View tarafında ele alınmadı.
    }
}
