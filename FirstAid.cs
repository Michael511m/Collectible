using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{
    [SerializeField] int hp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Hp>().AddHp(hp);
        Destroy(gameObject);
    }
}
