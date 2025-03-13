namespace DotNetNinja.Templates.Mvc.Constants;

public static class HttpStatus
{
    /// <summary>
    /// Http Status Code 100 - Continue
    /// </summary>
    public static readonly int Continue = StatusCodes.Status100Continue;

    /// <summary>
    /// Http Status Code 101 - Switching Protocols
    /// </summary>
    public static readonly int SwitchingProtocols = StatusCodes.Status101SwitchingProtocols;

    /// <summary>
    /// Http Status Code 102 - Processing
    /// </summary>
    public static readonly int Processing = StatusCodes.Status102Processing;

    /// <summary>
    /// Http Status Code 200 - OK
    /// </summary>
    public static readonly int Ok = StatusCodes.Status200OK;

    /// <summary>
    /// Http Status Code 201 - Created
    /// </summary>
    public static readonly int Created = StatusCodes.Status201Created;

    /// <summary>
    /// Http Status Code 202 - Accepted
    /// </summary>
    public static readonly int Accepted = StatusCodes.Status202Accepted;

    /// <summary>
    /// Http Status Code 203 - Non Authoritative
    /// </summary>
    public static readonly int NonAuthoritative = StatusCodes.Status203NonAuthoritative;

    /// <summary>
    /// Http Status Code 204 - No Content
    /// </summary>
    public static readonly int NoContent = StatusCodes.Status204NoContent;

    /// <summary>
    /// Http Status Code 205 - Reset Content
    /// </summary>
    public static readonly int ResetContent = StatusCodes.Status205ResetContent;

    /// <summary>
    /// Http Status Code 206 - Partial Content
    /// </summary>
    public static readonly int PartialContent = StatusCodes.Status206PartialContent;

    /// <summary>
    /// Http Status Code 207 - Multi Status
    /// </summary>
    public static readonly int MultiStatus = StatusCodes.Status207MultiStatus;

    /// <summary>
    /// Http Status Code 208 - Already Reported
    /// </summary>
    public static readonly int AlreadyReported = StatusCodes.Status208AlreadyReported;

    /// <summary>
    /// Http Status Code 226 - IMUsed
    /// </summary>
    public static readonly int IMUsed = StatusCodes.Status226IMUsed;

    /// <summary>
    /// Http Status Code 300 - Multiple Choices
    /// </summary>
    public static readonly int MultipleChoices = StatusCodes.Status300MultipleChoices;

    /// <summary>
    /// Http Status Code 301 - Moved Permanently
    /// </summary>
    public static readonly int MovedPermanently = StatusCodes.Status301MovedPermanently;

    /// <summary>
    /// Http Status Code 302 - Found
    /// </summary>
    public static readonly int Found = StatusCodes.Status302Found;

    /// <summary>
    /// Http Status Code 303 - See Other
    /// </summary>
    public static readonly int SeeOther = StatusCodes.Status303SeeOther;

    /// <summary>
    /// Http Status Code 304 - Not Modified
    /// </summary>
    public static readonly int NotModified = StatusCodes.Status304NotModified;

    /// <summary>
    /// Http Status Code 305 - Use Proxy
    /// </summary>
    public static readonly int UseProxy = StatusCodes.Status305UseProxy;

    /// <summary>
    /// Http Status Code 306 - Switch Proxy
    /// </summary>
    public static readonly int SwitchProxy = StatusCodes.Status306SwitchProxy;

    /// <summary>
    /// Http Status Code 307 - Temporary Redirect
    /// </summary>
    public static readonly int TemporaryRedirect = StatusCodes.Status307TemporaryRedirect;

    /// <summary>
    /// Http Status Code 308 - Permanent Redirect
    /// </summary>
    public static readonly int PermanentRedirect = StatusCodes.Status308PermanentRedirect;

    /// <summary>
    /// Http Status Code 400 - Bad Request
    /// </summary>
    public static readonly int BadRequest = StatusCodes.Status400BadRequest;

