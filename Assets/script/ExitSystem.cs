using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ExitSystem : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("title");
    }
}
