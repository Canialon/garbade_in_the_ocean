using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinSystem : MonoBehaviour
{
    private float massOfCollectedGarbage = 0;
    public TextMeshProUGUI textMass;
    public GameObject BottlePlastic;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown(GameObject BottlePlastic)
    {
        massOfCollectedGarbage += 0.2f;
        Debug.Log("count" + massOfCollectedGarbage);

        textMass.text = massOfCollectedGarbage.ToString();


    }
}
