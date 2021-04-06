using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject [] invasores;


    [SerializeField]
    GameObject[] invasoresIndestrutiveis;
        

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float Yinc = 0.5f;

    [SerializeField]
    float probabilidadeDeIndestrutivel = 0.15f;

    float tempo = 0f;

    bool a = false;

    int Tempoquepassou = 2;



    


    



    void Awake()
    {
        /* Pega num invasor , e coloca "nesta" posição 
         * Repete
         */

        float y = yMin;
        for (int line = 0 ; line < invasores.Length ;  line++)

        {
            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject normalOuIndstrutivel;
                if(Random.value <= probabilidadeDeIndestrutivel)
                {

                    normalOuIndstrutivel = invasoresIndestrutiveis [line];

                } else
                {
                    normalOuIndstrutivel = invasores [line];
                }

                GameObject newInvader = Instantiate (normalOuIndstrutivel, transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;  

            }
            y += Yinc; 
        }

      
    }

    private void Update()
    {


        

        Vector3 Aux = transform.position;

    

        transform.position = Aux;


        tempo += Time.deltaTime ;





        if (a == false && tempo >= 2f ) // 0.5 para a direita
        {
            Aux.x += 0.5f;

            transform.position = Aux;

            a = true;

           

        }




        if ( tempo >= 2f ) // 0.5 para a esquerda
        {

            Aux.x -= 0.5f;

            transform.position = Aux;

            tempo = 0;

            a = false;


        }


        

        
        
 

       







    }










}


