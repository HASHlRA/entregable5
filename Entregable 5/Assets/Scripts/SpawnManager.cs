using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Determina el prefab del obstáculo
    public GameObject obstaclePrefab;

    // Posición inicial del obstáculo
    private Vector3 spawnPos = new Vector3(0, 0, 30);

    // Determina un valor aleatorio al Y
    private float randomY;

    // Determina el rango del valor aleatorio
    private float rangeNumber = 10f;

    // Determina el ratio entre cada Invoke
    private float invokeRate = 5f;

    // Determina  el tiempo que tarda en iniciar el Invoke
    private float invokeTime = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        // Repite la función del SpawnsObstacle cada x tiempo
        InvokeRepeating("SpawnObstacle", invokeTime, invokeRate);
    }

    // Función que spawnea el obstáculo a una altura aleatoria, detrás de cada uno
    public void SpawnObstacle()
    {
        // Recibe un valor aleatorio
        randomY = Random.Range(-rangeNumber, rangeNumber);

        // Obtiene la posición del obstáculo
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);

        // Instancia un gameObject desde el prefab del obstáculo
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
