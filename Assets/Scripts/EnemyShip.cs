using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juego
{
    public class EnemyShip : Ship
    {
        public enum EnemyType
        {
            Type1,
            Type2
        }

        public EnemyType enemyType;
        public int maxHealth = 3;
        public int damage = 1;

        public GameObject bulletPrefab;
        public Transform firePoint;

        public float shootInterval = 2f;
        private float shootTimer = 0f;

        private int currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        private void Update()
        {
            Move(Vector3.down);

            shootTimer += Time.deltaTime;
            if (shootTimer >= shootInterval)
            {
                Shoot(Enums.BulletType.Black);
                shootTimer = 0f;
            }
        }

        public override void Move(Vector3 direction)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }

        public override void Shoot(Enums.BulletType bulletType)
        {
            if (bulletPrefab != null && firePoint != null)
            {
                Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            }
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}

