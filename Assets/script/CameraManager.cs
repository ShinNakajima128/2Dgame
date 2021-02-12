using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject hero;
    public float cameraX;
    public float cameraY;
    public float cameraZ;
    Animator c_anim;

    private void Start()
    {
        c_anim = GetComponent<Animator>();
        c_anim.Play("StartAnimetion");
    }
    void Update()
    {    
        Vector3 heroPos = hero.transform.position;
        transform.position = new Vector3(heroPos.x + cameraX,heroPos.y + cameraY, cameraZ);
    }
}
