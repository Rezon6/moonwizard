using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicProjectile : MonoBehaviour
{
    //skripta sem stýrir skotunum

    //public AudioSource clank;
    public float speed;
    public float lifeTime;
    public int damageDealt;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<RobotHealth>().HurtEnemy(damageDealt);
            Destroy(gameObject);
            //clank.Play();
        }
    }
}
