using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invader : MonoBehaviour
{

    [SerializeField]
    GameObject fire = null;

    [SerializeField]
    float cadencia = 1.5f;

   
    int AuxColisoes = 0;

    [SerializeField]
    int numerodetiros = 10;

    float TempoquePassou = 0f;

   

    void Update()
    {

    if (tag == "destrutivel")
        {
            TempoquePassou += Time.deltaTime;
           
            if (TempoquePassou >= cadencia)
            {
                Instantiate(fire, transform.position, transform.rotation);
                TempoquePassou = 0f;

            }
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(tag == "destrutivel")
        {

            if (collision.gameObject.tag == "disparodanave")
            {
                Destroy(gameObject); // destruir-me
                Destroy(collision.gameObject); // destruir o objeto que comigo colidiu 
            }
        } else
        {
            AuxColisoes ++ ;
            
            if (AuxColisoes == numerodetiros)
            {   
                Destroy(gameObject);

            }

            Destroy(collision.gameObject);
        }


        




    }
}
