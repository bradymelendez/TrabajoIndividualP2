using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juego
{
    public class EnemyBullet : Bullet
    {
        private void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
                other.GetComponent<PlayerShip>().TakeDamage(damage);
            }
        }
    }
}