# Rascunho de README (API) — legado

> **Obsoleto como documentação oficial.** Use o README principal na raiz: [`../README.md`](../README.md).

Este arquivo era um rascunho antigo (referências a Asp.Net Core 7/8 misturadas e URLs genéricas). Mantido apenas como histórico na pasta `Readme/`.

## Publicação atual (produção)

- API: https://smartdigitalpsicoapi.azurewebsites.net/
- UI: https://smartdigitalpsicoui.azurewebsites.net/authpages/login

Homologação/staging: **descontinuado**.

## Execução rápida (referência)

```bash
git clone https://github.com/LeoneRocha/SmartDigitalPsicoAPI.git
cd SmartDigitalPsicoAPI
dotnet restore SmartDigitalPsicoAPI.sln
dotnet run --project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj
```

Stack atual do backend: **.NET 10**, EF Core 9 (Pomelo MySQL e/ou SqlServer), Swagger, JWT.  
Frontend companion: Angular **22** (UI Dashboard).  
Documentação oficial: [`../README.md`](../README.md).
