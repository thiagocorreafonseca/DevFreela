### DevFreela

####Criando o arquivo Solution do Projeto
```csharp
dotnet new sln --name DevFreela
```
####Criando o Projeto Api
```csharp
dotnet new webapi -n DevFreela.Api --output DevFreela.Api
```
####Adicionando o projeto Api na Solution
```csharp
dotnet sln DevFreela.sln add ./DevFreela.Api/DevFreela.Api.csproj
```