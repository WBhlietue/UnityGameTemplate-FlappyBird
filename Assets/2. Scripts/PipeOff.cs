using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeOff : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Complete"))
        {
            other.transform.parent.gameObject.SetActive(false);
        }
    }
}
