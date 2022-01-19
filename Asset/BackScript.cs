using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour
{
    public GameObject playerCanvass, Option;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    public void returnButton()
    {
        Option.gameObject.SetActive(false);
        playerCanvass.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
