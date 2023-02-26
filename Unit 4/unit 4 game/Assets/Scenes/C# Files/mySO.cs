using UnityEngine;

[CreateAssetMenu]

public class mySO : ScriptableObject
{
    new public string name;
    public float damage;
    public float intakeMultiplier;

    public void setName(string str){
        name = str;
    }
    
    public void setDamage(float dam){
        damage = dam;
    }

    public void setIntakeMultiplier(float mult){
        intakeMultiplier = mult;
    }
}
