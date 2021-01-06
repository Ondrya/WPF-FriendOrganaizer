using Prism.Events;

namespace FriendOrganaizer.UI.Event
{
    public class AfterFriendSaveEvent:PubSubEvent<AfterFriendSaveEventArgs>
    {

    }

    public class AfterFriendSaveEventArgs
    {
        public int Id { get; set; }
        public string DisplayMemeber { get; set; }
    }
}
