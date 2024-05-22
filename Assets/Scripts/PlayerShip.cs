using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace juego
{
    public class PlayerShip : Ship
    {
        public GameObject blackBulletPrefab;
        public GameObject whiteBulletPrefab;
        public int maxHealth = 3;

        public int currentHealth;
        private Enums.BulletType currentBulletType = Enums.BulletType.Black; 

        private void Start()
        {
            currentHealth = maxHealth;
        }

        private void Update()
        {
            Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            Move(direction);

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                currentBulletType = Enums.BulletType.Black;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                currentBulletType = Enums.BulletType.White;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot(currentBulletType); 
            }
        }

        public override void Move(Vector3 direction)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }

        public override void Shoot(Enums.BulletType bulletType)
        {
            GameObject bulletPrefab = bulletType == Enums.BulletType.Black ? blackBulletPrefab : whiteBulletPrefab;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
