using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LookDetection : MonoBehaviour
{
    [Range(0f, 1f)]
    float Preciseness = 0.99f;

    public Transform Player;

    void Update()
    {
        OnDrawGizmos();
    }

    void OnDrawGizmos()
    {
        Vector3 Center = transform.position;
        Vector3 PlayerPos = Player.position;

        Vector3 PlayerLookDir = Player.forward;
        Vector3 PlayerToTriggerDir = (Center - PlayerPos).normalized;

        Gizmos.color = Color.white;
        Gizmos.DrawLine(PlayerPos, PlayerPos + PlayerLookDir);

        float Alignment = Vector3.Dot(PlayerToTriggerDir, PlayerLookDir);

        bool IsLooking = Alignment >= Preciseness;

        Gizmos.color = IsLooking ? Color.green : Color.red;
        Gizmos.DrawLine(PlayerPos, PlayerPos + PlayerToTriggerDir);
    }


}
