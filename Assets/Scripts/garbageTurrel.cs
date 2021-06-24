using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageTurrel : MonoBehaviour
{

    public GameObject Bullet;
    private Vector3 PosBullet;

    void Start()
    {
        PosBullet = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        StartCoroutine(CreateBullet());
    }

    IEnumerator CreateBullet()
    {
        yield return new WaitForSeconds(Random.Range(2.0f, 10.0f));
        Instantiate(Bullet, PosBullet, Quaternion.identity);
        StartCoroutine(CreateBullet());
    }
}
