namespace SmartDigitalPsico.Domain.Constants
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
        public const string RecordsGrouped = $"Records grouped into {GroupCount} groups / Registros agrupados em {GroupCount} grupos.";
        public const string ProcessingGroup = $"Processing group for MedicalId {MedicalId} with {Count} records / Processando grupo para MedicalId {MedicalId} com {Count} registros.";
        public const string RecordProcessed = $"Record {RecordId} processed for update / Registro {RecordId} processado para atualização.";
        public const string ProcessingWithoutCalendar = $"Processing {Count} records without MedicalCalendar / Processando {Count} registros sem MedicalCalendar.";
        public const string RecordUpdated = $"Record {RecordId} updated successfully / Registro {RecordId} atualizado com sucesso.";
        public const string ProcessingCompleted = $"Processing completed. Updated records: {UpdatedCount} / Processamento concluído. Registros atualizados: {UpdatedCount}.";
        public const string SendingNotification = $"Sending notification for record {RecordId} (ScheduledSendTime: {ScheduleTime}) / Enviando notificação para registro {RecordId} (ScheduledSendTime: {ScheduleTime}).";
        public const string UpdatedStatus = $"Record {RecordId} updated status: NextScheduledSendTime={NextTime}, IsCompleted={Completed} / Registro {RecordId} atualizado: NextScheduledSendTime={NextTime}, IsCompleted={Completed}.";
    }
}
