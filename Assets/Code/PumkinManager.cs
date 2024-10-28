using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpkinManager : MonoBehaviour
{
    public int pumpkinCount;
    public Text pumpkinText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pumpkinText.text = "Pumkin Collection" + pumpkinCount.ToString();
    }
}
