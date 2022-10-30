
public class AK_Tool
{
    // 1、JsonSerializable：Base class for Json serializable objects. Implements implicit cast to string using UnityEngine.JsonUtility.ToJson.
    public JsonSerializable JsonSerializable;

    // 2、Args：Abstract base class for WAAPI command arguments.
    public Args Args;

    // 3、ArgsCommand：WAAPI arguments containing an object identfier and command field. Used by AkWaapiUtilities.SelectObjectInAuthoringAsync().
    public ArgsCommand ArgsCommand;

    // 4、ArgsDisplayName：WAAPI arguments containing an object identfier and name used when deleting an object.
    public ArgsDisplayName ArgsDisplayName;

    // 5、ArgsObject：WAAPI arguments containing an object identfier.
    public ArgsObject ArgsObject;

    // 6、ArgsPlay：WAAPI arguments containing an Event identfier and transport ID. Used to toggle Event playback.
    public ArgsPlay ArgsPlay;

    // 7、ArgsRename：WAAPI arguments containing an object identfier and new value used when renaming an object.
    public ArgsRename ArgsRename;

    // 8、ArgsTransport：WAAPI arguments containing a transport ID. Used to specify transports in transport-specific commands.
    public ArgsTransport ArgsTransport;

    // 9、WaqlArgs：WAAPI arguments containing a WAQL string.
    public WaqlArgs WaqlArgs;

    // 10、ErrorDetails：Used to deserialize details in WAAPI error messages.
    public ErrorDetails ErrorDetails;

    // 11、ErrorMessage：Used to deserialize WAAPI error messages.
    public ErrorMessage ErrorMessage;

    // 12、Options：Abstract base class for WAAPI command options.
    public Options Options;

    // 13、ReturnOptions：WAAPI options to specify the names of fields to return in a WAAPI request returning WwiseObjects.
    public ReturnOptions ReturnOptions;

    // 14、TransportOptions：WAAPI options used to specify the transport ID when subscribing.
    public TransportOptions TransportOptions;

    // 15、ReturnTransport：Used to deserialize the response from an ak.wwise.core.transport.create command. Contains the transport ID.
    public ReturnTransport ReturnTransport;

    // 16、ReturnWwiseObjects< T > ：Generic class to deserialize a WAAPI response containing Wwise objects with custom return options.
    public ReturnWwiseObjects< T >  ReturnWwiseObjects;

    // 17、SelectedWwiseObjects：Class used to deserialize selected Wwise objects published on the ak.wwise.ui.selectionChanged topic.
    public SelectedWwiseObjects SelectedWwiseObjects;

    // 18、TransportState：Used to deserialize transport-state information receieved from the transport.stateChanged topic.
    public TransportState TransportState;

    // 19、WwiseChildModifiedInfo：Used to deserialize information published on the ak.wwise.core.@object.childAdded and ak.wwise.core.@object.childRemoved topics.
    public WwiseChildModifiedInfo WwiseChildModifiedInfo;

    // 20、WwiseRenameInfo：Used to deserialize information published on the ak.wwise.core.@object.nameChanged topic.
    public WwiseRenameInfo WwiseRenameInfo;

    // 21、WaapiHelper：Contains a helper function GetWwiseObjectTypeFromString.
    public WaapiHelper WaapiHelper;

    // 22、WaapiKeywords：Contains fields for specific WAAPI keywords.
    public WaapiKeywords WaapiKeywords;

    // 23、Wamp：WAMP protocol implementation using only strings and regular expressions. This implements only a subset of the WAMP feature set and is only compatible with Wwise.
    public Wamp Wamp;

    // 24、WwiseObjectInfo：Class containing the information returned by a WAAPI request for an object.
    public WwiseObjectInfo WwiseObjectInfo;

    // 25、WwiseObjectInfoJsonObject：Used to deserialize information from a request for a Wwise object. Implements an implicit cast to WwiseObjectInfo.
    public WwiseObjectInfoJsonObject WwiseObjectInfoJsonObject;

    // 26、WwiseObjectInfoParent：Contains the GUID of the returned object's parent.
    public WwiseObjectInfoParent WwiseObjectInfoParent;

}
