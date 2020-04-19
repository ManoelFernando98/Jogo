using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ground : MonoBehaviour
{

    private Airplane character;

    // Use this for initialization
    void Start()
    {
        character = FindObjectOfType<Airplane>();
    }


    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30)
        {

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.Death();
        }
    }

}
