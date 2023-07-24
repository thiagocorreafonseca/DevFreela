### DevFreela

#### Criando o arquivo Solution do Projeto
```csharp
dotnet new sln --name DevFreela
```
#### Criando o Projeto Core
```csharp
dotnet new classlib -o DevFreela.Core -n DevFreela.Core
```

#### Criando o Projeto Api
```csharp
dotnet new webapi -n DevFreela.Api --output DevFreela.Api
```


#### Adicionando a referência do Projeto Core na API
```csharp
cd .\DevFreela.Api\
dotnet add reference ../DevFreela.Core/DevFreela.Core.csproj
```

#### Adicionando os projetos na Solution
```csharp
dotnet sln DevFreela.sln add ./DevFreela.Core/DevFreela.Core.csproj
dotnet sln DevFreela.sln add ./DevFreela.Api/DevFreela.Api.csproj
```

## Docker
#### Comando para criar a imagem Docker da API
```docker
docker build --no-cache -f Dockerfile -t devfreela ..   
```

#### Comando para executar a imagem
```docker
docker run -d -p 5000:80 --name devfreela_image devfreela:latest 
```
