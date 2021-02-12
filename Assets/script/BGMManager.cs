using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    [SerializeField] string m_loadscene = null;
    private void Awake()
    {
        GameObject[] BGM = GameObject.FindGameObjectsWithTag("BGM");
        DontDestroyOnLoad(BGM[0]);

        if (BGM[0] != null && BGM.Length == 2)
        {
            Destroy(BGM[1]);
        }

    }
}