using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPattern : MonoBehaviour
{
    static bool m_isExists = false;
    public static int getTreasure = 0;

    private void Awake()
    {
        if (m_isExists)
        {
            Debug.LogWarningFormat("SingletonPattern を持ったゲームオブジェクトは既にあるので、{0} は破棄する", this.gameObject.name);
            Destroy(this.gameObject);
        }
        else
        {
            // SingletonPattern のインスタンスがない場合は、自分を DontDestroyOnload に置く。
            m_isExists = true;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
