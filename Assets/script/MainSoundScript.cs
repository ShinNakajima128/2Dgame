using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSoundScript : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
