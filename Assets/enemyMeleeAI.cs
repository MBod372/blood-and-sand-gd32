using System.Numerics;
using UnityEngine;
using UnityEngine.AI;

public class enemyMeleeAI : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
    }

    private void OnColisionEnter(Collider other)
    {
      float distance = Vector3.Distance(Player.transform.position, this.transform.position);
    }
}
