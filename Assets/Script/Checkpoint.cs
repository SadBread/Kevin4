using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Rigidbody2D rgbd;

    private bool trig = true;

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && trig)
        {
            target.transform.position = new Vector2(rgbd.position.x, rgbd.position.y);
            trig = false;
        }
    }
}
