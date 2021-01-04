using FriendOrganaizer.Model;
using FriendOrganaizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {
        private IFriendLookupDataService _friendLookupService;

        public ObservableCollection<LookupItem> Friends { get; }

        public NavigationViewModel(IFriendLookupDataService friendLookupDataService)
        {
            _friendLookupService = friendLookupDataService;
            Friends = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _friendLookupService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(item);
            }
        }
    }
}
