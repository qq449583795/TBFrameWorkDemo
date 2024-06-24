using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected ITriggerBehavior m_GunFireBehavior;
    protected IReloadBehavior m_ReloadBehavior;
    protected IModelBehavoir m_ModelBehavior;

    public void Fire() {
        m_GunFireBehavior.Trigger();
    }
    public void ReloadBullet() {
        m_ReloadBehavior.Reload();
    }
    public void ReloadModel()
    {
        m_ModelBehavior.ReloadModel();
    }
    public void ReloadGrayModel()
    {
        m_ModelBehavior.ReloadGrayModel();
    }
    public void DestoryModel()
    {
        m_ModelBehavior.DestoryModel();
    }
    public void SetFireBehavior(ITriggerBehavior triggerBehavior)
    {
        m_GunFireBehavior = triggerBehavior;
    }
    public void SetReloadBehavior(IReloadBehavior reloadBehavior)
    {
        m_ReloadBehavior = reloadBehavior;
    }
    public void SetModelBehavior(IModelBehavoir modelBehavoir)
    {
        m_ModelBehavior = modelBehavoir;
    }
}
