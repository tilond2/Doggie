using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBehaviour : MonoBehaviour
{
    float hunger = 50f;
    float fatigue = 50f;
    float bathroom = 50f;
    float loneliness = 50f;
    float bonding = 50f;
    float alarm = 50f;
    float hunger_rate = 0.1f;
    float fatigue_rate = 0.05f;
    float bathroom_rate = 0.2f;
    float loneliness_rate = 0.1f;
    float bonding_rate = -0.3f;
    float alarm_rate = -0.5f;
    bool owner_home = true;
    bool asleep = false;
    float time = 420;
    float time_rate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hunger += Time.deltaTime * hunger_rate;
        if (asleep) {
            fatigue += Time.deltaTime * fatigue_rate;
        }
        else {
            fatigue -= 2 * Time.deltaTime * fatigue_rate;
        }
        bathroom += Time.deltaTime * bathroom_rate;
        loneliness += Time.deltaTime * loneliness_rate;
        bonding += Time.deltaTime * bonding_rate;
        alarm += Time.deltaTime * alarm_rate;
    }

    //[Task]
    bool OwnerHome() {
        return owner_home;
    }

    //[Task]
    bool IsAlarmed() {
        return alarm > 75f;
    }

    //[Task]
    void AlertOwner() {
        print("The dog barks and desperately tries gets your attention, looking worried");
    }

    //[Task]
    bool NeedsBathroom() {
        return bathroom > 75f;
    }

    //[Task]
    void SignalBR() {
        print("The dog begins to get anxious, and looks outside, like it needs to use the bathroom");
    }

    //[Task]
    bool NeedsFood() {
        return hunger > 75f;
    }

    //[Task]
    void SignalFood() {
        print("The dog looks hungrily at its empty food bowl");
    }

    //[Task]
    bool NeedsSleep() {
        return fatigue > 75f;
    }

    //[Task]
    void SignalSleep() {
        print("The dog begins yawning and wanders over to its bed, curling up into bed");
        asleep = true;
    }

    //[Task]
    bool IsLonely() {
        return loneliness > 75f;
    }

    //[Task]
    void SignalLonely() {
        print("The dog looks lonely, and nuzzles up to you, looking for attention");
    }

    //[Task]
    bool IsBored() {
        return bonding < 25f;
    }

    //[Task]
    void SignalBored() {
        print("The dog looks like it wants to play, and brings you one of its toys");
    }

    //[Task]
    void GoIdle() {
        print("The dog sits idly in its bed");
    }
}
