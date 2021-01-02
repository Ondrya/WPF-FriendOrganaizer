using FriendOrganaizer.Model;
using FriendOrganaizer.UI.Data;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            var friends = await _friendDataService.GetAllAsync();
            Friends.Clear();
            foreach (var item in friends)
            {
                Friends.Add(item);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set { 
                _selectedFriend = value; 
                OnPropertyChanged(nameof(SelectedFriend));
            }            
        }
    }
}
