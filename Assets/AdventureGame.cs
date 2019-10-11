using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("You awaken, blinded and cold, the smell of mildew ...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
