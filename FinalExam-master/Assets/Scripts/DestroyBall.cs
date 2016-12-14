using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour
{

    public AudioSource catbat;

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name.Equals("Bat"))
            catbat.Play();

        GameObject.Destroy(gameObject);
    }
}