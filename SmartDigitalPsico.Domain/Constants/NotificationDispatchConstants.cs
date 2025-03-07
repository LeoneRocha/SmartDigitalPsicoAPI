﻿namespace SmartDigitalPsico.Domain.Constants
{
    public static class NotificationDispatchConstants
    {
        // Constantes de variáveis utilizadas nas mensagens
        public const string RecordId = "{RecordId}";
        public const string Count = "{Count}";
        public const string GroupCount = "{GroupCount}";
        public const string MedicalId = "{MedicalId}";
        public const string NextTime = "{NextTime}";
        public const string Completed = "{Completed}";
        public const string ScheduleTime = "{ScheduleTime}";
        public const string UpdatedCount = "{UpdatedCount}";

        // Constantes de mensagens
        public const string StartingProcessing = "Starting processing of pending notifications / Iniciando processamento de notificações pendentes.";
        public const string FoundPendingRecords = $"Found {Count} pending records / Encontrados {Count} registros pendentes.";        
        public const string RecordUpdated = $"Record {RecordId} updated successfully / Registro {RecordId} atualizado com sucesso.";
        public const string ProcessingCompleted = $"Processing completed. Updated records: {UpdatedCount} / Processamento concluído. Registros atualizados: {UpdatedCount}.";
        public const string SendedNotification = $"Sended notification for record {RecordId} / Enviado notificação para registro {RecordId}.";        
    }
}
