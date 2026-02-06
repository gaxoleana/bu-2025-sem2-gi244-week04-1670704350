using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Instantiate(dogPrefab[0], new Vector3(0, 0, 20), Quaternion.Euler(0, 180, 0));
            float x = Random.Range(-10, 10);
            int index = Random.Range(0, dogPrefabs.Length);
            if (dogPrefabs[index] != null)
            {
                Instantiate(dogPrefabs[index], new Vector3(x, 0, 20), Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Debug.LogWarning($"Dog prefab {index} is null");
            }
        }
    }
}
