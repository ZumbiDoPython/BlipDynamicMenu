FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlipCreateMenuByChannel.Api/BlipCreateMenuByChannel.Api.csproj", "BlipCreateMenuByChannel.Api/"]
RUN dotnet restore "BlipCreateMenuByChannel.Api/BlipCreateMenuByChannel.Api.csproj"
COPY . .
WORKDIR "/src/BlipCreateMenuByChannel.Api"
RUN dotnet build "BlipCreateMenuByChannel.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlipCreateMenuByChannel.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlipCreateMenuByChannel.Api.dll"]
