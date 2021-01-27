FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["server/JonnychipzBlazorWebApp.Server.csproj", "server/"]
RUN dotnet restore "server/JonnychipzBlazorWebApp.Server.csproj"
COPY . .
WORKDIR "/src/server"
RUN $NUGET_CERT_REVOCATION_MODE = "offline"
RUN dotnet build "JonnychipzBlazorWebApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JonnychipzBlazorWebApp.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JonnychipzBlazorWebApp.Server.dll"]