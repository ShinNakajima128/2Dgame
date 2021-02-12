using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeroController : MonoBehaviour
{
    [SerializeField] float h_moveSpeed = 3f;
    Rigidbody2D h_rb;
    Vector2 m_lastMovedDirection;
    SpriteRenderer m_sprite;
    Animator h_anim;
    public AudioClip treasure;
    public AudioClip walk;
    public AudioClip damage;
    AudioSource audioSource;
    int boxCount = 0;
    GameObject[] box;

    void Start()
    {
        h_rb = GetComponent<Rigidbody2D>();
        h_anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        m_sprite = GetComponent<SpriteRenderer>();
        box = GameObject.FindGameObjectsWithTag("Box");
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = AdjustInputDirection(h, v);
        
        h_rb.velocity = dir * h_moveSpeed;

        if (boxCount ==　6)
        {
            SceneManager.LoadScene("StageClear");
        }

    }
    Vector2 AdjustInputDirection(float inputX, float inputY)
    {
        Vector2 dir = new Vector2(inputX, inputY);

        if (m_lastMovedDirection == Vector2.zero)
        {
            if (dir.x != 0 && dir.y != 0)
            {
                dir.y = 0;
            }
        }
        else if (m_lastMovedDirection.x != 0)
        {
            dir.y = 0;
        }
        else if (m_lastMovedDirection.y != 0)
        {
            dir.x = 0f;
        }

        return dir;
    }
    void Animate(float inputX, float inputY)
    {
        if (h_anim == null) return; 

        if (inputX != 0)
        {
            h_anim.Play("WalkRight");
        }
        else if (inputY > 0)
        {
            h_anim.Play("WalkUp");
        }
        else if (inputY < 0)
        {
            h_anim.Play("WalkDown");
        }
        else
        {
            if (m_lastMovedDirection.x != 0)
            {
                h_anim.Play("IdleRight");
            }
            else if (m_lastMovedDirection.y > 0)
            {
                h_anim.Play("IdleBack");
            }
            else if (m_lastMovedDirection.y < 0)
            {
                h_anim.Play("IdleFront");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<TreasureController>())
        {
            audioSource.PlayOneShot(treasure);
            boxCount++;
            SingletonPattern.getTreasure++;

        }

    }
}
