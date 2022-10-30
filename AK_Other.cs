
public class Other
{
    // 1、AkEvent：Helper class that knows a Wwise Event and when to trigger it in Unity. 
    // As of 2017.2.0, the AkEvent inspector has buttons for play/stop, play multiple, stop multiple, and stop all. 
    // Play/Stop will play or stop the event such that it can be previewed both in edit mode and play mode. 
    // When multiple objects are selected, Play Multiple and Stop Multiple will play or stop the associated AkEvent for each object.
    public AkEvent Event;

    // 2、AkAmbient：Use this component to attach a Wwise Event to any object in a scene. 
    // The sound can be started at various moments, dependent on the selected Unity trigger. 
    // This component is more useful for ambient sounds (sounds related to scene-bound objects) but could also be used for other purposes. 
    // Since AkAmbient has AkEvent as its base class, it features the play/stop, play multiple, stop multiple and stop all buttons for previewing the associated Wwise event.
    public AkAmbient Ambient;

    // 3、AkTriggerBase：Base class for the generic triggering mechanism for Wwise Integration. 
    // All Wwise components will use this mechanism to drive their behavior. Derive from this class to add your own triggering condition, as described in 为 Wwise Events 添加新的 Trigger。
    // 继承自 MonoBehaviour. 被 AkTriggerCollisionEnter, AkTriggerCollisionExit, AkTriggerDisable, AkTriggerEnable, AkTriggerEnter, AkTriggerExit, AkTriggerMouseDown, AkTriggerMouseEnter, AkTriggerMouseExit , 以及 AkTriggerMouseUp 继承.
    public AkTriggerBase TriggerBase;

    // 4、AkBank：Loads and unloads a SoundBank at a specified moment. Vorbis sounds can be decompressed at a specified moment using the decode compressed data option. In that case, the SoundBank will be prepared.
    public AkBank Bank;

    // 5、AkAudioListener：Add this script on the game object that represent a listener. This is normally added to the Camera object or the Player object, but can be added to any game object when implementing 3D busses. 
    // isDefaultListener determines whether the game object will be considered a default listener - a listener that automatically listens to all game objects that do not have listeners attached to their AkGameObjListenerList's.
    public AkAudioListener AudioListener;

    // 6、AkState：This will call AkSoundEngine.SetState() whenever the selected Unity event is triggered. For example this component could be set on a Unity collider to trigger when an object enters it.
    public AkState State;

    // 7、AkSwitch：This will call AkSoundEngine.SetSwitch() whenever the selected Unity event is triggered. For example, this component could be set on a Unity collider to trigger when an object enters it.
    public AkSwitch Switch;

    // 8、AkAmbientLargeModePositioner：Use this component to add a Large Mode position to any AkAmbient in a Scene.
    public AkAmbientLargeModePositioner AmbientLargeModePositioner;

    // 9、AkEarlyReflections：Set an early reflections auxiliary bus and send volume for a particular game object.
    public AkEarlyReflections EarlyReflections;

    // 10、AkEmitterObstructionOcclusion：Completely obstructs/occludes the emitter of the current game object from its listeners if at least one object is between them.
    public AkEmitterObstructionOcclusion EmitterObstructionOcclusion;

    // 11、AkEnvironment：Use this component to define a reverb zone. This needs to be added to a collider object to work properly. See 在 Inspector 中使用 AkEnvironment 和 AkEnvironmentPortal (Reverb Zone).
    public AkEnvironment Environment;

    // 12、AkEnvironmentPortal：Use this component to define an area that straddles two different AkEnvironment's zones and allow mixing between both zones. 在 Inspector 中使用 AkEnvironment 和 AkEnvironmentPortal (Reverb Zone)
    public AkEnvironmentPortal EnvironmentPortal;

    // 13、AkEventCallbackMsg：Event callback information. Event callback functions can receive this structure as a parameter.
    public AkEventCallbackMsg EventCallbackMsg;

    // 14、AkGameObj：This component represents a sound object in your scene tracking its position and other game syncs such as Switches, RTPC and environment values. 
    // You can add this to any object that will emit sound, and it will be added to any object that an AkAudioListener is attached to. 
    // Note that if it is not present, Wwise will add it automatically, with the default values, to any Unity Game Object that is passed to Wwise.
    public AkGameObj GameObj;

    // 15、AkInitializer：This script deals with initialization, and frame updates of the Wwise audio engine.
    // It is marked as DontDestroyOnLoad so it stays active for the life of the game, not only one scene. 
    // Double-click the Initialization Settings entry, AkWwiseInitializationSettings, to review and edit Wwise initialization settings.
    public AkInitializer Initializer;

