# SmartDigitalPsico.WebAPI — .NET 10
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER app
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Restore com cache de layers (contexto = raiz SmartDigitalPsicoAPI)
COPY ["SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj", "SmartDigitalPsico.WebAPI/"]
COPY ["SmartDigitalPsico.Service/SmartDigitalPsico.Service.csproj", "SmartDigitalPsico.Service/"]
COPY ["SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj", "SmartDigitalPsico.Data/"]
COPY ["SmartDigitalPsico.Domain/SmartDigitalPsico.Domain.csproj", "SmartDigitalPsico.Domain/"]
COPY ["Directory.Packages.props", "./"]
COPY ["global.json", "./"]
RUN dotnet restore "SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj"

COPY . .
WORKDIR "/src/SmartDigitalPsico.WebAPI"
RUN dotnet build "./SmartDigitalPsico.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SmartDigitalPsico.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Garante certificado no container (tambem vem do publish via CopyToOutputDirectory)
COPY ["certificate.pfx", "./certificate.pfx"]

ENV TZ=America/Sao_Paulo
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="4d67018d-4a23-43cb-8ff1-6249058a5774"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/certificate.pfx"

ENTRYPOINT ["dotnet", "SmartDigitalPsico.WebAPI.dll"]

HEALTHCHECK --interval=5m --timeout=3s \
  CMD curl --fail http://localhost:80/health || exit 1
