using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAfterSec : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 0.9f);
    }
}