    // 16、AkMemBankLoader：This class is an example of how to load banks in Wwise, if the bank data was preloaded in memory.
    // This would be useful for situations where you use the WWW class
    public AkMemBankLoader MemBankLoader;

    // 17、AkRadialEmitter：A radial emitter is for sounds that are not point sources, but instead originate from a region of space.
    public AkRadialEmitter RadialEmitter;

    // 18、AkRoom：An AkRoom is an enclosed environment that can only communicate to the outside/other rooms with AkRoomPortals.
    // The AkRoom component uses its required Collider component to determine when AkRoomAwareObjects enter and exit the room using the OnTriggerEnter and OnTriggerExit callbacks.
    public AkRoom Room;

    // 19、AkRoomAwareManager：This manager tracks the AkRoomAwareObjects and the AkRooms in which they enter and exit.
    // At the end of the frame, the AkRoomAwareObject is set in the highest priority AkRoom in Spatial Audio.
    public AkRoomAwareManager RoomAwareManager;

    // 20、AkRoomAwareObject：This component makes a GameObject aware of AkRoom components. When using Spatial Audio rooms, all emitters and the spatial audio listener should have this component.
    public AkRoomAwareObject RoomAwareObject;

    // 21、AkRoomManager：This manager tracks AkRoomPortals and the rooms that they connect (front and back room).
    // At the end of the frame, the AkRoomPortals which rooms might have changed are updated and sent to Spatial Audio.
    public AkRoomManager RoomManager;

    // 22、AkRoomPortal：An AkRoomPortal can connect two AkRoom components together.
    public AkRoomPortal RoomPortal;

    // 23、AkRoomPortalObstruction：Completely obstructs the spatial audio portal of the current game object from the spatial audio listener if at least one object is between them.
    // If no spatial audio listener has been registered, there will be no obstruction.
    public AkRoomPortalObstruction RoomPortalObstruction;

    // 24、AkSpatialAudioDebugDraw：Add this script on a GameObject to print Spatial Audio paths.
    public AkSpatialAudioDebugDraw SpatialAudioDebugDraw；

    // 25、AkSpatialAudioEmitter：(DEPRECATED) This script is deprecated as of 2019.2. Early reflections, Diffraction and Room Reverb can all be enabled per sound in the Sound Property Editor of the Authoring.
    // Some functionalities were moved to different components. See the AkEarlyReflections and AkSpatialAudioDebugDraw components for more details.
    public AkSpatialAudioEmitter SpatialAudioEmitter;

    // 26、AkSpatialAudioListener：Add this script on the game object that represent a listener. This is normally added to the Camera object or the Player object, but can be added to any game object when implementing 3D busses. 
    // isDefaultListener determines whether the game object will be considered a default listener - a listener that automatically listens to all game objects that do not have listeners attached to their AkGameObjListenerList's.
    public AkSpatialAudioListener SpatialAudioListener;

    // 27、AkSurfaceReflector：This component converts the provided mesh into Spatial Audio Geometry.
    // This component takes a mesh as a parameter. The triangles of the mesh are sent to Spatial Audio by calling SpatialAudio::AddGeometrySet(). The triangles reflect sounds that have an associated early reflections bus. 
    // If diffraction is enabled on this component, spatial audio also finds edges on the provided mesh, which diffract sounds that are diffraction enabled.
    public AkSurfaceReflector SurfaceReflector;

    // 28、AkWaapiUtilities：This class wraps the client that communicates with the Wwise Authoring application via WAAPI. Given that only one request can be pending on the websocket, a queue is used to consume all calls sequentially. 
    // Messages sent to WAAPI use the JSON format and are serialized by Unity Json serialization. Helper classes (WaapiHelper) for serialization, keywords for WAAPI commands (WaapiKeywords), 
    // and classes for serializing message arguments and deserializing responses are found in AkWaapiHelper.cs. Uri.cs contains classes with fields containing URI strings for WAAPI calls and error messages.
    public AkWaapiUtilities WaapiUtilities;

    // 29、AkWwiseTreeWAAPIDataSource：This class communicates with Wwise Authoring via AkWaapiUtilities to keep track of the Wwise object hierarchy in the project. 
    // This hierarchy information is stored in a tree structure and is used by the Wwise Picker when it is in WAAPI mode. Changes to the project are received via WAAPI subscriptions.
    public AkWwiseTreeWAAPIDataSource WwiseTreeWAAPIDataSource;

    // 30、ak：URI strings to use in WAAPI calls. For a complete description, refer to the official Wwise SDK documentation.
    public ak ak;

}
