# ApplicationIAConfig — JSON para variável do Azure DevOps

> **Escopo:** documento operacional de configuração de pipeline (variável `ApplicationIAConfig`).  
> **Fora do ciclo** de migração .NET 8 → .NET 10 / atualização de pacotes NuGet.  
> Para TFM, Conjunto Homologado e plano de implementação, ver:  
> `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md` e  
> `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`.

Cole o valor abaixo na variável de pipeline **`ApplicationIAConfig`** (como já fazem com `AzureAd` e `TokenConfigurations`).

```json
{"VectorStores":{"AzureAISearch":{"Endpoint":"","ApiKey":""},"AzureCosmosDBMongoDB":{"ConnectionString":"","DatabaseName":""},"AzureCosmosDBNoSQL":{"ConnectionString":"","DatabaseName":""},"Qdrant":{"Host":"e6f97a9b-ec67-4fdd-b4d7-6d48cae736ac.sa-east-1-0.aws.cloud.qdrant.io","Port":6334,"Https":true,"ApiKey":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2Nlc3MiOiJtIiwic3ViamVjdCI6ImFwaS1rZXk6ZDIwOWYzNGMtM2EzZi00MzgxLWIwZWItNmZiNjZkOGY0ZTNmIn0.P3gsId0hcnhn2C82AtGQDi5w14T9B5UccNg6QKbsPmo"},"Redis":{"ConnectionConfiguration":"localhost:6379"},"Weaviate":{"Endpoint":"http://localhost:8080/v1/"}},"AIServices":{"AzureOpenAI":{"Endpoint":"","ChatDeploymentName":"gpt-4"},"AzureOpenAIEmbeddings":{"Endpoint":"","DeploymentName":"text-embedding-ada-002"},"OpenAI":{"ModelId":"gpt-4o","ApiKey":"","OrgId":null},"OpenAIEmbeddings":{"ModelId":"text-embedding-3-small","ApiKey":"","OrgId":null},"GroqApi":{"ModelId":"mixtral-8x7b-32768","ApiKey":"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","OrgId":null},"MistralApi":{"ModelId":"mistral-medium-latest","ApiKey":"YE922PonLSWuHVbkDMNuN2hGyEuWON2O","OrgId":null},"MistralApiEmbeddings":{"ModelId":"mistral-embed","ApiKey":"YE922PonLSWuHVbkDMNuN2hGyEuWON2O","OrgId":null},"OllamaApi":{"Endpoint":"http://localhost:11434","ModelId":"llama3.2","EndpointEmbeddings":"http://localhost:11434","ModelIdEmbeddings":"nomic-embed-text","ApiKey":"","OrgId":null}},"Rag":{"AIChatServiceApi":"MistralApi","AIEmbeddingServiceApi":"MistralApiEmbeddings","AIChatServiceAdapter":"SemanticKernel","AIEmbeddingServiceApiAdapter":"SemanticKernel","BuildCollection":true,"VectorStoreCollectionPrefixName":"production_","VectorStoreDimensions":1024,"DataLoadingBatchSize":10,"DataLoadingBetweenBatchDelayInMilliseconds":1000,"PdfFilePaths":["sourcedocument.pdf"],"VectorStoreType":"InMemory","SearchSettings":{"DelayBeforeSearchMilliseconds":10000}}}
```

## Formatado (leitura)

```json
{
  "VectorStores": {
    "AzureAISearch": {
      "Endpoint": "",
      "ApiKey": ""
    },
    "AzureCosmosDBMongoDB": {
      "ConnectionString": "",
      "DatabaseName": ""
    },
    "AzureCosmosDBNoSQL": {
      "ConnectionString": "",
      "DatabaseName": ""
    },
    "Qdrant": {
      "Host": "e6f97a9b-ec67-4fdd-b4d7-6d48cae736ac.sa-east-1-0.aws.cloud.qdrant.io",
      "Port": 6334,
      "Https": true,
      "ApiKey": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2Nlc3MiOiJtIiwic3ViamVjdCI6ImFwaS1rZXk6ZDIwOWYzNGMtM2EzZi00MzgxLWIwZWItNmZiNjZkOGY0ZTNmIn0.P3gsId0hcnhn2C82AtGQDi5w14T9B5UccNg6QKbsPmo"
    },
    "Redis": {
      "ConnectionConfiguration": "localhost:6379"
    },
    "Weaviate": {
      "Endpoint": "http://localhost:8080/v1/"
    }
  },
  "AIServices": {
    "AzureOpenAI": {
      "Endpoint": "",
      "ChatDeploymentName": "gpt-4"
    },
    "AzureOpenAIEmbeddings": {
      "Endpoint": "",
      "DeploymentName": "text-embedding-ada-002"
    },
    "OpenAI": {
      "ModelId": "gpt-4o",
      "ApiKey": "",
      "OrgId": null
    },
    "OpenAIEmbeddings": {
      "ModelId": "text-embedding-3-small",
      "ApiKey": "",
      "OrgId": null
    },
    "GroqApi": {
      "ModelId": "mixtral-8x7b-32768",
      "ApiKey": "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",
      "OrgId": null
    },
    "MistralApi": {
      "ModelId": "mistral-medium-latest",
      "ApiKey": "YE922PonLSWuHVbkDMNuN2hGyEuWON2O",
      "OrgId": null
    },
    "MistralApiEmbeddings": {
      "ModelId": "mistral-embed",
      "ApiKey": "YE922PonLSWuHVbkDMNuN2hGyEuWON2O",
      "OrgId": null
    },
    "OllamaApi": {
      "Endpoint": "http://localhost:11434",
      "ModelId": "llama3.2",
      "EndpointEmbeddings": "http://localhost:11434",
      "ModelIdEmbeddings": "nomic-embed-text",
      "ApiKey": "",
      "OrgId": null
    }
  },
  "Rag": {
    "AIChatServiceApi": "MistralApi",
    "AIEmbeddingServiceApi": "MistralApiEmbeddings",
    "AIChatServiceAdapter": "SemanticKernel",
    "AIEmbeddingServiceApiAdapter": "SemanticKernel",
    "BuildCollection": true,
    "VectorStoreCollectionPrefixName": "production_",
    "VectorStoreDimensions": 1024,
    "DataLoadingBatchSize": 10,
    "DataLoadingBetweenBatchDelayInMilliseconds": 1000,
    "PdfFilePaths": [
      "sourcedocument.pdf"
    ],
    "VectorStoreType": "InMemory",
    "SearchSettings": {
      "DelayBeforeSearchMilliseconds": 10000
    }
  }
}
```

**Não** inclua a chave raiz `"ApplicationIAConfig"` — o nome da variável do pipeline já é essa seção.
