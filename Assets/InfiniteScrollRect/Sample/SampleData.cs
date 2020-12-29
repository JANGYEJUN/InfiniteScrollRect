using System.Collections.Generic;

namespace Yejun.UGUI
{
    public class SampleData
    {
        private static SampleData s_instance;

        private List<string> m_data;

        public static SampleData Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new SampleData();
                    s_instance.Init();
                }

                return s_instance;
            }
        }

        private void Init()
        {
            m_data = new List<string>();
            for (int i = 0; i < 250; i++)
            {
                m_data.Add($"{i:D3}");
            }
        }

        public string Get(int index)
        {
            if (index >= 0 && index < m_data.Count)
            {
                return m_data[index];
            }
            else
            {
                return string.Empty;
            }
        }

        public int Count => m_data.Count;
    }
}