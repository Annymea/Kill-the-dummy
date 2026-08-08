using UnityEngine;

public class GameLogicController : MonoBehaviour
{
    [SerializeField] private int maxDummyCount = 2;
    [SerializeField] private float maxYPos = 10;
    [SerializeField] private float minYPos = -10;
    [SerializeField] private float maxXPos = 10;
    [SerializeField] private float minXPos = -10;
    [SerializeField] private GameObject dummy;

    private void Update()
    {
        GameObject[] dummies = GameObject.FindGameObjectsWithTag("Dummy");
        int currentDummyCount = dummies.Length;
        Debug.Log(currentDummyCount);
        if(currentDummyCount < maxDummyCount)
        {
            Instantiate(dummy, new Vector3(Random.Range(minXPos, maxXPos), Random.Range(minYPos, maxYPos)), gameObject.transform.rotation);
        }
    }
}
