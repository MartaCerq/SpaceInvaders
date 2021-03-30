using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;



    void Awake()
    {
        /* Pega num invasor , e coloca "nesta" posição 
         * Repete
         */

        float y = yMin;
        float x = xMin;
        for (int i = 1; i <= nInvasores * 2 ; i += 1)

        {

            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, y , 0f);
           
 
            GameObject newInvaderB = Instantiate(invasorB, transform);
            newInvaderB.transform.position = new Vector3(x, 1f + y , 0f);

            GameObject newInvaderC = Instantiate(invasorC, transform);
            newInvaderC.transform.position = new Vector3(x, 1.5f,  0f);


            x += 1;

            if (i == nInvasores)
            {
                x = xMin;
                y += 0.5f;
            


            }
           

        }
    }   
}