    /// <summary>
    /// Http Status Code 401 - Unauthorized
    /// </summary>
    public static readonly int Unauthorized = StatusCodes.Status401Unauthorized;

    /// <summary>
    /// Http Status Code 402 - Payment Required
    /// </summary>
    public static readonly int PaymentRequired = StatusCodes.Status402PaymentRequired;

    /// <summary>
    /// Http Status Code 403 - Forbidden
    /// </summary>
    public static readonly int Forbidden = StatusCodes.Status403Forbidden;

    /// <summary>
    /// Http Status Code 404 - Not Found
    /// </summary>
    public static readonly int NotFound = StatusCodes.Status404NotFound;

    /// <summary>
    /// Http Status Code 405 - Method Not Allowed
    /// </summary>
    public static readonly int MethodNotAllowed = StatusCodes.Status405MethodNotAllowed;

    /// <summary>
    /// Http Status Code 406 - Not Acceptable
    /// </summary>
    public static readonly int NotAcceptable = StatusCodes.Status406NotAcceptable;

    /// <summary>
    /// Http Status Code 407 - Proxy Authentication Required
    /// </summary>
    public static readonly int ProxyAuthenticationRequired = StatusCodes.Status407ProxyAuthenticationRequired;

    /// <summary>
    /// Http Status Code 408 - Request Timeout
    /// </summary>
    public static readonly int RequestTimeout = StatusCodes.Status408RequestTimeout;

    /// <summary>
    /// Http Status Code 409 - Conflict
    /// </summary>
    public static readonly int Conflict = StatusCodes.Status409Conflict;

    /// <summary>
    /// Http Status Code 410 - Gone
    /// </summary>
    public static readonly int Gone = StatusCodes.Status410Gone;

    /// <summary>
    /// Http Status Code 411 - Length Required
    /// </summary>
    public static readonly int LengthRequired = StatusCodes.Status411LengthRequired;

    /// <summary>
    /// Http Status Code 412 - Precondition Failed
    /// </summary>
    public static readonly int PreconditionFailed = StatusCodes.Status412PreconditionFailed;

    /// <summary>
    /// Http Status Code 413 - Request Entity Too Large
    /// </summary>
    public static readonly int RequestEntityTooLarge = StatusCodes.Status413RequestEntityTooLarge;

    /// <summary>
    /// Http Status Code 413 - Payload Too Large
    /// </summary>
    public static readonly int PayloadTooLarge = StatusCodes.Status413PayloadTooLarge;

    /// <summary>
    /// Http Status Code 414 - Request Uri Too Long
    /// </summary>
    public static readonly int RequestUriTooLong = StatusCodes.Status414RequestUriTooLong;

    /// <summary>
    /// Http Status Code 414 - Uri Too Long
    /// </summary>
    public static readonly int UriTooLong = StatusCodes.Status414UriTooLong;

    /// <summary>
    /// Http Status Code 415 - Unsupported Media Type
    /// </summary>
    public static readonly int UnsupportedMediaType = StatusCodes.Status415UnsupportedMediaType;

    /// <summary>
    /// Http Status Code 416 - Requested Range Not Satisfiable
    /// </summary>
    public static readonly int RequestedRangeNotSatisfiable = StatusCodes.Status416RequestedRangeNotSatisfiable;

    /// <summary>
    /// Http Status Code 416 - Range Not Satisfiable
    /// </summary>
    public static readonly int RangeNotSatisfiable = StatusCodes.Status416RangeNotSatisfiable;

    /// <summary>
    /// Http Status Code 417 - Expectation Failed
    /// </summary>
    public static readonly int ExpectationFailed = StatusCodes.Status417ExpectationFailed;

    /// <summary>
    /// Http Status Code 418 - Im ATeapot
    /// </summary>
    public static readonly int ImATeapot = StatusCodes.Status418ImATeapot;

