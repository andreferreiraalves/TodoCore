dotnet new mvc --auth Individual

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet-aspnet-codegenerator controller -name TodoController -dc ApplicationDbContext -m Todo --useDefaultLayout --useSqlite --referenceScriptLibraries
