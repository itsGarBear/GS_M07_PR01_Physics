using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 20;
    private List<GameObject> pooledObjects = new List<GameObject>();

    public bool willGrow = true;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(prefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(prefab);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }

}
