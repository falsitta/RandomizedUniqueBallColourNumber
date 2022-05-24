using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer ballMaterial;
    public 
    void Awake()
    {
        ballMaterial = GetComponent<MeshRenderer>();
    }

    public void SetBallMaterial(Color color)
    {
        ballMaterial.material.color = color;
    }
}
