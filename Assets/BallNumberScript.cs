using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallNumberScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ballText;
    void Awake()
    {
        ballText = GetComponentInChildren<TextMeshProUGUI>();
    }

}
