# Etapa 1: build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar os arquivos do projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar o restante do código
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: imagem de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "BibliotecaEscolar.dll"]
