using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeroController>())
        {
            Destroy(this.gameObject);
        }
    }
}
