using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerzavill2 : MonoBehaviour
{
   // codigo para que cuando el jugador colicione con un enemigo este sea empujado
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * 200.0f + 150f * rb.velocity.normalized, ForceMode2D.Impulse);
        }


    }

}
