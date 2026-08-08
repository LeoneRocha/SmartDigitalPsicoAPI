# SmartDigitalPsico.WebAPI � .NET 10
# Build context: pasta SmartDigitalPsicoAPI (docker-compose / raiz)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Restore com cache de layers � incluir todos os ProjectReference (incl. Core.SDK)
COPY ["SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj", "SmartDigitalPsico.WebAPI/"]
COPY ["SmartDigitalPsico.Service/SmartDigitalPsico.Service.csproj", "SmartDigitalPsico.Service/"]
COPY ["SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj", "SmartDigitalPsico.Data/"]
COPY ["SmartDigitalPsico.Domain/SmartDigitalPsico.Domain.csproj", "SmartDigitalPsico.Domain/"]
COPY ["SmartDigitalPsico.Core.SDK/SmartDigitalPsico.Core.SDK.csproj", "SmartDigitalPsico.Core.SDK/"]
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

# curl para HEALTHCHECK (imagem aspnet n�o inclui por padr�o)
USER root
RUN apt-get update \
    && apt-get install -y --no-install-recommends curl \
    && rm -rf /var/lib/apt/lists/*

COPY --from=publish /app/publish .
# Certificado na raiz do contexto (tamb�m pode vir do publish)
COPY ["certificate.pfx", "./certificate.pfx"]
RUN chown -R app:app /app

USER app

ENV TZ=America/Sao_Paulo
ENV ASPNETCORE_ENVIRONMENT=Production
# Porta 8080: usu�rio n�o-root (app) n�o pode bind em 80
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="4d67018d-4a23-43cb-8ff1-6249058a5774"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/certificate.pfx"

ENTRYPOINT ["dotnet", "SmartDigitalPsico.WebAPI.dll"]

HEALTHCHECK --interval=30s --timeout=5s --start-period=40s --retries=3 \
  CMD curl --fail http://localhost:80/health || exit 1
