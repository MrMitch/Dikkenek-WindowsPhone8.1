using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dikkenek_WindowsPhone8._1.Models
{
    public class Category : PicturedModel
    {
        public ObservableCollection<Phrase> Phrases { get; set; }
    }
}
