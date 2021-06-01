#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["OpenSiconfi.Core/OpenSiconfi.Core.csproj", "OpenSiconfi.Core/"]
COPY ["OpenSiconfi.Domain/OpenSiconfi.Domain.csproj", "OpenSiconfi.Domain/"]
COPY ["OpenSiconfi.Ifrastructure/OpenSiconfi.Ifrastructure.csproj", "OpenSiconfi.Ifrastructure/"]
RUN dotnet restore "OpenSiconfi.Core/OpenSiconfi.Core.csproj"
COPY . .
WORKDIR "/src/OpenSiconfi.Core"
RUN dotnet build "OpenSiconfi.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenSiconfi.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenSiconfi.Core.dll"]