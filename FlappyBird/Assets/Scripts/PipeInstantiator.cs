using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeInstantiator : MonoBehaviour
{
    public static PipeInstantiator instance;
    public GameObject pipesPrefab;
    public int amountToPool;
    public List<GameObject> pipesPool;
    
    public float positionX;
    public float positionY;
    

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pipesPool = new List<GameObject>();
        GameObject pipe;

        for (int i = 0; i < amountToPool; i++)
        {
            pipe = Instantiate(pipesPrefab);
            positionY = Random.Range(-2.2f, 2.5f);
            pipe.transform.position = new Vector3(positionX + 5 * i, positionY, pipe.transform.position.z);
            pipe.name = i.ToString();
            pipesPool.Add(pipe);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLastPipe()
    {
        GameObject pipe = pipesPool[0];

        for (int i = 0; i < amountToPool - 1; i++)
        {
            pipesPool[i] = pipesPool[i + 1];
        }

        pipesPool[amountToPool - 1] = pipe;
        
    }
}
