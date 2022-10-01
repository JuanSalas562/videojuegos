using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*Autor: Cabello Salas Juan Carlos
Fecha: 23/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip fue creado para el movimiento de nuestra comida - Pizza.
*/
public class MovePizza : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.s
    void Start()
    {
        
    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        if(transform.position.z > 34){ //Se le asigna esta función para que despues que se dispare, esta se destruya antes de salir del mapa
            Destroy(gameObject);
        }


        transform.Translate(Vector3.forward*Time.deltaTime*15); // Función para indicar el tiempo y la velocidad a la que ira nuestra comida - pizza
    }
}
