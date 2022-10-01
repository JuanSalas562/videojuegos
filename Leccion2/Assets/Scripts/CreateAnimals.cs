using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*Autor: Cabello Salas Juan Carlos
Fecha: 23/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip fue creado para generar los animales por si mismo sin necesidad de presionar una tecla.
*/
public class CreateAnimals : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    public GameObject[] animales; //Creamos este arreglo para dar referencias exactas a nuestros animales y a nuestro granjero que hay dentro del juego. Como bien nsabemos estos son GameObject
    

    //Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        InvokeRepeating("CrearAnimal", 2, 1.5F); //Este codigo invoka la función que crea el animal desde que inicia el juego sin necesidad de que el jugador los cree.
    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
    }

    void CrearAnimal(){ //Esta fuunción se utilizo para la creación automatica de nuestros animales
        int aleatorio = Random.Range(0, 3); // lo hace de forma aletoria y animales mixtos.
        int x = Random.Range(-10, 10); // en u n rango de 10

         Instantiate(animales[aleatorio], new Vector3(x, 0, 15), animales[0].transform.rotation); //La función que instansea el arrelgo de los animales

    }   
}
