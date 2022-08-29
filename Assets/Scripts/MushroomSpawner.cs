using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;
    public int amauntPool;
    private List<GameObject> poolObject;

    private void Start()
    {
        poolObject = new List<GameObject>();
        for (int i = 0; i < amauntPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objPrefab);
            obj.SetActive(false);
            poolObject.Add(obj);
        }
    }

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < poolObject.Count; i++)
        {
            if (!poolObject[i].activeInHierarchy)
            {
                return poolObject[i];
            }
        }
        return null;
    }

    public void SetInactive(GameObject obj)
    {
        obj.SetActive(false);
    }

    void Update(){
        spawnObject();  
    }

    private void spawnObject()
    {
        GameObject Mushroom = GetPoolObject();
        if (Mushroom != null)
        {
            Mushroom.transform.position = transform.position;
            Mushroom.SetActive(true);
        }
    }

}
