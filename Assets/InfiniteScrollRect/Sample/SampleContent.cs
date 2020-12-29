using UnityEngine;
using UnityEngine.UI;

namespace Yejun.UGUI
{
    public class SampleContent : MonoBehaviour, IContent
    {
        [SerializeField]
        private Text m_text = default;

        private bool m_isUpdate;

        bool IContent.Update(int index)
        {
            m_text.text = SampleData.Instance.Get(index);

            // auto inactive를 off 한 후 사용자가 제어하고 싶을 때 사용
            //m_isUpdate = true;
            return true;
        }

        private void Update()
        {
            if (m_isUpdate)
            {
                m_isUpdate = false;
                gameObject.SetActive(m_text.text != string.Empty);
            }
        }
    }
}