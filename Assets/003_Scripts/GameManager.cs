using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    public static GameManager instance;

    [Header("Spawning")]
    //TODO change this with an animation curce, so that its gets more difficult over time
    [SerializeField] private float m_fSpawnDelay = 1f;
    [SerializeField] private AnimationCurve m_curSpawnRate;

    [Header("References")]
    [SerializeField] private ObjectPooler m_poolObstacles;
    [SerializeField] private Transform m_transformStart;

    public Action<int> OnObstacleDestroyedAction;
    private int m_fdestroyedObstacles=0;
    private int m_iObstacleSpawned = 0;
    #endregion

    #region Unity Variables

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
        {
            Destroy(instance);
            Debug.LogError("Two instances of GameManager");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartObjectSpawning());
    }

    private IEnumerator StartObjectSpawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(m_curSpawnRate.Evaluate(m_iObstacleSpawned++));
            GameObject goObstacle = m_poolObstacles.GetObjectFromPool();
            goObstacle.transform.position = m_transformStart.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ObstacleDestryed()
    {
        OnObstacleDestroyedAction.Invoke(++m_fdestroyedObstacles);
    }

    internal void ResetGame()
    {
       /* 
        * m_poolObstacles.ResetPool();
        m_fdestroyedObstacles = 0;
        OnObstacleDestroyedAction?.Invoke(m_fdestroyedObstacles);
       */
        SceneManager.LoadScene(0);
    }

    #endregion
}
