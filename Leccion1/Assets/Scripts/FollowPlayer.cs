using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*Autor: Cabello Salas Juan Carlos
Fecha: 29/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip fue creado para el funcionamiento, configuración y control de nuestro Main Camera.
*/
public class FollowPlayer : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{

    public GameObject player; //Creamos esta variable para dar referencias exactas a nuestros obstaculos u vehiculo que hay dentro del juego. Como bien nsabemos estos son GameObject
    private Vector3 offset = new Vector3(0, 5, -7); // Esta variable fue creada para acceder al la configuración del desplazamiento de una manera mas facil y cambiando valores mas rapido.


    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        
    }

     // Este metodo de LateUpdate, lo agregue para que la camara espere a que primero se mueva el vehiculo y despues ella. 
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //Esta función la utilizamos para obtener la posición actual de nuestra camara, es decir los valores de los ejes.
        //Una vez teniendo esto tenemos que mover la posición de la cámara por encima del vehículo para que el jugador pueda tener una vista adecuada del juego.
    }
}
