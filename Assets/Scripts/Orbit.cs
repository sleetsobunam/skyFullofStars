using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class Orbit : MonoBehaviour
{
    [SerializeField] Transform celestialBody;
    [SerializeField, Range (10,100)] int numberOfBodies = 10;
    [SerializeField] Transform parent;
    Transform[] _planets;

    void Start()
    {
        _planets = new Transform[numberOfBodies];
        for (int i = 0; i < numberOfBodies; i++)
        {
            Transform planet = _planets[i] = Instantiate(celestialBody,parent);
            float scaler = Random.Range(2, 7);
            planet.transform.localScale = Vector3.one * scaler;
            float randX = Random.Range(planet.localScale.magnitude * 7f, planet.localScale.magnitude * 15f);
            planet.localPosition = new Vector3(randX, 0, 0);
        }
    }
    void Update()
    {
        var time = Time.deltaTime;
        var i = 0;
        foreach(var temp in _planets)
        {
            var speed = (Random.Range(10, 30+i) + 3 * i) % 100;
            i++;
            temp.transform.RotateAround(temp.parent.position,Vector3.down, speed * time);
        }
    }
}
