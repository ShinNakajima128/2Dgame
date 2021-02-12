using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoxManager : MonoBehaviour
{
    public GameObject score_object = null;
    public GameObject box;

    public void Start()
    {
        
    }

    void Update()
    {
        GameObject[] box = GameObject.FindGameObjectsWithTag("Box");
        Text boxText = score_object.GetComponent<Text>();
        boxText.text = "残りの宝箱:" + box.Length;

    }
}
