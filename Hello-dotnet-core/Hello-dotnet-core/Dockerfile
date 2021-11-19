FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Hello-dotnet-core/Hello-dotnet-core.csproj", "Hello-dotnet-core/"]
RUN dotnet restore "Hello-dotnet-core/Hello-dotnet-core.csproj"
COPY . .
WORKDIR "/src/Hello-dotnet-core"
RUN dotnet build "Hello-dotnet-core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hello-dotnet-core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hello-dotnet-core.dll"]
