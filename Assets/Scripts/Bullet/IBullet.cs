using Photon.Pun.Demo.Asteroids;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace TBFrameWork
{
    public abstract class BaseBullet : MonoBehaviour
    {
        string mDescription = "";
        protected GameObject bullet;
        protected bool isShoot;
        public string GetDescription()
        {
            return mDescription;
        }
        public virtual GameObject LoadEffect(string effectName) {

            GameObject effect= Resources.Load(effectName) as GameObject;
            bullet = Instantiate(effect);
            return bullet;
        }
        public void StartShoot()
        {
            isShoot = true;
        }

        public virtual void StopShoot()
        {
            isShoot = false;
        }

        public virtual void Update()
        {
            
        }
    }
    public class BulletFlyForward : BaseBullet
    {
        public override void Update()
        {
            base.Update();
            if(isShoot)
                bullet.transform.position += bullet.transform.forward * Time.deltaTime;
        }
    }
    public class BulletChangeBig : BaseBullet
    {
        public override void Update()
        {
            base.Update();
            if (isShoot)
                bullet.transform.localScale += bullet.transform.localScale * Time.deltaTime*0.1f;
        }
    }
    public class BulletDestroy : BaseBullet
    {
        float destroyTime;
        bool isDestroy;
        public override void StopShoot()
        {
            base.StopShoot();
            isDestroy = true;
        }
        public override void Update()
        {
            base.Update();
            if (isDestroy)
                destroyTime +=Time.deltaTime;
            if (destroyTime > 1f)
            {
                isDestroy = false;
                DestoryBullet();
            }
        }
        public void DestoryBullet()
        {
            Destroy(bullet);
        }
    }
    public class BulletTakeDamage: BaseBullet
    {
        public override void Update()
        {
            base.Update();
            
        }
    }
}