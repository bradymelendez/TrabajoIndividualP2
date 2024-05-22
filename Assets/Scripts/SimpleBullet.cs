using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juego
{
    public class SimpleBullet : Bullet
    {
        public enum BulletColor
        {
            Black,
            White
        }

        public BulletColor bulletColor;

        private void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (bulletColor == BulletColor.Black && other.CompareTag("EnemyBlack"))
            {
                Destroy(gameObject);
                other.GetComponent<EnemyShip>().TakeDamage(damage);
            }
            else if (bulletColor == BulletColor.White && other.CompareTag("EnemyWhite"))
            {
                Destroy(gameObject);
                other.GetComponent<EnemyShip>().TakeDamage(damage);
            }
        }
    }
}
