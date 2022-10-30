using AK.Wwise;

public class AK_Wwise
{  
    // 1、BaseType：This type represents the base for all Wwise Types that require a GUID.
    public AK.Wwise.BaseType BaseType;

    // 2、AcousticTexture：This type represents an Acoustic Texture.
    public AK.Wwise.AcousticTexture AcousticTexture;

    // 3、AuxBus：This type represents an auxiliary send in the Master-Mixer Hierarchy.
    public AK.Wwise.AuxBus AuxBus;

    // 4、Bank：This type can be used to load/unload SoundBanks.
    public AK.Wwise.Bank Bank;

    // 5、BaseGroupType：This type represents the base for all Wwise Types that also require a group GUID, such as State and Switch.
    public AK.Wwise.BaseGroupType BaseGroupType;

    // 6、Event：This type can be used to post Events to the sound engine.
    public AK.Wwise.Event Event;

    // 7、RTPC：This type can be used to set game parameter values to the sound engine.
    public AK.Wwise.RTPC RTPC;

    // 8、Trigger：This type can be used to post triggers to the sound engine.
    public AK.Wwise.Trigger Trigger;

    // 9、State：This type can be used to set Wwise States.
    public AK.Wwise.State State;

    // 10、Switch：This type can be used to set Switch values on gameobjects.
    public AK.Wwise.Switch Switch;
    
    // 11、CallbackFlags：This type represents the values of the flags used when posting an Event with a callback.
    public AK.Wwise.CallbackFlags CallbackFlags;
    
}
