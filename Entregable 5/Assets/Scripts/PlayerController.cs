using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Posición donde empieza
    private Vector3 defaultposition = Vector3.zero;

    // Velocidad de movimiento
    public float speed = 15f;

    // Velocidad de rotación
    public float turnSpeed = 25f;

    // Eje vertical
    private float verticalInput;

    // Coordenada límite para finalizar
    private int zMax = 450;


    // Start is called before the first frame update
    void Start()
    {
        // Posiciona al jugador
        transform.position = defaultposition;
    }

    // Update is called once per frame
    void Update()
    {
        // Eje vertical en negativo
        verticalInput = -Input.GetAxis("Vertical");

        // Mueve la avioneta hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rota la avioneta en función del eje
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);

        // Si la posición de la avioneta es igual o mayor al zMax
        if (transform.position.z >= zMax)
        {
            // Muestra el mensaje y termina el juego
            Debug.Log("THE END");
            Time.timeScale = 0f;
        }
    }
}
