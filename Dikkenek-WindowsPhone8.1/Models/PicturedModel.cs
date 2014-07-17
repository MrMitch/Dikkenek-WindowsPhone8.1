namespace Dikkenek_WindowsPhone8._1.Models
{
    public abstract class PicturedModel
    {
        public string Name { get; set; }

        private string _picture;
        public string Picture
        {
            get { return "/Assets/faces/" + _picture + ".png"; }
            set { _picture = value; }
        }
    }
}
