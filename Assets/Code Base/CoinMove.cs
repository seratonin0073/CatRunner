using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    private float speed = 3f;

    void Start()
    {
        speed = GameObject.FindObjectOfType<GroundMove>().LevelSpeed;
    }
    
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);
    }
}