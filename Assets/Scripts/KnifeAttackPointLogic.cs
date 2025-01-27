using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAttackPointLogic : MonoBehaviour
{
    private string holderTag;
    private new Collider2D collider;
    private void Awake()
    {
        collider = GetComponent<Collider2D>();
    }

    public void SetEnabled(Collider2D collider, bool enabled)
    {
        holderTag = enabled ? collider.tag : "";
        gameObject.SetActive(enabled);
        Physics2D.IgnoreCollision(this.collider, collider, enabled);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(holderTag)) return;
        Debug.Log("Knife hit: " + collision.transform.parent.name);
    }
}
