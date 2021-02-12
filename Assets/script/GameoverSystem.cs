using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverSystem : MonoBehaviour
{
    Text result;
    public GameObject score_object = null;

    void Start()
    {
        result = score_object.GetComponent<Text>();
        result.text = "獲得した宝箱の累計 : " + SingletonPattern.getTreasure + "個";
        Debug.Log(result.text);
    }
}
