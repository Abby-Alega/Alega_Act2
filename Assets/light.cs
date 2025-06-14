using UnityEngine;
using System.Collections;

public class light : MonoBehaviour
{
    public GameObject redLight, yellowLight, greenLight;

    public float redDuration = 5f;
    public float yellowDuration = 2f;
    public float greenDuration = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TrafficLight());
    }

    IEnumerator TrafficLight()
    {
        while (true)
        {
            redLight.SetActive(true);
            yellowLight.SetActive(false);
            greenLight.SetActive(false);
            yield return new WaitForSeconds(redDuration);

            redLight.SetActive(false);
            yellowLight.SetActive(true);
            greenLight.SetActive(false);
            yield return new WaitForSeconds(yellowDuration);

            redLight.SetActive(false);
            yellowLight.SetActive(false);
            greenLight.SetActive(true);
            yield return new WaitForSeconds(greenDuration);

            StartCoroutine(TrafficLight());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
