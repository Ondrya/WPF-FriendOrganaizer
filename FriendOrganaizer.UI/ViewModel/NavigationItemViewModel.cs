using System;
using System.Collections.Generic;
using System.Text;

namespace FriendOrganaizer.UI.ViewModel
{
    public class NavigationItemViewModel : ViewModelBase
    {
        public NavigationItemViewModel(int id, string displayMember)
        {
            Id = id;
            DisplayMember = displayMember;
        }

        public int Id { get; }
        private string _displayMember;

        public string DisplayMember
        {
            get => _displayMember;
            set { 
                _displayMember = value;
                OnPropertyChanged(nameof(DisplayMember));
            }
        }

    }
}
