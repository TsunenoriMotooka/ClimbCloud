using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StageData
{    
    Vector3 position;
    Vector3 scale;

    public StageData(Vector3 position, Vector3 scale)
    {
        this.position = position;
        this.scale = scale;
    }

    public Vector3 getPosition() { return this.position; }
    public Vector3 getScale() { return this.scale; }   
}

public class StageController : MonoBehaviour
{
    public GameObject cludePrefab;

    StageData[] stages = {
        new StageData(new Vector3(-1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)),
        new StageData(new Vector3(0f, -5.1f, 0f), new Vector3(11f, 1f, 1f)),
        new StageData(new Vector3(1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)),

        new StageData(new Vector3(-1.6f, -2.8f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(1.6f, -2.1f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(-0.2f, -0.7f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(-1.6f, 1.8f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(1.5f, 2.5f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(-0.1f, 4.2f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(1.6f, 6.4f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(-1.6f, 7.7f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(1.1f, 9f, 0f), new Vector3(0.9f, 1f, 1f)),
        new StageData(new Vector3(-1f, 11f, 0f), new Vector3(0.8f, 1f, 1f)),
        new StageData(new Vector3(-1.6f, 13f, 0f), new Vector3(0.7f, 1f, 1f)),
        new StageData(new Vector3(1.4f, 13.2f, 0f), new Vector3(1f, 1f, 1f)),
        new StageData(new Vector3(-1.1f, 15.5f, 0f), new Vector3(0.6f, 1f, 0f)),
        new StageData(new Vector3(1f, 16.6f, 0f), new Vector3(1f, 1f, 1f))
    };

    // Start is called before the first frame update
    void Start()
    {
        foreach(StageData stage in stages) {
            GameObject clude = Instantiate(this.cludePrefab);
            clude.transform.position = stage.getPosition();
            clude.transform.localScale = stage.getScale();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
