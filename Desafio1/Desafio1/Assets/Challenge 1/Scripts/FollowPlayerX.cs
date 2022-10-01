using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la posición de nuestra camara en lo que es la avioneta, es decir, para que la camara siga el avion mientras se ejecuta.
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class FollowPlayerX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    public GameObject plane; //Creamos esta variable para dar referencias exactas a nuestros obstaculos u avioneta que hay dentro del juego. Como bien nsabemos estos son GameObject
    private Vector3 offset = new Vector3(20,2,0); // Esta variable fue creada para acceder al la configuración de la camara de una manera mas facil y cambiando valores mas rapido.

    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {

    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        transform.position = plane.transform.position + offset;//Esta función la utilizamos para obtener la posición actual de nuestra camara, es decir los valores de los ejes.
        //Una vez teniendo esto tenemos que mover la posición de la cámara por encima de la avioneta para que el jugador pueda tener una vista adecuada del juego.
    }
}
