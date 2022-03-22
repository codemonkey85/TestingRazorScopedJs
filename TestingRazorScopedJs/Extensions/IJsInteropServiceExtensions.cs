namespace TestingRazorScopedJs.Extensions;

public static class IJsInteropServiceExtensions
{
    private const string mainJsModuleName = @"/js/app.js";

    private static void CheckInitialized(IJsInteropService jsInteropService)
    {
        if (!jsInteropService.ModuleInitialized(mainJsModuleName))
        {
            jsInteropService.InitializeModule(mainJsModuleName);
        }
    }

    public static async Task<bool> ConfirmDialog(this IJsInteropService jsInteropService, string message)
    {
        CheckInitialized(jsInteropService);
        return await jsInteropService.InvokeWithModuleAsync<bool>(mainJsModuleName, "confirmDialog", message);
    }
}
