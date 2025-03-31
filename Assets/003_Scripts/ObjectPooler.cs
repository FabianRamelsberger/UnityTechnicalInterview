using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] private int m_fObjectToPool;
    [SerializeField] private GameObject m_goPrefab;

    private List<GameObject> m_liPooledObjects;

    private void Awake()
    {
        m_liPooledObjects = new List<GameObject>();

        for (int i = 0; i < m_fObjectToPool; i++)
        {
            GameObject gameObject = Instantiate(m_goPrefab);
            gameObject.SetActive(false);
            m_liPooledObjects.Add(gameObject);
        }
    }

    public GameObject GetObjectFromPool()
    {
        foreach(GameObject gameObject in m_liPooledObjects)
        {
            if(gameObject.activeInHierarchy== false)
            {
                gameObject.SetActive(true);
                return gameObject;
            }
        };

        GameObject newGameObject = Instantiate(m_goPrefab);
        newGameObject.SetActive(true);
        m_liPooledObjects.Add(gameObject);

        return newGameObject;
    }

    internal void ResetPool()
    {
        m_liPooledObjects.ForEach(gameObject =>
        {
            gameObject.SetActive(false);
        } );
    }
}
