using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] Objects;

    private void Start()
    {
        Generate();
    }

    private void DisableObjects(GameObject[] objects)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
    }

    private bool GetRandomBool()
    {
        return Random.Range(0, 100) <= 50;
    }

    public void Generate()
    {
        DisableObjects(Objects);

        for (int i = 0; i < Objects.Length; i++)
        {
            Objects[i].SetActive(GetRandomBool());
        }
    }
}