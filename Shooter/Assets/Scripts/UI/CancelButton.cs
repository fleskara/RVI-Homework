using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CancelButton : MonoBehaviour
{

    [SerializeField] private GameObject content;
    public void EmptyScrollContent()
    {
        foreach (Transform child in content.transform) {
            Destroy(child.gameObject);
        }
    }

    void Start() {    
    }

    void Update() {   
    }
}
