using UnityEngine;

public class OfflinePlayer : MonoBehaviour
{
  public float Speed = 10;
    public bool ApplyVerticalInputToZAxis;
    private Vector3 m_Motion;

    void Update()
    {
        // Handle acquiring and applying player input
        m_Motion = Vector3.zero;
        m_Motion.x = Input.GetAxis("Horizontal");

        // Determine whether the vertical input is applied to the Y or Z axis
        if (!ApplyVerticalInputToZAxis)
        {
            m_Motion.y = Input.GetAxis("Vertical");
        }
        else
        {
            m_Motion.z = Input.GetAxis("Vertical");
        }

        // If there is any player input magnitude, then apply that amount of
        // motion to the transform
        if (m_Motion.magnitude > 0)
        {
            transform.position += m_Motion * Speed * Time.deltaTime;
        }
    }
}
