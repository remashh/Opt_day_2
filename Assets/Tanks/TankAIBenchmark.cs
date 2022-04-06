using DefaultNamespace;
using Tanks;
using UnityEngine;

public class TankAIBenchmark : MonoBehaviour 
{
    Transform[] tanks;
    public int numberOfTanks;
    public GameObject tankPrefab;
    public UpdateManager updateManager;
    private readonly Vector3 _move = new Vector3(0, 0, 0.05f);

    void Start()
    {
        tanks = new Transform[numberOfTanks];
        updateManager.Initialize(numberOfTanks);
        for (int i = 0; i < numberOfTanks; i++)
        {
            tanks[i] = Instantiate(tankPrefab, new Vector3(Random.Range(-50,50), 0, Random.Range(-50,50)), Quaternion.identity).transform;
            updateManager.Add(tanks[i].gameObject.GetComponent<TankUpdate>());
        }
    }
}
