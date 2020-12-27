using UnityEngine;

namespace Yejun.UGUI
{
    public class SampleUI : MonoBehaviour
    {
        [SerializeField]
        private InfiniteScrollRect m_infiniteScrollRect = default;

        private SampleData m_data;

        private void Awake()
        {
            m_data = SampleData.Instance;

            m_infiniteScrollRect.onVerifyIndex += index =>
            {
                return index >= 0 && index < m_data.Count;
            };
        }
    }
}