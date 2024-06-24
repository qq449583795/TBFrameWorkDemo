using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerBehavior
{
    public void Trigger();
}
public class ChargeGunTriggerBehavior : ITriggerBehavior
{
    public void Trigger()
    {
    }
}
public class NormalGunTriggerBehavior : ITriggerBehavior
{
    public void Trigger()
    {
    }
}
public class MagneticDeivceBehavior : ITriggerBehavior
{
    public void Trigger()
    {
    }
}
public class LightMagneticDeivceBehavior : ITriggerBehavior
{
    public void Trigger()
    {
    }
}