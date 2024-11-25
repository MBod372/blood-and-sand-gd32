using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyMeleeAI : MonoBehaviour
{
    public GameObject damageManager;
    public GameObject Player;
    public float damageAmount;
    public float attackTimer;
    public float attackDelay;
    public void Update()
    {
        attackTimer += Time.deltaTime;
        huntPlayer();
    }
    public void huntPlayer()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
    }

    public void dealDamage()
    {
        Player.GetComponent<PlayerHealth>().playerHealth -= damageAmount * damageManager.GetComponent<damageManager>().damageMultiplier;
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && attackTimer >= attackDelay)
        {
            attackTimer = 0f;
            dealDamage();
            if(Player.GetComponent<PlayerHealth>().playerHealth <= 0)
            {
                SceneManager.LoadScene(3);
            }
                    
        }
    }
}
