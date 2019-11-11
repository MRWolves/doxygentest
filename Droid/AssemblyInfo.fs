namespace docstest2.Droid

open System.Reflection
open System.Runtime.CompilerServices

// the name of the type here needs to match the name inside the ResourceDesigner attribute
type Resources = docstest2.Droid.Resource

[<assembly:Android.Runtime.ResourceDesigner("docstest2.Droid.Resources", IsApplication = true)>]
[<assembly:AssemblyTitle("docstest2.Droid")>]
[<assembly:AssemblyDescription("")>]
[<assembly:AssemblyConfiguration("")>]
[<assembly:AssemblyCompany("")>]
[<assembly:AssemblyProduct("")>]
[<assembly:AssemblyCopyright("${AuthorCopyright}")>]
[<assembly:AssemblyTrademark("")>]
[<assembly:AssemblyVersion("1.0.0.0")>]

//[<assembly: AssemblyDelaySign(false)>]
//[<assembly: AssemblyKeyFile("")>]

()
