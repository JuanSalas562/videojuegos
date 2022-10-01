using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para manipular la avioneta. la velocidad, la rotación, la camara y la dirección de ella.
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class PlayerControllerX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    public float speed; // Esta variable fue creada para asignar la velocidad a la que ira nuestra avioneta.
    public float rotationSpeed; // Esta variable fue creada para asignar la velocidad en la que rotara nuestra avioneta.
    public float verticalInput; // Esta variable se creo para el control de nuestra avión. Subir y bajar.

    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical"); //Esta es la función de nuestro control de la dirección de la avioneta.

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Esta es nuestra función paraasignar el tiempo y laa velocidad en la que ira nuestra avioneta.

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput); // Esta función le asignamos la velocidad de rotación y la función de la dirreción de nuestra avioneta.
    }
}
