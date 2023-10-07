using UnityEngine;

public class Backforth : MonoBehaviour
{
    [SerializeField] Transform singularity;

    void Start()
    {
        singularity.transform.position = Vector3.zero;
    }
    void Update()
    {
        float waveY = 20f* Mathf.Sin(0.5f * Time.fixedTime);
        singularity.transform.position = new Vector3(0, waveY, 0);
    }
}
