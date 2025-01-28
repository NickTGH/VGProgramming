using UnityEngine;

public class QuickPatrolScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] targetPoints;
    private Transform currentTarget;
    private int targetIndex;

    [SerializeField]
    private float speed = 5.0f;
    void Start()
    {
        targetIndex = 0;
        currentTarget = targetPoints[targetIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position,currentTarget.position) < 0.001f) 
        {
            SwitchTarget();
        }
    }

    private void SwitchTarget()
    {
        targetIndex++;
        targetIndex %= targetPoints.Length;
        currentTarget = targetPoints[targetIndex];
    }
}
