using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class garbageCobtrol : MonoBehaviour
{


    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }


    void Update()
    {

        if (gameObject.transform.position.x >= 9.0f)
        {
            Destroy(gameObject);
        }

        transform.Rotate(new Vector3(0, 0, Random.Range(5.0f, 25.0f)) * Time.deltaTime);
        
        if (Input.touchCount > 0)
        {
            Destroy(gameObject);
        }

    }

    //для проверки на коппуктере:
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
