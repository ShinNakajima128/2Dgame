using UnityEngine;

public class PatrolController : MonoBehaviour
{
    [SerializeField] float m_moveSpeed = 1f;
    [SerializeField] Transform[] m_routePoints;
    Vector3 m_currentDestination;
    int m_routePointIndex = 0;
    [SerializeField] float m_distanceToTargetToSwitchTarget = 0.01f;

    void Start()
    {
        m_currentDestination = m_routePoints[m_routePointIndex].position;
    }

    void Update()
    {
        MoveTowards(m_currentDestination);

        float distance = Vector3.Distance(this.transform.position, m_currentDestination);
        if (distance < m_distanceToTargetToSwitchTarget)
        {
            SwitchDistination();
        }
    }

    void MoveTowards(Vector3 target)
    {
        //this.transform.position = Vector3.Lerp(this.transform.position, target, Time.deltaTime * m_moveSpeed);
        Vector3 dir = (target - this.transform.position).normalized;
        this.transform.Translate(dir * m_moveSpeed * Time.deltaTime);
    }

    void SwitchDistination()
    {
        if (m_routePoints.Length - 1 > m_routePointIndex)
        {
            m_routePointIndex++;
        }
        else
        {
            m_routePointIndex = 0;
        }
        m_currentDestination = m_routePoints[m_routePointIndex].position;
    }
}
