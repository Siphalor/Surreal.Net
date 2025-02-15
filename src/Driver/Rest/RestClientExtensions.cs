using System.Diagnostics;

namespace SurrealDB.Driver.Rest;

public static class RestClientExtensions {
    [DebuggerStepThrough]
    public static Task<RestResponse> ToSurreal(this HttpResponseMessage msg) {
        return RestResponse.From(msg);
    }
}