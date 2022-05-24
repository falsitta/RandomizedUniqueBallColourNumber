using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int numOfBalls = 50;

    private List<int> ballTextValues = new List<int>();

    [SerializeField]
    private GameObject ballPrefab;
    void Start()
    {
        ballTextValues = GenerateRandomNumbers(numOfBalls);
        for (int i = 0; i < numOfBalls; i++)
        {
            GameObject tempBall = Instantiate(ballPrefab, RandomPosition(new Vector3(-20, 5, -20), new Vector3(20, 5, 20)), Quaternion.identity); 
            tempBall.GetComponent<BallNumberScript>().ballText.text = ballTextValues[i].ToString();

            if (ballTextValues[i] % 3 == 0)
            {
                tempBall.GetComponent<BallColourScript>().SetBallMaterial(Color.red);

            }
            else if (ballTextValues[i] % 5 == 0)
            {
                tempBall.GetComponent<BallColourScript>().SetBallMaterial(Color.blue);

            }
            else
            {
                tempBall.GetComponent<BallColourScript>().SetBallMaterial(Color.grey);
            }

            if (ballTextValues[i] % 15 == 0)
            {
                tempBall.GetComponent<BallColourScript>().SetBallMaterial(new Color(128, 0, 128));

            }
            
        }
    }

    private List<int> GenerateRandomNumbers(int count)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Add(i);
        }

        List<int> results = new List<int>();
        while (numbers.Count > 0)
        {
            int position = Random.Range(0, numbers.Count);

            results.Add(numbers[position]);
            numbers.RemoveAt(position);
        }

        return results;
    }

    private Vector3 RandomPosition(Vector3 min, Vector3 max)
    {
        return new Vector3(UnityEngine.Random.Range(min.x, max.x), UnityEngine.Random.Range(min.y, max.y), UnityEngine.Random.Range(min.z, max.z));
    }
}
