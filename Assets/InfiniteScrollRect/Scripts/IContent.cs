using UnityEngine.EventSystems;

namespace Yejun.UGUI
{
    public interface IContent : IEventSystemHandler
    {
        bool Update(int index);
    }
}