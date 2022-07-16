using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public static PipeManager instance;
    public float distance;
    public GameObject pre;
    public GameObject pipe;
    public float upY;
    public float downY;
    public int startNum;
    List<GameObject> pipes = new List<GameObject>();

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < startNum; i++)
        {
            Spawn();
        }
    }

    public void Spawn()
    {

        foreach (var i in pipes)
        {
            if (!i.activeInHierarchy)
            {
                SetPipe(i);
                return;
            }
        }

        GameObject tmp = Instantiate(pipe, transform);
        pipes.Add(tmp);
        SetPipe(tmp);
    }

    void SetPipe(GameObject p)
    {
        float x;
        if (pre == null)
        {
            x = transform.position.x;
        }
        else
        {
            x = pre.transform.position.x + distance;
        }
        pre = p;
        p.transform.position = Pos(x);
        p.SetActive(true);
    }

    Vector2 Pos(float x)
    {
        return new Vector2(x, Random.Range(downY, upY));
    }
}
