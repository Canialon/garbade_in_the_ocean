using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class qq : MonoBehaviour
{
    public TextMeshProUGUI textMass;
    private int massOfCollectedGarbage;
    public void Count()
        {
            
                    massOfCollectedGarbage++;
                    
                    Debug.Log("count: " + massOfCollectedGarbage);
                    
                    textMass.text = massOfCollectedGarbage.ToString();

        }
    private void OnMouseDown()
    {
        massOfCollectedGarbage++;

        Debug.Log("count: " + massOfCollectedGarbage);

        textMass.text = massOfCollectedGarbage.ToString();
    }

}
