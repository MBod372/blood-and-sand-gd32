using UnityEngine;
using UnityEngine.AI;

public class enemyMeleeAI : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        this.GetComponent<NavMeshAgent>().Move(Player.transform.position);
    }
}
