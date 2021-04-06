using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField]
    GameObject fire;

    [SerializeField]
    Transform nozzle;

    [SerializeField]
    float velocidade = 5f;

    int Auxvidas = 0;
    [SerializeField]

    int NumerodeVidas = 3;

   

    float minX, maxX;


    // Start is called before the first frame update
    void Start()

    {
        // 0.25 é metade do tamanho da nave 
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.25f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.25f;

    }

    // Update is called once per frame
    void Update()
    {
        /* 
         * se o jogador premir o espaço
         * então criar um disparo
         */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, nozzle.position, nozzle.rotation);
        }

        MoveShip();

    }

       void MoveShip()
    {
        float hMov = Input.GetAxis("Horizontal");
        transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }


  void OnCollisionEnter2D(Collision2D collision)
    {

        Auxvidas++;

        if( Auxvidas == NumerodeVidas)
        {
             Destroy(gameObject);
        }

     
        Destroy(collision.gameObject);
    }

    

}