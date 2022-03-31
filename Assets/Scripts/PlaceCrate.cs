using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCrate : MonoBehaviour
{
    public GameObject Crate1;
    public GameObject Crate2;
    public GameObject Crate3;
    public GameObject Crate1Ghost;
    public GameObject Crate2Ghost;
    public GameObject Crate3Ghost;
    const float rateOfFire = 1f;
    const float speed = 500f;
    float fireDelay;


    void Start()
    {
        Crate1Ghost.gameObject.SetActive(false);
        Crate2Ghost.gameObject.SetActive(false);
        Crate3Ghost.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > fireDelay)
        {
            fireDelay = Time.time + rateOfFire;
            GameObject shotInstance = Instantiate(Crate1, transform.position, transform.rotation);
            shotInstance.GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
            ScoreScript.scoreValue += 100;

        }
        if (Input.GetButton("Fire2") && Time.time > fireDelay)
        {
            fireDelay = Time.time + rateOfFire;
            GameObject shotInstance = Instantiate(Crate2, transform.position, transform.rotation);
            shotInstance.GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
            ScoreScript.scoreValue += 300;

        }
        if (Input.GetButton("Fire3") && Time.time > fireDelay)
        {
            fireDelay = Time.time + rateOfFire;
            GameObject shotInstance = Instantiate(Crate3, transform.position, transform.rotation);
            shotInstance.GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
            ScoreScript.scoreValue += 600;

        }

        if (Input.GetButton("Ghost1"))
        {
            Crate1Ghost.gameObject.SetActive(true);
            Crate2Ghost.gameObject.SetActive(false);
            Crate3Ghost.gameObject.SetActive(false);
        }
        if (Input.GetButton("Ghost2"))
        {
            Crate1Ghost.gameObject.SetActive(false);
            Crate2Ghost.gameObject.SetActive(true);
            Crate3Ghost.gameObject.SetActive(false);
        }
        if (Input.GetButton("Ghost3"))
        {
            Crate1Ghost.gameObject.SetActive(false);
            Crate2Ghost.gameObject.SetActive(false);
            Crate3Ghost.gameObject.SetActive(true);
        }
    }
}
