using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Extensions
{
    public static class ScheduleBatchExtensions
    {
        public static void AddScheduleItem(this ScheduleBatch batch, ScheduleItem item)
        {
            // Criar um novo array com tamanho maior para incluir o novo item
            var currentItems = batch.ScheduleData;
            var newItems = new ScheduleItem[currentItems.Length + 1];

            // Copiar os itens existentes
            Array.Copy(currentItems, newItems, currentItems.Length);

            // Adicionar o novo item
            newItems[currentItems.Length] = item;

            // Atualizar o array na entidade
            batch.ScheduleData = newItems;
        }

        public static void RemoveScheduleItem(this ScheduleBatch batch, ScheduleItem item)
        {
            var currentItems = batch.ScheduleData;
            var itemToRemoveIndex = -1;

            // Encontrar o índice do item a ser removido
            for (int i = 0; i < currentItems.Length; i++)
            {
                if (currentItems[i].StartDateTime == item.StartDateTime &&
                    currentItems[i].EndDateTime == item.EndDateTime &&
                    currentItems[i].Title == item.Title)
                {
                    itemToRemoveIndex = i;
                    break;
                }
            }

            // Se encontrou o item, remover
            if (itemToRemoveIndex >= 0)
            {
                var newItems = new ScheduleItem[currentItems.Length - 1];

                // Copiar os itens antes do item a ser removido
                if (itemToRemoveIndex > 0)
                {
                    Array.Copy(currentItems, 0, newItems, 0, itemToRemoveIndex);
                }

                // Copiar os itens depois do item a ser removido
                if (itemToRemoveIndex < currentItems.Length - 1)
                {
                    Array.Copy(currentItems, itemToRemoveIndex + 1, newItems, itemToRemoveIndex, currentItems.Length - itemToRemoveIndex - 1);
                }

                // Atualizar o array na entidade
                batch.ScheduleData = newItems;
            }
        }

        public static void UpdateScheduleItem(this ScheduleBatch batch, ScheduleItem oldItem, ScheduleItem newItem)
        {
            var currentItems = batch.ScheduleData;
            var itemToUpdateIndex = -1;

            // Encontrar o índice do item a ser atualizado
            for (int i = 0; i < currentItems.Length; i++)
            {
                if (currentItems[i].StartDateTime == oldItem.StartDateTime &&
                    currentItems[i].EndDateTime == oldItem.EndDateTime &&
                    currentItems[i].Title == oldItem.Title)
                {
                    itemToUpdateIndex = i;
                    break;
                }
            }

            // Se encontrou o item, atualizar
            if (itemToUpdateIndex >= 0)
            {
                currentItems[itemToUpdateIndex] = newItem;
            }
        }

        public static ScheduleItem[] FilterScheduleItems(this ScheduleBatch batch, DateTime startDate, DateTime endDate)
        {
            return batch.ScheduleData
                .Where(i => i.StartDateTime <= endDate &&
                           (i.EndDateTime ?? i.StartDateTime) >= startDate)
                .ToArray();
        }

        public static ScheduleItem? FindScheduleItem(this ScheduleBatch batch, Func<ScheduleItem, bool> predicate)
        {
            return batch.ScheduleData.FirstOrDefault(predicate);
        }

        public static ScheduleItem[] FindAllScheduleItems(this ScheduleBatch batch, Func<ScheduleItem, bool> predicate)
        {
            return batch.ScheduleData.Where(predicate).ToArray();
        }
    }
} 