using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PreviewSystem : MonoBehaviour
{
    [SerializeField] float timeOut = 2f;
    float timeElapsed;
    Animator m_anim;
    [SerializeField] GameObject m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeElapsed);
        if (Input.anyKey || Input.GetMouseButton(0))
        {
            m_anim.Play("Camera_Anim");
                        
            Destroy(m_text);

            //timeElapsed += Time.deltaTime;
            //if (m_anim == false)
            //{
            //    SceneManager.LoadScene("Main");
            //}
        }

        
    }
    void Lord()
    {
        SceneManager.LoadScene("Main");
    }
}
