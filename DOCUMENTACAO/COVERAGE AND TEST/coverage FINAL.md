 
---

## 📝 Prompt otimizado (SonarQube/SonarCloud)

1. **Revisar/criar todos os testes** garantindo **100% de cobertura de linhas e ramos**.  
2. **Nomes dos métodos em inglês**, padrão `Metodo_Cenario_Resultado`.  
   - Se houver nomes em português, renomear para inglês.  
3. **Comentário em português** acima de cada método explicando cenário/objetivo:
   - `// Cenário: ...`
   - `// Objetivo: ...`
4. Seguir o padrão **Arrange / Act / Assert (AAA)** no corpo do método, com marcadores:
   - `// Arrange`
   - `// Act`
   - `// Assert`
5. Usar **NUnit, Moq, Bogus, AwesomeAssertions**.
6. Cobrir: fluxo principal, alternativos, limites e erros/exceções.
7. Cada teste deve ser **independente, limpo e performático**.
8. Usar **Bogus** para dados realistas e limites (null, inválidos, extremos).
9. Usar **Moq** para simular dependências (sucesso, null, exceção).
10. Para múltiplas validações, usar `Assert.Multiple`.
11. Seguir convenções de estilo já existentes.

---

## ⚙️ Execução obrigatória
- **Passo 1:** Rodar build  
  ```bash
  dotnet build
  ```
- **Passo 2:** Rodar testes com cobertura  
  ```bash
  dotnet test --collect:"XPlat Code Coverage"
  ```
- **Passo 3:** Analisar resultado dos testes e cobertura Sonar (SonarCloud/SonarQube).  
- **Passo 4:** Se alguma linha não for coberta, ajustar os testes até atingir **100% de cobertura**.  

---

## 🎯 Resultado esperado
- Testes revisados/criados com nomes corretos e comentários claros.  
- Cobertura total validada pelo Sonar.  
- Código limpo, consistente e otimizado.  
- Build e suíte de testes rodando sem erros em `C:\git\SMARTDIGITALPSICO\SmartDigitalPsicoAPI\`.  

 
--- 

Instrução inicial: 

Rode os testes com Coverlet, colete o coverage e analise o resultado para identificar o que não está coberto. A partir dessa análise, ajuste ou crie novos testes até atingir 100% de cobertura.

1. Revisar ou criar todos os testes garantindo 100% de cobertura de linhas e ramos.  
2. Nomes dos métodos em inglês, padrão Metodo_Cenario_Resultado.  
   - Se houver nomes em português, renomear para inglês.  
3. Comentário em português acima de cada método (`// Cenário:` / `// Objetivo:`).
4. Corpo do teste no padrão AAA com `// Arrange`, `// Act` e `// Assert`.
5. Usar NUnit, Moq, Bogus e AwesomeAssertions.
6. Cobrir fluxo principal, alternativos, limites e erros/exceções.
7. Cada teste deve ser independente, limpo e performático.
8. Usar Bogus para dados realistas e limites (null, inválidos, extremos).
9. Usar Moq para simular dependências (sucesso, null, exceção).
10. Para múltiplas validações, usar Assert.Multiple.
11. Seguir convenções de estilo já existentes.

Execução obrigatória:
- Passo 1: rodar build com `dotnet build`.  
- Passo 2: rodar testes com cobertura usando Coverlet:  
  ```bash
  dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
  ```  
- Passo 3: analisar resultado dos testes e cobertura Sonar (SonarCloud/SonarQube).  
- Passo 4: se alguma linha não for coberta, ajustar os testes até atingir 100% de cobertura.  

Resultado esperado:
- Testes revisados/criados com nomes corretos e comentários claros.  
- Cobertura total validada pelo Sonar.  
- Código limpo, consistente e otimizado.  
- Build e suíte de testes rodando sem erros em C:\git\repos\SmartCoreHub\backend.    

