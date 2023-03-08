using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform vertex1;
    public Transform vertex2;
    public Transform vertex3;
    public GameObject prefab;

    public void ReAgain()
    {
        // Generate a random point inside the triangle
        Vector3 randomPoint = RandomPointInTriangle(vertex1.position, vertex2.position, vertex3.position);

        // Instantiate a prefab at the random point
        Instantiate(prefab, randomPoint, Quaternion.identity);
    }

    void Start()
    {
        // Generate a random point inside the triangle
        Vector3 randomPoint = RandomPointInTriangle(vertex1.position, vertex2.position, vertex3.position);

        // Instantiate a prefab at the random point
        Instantiate(prefab, randomPoint, Quaternion.identity);
    }

    Vector3 RandomPointInTriangle(Vector3 v1, Vector3 v2, Vector3 v3)
    {
        // Generate two random barycentric coordinates
        float rand1 = Random.Range(0.0f, 1.0f);
        float rand2 = Random.Range(0.0f, 1.0f - rand1);

        // Calculate the third barycentric coordinate
        float rand3 = 1.0f - rand1 - rand2;

        // Calculate the random point using the barycentric coordinates
        Vector3 randomPoint = rand1 * v1 + rand2 * v2 + rand3 * v3;

        return randomPoint;
    }
}



