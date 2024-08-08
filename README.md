This is a repro for https://github.com/OData/AspNetCoreOData/issues/1293

Steps to reproduce error:
1. Run odata-repro via IIS Express - should open to https://localhost:44362
2. Run the queries in odata-repro.http - the first two work, the final one fails with an error message
```
An unhandled exception has occurred while executing the request.
      System.UriFormatException: Invalid URI: The Uri string is too long.
         at System.Uri.CreateThis(String uri, Boolean dontEscape, UriKind uriKind, UriCreationOptions& creationOptions)
         at System.Uri..ctor(String uriString)
         at Microsoft.AspNetCore.OData.Formatter.Serialization.ODataResourceSetSerializer.<>c__DisplayClass17_2.<GetNextLinkGenerator>b__2(Object obj)
         at Microsoft.AspNetCore.OData.Formatter.Serialization.ODataResourceSetSerializer.WriteResourceSetAsync(IEnumerable enumerable, IEdmTypeReference resourceSetType, ODataWriter writer, ODataSerializerContext writeContext)
         at Microsoft.AspNetCore.OData.Formatter.Serialization.ODataResourceSetSerializer.WriteObjectInlineAsync(Object graph, IEdmTypeReference expectedType, ODataWriter writer, ODataSerializerContext writeContext)
         at Microsoft.AspNetCore.OData.Formatter.Serialization.ODataResourceSetSerializer.WriteObjectAsync(Object graph, Type type, ODataMessageWriter messageWriter, ODataSerializerContext writeContext)
         at Microsoft.AspNetCore.OData.Formatter.ODataOutputFormatterHelper.WriteToStreamAsync(Type type, Object value, IEdmModel model, ODataVersion version, Uri baseAddress, MediaTypeHeaderValue contentType, HttpRequest request, IHeaderDictionary requestHeaders, IODataSerializerProvider serializerProvider)
         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeResultAsync>g__Logged|22_0(ResourceInvoker invoker, IActionResult result)
         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResultFilterAsync>g__Awaited|30_0[TFilter,TFilterAsync](ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResultExecutedContextSealed context)
         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.ResultNext[TFilter,TFilterAsync](State& next, Scope& scope, Object& state, Boolean& isCompleted)
         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeResultFilters()
```
