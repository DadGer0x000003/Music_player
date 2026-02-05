

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HPlayer
{
    public class MainPlayerViewModel: INotifyPropertyChanged
    {



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
