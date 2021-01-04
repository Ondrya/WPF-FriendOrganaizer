using System.Threading.Tasks;

namespace FriendOrganaizer.UI.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}