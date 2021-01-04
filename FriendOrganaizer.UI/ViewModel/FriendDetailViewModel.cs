using FriendOrganaizer.Model;
using FriendOrganaizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendDataService _dataService;

        public FriendDetailViewModel(IFriendDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task LoadAsync(int friendId)
        {
            Friend = await _dataService.GetByIdAsync(friendId);
        }

        private Friend _friend;

        public Friend Friend
        {
            get => _friend;
            private set
            {
                _friend = value;
                OnPropertyChanged(nameof(Friend));
            }
        }

    }
}
