FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GitHubActions-POC/GitHubActions-POC.csproj", "GitHubActions-POC/"]
RUN dotnet restore "GitHubActions-POC/GitHubActions-POC.csproj"
COPY . .
WORKDIR "/src/GitHubActions-POC"
RUN dotnet build "GitHubActions-POC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GitHubActions-POC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GitHubActions-POC.dll"]