    /// <summary>
    /// Http Status Code 419 - Authentication Timeout
    /// </summary>
    public static readonly int AuthenticationTimeout = StatusCodes.Status419AuthenticationTimeout;

    /// <summary>
    /// Http Status Code 421 - Misdirected Request
    /// </summary>
    public static readonly int MisdirectedRequest = StatusCodes.Status421MisdirectedRequest;

    /// <summary>
    /// Http Status Code 422 - Unprocessable Entity
    /// </summary>
    public static readonly int UnprocessableEntity = StatusCodes.Status422UnprocessableEntity;

    /// <summary>
    /// Http Status Code 423 - Locked
    /// </summary>
    public static readonly int Locked = StatusCodes.Status423Locked;

    /// <summary>
    /// Http Status Code 424 - Failed Dependency
    /// </summary>
    public static readonly int FailedDependency = StatusCodes.Status424FailedDependency;

    /// <summary>
    /// Http Status Code 426 - Upgrade Required
    /// </summary>
    public static readonly int UpgradeRequired = StatusCodes.Status426UpgradeRequired;

    /// <summary>
    /// Http Status Code 428 - Precondition Required
    /// </summary>
    public static readonly int PreconditionRequired = StatusCodes.Status428PreconditionRequired;

    /// <summary>
    /// Http Status Code 429 - Too Many Requests
    /// </summary>
    public static readonly int TooManyRequests = StatusCodes.Status429TooManyRequests;

    /// <summary>
    /// Http Status Code 431 - Request Header Fields Too Large
    /// </summary>
    public static readonly int RequestHeaderFieldsTooLarge = StatusCodes.Status431RequestHeaderFieldsTooLarge;

    /// <summary>
    /// Http Status Code 451 - Unavailable For Legal Reasons
    /// </summary>
    public static readonly int UnavailableForLegalReasons = StatusCodes.Status451UnavailableForLegalReasons;

    /// <summary>
    /// Http Status Code 500 - Internal Server Error
    /// </summary>
    public static readonly int InternalServerError = StatusCodes.Status500InternalServerError;

    /// <summary>
    /// Http Status Code 501 - Not Implemented
    /// </summary>
    public static readonly int NotImplemented = StatusCodes.Status501NotImplemented;

    /// <summary>
    /// Http Status Code 502 - Bad Gateway
    /// </summary>
    public static readonly int BadGateway = StatusCodes.Status502BadGateway;

    /// <summary>
    /// Http Status Code 503 - Service Unavailable
    /// </summary>
    public static readonly int ServiceUnavailable = StatusCodes.Status503ServiceUnavailable;

    /// <summary>
    /// Http Status Code 504 - Gateway Timeout
    /// </summary>
    public static readonly int GatewayTimeout = StatusCodes.Status504GatewayTimeout;

    /// <summary>
    /// Http Status Code 505 - Http Version Notsupported
    /// </summary>
    public static readonly int HttpVersionNotsupported = StatusCodes.Status505HttpVersionNotsupported;

    /// <summary>
    /// Http Status Code 506 - Variant Also Negotiates
    /// </summary>
    public static readonly int VariantAlsoNegotiates = StatusCodes.Status506VariantAlsoNegotiates;

    /// <summary>
    /// Http Status Code 507 - Insufficient Storage
    /// </summary>
    public static readonly int InsufficientStorage = StatusCodes.Status507InsufficientStorage;

    /// <summary>
    /// Http Status Code 508 - Loop Detected
    /// </summary>
    public static readonly int LoopDetected = StatusCodes.Status508LoopDetected;

    /// <summary>
    /// Http Status Code 510 - Not Extended
    /// </summary>
    public static readonly int NotExtended = StatusCodes.Status510NotExtended;

    /// <summary>
    /// Http Status Code 511 - Network Authentication Required
    /// </summary>
    public static readonly int NetworkAuthenticationRequired = StatusCodes.Status511NetworkAuthenticationRequired;
}    