namespace AvtoMigBussines.DTOModels
{
    public class ClientStatisticsDto
    {
        public int NewClientsCount { get; set; } // Количество новых клиентов
        public int ActiveClientsCount { get; set; } // Количество активных клиентов
        public double? AverageCheck { get; set; } // Средний чек клиента
        public double VisitFrequency { get; set; } // Частота посещений
    }
}
