using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReloadBehavior 
{
    public void Reload();
}
public class ReloadBulletNormalBehavior :IReloadBehavior
{
    public void Reload() {
    }
}
public class ReloadBulletChargeBehavior : IReloadBehavior
{
    public void Reload()
    {
    }
}

public class CoolDownMagneticBehavior : IReloadBehavior
{
    public void Reload()
    {
    }
}

public class CoolDownLightMagneticBehavior : IReloadBehavior
{
    public void Reload()
    {
    }
}