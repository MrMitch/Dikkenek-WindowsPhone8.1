namespace Dikkenek_WindowsPhone8._1.Models
{
    public class Phrase : PicturedModel
    {
        private string _sound;
        public string Sound
        {
            get { return "/Assets/sounds/" + _sound + ".mp3"; }
            set { _sound = value; }
        }
    }
}
