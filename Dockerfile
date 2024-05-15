# Imagem base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

# Expõe as portas 80 e 443
EXPOSE 80
#SSL 
EXPOSE 443
# ALTERNATE TO 80  
EXPOSE 8080

# Copia dos arquivos do projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia do codigo fonte
COPY . ./

COPY *.csproj ./

# Restaura as dependencias do projeto
RUN dotnet restore "SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj"

# Copia do codigo fonte
COPY . ./

# Build da aplicacao
WORKDIR "/src/SmartDigitalPsico.WebAPI"
RUN dotnet build "./SmartDigitalPsico.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicacao da aplicacao
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SmartDigitalPsico.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Certificado
COPY *.pfx . 

# Execucao da aplicacao
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Ambiente definicoes 
ENV TZ America/Sao_Paulo
ENV ASPNETCORE_ENVIRONMENT Production 

ENV ASPNETCORE_Kestrel__Certificates__Default__Password="4d67018d-4a23-43cb-8ff1-6249058a5774"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/certificate.pfx"
  
# Define o comando de entrada
ENTRYPOINT ["dotnet", "SmartDigitalPsico.WebAPI.dll"]