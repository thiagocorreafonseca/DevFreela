### DevFreela

#### Criando o arquivo Solution do Projeto
```csharp
dotnet new sln --name DevFreela
```
#### Criando o Projeto Api
```csharp
dotnet new webapi -n DevFreela.Api --output DevFreela.Api
```
#### Adicionando o projeto Api na Solution
```csharp
dotnet sln DevFreela.sln add ./DevFreela.Api/DevFreela.Api.csproj
```

#### Comando para criar a imagem Docker da API
```docker
docker build --no-cache -f Dockerfile -t devfreela ..   
```

#### Comando para executar a imagem
```docker
docker run -d -p 5000:80 --name devfreela_image devfreela:latest 
```
