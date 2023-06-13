using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] int money;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Score>().AddMoney(money);
        Destroy(gameObject);
    }
}
