using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextActive : MonoBehaviour
{[SerializeField]
    public Text texts;
    void Start()
    {

        
        texts.text ="上がれ、上がれ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
