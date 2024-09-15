using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNumbetOfFindables : MonoBehaviour
{
    public Text total;
    public Text remaining;


    int numberOfFindables = 0;
    int numberOfRemainingFindables = 0;

    void Start()
    {
        numberOfFindables = GameObject.FindGameObjectsWithTag("Findables").Length;
        total.text = numberOfFindables.ToString();

        numberOfRemainingFindables = numberOfFindables;
        remaining.text = numberOfRemainingFindables.ToString();
    }

    void Update()
    {
        numberOfRemainingFindables = GameObject.FindGameObjectsWithTag("Findables").Length;
        remaining.text = numberOfRemainingFindables.ToString();
    }
}
