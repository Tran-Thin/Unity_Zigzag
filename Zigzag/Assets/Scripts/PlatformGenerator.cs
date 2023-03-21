using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] Transform currentPlatform;
    [SerializeField] int staringPlatformCount;

    int nextPlatformDirection;

    public static PlatformGenerator instance;

    private void OnEnable()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        GeneratorStartingPlatform();
    }

    void GeneratorStartingPlatform()
    {
        for (int i = 0; i < staringPlatformCount; i++)
        {
            nextPlatformDirection = Random.Range(0, 2);
            if (nextPlatformDirection == 0)
            {
                currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.right * 2, Quaternion.identity).transform;

            }
            else
            {
                currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.forward * 2, Quaternion.identity).transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextPlatform()
    {
        for (int i = 0; i < staringPlatformCount; i++)
        {
            nextPlatformDirection = Random.Range(0, 2);
            if (nextPlatformDirection == 0)
            {
                currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.right * 2, Quaternion.identity).transform;

            }
            else
            {
                currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.forward * 2, Quaternion.identity).transform;
            }
        }

    }
}
